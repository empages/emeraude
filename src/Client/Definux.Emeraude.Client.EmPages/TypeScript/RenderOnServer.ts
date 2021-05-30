process.env.VUE_ENV = 'server';

import * as path from 'path';
import * as fs from 'fs';
import * as vueServerRenderer from 'vue-server-renderer';
import * as url from 'url';
import * as domain from 'domain';
import { run as domainTaskRun, baseUrl as domainTaskBaseUrl } from 'domain-task';
import { BootFunc, BootFuncParams, RenderToStringCallback, RenderToStringFunc, RedirectResult, RenderResult } from './PrerenderingInterfaces';

const defaultTimeoutMilliseconds = 30 * 1000;

export const renderToString: RenderToStringFunc = renderToStringImpl;

function renderToStringImpl(callback: RenderToStringCallback, serverBundlePath: string, applicationBasePath: string, absoluteRequestUrl: string, requestPathAndQuery: string, customDataParameter: any, overrideTimeoutMilliseconds: number, requestPathBase: string) {
    try {
        renderViewFunc.apply(null, arguments);
    } catch (ex) {
        callback(ex.stack);
    }
};

function renderViewFunc(callback: RenderToStringCallback, serverBundlePath: string, applicationBasePath: string, absoluteRequestUrl: string, requestPathAndQuery: string, customDataParameter: any, overrideTimeoutMilliseconds: number, requestPathBase: string) {
    const bootFunc = (params: BootFuncParams) => {
        const fullFilePath = path.join(applicationBasePath, params.serverBundlePath);
        const vueRenderer = vueServerRenderer.createBundleRenderer(fullFilePath);

        return new Promise<RenderResult>((resolve, reject) => {
            const context = {
                url: params.url,
                absoluteUrl: params.absoluteUrl,
                baseUrl: params.baseUrl,
                data: params.data,
                domainTasks: params.domainTasks,
                location: params.location,
                origin: params.origin
            };

            vueRenderer.renderToString(context, (error, resultHtml) => {
                if (error) {
                    reject(error.message + " --- " + error.stack);
                }

                resolve({
                    html: resultHtml,
                    globals: {
                        __INITIAL_STATE__: context
                    }
                });
            })
        })
    };

    const serverRenderer = createServerRenderer(bootFunc);
    serverRenderer(callback, serverBundlePath, applicationBasePath, absoluteRequestUrl, requestPathAndQuery, customDataParameter, overrideTimeoutMilliseconds, requestPathBase);
}

function createServerRenderer(bootFunc: BootFunc): RenderToStringFunc {
    const resultFunc = (callback: RenderToStringCallback, serverBundlePath: string, applicationBasePath: string, absoluteRequestUrl: string, requestPathAndQuery: string, customDataParameter: any, overrideTimeoutMilliseconds: number, requestPathBase: string) => {

        let domainTaskCompletionPromiseResolve;
        const domainTaskCompletionPromise = new Promise((resolve, reject) => {
            domainTaskCompletionPromiseResolve = resolve;
        });
        const parsedAbsoluteRequestUrl = url.parse(absoluteRequestUrl);
        const params: BootFuncParams = {
            serverBundlePath: serverBundlePath,
            location: url.parse(requestPathAndQuery, /* parseQueryString */ true),
            origin: parsedAbsoluteRequestUrl.protocol + '//' + parsedAbsoluteRequestUrl.host,
            url: requestPathAndQuery,
            baseUrl: (requestPathBase || '') + '/',
            absoluteUrl: absoluteRequestUrl,
            domainTasks: domainTaskCompletionPromise,
            data: customDataParameter
        };
        const absoluteBaseUrl = params.origin + params.baseUrl;

        domainTaskRun(() => {
            bindPromiseContinuationsToDomain(domainTaskCompletionPromise, domain['active']);
            domainTaskBaseUrl(absoluteBaseUrl);

            const bootFuncPromise = bootFunc(params);
            if (!bootFuncPromise || typeof bootFuncPromise.then !== 'function') {
                callback(`Prerendering failed because the boot function did not return a promise.`, null);
                return;
            }
            const timeoutMilliseconds = overrideTimeoutMilliseconds || defaultTimeoutMilliseconds;
            const bootFuncPromiseWithTimeout = timeoutMilliseconds > 0
                ? wrapWithTimeout(bootFuncPromise, timeoutMilliseconds,
                    `Prerendering timed out after ${timeoutMilliseconds}ms because the boot function `
                    + 'returned a promise that did not resolve or reject. Make sure that your boot function always resolves or '
                    + 'rejects its promise.')
                : bootFuncPromise;

            bootFuncPromiseWithTimeout.then(successResult => {
                callback(null, successResult as RedirectResult);
            }, error => {
                callback(error, null);
            });
        }, errorOrNothing => {
            if (errorOrNothing) {
                callback(errorOrNothing, null);
            } else {
                domainTaskCompletionPromiseResolve();
            }
        });
    };

    resultFunc['isServerRenderer'] = true;

    return resultFunc;
}

function wrapWithTimeout<T>(promise: Promise<T>, timeoutMilliseconds: number, timeoutRejectionValue: any): Promise<T> {
    return new Promise<T>((resolve, reject) => {
        const timeoutTimer = setTimeout(() => {
            reject(timeoutRejectionValue);
        }, timeoutMilliseconds);

        promise.then(
            resolvedValue => {
                clearTimeout(timeoutTimer);
                resolve(resolvedValue);
            },
            rejectedValue => {
                clearTimeout(timeoutTimer);
                reject(rejectedValue);
            }
        )
    });
}

function bindPromiseContinuationsToDomain(promise: Promise<any>, domainInstance: domain.Domain) {
    const originalThen = promise.then;
    promise.then = (function then(resolve, reject) {
        if (typeof resolve === 'function') {
            resolve = domainInstance.bind(resolve);
        }

        if (typeof reject === 'function') {
            reject = domainInstance.bind(reject);
        }

        return originalThen.call(this, resolve, reject);
    }) as any;
}
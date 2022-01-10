import vue from 'rollup-plugin-vue'
import {RUNTIME_INJECTION_BUNDLE_FILE_NAME} from '@emeraude-framework/portal-runtime-injection'
import path from 'path'
import { defineConfig } from 'vite'

module.exports = defineConfig({
    plugins: [vue()],
    build: {
        outDir: path.resolve(__dirname, 'privateroot/portal'),
        emptyOutDir: false,
        lib: {
            entry: path.resolve(__dirname, 'Portal/src/main.js'),
            formats: ['iife'],
            name: RUNTIME_INJECTION_BUNDLE_FILE_NAME,
            fileName: () => RUNTIME_INJECTION_BUNDLE_FILE_NAME
        },
        rollupOptions: {
            external: ['vue'],
            output: {
                globals: {
                    vue: 'Vue'
                }
            }
        }
    }
})
import Vue from 'vue';
import Router from 'vue-router';
import store from '../store/index';
import { routes } from './routes';
import { useEmPageInterceptors } from 'emeraude-initial-state-processors';

Vue.use(Router);

let router = new Router({
    mode: 'history',
    routes
});

useEmPageInterceptors(router, store);

export default router;
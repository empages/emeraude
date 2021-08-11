import Vue from 'vue';
import VueRouter from 'vue-router';
import BootstrapVue from 'bootstrap-vue';
import axios from 'axios';

import './assets/style.scss';

import Scaffold from './pages/scaffold/Scaffold.vue';
import Endpoints from './pages/endpoints/Endpoints.vue';
import Languages from './pages/languages/Languages.vue';
import Translations from './pages/translations/Translations.vue';
import StaticContent from './pages/static-content/StaticContent.vue';

import App from './App.vue';

Vue.use(VueRouter);
Vue.use(BootstrapVue);

Vue.prototype.$http = axios;

const router = new VueRouter({
    routes: [
        { name: 'scaffold', path: '/admin/client-builder/scaffold', component: Scaffold },
        { name: 'endpoints', path: '/admin/client-builder/endpoints', component: Endpoints },
        { name: 'languages', path: '/admin/client-builder/languages', component: Languages },
        { name: 'translations', path: '/admin/client-builder/translations', component: Translations },
        { name: 'static-content', path: '/admin/client-builder/static-content', component: StaticContent }
    ],
    mode: 'history'
});

new Vue({
    el: '#client-builder-app',
    render: h => h(App),
    router
});
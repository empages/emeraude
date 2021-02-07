import Vue from 'vue';
import router from './router';
import store from './store';
import i18n from './locales/i18n';
import BootstrapVue from 'bootstrap-vue';
import App from './App.vue';

Vue.use(BootstrapVue);

const app = new Vue({
    i18n,
    router,
    store,
    render: h => h(App)
});

export { app, router, store };
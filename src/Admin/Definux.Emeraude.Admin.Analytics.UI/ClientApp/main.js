import Vue from 'vue';
import axios from 'axios';
import BootstrapVue from 'bootstrap-vue';

import App from './App.vue';

Vue.use(BootstrapVue);

Vue.prototype.$http = axios;

new Vue({
    el: '#analytics-app',
    render: h => h(App)
});
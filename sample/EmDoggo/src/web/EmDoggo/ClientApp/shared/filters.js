import Vue from 'vue';
import { formatDate, formatTime } from "../utils/helpers";

Vue.filter('date', function (value) {
    return formatDate(value);
});

Vue.filter('time', function (value) {
    return formatTime(value);
});
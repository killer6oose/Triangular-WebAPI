window._ = require('lodash');

window.axios = require('axios');

import Vue from 'vue';
import TriangleCalculator from './components/TriangleCalculator.vue';

new Vue({
    el: '#app',
    components: { TriangleCalculator }
});
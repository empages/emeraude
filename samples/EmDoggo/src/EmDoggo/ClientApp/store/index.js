import Vue from 'vue';
import Vuex from 'vuex';

Vue.use(Vuex);

const getters = {
};

const mutations = {
    SET_DATA(state, value) {
        state.data = value;
    },
};

const actions = {
    updateData(context, value) {
        context.commit('SET_DATA', value);
    },
};

const store = new Vuex.Store({
    getters,
    mutations,
    actions
});

export default store;
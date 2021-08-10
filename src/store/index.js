import { createStore } from 'vuex'

export default createStore({
  state: {
    isWordShow: false,
  },
  mutations: {
    show(state){
      state.isWordShow = true;
    },
    hide(state){
      state.isWordShow = false;
    }
  },
  actions: {
    show({commit}){
      commit('show')
    },
    hide({commit}){
      commit('hide')
    }
  },
  getters: {
    showWord(state){
      return state.isWordShow
    }
  }
})

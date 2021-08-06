import { createRouter, createWebHistory } from 'vue-router'
import Home from '../views/Home.vue'

const routes = [
  {
    path: '/',
    name: 'Home',
    component: Home
  },
  {
    path: '/login',
    name: 'Login',
    component: () => import('../views/Login.vue')
  },
  {
    path: '/chi',
    name: 'Chi',
    component: () => import('../views/_Chi.vue')
  },
  {
    path: '/cyuan',
    name: 'Cyuan',
    component: () => import('../views/_Cyuan.vue')
  },
  {
    path: '/eric',
    name: 'Eric',
    component: () => import('../views/_Eric.vue')
  },
  {
    path: '/become-a-host',
    name: 'become-a-host',
    component: () => import('../views/Eric/NewHouse.vue')
  },
  {
    path: '/heather',
    name: 'Heather',
    component: () => import('../views/_Heather.vue')
  },
  {
    path: '/howard',
    name: 'Howard',
    component: () => import('../views/_Howard.vue')
  },
  {
    path: '/yuan',
    name: 'Yuan',
    component: () => import('../views/_Yuan.vue')
  },
]

const router = createRouter({
  history: createWebHistory(process.env.BASE_URL),
  routes
})

export default router

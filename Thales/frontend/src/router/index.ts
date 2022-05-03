import { createRouter, createWebHashHistory } from 'vue-router';
import type { RouteRecordRaw } from 'vue-router'

import Home from '../views/Home.vue';
import Novel from '../views/Novel.vue';
import Author from '../views/Author.vue';

const routes: Array<RouteRecordRaw> = [
    {
        path: '/',
        name: 'Home',
        component: Home
    },
    {
        path: '/novel',
        name: 'Novel',
        component: Novel
    },
    {
        path: '/author',
        name: 'Author',
        component: Author
    }
];

const router = createRouter({
    history: createWebHashHistory(),
    routes
});

export default router;
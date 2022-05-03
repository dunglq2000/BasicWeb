import { createApp } from 'vue'
import BootstrapVue from 'bootstrap-vue'
import App from './App.vue'
import router from './router';

createApp(App)
    .use(router)
    .mount('#app')

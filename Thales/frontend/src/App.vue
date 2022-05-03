<script lang="ts">
import { defineComponent } from "vue";
import Novel  from './views/Novel.vue';
import Header from './views/Header.vue'
import Footer from './views/Footer.vue'

import 'bootstrap/dist/css/bootstrap.css'
import 'bootstrap-vue/dist/bootstrap-vue.css'

export default defineComponent({
    components: { 
      Header,
      Novel,
      Footer },
})
</script>

<template>
  <Header />
  <Novel />
  <router-view></router-view>
</template>
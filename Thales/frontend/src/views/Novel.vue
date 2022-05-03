<script lang="ts">
import { getNovels, getAuthors, postNovel } from '../services/novelAPI';
import type { Novel, Author } from '@/services/novelAPI';

import { defineComponent } from 'vue';

export default defineComponent({
    name: 'Novel',
    created() {
        this.init();
    },
    data() {
        return {
            novels: [] as Novel[],
            authors: [] as Author[],
            title: null as string | null,
            authorId: 1 as number
        }
    },
    methods: {
        async init() {
            this.novels = await getNovels();
            this.authors = await getAuthors();
        },
        getAuthorName(authorId: number) {
          const author = this.authors.find(p => p.authorId == authorId);
          if (author) {
            return author.lastName + " " + author.firstMidName;
          } else {
            console.log(author);
            return null;
          }
        },
        async add() {
          if (this.title != null)
          {
            const newNovel = await postNovel(this.title, this.authorId);
          }
        }
    }
})
</script>

<template>
<table class="table">
  <thead class="thead-dark">
    <tr>
      <th scope="col">Novel ID</th>
      <th scope="col">Title</th>
      <th scope="col">Author ID</th>
      <th scope="col">Author Name</th>
    </tr>
  </thead>
  <tbody>
    <tr v-for="novel in novels">
      <th scope="row">{{ novel.novelId }}</th>
      <td scope="col">{{ novel.title }}</td>
      <td scope="col">{{ novel.authorId }}</td>
      <td scope="col">{{ getAuthorName(novel.authorId) }}</td>
    </tr>
  </tbody>
</table>

<div>
  <input type="string" v-model="title" placeholder="ABCD">
  <input type="number" v-model="authorId" placeholder="1">
  <button @click="add()">Submit</button>
</div>
</template>
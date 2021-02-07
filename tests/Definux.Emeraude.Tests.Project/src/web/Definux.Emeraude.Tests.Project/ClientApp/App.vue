<template>
    <div class="h-100 w-100 d-flex">
        <router-view></router-view>
    </div>
</template>

<script>
    import { initialStateMixin } from 'emeraude-initial-state-processors';
    export default {
        data() {
          return {
          }
        },
        mixins: [initialStateMixin],
        mounted() {

        }
    }
</script>
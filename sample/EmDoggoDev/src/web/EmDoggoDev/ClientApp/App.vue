<template>
    <div class="h-100">
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
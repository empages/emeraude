<template>
    <div>
        <hr />
        <div class="responsive-table">
            <b-table striped hover :items="pages" :fields="fields">
            </b-table>
        </div>
    </div>
</template>

<script>
    import { bootstrapTableFields } from '../../utilities/helpers.js';
    export default {
        data() {
            return {
                fields: bootstrapTableFields(
                    'id',
                    'name',
                    'route',
                    'authorized'
                ),
                pages: [],
            }
        },
        methods: {
            loadPages() {
                let self = this;
                this.$http.get('/api/client-builder/pages')
                    .then(response => {
                        self.pages = response.data;
                    })
                    .catch(error => {
                        console.log(error);
                    });
            },
        },
        mounted() {
            this.loadPages();
        }
    }
</script>
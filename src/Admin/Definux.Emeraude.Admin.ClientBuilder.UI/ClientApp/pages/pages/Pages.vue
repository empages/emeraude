<template>
    <div class="client-builder-page">
        <b-card class="main-card" title="EmPages list" sub-title="List of all SSR pages implemented by the classes that inherit EmPage abstract class.">
            <hr class="w-100"/>
            <div class="responsive-table">
                <b-table striped hover :items="pages" :fields="fields">
                    <template v-slot:cell(authorized)="data">
                        <b-form-checkbox v-model="data.item.authorized" :disabled="true">
                        </b-form-checkbox>
                    </template>
                    <template v-slot:cell(actions)="data">
                        <a :href="data.item.route" class="btn btn-icons btn-primary" target="_blank" title="Visit"><i class="mdi mdi-web"></i></a>
                    </template>
                </b-table>
            </div>
        </b-card>
    </div>
</template>

<script>
    import { bootstrapTableFields } from '../../utilities/helpers.js';
    export default {
        data() {
            return {
                fields: bootstrapTableFields(
                    'name',
                    'route',
                    'authorized',
                    'actions'
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
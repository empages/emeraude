<template>
    <div>
        <hr />
        <div class="responsive-table">
            <b-table striped hover :items="endpoints" :fields="fields">
            </b-table>
        </div>
    </div>
</template>
<script>
    import { bootstrapTableFields } from '../../utilities/helpers.js';
    export default {
        name: "Endpoints",
        data() {
            return {
                fields: bootstrapTableFields(
                    'id',
                    'controllerName',
                    'actionName',
                    'route',
                    'methodName'
                ),
                endpoints: []
            };
        },
        methods: {
            loadEndpoints() {
                let self = this;
                this.$http.get('/api/client-builder/endpoints')
                    .then(response => {
                        self.endpoints = response.data;
                    })
                    .catch(error => {
                        console.log(error);
                    });
            }
        },
        mounted() {
            this.loadEndpoints();
        }
    }
</script>
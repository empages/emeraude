<template>
    <div>
        <hr />
        <b-card no-body class="bg-dark">
            <b-card-title class="p-3 m-0 text-white" title="Add language" title-tag="p"></b-card-title>
            <b-card-body class="p-2">
                <div class="row m-0">
                    <div class="form-group col px-1">
                        <input class="form-control"
                               v-model="newLanguage.code"
                               placeholder="Code" />
                    </div>
                    <div class="form-group col px-1">
                        <input class="form-control"
                               v-model="newLanguage.name"
                               placeholder="Name" />
                    </div>
                    <div class="form-group col px-1">
                        <input class="form-control"
                               v-model="newLanguage.nativeName"
                               placeholder="Native Name" />
                    </div>
                    <div class="form-group col-1 px-1">
                        <button class="btn btn-primary w-100 h-100" @click="addNewLanguage">Add</button>
                    </div>
                </div>
            </b-card-body>
        </b-card>
        <hr />
        <b-table striped hover :items="languages" :fields="fields">
            <template v-slot:cell(default)="data">
                <button v-if="!data.item.isDefault"
                        type="button"
                        @click="makeLanguageDefault(data.item.id)"
                        class="btn btn-icons action-btn btn-primary p-1"
                        title="Make Default">
                    <i class="mdi mdi-select"></i>
                </button>
                <button v-else
                        disabled
                        type="button"
                        class="btn btn-icons action-btn btn-ForestGreen p-1"
                        title="Default">
                    <i class="mdi mdi-checkbox-marked-outline"></i>
                </button>
            </template>
            <template v-slot:cell(actions)="data">
                <b-button @click="deleteLanguage(data.item.id)" variant="danger" class="btn btn-icons"><i class="mdi mdi-delete-forever"></i></b-button>
            </template>
        </b-table>
    </div>
</template>

<script>
    import { bootstrapTableFields } from '../../utilities/helpers.js';
    export default {
        data() {
            return {
                fields: bootstrapTableFields(
                    'code',
                    'name',
                    'nativeName',
                    'default',
                    'actions'
                ),
                languages: [],
                newLanguage: {
                    code: '',
                    name: '',
                    nativeName: ''
                }
            };
        },
        methods: {
            addNewLanguage() {
                let self = this;
                this.$http.post('/api/client-builder/languages', this.newLanguage)
                    .then(() => {
                        self.loadLanguages();
                        self.newLanguage = {
                            code: '',
                            name: '',
                            nativeName: ''
                        };
                    })
                    .catch(error => {
                        console.log(error);
                    })
            },
            loadLanguages() {
                let self = this;
                this.$http.get('/api/client-builder/languages')
                    .then(response => {
                        self.languages = response.data;
                    })
                    .catch(error => {
                        console.log(error);
                    })
            },
            makeLanguageDefault(languageId) {
                let self = this;
                this.$http.post('/api/client-builder/languages/default', {
                    value: languageId
                })
                    .then(response => {
                        self.loadLanguages();
                    })
                    .catch(error => {
                        console.log(error);
                    })
            },
            deleteLanguage(languageId) {
                let self = this;
                this.$bvModal.msgBoxConfirm('By clicking the \'Yes\' button you will delete the selected language and its translations.', {
                    title: 'Are you sure you want to delete this language?',
                    size: 'md',
                    okVariant: 'danger',
                    cancelVariant: 'primary',
                    okTitle: 'DELETE',
                    cancelTitle: 'CANCEL',
                    headerClass: 'p-2 border-bottom-0',
                    footerClass: 'p-2 border-top-0',
                    centered: true
                })
                    .then(value => {
                        if (value) {
                            this.$http.delete('/api/client-builder/languages/' + languageId)
                                .then(response => {
                                    self.loadLanguages();
                                })
                                .catch(error => {
                                    console.log(error);
                                });
                        }
                    })
            },
        },
        mounted() {
            this.loadLanguages();
        }
    }
</script>
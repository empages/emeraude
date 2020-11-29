<template>
    <div class="client-builder-page">
        <b-card class="main-card" title="Translations list" sub-title="List of all translations defined by key and translations stored into the localization content. To create a new one use the form placed on the top of the page.">
            <hr class="w-100" />
            <div class="row m-0">
                <div class="form-group col px-1">
                    <input class="form-control"
                           v-model="newKey.key"
                           @keypress="isValidKeyValue"
                           @input="newKey.key = transformKeyInput($event)"
                           placeholder="Key" />
                </div>
                <div class="form-group col px-1" v-for="(language, languageIndex) in languages" :key="'LanguageInput' + language.code">
                    <input class="form-control" v-model="newKey.values[languageIndex].value" :placeholder="'Translation in ' + language.name" />
                </div>
                <div class="form-group col-1 px-1">
                    <button class="btn btn-primary w-100 h-100" @click="createKey">Add</button>
                </div>
            </div>
            <hr />
            <input v-model="filterString" class="form-control" placeholder="Filter by key or value" />
            <hr />
            <div>
                <div v-if="gridData.length == 0" class="text-center">
                    <i class="mdi mdi-24px mdi-spin mdi-loading"></i>
                </div>
                <div v-else>
                    <table class="table table-hover table-striped">
                        <thead>
                            <tr class="text-center border">
                                <th class="p-1 pb-2">
                                    <strong>Key</strong>
                                </th>
                                <th class="p-1 pb-2" v-for="language in languages" :key="'Language' + language.code">
                                    <strong>{{language.nativeName}}</strong>
                                </th>
                                <th class="p-1 pb-2"></th>
                            </tr>
                        </thead>
                        <tbody>
                            <key-row v-for="(dataItem, dataItemIndex) in filteredData"
                                     :key="'DataItem' + dataItemIndex"
                                     :data="dataItem"
                                     :reloadCallback="loadGridData"></key-row>
                        </tbody>
                    </table>
                </div>
            </div>
        </b-card>
    </div>
</template>

<script>
    import inputMixin from '../../mixins/inputMixin.js';
    import KeyRow from './components/KeyRow';
    export default {
        name: 'Translations',
        components: {
            'key-row': KeyRow
        },
        mixins: [inputMixin],
        data() {
            return {
                gridData: [],
                filterString: '',
                languages: [],
                newKey: {
                    key: '',
                    values: []
                }
            }
        },
        computed: {
            filteredData() {
                let self = this;
                return this.gridData.filter((obj) => {
                    return obj.key.toLowerCase().includes(self.filterString.toLowerCase()) || (obj.languageValues.filter((innerObj) => {
                        return innerObj.value.toLowerCase().includes(self.filterString.toLowerCase());
                    })).length > 0;
                });
            }
        },
        methods: {
            loadGridData() {
                let self = this;
                this.$http.get('/api/client-builder/languages/grid-data')
                    .then(response => {
                        self.gridData = response.data.items;
                    })
                    .catch(error => {
                        console.log(error);
                    });
            },
            initEmptyTranslations() {
                for (var i = 0; i < this.languages.length; i++) {
                    this.newKey.values.push({
                        languageId: this.languages[i].id,
                        languageCode: this.languages[i].code,
                        value: ''
                    });
                }
            },
            loadLanguages() {
                let self = this;
                this.$http.get('/api/client-builder/languages')
                    .then(response => {
                        self.languages = response.data;
                        self.initEmptyTranslations();
                    })
                    .catch(error => {
                        console.log(error);
                    })
            },
            createKey() {
                let self = this;
                this.$http.post('/api/client-builder/languages/keys', this.newKey)
                    .then(response => {
                        self.$bvToast.toast('The new key has been added.', {
                            title: 'New Key Operation',
                            autoHideDelay: 1500,
                            variant: 'success',
                            solid: true
                        });

                        self.loadGridData();
                        self.newKey = {
                            key: '',
                            values: []
                        };
                        self.initEmptyTranslations();
                    })
                    .catch(error => {
                        self.$bvToast.toast('The new key has not been added.', {
                            title: 'New Key Operation',
                            autoHideDelay: 1500,
                            variant: 'danger',
                            solid: true
                        });
                    });
            },
        },
        mounted() {
            this.loadLanguages();
            this.loadGridData();
        },
        watch: {
            filterString() {
                this.$forceUpdate();
            }
        }
    }
</script>
<template>
    <div>
        <b-row>
            <b-col cols="6">
                <b-card no-body class="overflow-hidden h-100">
                    <b-row no-gutters>
                        <b-col cols="4">
                            <b-card-img src="/admin/images/vuejs.jpg" class="rounded-0"></b-card-img>
                        </b-col>
                        <b-col cols="8">
                            <b-card-body title="Web Modules">
                                <b-card-text>
                                    This module generate all VueJs modules in the order specified from the system. After generation a WebPack build is a required action.
                                </b-card-text>
                                <button class="btn btn-primary" @click="generateWebModules">Generate</button>
                            </b-card-body>
                        </b-col>
                    </b-row>
                </b-card>
            </b-col>
            <b-col cols="6">
                <b-card no-body class="overflow-hidden h-100">
                    <b-row no-gutters>
                        <b-col cols="4">
                            <b-card-img src="/admin/images/xamarin.jpg" class="rounded-0"></b-card-img>
                        </b-col>
                        <b-col cols="8">
                            <b-card-body title="Mobile Modules">
                                <b-card-text>
                                    This module generate all Xamarin modules in the order specified from the system. After generation the a Xamarin project build is a required action.
                                </b-card-text>
                                <button class="btn btn-primary" @click="generateMobileModules">Generate</button>
                            </b-card-body>
                        </b-col>
                    </b-row>
                </b-card>
            </b-col>
        </b-row>
        <hr />
        <div>
            <div class="responsive-table">
                <b-table striped hover :items="modules" :fields="fields" v-if="modules.length > 0">
                    <template v-slot:cell(name)="data">
                        <span>{{data.item.name}}</span>
                    </template>
                    <template v-slot:cell(type)="data">
                        <span class="badge" :class="{
                             'badge-primary' : data.item.type === 1,
                             'badge-info' : data.item.type === 2 }">
                            <i class="mdi" :class="{
                             'mdi-desktop-mac' : data.item.type === 1,
                             'mdi-cellphone' : data.item.type === 2 }">
                            </i>
                        </span>
                    </template>
                    <template v-slot:cell(generated)="data">
                        <b-form-checkbox v-model="data.item.generated" :disabled="true">
                        </b-form-checkbox>
                    </template>
                    <template v-slot:cell(locked)="data">
                        <b-form-checkbox v-model="data.item.locked" :disabled="true">
                        </b-form-checkbox>
                    </template>
                    <template v-slot:cell(actions)="data">
                        <button type="button" class="btn btn-icons btn-primary" @click="generate(data.item)" title="Generate"><i class="mdi mdi-flash"></i></button>
                    </template>
                </b-table>
            </div>
        </div>
    </div>
</template>

<script>
    import { bootstrapTableFields } from '../../utilities/helpers.js';
    export default {
        data() {
            return {
                modules: [],
                fields: bootstrapTableFields(
                    'name',
                    'type',
                    'generated',
                    'locked',
                    'actions'
                ),
            }
        },
        methods: {
            loadModules() {
                let self = this;
                this.$http.get('/api/client-builder/scaffold/modules')
                    .then(response => {
                        self.modules = response.data;
                    })
                    .catch(error => {
                        console.log(error);
                    });
            },
            generate(module) {
                let self = this;
                this.$http.post('/api/client-builder/scaffold/generate', {
                    moduleId: module.id
                })
                    .then(response => {
                        self.$bvToast.toast(module.name + ' has been generated successfully.', {
                            title: 'Generation Completed',
                            autoHideDelay: 3000,
                            variant: 'success',
                            solid: true
                        });
                        self.loadModules();
                    })
                    .catch(error => {
                        self.$bvToast.toast(error.response.data, {
                            title: 'Generation Failed',
                            autoHideDelay: 3000,
                            variant: 'danger',
                            solid: true
                        });
                    });
            },
            generateWebModules() {
                let self = this;
                this.$http.post('/api/client-builder/scaffold/generate/web', {})
                    .then(response => {
                        self.$bvToast.toast('Web modules have been generated successfully.', {
                            title: 'Generation Completed',
                            autoHideDelay: 3000,
                            variant: 'success',
                            solid: true
                        });
                        self.loadModules();
                    })
                    .catch(error => {
                        self.$bvToast.toast(error.response.data, {
                            title: 'Generation Failed',
                            autoHideDelay: 3000,
                            variant: 'danger',
                            solid: true
                        });
                    });
            },
            generateMobileModules() {
                let self = this;
                this.$http.post('/api/client-builder/scaffold/generate/mobile', {})
                    .then(response => {
                        self.$bvToast.toast('Mobile modules have been generated successfully.', {
                            title: 'Generation Completed',
                            autoHideDelay: 3000,
                            variant: 'success',
                            solid: true
                        });
                        self.loadModules();
                    })
                    .catch(error => {
                        self.$bvToast.toast(error.response.data, {
                            title: 'Generation Failed',
                            autoHideDelay: 3000,
                            variant: 'danger',
                            solid: true
                        });
                    });
            }
        },
        mounted() {
            this.loadModules();
        }
    }
</script>
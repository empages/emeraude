<template>
    <div class="client-builder-page">
        <b-card class="main-card" title="Modules generation" sub-title="By click the button all modules from selected section will be generated.">
            <hr class="w-100" />
            <b-row>
                <b-col cols="12" class="mb-4">
                    <h5>By instance type</h5>
                    <b-row no-gutters>
                        <button class="btn btn-primary cb-gen-btn" v-if="hasWebModules" @click="generateWebModules"><i class="mdi mdi-desktop-mac"></i> Web Modules</button>
                        <button class="btn btn-primary cb-gen-btn" v-if="hasMobileModules" @click="generateMobileModules"><i class="mdi mdi-cellphone"></i> Mobile Modules</button>
                    </b-row>
                </b-col>
                <b-col cols="12">
                    <h5>By parent type</h5>
                    <b-row no-gutters>
                        <button class="btn btn-primary cb-gen-btn" v-for="(uniqueModule, uniqueModuleIdIndex) in uniqueModulesByParent" :key="uniqueModule.parentModuleId" @click="generateModules(uniqueModule.parentModuleId)"><img :src="'data:image/png;base64, ' + uniqueModule.icon" class="cb-gen-btn-img" /> <span class="cb-gen-btn-text">{{ uniqueModule.scaffoldTypeName }} Modules</span></button>
                    </b-row>
                </b-col>
            </b-row>
        </b-card>
        <hr />
        <div>
            <div class="responsive-table">
                <b-table striped hover :items="modules" :fields="fields" v-if="modules.length > 0">
                    <template v-slot:cell(icon)="data">
                        <img class="table-row-icon" :src="'data:image/png;base64, ' + data.item.icon" />
                    </template>
                    <template v-slot:cell(name)="data">
                        <span>{{data.item.name}}</span>
                    </template>
                    <template v-slot:cell(type)="data">
                        <span class="badge" :class="{
                             'badge-dark' : data.item.type === 0,
                             'badge-primary' : data.item.type === 1,
                             'badge-info' : data.item.type === 2 }">
                            <i class="mdi" :class="{
                             'mdi-sticker-outline' : data.item.type === 0,
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
                        <button type="button" class="btn btn-icons btn-primary" @click="generate(data.item)" title="Generate"><i class="mdi mdi-play-speed"></i></button>
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
                    'icon',
                    'name',
                    'type',
                    'generated',
                    'locked',
                    'actions'
                ),
            }
        },
        computed: {
            hasWebModules() {
                return this.modules.filter(x => x.type == 1).length > 0;
            },
            hasMobileModules() {
                return this.modules.filter(x => x.type == 2).length > 0;
            },
            uniqueModulesIdsByParent() {
                if (this.modules != null && this.modules.length > 0) {
                    return this.modules.map(x => x.parentModuleId).filter((value, index, self) => {
                        return self.indexOf(value) === index;
                    });
                }

                return [];
            },
            uniqueModulesByParent() {
                let modules = [];
                for (let i = 0; i < this.uniqueModulesIdsByParent.length; i++) {
                    modules.push(this.getDefaultModuleByParentModuleId(this.uniqueModulesIdsByParent[i]))
                }

                return modules;
            }
        },
        methods: {
            getDefaultModuleByParentModuleId(parentModuleId) {
                if (this.modules != null && this.modules.length > 0) {
                    let currentModules = this.modules.filter(x => x.parentModuleId == parentModuleId);
                    if (currentModules.length > 0) {
                        return currentModules[0];
                    }
                }

                return null;
            },
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
            generateModules(parentModuleId) {
                let self = this;
                this.$http.post('/api/client-builder/scaffold/generate/' + parentModuleId, {})
                    .then(response => {
                        self.$bvToast.toast('Modules have been generated successfully.', {
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
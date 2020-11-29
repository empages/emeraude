<template>
    <layout>
        <div>
            <b-row>
                <b-col md="6">
                    <b-form-group :label="$t('NAME')">
                        <b-input v-model="newDog.name"/>
                    </b-form-group>
                    <b-form-group :label="$t('DOG_TYPE')">
                        <enum-b-select v-model="newDog.type" enumType="EmDoggo.Domain.Common.DogType"></enum-b-select>
                    </b-form-group>
                    <b-form-group :label="$t('DOG_BREED')">
                        <enum-b-select v-model="newDog.breed" enumType="EmDoggo.Domain.Common.DogBreed"></enum-b-select>
                    </b-form-group>
                    <b-button variant="primary" @click="addDog">{{$t('ADD')}}</b-button>
                </b-col>
                <b-col>
                    <b-row>
                        <b-col md="6" class="mb-2" v-for="dog in dogs" :key="dog.id">
                            <b-card :title="dog.name" class="text-center">
                                <h1 class="mdi mdi-dog"></h1>
                            </b-card>
                        </b-col>
                    </b-row>
                </b-col>
            </b-row>
        </div>
    </layout>
</template>

<script>
    import Layout from '../../layouts/Layout';
    import EnumBSelect from "../../components/forms/EnumBSelect";
    import {dogsServiceAgent} from "../../api/endpoints";
    export default {
        name: "Dogs",
        components: {
            Layout,
            EnumBSelect
        },
        data() {
            return {
                newDog: {
                    name: '',
                    type: 1,
                    breed: 1
                }
            };
        },
        computed: {
            dogs() {
                if (this.$store.getters.viewModel.dogs !== undefined) {
                    return this.$store.getters.viewModel.dogs;
                }

                return [];
            }
        },
        methods: {
            addDog() {
                let self = this;
                dogsServiceAgent.addDog(self.newDog)
                    .then(() => {
                        location.reload();
                    })
                    .catch(error => {
                        console.log(error);
                    })
            },
            resetNewDog() {
                this.newDog = {
                    name: '',
                    type: 1,
                    breed: 1
                }
            }
        },
        mounted() {

        }
    }
</script>

<style scoped>

</style>
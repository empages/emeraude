<template>
    <layout>
        <b-row>
            <b-col md="4" class="h-100" v-for="shop in shops" :key="shop.id">
                <b-card :title="shop.name" :sub-title="$t('OFFERS')">
                    <ul>
                        <li v-for="food in shop.foods" :key="food.id">{{food.food.name}}</li>
                    </ul>
                </b-card>
            </b-col>
        </b-row>
    </layout>
</template>

<script>
    import Layout from '../../layouts/Layout';
    export default {
        name: "Shops",
        components: {
            Layout
        },
        data() {
            return {

            };
        },
        computed: {
            shops() {
                if (this.$store.getters.viewModel.shops !== undefined) {
                    return this.$store.getters.viewModel.shops;
                }

                return [];
            }
        },
        methods: {

        },
        mounted() {

        }
    }
</script>

<style scoped>

</style>
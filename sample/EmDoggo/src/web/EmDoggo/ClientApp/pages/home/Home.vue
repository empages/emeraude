<template>
    <layout>
        <div>
            <home-page-static-content :language-id="languageId"/>
        </div>
    </layout>
</template>

<script>
    import Layout from '../../layouts/Layout';
    import HomePageStaticContent from "../../components/static-content/HomePageStaticContent";
    import generalMixin from "../../mixins/general/generalMixin";
    export default {
        name: "Home",
        components: {
          Layout,
            HomePageStaticContent
        },
        mixins: [generalMixin],
        data() {
            return {

            };
        },
        computed: {
            languageId() {
                return this.$store.getters.languageId;
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
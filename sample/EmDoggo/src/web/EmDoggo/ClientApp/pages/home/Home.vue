<template>
    <layout>
        <div>
            <home-page-static-content :language-id="languageId"/>
        </div>
        <div class="my-2">
          <b-button @click="invokeError">{{ $t('INVOKE_ERROR') }}</b-button>
        </div>
    </layout>
</template>

<script>
    import Layout from '../../layouts/Layout';
    import HomePageStaticContent from "../../components/static-content/HomePageStaticContent";
    import generalMixin from "../../mixins/general/generalMixin";
    import {loggerServiceAgent} from "../../api/endpoints";
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
          invokeError() {
            fetch('/some-not-existed-path', {
              method: 'GET',
              headers: { 'Content-Type': 'application/json', 'Accept': 'application/json' },
              credentials: 'include'
            })
            .then(response => response.json())
            .then(data => {
              console.log(data);
            })
            .catch(error => this.logError(error, 'invokeError'))
          }
        },
        mounted() {

        }
    }
</script>

<style scoped>

</style>
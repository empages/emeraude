<template>
    <div class="d-flex flex-column flex-md-row align-items-center p-3 px-md-4 mb-3 bg-white border-bottom box-shadow">
        <h5 class="my-0 mr-md-auto font-weight-normal"><img class="navbar-logo" src="/assets/images/dogapp_logo_text.png"/></h5>
        <nav class="my-2 my-md-0 mr-md-3">
            <router-link class="p-2 text-dark" :to="getRoute('/')">{{$t('HOME')}}</router-link>
            <router-link class="p-2 text-dark" :to="getRoute('/dogs')">{{$t('DOGS')}}</router-link>
            <router-link class="p-2 text-dark" :to="getRoute('/shops')">{{$t('SHOPS')}}</router-link>
            <a class="ml-2 btn btn-primary" :href="languageReverseLink">{{$t('SWITCH_TO')}} {{$t(languageReverseName)}}</a>
        </nav>
        <a v-if="!isAuthenticated" class="btn btn-outline-primary" :href="getRoute('/login')">{{$t('LOGIN')}}</a>
        <form v-else method="post" action="/logout">
            <b-button variant="primary" type="submit">{{$t('LOGOUT')}}</b-button>
        </form>
    </div>
</template>

<script>
    import generalMixin from "../mixins/general/generalMixin";

    export default {
        mixins: [generalMixin],
        computed: {
            isAuthenticated() {
                if (this.$store.getters.user !== undefined) {
                    return this.$store.getters.user.isAuthenticated;
                }

                return false;
            },
            userName() {
                if (this.$store.getters.user !== undefined) {
                    return this.$store.getters.user.name.split(" ")[0];
                }

                return '';
            },
            stateString() {
                return this.$store.getters.stateString;
            },
            languageReverseLink() {
                let languageCode = this.$route.params.lang ?? 'en';
                if (languageCode === 'en') {
                    return '/bg';
                }
                else if (languageCode === 'bg') {
                    return '/';
                }
                else {
                    return '/bg';
                }
            },
            languageReverseName() {
                let languageCode = this.$route.params.lang ?? 'en';
                if (languageCode === 'en') {
                    return 'BULGARIAN';
                }
                else if (languageCode === 'bg') {
                    return 'ENGLISH';
                }
                else {
                    return 'BULGARIAN';
                }
            }
        },
        methods: {

        }
    }
</script>

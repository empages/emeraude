<template>
    <div class="card p-3">
        <ul class="nav nav-tabs tab-basic">
            <li class="nav-item">
                <router-link to="/admin/client-builder/scaffold" active-class="active" class="nav-link"><i class="mdi mdi-arrow-right-drop-circle"></i> Scaffold</router-link>
            </li>
            <li class="nav-item">
                <router-link to="/admin/client-builder/pages" active-class="active" class="nav-link"><i class="mdi mdi-cellphone-link"></i> Pages</router-link>
            </li>
            <li class="nav-item">
                <router-link to="/admin/client-builder/endpoints" active-class="active" class="nav-link"><i class="mdi mdi-cloud-braces"></i> Endpoints</router-link>
            </li>
            <li class="nav-item">
                <router-link to="/admin/client-builder/languages" active-class="active" class="nav-link"><i class="mdi mdi-comment-processing"></i> Languages</router-link>
            </li>
            <li class="nav-item">
                <router-link to="/admin/client-builder/translations" active-class="active" class="nav-link"><i class="mdi mdi-translate"></i> Translations</router-link>
            </li>
            <li class="nav-item">
                <router-link to="/admin/client-builder/static-content" active-class="active" class="nav-link"><i class="mdi mdi-format-float-left"></i> Static Content</router-link>
            </li>
        </ul>
        <div>
            <router-view class="view-content"></router-view>
        </div>
    </div>
</template>

<script>
    export default {
        name: 'App',
    }
</script>
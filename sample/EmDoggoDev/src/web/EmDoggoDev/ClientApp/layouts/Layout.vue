<template>
    <div class="base-page">
        <top-navbar />
        <div class="container">
            <slot></slot>
        </div>
        <layout-footer />
    </div>
</template>
<script>
    import TopNavbar from "./Navbar";
    import LayoutFooter from "./Footer";
    export  default {
        data() {
            return {}
        },
        components: {
            TopNavbar,
            LayoutFooter
        }
    }
</script>
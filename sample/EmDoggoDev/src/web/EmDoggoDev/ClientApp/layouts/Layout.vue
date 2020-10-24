<template>
    <div>
        <div class="p-3">
            <top-navbar></top-navbar>
            <div>
                <slot></slot>
            </div>
            <layout-footer></layout-footer>
        </div>
    </div>
</template>
<script>
    import TopNavbar from "./Navbar";
    import LayoutFooter from "./Footer";
    export default {
        data() {
            return {}
        },
        components: {
            TopNavbar,
            LayoutFooter
        }
    }
</script>
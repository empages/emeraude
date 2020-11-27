<template>
    <div>
        <b-select v-model="value" @input="updateValue">
            <b-select-option :value="option.value" v-for="(option, index) in options" :key="enumType + index">{{option.translatedValue}}</b-select-option>
        </b-select>
    </div>
</template>

<script>
    import {enumServiceAgent} from "../../api/endpoints";
    export default {
        name: "EnumSelect",
        data() {
            return {
                options: []
            }
        },
        props: {
            enumType: String,
            value: Number
        },
        methods: {
            updateValue(value) {
                this.value = value;
                this.$emit('input', this.value);
            },
            loadOptions() {
                let self = this;
                enumServiceAgent.getEnumValueList(this.enumType)
                    .then(data => {
                        for (let i = 0; i < data.length; i++) {
                            this.options.push({
                                key: data[i].key,
                                value: data[i].value,
                                translatedValue: self.$t(data[i].key)
                            });
                        }
                    })
                    .catch(error => {
                        console.log(error);
                    });
            }
        },
        mounted() {
            this.loadOptions();
        }
    }
</script>

<style scoped>

</style>
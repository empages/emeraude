<template>
    <div class="mt-3 mb-3 text-left">
        <b-form-group label="From Date:" class="d-inline-block">
            <vuejs-datepicker v-model="filterDateFrom"
                              input-class="form-control">
            </vuejs-datepicker>
        </b-form-group>
        <b-form-group label="To Date:" class="d-inline-block">
            <vuejs-datepicker v-model="filterDateTo"
                              input-class="form-control">
            </vuejs-datepicker>
        </b-form-group>
        <b-form-group class="d-inline-block">
            <button class="btn btn-primary" @click="filterData">Filter</button>
        </b-form-group>
    </div>
</template>

<script>
    import Datepicker from 'vuejs-datepicker';
    export default {
        components: {
            'vuejs-datepicker': Datepicker,
        },
        data() {
            return {
                filterDateFrom: new Date(Date.now() - 12096e5),
                filterDateTo: Date.now()
            };
        },
        methods: {
            filterData() {
                this.$emit('update-dates', {
                    filterDateFrom: this.filterDateFrom,
                    filterDateTo: this.filterDateTo
                })
            }
        }
    }
</script>
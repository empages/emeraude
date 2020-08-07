<template>
    <div>
        <data-filter @update-dates="updateDates"></data-filter>
        <routes-visits-widget :date-from="filterDateFrom" :date-to="filterDateTo"></routes-visits-widget>
    </div>
</template>

<script>
    import DataFilter from './components/DateFilter';
    import RoutesVisitsWidget from './components/RoutesVisitsWidget';
    export default {
        components: {
            'data-filter': DataFilter,
            'routes-visits-widget': RoutesVisitsWidget
        },
        data() {
            return {
                filterDateFrom: new Date(Date.now() - 12096e5),
                filterDateTo: Date.now(),
            }
        },
        methods: {
            updateDates(dates) {
                this.filterDateFrom = dates.filterDateFrom;
                this.filterDateTo = dates.filterDateTo;
            }
        }
    }
</script>
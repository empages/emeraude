export default {
    date() {
        return {
            dateFormat: "x"
        };
    },
    props: {
        dateFrom: [Number, Date],
        dateTo: [Number, Date]
    },
    computed: {
        filterDateFrom() {
            return new Date(Number(this.dateFrom));
        },
        filterDateTo() {
            return new Date(Number(this.dateTo));
        },
        filterDateFromNumber() {
            return (this.filterDateFrom.getTime() / 1000).toFixed(0);
        },
        filterDateToNumber() {
            return (this.filterDateTo.getTime() / 1000).toFixed(0);
        },
        dateFilterQueryString() {
            return '&from=' + this.filterDateFromNumber + '&to=' + this.filterDateToNumber;
        }
    }
}
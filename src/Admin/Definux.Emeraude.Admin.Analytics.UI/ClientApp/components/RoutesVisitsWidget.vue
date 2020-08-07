<template>
    <div class="card p-3">
        <div class="card-header p-0 text-center border-0">
            <h4 class="card-title">Routes Visits</h4>
        </div>
        <div class="p-3">
            <b-form-group label="Type:" class="d-inline-block">
                <select @change="loadUniqueRoutes" v-model.number="routeType" class="form-control">
                    <option value="1">Client</option>
                    <option value="2">Admin</option>
                    <option value="3">API</option>
                </select>
            </b-form-group>
            <b-form-group label="Route:" class="d-inline-block">
                <select @change="globalFilter" class="form-control" v-model="selectedRoute">
                    <option :value="route" v-for="(route, routeIndex) in filteredRoutes" :key="routeIndex">
                        {{route}}
                    </option>
                </select>
            </b-form-group>
            <hr />
            <b-row if="selectedRoute != null">
                <b-col md="8">
                    <apexchart v-if="routeVisitsPerPeriodData != null"
                               type="line"
                               height="350"
                               :options="routeVisitsPerPeriodData.chartOptions"
                               :series="routeVisitsPerPeriodData.series" />
                </b-col>
                <b-col md="4">
                    <apexchart v-if="routeVisitsPerWeekDaysData != null"
                               type="radar"
                               height="350"
                               :options="routeVisitsPerWeekDaysData.chartOptions"
                               :series="routeVisitsPerWeekDaysData.series" />
                </b-col>
            </b-row>
        </div>
    </div>
</template>

<script>
    import VueApexCharts from 'vue-apexcharts';
    import dateFilterMixin from '../mixins/dateFilterMixin';
    export default {
        components: {
            'apexchart': VueApexCharts,
        },
        mixins: [dateFilterMixin],
        data() {
            return {
                routes: [],
                routeType: 1,
                selectedRoute: null,
                routeVisitsPerPeriodData: null,
                routeVisitsPerWeekDaysData: null,
            };
        },
        computed: {
            filteredRoutes() {
                let routes = [];
                if (this.routeType === 1) {
                    routes = this.routes.filter((r) => {
                        return !r.startsWith('/api/') && !r.startsWith('/admin');
                    });
                }
                else if (this.routeType === 2) {
                    routes = this.routes.filter((r) => {
                        return r.startsWith('/admin');
                    });
                }
                else if (this.routeType === 3) {
                    routes = this.routes.filter((r) => {
                        return r.startsWith('/api/');
                    });
                }

                return routes;
            }
        },
        methods: {
            loadUniqueRoutes() {
                let self = this;
                this.$http.get('/api/analytics/get-unique-routes')
                    .then(response => {
                        self.routes = response.data;
                        self.selectedRoute = self.filteredRoutes[0];
                        this.globalFilter();
                    })
                    .catch(error => {

                    });
            },
            loadRouteVisitsPerPerios() {
                let self = this;
                this.$http.get('/api/analytics/route-visits-per-period?route=' + this.selectedRoute + this.dateFilterQueryString)
                    .then(response => {
                        self.updateRouteVisitsPerPeriodChart(response.data);
                    })
                    .catch(error => {

                    });
            },
            loadRouteVisitsPerWeekDay() {
                let self = this;
                this.$http.get('/api/analytics/route-visits-per-week-day?route=' + this.selectedRoute + this.dateFilterQueryString)
                    .then(response => {
                        self.updateRouteVisitsPerWeekDayChart(response.data);
                    })
                    .catch(error => {

                    });
            },
            updateRouteVisitsPerPeriodChart(data) {
                this.routeVisitsPerPeriodData = {
                    series: [{
                        name: "All Visits",
                        data: data.visits
                    }, {
                        name: "Unique Visits",
                        data: data.uniqueVisits
                    }
                    ],
                    chartOptions: {
                        chart: {
                            shadow: {
                                enabled: true,
                                color: '#000',
                                top: 18,
                                left: 7,
                                blur: 10,
                                opacity: 1
                            },
                            toolbar: {
                                show: false
                            }
                        },
                        colors: ['#7eb62f', '#545454'],
                        dataLabels: {
                            enabled: true,
                        },
                        stroke: {
                            curve: 'smooth'
                        },
                        title: {
                            text: 'Visits Per ' + data.periodType + ((data.hourTypeDate !== null) ? ' (' + data.hourTypeDate + ')' : ""),
                            align: 'center'
                        },
                        grid: {
                            borderColor: '#e7e7e7',
                            row: {
                                colors: ['#f3f3f3', 'transparent'],
                                opacity: 0.5
                            },
                        },
                        markers: {
                            size: 6
                        },
                        xaxis: {
                            categories: data.dates,
                            title: {
                                text: data.periodType
                            }
                        },
                        yaxis: {
                            title: {
                                text: 'Visits'
                            },
                            min: data.minVisits,
                            max: data.maxVisits
                        },
                        legend: {
                            position: 'top',
                            horizontalAlign: 'right',
                            floating: true,
                            offsetY: -25,
                            offsetX: -5
                        }
                    }
                }
            },
            updateRouteVisitsPerWeekDayChart(data) {
                this.routeVisitsPerWeekDaysData = {
                    series: [{
                        name: 'All Visits',
                        data: data.visits,
                    }, {
                        name: 'Unique Visits',
                        data: data.uniqueVisits,
                    }],

                    chartOptions: {
                        chart: {
                            toolbar: {
                                show: false,
                            },
                        },
                        labels: data.days,
                        plotOptions: {
                            radar: {
                                size: 140,
                                polygons: {
                                    strokeColor: '#7eb62f',
                                    fill: {
                                        colors: ['#f8f8f8', '#fff']
                                    }
                                }
                            }
                        },
                        title: {
                            text: 'Visits Per Week Days',
                            align: 'center'
                        },
                        colors: ['#7eb62f', '#545454'],
                        markers: {
                            size: 3,
                            colors: ['#ddd'],
                            strokeColor: '#545454',
                            strokeWidth: 2,
                        },
                        tooltip: {
                            y: {
                                formatter: function (val) {
                                    return val
                                }
                            }
                        },
                        yaxis: {
                            tickAmount: 7,
                            labels: {
                                formatter: function (val, i) {
                                    if (i % 2 === 0) {
                                        return val
                                    } else {
                                        return ''
                                    }
                                }
                            }
                        }
                    }
                };
            },
            globalFilter() {
                this.loadRouteVisitsPerPerios();
                this.loadRouteVisitsPerWeekDay();
            }
        },
        mounted() {
            this.loadUniqueRoutes();
        },
        watch: {
            dateFilterQueryString() {
                this.globalFilter();
            }
        }
    }
</script>
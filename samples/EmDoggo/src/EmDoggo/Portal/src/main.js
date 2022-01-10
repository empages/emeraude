import { initializeRuntimeInjection } from "@emeraude-framework/portal-runtime-injection"
import createInsightsCustomViewComponent from "./components/insights-custom-view-component";

initializeRuntimeInjection((app, vueBundler) => {
    app.component('InsightsCustomView', createInsightsCustomViewComponent(vueBundler));
})
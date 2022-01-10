export default function ({compile}) {
    const render = compile(
`
<div>
    <div class="alert alert-warning">{{ message }}</div>
</div>
`);
    
    return {
        render,
        data() {
            return {
                message: 'Custom component for Insights Custom View!'
            }
        },
        props: {

        },
        inject: ['$httpClient'],
        mounted() {
        }
    }
}
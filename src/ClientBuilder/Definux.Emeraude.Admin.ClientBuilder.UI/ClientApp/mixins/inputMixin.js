export default {
    methods: {
        isValidKeyValue(event) {
            event = (event) ? event : window.event;
            let charCode = (event.which) ? event.which : event.keyCode;
            if ((charCode >= 48 && charCode <= 57) ||
                (charCode >= 65 && charCode <= 90) ||
                (charCode >= 97 && charCode <= 122) ||
                charCode === 95 || charCode === 32) {
                return true;
            }
            else {
                event.preventDefault();
            }
        },
        transformKeyInput(event) {
            let input = event.target.value.toUpperCase();
            input = input.replace(/ /g, "_");

            return input;
        }
    }
}
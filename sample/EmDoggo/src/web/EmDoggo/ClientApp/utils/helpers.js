import moment from "moment";

export function newGuid() {
    return 'xxxxxxxx-xxxx-4xxx-yxxx-xxxxxxxxxxxx'.replace(/[xy]/g, function(c) {
        var r = Math.random() * 16 | 0, v = c == 'x' ? r : (r & 0x3 | 0x8);
        return v.toString(16);
    });
};

export function formatDate(date) {
    return moment(date).format('DD/MM/YYYY');
}

export function formatTime(time) {
    return moment(time, 'HH:mm:ss').format("HH:mm")
}

export function getWeekdayFromDate(date) {
    let weekday = new Array(7);
    weekday[0] = "SUNDAY";
    weekday[1] = "MONDAY";
    weekday[2] = "TUESDAY";
    weekday[3] = "WEDNESDAY";
    weekday[4] = "THURSDAY";
    weekday[5] = "FRIDAY";
    weekday[6] = "SATURDAY";

    return weekday[moment(date).format('d')];
}

export function getKeyByValue(object, value) {
    return Object.keys(object).find(key => object[key] === value);
}
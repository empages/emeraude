export function capitalizeFirstLetter(string) {
    return string[0].toUpperCase() + string.slice(1);
};

export function bootstrapTableFields() {
    let fields = [];
    for (let i = 0; i < arguments.length; i++) {
        fields.push({
            key: arguments[i],
            label: capitalizeFirstLetter(arguments[i]),
            sortable: arguments[i] !== 'actions',
            tdClass: 'px-2 py-0 ' + (arguments[i] === 'actions' ? 'text-center fit' : 'text-left'),
            thClass: 'p-2 h-auto text-left'
        });
    }

    return fields;
};
$(document).ready(function () {
    $('.user-select-2').select2({
        placeholder: 'Select User',
        ajax: {
            url: '/api/admin/users',
            data: function (params) {
                return {
                    searchQuery: params.term
                };
            },
            delay: 500,
            processResults: function (data) {
                return {
                    results: data.items,
                    pagination: {
                        more: data.currentPage < data.pagesCount
                    }
                };
            }
        }
    });
})
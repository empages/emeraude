$(document).ready(function () {
    $('.prettify-json').each(function(index) {
        let currentHtml = $(this).html();
        if (currentHtml !== undefined && currentHtml !== null && currentHtml !== '') {
            let jsonContent = JSON.parse(decodeHtml($(this).html()));
            $(this).html(prettyPrintJson.toHtml(jsonContent))
        }
    });
});
$(document).ready(function () {
    $('.prettify-json').each(function(index) {
        let jsonContent = JSON.parse(decodeHtml($(this).html()));
        $(this).html(prettyPrintJson.toHtml(jsonContent))
    });
});
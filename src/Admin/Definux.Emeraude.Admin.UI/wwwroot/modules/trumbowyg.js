export function initEditor(slotId, inputId, initialValue) {
    $(`#${slotId}`).trumbowyg({})
        .on('tbwchange', function () {
            $(`#${inputId}`).val(encodeHtml($(this).trumbowyg('html')));
        })
        .on('tbwinit', function () {
            $(this).trumbowyg('html', decodeHtml(initialValue));
        });
}
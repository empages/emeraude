export function initEditor(slotId, inputId, initialValue) {
    $(`#${slotId}`).trumbowyg({})
        .on('tbwchange', function () {
            const input = $(`#${inputId}`);
            input.val(encodeHtml($(this).trumbowyg('html')));
            input[0].dispatchEvent(new Event('change'));
        })
        .on('tbwinit', function () {
            $(this).trumbowyg('html', decodeHtml(initialValue));
        });
}
$.trumbowyg.svgPath = '/admin/icons/html-editor-icons.svg';
$('.trumbowyg-editor-selector').trumbowyg({

})
    .on('tbwchange', function () {
        let currentChangeHtml = $(this).trumbowyg('html');
        let currentEditorId = $(this).attr('id');
        $('#trumbowyg-editor-hidden-input-' + currentEditorId).val(encodeHtml(currentChangeHtml));
    })
    .on('tbwinit', function () {
        let currentEditorId = $(this).attr('id');
        let currentEditorInputValue = $('#trumbowyg-editor-hidden-input-' + currentEditorId).val();
        $(this).trumbowyg('html', decodeHtml(currentEditorInputValue));
    });
(function($) {
  'use strict';
    $('.upload-file-input').on('change', function () {
        uploadFile($(this), transferUploadedFileToHiddenInput);
    });

    function uploadFile(fileInput, successCallback) {
        let file = fileInput[0].files[0];
        if (typeof (file) !== 'undefined') {
            let formData = new FormData();
            formData.append("file", file);

            $.ajax({
                method: 'POST',
                url: "/api/upload/file",
                success: function (data) {
                    successCallback(fileInput, data);
                },
                error: function (error) {
                    console.log(error);
                },
                async: true,
                data: formData,
                cache: false,
                contentType: false,
                processData: false,
                timeout: 60000
            });
        }
    }

    function transferUploadedFileToHiddenInput(fileInput, uploadedFile) {
        let fileInputId = fileInput.attr('id');
        $('#target-' + fileInputId).val(uploadedFile.id);
    }
})(jQuery);
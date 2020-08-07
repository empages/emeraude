$(document).ready(function () {
    $(".image-radio").each(function () {
        if ($(this).find('input[type="radio"]').first().attr("checked")) {
            $(this).addClass('image-radio-checked');
        } else {
            $(this).removeClass('image-radio-checked');
        }
    });

    $(".image-radio").on("click", function (e) {
        $(".image-radio").removeClass('image-radio-checked');
        $(this).addClass('image-radio-checked');
        var $radio = $(this).find('input[type="radio"]');
        $radio.prop("checked", !$radio.prop("checked"));

        e.preventDefault();
    });
});
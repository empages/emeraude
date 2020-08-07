(function ($) {
  'use strict';

  if ($(".timepicker-popup").length) {
      $('.timepicker-popup').timepicker({
          timeFormat: 'HH:mm',
          interval: 5,
          dynamic: false,
          dropdown: true,
          scrollbar: true
    });
  }

  if ($(".datepicker-popup").length) {
    $('.datepicker-popup').datepicker({
        enableOnReadonly: true,
        todayHighlight: true,
        format: 'mm/dd/yyyy'
    });
  }

})(jQuery);
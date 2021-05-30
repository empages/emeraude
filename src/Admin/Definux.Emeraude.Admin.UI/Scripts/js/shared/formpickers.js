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
          format: 'dd/mm/yyyy'
      }).on('changeDate', function(e){
          let value = Math.round(e.date.getTime() / 1000).toString();
          let targetElementId = e.target.id;
          $("#" + targetElementId + "-hidden").val(value);
      });
  }

})(jQuery);
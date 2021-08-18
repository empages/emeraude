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
          let value = moment(e.date, 'dd/mm/yyyy').format("YYYY-MM-DD");
          let targetElementId = e.target.id;
          $("#" + targetElementId + "-hidden").val(value);
      });
  }

})(jQuery);
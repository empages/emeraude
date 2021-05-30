(function ($) {
  'use strict';
  if ($('#page-keywords').length) {
      $('#page-keywords').tagsInput({
      'width': '100%',
      'height': '75%',
      'interactive': true,
      'defaultText': 'Add',
      'removeWithBackspace': true,
      'minChars': 0,
      'placeholderColor': '#666666'
    });
  }
})(jQuery);
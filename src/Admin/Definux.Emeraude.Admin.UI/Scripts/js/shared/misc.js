// var primaryColor = getComputedStyle(document.body).getPropertyValue('--primary');
// var secondaryColor = getComputedStyle(document.body).getPropertyValue('--secondary');
// var successColor = getComputedStyle(document.body).getPropertyValue('--success');
// var warningColor = getComputedStyle(document.body).getPropertyValue('--warning');
// var dangerColor = getComputedStyle(document.body).getPropertyValue('--danger');
// var infoColor = getComputedStyle(document.body).getPropertyValue('--info');
// var darkColor = getComputedStyle(document.body).getPropertyValue('--dark');
// var lightColor = getComputedStyle(document.body).getPropertyValue('--light');
//
// (function ($) {
//   'use strict';
//   $(function () {
//     var body = $('body');
//     var contentWrapper = $('.content-wrapper');
//     var scroller = $('.container-scroller');
//       var footer = $('.footer');
//
//     //Close other submenu in sidebar on opening any
//     $("#sidebar > .nav > .nav-item > a[data-toggle='collapse']").on("click", function () {
//       $("#sidebar > .nav > .nav-item").find('.collapse.show').collapse('hide');
//     });
//
//     //Change sidebar and content-wrapper height
//     applyStyles();
//
//     function applyStyles() {
//       //Applying perfect scrollbar
//       if (!body.hasClass("rtl")) {
//         if ($('.settings-panel .tab-content .tab-pane.scroll-wrapper').length) {
//           const settingsPanelScroll = new PerfectScrollbar('.settings-panel .tab-content .tab-pane.scroll-wrapper');
//         }
//         if ($('.chats').length) {
//           const chatsScroll = new PerfectScrollbar('.chats');
//         }
//         if ($('.scroll-container').length) {
//           const ScrollContainer = new PerfectScrollbar('.scroll-container');
//         }
//         if (body.hasClass("sidebar-fixed")) {
//           var fixedSidebarScroll = new PerfectScrollbar('#sidebar .nav');
//         }
//         if ($('.ps-enabled').length) {
//           const psEnabled = new PerfectScrollbar('.ps-enabled');
//         }
//       }
//     }
//
//     $('[data-toggle="minimize"]').on("click", function () {
//       if ((body.hasClass('sidebar-toggle-display')) || (body.hasClass('sidebar-absolute'))) {
//         body.toggleClass('sidebar-hidden');
//       } else {
//         body.toggleClass('sidebar-icon-only');
//       }
//     });
//
//     //checkbox and radios
//     $(".form-check label,.form-radio label").append('<i class="input-helper"></i>');
//   });
//
//   $(".sidebar .sidebar-inner > .nav > .nav-item").not(".brand-logo").attr('toggle-status', 'closed');
//   $(".sidebar .sidebar-inner > .nav > .nav-item").on('click', function () {
//     $(".sidebar .sidebar-inner > .nav > .nav-item").removeClass("active");
//     $(this).addClass("active");
//     $(".sidebar .sidebar-inner > .nav > .nav-item").find(".submenu").removeClass("open");
//     $(".sidebar .sidebar-inner > .nav > .nav-item").not(this).attr('toggle-status', 'closed');
//     var toggleStatus = $(this).attr('toggle-status');
//     if (toggleStatus === 'closed') {
//       $(this).find(".submenu").addClass("open");
//       $(this).attr('toggle-status', 'open');
//     } else {
//       $(this).find(".submenu").removeClass("open");
//       $(this).not(".brand-logo").attr('toggle-status', 'closed');
//     }
//   });
// })(jQuery);
//
// function showConfirmationMessage(e, title, message) {
//     e.preventDefault();
//     swal({
//         title: title,
//         text: message,
//         icon: 'warning',
//         buttons: {
//             cancel: {
//                 text: "Cancel",
//                 value: false,
//                 visible: true,
//                 className: "btn btn-danger",
//                 closeModal: true,
//             },
//             confirm: {
//                 text: "OK",
//                 value: true,
//                 visible: true,
//                 className: "btn btn-primary",
//                 closeModal: true
//             }
//         }
//     })
//     .then((value) => {
//         if (value === true) {
//             e.srcElement.submit();
//         }
//     });
// }

function encodeHtml(htmlString) {
    if (!htmlString) {
        return '';
    }
    
    let buf = [];

    for (let i=htmlString.length-1;i>=0;i--) {
        buf.unshift(['&#', htmlString[i].charCodeAt(), ';'].join(''));
    }

    return buf.join('');
}

function decodeHtml(htmlString) {
    if (!htmlString) {
        return '';
    }

    return htmlString.replace(/&#(\d+);/g, function(match, dec) {
        return String.fromCharCode(dec);
    });
}
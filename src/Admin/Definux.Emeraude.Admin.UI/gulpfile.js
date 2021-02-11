'use strict';

var gulp = require("gulp"),
    sass = require('gulp-sass'),
    concat = require('gulp-concat'),
    cssmin = require('gulp-cssmin'),
    uglify = require('gulp-uglify-es').default;

gulp.task('styles', () =>
    gulp
        .src('./Styles/scss/style.scss')
        .pipe(sass())
        .pipe(cssmin({ keepSpecialComments: 0 }))
        .pipe(concat('style.min.css'))
        .pipe(gulp.dest('./wwwroot/admin/css'))
);

gulp.task('styles:vendors', () =>
    gulp
        .src([
            './node_modules/bootstrap/dist/css/bootstrap.min.css',
            './node_modules/perfect-scrollbar/css/perfect-scrollbar.css',
            './node_modules/jquery-tags-input/dist/jquery.tagsinput.min.css',
            './node_modules/bootstrap-vue/dist/bootstrap-vue.min.css',
            './node_modules/dropzone/dist/dropzone.css',
            './node_modules/bootstrap-datepicker/dist/css/bootstrap-datepicker.min.css',
            './node_modules/jquery-timepicker/jquery.timepicker.css',
            './node_modules/trumbowyg/dist/ui/trumbowyg.min.css',
            './node_modules//pretty-print-json/dist/pretty-print-json.css',
            './node_modules/select2/dist/css/select2.min.css'
        ])
        .pipe(cssmin({ keepSpecialComments: 0 }))
        .pipe(concat('style.vendors.min.css'))
        .pipe(gulp.dest('./wwwroot/admin/css'))
);

gulp.task('scripts', () =>
    gulp.src([
        "./Scripts/js/shared/off-canvas.js",
        "./Scripts/js/shared/hoverable-collapse.js",
        "./Scripts/js/shared/misc.js",
        "./Scripts/js/shared/tooltips.js",
        "./Scripts/js/shared/popover.js",
        "./Scripts/js/shared/clipboard.js",
        "./Scripts/js/shared/form-addons.js",
        "./Scripts/js/shared/formpickers.js",
        "./Scripts/js/shared/upload-file-input.js",
        "./Scripts/js/shared/selectable-gallery.js",
        "./Scripts/js/shared/trumbowyg.js",
        "./Scripts/js/shared/general.js",
        "./Scripts/js/shared/select2.js"
    ])
        .pipe(uglify())
        .pipe(concat("scripts.min.js"))
        .pipe(gulp.dest('./wwwroot/admin/js/'))
);

gulp.task('scripts:vendors', function () {
    return gulp.src([
        './node_modules/jquery/dist/jquery.min.js',
        './node_modules/popper.js/dist/umd/popper.min.js',
        './node_modules/bootstrap/dist/js/bootstrap.min.js',
        './node_modules/perfect-scrollbar/dist/perfect-scrollbar.min.js',
        './node_modules/clipboard/dist/clipboard.min.js',
        './node_modules/jquery-tags-input/dist/jquery.tagsinput.min.js',
        './node_modules/sweetalert/dist/sweetalert.min.js',
        './node_modules/moment/min/moment.min.js',
        './node_modules/dropzone/dist/dropzone.js',
        './node_modules/bootstrap-datepicker/dist/js/bootstrap-datepicker.min.js',
        './node_modules/jquery-timepicker/jquery.timepicker.js',
        './node_modules/trumbowyg/dist/trumbowyg.min.js',
        './node_modules/pretty-print-json/dist/pretty-print-json.min.js',
        './node_modules/select2/dist/js/select2.min.js'
    ])
        .pipe(uglify())
        .pipe(concat("scripts.vendors.min.js"))
        .pipe(gulp.dest('./wwwroot/admin/js/'));
});

gulp.task('generate:admin:assets:styles', gulp.series('styles', 'styles:vendors'));
gulp.task('generate:admin:assets:scripts', gulp.series('scripts', 'scripts:vendors'));
gulp.task('default', gulp.series('generate:admin:assets:styles', 'generate:admin:assets:scripts'));
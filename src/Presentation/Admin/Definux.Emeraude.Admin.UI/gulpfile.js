'use strict';

var gulp = require("gulp"),
    sass = require('gulp-sass'),
    concat = require('gulp-concat'),
    cssmin = require('gulp-cssmin'),
    rename = require('gulp-rename'),
    uglify = require('gulp-uglify-es').default;

gulp.task('styles', function () {
    return gulp
        .src('./Styles/scss/style.scss')
        .pipe(sass())
        .pipe(cssmin({ keepSpecialComments: 0 }))
        .pipe(concat('style.min.css'))
        .pipe(gulp.dest('./wwwroot/admin/css'));
});

gulp.task('styles:vendors', function () {
    return gulp
        .src([
            './node_modules/bootstrap/dist/css/bootstrap.min.css',
            './node_modules/perfect-scrollbar/css/perfect-scrollbar.css',
            './node_modules/jquery-tags-input/dist/jquery.tagsinput.min.css',
            './node_modules/sweetalert2/dist/sweetalert2.min.css',
            './node_modules/bootstrap-vue/dist/bootstrap-vue.min.css',
            './node_modules/apexcharts/dist/apexcharts.css',
            './node_modules/dropzone/dist/dropzone.css',
            './node_modules/bootstrap-datepicker/dist/css/bootstrap-datepicker.min.css',
            './node_modules/jquery-timepicker/jquery.timepicker.css'
        ])
        .pipe(cssmin({ keepSpecialComments: 0 }))
        .pipe(concat('style.vendors.min.css'))
        .pipe(gulp.dest('./wwwroot/admin/css'));
});

gulp.task('scripts', function () {
    return gulp.src([
        "./Scripts/js/shared/off-canvas.js",
        "./Scripts/js/shared/hoverable-collapse.js",
        "./Scripts/js/shared/misc.js",
        "./Scripts/js/shared/todolist.js",
        "./Scripts/js/shared/tooltips.js",
        "./Scripts/js/shared/popover.js",
        "./Scripts/js/shared/clipboard.js",
        "./Scripts/js/shared/form-addons.js",
        "./Scripts/js/shared/formpickers.js",
        "./Scripts/js/shared/upload-file-input.js",
        "./Scripts/js/shared/selectable-gallery.js"
    ])
        .pipe(uglify())
        .pipe(concat("scripts.min.js"))
        .pipe(gulp.dest('./wwwroot/admin/js/'));
});

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
        './node_modules/jquery-timepicker/jquery.timepicker.js'
    ])
        .pipe(uglify())
        .pipe(concat("scripts.vendors.min.js"))
        .pipe(gulp.dest('./wwwroot/admin/js/'));
});

gulp.task('generate:admin:assets:styles', ['styles', 'styles:vendors']);
gulp.task('generate:admin:assets:scripts', ['scripts', 'scripts:vendors']);
gulp.task('generate:admin:assets', ['generate:admin:assets:styles', 'generate:admin:assets:scripts']);
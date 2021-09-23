'use strict';

const gulp = require("gulp"),
    sass = require('gulp-sass')(require('sass')),
    concat = require('gulp-concat'),
    cssmin = require('gulp-cssmin'),
    uglify = require('gulp-uglify-es').default;

gulp.task('styles', () =>
    gulp
        .src('./Styles/scss/style.scss')
        .pipe(sass())
        .pipe(cssmin({ keepSpecialComments: 0 }))
        .pipe(concat('style.min.css'))
        .pipe(gulp.dest('./wwwroot/_em/admin/css'))
);

gulp.task('scripts:vendors', function () {
    return gulp.src([
        './node_modules/bootstrap/dist/js/bootstrap.bundle.js'
    ])
        .pipe(uglify())
        .pipe(concat("scripts.vendors.min.js"))
        .pipe(gulp.dest('./wwwroot/_em/admin/js/'));
});

gulp.task('mdi', () =>
    gulp.src('node_modules/@mdi/font/fonts/*')
        .pipe(gulp.dest('./wwwroot/_em/admin/fonts'))
);

gulp.task('default', gulp.series('styles', 'mdi', 'scripts:vendors'));
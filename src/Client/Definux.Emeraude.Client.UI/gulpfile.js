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
        .pipe(gulp.dest('./wwwroot/client/css'))
);

gulp.task('styles:vendors', () =>
    gulp
        .src([
            './node_modules/bootstrap/dist/css/bootstrap.min.css'
        ])
        .pipe(cssmin({ keepSpecialComments: 0 }))
        .pipe(concat('style.vendors.min.css'))
        .pipe(gulp.dest('./wwwroot/client/css'))
);

gulp.task('scripts', () =>
    gulp.src([
        './Scripts/js/main.js'
    ])
        .pipe(uglify())
        .pipe(concat("scripts.min.js"))
        .pipe(gulp.dest('./wwwroot/client/js/'))
);

gulp.task('scripts:vendors', function () {
    return gulp.src([
        './node_modules/jquery/dist/jquery.min.js',
        './node_modules/bootstrap/dist/js/bootstrap.min.js'
    ])
        .pipe(uglify())
        .pipe(concat("scripts.vendors.min.js"))
        .pipe(gulp.dest('./wwwroot/client/js/'));
});

gulp.task('generate:client:assets:styles', gulp.series('styles', 'styles:vendors'));
gulp.task('generate:client:assets:scripts', gulp.series('scripts', 'scripts:vendors'));
gulp.task('default', gulp.series('generate:client:assets:styles', 'generate:client:assets:scripts'));
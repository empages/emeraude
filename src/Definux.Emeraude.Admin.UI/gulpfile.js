'use strict';

const gulp = require("gulp"),
    sass = require('gulp-sass')(require('sass')),
    concat = require('gulp-concat'),
    cssmin = require('gulp-cssmin'),
    uglify = require('gulp-uglify-es').default;

gulp.task('styles', () =>
    gulp
        .src([
            './Styles/scss/style.scss'
        ])
        .pipe(sass())
        .pipe(cssmin({ keepSpecialComments: 0 }))
        .pipe(concat('style.min.css'))
        .pipe(gulp.dest('./wwwroot/_em/admin/css'))
);

gulp.task('styles:vendors', () =>
    gulp
        .src([
            './node_modules/trumbowyg/dist/ui/trumbowyg.min.css',
        ])
        .pipe(sass())
        .pipe(cssmin({ keepSpecialComments: 0 }))
        .pipe(concat('style.vendors.min.css'))
        .pipe(gulp.dest('./wwwroot/_em/admin/css'))
);

gulp.task('scripts', () =>
    gulp.src([
        "./Scripts/js/shared/trumbowyg.js",
        "./Scripts/js/shared/misc.js",
    ])
        .pipe(uglify())
        .pipe(concat("scripts.min.js"))
        .pipe(gulp.dest('./wwwroot/_em/admin/js/'))
);

gulp.task('scripts:vendors', function () {
    return gulp.src([
        './node_modules/jquery/dist/jquery.min.js',
        './node_modules/moment/min/moment.min.js',
        './node_modules/bootstrap/dist/js/bootstrap.bundle.js',
        './node_modules/trumbowyg/dist/trumbowyg.min.js'
    ])
        .pipe(uglify())
        .pipe(concat("scripts.vendors.min.js"))
        .pipe(gulp.dest('./wwwroot/_em/admin/js/'));
});

gulp.task('mdi', () =>
    gulp.src('node_modules/@mdi/font/fonts/*')
        .pipe(gulp.dest('./wwwroot/_em/admin/fonts'))
);

gulp.task('default', gulp.series('styles:vendors', 'styles', 'mdi', 'scripts:vendors', 'scripts'));
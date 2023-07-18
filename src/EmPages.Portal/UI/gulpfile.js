const gulp = require("gulp"),
    concat = require('gulp-concat'),
    sass = require('gulp-sass')(require('sass')),
    uglify = require('gulp-uglify')
    minify = require('gulp-minify')
    cssmin = require('gulp-cssmin');

gulp.task('styles', () =>
    gulp.src('./Styles/src/**/*.scss')
        .pipe(sass())
        .pipe(cssmin({ keepSpecialComments: 0 }))
        .pipe(concat('_EmPages.css'))
        .pipe(gulp.dest('./Styles/dist'))
);
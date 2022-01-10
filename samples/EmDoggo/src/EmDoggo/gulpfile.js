const gulp = require("gulp"),
    concat = require('gulp-concat'),
    sass = require('gulp-sass')(require('sass')),
    cssmin = require('gulp-cssmin');

const { RUNTIME_INJECTION_STYLE_FILE_NAME } = require("@emeraude-framework/portal-runtime-injection");

gulp.task('portal-styles', () =>
    gulp.src('./Portal/style/**/*.scss')
        .pipe(sass())
        .pipe(cssmin({ keepSpecialComments: 0 }))
        .pipe(concat(RUNTIME_INJECTION_STYLE_FILE_NAME))
        .pipe(gulp.dest('./privateroot/portal/'))
);
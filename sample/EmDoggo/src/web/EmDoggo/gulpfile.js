let gulp = require("gulp"),
    concat = require('gulp-concat'),
    sass = require('gulp-sass'),
    rename = require('gulp-rename'),
    cssmin = require('gulp-cssmin'),
    gzip = require('gulp-gzip');

gulp.task('sass', () =>
    gulp.src('Styles/scss/**/*.scss')
        .pipe(sass())
        .pipe(gulp.dest('Styles/css'))
);

gulp.task('style:vendors', () =>
    gulp.src([
        "node_modules/bootstrap-vue/dist/bootstrap-vue.min.css"
    ])
        .pipe(concat('style.vendors.css'))
        .pipe(gulp.dest('Styles/css'))
);

gulp.task('styles', () =>
    gulp.src('Styles/css/*.css')
        .pipe(cssmin({ keepSpecialComments: 0 }))
        .pipe(rename({ extname: '.min.css' }))
        .pipe(gzip({ gzipOptions: { level: 9 } }))
        .pipe(gulp.dest('wwwroot/assets/css'))
);

gulp.task('default', gulp.series('sass', 'style:vendors', 'styles'));
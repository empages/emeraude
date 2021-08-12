let gulp = require("gulp"),
    concat = require('gulp-concat'),
    sass = require('gulp-sass')(require('sass')),
    rename = require('gulp-rename'),
    cssmin = require('gulp-cssmin');

gulp.task('sass', () =>
    gulp.src('Styles/scss/**/*.scss')
        .pipe(sass())
        .pipe(gulp.dest('Styles/css'))
);

gulp.task('style:vendors', () =>
    gulp.src([
        "node_modules/bootstrap/dist/css/bootstrap.css"
    ])
        .pipe(concat('style.vendors.css'))
        .pipe(gulp.dest('Styles/css'))
);

gulp.task('styles', () =>
    gulp.src('Styles/css/*.css')
        .pipe(cssmin({ keepSpecialComments: 0 }))
        .pipe(rename({ extname: '.min.css' }))
        .pipe(gulp.dest('wwwroot/assets/css'))
);

gulp.task('default', gulp.series('sass', 'style:vendors', 'styles'));
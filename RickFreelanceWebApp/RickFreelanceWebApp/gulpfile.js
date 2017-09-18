var gulp = require('gulp'),
    sass = require('gulp-ruby-sass'),
    autoprefixer = require('gulp-autoprefixer'),
    cssnano = require('gulp-cssnano'),
    jshint = require('gulp-jshint'),
    uglify = require('gulp-uglify'),
    imagemin = require('gulp-imagemin'),
    rename = require('gulp-rename'),
    concat = require('gulp-concat'),
    notify = require('gulp-notify'),
    cache = require('gulp-cache'),
    livereload = require('gulp-livereload'),
    del = require('del');

//Compile Sass, Autoprefix and minify
gulp.task('styles',
    function () {
        return (sass('wwwroot/scss/*.scss')
            .pipe(gulp.dest('wwwroot/css/Custom/'))
            .pipe(rename({ suffix: '.min' }))
            .pipe(cssnano())
            .pipe(gulp.dest('wwwroot/css/Custom/'))
            .pipe(notify({ message: 'Styles task complete' })));
    });

//JSHint, concat, and minifiy JavaScript
gulp.task('scripts', function () {
    return gulp.src('wwwroot/js/Custom/*.js')
        .pipe(jshint('../node_modules/liftoff/.jshintrc'))
        .pipe(jshint.reporter('default'))
        .pipe(concat('site.js'))
        .pipe(gulp.dest('wwwroot/js/'))
        .pipe(rename({ suffix: '.min' }))
        .pipe(uglify())
        .pipe(gulp.dest('wwwroot/js/'))
        .pipe(notify({ message: 'Scripts task complete' }));
});

//Compress Images
gulp.task('images', function () {
    return gulp.src('src/images/**/*')
        .pipe(imagemin({ optimizationLevel: 3, progressive: true, interlaced: true }))
        .pipe(gulp.dest('dist/assets/img'))
        .pipe(notify({ message: 'Images task complete' }));
});

//Clean up
gulp.task('clean', function () {
    return del(['dist/assets/css', 'dist/assets/js', 'dist/assets/img']);
});

//Default task
gulp.task('default', ['clean'], function () {
    gulp.start('styles', 'scripts', 'images');
});
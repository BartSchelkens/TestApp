/*
Grunt configuration to combine and minify all .js files in Scripts directory and save the result in wwwroot/app.js
Taken from: http://proudmonkey.azurewebsites.net/asp-net-5-jump-start-to-angularjs-with-mvc-6-web-api/
*/
module.exports = function (grunt) {
    grunt.loadNpmTasks('grunt-contrib-uglify');
    grunt.loadNpmTasks('grunt-contrib-watch');

    grunt.initConfig({
        uglify: {
            my_target: {
                files: { 'wwwroot/app.js': ['Scripts/app.js', 'Scripts/**/*.js'] }
            }
        },

        watch: {
            scripts: {
                files: ['Scripts/**/*.js'],
                tasks: ['uglify']
            }
        }
    });

    grunt.registerTask('default', ['uglify', 'watch']);
};
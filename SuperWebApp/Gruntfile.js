/* global module:false */
module.exports = function(grunt) {
	// Project configuration
	grunt.initConfig({
		pkg: grunt.file.readJSON('package.json'),

		uglify: {
			build: {
				src: 'js/source/default.js',
				dest: 'js/default.min.js'
			}
		},

		cssmin: {
			compress: {
				files: {
					'css/default.min.css': [ 'css/source/default.css' ]
				}
			}
		},

		less: {
			main: {
				files: {
					'css/source/default.css': 'css/source/default.less'
				}
			}
		},

		watch: {
          css: {
            files: ['css/source/*.less'],
            tasks: ['less','cssmin']
          },
          js: {
            files: ['js/source/*.js'],
            tasks: ['uglify']
          }
		}
	});

	// Dependencies
	grunt.loadNpmTasks( 'grunt-contrib-cssmin' );
	grunt.loadNpmTasks( 'grunt-contrib-uglify' );
	grunt.loadNpmTasks( 'grunt-contrib-watch' );
	grunt.loadNpmTasks( 'grunt-contrib-less' );

	// Default task
	grunt.registerTask( 'default', [ 'less', 'cssmin', 'uglify' ] );

};

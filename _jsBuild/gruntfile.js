module.exports = function(grunt) {
   
   grunt.initConfig({
	   //"clean" plugin config
	   clean: {
		   options: {
			   force:true
			   },
		   all:{
			   src:['../Angular4DotNetWebAPI/App_Build/**/*.*']
			   }
	   },
	   ngAnnotate: {
			options: {
				singleQuotes: true
			},
			dist: {
				files: [{
						expand: true,
						cwd: '../Angular4DotNetWebAPI/angular_app',
						src: ['**/*.js', '!**/*.min.js'],
						dest: '../Angular4DotNetWebAPI/App_Build/',
						ext: '.min.js',
						extDot: 'last'
					}],
			}
		}	   
   })
   
   
   // Load the plugin that provides the "clean" task.
   grunt.loadNpmTasks('grunt-contrib-clean');
   // ngmin is an AngularJS application pre-minifier. Replaced by ng-annotate
   grunt.loadNpmTasks('grunt-ng-annotate'); 
   // Default task(s). if you add 'build_angular' as param it is enough to run in cmd just 'grunt'
   grunt.registerTask('default', ['build_angular']);
   //tun in cmd as 'grunt build_angular'
   grunt.registerTask('build_angular', ['clean', 'ngAnnotate']);
};
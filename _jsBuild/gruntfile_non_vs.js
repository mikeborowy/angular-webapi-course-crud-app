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
	   //deprecated
	   // ngmin:{
		   // all:{
			   // files:[
					// {
						// expand: true,
						// cwd: '../Angular4DotNetWebAPI/angular_app',
						// src: ['**/*.js'],
						// dest: '../Angular4DotNetWebAPI/App_Build/',
						// ext: '.js'
					// }
			   // ]
		   // }
	   // },
	   
	   uglify:{
		   all:{
			   files:[
					{
						expand: true,
						cwd: '../Angular4DotNetWebAPI/angular_app',
						src: ['**/*.js'],
						dest: '../Angular4DotNetWebAPI/App_Build/',
						ext: '.min.js'
					}
			   ]
		   }
	   },

	   concat:{
		   optrions:{
			   separator: ';'
		   },
		   dist:{
			   src: ['../Angular4DotNetWebAPI/App_Build/**/*.js'],
			   dest: '../Angular4DotNetWebAPI/App_Build/app_minsafed.js'
		   }
	   }
   })
   
   
   // Load the plugin that provides the "clean" task.
   grunt.loadNpmTasks('grunt-contrib-clean');
   // ngmin is an AngularJS application pre-minifier. Replaced by ng-annotate
   //grunt.loadNpmTasks('grunt-ngmin'); = deprecated, use grunt-ng-annotate
   grunt.loadNpmTasks('grunt-ng-annotate'); 
   // Creates minified version of *.js files
   grunt.loadNpmTasks('grunt-contrib-uglify'); 
   // Creates one ouyput file from all *.js files
   grunt.loadNpmTasks('grunt-contrib-concat'); 
   
   // Default task(s). if you add 'build_angular' as param it is enough to run in cmd just 'grunt'
   grunt.registerTask('default', ['build_angular']);
   //tun in cmd as 'grunt build_angular'
   grunt.registerTask('build_angular', ['clean', 'ngAnnotate', 'uglify', 'concat']);
   
};
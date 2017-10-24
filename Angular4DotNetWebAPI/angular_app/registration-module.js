//rememeber to add this file to _Layout.cshtml page
var registrationModule = angular.module("registrationModule", ['ngRoute', 'ngResource'])
    .config(function($routeProvider, $locationProvider) {

        //when url looks like '/Registration/Courses' use template '/templates/courses.html' 
        //and controller 'Angular/Courses/courses-controller'
        //remember to add RoutMAp to App_Start RouteConfig.cs

        $routeProvider.when('/Courses', { templateUrl: '/angular_templates/courses.html', controller: 'CoursesController' });
        $routeProvider.when('/Instructors', { templateUrl: '/angular_templates/instructors.html', controller: 'InstructorsController' });
        $routeProvider.when('/CreateAccount', { templateUrl: '/angular_templates/create-account.html', controller: 'AccountController' });

        $locationProvider.html5Mode({
            enabled: true,
            requireBase: false
        });
    });
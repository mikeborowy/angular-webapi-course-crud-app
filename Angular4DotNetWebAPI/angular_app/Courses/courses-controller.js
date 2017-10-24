'use strict';
//rememeber to add *.js files to index page
// ... for mvc:
//registrationModule.controller
//... for grunt:
//angular.module('registrationModule').controller

angular.module('registrationModule').controller("CoursesController", function ($scope, coursesRepository) {
    //coursesRepository.get() - promise is succesful
    //then call succes or error parameter
    $scope.courses = coursesRepository.get();
})
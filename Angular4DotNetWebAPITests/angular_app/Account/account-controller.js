'use strict';
//rememeber to add *.js files to index page
// ... for mvc:
//registrationModule.controller
//... for grunt:
//angular.module('registrationModule').controller

angular.module('registrationModule').controller("AccountController", function ($scope, accountRepository, $location) {

    $scope.errors = [];
    $scope.OnCreateClick = function (student) {

        accountRepository
            .save(student)
            .$promise
            .then(
                function (succesResult) { OnSuccess(succesResult) },    //on success
                function (errorResponse) { OnError(errorResponse) }     //on error
            );

        function OnSuccess(succesResult) {
            $location.url("/Courses");
        };

        function OnError(errorResponse) {

            $scope.errors = errorResponse.data;
            //alert(errorResponse);
        };

    };


})
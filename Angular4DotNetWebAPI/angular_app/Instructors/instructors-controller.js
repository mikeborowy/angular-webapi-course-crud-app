//rememeber to add *.js files to index page
// ... for mvc:
//registrationModule.controller("InstructorsController", function ($scope, instructorsRepository)
//... for grunt:
//angular.module('registrationModule').controller("InstructorsController", function ($scope, instructorsRepository)  
angular.module('registrationModule').controller("InstructorsController", function ($scope, instructorsRepository) {
    //coursesRepository.get() - promise is succesful
    //then call succes or error parameter
    $scope.instructors =  instructorsRepository.get()
})
'use strict';
//rememeber to add *.js files to index page
registrationModule.factory('accountRepository', function ($resource){
    return{
        save: function (student) {
            return $resource('api/Account').save(student);
        }
    }
});
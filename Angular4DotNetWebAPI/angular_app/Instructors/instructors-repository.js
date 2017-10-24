registrationModule.factory('instructorsRepository', function ($resource){
    return{
        get:function(){
            // $q <=> promise library helps in handling assynchronous communication,
            //it is builded in $resource (ngResources in regisutration-module.js) library
            //return $resource('/api/Instructors').get() -> get() for single object return,
            //for array return must be used query()
            return $resource('/api/Instructors').query()
        }
    }
});
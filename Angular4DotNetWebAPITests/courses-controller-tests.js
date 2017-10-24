'use-strict';

describe('During construction of controller', function () {
    angular.mock.module('registrationModule');

    var scope;
    var controller;
    var coursesRepositoryMock;
    var courses;

    beforeEach(angular.mock.inject(function ($controller, $rootScope, coursesRepository) {

        scope = $rootScope.$new();
        coursesRepositoryMock = sinon.stub($coursesRepository);

        conosle.log('raaaa')

        courses = [{ foo: 'bar' }];
        coursesRepositoryMock.get.returns(courses);
        controller = $controller('CoursesController', { $scope: scope, coursesRepository: coursesRepositoryMock });

    }));

    it('should set the courses from repository', function () {

        expect(scope.courses).toEqual(courses);
    });

    //describe('$scope.courses', function () {
    //});
    //beforeEach(angular.mock.inject(function (_$controller_, _$rootScope_, _$coursesRepository_) {
    //    $scope = _$rootScope_.new();
    //    $coursesRepositoryMock = sinon.stub(_$coursesRepository_);
    //    courses = [{ foo: 'bar' }];
    //    $coursesRepositoryMock.get.returns(courses);
    //    $controller = _$controller_('CoursesController', { $scope: $scope });
    //}));
    //
    //    it('should set the courses from repository', function () {
    //        expect(scope.courses).toBe(courses);
    //    });
})


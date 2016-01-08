(function () {
    'use strict';

    angular
        .module('personApp')
        .controller('personController', personController);

    personController.$inject = ['$scope', 'Persons'];

    function personController($scope, Persons) {
        $scope.Persons = Persons.query();
    }
})();

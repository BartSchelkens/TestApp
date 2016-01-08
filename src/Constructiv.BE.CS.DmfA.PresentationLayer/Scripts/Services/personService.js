(function () {
    'use strict';

    var personService = angular.module('personService', ['ngResource']);

    personService.factory('Persons', ['$resource',
        function ($resource) {
            return $resource('/api/persons', {}, {
                query: { method: 'GET', params: {}, isArray: true }
            });
        }
    ]);
})();

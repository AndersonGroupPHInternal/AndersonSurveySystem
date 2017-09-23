(function () {
    'use strict';

    angular
        .module('App')
        .factory('DynamicGraphService', DynamicGraphService);

    DynamicGraphService.$inject = ['$http'];

    function DynamicGraphService($http) {
        return {
            Read: Read
        }

        function Read() {
            return $http({
                method: 'POST',
                url: '../Chart/DynamicStructuredData',
                headers: { 'Content-Type': 'application/x-www-form-urlencoded' }
            });
        }


    }
})();
(function () {
    'use strict';

    angular
    .module('App')
    .factory('RateService', RateService);

    RateService.$inject = ['$http'];

    function RateService($http) {
        return {
            Create: Create,
            List: List,
            Update: Update,
            Delete: Delete
        }

        function Create(rate) {
            return $http({
                method: 'POST',
                url: '../Rate/Create',
                data: {
                    rate: rate
                }
            });
        }

        function List() {
            return $http({
                method: 'POST',
                url: '../Rate/List',
                headers: { 'Content-Type': 'application/x-www-form-urlencoded' }
            });
        }

        function Update(rate) {
            return $http({
                method: 'POST',
                url: '../Rate/Update',
                data: {
                    rate: rate
                }
            });
        }
        function Delete(rate) {
            return $http({
                method: 'POST',
                url: '../Rate/Delete',
                data: {
                    rate: rate
                },
            })
        }
    }
})();
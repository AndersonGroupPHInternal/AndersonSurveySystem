(function () {
    'use strict';

    angular
    .module('App')
    .factory('EmailService', EmailService);

    EmailService.$inject = ['$http'];

    function EmailService($http) {
        return {
            Create: Create,
            List: List,
            Update: Update,
            Delete: Delete
        }

        function Create(email) {
            return $http({
                method: 'POST',
                url: '../Email/Create',
                data: {
                    email: email
                }
            });
        }

        function List() {
            return $http({
                method: 'POST',
                url: '../Email/List',
                headers: { 'Content-Type': 'application/x-www-form-urlencoded' }
            });
        }

        function Update(email) {
            return $http({
                method: 'POST',
                url: '../Email/Update',
                data: {
                    email: email
                }
            });
        }
        function Delete(email) {
            return $http({
                method: 'POST',
                url: '../Email/Delete',
                data: {
                    email: email
                },
            })
        }
    }
})();
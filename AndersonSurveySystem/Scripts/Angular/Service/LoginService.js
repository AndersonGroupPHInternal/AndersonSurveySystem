(function () {
    'use strict';

    angular
    .module('App')
    .factory('LoginService', LoginService);

    LoginService.$inject = ['$http'];

    function LoginService($http) {
        return {
            Create: Create,
            List: List,
            Update: Update,
            Delete: Delete
        }

        function Create(admin) {
            return $http({
                method: 'POST',
                url: '../Login/Create',
                data: {
                    login: login
                }
            });
        }

        function List() {
            return $http({
                method: 'POST',
                url: '../Login/List',
                headers: { 'Content-Type': 'application/x-www-form-urlencoded' }
            });
        }

        function Update(admin) {
            return $http({
                method: 'POST',
                url: '../Login/Update',
                data: {
                    admin: admin
                }
            });
        }
        function Delete(admin) {
            return $http({
                method: 'POST',
                url: '../Login/Delete',
                data: {
                    login: login
                },
            })
        }
    }
})();
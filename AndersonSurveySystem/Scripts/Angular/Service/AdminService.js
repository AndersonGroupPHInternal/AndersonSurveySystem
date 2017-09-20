(function () {
    'use strict';

    angular
    .module('App')
    .factory('AdminService', AdminService);

    AdminService.$inject = ['$http'];

    function AdminService($http) {
        return {
            Create: Create,
            List: List,
            Update: Update,
            Delete: Delete
        }

        function Create(admin) {
            return $http({
                method: 'POST',
                url: '../Admin/Create',
                data: {
                    admin: admin
                }
            });
        }

        function List() {
            return $http({
                method: 'POST',
                url: '../Admin/List',
                headers: { 'Content-Type': 'application/x-www-form-urlencoded' }
            });
        }

        function Update(admin) {
            return $http({
                method: 'POST',
                url: '../Admin/Update',
                data: {
                    admin: admin
                }
            });
        }
        function Delete(admin) {
            return $http({
                method: 'POST',
                url: '../Admin/Delete',
                data: {
                    admin: admin
                },
            })
        }
    }
})();
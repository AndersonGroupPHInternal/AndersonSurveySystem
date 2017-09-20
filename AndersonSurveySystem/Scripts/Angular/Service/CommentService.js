(function () {
    'use strict';

    angular
    .module('App')
    .factory('CommentService', CommentService);

    CommentService.$inject = ['$http'];

    function CommentService($http) {
        return {
            Create: Create,
            List: List,
            Update: Update,
            Delete: Delete
        }

        function Create(comment) {
            return $http({
                method: 'POST',
                url: '../Comment/Create',
                data: {
                    comment: comment
                }
            });
        }

        function List() {
            return $http({
                method: 'POST',
                url: '../Comment/List',
                headers: { 'Content-Type': 'application/x-www-form-urlencoded' }
            });
        }

        function Update(comment) {
            return $http({
                method: 'POST',
                url: '../Comment/Update',
                data: {
                    comment: comment
                }
            });
        }
        function Delete(comment) {
            return $http({
                method: 'POST',
                url: '../Comment/Delete',
                data: {
                    comment: comment
                },
            })
        }
    }
})();
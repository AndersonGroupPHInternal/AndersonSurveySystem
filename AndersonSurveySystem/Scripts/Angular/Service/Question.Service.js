(function () {
    'use strict';

    angular
        .module('App')
        .factory('QuestionService', QuestionService);

    QuestionService.$inject = ['$http'];

    function QuestionService($http) {
        return {
            Read: Read,
            Delete: Delete
        }

        function Read() {
            return $http({
                method: 'POST',
                url: '/Question/Read',
                headers: { 'Content-Type': 'application/x-www-form-urlencoded' }
            });
        }

        function Delete(QuestionId) {
            return $http({
                method: 'DELETE',
                url: '/Question/Delete/' + QuestionId,
                headers: { 'Content-Type': 'application/x-www-form-urlencoded' }
            });
        }
    }
})();
(function () {
    'use strict';

    angular
        .module('App')
        .factory('SurveyService', SurveyService);

    SurveyService.$inject = ['$http'];

    function SurveyService($http) {
        return {
            Read: Read,
            Delete: Delete
        }

        function Read() {
            return $http({
                method: 'POST',
                url: '/Survey/Read',
                headers: { 'Content-Type': 'application/x-www-form-urlencoded' }
            });
        }

        function Delete(SurveyId) {
            return $http({
                method: 'DELETE',
                url: '/Survey/Delete/' + SurveyId,
                headers: { 'Content-Type': 'application/x-www-form-urlencoded' }
            });
        }
    }
})();
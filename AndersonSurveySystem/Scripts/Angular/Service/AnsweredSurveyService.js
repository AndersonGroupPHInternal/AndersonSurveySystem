(function () {
    'use strict';

    angular
    .module('App')
    .factory('AnsweredSurveyService', AnsweredSurveyService);

    AnsweredSurveyService.$inject = ['$http'];

    function AnsweredSurveyService($http) {
        return {
            Create: Create,
            List: List,
            Update: Update,
            Delete: Delete
        }

        function Create(survey) {
            return $http({
                method: 'POST',
                url: '../Survey/Create',
                data: {
                    survey: survey
                }
            });
        }

        function List() {
            return $http({
                method: 'POST',
                url: '../Survey/List',
                headers: { 'Content-Type': 'application/x-www-form-urlencoded' }
            });
        }

        function Update(survey) {
            return $http({
                method: 'POST',
                url: '../Survey/Update',
                data: {
                    survey: survey
                }
            });
        }
        function Delete(survey) {
            return $http({
                method: 'POST',
                url: '../Survey/Delete',
                data: {
                    survey: survey
                },
            })
        }
    }
})();


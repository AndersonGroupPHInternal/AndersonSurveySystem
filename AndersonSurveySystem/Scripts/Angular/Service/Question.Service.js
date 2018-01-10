(function () {
    'use strict';

    angular
        .module('App')
        .factory('QuestionService', QuestionService);

    QuestionService.$inject = ['$http'];

    function QuestionService($http) {
        return {
            Read: Read
        }

        function Read(surveyId) {
            return $http({
                method: 'POST',
                url: '/Question/Read/' + surveyId,
                headers: { 'Content-Type': 'application/x-www-form-urlencoded' }
            });
        }
    }
})();
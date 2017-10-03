(function () {
    'use strict';

    angular
        .module('App')
        .factory('QuestionResultService', QuestionResultService);

    QuestionResultService.$inject = ['$http'];

    function QuestionResultService($http) {
        return {
            Read: Read
        }

        function Read(surveyId) {
            return $http({
                method: 'POST',
                url: '../QuestionResult/Result/' + surveyId,
                headers: { 'Content-Type': 'application/x-www-form-urlencoded' }
            });
        }


    }
})();
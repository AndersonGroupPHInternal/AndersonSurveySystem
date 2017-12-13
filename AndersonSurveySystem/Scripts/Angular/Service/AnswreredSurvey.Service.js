(function () {
    'use strict';

    angular
        .module('App')
        .factory('AnsweredSurveyService', AnsweredSurveyService);


    AnsweredSurveyService.$inject = ['$http'];

    function AnsweredSurveyService($http) {
        return {
            Read: Read
        }

        function Read(QuestionResultFilter) {
            return $http({
                method: 'POST',
                url: '../QuestionResult/List',
                data: $.param(QuestionResultFilter),
                headers: { 'Content-Type': 'application/x-www-form-urlencoded' }
            })
            .then(function (result) {
                vm.dataList = angular.copy(result.data);
            })
        }


    }
})();
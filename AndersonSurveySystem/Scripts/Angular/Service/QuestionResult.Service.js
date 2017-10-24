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

        function Read(QuestionResultFilter) {
            return $http({
                method: 'POST',
                url: '../QuestionResult/Result',
                data: $.param(QuestionResultFilter),
                headers: { 'Content-Type': 'application/x-www-form-urlencoded' }
            });
        }


    }
})();
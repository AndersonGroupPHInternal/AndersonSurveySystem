(function () {
    'use strict';

    angular
        .module('App')
        .factory('AnsweredQuestionService', AnsweredQuestionService);
        

    AnsweredQuestionService.$inject = ['$http'];

    function AnsweredQuestionService($http) {
        return {
            Read: Read
        }

        function Read(questionResultFilter) {
            return $http({
                method: 'POST',
                url: '../AnsweredQuestion/Read',
                data: $.param(questionResultFilter),
                headers: { 'Content-Type': 'application/x-www-form-urlencoded' }
            });
        }


    }
})();
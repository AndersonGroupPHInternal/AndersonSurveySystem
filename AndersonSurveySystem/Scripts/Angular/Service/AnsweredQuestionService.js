(function () {
    'use strict';

    angular
    .module('App')
    .factory('AnsweredQuestionService', AnsweredQuestionService);

    AnsweredQuestionService.$inject = ['$http'];

    function AnsweredQuestionService($http) {
        return {
            Create: Create,
            List: List,
            Update: Update,
            Delete: Delete
        }

        function Create(answeredquestion) {
            return $http({
                method: 'POST',
                url: '../AnsweredQuestion/Create',
                data: {
                    answeredquestion: answeredquestion
                }
            });
        }

        function List() {
            return $http({
                method: 'POST',
                url: '../AnsweredQuestion/List',
                headers: { 'Content-Type': 'application/x-www-form-urlencoded' }
            });
        }

        function Update(answeredquestion) {
            return $http({
                method: 'POST',
                url: '../AnsweredQuestion/Update',
                data: {
                    answeredquestion: answeredquestion
                }
            });
        }
        function Delete(answeredquestion) {
            return $http({
                method: 'POST',
                url: '../AnsweredQuestion/Delete',
                data: {
                    answeredquestion: answeredquestion
                },
            })
        }
    }
})();
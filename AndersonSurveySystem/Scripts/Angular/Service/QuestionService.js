(function () {
    'use strict';

    angular
    .module('App')
    .factory('QuestionService', QuestionService);

    QuestionService.$inject = ['$http'];

    function QuestionService($http) {
        return {
            Create: Create,
            List: List,
            Update: Update,
            Delete: Delete
        }

        function Create(question) {
            return $http({
                method: 'POST',
                url: '../Question/Create',
                data: {
                    question: question
                }
            });
        }

        function List() {
            return $http({
                method: 'POST',
                url: '../Question/List',
                headers: { 'Content-Type': 'application/x-www-form-urlencoded' }
            });
        }

        function Update(question) {
            return $http({
                method: 'POST',
                url: '../Question/Update',
                data: {
                    question: question
                }
            });
        }
        function Delete(question) {
            return $http({
                method: 'POST',
                url: '../Question/Delete',
                data: {
                    question: question
                },
            })
        }
    }
})();
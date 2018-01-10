(function () {
    'use strict';

    angular
        .module('App')
        .controller('QuestionController', QuestionController);

    QuestionController.$inject = ['$filter', '$window', 'QuestionService'];

    function QuestionController($filter, $window, QuestionService) {
        var vm = this;

        vm.SurveyId;

        vm.Questions = [];
        vm.Name = [];

        vm.Question = {
            Description: '',
        };

        vm.Create = Create;
        vm.UpdateQuestion = UpdateQuestion;
        vm.Delete = Delete;
        vm.DeletedQuestions = [];

        vm.IsExisting = IsExisting;

        vm.Initialise = Initialise;

        function UpdateQuestion(question) {
            question.Question = $filter('filter')(vm.Question, { QuestionId: question.QuestionId })[0];
        }
        function Create() {
            vm.Questions.push(vm.Question);
        }

        function IsExisting(question) {
            return (question.QuestionId !== null);
        }

        function Initialise(surveyId) {
            vm.SurveyId = surveyId
            Read();
        }

        function Read() {
            QuestionService.Read(vm.SurveyId)
                .then(function (response) {
                    vm.Questions = response.data;
                })
        }

        function Delete(question) {
            vm.DeletedQuestions.push(question);
            var index = vm.Questions.indexOf(question);
            if (index >= 0)
                vm.Questions.splice(index, 1);
        }
    }
})();
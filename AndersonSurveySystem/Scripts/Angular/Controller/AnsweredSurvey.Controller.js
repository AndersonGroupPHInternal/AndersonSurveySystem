(function () {
    'use strict';

    angular
        .module('App')
        .controller('AnsweredSurveyController', AnsweredSurveyController);

    AnsweredSurveyController.$inject = ['AnsweredSurveyService'];
    function AnsweredSurveyController(AnsweredSurveyService) {
        var vm = this;
        //object
        vm.Options;
        vm.QuestionResultFilter = {
            From: new Date(moment().add(-1, 'months')),
            To: new Date(moment()),
            SurveyId: 1
        };
        //object array
        vm.Description = [];
        vm.FirstNameName = [];
        vm.MiddleName = [];
        vm.LastName = [];
        vm.TicketNumber = [];
        vm.AnsweredQuestion = [];
        vm.Answer = [];
        vm.Surveys = [];

        //declared functions
        vm.Initialise = Initialise;
        vm.Read = Read;
        //public read
        function Initialise() {
            vm.Surveys = ['Survey'];
            vm.option = [];
            
        }
        Read();
    }

    function Read() {
        var questionResultFilter = angular.copy(vm.QuestionResultFilter)
        questionResultFilter.From = moment(questionResultFilter.From).format('YYYY-MM-DD');
        questionResultFilter.To = moment(questionResultFilter.To).format('YYYY-MM-DD');
        QuestionResultService.Read(questionResultFilter)
            .then(function (response) {
                vm.names = response.data.record;});
                vm.AnsweredSurvey = reponse.data;
                UpdateAnswer;

                vm.Name = vm.QuestionResults.map(function (a) { return a.Name; })

            .catch(function (data, status) {
            });
    }
    function UpdateAnsweredSurvey() {

    }

})();
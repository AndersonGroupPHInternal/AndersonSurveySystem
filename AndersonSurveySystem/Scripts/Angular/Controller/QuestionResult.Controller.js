(function () {
    'use strict';

    angular
        .module('App')
        .controller('QuestionResultController', QuestionResultController);

    QuestionResultController.$inject = ['AnsweredQuestionService', 'QuestionResultService'];
    function QuestionResultController(AnsweredQuestionService, QuestionResultService) {
        var vm = this;
        //object
        vm.Options;
        vm.QuestionResultFilter = {
            From: new Date(moment().add(-1, 'months')),
            To: new Date(moment()),
            SurveyId: 1
        };
        //object array
        vm.Colors = [];
        vm.Name = [];
        vm.QuestionResults = [];
        vm.Rate = [];
        vm.Surveys = [];
        vm.AnsweredQuestions = [];

        //declared functions
        vm.Initialise = Initialise;
        vm.Read = Read;
        vm.ReadAnsweredQuestion = ReadAnsweredQuestion;

        //public read
        function Initialise() {
            vm.Surveys = ['Survey'];
            vm.Colors = ['#4CAF50', '#F44336', '#9E9E9E', '#9C27B0', '#795548'];
            vm.Options = {
                size: {
                    height: 504,
                    width: 896
            },
                scales: {
                    xAxes: [{
                        gridLines: {
                            display: false
                        },
                    }],
                    yAxes: [{
                        gridlines: {
                            display: false
                        },
                        ticks: {
                            beginAtZero: true,
                            max: 10,
                            display: true
                        }
                    }],
                    legend: {
                        display: true,
                        position: 'Right'
                    }
                }
            }
            Read();
        }

        function Read() {
            var questionResultFilter = angular.copy(vm.QuestionResultFilter)
            questionResultFilter.From = moment(questionResultFilter.From).format('YYYY-MM-DD');
            questionResultFilter.To = moment(questionResultFilter.To).format('YYYY-MM-DD');
            QuestionResultService.Read(questionResultFilter)
                .then(function (response) {
                    vm.QuestionResults = response.data;

                    vm.Rate = vm.QuestionResults.map(function (a) { return a.Rate; });
                    vm.Name = vm.QuestionResults.map(function (a) { return a.Name; });

                })
                .catch(function (data, status) {
                });
        }

        function ReadAnsweredQuestion() {
            var questionResultFilter = angular.copy(vm.QuestionResultFilter)
            questionResultFilter.From = moment(questionResultFilter.From).format('YYYY-MM-DD');
            questionResultFilter.To = moment(questionResultFilter.To).format('YYYY-MM-DD');
            AnsweredQuestionService.Read(questionResultFilter)
                .then(function (response) {
                    vm.AnsweredQuestions = response.data;
                })
                .catch(function (data, status) {
                });
        }
    }
})();
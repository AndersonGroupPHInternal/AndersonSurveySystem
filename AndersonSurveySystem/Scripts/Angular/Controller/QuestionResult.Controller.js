(function () {
    'use strict';

    angular
        .module('App')
        .controller('QuestionResultController', QuestionResultController);

    QuestionResultController.$inject = ['QuestionResultService'];

    function QuestionResultController(QuestionResultService) {
        var vm = this;
        //object
        vm.Options;
        //object array
        vm.Labels = [];
        vm.QuestionResults = [];
        vm.Rate = [];
        vm.Surveys = [];

        //declared functions
        vm.Initialise = Initialise;

        //public read
        function Initialise() {
            vm.Surveys = ['Survey']

            vm.Options = {
                scales: {
                    yAxes: [{
                        ticks: {
                            beginAtZero: true,
                            max: 10
                        }
                    }]
                }
            }

            Read();
        }

        function Read() {
            QuestionResultService.Read(1)
                .then(function (response) {
                    vm.QuestionResults = response.data;

                    vm.Rate = vm.QuestionResults.map(function (a) { return a.Rate; });
                    vm.Description = vm.QuestionResults.map(function (a) { return a.Description; });

                    
                })
                .catch(function (data, status) {
                });
        }

    }
})();
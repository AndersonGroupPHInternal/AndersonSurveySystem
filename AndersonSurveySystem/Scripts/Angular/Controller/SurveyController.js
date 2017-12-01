(function () {
    'use strict';

    angular
        .module('App')
        .controller('SurveyController', SurveyController);

    SurveyController.$inject = ['$filter', '$window', 'SurveyService'];

    function SurveyController($filter, $window, SurveyService) {
        var vm = this;

        vm.Survey = [];

        vm.GoToUpdatePage = GoToUpdatePage;
        vm.Initialise = Initialise;

        vm.UpdateSurvey = UpdateSurvey;

        vm.Delete = Delete;

        function GoToUpdatePage(surveyId) {
            $window.location.href = '../Survey/Update/' + surveyId;
        }

        function Initialise() {
            Read();
            ReadSurvey();
        }

        function InitialiseDropdown(surveyId) {
            vm.SurveyId = surveyId
            Read();

        }
        function ReadSurvey() {
            SurveyService.Read()
                .then(function (response) {
                    vm.Survey = response.data;
                })
                .catch(function (data, status) {
                    new PNotify({
                        title: status,
                        text: data,
                        type: 'error',
                        hide: true,
                        addclass: "stack-bottomright"
                    });

                });
        }

        function Read() {
            SurveyService.Read()
                .then(function (response) {
                    vm.Survey = response.data;
                
                })
                .catch(function (data, status) {
                    new PNotify({
                        title: status,
                        text: data,
                        type: 'error',
                        hide: true,
                        addclass: "stack-bottomright"
                    });

                });
        }

        function UpdateSurvey(survey) {
            survey.Survey = $filter('filter')(vm.Survey, { SurveyId: survey.SurveyId })[0];
        }

        function Delete(SurveyId) {
            SurveyService.Delete(surveyId)
                .then(function (response) {
                    Read();
                })
                .catch(function (data, status) {
                    new PNotify({
                        title: status,
                        text: data,
                        type: 'error',
                        hide: true,
                        addclass: "stack-bottomright"
                    });
                });
        }

    }
})();
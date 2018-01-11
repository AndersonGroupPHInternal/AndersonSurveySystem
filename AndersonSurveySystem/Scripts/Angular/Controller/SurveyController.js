(function () {
    'use strict';

    angular
        .module('App')
        .controller('SurveyController', SurveyController);

    SurveyController.$inject = ['$filter', '$window', 'SurveyService'];

    function SurveyController($filter, $window, SurveyService) {
        var vm = this;

        vm.Surveys = [];

        vm.GoToUpdatePage = GoToUpdatePage;
        vm.Initialise = Initialise;

        vm.UpdateSurvey = UpdateSurvey;

        vm.Delete = Delete;

        function GoToUpdatePage(surveyId) {
            $window.location.href = '../Survey/Update/' + surveyId;
        }

        function UpdateSurvey(survey) {
            survey.Survey = $filter('filter')(vm.Survey, { SurveyId: survey.SurveyId })[0];
        }

        function Initialise() {
            Read();
        }

        //a
        function ReadSurvey() {
            SurveyService.Read()
                .then(function (response) {
                    vm.Survey = response.data;
                })
        }

        function Read() {
            SurveyService.Read()
                .then(function (response) {
                    vm.Survey = response.data;

                })
        }
        function Delete(surveyId) {
            SurveyService.Delete(surveyId)
                .then(function (response) {
                    Read();
                })
        }
    }
})();
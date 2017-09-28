(function () {
    'use strict';

    angular
    .module('App')
    .controller('AnsweredSurveyController', AnsweredSurveyController);

    AnsweredSurveyController.$inject = ['AnsweredSurveyService'];

    function AnsweredSurveyController($scope) {
        var vm = this;

        vm.Survey;

        vm.Surveys = [];

        vm.List = List;
        vm.Create = Create;
        vm.CreateModal = CreateModal;
        vm.Update = Update;
        vm.UpdateModal = UpdateModal;
       
        vm.Delete = Delete;

        function Create() {
            SurveyService.Create(vm.Survey)
            .then(function (response) {
                List();
                angular.element('#SurveyRate').modal('hide');

                new PNotify({
                    title: 'Success',
                    text: 'Survey Recorded',
                    type: 'success',
                    hide: true,
                    addclass: "stack-bottomright"
                });

            })
            .catch(function (data, status) {
                new PNotify({
                    title: 'Error',
                    text: 'There was an error on loading the list',
                    type: 'error',
                    hide: true,
                    addclass: "stack-bottomright"
                });

            });
        }


        function Index() {
            SurveyService.Create(vm.Survey)
            .then(function (response) {
                List();
                angular.element('#SurveyRate').modal('hide');

                new PNotify({
                    title: 'Success',
                    text: 'Survey Recorded',
                    type: 'success',
                    hide: true,
                    addclass: "stack-bottomright"
                });

            })
            .catch(function (data, status) {
                new PNotify({
                    title: 'Error',
                    text: 'There was an error on loading the list',
                    type: 'error',
                    hide: true,
                    addclass: "stack-bottomright"
                });

            });
        }
        function CreateModal(survey) {
            vm.Survey = {
                SurveyId: '',
                SurveyName: '',
                Comments:'',
                Rate: '',
              
            };
        }

        function List() {
            SurveyService.List()
             .then(function (response) {
                 vm.Surveys.response.data;
             })
             .catch(function (data, status) {
                 new PNotify({
                     title: 'Error',
                     text: 'There was an error on loading the list',
                     type: 'error',
                     hide: true,
                     addclass: "stack-bottomright"
                 });

             });
        }

        function Update() {
      
            SurveyService.Update(vm.Survey)
            .then(function (response) {
                List();
                angular.element('#SurveyRate').modal('hide');
            })
            .catch(function (data, status) {
                new PNotify({
                    title: 'Error',
                    text: 'There was an error on loading the list',
                    type: 'error',
                    hide: true,
                    addclass: "stack-bottomright"
                });

            });
        }

        function UpdateModal(survey) {
            vm.Survey = angular.copy(survey);
        }

        function Delete(survey) {
            SurveyService.Delete(survey)
                .then(function (response) {
                    List();
                })
                .catch(function (response) {
                });
        }

  

    }
})();

;
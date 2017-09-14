(function () {
    'use strict';

    angular
    .module('App')
    .controller('AnsweredQuestionController', AnsweredQuestionController);

    AnsweredQuestionController.$inject = ['AnsweredQuestionService'];

    function AnsweredQuestionController(AnsweredQuestionService) {
        var vm = this;

        vm.AnsweredQuestion;

        vm.AnsweredQuestions = [];

        vm.List = List;
        vm.Create = Create;
        vm.CreateModal = CreateModal;
        vm.Update = Update;
        vm.UpdateModal = UpdateModal;
        vm.Delete = Delete;

        function Create() {
            AnsweredQuestionService.Create(vm.AnsweredQuestion)
            .then(function (response) {
                List();
                angular.element('#AnsweredQuestionModal').modal('hide');

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

        function CreateModal(answeredquestion) {
            vm.AnsweredQuestion = {
                AnsweredQuestionid: '',
                Answer: '',
                

            };
        }

        function List() {
            AnsweredQuestionService.List()
             .then(function (response) {
                 vm.AnsweredQuestions = response.data;
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
            AnsweredQuestionService.Update(vm.AnsweredQuestion)
            .then(function (response) {
                List();
                angular.element('#AnsweredQuestionModal').modal('hide');
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

        function UpdateModal(answeredquestion) {
            vm.AnsweredQuestion = angular.copy(answeredquestion);
        }

        function Delete(answeredquestion) {
            AnsweredQuestionService.Delete(answeredquestion)
                .then(function (response) {
                    List();
                })
                .catch(function (response) {
                });
        }

    }
})();
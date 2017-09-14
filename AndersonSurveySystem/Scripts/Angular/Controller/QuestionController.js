(function () {
    'use strict';

    angular
    .module('App')
    .controller('QuestionController', QuestionController);

    QuestionController.$inject = ['QuestionService'];

    function QuestionController(QuestionService) {
        var vm = this;

        vm.Question;

        vm.Questions = [];

        vm.List = List;
        vm.Create = Create;
        vm.CreateModal = CreateModal;
        vm.Update = Update;
        vm.UpdateModal = UpdateModal;
        vm.Delete = Delete;

        function Create() {
            QuestionService.Create(vm.Question)
            .then(function (response) {
                List();
                angular.element('#QuestionModal').modal('hide');

                new PNotify({
                    title: 'Success',
                    text: 'Question Recorded',
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

        function CreateModal(question) {
            vm.Question = {
                QuestionId: '',
                Description: '',

            };
        }

        function List() {
            QuestionService.List()
            .then(function (response) {
                vm.Questions = response.data;
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
            QuestionService.Update(vm.Question)
            .then(function (response) {
                List();
                angular.element('#QuestionModal').modal('hide');
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

        function UpdateModal(question) {
            vm.Question = angular.copy(question);
        }

        function Delete(question) {
            QuestionService.Delete(question)
                .then(function (response) {
                    List();
                })
                .catch(function (response) {
                });
        }

    }
})();
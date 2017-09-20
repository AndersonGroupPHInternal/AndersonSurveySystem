(function () {
    'use strict';

    angular
    .module('App')
    .controller('CommentController', CommentController);

    CommentController.$inject = ['CommentService'];

    function CommentController(CommentService) {
        var vm = this;

        vm.Comment;

        vm.Comments = [];

        vm.List = List;
        vm.Create = Create;
        vm.CreateModal = CreateModal;
        vm.Update = Update;
        vm.UpdateModal = UpdateModal;
        vm.Delete = Delete;



        function Create() {
            CommentService.Create(vm.Comment)
            .then(function (response) {
                List();
                angular.element('#CommentModal').modal('hide');

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

        function CreateModal(comment) {
            vm.Comment = {
                CommentId: '',
                Comments: '',


            };
        }

        function List() {
            CommentService.List()
             .then(function (response) {
                 vm.Comments = response.data;
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
            CommentService.Update(vm.Comments)
            .then(function (response) {
                List();
                angular.element('#CommentModal').modal('hide');
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
        angular.module('rate', []).controller('CommentController', function ($scope, $http) {
            $scope.Comment = null;
            $scope.Comment = [];

            $http({
                method: 'GET',
                url: '/Comment/List',
                data: { CommentId: 3 }
            }).success(function (result) {
                $scope.Comment = result;
            });
        });

        function UpdateModal(comment) {
            vm.Comment = angular.copy(comment);
        }

        function Delete(comment) {
            CommentService.Delete(comment)
                .then(function (response) {
                    List();
                })
                .catch(function (response) {
                });
        }

    }
})();
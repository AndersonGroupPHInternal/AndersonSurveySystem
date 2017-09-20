(function () {
    'use strict';

    angular
    .module('App')
    .controller('EmailController', EmailController);

    EmailController.$inject = ['EmailService'];

    function EmailController(EmailService) {
        var vm = this;

        vm.Email;

        vm.Emails = [];

        vm.List = List;
        vm.Create = Create;
        vm.CreateModal = CreateModal;
        vm.Update = Update;
        vm.UpdateModal = UpdateModal;
        vm.Delete = Delete;



        function Create() {
            EmailService.Create(vm.Email)
            .then(function (response) {
                List();
                angular.element('#EmailModal').modal('hide');

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

        function CreateModal(email) {
            vm.Email = {
                UserId: '',
                UserName: '',
                EmailAd: '',
                ReferenceNumber: '',

            };
        }

        function List() {
            EmailService.List()
             .then(function (response) {
                 vm.Emails = response.data;
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
            EmailService.Update(vm.Email)
            .then(function (response) {
                List();
                angular.element('#EmailModal').modal('hide');
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
        angular.module('email', []).controller('EmailController', function ($scope, $http) {
            $scope.Email = null;
            $scope.Email = [];

            $http({
                method: 'GET',
                url: '/Email/List',
                data: { UserId: 3 }
            }).success(function (result) {
                $scope.Email = result;
            });
        });

        function UpdateModal(email) {
            vm.Email = angular.copy(email);
        }

        function Delete(email) {
            EmailService.Delete(email)
                .then(function (response) {
                    List();
                })
                .catch(function (response) {
                });
        }

    }
})();
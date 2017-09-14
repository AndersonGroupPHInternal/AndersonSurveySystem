(function () {
    'use strict';

    angular
    .module('App')
    .controller('AdminController', AdminController);

    AdminController.$inject = ['AdminService'];

    function AdminController(AdminService) {
        var vm = this;

        vm.Admin;

        vm.Admins = [];

        vm.List = List;
        vm.Create = Create;
        vm.CreateModal = CreateModal;
        vm.Update = Update;
        vm.UpdateModal = UpdateModal;
        vm.Delete = Delete;

        function Create() {
            AdminService.Create(vm.Admin)
            .then(function (response) {
                List();
                angular.element('#AdminModal').modal('hide');

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

        function CreateModal(admin) {
            vm.Admin = {
                AdminId: '',
                AdminName: '',
                UserName: '',
                FirstName: '',
                LastName: '',

            };
        }

        function List() {
            AdminService.List()
             .then(function (response) {
                 vm.Admins = response.data;
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
            AdminService.Update(vm.Admin)
            .then(function (response) {
                List();
                angular.element('#AdminModal').modal('hide');
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

        function UpdateModal(admin) {
            vm.Admin = angular.copy(admin);
        }

        function Delete(admin) {
            AdminService.Delete(admin)
                .then(function (response) {
                    List();
                })
                .catch(function (response) {
                });
        }

    }
})();
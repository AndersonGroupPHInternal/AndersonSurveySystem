(function () {
    'use strict';

    angular
    .module('App')
    .controller('RateController', RateController);

    RateController.$inject = ['RateService'];

    function RateController(RateService) {
        var vm = this;

        vm.Rate;

        vm.Rates = [];

        vm.List = List;
        vm.Create = Create;
        vm.CreateModal = CreateModal;
        vm.Update = Update;
        vm.UpdateModal = UpdateModal;
        vm.Delete = Delete;



        function Create() {
            RateService.Create(vm.Rate)
            .then(function (response) {
                List();
                angular.element('#RateModal').modal('hide');

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

        function CreateModal(rate) {
            vm.Rate = {
                RateId: '',
                Rates: '',
                

            };
        }

        function List() {
            RateService.List()
             .then(function (response) {
                 vm.Rates = response.data;
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
            RateService.Update(vm.Rate)
            .then(function (response) {
                List();
                angular.element('#RateModal').modal('hide');
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
        angular.module('rate', []).controller('RateController', function ($scope, $http) {
            $scope.Rate = null;
            $scope.Rate = [];

            $http({
                method: 'GET',
                url: '/Rate/List',
                data: { RatedId: 3 }
            }).success(function (result) {
                $scope.Rate = result;
            });
        });

        function UpdateModal(rate) {
            vm.Rate = angular.copy(rate);
        }

        function Delete(survey) {
            RateService.Delete(rate)
                .then(function (response) {
                    List();
                })
                .catch(function (response) {
                });
        }

    }
})();
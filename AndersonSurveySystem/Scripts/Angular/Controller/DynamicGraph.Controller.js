(function () {
    'use strict';

    angular
        .module('App')
        .controller('DynamicGraphController', DynamicGraphController);

    DynamicGraphController.$inject = ['DynamicGraphService'];

    function DynamicGraphController(DynamicGraphService) {
        var vm = this;
        //object
        vm.Chart = null;
        //object array
        vm.Labels = [];
        vm.Series = [];
        vm.Data = [];

        //declared functions
        vm.Initialise = Initialise;

        //public read
        function Initialise() {
            Read();
        }

        function Read() {
            DynamicGraphService.Read()
                .then(function (response) {
                    vm.Chart = response.data;
                    vm.Series = vm.Chart.map(function (a) { return a.Series; });

                    var ChartData = vm.Chart.map(function (a) { return a.ChartData; });

                    vm.Labels = ChartData[0].map(function (a) { return a.Label; });

                    angular.forEach(ChartData, function (value, key) {
                        var dataList = value.map(function (a) { return a.Data; });
                        vm.Data.push(dataList);
                    });
                })
                .catch(function (data, status) {
                });
        }

    }
})();
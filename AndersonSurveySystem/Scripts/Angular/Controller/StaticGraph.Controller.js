(function () {
    'use strict';

    angular
        .module('App',['chart.jas'])
        .controller('StaticGraphController', StaticGraphController);

    StaticGraphController.$inject = [];

    function StaticGraphController() {
        var vm = this;
        //object array
        vm.Labels = [];
        vm.Series = [];
        vm.Data = [];

        //declared functions
        vm.Initialise = Initialise;

        //public read
        function Initialise() {
           
            vm.Labels = ['2006', '2007', '2008', '2009', '2010', '2011', '2012'];
            vm.Series = ['Series A', 'Series B'];

            vm.Data = [
                [65, 59, 80, 81, 56, 55, 40],
                [28, 48, 40, 19, 86, 27, 90]
            ];
        }

    }
})();
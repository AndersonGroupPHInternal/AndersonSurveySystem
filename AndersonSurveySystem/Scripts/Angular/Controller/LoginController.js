(function () {
    var app = angular.module('myApp', ['ui.router']);

    app.run(function ($rootScope, $location, $state, LoginService) {
        $rootScope.$on('$stateChangeStart',
          function (event, toState, toParams, fromState, fromParams) {
              console.log('Changed state to: ' + toState);
          });

        if (!LoginService.isAuthenticated()) {
            $state.transitionTo('login');
        }
    });

    app.config(['$stateProvider', '$urlRouterProvider', function ($stateProvider, $urlRouterProvider) {
        $urlRouterProvider.otherwise('/Admin');

        $stateProvider
          .state('Admin', {
              url: '/Admin',
              templateUrl: 'Admin.html',
              controller: 'LoginController'
          })
          .state('admin', {
              url: '/Admin',
              templateUrl: 'index.html',
              controller: 'AdminController'
          });
    }]);

    app.controller('LoginController', function ($scope, $rootScope, $stateParams, $state, LoginService) {
        $rootScope.title = "AngularJS Login Sample";

        $scope.formSubmit = function () {
            if (LoginService.login($scope.username, $scope.password)) {
                $scope.error = '';
                $scope.username = '';
                $scope.password = '';
                $state.transitionTo('Admin');
            } else {
                $scope.error = "Incorrect username/password !";
            }
        };

    });

    app.controller('AdminController', function ($scope, $rootScope, $stateParams, $state, LoginService) {
        $rootScope.title = "AngularJS Login Sample";

    });

    app.factory('LoginService', function () {
        var UserName = 'UserName';
        var password = 'password';
        var isAuthenticated = false;

        return {
            login: function (UserName, password) {
                isAuthenticated = UserName === Admin && password === pass;
                return isAuthenticated;
            },
            isAuthenticated: function () {
                return isAuthenticated;
            }
        };

    });

})();
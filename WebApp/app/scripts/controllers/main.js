'use strict';

/**
 * @ngdoc function
 * @name spwebApp.controller:MainCtrl
 * @description
 * # MainCtrl
 * Controller of the spwebApp
 * http://localhost:56112/api/upload
 */
angular.module('spwebApp')
  .controller('MainCtrl', function ($scope, $http) {
    $http.get('http://localhost:56112/api/Account/ManageInfo?returnUrl=%2F&generateState=true').then(
      function success(response) {
        console.log(response);
      },
      function error(response) {
        console.log(response);
      }
    );
      $http.get('http://localhost:56112/api/Surveys').then(
      function success(response) {
        console.log(response);
      },
      function error(response) {
        console.log(response);
      }
    );
    $scope.uploadFile = function () {
      var file = $scope.myFile;
      console.log('file is ');
      console.dir(file);
    };
  });

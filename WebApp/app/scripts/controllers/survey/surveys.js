'use strict';

/**
 * @ngdoc function
 * @name spwebApp.controller:SurveySurveysCtrl
 * @description
 * # SurveySurveysCtrl
 * Controller of the spwebApp
 */
angular.module('spwebApp')
  .controller('SurveySurveysCtrl', function ($scope, $location, surveySvc) {
     surveySvc.getSurveys().then(
       function success(response) {
         $scope.surveys = response;
       },
       function error(params) {
         
       }
     );
     
     $scope.viewSurvey = function(surveyId) {
       $location.path('/survey/view-survey').search('surveyId', surveyId);
     }
  });

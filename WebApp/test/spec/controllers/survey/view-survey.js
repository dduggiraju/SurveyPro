'use strict';

describe('Controller: SurveyViewSurveyCtrl', function () {

  // load the controller's module
  beforeEach(module('spwebApp'));

  var SurveyViewSurveyCtrl,
    scope;

  // Initialize the controller and a mock scope
  beforeEach(inject(function ($controller, $rootScope) {
    scope = $rootScope.$new();
    SurveyViewSurveyCtrl = $controller('SurveyViewSurveyCtrl', {
      $scope: scope
      // place here mocked dependencies
    });
  }));

  it('should attach a list of awesomeThings to the scope', function () {
    expect(SurveyViewSurveyCtrl.awesomeThings.length).toBe(3);
  });
});

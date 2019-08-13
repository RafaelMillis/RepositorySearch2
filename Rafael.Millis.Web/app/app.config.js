'use strict';

angular.
  module('movieApp').
  config(['$routeProvider',
    function config($routeProvider) {
      $routeProvider.
        when('/movies', {
          template: '<movie-list></movie-list>'
        }).
        when('/movies/:movieId', {
          template: '<movie-detail></movie-detail>'
        }).
        otherwise('/movies');
    }
  ]);

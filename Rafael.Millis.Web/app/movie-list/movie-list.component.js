'use strict';

// Register `movieList` component, along with its associated controller and template
angular.
  module('movieList').
  component('movieList', {
    templateUrl: 'movie-list/movie-list.template.html',
    controller: ['$http', function MovieListController($http) {
      var webAPIHost = 'http://localhost:50974'; //should be from config file
      var self = this;
      //self.orderProp = 'name';

      $http.get( webAPIHost + '/api/movies').then(function(response) {
        self.movies = response.data;
      });     
    }]
  });

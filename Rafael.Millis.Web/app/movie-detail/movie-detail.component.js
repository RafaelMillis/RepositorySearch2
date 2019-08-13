'use strict';

// Register `movieDetail` component, along with its associated controller and template
angular.
  module('movieDetail').
  component('movieDetail', {
    templateUrl: 'movie-detail/movie-detail.template.html',
    controller: ['$http', '$routeParams',
      function MovieDetailController($http, $routeParams) {
        var self = this;

        $http.get('http://localhost:50974/api/movies/' + $routeParams.movieId).then(function(response) {
          self.movie = response.data;
        });
      }
    ]
  });

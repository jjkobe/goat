'use strict';

var myApp = angular.module('nodejsApp', ['ui.router']);

myApp.config(function ($stateProvider) {

    $stateProvider
      .state('app', {
        url: '',
        views: {
            'head@': {
              templateUrl: 'views/homepage-header.html'
            },
            'content@': {
              templateUrl: 'views/homepage-content.html'
            }
        }
    });

});

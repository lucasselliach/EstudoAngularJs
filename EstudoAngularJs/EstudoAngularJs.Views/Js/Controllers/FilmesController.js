angular.module("SysLocadora").controller("FilmeCtrl", function ($scope, filmeFactory) {

    $scope.Titulo = "Controle Filmes";

    $scope.FilmesGeneros = [];

    $scope.Filmes = [];

    var carregarFilmesGeneros = function ()
    {
        filmeFactory.GetFilmesGeneros()
           .success(function (data, status) {
               $scope.FilmesGeneros = data;
           })
           .error(function (data, status) {
               $scope.message = "Aconteceu um problema: " + status + data;
           });
    }

    var carregarFilmes = function ()
    {
        filmeFactory.GetFilmes()
           .success(function (data, status) {
               $scope.Filmes = data;
           })
           .error(function (data, status) {
               $scope.message = "Aconteceu um problema: " + status + data;
           });
    }

    $scope.adicionarFilme = function (filme)
    {
        filme.filmeGeneroId = filme.filmeGenero.id;
        filmeFactory.SaveFilme(filme)
            .success(function (data, status) {
                delete $scope.FilmeAdd;
                $scope.filmeForm.$setPristine();
                carregarFilmes();
            })
            .error(function (data, status) {
                $scope.message = "Aconteceu um problema: " + status + data;
            });
    };

    $scope.editarFilme = function (filme) {

    };

    $scope.deletarFilme = function (filme) {
        filmeFactory.DeleteFilme(filme.id)
            .success(function (data, status) {
                carregarFilmes();
            })
            .error(function (data, status) {
                $scope.message = "Aconteceu um problema: " + status + data;
            });
    };

    carregarFilmesGeneros();
    carregarFilmes();
});
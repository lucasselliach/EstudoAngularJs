angular.module("SysLocadora").factory("filmeFactory", function ($http) {

    var getFilmesGeneros = function () {
        return $http.get("http://localhost:59330/api/FilmeGenero");
    };

    var getFilmes = function () {
        return $http.get("http://localhost:59330/api/Filme");
    };

    var saveFilme = function (filme) {
        return $http.post("http://localhost:59330/api/Filme", filme);
    };

    var editFilme = function (filmeId, filme) {
        return $http.put("http://localhost:59330/api/Filme", filmeId, filme);
    };

    var deleteFilme = function (filmeId) {
        return $http.delete("http://localhost:59330/api/Filme", filmeId);
    };

    return {
        GetFilmesGeneros: getFilmesGeneros,
        GetFilmes: getFilmes,
        SaveFilme: saveFilme,
        EditFilme: editFilme,
        DeleteFilme: deleteFilme
    };
});
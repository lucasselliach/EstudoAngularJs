angular.module("SysLocadora").factory("mainFactory", function ($http) {

    var getLocacoes = function () {
        return $http.get("http://localhost:59330/api/Locacao");
    };

    var getClientes = function () {
        return $http.get("http://localhost:59330/api/Cliente");
    };

    var getFilmes = function () {
        return $http.get("http://localhost:59330/api/Filme");
    };

    var getFuncionarios = function () {
        return $http.get("http://localhost:59330/api/Funcionario");
    };
    
    var getLocacoesById = function (locacaoId) {
        return $http.get("http://localhost:59330/api/Locacao");
    };

    var saveLocacao = function (locacoes) {
        return $http.post("http://localhost:59330/api/Locacao", locacoes);
    };

    return {
        GetLocacoes: getLocacoes,
        GetClientes: getClientes,
        GetFilmes: getFilmes,
        GetFuncionarios: getFuncionarios,
        GetLocacoesById: getLocacoesById,
        SaveLocacao: saveLocacao
    };
});
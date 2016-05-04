angular.module("SysLocadora").controller("MainCtrl", function ($scope, $translate, mainFactory) {

    //Titulo 
    //Recommended: don't translate in the controller, translate in your view
    $translate('Page_Main_Titulo').then(function (translatedValue) {
        $scope.Titulo = translatedValue;
    });
 
    $scope.Locacoes = [];

    $scope.Clientes = [];

    $scope.Filmes = [];

    $scope.Funcionarios = [];
    
    var carregarLocacoes = function () {
        mainFactory.GetLocacoes()
            .success(function (data, status) {
                $scope.Locacoes = data;
            })
            .error(function (data, status) {
                $scope.message = "Aconteceu um problema: " + status + data;
            });
    }

    var carregarClientes = function () {
        mainFactory.GetClientes()
            .success(function (data, status) {
                $scope.Clientes = data;
            })
            .error(function (data, status) {
                $scope.message = "Aconteceu um problema: " + status + data;
            });
    }

    var carregarFilmes = function () {
        mainFactory.GetFilmes()
            .success(function (data, status) {
                $scope.Filmes = data;
            })
            .error(function (data, status) {
                $scope.message = "Aconteceu um problema: " + status + data;
            });
    }

    var carregarFuncionarios = function () {
        mainFactory.GetFuncionarios()
            .success(function (data, status) {
                $scope.Funcionarios = data;
            })
            .error(function (data, status) {
                $scope.message = "Aconteceu um problema: " + status + data;
            });
    }

    $scope.adicionarAlocacao = function (alocacao) {
        alocacao.clienteQueAlocouId = alocacao.clienteQueAlocou.id;
        alocacao.funcionarioQueAtendeuId = alocacao.filmeAlocado.id;
        alocacao.filmeAlocadoId = alocacao.funcionarioQueAtendeu.id;

        mainFactory.SaveLocacao(alocacao)
            .success(function (data, status) {
                delete $scope.LocacaoAdd;
                $scope.LocacaoForm.$setPristine();
                carregarLocacoes();
            })
            .error(function (data, status) {
                $scope.message = "Aconteceu um problema: " + status + data;
            });
    };

    carregarLocacoes();
    carregarClientes();
    carregarFilmes();
    carregarFuncionarios();
});
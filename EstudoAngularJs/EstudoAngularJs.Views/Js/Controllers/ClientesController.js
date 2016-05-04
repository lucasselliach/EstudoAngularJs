angular.module("SysLocadora").controller("ClienteCtrl", function ($scope, clienteFactory) {

    $scope.Titulo = "Controle Clientes";

    $scope.Clientes = [];

    var carregarClientes = function () {
        clienteFactory.GetClientes()
            .success(function (data, status) {
                $scope.Clientes = data;
            })
            .error(function (data, status) {
                $scope.message = "Aconteceu um problema: " + status + data;
            });
    }

    $scope.adicionarCliente = function (cliente) {
        clienteFactory.SaveCliente(cliente)
            .success(function (data, status) {
                delete $scope.cliente;
                carregarClientes();
            })
            .error(function (data, status) {
                $scope.message = "Aconteceu um problema: " + status + data;
            });
    };

    carregarClientes();
});
angular.module("SysLocadora").factory("clienteFactory", function ($http) {
    var getClientes = function () {
        return $http.get("http://localhost:59330/api/Cliente");
    };

    var saveCliente = function (cliente) {
        return $http.post("http://localhost:59330/api/Cliente", cliente);
    };

    return {
        GetClientes: getClientes,
        SaveCliente: saveCliente
    };
});
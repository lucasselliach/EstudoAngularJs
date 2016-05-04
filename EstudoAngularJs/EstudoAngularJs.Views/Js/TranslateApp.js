angular.module("SysLocadora").config(['$translateProvider', function ($translateProvider) {
    $translateProvider.translations('en', {
        WebSite_Titulo: 'System Movies - V1',
        navBar_Locacoes: 'Locations',
        navBar_Clientes: 'Clients',
        navBar_Filmes: 'Movies',
        navBar_Funcionarios: 'Employees',
        Page_Main_Titulo: 'Movies Control',
        Page_Main_placeholder: 'What are you searching?',
        Page_Main_Table_Cliente: 'Client',
        Page_Main_Table_Filme: 'Movie',
        Page_Main_Table_Funcionario: 'Employee',
        Page_Main_Table_DataAlocacao: 'Lease Date',
        Page_Main_Table_TipoLocacao: 'Lease Type',
        Page_Main_Table_Button_Finalizar: 'Close',
        Page_Main_Container_Panel_Heading_AdicionarLocacao: 'Add Lease',
        Page_Main_Container_Panel_Body_LocacaoAddClienteQueAlocou: 'Choose a client',
        Page_Main_Container_Panel_Body_LocacaoAddfilmeAlocado: 'Choose a movie',
        Page_Main_Container_Panel_Body_LocacaoAddfuncionarioQueAtendeu: 'Choose a employee',
        Page_Main_Container_Panel_Body_LocacaoTarifa: 'Choose a fare',
        Page_Main_Container_Panel_Body_LocacaoTarifaSL: 'Expensive',
        Page_Main_Container_Panel_Body_LocacaoTarifaL: 'Less Expensive',
        Page_Main_Container_Panel_Body_LocacaoTarifaN: 'Normal',
        Page_Main_Container_Panel_Body_Button_LocacaoAdd: 'Create Lease'
    });

    $translateProvider.translations('pt', {
        WebSite_Titulo: 'Sistema de Locadora - V1',
        navBar_Locacoes: 'Locações',
        navBar_Clientes: 'Clientes',
        navBar_Filmes: 'Filmes',
        navBar_Funcionarios: 'Funcionarios',
        Page_Main_Titulo: 'Controle Filmes',
        Page_Main_placeholder: 'O que você está procurando?',
        Page_Main_Table_Cliente: 'Cliente',
        Page_Main_Table_Filme: 'Filme',
        Page_Main_Table_Funcionario: 'Funcionario',
        Page_Main_Table_DataAlocacao: 'Data Locação',
        Page_Main_Table_TipoLocacao: 'Tipo Locação',
        Page_Main_Table_Button_Finalizar: 'Finalizar',
        Page_Main_Container_Panel_Heading_AdicionarLocacao: 'Adicionar Locação',
        Page_Main_Container_Panel_Body_LocacaoAddClienteQueAlocou: 'Selecione um cliente',
        Page_Main_Container_Panel_Body_LocacaoAddfilmeAlocado: 'Selecione um filme',
        Page_Main_Container_Panel_Body_LocacaoAddfuncionarioQueAtendeu: 'Selecione um funcionario',
        Page_Main_Container_Panel_Body_LocacaoTarifa: 'Selecione a tarifa',
        Page_Main_Container_Panel_Body_LocacaoTarifaSL: 'SuperLançamento',
        Page_Main_Container_Panel_Body_LocacaoTarifaL: 'Lançamento',
        Page_Main_Container_Panel_Body_LocacaoTarifaN: 'Normal',
        Page_Main_Container_Panel_Body_Button_LocacaoAdd: 'Criar Locação'

    });

    $translateProvider.preferredLanguage('pt'); //temos que dizer qual é a default.
}]);


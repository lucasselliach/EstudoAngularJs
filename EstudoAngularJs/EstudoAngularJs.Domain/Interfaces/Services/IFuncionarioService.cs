using System;
using System.Collections.Generic;
using EstudoAngularJs.Domain.Entities;

namespace EstudoAngularJs.Domain.Interfaces.Services
{
    public interface IFuncionarioService
    {
        void RegistrarFuncionario(string nome, int numero, DateTime dataInicio);
        IEnumerable<Funcionario> AdiquireFuncionarios();
        Funcionario AdiquireFuncionario(Guid id);
        void EditarFuncionario(Guid id, string nome, int numero, DateTime dataInicio);
        void ExcluirFuncionario(Guid id);
        void AumentarRankEmQuantidadeDeAlugueisRealizados(Guid id);
    }
}

using System;
using System.Collections.Generic;
using EstudoAngularJs.Domain.Entities;

namespace EstudoAngularJs.Domain.Interfaces.Services
{
    public interface IClienteService
    {
        void RegistrarCliente(string nome, string cpf, DateTime nascimento);
        IEnumerable<Cliente> AdiquireClientes();
        Cliente AdiquireCliente(Guid id);
        void AtualizaCliente(Guid id, string nome, string cpf, DateTime nascimento);
        void RemoveCliente(Guid id);
    }
}

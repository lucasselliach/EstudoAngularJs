using System;
using System.Collections.Generic;
using EstudoAngularJs.Domain.Entities;
using EstudoAngularJs.Domain.Interfaces.Repositories;
using EstudoAngularJs.Domain.Interfaces.Services;

namespace EstudoAngularJs.Domain.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public void RegistrarCliente(string nome, string cpf, DateTime nascimento)
        {
            var cliente = new Cliente(nome, cpf, nascimento);
            _clienteRepository.Add(cliente);
        }

        public IEnumerable<Cliente> AdiquireClientes()
        {
            return _clienteRepository.GetAll();
        }

        public Cliente AdiquireCliente(Guid id)
        {
            return _clienteRepository.GetById(id);
        }

        public void AtualizaCliente(Guid id, string nome, string cpf, DateTime nascimento)
        {
            var cliente = _clienteRepository.GetById(id);

            cliente.AlterarNome(nome);
            cliente.AlterarCpf(cpf);
            cliente.AlterarNascimento(nascimento);

            _clienteRepository.Update(cliente);
        }

        public void RemoveCliente(Guid id)
        {
            var cliente = _clienteRepository.GetById(id);
            _clienteRepository.Remove(cliente);
        }
    }
}

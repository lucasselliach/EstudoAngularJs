using System;
using System.Collections.Generic;
using EstudoAngularJs.Domain.Entities;
using EstudoAngularJs.Domain.Interfaces.Repositories;
using EstudoAngularJs.Domain.Interfaces.Services;

namespace EstudoAngularJs.Domain.Services
{
    public class FuncionarioService : IFuncionarioService
    {
        private readonly IFuncionarioRepository _funcionarioRepository;

        public FuncionarioService(IFuncionarioRepository funcionarioRepository)
        {
            _funcionarioRepository = funcionarioRepository;
        }

        public void RegistrarFuncionario(string nome, int numero, DateTime dataInicio)
        {
            var funcionario = new Funcionario(nome, numero, dataInicio);
            _funcionarioRepository.Add(funcionario);
        }

        public IEnumerable<Funcionario> AdiquireFuncionarios()
        {
            return _funcionarioRepository.GetAll();
        }

        public Funcionario AdiquireFuncionario(Guid id)
        {
            return _funcionarioRepository.GetById(id);
        }

        public void EditarFuncionario(Guid id, string nome, int numero, DateTime dataInicio)
        {
            var funcionario =  _funcionarioRepository.GetById(id);

            funcionario.AlterarNome(nome);
            funcionario.AlterarNumeroFuncionario(numero);
            funcionario.AlterarDataDeInicio(dataInicio);

            _funcionarioRepository.Update(funcionario);
        }

        public void ExcluirFuncionario(Guid id)
        {
            var funcionario = _funcionarioRepository.GetById(id);
            _funcionarioRepository.Remove(funcionario);
        }

        public void AumentarRankEmQuantidadeDeAlugueisRealizados(Guid id)
        {
            var funcionario = _funcionarioRepository.GetById(id);
            funcionario.RealizouUmAluguel();
            _funcionarioRepository.Update(funcionario);
        }
    }
}

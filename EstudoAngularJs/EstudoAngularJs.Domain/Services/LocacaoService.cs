using System;
using System.Collections.Generic;
using EstudoAngularJs.Domain.Entities;
using EstudoAngularJs.Domain.Interfaces.Repositories;
using EstudoAngularJs.Domain.Interfaces.Services;

namespace EstudoAngularJs.Domain.Services
{
    public class LocacaoService : ILocacaoService
    {
        private readonly ILocacaoRepository _locacaoRepository;

        public LocacaoService(ILocacaoRepository locacaoRepository)
        {
            _locacaoRepository = locacaoRepository;
        }

        public void RegistrarLocacao(Guid clienteQueAlocouId, Guid funcionarioQueAtendeuId, Guid filmeAlocadoId, int locacaoTipoInt)
        {
            var locacaoTipo = (LocacaoTipo) Enum.ToObject(typeof(LocacaoTipo), locacaoTipoInt);
            var locacao = new Locacao(clienteQueAlocouId, funcionarioQueAtendeuId, filmeAlocadoId, locacaoTipo);
            _locacaoRepository.Add(locacao);
        }

        public IEnumerable<Locacao> AdiquireLocacoesAtivas()
        {
            return _locacaoRepository.GetAllAtivos();
        }

        public IEnumerable<Locacao> AdiquireLocacoes()
        {
            return _locacaoRepository.GetAll();
        }

        public Locacao AdiquireLocacao(Guid id)
        {
            return _locacaoRepository.GetById(id);
        }

        public void EditarLocacao(Guid id, int locacaoTipoInt)
        {
            var locacaoTipo = (LocacaoTipo)Enum.ToObject(typeof(LocacaoTipo), locacaoTipoInt);

            var locacao = _locacaoRepository.GetById(id);
            locacao.AlterarTipoDeLocacao(locacaoTipo);
            
            _locacaoRepository.Update(locacao);
        }

        public void FinalizarLocacao(Guid id)
        {
            var locacao = _locacaoRepository.GetById(id);
            locacao.RealizarEntrega();

            _locacaoRepository.Update(locacao);
        }
    }
}

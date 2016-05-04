using System;
using System.Collections.Generic;
using EstudoAngularJs.Domain.Entities;

namespace EstudoAngularJs.Domain.Interfaces.Services
{
    public interface ILocacaoService
    {
        void RegistrarLocacao(Guid clienteQueAlocouId, Guid funcionarioQueAtendeuId, Guid filmeAlocadoId, int locacaoTipoInt);
        IEnumerable<Locacao> AdiquireLocacoesAtivas();
        IEnumerable<Locacao> AdiquireLocacoes();
        Locacao AdiquireLocacao(Guid id);
        void EditarLocacao(Guid id, int locacaoTipoInt);
        void FinalizarLocacao(Guid id);
    }
}

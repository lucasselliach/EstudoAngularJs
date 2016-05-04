using System;
using System.Collections.Generic;
using EstudoAngularJs.Domain.Entities;

namespace EstudoAngularJs.Domain.Interfaces.Services
{
    public interface IFilmeService
    {
        void RegistrarFilme(string nome, Guid filmeGeneroId, DateTime anoLançamento);
        IEnumerable<Filme> AdiquireFilmes();
        Filme AdiquireFilme(Guid id);
        void EditarFilme(Guid id, string nome, Guid filmeGeneroId, DateTime anoLançamento);
        void ExcluirFilme(Guid id);
    }
}

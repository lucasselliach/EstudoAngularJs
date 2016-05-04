using System;
using System.Collections.Generic;
using EstudoAngularJs.Domain.Entities;

namespace EstudoAngularJs.Domain.Interfaces.Services
{
    public interface IFilmeGeneroService
    {
        void RegistrarFilmeGenero(string nome);
        IEnumerable<FilmeGenero> AdiquireFilmesGeneros();
        FilmeGenero AdiquireFilmeGeneroById(Guid id);
        void ExcluirFilmeGenero(Guid id);
    }
}

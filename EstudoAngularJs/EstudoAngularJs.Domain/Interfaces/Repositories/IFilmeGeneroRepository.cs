using System;
using System.Collections.Generic;
using EstudoAngularJs.Domain.Entities;

namespace EstudoAngularJs.Domain.Interfaces.Repositories
{
    public interface IFilmeGeneroRepository
    {
        void Add(FilmeGenero filmeGenero);
        IEnumerable<FilmeGenero> GetAll();
        FilmeGenero GetById(Guid id);
        void Update(FilmeGenero filmeGenero);
        void Remove(FilmeGenero filmeGenero);
    }
}

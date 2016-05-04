using System;
using System.Collections.Generic;
using EstudoAngularJs.Domain.Entities;

namespace EstudoAngularJs.Domain.Interfaces.Repositories
{
    public interface IFilmeRepository
    {
        void Add(Filme filme);
        IEnumerable<Filme> GetAll();
        Filme GetById(Guid id);
        void Update(Filme filme);
        void Remove(Filme filme);
    }
}

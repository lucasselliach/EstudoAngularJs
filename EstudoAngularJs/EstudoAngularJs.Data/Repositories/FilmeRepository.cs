using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using EstudoAngularJs.Data.Context;
using EstudoAngularJs.Domain.Entities;
using EstudoAngularJs.Domain.Interfaces.Repositories;

namespace EstudoAngularJs.Data.Repositories
{
    public class FilmeRepository : IFilmeRepository
    {
        protected EstudoAngularJsDataContext DbContext = new EstudoAngularJsDataContext();
        
        public void Add(Filme filme)
        {
            DbContext.Set<Filme>().Add(filme);
            DbContext.SaveChanges();
        }

        public IEnumerable<Filme> GetAll()
        {
            return DbContext.Set<Filme>().ToList();
        }

        public Filme GetById(Guid id)
        {
            return DbContext.Set<Filme>().FirstOrDefault(x => x.Id == id);
        }

        public void Update(Filme filme)
        {
            DbContext.Entry(filme).State = EntityState.Modified;
            DbContext.SaveChanges();
        }

        public void Remove(Filme filme)
        {
            DbContext.Set<Filme>().Remove(filme);
            DbContext.SaveChanges();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using EstudoAngularJs.Data.Context;
using EstudoAngularJs.Domain.Entities;
using EstudoAngularJs.Domain.Interfaces.Repositories;

namespace EstudoAngularJs.Data.Repositories
{
    public class FilmeGeneroRepository : IFilmeGeneroRepository
    {
        protected EstudoAngularJsDataContext DbContext = new EstudoAngularJsDataContext();

        public void Add(FilmeGenero filmeGenero)
        {
            DbContext.Set<FilmeGenero>().Add(filmeGenero);
            DbContext.SaveChanges();
        }

        public IEnumerable<FilmeGenero> GetAll()
        {
            return DbContext.Set<FilmeGenero>().ToList();
        }

        public FilmeGenero GetById(Guid id)
        {
            return DbContext.Set<FilmeGenero>().FirstOrDefault(x=>x.Id == id);
        }

        public void Update(FilmeGenero filmeGenero)
        {
            DbContext.Entry(filmeGenero).State = EntityState.Modified;
            DbContext.SaveChanges();
        }

        public void Remove(FilmeGenero filmeGenero)
        {
            DbContext.Set<FilmeGenero>().Remove(filmeGenero);
            DbContext.SaveChanges();
        }
        
    }
}

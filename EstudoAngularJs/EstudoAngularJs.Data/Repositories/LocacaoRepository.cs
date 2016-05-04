using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using EstudoAngularJs.Data.Context;
using EstudoAngularJs.Domain.Entities;
using EstudoAngularJs.Domain.Interfaces.Repositories;

namespace EstudoAngularJs.Data.Repositories
{
    public class LocacaoRepository : ILocacaoRepository
    {
        protected EstudoAngularJsDataContext DbContext = new EstudoAngularJsDataContext();

        public void Add(Locacao locacao)
        {
            DbContext.Set<Locacao>().Add(locacao);
            DbContext.SaveChanges();
        }

        public IEnumerable<Locacao> GetAllAtivos()
        {
            return DbContext.Set<Locacao>().Where(x => x.JaEntregou == false);
        }

        public IEnumerable<Locacao> GetAll()
        {
            return DbContext.Set<Locacao>().ToList();
        }

        public Locacao GetById(Guid id)
        {
            return DbContext.Set<Locacao>().FirstOrDefault(x=>x.Id == id);
        }

        public void Update(Locacao locacao)
        {
            DbContext.Entry(locacao).State = EntityState.Modified;
            DbContext.SaveChanges();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using EstudoAngularJs.Data.Context;
using EstudoAngularJs.Domain.Entities;
using EstudoAngularJs.Domain.Interfaces.Repositories;

namespace EstudoAngularJs.Data.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        protected EstudoAngularJsDataContext DbContext = new EstudoAngularJsDataContext();

        public void Add(Cliente cliente)
        {
            DbContext.Set<Cliente>().Add(cliente);
            DbContext.SaveChanges();
        }

        public IEnumerable<Cliente> GetAll()
        {
            return DbContext.Set<Cliente>().ToList();
        }

        public Cliente GetById(Guid id)
        {
            return DbContext.Set<Cliente>().FirstOrDefault(x => x.Id == id);
        }

        public void Update(Cliente cliente)
        {
            DbContext.Entry(cliente).State = EntityState.Modified;
            DbContext.SaveChanges();
        }

        public void Remove(Cliente cliente)
        {
            DbContext.Set<Cliente>().Remove(cliente);
            DbContext.SaveChanges();
        }
    }
}

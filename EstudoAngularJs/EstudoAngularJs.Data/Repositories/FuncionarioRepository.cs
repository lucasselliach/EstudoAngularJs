using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using EstudoAngularJs.Data.Context;
using EstudoAngularJs.Domain.Entities;
using EstudoAngularJs.Domain.Interfaces.Repositories;

namespace EstudoAngularJs.Data.Repositories
{
    public class FuncionarioRepository : IFuncionarioRepository
    {
        protected EstudoAngularJsDataContext DbContext = new EstudoAngularJsDataContext();

        public void Add(Funcionario funcionario)
        {
            DbContext.Set<Funcionario>().Add(funcionario);
            DbContext.SaveChanges();
        }

        public IEnumerable<Funcionario> GetAll()
        {
            return DbContext.Set<Funcionario>().ToList();
        }

        public Funcionario GetById(Guid id)
        {
            return DbContext.Set<Funcionario>().FirstOrDefault(x=>x.Id == id);
        }

        public void Update(Funcionario funcionario)
        {
            DbContext.Entry(funcionario).State = EntityState.Modified;
            DbContext.SaveChanges();
        }

        public void Remove(Funcionario funcionario)
        {
            DbContext.Set<Funcionario>().Remove(funcionario);
            DbContext.SaveChanges();
        }
    }
}

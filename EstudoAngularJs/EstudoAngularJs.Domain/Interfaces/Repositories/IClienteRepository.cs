using System;
using System.Collections.Generic;
using EstudoAngularJs.Domain.Entities;

namespace EstudoAngularJs.Domain.Interfaces.Repositories
{
    public interface IClienteRepository
    {
        void Add(Cliente cliente);
        IEnumerable<Cliente> GetAll();
        Cliente GetById(Guid id);
        void Update(Cliente cliente);
        void Remove(Cliente cliente);
    }
}

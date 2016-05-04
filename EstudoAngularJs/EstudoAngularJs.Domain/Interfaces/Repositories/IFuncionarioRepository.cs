using System;
using System.Collections.Generic;
using EstudoAngularJs.Domain.Entities;

namespace EstudoAngularJs.Domain.Interfaces.Repositories
{
    public interface IFuncionarioRepository
    {
        void Add(Funcionario funcionario);
        IEnumerable<Funcionario> GetAll();
        Funcionario GetById(Guid id);
        void Update(Funcionario funcionario);
        void Remove(Funcionario funcionario);
    }
}

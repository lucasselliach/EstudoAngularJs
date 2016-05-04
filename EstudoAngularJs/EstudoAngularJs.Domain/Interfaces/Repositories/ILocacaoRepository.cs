using System;
using System.Collections.Generic;
using EstudoAngularJs.Domain.Entities;

namespace EstudoAngularJs.Domain.Interfaces.Repositories
{
    public interface ILocacaoRepository
    {
        void Add(Locacao locacao);
        IEnumerable<Locacao> GetAllAtivos();
        IEnumerable<Locacao> GetAll();
        Locacao GetById(Guid id);
        void Update(Locacao locacao);
    }
}

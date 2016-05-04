using System;
using System.Collections.Generic;
using EstudoAngularJs.Domain.Entities;
using EstudoAngularJs.Domain.Interfaces.Repositories;
using EstudoAngularJs.Domain.Interfaces.Services;

namespace EstudoAngularJs.Domain.Services
{
    public class FilmeService : IFilmeService
    {
        private readonly IFilmeRepository _filmeRepository;

        public FilmeService(IFilmeRepository filmeRepository)
        {
            _filmeRepository = filmeRepository;
        }

        public void RegistrarFilme(string nome, Guid filmeGeneroId, DateTime anoLançamento)
        {
            var filme = new Filme(nome, filmeGeneroId, anoLançamento);
            _filmeRepository.Add(filme);
        }

        public IEnumerable<Filme> AdiquireFilmes()
        {
            return _filmeRepository.GetAll();
        }

        public Filme AdiquireFilme(Guid id)
        {
            return _filmeRepository.GetById(id);
        }

        public void EditarFilme(Guid id, string nome, Guid filmeGeneroId, DateTime anoLançamento)
        {
            var filme = _filmeRepository.GetById(id);
            
            filme.AlterarNome(nome);
            filme.AlterarFilmeGeneroId(filmeGeneroId);
            filme.AlterarAnoLancamento(anoLançamento);
            
            _filmeRepository.Update(filme);
        }

        public void ExcluirFilme(Guid id)
        {
            var filme = _filmeRepository.GetById(id);

            filme.DesativaFilme();

            _filmeRepository.Update(filme);
        }
    }
}

using System;
using System.Collections.Generic;
using EstudoAngularJs.Domain.Entities;
using EstudoAngularJs.Domain.Interfaces.Repositories;
using EstudoAngularJs.Domain.Interfaces.Services;

namespace EstudoAngularJs.Domain.Services
{
    public class FilmeGeneroService : IFilmeGeneroService
    {
        private readonly IFilmeGeneroRepository _filmeGeneroRepository;

        public FilmeGeneroService(IFilmeGeneroRepository filmeGeneroRepository)
        {
            _filmeGeneroRepository = filmeGeneroRepository;
        }

        public void RegistrarFilmeGenero(string nome)
        {
            var filmeGenero = new FilmeGenero(nome);
            _filmeGeneroRepository.Add(filmeGenero);
        }

        public IEnumerable<FilmeGenero> AdiquireFilmesGeneros()
        {
            return _filmeGeneroRepository.GetAll();
        }

        public FilmeGenero AdiquireFilmeGeneroById(Guid id)
        {
            return _filmeGeneroRepository.GetById(id);
        }

        public void ExcluirFilmeGenero(Guid id)
        {
            var filme = _filmeGeneroRepository.GetById(id);
            _filmeGeneroRepository.Remove(filme);
        }
    }
}

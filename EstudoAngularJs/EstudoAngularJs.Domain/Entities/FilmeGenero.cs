using System;

namespace EstudoAngularJs.Domain.Entities
{
    public class FilmeGenero
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        
        protected FilmeGenero() { }

        public FilmeGenero(string nome)
        {
            Id = Guid.NewGuid();
            Nome = nome;
        }
    }
}

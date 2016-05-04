using System;

namespace EstudoAngularJs.Domain.Entities
{
    public class Filme
    {
        public Guid Id { get; private set; }
        public string Nome { get; private set; }
        public Guid FilmeGeneroId { get; private set; }
        public DateTime AnoLancamento { get; private set; }
        public bool Ativo { get; private set; }

        public virtual FilmeGenero FilmeGenero { get; set; }

        protected Filme() { }

        public Filme(string nome, Guid filmeGeneroId, DateTime anoLancamento)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            FilmeGeneroId = filmeGeneroId;
            AnoLancamento = anoLancamento;
            Ativo = true;
        }



        public void AlterarNome(string nome)
        {
            Nome = nome;
        }

        public void AlterarFilmeGeneroId(Guid filmeGeneroId)
        {
            FilmeGeneroId = filmeGeneroId;
        }

        public void AlterarAnoLancamento(DateTime anoLancamento)
        {
            AnoLancamento = anoLancamento;
        }

        public void DesativaFilme()
        {
            Ativo = false;
        }

        public void AtivaFilme()
        {
            Ativo = true;
        }
    }
}
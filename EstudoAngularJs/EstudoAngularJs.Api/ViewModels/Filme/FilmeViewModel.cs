using System;

namespace EstudoAngularJs.Api.ViewModels.Filme
{
    public class FilmeViewModel
    {
        public string Nome { get; set; }
        public Guid FilmeGeneroId { get; set; }
        public DateTime AnoLancamento { get; set; }
    }
}
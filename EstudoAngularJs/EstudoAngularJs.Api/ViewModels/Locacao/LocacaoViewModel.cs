using System;

namespace EstudoAngularJs.Api.ViewModels.Locacao
{
    public class NovoLocacaoViewModel
    {
        public Guid ClienteQueAlocouId { get; set; }
        public Guid FuncionarioQueAtendeuId { get; set; }
        public Guid FilmeAlocadoId { get; set; }
        public int TipoLocacao { get; set; }
    }
}
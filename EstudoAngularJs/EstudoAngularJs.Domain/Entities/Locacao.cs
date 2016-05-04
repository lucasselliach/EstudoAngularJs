using System;

namespace EstudoAngularJs.Domain.Entities
{
    public class Locacao
    {
        public Guid Id { get; set; }
        public Guid ClienteQueAlocouId { get; set; }
        public Guid FuncionarioQueAtendeuId { get; set; }
        public Guid FilmeAlocadoId { get; set; }
        public DateTime DataDeAlocacao { get; set; }
        public LocacaoTipo LocacaoTipo { get; set; }
        public bool JaEntregou { get; set; }
        public DateTime DataEntrega { get; set; }

        public virtual Cliente ClienteQueAlocou { get; set; }
        public virtual Funcionario FuncionarioQueAtendeu { get; set; }
        public virtual Filme FilmeAlocado { get; set; }
        
        protected Locacao() { }

        public Locacao(Guid clienteQueAlocouId, Guid funcionarioQueAtendeuId, Guid filmeAlocadoId, LocacaoTipo locacaoTipo)
        {
            Id = Guid.NewGuid();
            ClienteQueAlocouId = clienteQueAlocouId;
            FuncionarioQueAtendeuId = funcionarioQueAtendeuId;
            FilmeAlocadoId = filmeAlocadoId;
            LocacaoTipo = locacaoTipo;
            DataDeAlocacao = DateTime.Now;
            DataEntrega = Convert.ToDateTime("01-01-2000");
        }

        public void AlterarTipoDeLocacao(LocacaoTipo locacaoTipo)
        {
            LocacaoTipo = locacaoTipo;
        }

        public void RealizarEntrega()
        {
            JaEntregou = true;
            DataEntrega = DateTime.Now;
        }
    }
}

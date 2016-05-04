using System;

namespace EstudoAngularJs.Domain.Entities
{
    public class Funcionario
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public int NumeroFuncionario { get; set; }
        public DateTime DataDeInicio { get; set; }
        public int QuantidadeDeAlugueisRealizados { get; set; }
        public bool Ativo { get; set; }
        
        protected Funcionario() { }

        public Funcionario(string nome, int numeroFuncionario, DateTime dataDeInicio)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            NumeroFuncionario = numeroFuncionario;
            DataDeInicio = dataDeInicio;
            QuantidadeDeAlugueisRealizados = 0;
            Ativo = true;
        }

        public void AlterarNome(string nome)
        {
            Nome = nome;
        }

        public void AlterarNumeroFuncionario(int numeroFuncionario)
        {
            NumeroFuncionario = numeroFuncionario;
        }

        public void AlterarDataDeInicio(DateTime dataDeInicio)
        {
            DataDeInicio = dataDeInicio;
        }

        public void RealizouUmAluguel()
        {
            QuantidadeDeAlugueisRealizados++;
        }

        public void DesativaFuncionario()
        {
            Ativo = false;
        }

        public void AtivaFuncionario()
        {
            Ativo = true;
        }
    }
}

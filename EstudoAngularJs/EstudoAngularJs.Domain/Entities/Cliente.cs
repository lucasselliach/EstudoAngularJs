using System;

namespace EstudoAngularJs.Domain.Entities
{
    public class Cliente
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime Nascimento { get; set; }
        public bool Ativo { get; set; }

        protected Cliente() { }

        public Cliente(string nome, string cpf, DateTime nascimento)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            Cpf = cpf;
            Nascimento = nascimento;
            Ativo = true;
        }



        public void AlterarNome(string nome)
        {
            Nome = nome;
        }

        public void AlterarCpf(string cpf)
        {
            Cpf = cpf;
        }

        public void AlterarNascimento(DateTime nascimento)
        {
            Nascimento = nascimento;
        }

        public void DesativaCliente()
        {
            Ativo = false;
        }

        public void AtivaCliente()
        {
            Ativo = true;
        }
    }
}

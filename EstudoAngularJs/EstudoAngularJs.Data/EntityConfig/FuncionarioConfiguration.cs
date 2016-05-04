using System.Data.Entity.ModelConfiguration;
using EstudoAngularJs.Domain.Entities;

namespace EstudoAngularJs.Data.EntityConfig
{
    public class FuncionarioConfiguration : EntityTypeConfiguration<Funcionario>
    {
        public FuncionarioConfiguration()
        {
            HasKey(x => x.Id);
            Property(x => x.Nome).IsRequired().HasMaxLength(200);
            Property(x => x.NumeroFuncionario).IsRequired();
            Property(x => x.DataDeInicio).IsRequired();
            Property(x => x.QuantidadeDeAlugueisRealizados).IsRequired();
            Property(x => x.Ativo).IsRequired();
        }
    }
}

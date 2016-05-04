using System.Data.Entity.ModelConfiguration;
using EstudoAngularJs.Domain.Entities;

namespace EstudoAngularJs.Data.EntityConfig
{
    public class ClienteConfiguration : EntityTypeConfiguration<Cliente>
    {
        public ClienteConfiguration()
        {
            HasKey(x => x.Id);
            Property(x => x.Nome).IsRequired().HasMaxLength(200);
            Property(x => x.Cpf).IsRequired().HasMaxLength(100);
            Property(x => x.Nascimento).IsRequired();
            Property(x => x.Ativo).IsRequired();
        }
    }
}

using System.Data.Entity.ModelConfiguration;
using EstudoAngularJs.Domain.Entities;

namespace EstudoAngularJs.Data.EntityConfig
{
    public class FilmeConfiguration : EntityTypeConfiguration<Filme>
    {
        public FilmeConfiguration()
        {
            HasKey(x => x.Id);
            Property(x => x.Nome).IsRequired().HasMaxLength(200);
            Property(x => x.AnoLancamento).IsRequired();
            Property(x => x.Ativo).IsRequired();
        }
    }
}

using System.Data.Entity.ModelConfiguration;
using EstudoAngularJs.Domain.Entities;

namespace EstudoAngularJs.Data.EntityConfig
{
    public class FilmeGeneroConfiguration : EntityTypeConfiguration<FilmeGenero>
    {
        public FilmeGeneroConfiguration()
        {
            HasKey(x => x.Id);
            Property(x => x.Nome).IsRequired().HasMaxLength(200);
        }
    }
}

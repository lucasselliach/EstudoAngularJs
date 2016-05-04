using System.Data.Entity.ModelConfiguration;
using EstudoAngularJs.Domain.Entities;

namespace EstudoAngularJs.Data.EntityConfig
{
    public class LocacaoConfiguration : EntityTypeConfiguration<Locacao>
    {
        public LocacaoConfiguration()
        {
            HasKey(x => x.Id);
            Property(x => x.DataDeAlocacao).IsRequired();
            Property(x => x.JaEntregou).IsRequired();
            Property(x => x.DataEntrega).IsRequired();
        }
    }
}

using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using EstudoAngularJs.Data.EntityConfig;
using EstudoAngularJs.Domain.Entities;

namespace EstudoAngularJs.Data.Context
{
    public class EstudoAngularJsDataContext : DbContext
    {
        public EstudoAngularJsDataContext() : base("stringConnection")
        {
            Database.SetInitializer<EstudoAngularJsDataContext>(null);
            Configuration.LazyLoadingEnabled = true;
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Filme> Filmes { get; set; }
        public DbSet<FilmeGenero> FilmeGeneros { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Locacao> Locacoes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties<string>().Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Configurations.Add(new ClienteConfiguration());
            modelBuilder.Configurations.Add(new FilmeConfiguration());
            modelBuilder.Configurations.Add(new FilmeGeneroConfiguration());
            modelBuilder.Configurations.Add(new FuncionarioConfiguration());
            modelBuilder.Configurations.Add(new LocacaoConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}

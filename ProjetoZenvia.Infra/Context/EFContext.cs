using ProjetoZenvia.Domain.Entity;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ProjetoZenvia.Infra.Context
{
    public class EFContext : DbContext
    {
        public EFContext() : base("EFConnectionString") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);

        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<ClienteEndereco> ClienteEnderecos { get; set; }
        public DbSet<ClienteContato> ClienteContatos { get; set; }
        public DbSet<TipoContato> TiposContato { get; set; }

    }
}

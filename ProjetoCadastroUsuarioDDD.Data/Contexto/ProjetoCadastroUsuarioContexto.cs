
using ProjetoCadastroUsuarioDDD.Data.EntityConfig;
using ProjetoCadastroUsuarioDDD.Domain.Entities;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ProjetoCadastroUsuarioDDD.Data.Contexto
{
    public class ProjetoCadastroUsuarioContexto : DbContext
    {
        public ProjetoCadastroUsuarioContexto(): base("ProjetoCadastroUsuarioDDD")
        {

        }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties().Where(p => p.Name == p.ReflectedType.Name + "Id").Configure(p => p.IsKey());

            modelBuilder.Properties<string>().Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>().Configure(p => p.HasMaxLength(100));

             modelBuilder.Configurations.Add(new UsuarioConfiguration());
        }
    }
}

using ProjetoCadastroUsuarioDDD.Domain.Entities;

using System.Data.Entity.ModelConfiguration;

namespace ProjetoCadastroUsuarioDDD.Data.EntityConfig
{
    public class UsuarioConfiguration : EntityTypeConfiguration<Usuario>
    {
        public UsuarioConfiguration()
        {
            HasKey(u => u.UsuarioId);
            Property(u => u.Nome).IsRequired().HasMaxLength(150);

            Property(c => c.CPF).IsRequired();
        }
    }
}

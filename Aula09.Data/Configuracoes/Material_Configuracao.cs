using Aula09.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aula09.Dados.Configuracoes
{
    public class Material_Configuracao : IEntityTypeConfiguration<Material> {
        public void Configure(EntityTypeBuilder<Material> builder)
        {
            
            builder.ToTable("Material", "RPG");

            builder.HasKey("CodMaterial");

            builder.Property(f => f.CodMaterial).HasColumnName("CodMaterial");
            builder.Property(f => f.NomeMaterial).HasColumnName("NomeMaterial");
        }
    }
}

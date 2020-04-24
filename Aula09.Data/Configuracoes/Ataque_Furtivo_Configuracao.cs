using Aula09.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aula09.Dados.Configuracoes
{
    public class Ataque_Furtivo_Configuracao : IEntityTypeConfiguration<Ataque_Furtivo> {
        public void Configure(EntityTypeBuilder<Ataque_Furtivo> builder)
        {
            
            builder.ToTable("Ataque_Furtivo", "RPG");

            builder.HasKey("CodClasse");

            builder.Property(f => f.CodClasse).HasColumnName("CodClasse");
            builder.Property(f => f.CodNivel).HasColumnName("CodNivel");
            builder.Property(f => f.QtdDado).HasColumnName("QtdDado");
            builder.Property(f => f.CodDado).HasColumnName("CodDado");
        }
    }
}

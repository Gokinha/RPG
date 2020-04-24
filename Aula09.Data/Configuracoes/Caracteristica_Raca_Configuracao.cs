using Aula09.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aula09.Dados.Configuracoes
{
    public class Caracteristica_Raca_Configuracao : IEntityTypeConfiguration<Caracteristica_Raca> {
        public void Configure(EntityTypeBuilder<Caracteristica_Raca> builder)
        {
            
            builder.ToTable("Caracteristica_Raca", "RPG");

            builder.HasKey("CodCaracteristicas");

            builder.Property(f => f.CodCaracteristicas).HasColumnName("CodCaracteristicas");
            builder.Property(f => f.CodRaca).HasColumnName("CodRaca");
        }
    }
}

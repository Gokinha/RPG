using Aula09.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aula09.Dados.Configuracoes
{
    public class Proficiencia_Arma_Raca_Configuracao : IEntityTypeConfiguration<Proficiencia_Arma_Raca> {
        public void Configure(EntityTypeBuilder<Proficiencia_Arma_Raca> builder)
        {
            
            builder.ToTable("Proficiencia_Arma_Raca", "RPG");

            builder.HasKey("CodArma","CodRaca");

            builder.Property(f => f.CodArma).HasColumnName("CodArma");
            builder.Property(f => f.CodRaca).HasColumnName("CodRaca");
        }
    }
}

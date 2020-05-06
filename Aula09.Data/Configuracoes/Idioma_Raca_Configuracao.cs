using Aula09.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aula09.Dados.Configuracoes
{
    public class Idioma_Raca_Configuracao : IEntityTypeConfiguration<Idioma_Raca> {
        public void Configure(EntityTypeBuilder<Idioma_Raca> builder)
        {
            
            builder.ToTable("Idioma_Raca", "RPG");

            builder.HasKey("CodRaca", "CodIdioma");

            builder.Property(f => f.CodRaca).HasColumnName("CodRaca");
            builder.Property(f => f.CodIdioma).HasColumnName("CodIdioma");
        }
    }
}

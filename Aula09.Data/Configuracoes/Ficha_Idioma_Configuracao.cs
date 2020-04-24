using Aula09.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aula09.Dados.Configuracoes
{
    public class Ficha_Idioma_Configuracao : IEntityTypeConfiguration<Ficha_Idioma> {
        public void Configure(EntityTypeBuilder<Ficha_Idioma> builder)
        {
            
            builder.ToTable("Ficha_Idioma", "RPG");

            builder.HasKey("CodFicha");
            builder.HasKey("CodJogador");
            builder.HasKey("CodIdioma");

            builder.Property(f => f.CodFicha).HasColumnName("CodFicha");
            builder.Property(f => f.CodJogador).HasColumnName("CodJogador");
            builder.Property(f => f.CodIdioma).HasColumnName("CodIdioma");
          
        }
    }
}

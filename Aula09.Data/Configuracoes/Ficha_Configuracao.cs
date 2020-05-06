using Aula09.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aula09.Dados.Configuracoes
{
    public class Ficha_Configuracao : IEntityTypeConfiguration<Ficha> {
        public void Configure(EntityTypeBuilder<Ficha> builder)
        {
            
            builder.ToTable("Ficha", "RPG");

            builder.HasKey("CodFicha", "CodJogador", "CodRaca");

            builder.Property(f => f.CodFicha).HasColumnName("CodFicha");
            builder.Property(f => f.CodJogador).HasColumnName("CodJogador");
            builder.Property(f => f.CodRaca).HasColumnName("CodRaca");
            builder.Property(f => f.NomePersonagem).HasColumnName("NomePersonagem");
            builder.Property(f => f.Vida).HasColumnName("Vida");
          
        }
    }
}

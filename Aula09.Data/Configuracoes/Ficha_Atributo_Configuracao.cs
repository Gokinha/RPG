using Aula09.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aula09.Dados.Configuracoes
{
    public class Ficha_Atributo_Configuracao : IEntityTypeConfiguration<Ficha_Atributo> {
        public void Configure(EntityTypeBuilder<Ficha_Atributo> builder)
        {
            
            builder.ToTable("Ficha_Atributo", "RPG");

            builder.HasKey("CodFicha","CodJogador","CodAtributo");

            builder.Property(f => f.CodFicha).HasColumnName("CodFicha");
            builder.Property(f => f.CodJogador).HasColumnName("CodJogador");
            builder.Property(f => f.CodAtributo).HasColumnName("CodAtributo");
            builder.Property(f => f.VlrAtributo).HasColumnName("VlrAtributo");
        }
    }
}

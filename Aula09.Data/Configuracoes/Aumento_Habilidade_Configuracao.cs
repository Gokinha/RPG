using Aula09.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aula09.Dados.Configuracoes
{
    public class Aumento_Habilidade_Configuracao : IEntityTypeConfiguration<Aumento_Habilidade> {
        public void Configure(EntityTypeBuilder<Aumento_Habilidade> builder)
        {
            
            builder.ToTable("Aumento_Habilidade", "RPG");

            builder.HasKey("CodAtributo");

            builder.Property(f => f.CodAtributo).HasColumnName("CodAtributo");
            builder.Property(f => f.CodRaca).HasColumnName("CodRaca");
            builder.Property(f => f.VlrAumento).HasColumnName("VlrAumento");
        }
    }
}

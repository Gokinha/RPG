using Aula09.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aula09.Dados.Configuracoes
{
    public class Atributo_Configuracao : IEntityTypeConfiguration<Atributo> {
        public void Configure(EntityTypeBuilder<Atributo> builder)
        {
            
            builder.ToTable("Atributo", "RPG");

            builder.HasKey("CodAtributo");

            builder.Property(f => f.CodAtributo).HasColumnName("CodAtributo");
            builder.Property(f => f.NomeAtributo).HasColumnName("NomeAtributo");
        }
    }
}

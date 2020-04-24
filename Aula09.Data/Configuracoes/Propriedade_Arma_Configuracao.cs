using Aula09.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aula09.Dados.Configuracoes
{
    public class Propriedade_Arma_Configuracao : IEntityTypeConfiguration<Propriedade_Arma> {
        public void Configure(EntityTypeBuilder<Propriedade_Arma> builder)
        {
            
            builder.ToTable("Propriedade_Arma", "RPG");

            builder.HasKey("CodPropriedadeArma");

            builder.Property(f => f.CodPropriedadeArma).HasColumnName("CodPropriedadeArma");
            builder.Property(f => f.TipoPropriedade).HasColumnName("TipoPropriedade");
        }
    }
}

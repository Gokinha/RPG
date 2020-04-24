using Aula09.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aula09.Dados.Configuracoes
{
    public class Arma_Propriedade_Arma_Configuracao : IEntityTypeConfiguration<Arma_Propriedade_Arma> {
        public void Configure(EntityTypeBuilder<Arma_Propriedade_Arma> builder)
        {

            builder.ToTable("Arma_Propriedade_Arma", "RPG");

            builder.HasKey("CodPropriedadeArma");

            builder.Property(f => f.CodPropriedadeArma).HasColumnName("CodPropriedadeArma");
            builder.Property(f => f.CodArma).HasColumnName("CodArma");
        }
    }
}

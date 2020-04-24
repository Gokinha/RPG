using Aula09.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aula09.Dados.Configuracoes
{
    public class Arma_Classe_Configuracao : IEntityTypeConfiguration<Arma_Classe> {
        public void Configure(EntityTypeBuilder<Arma_Classe> builder)
        {

            builder.ToTable("Arma_Classe", "RPG");

            builder.HasKey("CodArma", "CodClasse");

            builder.Property(f => f.CodArma).HasColumnName("CodArma");
            builder.Property(f => f.CodClasse).HasColumnName("CodClasse");
        }
    }
}

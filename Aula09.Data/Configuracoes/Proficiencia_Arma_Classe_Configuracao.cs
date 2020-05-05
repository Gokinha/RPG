using Aula09.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aula09.Dados.Configuracoes
{
    public class Proficiencia_Arma_Classe_Configuracao : IEntityTypeConfiguration<Proficiencia_Arma_Classe> {
        public void Configure(EntityTypeBuilder<Proficiencia_Arma_Classe> builder)
        {
            
            builder.ToTable("Proficiencia_Arma_Classe", "RPG");

            builder.HasKey("CodArma","CodClasse");

            builder.Property(f => f.CodArma).HasColumnName("CodArma");
            builder.Property(f => f.CodClasse).HasColumnName("CodClasse");
        }
    }
}

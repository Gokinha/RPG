using Aula09.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aula09.Dados.Configuracoes
{
    public class Proficiencia_Arma_Configuracao : IEntityTypeConfiguration<Proficiencia_Arma> {
        public void Configure(EntityTypeBuilder<Proficiencia_Arma> builder)
        {
            
            builder.ToTable("Proficiencia_Arma", "RPG");

            builder.HasKey("CodArma", "CodClasse");

            builder.Property(f => f.CodArma).HasColumnName("CodArma");
            builder.Property(f => f.CodClasse).HasColumnName("CodClasse");
        }
    }
}

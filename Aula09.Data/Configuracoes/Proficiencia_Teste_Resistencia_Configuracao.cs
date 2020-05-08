using Aula09.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aula09.Dados.Configuracoes
{
    public class Proficiencia_Teste_Resistencia_Configuracao : IEntityTypeConfiguration<Proficiencia_Teste_Resistencia> {
        public void Configure(EntityTypeBuilder<Proficiencia_Teste_Resistencia> builder)
        {
            
            builder.ToTable("Proficiencia_Teste_Resistencia", "RPG");

            builder.HasKey("CodClasse,CodAtributo");

            builder.Property(f => f.CodClasse).HasColumnName("CodClasse");
            builder.Property(f => f.CodAtributo).HasColumnName("CodAtributo");
        }
    }
}

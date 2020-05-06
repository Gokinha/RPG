using Aula09.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aula09.Dados.Configuracoes
{
    public class Proficiencia_Armadura_Configuracao : IEntityTypeConfiguration<Proficiencia_Armadura> {
        public void Configure(EntityTypeBuilder<Proficiencia_Armadura> builder)
        {
            
            builder.ToTable("Proficiencia_Armadura", "RPG");

            builder.HasKey("CodClasse", "CodArmadura");

            builder.Property(f => f.CodClasse).HasColumnName("CodClasse");
            builder.Property(f => f.CodArmadura).HasColumnName("CodArmadura");
        }
    }
}

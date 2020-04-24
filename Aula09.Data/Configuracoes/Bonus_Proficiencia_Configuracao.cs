using Aula09.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aula09.Dados.Configuracoes
{
    public class Bonus_Proficiencia_Configuracao : IEntityTypeConfiguration<Bonus_Proficiencia> {
        public void Configure(EntityTypeBuilder<Bonus_Proficiencia> builder)
        {
            
            builder.ToTable("Bonus_Proficiencia", "RPG");

            builder.HasKey("CodBonusProficiencia");

            builder.Property(f => f.CodBonusProficiencia).HasColumnName("CodBonusProficiencia");
            builder.Property(f => f.Bonus).HasColumnName("Bonus");
            builder.Property(f => f.CodNivel).HasColumnName("CodNivel");
        }
    }
}

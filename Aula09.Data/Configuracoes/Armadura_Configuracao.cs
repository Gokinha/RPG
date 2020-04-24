using Aula09.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aula09.Dados.Configuracoes
{
    public class Armadura_Configuracao : IEntityTypeConfiguration<Armadura> {
        public void Configure(EntityTypeBuilder<Armadura> builder)
        {

            builder.ToTable("Armadura", "RPG");

            builder.HasKey("CodArmadura");

            builder.Property(f => f.CodArmadura).HasColumnName("CodArmadura");
            builder.Property(f => f.Furtividade).HasColumnName("Furtividade");
            builder.Property(f => f.PesoArmadura).HasColumnName("PesoArmadura");
            builder.Property(f => f.ClasseArmadura).HasColumnName("ClasseArmadura");
            builder.Property(f => f.AdicionalArmadura).HasColumnName("AdicionalArmadura");
            builder.Property(f => f.ForcaArmadura).HasColumnName("ForcaArmadura");
            builder.Property(f => f.NomeArmadura).HasColumnName("NomeArmadura");
            builder.Property(f => f.CodTipoArmadura).HasColumnName("CodTipoArmadura");
        }
    }
}

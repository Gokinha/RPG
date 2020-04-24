using Aula09.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aula09.Dados.Configuracoes
{
    public class Tipo_Armadura_Configuracao : IEntityTypeConfiguration<Tipo_Armadura> {
        public void Configure(EntityTypeBuilder<Tipo_Armadura> builder)
        {
            
            builder.ToTable("Tipo_Armadura", "RPG");

            builder.HasKey("CodTipoArmadura");

            builder.Property(f => f.CodTipoArmadura).HasColumnName("CodTipoArmadura");
            builder.Property(f => f.NomeTipoArmadura).HasColumnName("NomeTipoArmadura");
        }
    }
}

using Aula09.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aula09.Dados.Configuracoes
{
    public class Ciclo_Magia_Configuracao : IEntityTypeConfiguration<Ciclo_Magia> {
        public void Configure(EntityTypeBuilder<Ciclo_Magia> builder)
        {
            
            builder.ToTable("Ciclo_Magia", "RPG");

            builder.HasKey("CodCicloMagia");

            builder.Property(f => f.CodCicloMagia).HasColumnName("CodCicloMagia");
            builder.Property(f => f.NivelCiclo).HasColumnName("NivelCiclo");
        }
    }
}

using Aula09.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aula09.Dados.Configuracoes
{
    public class Qtd_Magia_Ciclo_Configuracao : IEntityTypeConfiguration<Qtd_Magia_Ciclo> {
        public void Configure(EntityTypeBuilder<Qtd_Magia_Ciclo> builder)
        {
            
            builder.ToTable("Qtd_Magia_Ciclo", "RPG");

            builder.HasKey("CodClasse");
            builder.HasKey("CodNivel");
            builder.HasKey("CodCicloMagia");

            builder.Property(f => f.CodClasse).HasColumnName("CodClasse");
            builder.Property(f => f.CodNivel).HasColumnName("CodNivel");
            builder.Property(f => f.CodCicloMagia).HasColumnName("CodCicloMagia");
            builder.Property(f => f.Qtd).HasColumnName("Qtd");
        }
    }
}

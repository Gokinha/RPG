using Aula09.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aula09.Dados.Configuracoes
{
    public class Magia_Configuracao : IEntityTypeConfiguration<Magia> {
        public void Configure(EntityTypeBuilder<Magia> builder)
        {
            
            builder.ToTable("Magia", "RPG");

            builder.HasKey("CodMagia");

            builder.Property(f => f.CodMagia).HasColumnName("CodMagia");
            builder.Property(f => f.CodCicloMagia).HasColumnName("CodCicloMagia");
            builder.Property(f => f.CodTipoMagia).HasColumnName("CodTipoMagia");
            builder.Property(f => f.NomeMagia).HasColumnName("NomeMagia");
            builder.Property(f => f.AlcanceMagia).HasColumnName("AlcanceMagia");
            builder.Property(f => f.DuracaoMagia).HasColumnName("DuracaoMagia");
            builder.Property(f => f.DescricaoMagia).HasColumnName("DescricaoMagia");
            builder.Property(f => f.TempoConjuracao).HasColumnName("TempoConjuracao");
        }
    }
}

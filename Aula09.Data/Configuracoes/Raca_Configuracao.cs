using Aula09.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aula09.Dados.Configuracoes
{
    public class Raca_Configuracao : IEntityTypeConfiguration<Raca> {
        public void Configure(EntityTypeBuilder<Raca> builder)
        {
            
            builder.ToTable("Raca", "RPG");

            builder.HasKey("CodRaca");

            builder.Property(f => f.CodRaca).HasColumnName("CodRaca");
            builder.Property(f => f.Nome).HasColumnName("Nome");
            builder.Property(f => f.Descricao).HasColumnName("Descricao");
            builder.Property(f => f.Tendencia).HasColumnName("Tendencia");
            builder.Property(f => f.TamanhoMin).HasColumnName("TamanhoMin");
            builder.Property(f => f.TamanhoMax).HasColumnName("TamanhoMax");
            builder.Property(f => f.PesoRaca).HasColumnName("PesoRaca");
            builder.Property(f => f.VisaoEscuro).HasColumnName("VisaoEscuro");
        }
    }
}

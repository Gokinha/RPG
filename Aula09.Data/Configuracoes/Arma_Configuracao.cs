using Aula09.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aula09.Dados.Configuracoes
{
    public class Arma_Configuracao : IEntityTypeConfiguration<Arma> {
        public void Configure(EntityTypeBuilder<Arma> builder)
        {

            builder.ToTable("Arma", "RPG");

            builder.HasKey("CodArma");

            builder.Property(f => f.CodArma).HasColumnName("CodArma");
            builder.Property(f => f.NomeArma).HasColumnName("NomeArma");
            builder.Property(f => f.PesoArma).HasColumnName("PesoArma");
            builder.Property(f => f.CodDado).HasColumnName("CodDado");
            builder.Property(f => f.CodFormaDano).HasColumnName("CodFormaDano");
        }
    }
}

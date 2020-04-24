using Aula09.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aula09.Dados.Configuracoes
{
    public class Dado_Configuracao : IEntityTypeConfiguration<Dado> {
        public void Configure(EntityTypeBuilder<Dado> builder)
        {
            
            builder.ToTable("Dado", "RPG");

            builder.HasKey("CodDado");

            builder.Property(f => f.CodDado).HasColumnName("CodDado");
            builder.Property(f => f.TamanhoDado).HasColumnName("TamanhoDado");
        }
    }
}

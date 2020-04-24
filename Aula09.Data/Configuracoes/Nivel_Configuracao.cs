using Aula09.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aula09.Dados.Configuracoes
{
    public class Nivel_Configuracao : IEntityTypeConfiguration<Nivel> {
        public void Configure(EntityTypeBuilder<Nivel> builder)
        {
            
            builder.ToTable("Nivel", "RPG");

            builder.HasKey("CodNivel");

            builder.Property(f => f.CodNivel).HasColumnName("CodNivel");
            builder.Property(f => f.nivel).HasColumnName("Nivel");
        }
    }
}

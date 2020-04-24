using Aula09.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aula09.Dados.Configuracoes
{
    public class Caracteristicas_Configuracao : IEntityTypeConfiguration<Caracteristicas> {
        public void Configure(EntityTypeBuilder<Caracteristicas> builder)
        {
            
            builder.ToTable("Caracteristicas", "RPG");

            builder.HasKey("CodCaracteristicas");

            builder.Property(f => f.CodCaracteristicas).HasColumnName("CodCaracteristicas");
            builder.Property(f => f.Nome).HasColumnName("Nome");
            builder.Property(f => f.Descricao).HasColumnName("Descricao");
        }
    }
}

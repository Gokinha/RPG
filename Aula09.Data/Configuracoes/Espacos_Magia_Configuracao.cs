using Aula09.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aula09.Dados.Configuracoes
{
    public class Espacos_Magia_Configuracao : IEntityTypeConfiguration<Espacos_Magia> {
        public void Configure(EntityTypeBuilder<Espacos_Magia> builder)
        {
            
            builder.ToTable("Espaco_Magia", "RPG");

            builder.HasKey("CodClasse", "CodNivel");

            builder.Property(f => f.CodClasse).HasColumnName("CodClasse");
            builder.Property(f => f.CodNivel).HasColumnName("CodNivel");
        }
    }
}

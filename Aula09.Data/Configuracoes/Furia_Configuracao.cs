using Aula09.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aula09.Dados.Configuracoes
{
    public class Furia_Configuracao : IEntityTypeConfiguration<Furia> {
        public void Configure(EntityTypeBuilder<Furia> builder)
        {
            
            builder.ToTable("Furia", "RPG");

            builder.HasKey("CodClasse");
            builder.HasKey("CodNivel");

            builder.Property(f => f.CodClasse).HasColumnName("CodClasse");
            builder.Property(f => f.CodNivel).HasColumnName("CodNivel");
            builder.Property(f => f.QtdFuria).HasColumnName("QtdFuria");
            builder.Property(f => f.DanoFuria).HasColumnName("DanoFuria");
        }
    }
}

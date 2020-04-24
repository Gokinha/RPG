using Aula09.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aula09.Dados.Configuracoes
{
    public class Idioma_Configuracao : IEntityTypeConfiguration<Idioma> {
        public void Configure(EntityTypeBuilder<Idioma> builder)
        {
            
            builder.ToTable("Idioma", "RPG");

            builder.HasKey("CodIdioma");

            builder.Property(f => f.CodIdioma).HasColumnName("CodIdioma");
            builder.Property(f => f.Nome).HasColumnName("Nome");
            builder.Property(f => f.Descricao).HasColumnName("Descricao");
        }
    }
}

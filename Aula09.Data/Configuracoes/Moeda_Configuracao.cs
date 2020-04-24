using Aula09.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aula09.Dados.Configuracoes
{
    public class Moeda_Configuracao : IEntityTypeConfiguration<Moeda> {
        public void Configure(EntityTypeBuilder<Moeda> builder)
        {
            
            builder.ToTable("Moeda", "RPG");

            builder.HasKey("CodMoeda");

            builder.Property(f => f.CodMoeda).HasColumnName("CodMoeda");
            builder.Property(f => f.Nome).HasColumnName("Nome");
        }
    }
}

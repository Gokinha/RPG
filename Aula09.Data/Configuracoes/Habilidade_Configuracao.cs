using Aula09.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aula09.Dados.Configuracoes
{
    public class Habilidade_Configuracao : IEntityTypeConfiguration<Habilidade> {
        public void Configure(EntityTypeBuilder<Habilidade> builder)
        {
            
            builder.ToTable("Habilidade", "RPG");

            builder.HasKey("CodHabilidade");

            builder.Property(f => f.NomeHabilidade).HasColumnName("NomeHabilidade");
            builder.Property(f => f.DescricaoHabilidade).HasColumnName("DescricaoHabilidade");
        }
    }
}

using Aula09.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aula09.Dados.Configuracoes
{
    public class Monge_Configuracao : IEntityTypeConfiguration<Monge> {
        public void Configure(EntityTypeBuilder<Monge> builder)
        {
            
            builder.ToTable("Monge", "RPG");

            builder.HasKey("CodClasse", "CodNivel");

            builder.Property(f => f.CodClasse).HasColumnName("CodClasse");
            builder.Property(f => f.CodNivel).HasColumnName("CodNivel");
            builder.Property(f => f.PontosChi).HasColumnName("PontosChi");
            builder.Property(f => f.Deslocamento).HasColumnName("Deslocamento");
            builder.Property(f => f.CodDado).HasColumnName("CodDado");
        }
    }
}

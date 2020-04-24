using Aula09.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aula09.Dados.Configuracoes
{
    public class Classe_Configuracao : IEntityTypeConfiguration<Classe> {
        public void Configure(EntityTypeBuilder<Classe> builder)
        {
            
            builder.ToTable("Classe", "RPG");

            builder.HasKey("CodClasse");

            builder.Property(f => f.CodClasse).HasColumnName("CodClasse");
            builder.Property(f => f.DescricaoClasse).HasColumnName("DescricaoClasse");
            builder.Property(f => f.NomeClasse).HasColumnName("NomeClasse");
            builder.Property(f => f.CodDado).HasColumnName("CodDado");
        }
    }
}

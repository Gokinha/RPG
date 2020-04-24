using Aula09.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aula09.Dados.Configuracoes
{
    public class Classe_Habilidade_Configuracao : IEntityTypeConfiguration<Classe_Habilidade> {
        public void Configure(EntityTypeBuilder<Classe_Habilidade> builder)
        {
            
            builder.ToTable("Classe_Habilidade", "RPG");

            builder.HasKey("CodClasse");

            builder.Property(f => f.CodClasse).HasColumnName("CodClasse");
            builder.Property(f => f.CodHabilidade).HasColumnName("CodHabilidade");
        }
    }
}

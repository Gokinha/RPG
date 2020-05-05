using Aula09.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aula09.Dados.Configuracoes
{
    public class Proficiencia_Pericias_Configuracao : IEntityTypeConfiguration<Proficiencia_Pericias> {
        public void Configure(EntityTypeBuilder<Proficiencia_Pericias> builder)
        {
            
            builder.ToTable("Proficiencia_Pericias", "RPG");

            builder.HasKey("CodClasse,CodPericia");

            builder.Property(f => f.CodClasse).HasColumnName("CodClasse");
            builder.Property(f => f.CodPericia).HasColumnName("CodPericia");
        }
    }
}

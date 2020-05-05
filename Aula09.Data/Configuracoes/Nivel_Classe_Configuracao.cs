using Aula09.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aula09.Dados.Configuracoes
{
    public class Nivel_Classe_Configuracao : IEntityTypeConfiguration<Nivel_Classe> {
        public void Configure(EntityTypeBuilder<Nivel_Classe> builder)
        {
            
            builder.ToTable("Nivel_Classe", "RPG");

            builder.HasKey("CodFicha","CodJogador","CodNivel","CodClasse");

            builder.Property(f => f.CodFicha).HasColumnName("CodFicha");
            builder.Property(f => f.CodJogador).HasColumnName("CodJogador");
            builder.Property(f => f.CodNivel).HasColumnName("CodNivel");
            builder.Property(f => f.CodClasse).HasColumnName("CodClasse");
        }
    }
}

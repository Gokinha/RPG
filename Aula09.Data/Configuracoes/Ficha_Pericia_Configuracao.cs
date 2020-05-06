using Aula09.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aula09.Dados.Configuracoes
{
    public class Ficha_Pericia_Configuracao : IEntityTypeConfiguration<Ficha_Pericia> {
        public void Configure(EntityTypeBuilder<Ficha_Pericia> builder)
        {
            
            builder.ToTable("Ficha_Pericia", "RPG");

            builder.HasKey("CodFicha", "CodJogador", "CodPericia");

            builder.Property(f => f.CodFicha).HasColumnName("CodFicha");
            builder.Property(f => f.CodJogador).HasColumnName("CodJogador");
            builder.Property(f => f.CodPericia).HasColumnName("CodPericia");
          
        }
    }
}

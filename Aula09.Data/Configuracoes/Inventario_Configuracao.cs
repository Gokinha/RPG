using Aula09.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aula09.Dados.Configuracoes
{
    public class Inventario_Configuracao : IEntityTypeConfiguration<Inventario> {
        public void Configure(EntityTypeBuilder<Inventario> builder)
        {
            
            builder.ToTable("Inventario", "RPG");

            builder.HasKey("CodFicha","CodJogador");

            builder.Property(f => f.CodFicha).HasColumnName("CodFicha");
            builder.Property(f => f.CodJogador).HasColumnName("CodJogador");
        }
    }
}

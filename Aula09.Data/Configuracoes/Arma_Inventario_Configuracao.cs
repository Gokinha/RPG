using Aula09.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aula09.Dados.Configuracoes
{
    public class Arma_Inventario_Configuracao : IEntityTypeConfiguration<Arma_Inventario> {
        public void Configure(EntityTypeBuilder<Arma_Inventario> builder)
        {
            
            builder.ToTable("Arma_Inventario", "RPG");

            builder.HasKey("CodJogador");

            builder.Property(f => f.CodJogador).HasColumnName("CodJogador");
            builder.Property(f => f.CodFicha).HasColumnName("CodFicha");
            builder.Property(f => f.CodArma).HasColumnName("CodArma");
            builder.Property(f => f.Qtde).HasColumnName("Qtde");
        }
    }
}

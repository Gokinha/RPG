using Aula09.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aula09.Dados.Configuracoes
{
    public class Dinheiro_Inventario_Configuracao : IEntityTypeConfiguration<Dinheiro_Inventario> {
        public void Configure(EntityTypeBuilder<Dinheiro_Inventario> builder)
        {
            
            builder.ToTable("Dinheiro_Inventario", "RPG");

            builder.HasKey("CodMoeda");

            builder.Property(f => f.CodMoeda).HasColumnName("CodMoeda");
            builder.Property(f => f.CodFicha).HasColumnName("CodFicha");
            builder.Property(f => f.CodJogador).HasColumnName("CodJogador");
            builder.Property(f => f.Qtd).HasColumnName("Qtd");
        }
    }
}

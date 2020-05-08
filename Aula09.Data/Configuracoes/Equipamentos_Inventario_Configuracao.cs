using Aula09.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aula09.Dados.Configuracoes
{
    public class Equipamentos_Inventario_Configuracao : IEntityTypeConfiguration<Equipamentos_Inventario> {
        public void Configure(EntityTypeBuilder<Equipamentos_Inventario> builder)
        {
            
            builder.ToTable("Equipamentos_Inventario", "RPG");

            builder.HasKey("CodFicha","CodJogador","CodEquipamento");

            builder.Property(f => f.CodFicha).HasColumnName("CodFicha");
            builder.Property(f => f.CodJogador).HasColumnName("CodJogador");
            builder.Property(f => f.CodEquipamento).HasColumnName("CodEquipamento");
            builder.Property(f => f.Qtd).HasColumnName("Qtd");
        }
    }
}

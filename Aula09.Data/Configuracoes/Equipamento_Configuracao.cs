using Aula09.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aula09.Dados.Configuracoes
{
    public class Equipamento_Configuracao : IEntityTypeConfiguration<Equipamento> {
        public void Configure(EntityTypeBuilder<Equipamento> builder)
        {
            
            builder.ToTable("Equipamento", "RPG");

            builder.HasKey("CodEquipamento");

            builder.Property(f => f.CodEquipamento).HasColumnName("CodEquipamento");
            builder.Property(f => f.NomeEquipamento).HasColumnName("NomeEquipamento");
            builder.Property(f => f.PesoEquipamento).HasColumnName("PesoEquipamento");
        }
    }
}

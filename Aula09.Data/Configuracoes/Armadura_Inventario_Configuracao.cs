using Aula09.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aula09.Dados.Configuracoes
{
    public class Armadura_Inventario_Configuracao : IEntityTypeConfiguration<Armadura_Inventario> {
        public void Configure(EntityTypeBuilder<Armadura_Inventario> builder)
        {

            builder.ToTable("Armadura_Inventario", "RPG");

            builder.HasKey("CodJogador");

            builder.Property(f => f.CodFicha).HasColumnName("CodFicha");
            builder.Property(f => f.CodJogador).HasColumnName("CodJogador");
            builder.Property(f => f.CodArmadura).HasColumnName("CodArmadura");
            builder.Property(f => f.Qtde).HasColumnName("Qtde");
        }
    }
}

using Aula09.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aula09.Dados.Configuracoes
{
    public class Tipo_Magia_Configuracao : IEntityTypeConfiguration<Tipo_Magia> {
        public void Configure(EntityTypeBuilder<Tipo_Magia> builder)
        {
            
            builder.ToTable("Tipo_Magia", "RPG");

            builder.HasKey("CodTipoMagia");

            builder.Property(f => f.CodTipoMagia).HasColumnName("CodTipoMagia");
            builder.Property(f => f.DescricaoTipoMagia).HasColumnName("DescricaoTipoMagia");
        }
    }
}

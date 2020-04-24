using Aula09.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aula09.Dados.Configuracoes
{
    public class Pericia_Configuracao : IEntityTypeConfiguration<Pericia> {
        public void Configure(EntityTypeBuilder<Pericia> builder)
        {
            
            builder.ToTable("Pericia", "RPG");

            builder.HasKey("CodPericia");

            builder.Property(f => f.CodPericia).HasColumnName("CodPericia");
            builder.Property(f => f.NomePericia).HasColumnName("NomePericia");
            builder.Property(f => f.VlrPericia).HasColumnName("VlrPericia");
        }
    }
}

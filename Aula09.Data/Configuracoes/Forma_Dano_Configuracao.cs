using Aula09.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aula09.Dados.Configuracoes
{
    public class Forma_Dano_Configuracao : IEntityTypeConfiguration<Forma_Dano> {
        public void Configure(EntityTypeBuilder<Forma_Dano> builder)
        {
            
            builder.ToTable("Forma_Dano","RPG");

            builder.HasKey("CodFormaDano");

            builder.Property(f => f.CodFormaDano).HasColumnName("CodFormaDano");
            builder.Property(f => f.Forma).HasColumnName("Forma");
        }
    }
}

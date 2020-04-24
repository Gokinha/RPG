using Aula09.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aula09.Dados.Configuracoes
{
    public class Componente_Configuracao : IEntityTypeConfiguration<Componente> {
        public void Configure(EntityTypeBuilder<Componente> builder)
        {
            
            builder.ToTable("Componente", "RPG");

            builder.HasKey("CodComponente");

            builder.Property(f => f.CodComponente).HasColumnName("CodComponente");
            builder.Property(f => f.TipoComponente).HasColumnName("TipoComponente");
        }
    }
}

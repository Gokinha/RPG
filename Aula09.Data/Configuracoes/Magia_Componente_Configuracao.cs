using Aula09.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aula09.Dados.Configuracoes
{
    public class Magia_Componente_Configuracao : IEntityTypeConfiguration<Magia_Componente> {
        public void Configure(EntityTypeBuilder<Magia_Componente> builder)
        {
            
            builder.ToTable("Magia_Componente", "RPG");

            builder.HasKey("CodMagia");
            builder.HasKey("CodComponente");

            builder.Property(f => f.CodMagia).HasColumnName("CodMagia");
            builder.Property(f => f.CodComponente).HasColumnName("CodComponente");
        }
    }
}

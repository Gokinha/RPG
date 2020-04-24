using Aula09.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aula09.Dados.Configuracoes
{
    public class Componente_Material_Configuracao : IEntityTypeConfiguration<Componente_Material> {
        public void Configure(EntityTypeBuilder<Componente_Material> builder)
        {
            
            builder.ToTable("Componente_Material", "RPG");

            builder.HasKey("CodComponente");

            builder.Property(f => f.CodComponente).HasColumnName("CodComponente");
            builder.Property(f => f.CodMagia).HasColumnName("TCodMagia");
        }
    }
}

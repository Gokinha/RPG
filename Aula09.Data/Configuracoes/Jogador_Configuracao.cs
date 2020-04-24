using Aula09.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aula09.Dados.Configuracoes
{
    public class Jogador_Configuracao : IEntityTypeConfiguration<Jogador> {
        public void Configure(EntityTypeBuilder<Jogador> builder)
        {
            
            builder.ToTable("Jogador", "RPG");

            builder.HasKey("CodJogador");

            builder.Property(f => f.CodJogador).HasColumnName("CodJogador");
            builder.Property(f => f.Nome).HasColumnName("Nome");
            builder.Property(f => f.Email).HasColumnName("Email");
            builder.Property(f => f.Login).HasColumnName("Login");
            builder.Property(f => f.Senha).HasColumnName("Senha");
            builder.Property(f => f.DataNascimento).HasColumnName("DataNascimento");
        }
    }
}

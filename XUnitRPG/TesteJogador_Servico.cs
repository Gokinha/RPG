using System;
using Xunit;
using Aula09.Servico;
using Aula09.Dominio;
using Aula09.Comum;
using Aula09.Comum.NotificationPattern;

namespace XUnitRPG
{
    public class TesteJogador_Servico 
    {
        [Fact]
        public void TesteSalvar()
        {
            Jogador_Servico jogadorservico = new Jogador_Servico();
            
            Jogador jogador = new Jogador();

            jogador.CodJogador = 1;
            jogador.Nome = "Adriano Jose da Silva";
            jogador.Login = "Seilvao";
            jogador.Senha = "123456";
            jogador.Email = "a@gmail.com";
            jogador.DataNascimento = new DateTime(1996, 04, 01);

            Assert.NotNull(jogadorservico.Salvar(jogador));
        }
    }
}

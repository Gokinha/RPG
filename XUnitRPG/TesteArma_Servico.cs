using System;
using Xunit;
using Aula09.Servico;
using Aula09.Dominio;
using Aula09.Comum;
using Aula09.Comum.NotificationPattern;

namespace XUnitRPG
{
    public class TesteArma_Servico
    {
        [Fact]
        public void TesteSalvar()
        {
            Arma_Servico armaservico = new Arma_Servico();
            
            Arma arma = new Arma();

            var notificationResult = new NotificationResult();

            arma.CodArma = 1;
            arma.NomeArma = "Machado";
            arma.PesoArma = 2;
            arma.CodDado = 1;
            arma.CodFormaDano = 1;

            notificationResult = armaservico.Salvar(arma);
            Assert.NotNull(notificationResult);
        }
    }
}

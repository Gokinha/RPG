using System;
using System.Collections.Generic;
using Aula09.Comum.NotificationPattern;
using Aula09.Dados;
using Aula09.Dominio;

namespace Aula09.Servico
{
    public class Proficiencia_Arma_Raca_Servico
    {

        private readonly Proficiencia_Arma_Raca_Repositorio _proficiencia_Arma_Raca_Repositorio;
        public Proficiencia_Arma_Raca_Servico()
        {
            _proficiencia_Arma_Raca_Repositorio = new Proficiencia_Arma_Raca_Repositorio();
        }


        public NotificationResult Salvar(Proficiencia_Arma_Raca entidade)
        {
            var notificationResult = new NotificationResult();

            try
            {
                if (entidade.CodArma == 0 || entidade.CodRaca == 0)
                    notificationResult.Add(new NotificationError("Qtde. de produtos no Estoque inválido.", NotificationErrorType.USER));

                if (notificationResult.IsValid)
                {
                    _proficiencia_Arma_Raca_Repositorio.Adicionar(entidade);

                    notificationResult.Add("Produto cadastrado com sucesso.");
                }

                notificationResult.Result = entidade;

                return notificationResult;
            }
            catch (Exception ex)
            {
                return notificationResult.Add(new NotificationError(ex.Message));
            }
        }

        public string Excluir(Proficiencia_Arma_Raca entidade)
        {
            return "";
        }

        public IEnumerable<Proficiencia_Arma_Raca> ListarTodosComEstoqueZerado()
        {
            return _proficiencia_Arma_Raca_Repositorio.ListarTodosComEstoqueZerado();
        }
    }
}

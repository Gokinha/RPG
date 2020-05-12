using System;
using System.Collections.Generic;
using Aula09.Comum.NotificationPattern;
using Aula09.Dados;
using Aula09.Dominio;
using Aula09.Comum.NotificationPattern;

namespace Aula09.Servico
{
    public class Raca_Servico
    {

        private readonly Raca_Repositorio _raca_Repositorio;
        public Raca_Servico()
        {
            _raca_Repositorio = new Raca_Repositorio();
        }


        public NotificationResult Salvar(Raca entidade)
        {
            var notificationResult = new NotificationResult();

            try
            {
                if (entidade.CodRaca == 0)
                    notificationResult.Add(new NotificationError("Qtde. de produtos no Estoque inválido.", NotificationErrorType.USER));

                if (notificationResult.IsValid)
                {
                    _raca_Repositorio.Adicionar(entidade);

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

        public string Excluir(Raca entidade)
        {
            return "";
        }

        public IEnumerable<Raca> ListarTodosComEstoqueZerado()
        {
            return _raca_Repositorio.ListarTodosComEstoqueZerado();
        }
    }
}

using System;
using System.Collections.Generic;
using Aula09.Dados;
using Aula09.Dominio;

namespace Aula09.Servico
{
    public class Monge_Servico
    {

        private readonly Monge_Repositorio _monge_Repositorio;
        public Monge_Servico()
        {
            _monge_Repositorio = new Monge_Repositorio();
        }


        public NotificationResult Salvar(Monge entidade)
        {
            var notificationResult = new NotificationResult();

            try
            {
                if (entidade.CodClasse == 0 || entidade.CodNivel == 0)
                    notificationResult.Add(new NotificationError("Qtde. de produtos no Estoque inválido.", NotificationErrorType.USER));

                if (notificationResult.IsValid)
                {
                    _monge_Repositorio.Adicionar(entidade);

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

        public string Excluir(Monge entidade)
        {
            return "";
        }

        public IEnumerable<Monge> ListarTodosComEstoqueZerado()
        {
            return _monge_Repositorio.ListarTodosComEstoqueZerado();
        }
    }
}

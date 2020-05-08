using System;
using System.Collections.Generic;
using Aula09.Comum.NotificationPattern;
using Aula09.Dados;
using Aula09.Dominio;

namespace Aula09.Servico
{
    public class Moeda_Servico
    {

        private readonly Moeda_Repositorio _moeda_Repositorio;
        public Moeda_Servico()
        {
            _moeda_Repositorio = new Moeda_Repositorio();
        }


        public NotificationResult Salvar(Moeda entidade)
        {
            var notificationResult = new NotificationResult();

            try
            {
                if (entidade.CodMoeda == 0)
                    notificationResult.Add(new NotificationError("Qtde. de produtos no Estoque inválido.", NotificationErrorType.USER));

                if (notificationResult.IsValid)
                {
                    _moeda_Repositorio.Adicionar(entidade);

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

        public string Excluir(Moeda entidade)
        {
            return "";
        }

        public IEnumerable<Moeda> ListarTodosComEstoqueZerado()
        {
            return _moeda_Repositorio.ListarTodosComEstoqueZerado();
        }
    }
}

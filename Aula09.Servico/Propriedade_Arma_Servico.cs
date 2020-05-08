using System;
using System.Collections.Generic;
using Aula09.Dados;
using Aula09.Dominio;

namespace Aula09.Servico
{
    public class Propriedade_Arma_Servico
    {

        private readonly Propriedade_Arma_Repositorio _propriedade_Arma_Repositorio;
        public Propriedade_Arma_Servico()
        {
            _propriedade_Arma_Repositorio = new Propriedade_Arma_Repositorio();
        }


        public NotificationResult Salvar(Propriedade_Arma entidade)
        {
            var notificationResult = new NotificationResult();

            try
            {
                if (entidade.CodArma == 0)
                    notificationResult.Add(new NotificationError("Qtde. de produtos no Estoque inválido.", NotificationErrorType.USER));

                if (notificationResult.IsValid)
                {
                    _propriedade_Arma_Repositorio.Adicionar(entidade);

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

        public string Excluir(Propriedade_Arma entidade)
        {
            return "";
        }

        public IEnumerable<Propriedade_Arma> ListarTodosComEstoqueZerado()
        {
            return _propriedade_Arma_Repositorio.ListarTodosComEstoqueZerado();
        }
    }
}

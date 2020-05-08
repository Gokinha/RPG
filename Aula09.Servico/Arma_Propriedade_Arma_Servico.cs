using System;
using System.Collections.Generic;
using Aula09.Comum.NotificationPattern;
using Aula09.Dados;
using Aula09.Dominio;

namespace Aula09.Servico
{
    public class Arma_Propriedade_Arma_Servico
    {

        private readonly Arma_Propriedade_Arma_Repositorio _arma_Propriedade_Arma_Repositorio;
        public Arma_Propriedade_Arma_Servico()
        {
            _arma_Propriedade_Arma_Repositorio = new Arma_Propriedade_Arma_Repositorio();
        }


        public NotificationResult Salvar(Arma_Propriedade_Arma entidade)
        {
            var notificationResult = new NotificationResult();

            try
            {
                if (entidade.CodArma == 0)
                    notificationResult.Add(new NotificationError("Arma Classe não pode ser zero.", NotificationErrorType.USER));

                if (notificationResult.IsValid)
                {
                    _arma_Propriedade_Arma_Repositorio.Adicionar(entidade);

                    notificationResult.Add("Arma Classe cadastrado com sucesso.");
                }

                notificationResult.Result = entidade;

                return notificationResult;
            }
            catch (Exception ex)
            {
                return notificationResult.Add(new NotificationError(ex.Message));
            }


        }
    
        public string Excluir(Arma_Propriedade_Arma entidade)
        {
            return "";
        }

        public IEnumerable<Arma_Propriedade_Arma> ListarTodosComEstoqueZerado()
        {
            return _arma_Propriedade_Arma_Repositorio.ListarTodosComEstoqueZerado();
        }
    }
}

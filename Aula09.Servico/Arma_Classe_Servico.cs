using System;
using System.Collections.Generic;
using Aula09.Comum.NotificationPattern;
using Aula09.Dados;
using Aula09.Dominio;

namespace Aula09.Servico
{
    public class Arma_Classe_Servico
    {

        private readonly Arma_Classe_Repositorio _arma_Classe_Repositorio;
        public Arma_Classe_Servico()
        {
            _arma_Classe_Repositorio = new Arma_Classe_Repositorio();
        }

        public NotificationResult Salvar(Arma_Classe entidade)
        {
            var notificationResult = new NotificationResult();

            try
            {
                if (entidade.CodArma == 0)
                    notificationResult.Add(new NotificationError("Arma Classe não pode ser zero.", NotificationErrorType.USER));

                if (notificationResult.IsValid)
                {
                    _arma_Classe_Repositorio.Adicionar(entidade);

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
        public string Excluir(Arma_Classe entidade)
        {
            return "";
        }

        public IEnumerable<Arma_Classe> ListarTodosComEstoqueZerado()
        {
            return _arma_Classe_Repositorio.ListarTodosComEstoqueZerado();
        }
    }
}

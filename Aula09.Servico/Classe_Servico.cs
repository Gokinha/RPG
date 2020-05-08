using System;
using System.Collections.Generic;
using Aula09.Comum.NotificationPattern;
using Aula09.Dados;
using Aula09.Dominio;

namespace Aula09.Servico
{
    public class Classe_Servico
    {

        private readonly Classe_Repositorio _classe_Repositorio;
        public Classe_Servico()
        {
            _classe_Repositorio = new Classe_Repositorio();
        }

        public NotificationResult Salvar(Classe entidade)
        {
            var notificationResult = new NotificationResult();

            try
            {
                if (entidade.CodClasse == 0)
                    notificationResult.Add(new NotificationError("Cod Classe não pode ser zero.", NotificationErrorType.USER));

                if (notificationResult.IsValid)
                {
                    _classe_Repositorio.Adicionar(entidade);

                    notificationResult.Add("Classe cadastrado com sucesso.");
                }

                notificationResult.Result = entidade;

                return notificationResult;
            }
            catch (Exception ex)
            {
                return notificationResult.Add(new NotificationError(ex.Message));
            }
        }

        public string Excluir(Classe entidade)
        {
            return "";
        }

        public IEnumerable<Classe> ListarTodosComEstoqueZerado()
        {
            return _classe_Repositorio.ListarTodosComEstoqueZerado();
        }
    }
}

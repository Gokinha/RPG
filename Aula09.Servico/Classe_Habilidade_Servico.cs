using System;
using System.Collections.Generic;
using Aula09.Comum.NotificationPattern;
using Aula09.Dados;
using Aula09.Dominio;

namespace Aula09.Servico
{
    public class Classe_Habilidade_Servico
    {

        private readonly Classe_Habilidade_Repositorio _classe_Habilidade_Repositorio;
        public Classe_Habilidade_Servico()
        {
            _classe_Habilidade_Repositorio = new Classe_Habilidade_Repositorio();
        }

        public NotificationResult Salvar(Classe_Habilidade entidade)
        {
            var notificationResult = new NotificationResult();

            try
            {
                if (entidade.CodClasse == 0)
                    notificationResult.Add(new NotificationError("Cod Classe não pode ser zero.", NotificationErrorType.USER));

                if (notificationResult.IsValid)
                {
                    _classe_Habilidade_Repositorio.Adicionar(entidade);

                    notificationResult.Add("Classe Habilidade cadastrado com sucesso.");
                }

                notificationResult.Result = entidade;

                return notificationResult;
            }
            catch (Exception ex)
            {
                return notificationResult.Add(new NotificationError(ex.Message));
            }
        }

        public string Excluir(Classe_Habilidade entidade)
        {
            return "";
        }

        public IEnumerable<Classe_Habilidade> ListarTodosComEstoqueZerado()
        {
            return _classe_Habilidade_Repositorio.ListarTodosComEstoqueZerado();
        }
    }
}

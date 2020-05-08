using System;
using System.Collections.Generic;
using Aula09.Comum.NotificationPattern;
using Aula09.Dados;
using Aula09.Dominio;

namespace Aula09.Servico
{
    public class Dado_Servico
    {

        private readonly Dado_Repositorio _dado_Repositorio;
        public Dado_Servico()
        {
            _dado_Repositorio = new Dado_Repositorio();
        }
        public NotificationResult Salvar(Dado entidade)
        {
            var notificationResult = new NotificationResult();

            try
            {
                if (entidade.CodDado == 0)
                    notificationResult.Add(new NotificationError("Arma Classe não pode ser zero.", NotificationErrorType.USER));

                if (notificationResult.IsValid)
                {
                    _dado_Repositorio.Adicionar(entidade);

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
        public string Excluir(Dado entidade)
        {
            return "";
        }

        public IEnumerable<Dado> ListarTodosComEstoqueZerado()
        {
            return _dado_Repositorio.ListarTodosComEstoqueZerado();
        }
    }
}

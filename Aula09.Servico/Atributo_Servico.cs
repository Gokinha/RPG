using System;
using System.Collections.Generic;
using Aula09.Comum.NotificationPattern;
using Aula09.Dados;
using Aula09.Dominio;

namespace Aula09.Servico
{
    public class Atributo_Servico
    {

        private readonly Atributo_Repositorio _atributo_Repositorio;
        public Atributo_Servico()
        {
            _atributo_Repositorio = new Atributo_Repositorio();
        }


        public NotificationResult Salvar(Atributo entidade)
        {
            var notificationResult = new NotificationResult();

            try
            {
                if (entidade.CodAtributo == 0)
                    notificationResult.Add(new NotificationError("Atributo não pode ser zero.", NotificationErrorType.USER));

                if (notificationResult.IsValid)
                {
                    _atributo_Repositorio.Adicionar(entidade);

                    notificationResult.Add("Atributo cadastrado com sucesso.");
                }

                notificationResult.Result = entidade;

                return notificationResult;
            }
            catch (Exception ex)
            {
                return notificationResult.Add(new NotificationError(ex.Message));
            }
        }

        public string Excluir(Atributo entidade)
        {
            return "";
        }

        public IEnumerable<Atributo> ListarTodosComEstoqueZerado()
        {
            return _atributo_Repositorio.ListarTodosComEstoqueZerado();
        }
    }
}

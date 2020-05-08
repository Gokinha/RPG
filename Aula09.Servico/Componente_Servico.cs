using System;
using System.Collections.Generic;
using Aula09.Comum.NotificationPattern;
using Aula09.Dados;
using Aula09.Dominio;

namespace Aula09.Servico
{
    public class Componente_Servico
    {

        private readonly Componente_Repositorio _componente_Repositorio;
        public Componente_Servico()
        {
            _componente_Repositorio = new Componente_Repositorio();
        }


        public NotificationResult Salvar(Componente entidade)
        {
            var notificationResult = new NotificationResult();

            try
            {
                if (entidade.CodComponente == 0)
                    notificationResult.Add(new NotificationError("Cod Componente não pode ser zero.", NotificationErrorType.USER));

                if (notificationResult.IsValid)
                {
                    _componente_Repositorio.Adicionar(entidade);

                    notificationResult.Add("Componente cadastrado com sucesso.");
                }

                notificationResult.Result = entidade;

                return notificationResult;
            }
            catch (Exception ex)
            {
                return notificationResult.Add(new NotificationError(ex.Message));
            }
        }

        public string Excluir(Componente entidade)
        {
            return "";
        }

        public IEnumerable<Componente> ListarTodosComEstoqueZerado()
        {
            return _componente_Repositorio.ListarTodosComEstoqueZerado();
        }
    }
}

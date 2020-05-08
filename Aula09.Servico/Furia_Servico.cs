using System;
using System.Collections.Generic;
using Aula09.Comum.NotificationPattern;
using Aula09.Dados;
using Aula09.Dominio;

namespace Aula09.Servico
{
    public class Furia_Servico
    {

        private readonly Furia_Repositorio _furia_Repositorio;
        public Furia_Servico()
        {
            _furia_Repositorio = new Furia_Repositorio();
        }


        public NotificationResult Salvar(Furia entidade)
        {
            var notificationResult = new NotificationResult();

            try
            {
                if (entidade.CodClasse == 0)
                    notificationResult.Add(new NotificationError("Cod Classe não pode ser zero.", NotificationErrorType.USER));

                if (notificationResult.IsValid)
                {
                    _furia_Repositorio.Adicionar(entidade);

                    notificationResult.Add("Furia cadastrada.");
                }

                notificationResult.Result = entidade;

                return notificationResult;
            }
            catch (Exception ex)
            {
                return notificationResult.Add(new NotificationError(ex.Message));
            }
        }

        public string Excluir(Furia entidade)
        {
            return "";
        }

        public IEnumerable<Furia> ListarTodosComEstoqueZerado()
        {
            return _furia_Repositorio.ListarTodosComEstoqueZerado();
        }
    }
}

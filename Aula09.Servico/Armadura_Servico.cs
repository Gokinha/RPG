using System;
using System.Collections.Generic;
using Aula09.Comum.NotificationPattern;
using Aula09.Dados;
using Aula09.Dominio;

namespace Aula09.Servico
{
    public class Armadura_Servico
    {

        private readonly Armadura_Repositorio _armadura_Repositorio;
        public Armadura_Servico()
        {
            _armadura_Repositorio = new Armadura_Repositorio();
        }

        public NotificationResult Salvar(Armadura entidade)
        {
            var notificationResult = new NotificationResult();

            try
            {
                if (entidade.CodArmadura == 0)
                    notificationResult.Add(new NotificationError("Armadura não pode ser zero.", NotificationErrorType.USER));

                if (notificationResult.IsValid)
                {
                    _armadura_Repositorio.Adicionar(entidade);

                    notificationResult.Add("Armadura cadastrada com sucesso.");
                }

                notificationResult.Result = entidade;

                return notificationResult;
            }
            catch (Exception ex)
            {
                return notificationResult.Add(new NotificationError(ex.Message));
            }
        }

        public string Excluir(Armadura entidade)
        {
            return "";
        }

        public IEnumerable<Armadura> ListarTodosComEstoqueZerado()
        {
            return _armadura_Repositorio.ListarTodosComEstoqueZerado();
        }
    }
}

using System;
using System.Collections.Generic;
using Aula09.Comum.NotificationPattern;
using Aula09.Dados;
using Aula09.Dominio;

namespace Aula09.Servico
{
    public class Caracteristica_raca_Servico
    {

        private readonly Caracteristica_Raca_Repositorio _caracteristica_Raca_Repositorio;
        public Caracteristica_raca_Servico()
        {
            _caracteristica_Raca_Repositorio = new Caracteristica_Raca_Repositorio();
        }

        public NotificationResult Salvar(Caracteristica_Raca entidade)
        {
            var notificationResult = new NotificationResult();

            try
            {
                if (entidade.CodCaracteristicas == 0)
                    notificationResult.Add(new NotificationError("CodCaracteristicas não pode ser zero.", NotificationErrorType.USER));

                if (notificationResult.IsValid)
                {
                    _caracteristica_Raca_Repositorio.Adicionar(entidade);

                    notificationResult.Add("Caracteristica Raca cadastrado com sucesso.");
                }

                notificationResult.Result = entidade;

                return notificationResult;
            }
            catch (Exception ex)
            {
                return notificationResult.Add(new NotificationError(ex.Message));
            }
        }

        public string Excluir(Caracteristica_Raca entidade)
        {
            return "";
        }

        public IEnumerable<Caracteristica_Raca> ListarTodosComEstoqueZerado()
        {
            return _caracteristica_Raca_Repositorio.ListarTodosComEstoqueZerado();
        }
    }
}

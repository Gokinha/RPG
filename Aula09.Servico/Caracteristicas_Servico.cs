using System;
using System.Collections.Generic;
using Aula09.Comum.NotificationPattern;
using Aula09.Dados;
using Aula09.Dominio;

namespace Aula09.Servico
{
    public class Caracteristicas_Servico
    {

        private readonly Caracteristicas_Repositorio _caracteristicas_Repositorio;
        public Caracteristicas_Servico()
        {
            _caracteristicas_Repositorio = new Caracteristicas_Repositorio();
        }

        public NotificationResult Salvar(Caracteristicas entidade)
        {
            var notificationResult = new NotificationResult();

            try
            {
                if (entidade.CodCaracteristicas == 0)
                    notificationResult.Add(new NotificationError("CodCaracteristicas não pode ser zero.", NotificationErrorType.USER));

                if (notificationResult.IsValid)
                {
                    _caracteristicas_Repositorio.Adicionar(entidade);

                    notificationResult.Add("Caracteristica cadastrado com sucesso.");
                }

                notificationResult.Result = entidade;

                return notificationResult;
            }
            catch (Exception ex)
            {
                return notificationResult.Add(new NotificationError(ex.Message));
            }
        }

        public string Excluir(Caracteristicas entidade)
        {
            return "";
        }

        public IEnumerable<Caracteristicas> ListarTodosComEstoqueZerado()
        {
            return _caracteristicas_Repositorio.ListarTodosComEstoqueZerado();
        }
    }
}

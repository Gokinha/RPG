using System;
using System.Collections.Generic;
using Aula09.Comum.NotificationPattern;
using Aula09.Dados;
using Aula09.Dominio;

namespace Aula09.Servico
{
    public class Ciclo_Magia_Servico
    {

        private readonly Ciclo_Magia_Repositorio _ciclo_Magia_Repositorio;
        public Ciclo_Magia_Servico()
        {
            _ciclo_Magia_Repositorio = new Ciclo_Magia_Repositorio();
        }

        public NotificationResult Salvar(Ciclo_Magia entidade)
        {
            var notificationResult = new NotificationResult();

            try
            {
                if (entidade.CodCicloMagia == 0)
                    notificationResult.Add(new NotificationError("CodCicloMagia não pode ser zero.", NotificationErrorType.USER));

                if (notificationResult.IsValid)
                {
                    _ciclo_Magia_Repositorio.Adicionar(entidade);

                    notificationResult.Add("Ciclo Magia cadastrado com sucesso.");
                }

                notificationResult.Result = entidade;

                return notificationResult;
            }
            catch (Exception ex)
            {
                return notificationResult.Add(new NotificationError(ex.Message));
            }
        }

        public string Excluir(Ciclo_Magia entidade)
        {
            return "";
        }

        public IEnumerable<Ciclo_Magia> ListarTodosComEstoqueZerado()
        {
            return _ciclo_Magia_Repositorio.ListarTodosComEstoqueZerado();
        }
    }
}

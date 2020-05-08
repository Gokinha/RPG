using System;
using System.Collections.Generic;
using Aula09.Comum.NotificationPattern;
using Aula09.Dados;
using Aula09.Dominio;

namespace Aula09.Servico
{
    public class Equipamento_Servico
    {

        private readonly Equipamento_Repositorio _equipamento_Repositorio;
        public Equipamento_Servico()
        {
            _equipamento_Repositorio = new Equipamento_Repositorio();
        }


        public NotificationResult Salvar(Equipamento entidade)
        {
            var notificationResult = new NotificationResult();

            try
            {
                if (entidade.CodEquipamento == 0)
                    notificationResult.Add(new NotificationError("Cod Equipamento não pode ser zero.", NotificationErrorType.USER));

                if (notificationResult.IsValid)
                {
                    _equipamento_Repositorio.Adicionar(entidade);

                    notificationResult.Add("Equipamento cadastrado com sucesso.");
                }

                notificationResult.Result = entidade;

                return notificationResult;
            }
            catch (Exception ex)
            {
                return notificationResult.Add(new NotificationError(ex.Message));
            }
        }

        public string Excluir(Equipamento entidade)
        {
            return "";
        }

        public IEnumerable<Equipamento> ListarTodosComEstoqueZerado()
        {
            return _equipamento_Repositorio.ListarTodosComEstoqueZerado();
        }
    }
}

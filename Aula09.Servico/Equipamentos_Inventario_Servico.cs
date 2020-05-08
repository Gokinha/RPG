using System;
using System.Collections.Generic;
using Aula09.Comum.NotificationPattern;
using Aula09.Dados;
using Aula09.Dominio;

namespace Aula09.Servico
{
    public class Equipamentos_Inventario_Servico
    {

        private readonly Equipamentos_Inventario_Repositorio _equipamentos_Inventario_Repositorio;
        public Equipamentos_Inventario_Servico()
        {
            _equipamentos_Inventario_Repositorio = new Equipamentos_Inventario_Repositorio();
        }


        public NotificationResult Salvar(Equipamentos_Inventario entidade)
        {
            var notificationResult = new NotificationResult();

            try
            {
                if (entidade.CodEquipamento == 0)
                    notificationResult.Add(new NotificationError("Cod Equipamento não pode ser zero.", NotificationErrorType.USER));

                if (notificationResult.IsValid)
                {
                    _equipamentos_Inventario_Repositorio.Adicionar(entidade);

                    notificationResult.Add("Equipamentos Inventario cadastrado com sucesso.");
                }

                notificationResult.Result = entidade;

                return notificationResult;
            }
            catch (Exception ex)
            {
                return notificationResult.Add(new NotificationError(ex.Message));
            }
        }

        public string Excluir(Equipamentos_Inventario entidade)
        {
            return "";
        }

        public IEnumerable<Equipamentos_Inventario> ListarTodosComEstoqueZerado()
        {
            return _equipamentos_Inventario_Repositorio.ListarTodosComEstoqueZerado();
        }
    }
}

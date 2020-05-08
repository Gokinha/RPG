using System;
using System.Collections.Generic;
using Aula09.Comum.NotificationPattern;
using Aula09.Dados;
using Aula09.Dominio;

namespace Aula09.Servico
{
    public class Armadura_Inventario_Servico
    {

        private readonly Armadura_Inventario_Repositorio _armadura_Inventario_Repositorio;
        public Armadura_Inventario_Servico()
        {
            _armadura_Inventario_Repositorio = new Armadura_Inventario_Repositorio();
        }


        public NotificationResult Salvar(Armadura_Inventario entidade)
        {
            var notificationResult = new NotificationResult();

            try
            {
                if (entidade.CodArmadura == 0)
                    notificationResult.Add(new NotificationError("Armadura não pode ser zero.", NotificationErrorType.USER));

                if (notificationResult.IsValid)
                {
                    _armadura_Inventario_Repositorio.Adicionar(entidade);

                    notificationResult.Add("Armadura cadastrado com sucesso.");
                }

                notificationResult.Result = entidade;

                return notificationResult;
            }
            catch (Exception ex)
            {
                return notificationResult.Add(new NotificationError(ex.Message));
            }
        }
        public string Excluir(Armadura_Inventario entidade)
        {
            return "";
        }

        public IEnumerable<Armadura_Inventario> ListarTodosComEstoqueZerado()
        {
            return _armadura_Inventario_Repositorio.ListarTodosComEstoqueZerado();
        }
    }
}

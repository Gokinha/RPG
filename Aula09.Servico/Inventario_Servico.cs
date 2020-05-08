using System;
using System.Collections.Generic;
using Aula09.Dados;
using Aula09.Dominio;

namespace Aula09.Servico
{
    public class Inventario_Servico
    {

        private readonly Inventario_Repositorio _inventario_Repositorio;
        public Inventario_Servico()
        {
            _inventario_Repositorio = new Inventario_Repositorio();
        }


        public NotificationResult Salvar(Inventario entidade)
        {
            var notificationResult = new NotificationResult();

            try
            {
                if (entidade.CodFicha == 0 || entidade.CodJogador == 0)
                    notificationResult.Add(new NotificationError("Qtde. de produtos no Estoque inválido.", NotificationErrorType.USER));

                if (notificationResult.IsValid)
                {
                    _inventario_Repositorio.Adicionar(entidade);

                    notificationResult.Add("Produto cadastrado com sucesso.");
                }

                notificationResult.Result = entidade;

                return notificationResult;
            }
            catch (Exception ex)
            {
                return notificationResult.Add(new NotificationError(ex.Message));
            }
        }

        public string Excluir(Inventario entidade)
        {
            return "";
        }

        public IEnumerable<Inventario> ListarTodosComEstoqueZerado()
        {
            return _inventario_Repositorio.ListarTodosComEstoqueZerado();
        }
    }
}

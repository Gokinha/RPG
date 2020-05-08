using System;
using System.Collections.Generic;
using Aula09.Comum.NotificationPattern;
using Aula09.Dados;
using Aula09.Dominio;

namespace Aula09.Servico
{
    public class Dinheiro_Inventario_Servico
    {

        private readonly Dinheiro_Inventario_Repositorio _dinheiro_Inventario_Repositorio;
        public Dinheiro_Inventario_Servico()
        {
            _dinheiro_Inventario_Repositorio = new Dinheiro_Inventario_Repositorio();
        }


        public NotificationResult Salvar(Dinheiro_Inventario entidade)
        {
            var notificationResult = new NotificationResult();

            try
            {
                if (entidade.CodJogador == 0)
                    notificationResult.Add(new NotificationError("Cod jogador não pode ser zero.", NotificationErrorType.USER));

                if (notificationResult.IsValid)
                {
                    _dinheiro_Inventario_Repositorio.Adicionar(entidade);

                    notificationResult.Add("Dinheiro Inventario cadastrado com sucesso.");
                }

                notificationResult.Result = entidade;

                return notificationResult;
            }
            catch (Exception ex)
            {
                return notificationResult.Add(new NotificationError(ex.Message));
            }
        }

        public string Excluir(Dinheiro_Inventario entidade)
        {
            return "";
        }

        public IEnumerable<Dinheiro_Inventario> ListarTodosComEstoqueZerado()
        {
            return _dinheiro_Inventario_Repositorio.ListarTodosComEstoqueZerado();
        }
    }
}

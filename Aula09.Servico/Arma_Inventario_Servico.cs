using System;
using System.Collections.Generic;
using Aula09.Comum.NotificationPattern;
using Aula09.Dados;
using Aula09.Dominio;

namespace Aula09.Servico
{
    public class Arma_Inventario_Servico
    {

        private readonly Arma_Inventario_Repositorio _arma_Inventario_Repositorio;
        public Arma_Inventario_Servico()
        {
            _arma_Inventario_Repositorio = new Arma_Inventario_Repositorio();
        }

        public NotificationResult Salvar(Arma_Inventario entidade)
        {
            var notificationResult = new NotificationResult();

            try
            {
                if (entidade.CodArma == 0)
                    notificationResult.Add(new NotificationError("Arma Classe não pode ser zero.", NotificationErrorType.USER));

                if (notificationResult.IsValid)
                {
                    _arma_Inventario_Repositorio.Adicionar(entidade);

                    notificationResult.Add("Arma Classe cadastrado com sucesso.");
                }

                notificationResult.Result = entidade;

                return notificationResult;
            }
            catch (Exception ex)
            {
                return notificationResult.Add(new NotificationError(ex.Message));
            }
        }
        public string Excluir(Arma_Inventario entidade)
        {
            return "";
        }

        public IEnumerable<Arma_Inventario> ListarTodosComEstoqueZerado()
        {
            return _arma_Inventario_Repositorio.ListarTodosComEstoqueZerado();
        }
    }
}

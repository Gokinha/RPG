using System;
using System.Collections.Generic;
using Aula09.Comum.NotificationPattern;
using Aula09.Dados;
using Aula09.Dominio;

namespace Aula09.Servico
{
    public class Arma_Servico
    {

        private readonly Arma_Repositorio _armaRepositorio;
        public Arma_Servico()
        {
            _armaRepositorio = new Arma_Repositorio();
        }

        public NotificationResult Salvar(Arma entidade)
        {
            var notificationResult = new NotificationResult();

            try
            {
                if (entidade.CodArma == 0)
                    notificationResult.Add(new NotificationError("Qtde. de produtos no Estoque inválido.", NotificationErrorType.USER));

                if (notificationResult.IsValid)
                {
                    _armaRepositorio.Adicionar(entidade);

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

        public string Excluir(Arma entidade)
        {
            return "";
        }

        public IEnumerable<Arma> ListarTodos()
        {
            return _armaRepositorio.ListarTodos();
        }

        public IEnumerable<Arma> ListarTodosComEstoqueZerado()
        {
            return _armaRepositorio.ListarTodosComEstoqueZerado();
        }
    }
}

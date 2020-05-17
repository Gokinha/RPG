using System;
using System.Collections.Generic;
using Aula09.Comum.NotificationPattern;
using Aula09.Dados;
using Aula09.Dominio;

namespace Aula09.Servico
{
    public class Pericia_Servico
    {

        private readonly Pericia_Repositorio _pericia_Repositorio;
        public Pericia_Servico()
        {
            _pericia_Repositorio = new Pericia_Repositorio();
        }


        public NotificationResult Salvar(Pericia entidade)
        {
            var notificationResult = new NotificationResult();

            try
            {
                if (entidade.CodPericia == 0)
                    notificationResult.Add(new NotificationError("Qtde. de produtos no Estoque inválido.", NotificationErrorType.USER));

                if (notificationResult.IsValid)
                {
                    _pericia_Repositorio.Adicionar(entidade);

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

        public string Excluir(Pericia entidade)
        {
            return "";
        }

        public IEnumerable<Pericia> ListarTodosComEstoqueZerado()
        {
            return _pericia_Repositorio.ListarTodosComEstoqueZerado();
        }
    }
}

using System;
using System.Collections.Generic;
using Aula09.Comum.NotificationPattern;
using Aula09.Dados;
using Aula09.Dominio;

namespace Aula09.Servico
{
    public class Magia_Servico
    {

        private readonly Magia_Repositorio _magia_Repositorio;
        public Magia_Servico()
        {
            _magia_Repositorio = new Magia_Repositorio();
        }


        public NotificationResult Salvar(Magia entidade)
        {
            var notificationResult = new NotificationResult();

            try
            {
                if (entidade. CodMagia== 0)
                    notificationResult.Add(new NotificationError("Qtde. de produtos no Estoque inválido.", NotificationErrorType.USER));

                if (notificationResult.IsValid)
                {
                    _magia_Repositorio.Adicionar(entidade);

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

        public string Excluir(Magia entidade)
        {
            return "";
        }

        public IEnumerable<Magia> ListarTodosComEstoqueZerado()
        {
            return _magia_Repositorio.ListarTodosComEstoqueZerado();
        }
    }
}

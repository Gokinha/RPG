using System;
using System.Collections.Generic;
using Aula09.Comum.NotificationPattern;
using Aula09.Dados;
using Aula09.Dominio;
using Aula09.Comum.NotificationPattern;

namespace Aula09.Servico
{
    public class Tipo_Magia_Servico
    {

        private readonly Tipo_Magia_Repositorio _tipo_Magia_Repositorio;
        public Tipo_Magia_Servico()
        {
            _tipo_Magia_Repositorio = new Tipo_Magia_Repositorio();
        }


        public NotificationResult Salvar(Tipo_Magia entidade)
        {
            var notificationResult = new NotificationResult();

            try
            {
                if (entidade.CodTipoMagia == 0)
                    notificationResult.Add(new NotificationError("Qtde. de produtos no Estoque inválido.", NotificationErrorType.USER));

                if (notificationResult.IsValid)
                {
                    _tipo_Magia_Repositorio.Adicionar(entidade);

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

        public string Excluir(Tipo_Magia entidade)
        {
            return "";
        }

        public IEnumerable<Tipo_Magia> ListarTodosComEstoqueZerado()
        {
            return _tipo_Magia_Repositorio.ListarTodosComEstoqueZerado();
        }
    }
}

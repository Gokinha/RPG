using System;
using System.Collections.Generic;
using Aula09.Comum.NotificationPattern;
using Aula09.Dados;
using Aula09.Dominio;
using Aula09.Comum.NotificationPattern;

namespace Aula09.Servico
{
    public class Tipo_Armadura_Servico
    {

        private readonly Tipo_Armadura_Repositorio _tipo_Armadura_Repositorio;
        public Tipo_Armadura_Servico()
        {
            _tipo_Armadura_Repositorio = new Tipo_Armadura_Repositorio();
        }


        public NotificationResult Salvar(Tipo_Armadura entidade)
        {
            var notificationResult = new NotificationResult();

            try
            {
                if (entidade.CodTipoArmadura == 0)
                    notificationResult.Add(new NotificationError("Qtde. de produtos no Estoque inválido.", NotificationErrorType.USER));

                if (notificationResult.IsValid)
                {
                    _tipo_Armadura_Repositorio.Adicionar(entidade);

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

        public string Excluir(Tipo_Armadura entidade)
        {
            return "";
        }

        public IEnumerable<Tipo_Armadura> ListarTodosComEstoqueZerado()
        {
            return _tipo_Armadura_Repositorio.ListarTodosComEstoqueZerado();
        }
    }
}

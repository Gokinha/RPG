using System;
using System.Collections.Generic;
using Aula09.Comum.NotificationPattern;
using Aula09.Dados;
using Aula09.Dominio;

namespace Aula09.Servico
{
    public class Forma_Dano_Servico
    {

        private readonly Forma_Dano_Repositorio _forma_Dano_Repositorio;
        public Forma_Dano_Servico()
        {
            _forma_Dano_Repositorio = new Forma_Dano_Repositorio();
        }


        public NotificationResult Salvar(Forma_Dano entidade)
        {
            var notificationResult = new NotificationResult();

            try
            {
                if (entidade.CodFormaDano == 0)
                    notificationResult.Add(new NotificationError("Qtde. de produtos no Estoque inválido.", NotificationErrorType.USER));

                if (notificationResult.IsValid)
                {
                    _forma_Dano_Repositorio.Adicionar(entidade);

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

        public string Excluir(Forma_Dano entidade)
        {
            return "";
        }

        public IEnumerable<Forma_Dano> ListarTodosComEstoqueZerado()
        {
            return _forma_Dano_Repositorio.ListarTodosComEstoqueZerado();
        }
    }
}

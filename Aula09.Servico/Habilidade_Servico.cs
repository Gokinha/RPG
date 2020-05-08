using System;
using System.Collections.Generic;
using Aula09.Comum.NotificationPattern;
using Aula09.Dados;
using Aula09.Dominio;

namespace Aula09.Servico
{
    public class Habilidade_Servico
    {

        private readonly Habilidade_Repositorio _habilidade_Repositorio;
        public Habilidade_Servico()
        {
            _habilidade_Repositorio = new Habilidade_Repositorio();
        }


        public NotificationResult Salvar(Habilidade entidade)
        {
            var notificationResult = new NotificationResult();

            try
            {
                if (entidade.CodHabilidade == 0)
                    notificationResult.Add(new NotificationError("Qtde. de produtos no Estoque inválido.", NotificationErrorType.USER));

                if (notificationResult.IsValid)
                {
                    _habilidade_Repositorio.Adicionar(entidade);

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

        public string Excluir(Habilidade entidade)
        {
            return "";
        }

        public IEnumerable<Habilidade> ListarTodosComEstoqueZerado()
        {
            return _habilidade_Repositorio.ListarTodosComEstoqueZerado();
        }
    }
}

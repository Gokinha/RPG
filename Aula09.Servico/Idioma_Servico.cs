using System;
using System.Collections.Generic;
using Aula09.Comum.NotificationPattern;
using Aula09.Dados;
using Aula09.Dominio;

namespace Aula09.Servico
{
    public class Idioma_Servico
    {

        private readonly Idioma_Repositorio _idioma_Repositorio;
        public Idioma_Servico()
        {
            _idioma_Repositorio = new Idioma_Repositorio();
        }


         public NotificationResult Salvar(Idioma entidade)
        {
            var notificationResult = new NotificationResult();

            try
            {
                if (entidade.CodIdioma == 0)
                    notificationResult.Add(new NotificationError("Qtde. de produtos no Estoque inválido.", NotificationErrorType.USER));

                if (notificationResult.IsValid)
                {
                    _idioma_Repositorio.Adicionar(entidade);

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

        public string Excluir(Idioma entidade)
        {
            return "";
        }

        public IEnumerable<Idioma> ListarTodosComEstoqueZerado()
        {
            return _idioma_Repositorio.ListarTodosComEstoqueZerado();
        }
    }
}

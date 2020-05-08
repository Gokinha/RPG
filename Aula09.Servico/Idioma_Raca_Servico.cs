using System;
using System.Collections.Generic;
using Aula09.Comum.NotificationPattern;
using Aula09.Dados;
using Aula09.Dominio;

namespace Aula09.Servico
{
    public class Idioma_Raca_Servico
    {

        private readonly Idioma_Raca_Repositorio _idioma_Raca_Repositorio;
        public Idioma_Raca_Servico()
        {
            _idioma_Raca_Repositorio = new Idioma_Raca_Repositorio();
        }


        public NotificationResult Salvar(Idioma_Raca entidade)
        {
            var notificationResult = new NotificationResult();

            try
            {
                if (entidade.CodIdioma == 0 || entidade.CodRaca == 0)
                    notificationResult.Add(new NotificationError("Qtde. de produtos no Estoque inválido.", NotificationErrorType.USER));

                if (notificationResult.IsValid)
                {
                    _idioma_Raca_Repositorio.Adicionar(entidade);

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

        public string Excluir(Idioma_Raca entidade)
        {
            return "";
        }

        public IEnumerable<Idioma_Raca> ListarTodosComEstoqueZerado()
        {
            return _idioma_Raca_Repositorio.ListarTodosComEstoqueZerado();
        }
    }
}

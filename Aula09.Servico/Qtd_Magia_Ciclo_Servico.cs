using System;
using System.Collections.Generic;
using Aula09.Comum.NotificationPattern;
using Aula09.Dados;
using Aula09.Dominio;

namespace Aula09.Servico
{
    public class Qtd_Magia_Ciclo_Servico
    {

        private readonly Qtd_Magia_Ciclo_Repositorio _qtd_Magia_Ciclo_Repositorio;
        public Qtd_Magia_Ciclo_Servico()
        {
            _qtd_Magia_Ciclo_Repositorio = new Qtd_Magia_Ciclo_Repositorio();
        }


        public NotificationResult Salvar(Qtd_Magia_Ciclo entidade)
        {
            var notificationResult = new NotificationResult();

            try
            {
                if (entidade.CodClasse == 0 || entidade.CodNivel == 0)
                    notificationResult.Add(new NotificationError("Qtde. de produtos no Estoque inválido.", NotificationErrorType.USER));

                if (notificationResult.IsValid)
                {
                    _qtd_Magia_Ciclo_Repositorio.Adicionar(entidade);

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

        public string Excluir(Qtd_Magia_Ciclo entidade)
        {
            return "";
        }

        public IEnumerable<Qtd_Magia_Ciclo> ListarTodosComEstoqueZerado()
        {
            return _qtd_Magia_Ciclo_Repositorio.ListarTodosComEstoqueZerado();
        }
    }
}

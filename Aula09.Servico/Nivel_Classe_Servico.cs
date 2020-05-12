using System;
using System.Collections.Generic;
using Aula09.Comum.NotificationPattern;
using Aula09.Dados;
using Aula09.Dominio;

namespace Aula09.Servico
{
    public class Nivel_Classe_Servico
    {

        private readonly Nivel_Classe_Repositorio _nivel_Classe_Repositorio;
        public Nivel_Classe_Servico()
        {
            _nivel_Classe_Repositorio = new Nivel_Classe_Repositorio();
        }


        public NotificationResult Salvar(Nivel_Classe entidade)
        {
            var notificationResult = new NotificationResult();

            try
            {
                if (entidade.CodNivel == 0 || entidade.CodClasse == 0)
                    notificationResult.Add(new NotificationError("Qtde. de produtos no Estoque inválido.", NotificationErrorType.USER));

                if (notificationResult.IsValid)
                {
                    _nivel_Classe_Repositorio.Adicionar(entidade);

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

        public string Excluir(Nivel_Classe entidade)
        {
            return "";
        }

        public IEnumerable<Nivel_Classe> ListarTodosComEstoqueZerado()
        {
            return _nivel_Classe_Repositorio.ListarTodosComEstoqueZerado();
        }
    }
}

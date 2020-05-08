using System;
using System.Collections.Generic;
using Aula09.Dados;
using Aula09.Dominio;

namespace Aula09.Servico
{
    public class Nivel_Servico
    {

        private readonly Nivel_Repositorio _nivel_Repositorio;
        public Nivel_Servico()
        {
            _nivel_Repositorio = new Nivel_Repositorio();
        }


        public NotificationResult Salvar(Nivel entidade)
        {
            var notificationResult = new NotificationResult();

            try
            {
                if (entidade.CodNivel == 0)
                    notificationResult.Add(new NotificationError("Qtde. de produtos no Estoque inválido.", NotificationErrorType.USER));

                if (notificationResult.IsValid)
                {
                    _nivel_Repositorio.Adicionar(entidade);

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

        public string Excluir(Nivel entidade)
        {
            return "";
        }

        public IEnumerable<Nivel> ListarTodosComEstoqueZerado()
        {
            return _nivel_Repositorio.ListarTodosComEstoqueZerado();
        }
    }
}

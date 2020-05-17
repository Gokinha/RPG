using System;
using System.Collections.Generic;
using Aula09.Comum.NotificationPattern;
using Aula09.Dados;
using Aula09.Dominio;

namespace Aula09.Servico
{
    public class Magia_Componente_Servico
    {

        private readonly Magia_Componente_Repositorio _magia_Componente_Repositorio;
        public Magia_Componente_Servico()
        {
            _magia_Componente_Repositorio = new Magia_Componente_Repositorio();
        }


        public NotificationResult Salvar(Magia_Componente entidade)
        {
            var notificationResult = new NotificationResult();

            try
            {
                if (entidade.CodComponente == 0 || entidade.CodMagia == 0)
                    notificationResult.Add(new NotificationError("Qtde. de produtos no Estoque inválido.", NotificationErrorType.USER));

                if (notificationResult.IsValid)
                {
                    _magia_Componente_Repositorio.Adicionar(entidade);

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

        public string Excluir(Magia_Componente entidade)
        {
            return "";
        }

        public IEnumerable<Magia_Componente> ListarTodosComEstoqueZerado()
        {
            return _magia_Componente_Repositorio.ListarTodosComEstoqueZerado();
        }
    }
}

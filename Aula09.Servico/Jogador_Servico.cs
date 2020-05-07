using System;
using System.Collections.Generic;
using Aula09.Dados;
using Aula09.Dominio;

namespace Aula09.Servico
{
    public class Jogador_Servico
    {

        private readonly Jogador_Repositorio _jogador_Repositorio;
        public Jogador_Servico()
        {
            _jogador_Repositorio = new Jogador_Repositorio();
        }


        public NotificationResult Salvar(Jogador entidade)
        {
            var notificationResult = new NotificationResult();

            try
            {
                if (entidade.CodJogador == 0)
                    notificationResult.Add(new NotificationError("Qtde. de produtos no Estoque inválido.", NotificationErrorType.USER));

                if (notificationResult.IsValid)
                {
                    _jogador_Repositorio.Adicionar(entidade);

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

        public string Excluir(Jogador entidade)
        {
            return "";
        }

        public IEnumerable<Jogador> ListarTodosComEstoqueZerado()
        {
            return _jogador_Repositorio.ListarTodosComEstoqueZerado();
        }
    }
}

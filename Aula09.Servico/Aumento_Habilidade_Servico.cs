using System;
using System.Collections.Generic;
using Aula09.Comum.NotificationPattern;
using Aula09.Dados;
using Aula09.Dominio;

namespace Aula09.Servico
{
    public class Aumento_Habilidade_Servico
    {

        private readonly Aumento_Habilidade_Repositorio _aumento_Habilidade_Repositorio;
        public Aumento_Habilidade_Servico()
        {
            _aumento_Habilidade_Repositorio = new Aumento_Habilidade_Repositorio();
        }


        public NotificationResult Salvar(Aumento_Habilidade entidade)
        {
            var notificationResult = new NotificationResult();

            try
            {
                if (entidade.CodAtributo == 0)
                    notificationResult.Add(new NotificationError("Atributo não pode ser zero.", NotificationErrorType.USER));

                if (notificationResult.IsValid)
                {
                    _aumento_Habilidade_Repositorio.Adicionar(entidade);

                    notificationResult.Add("Aumento Habilidade cadastrado com sucesso.");
                }

                notificationResult.Result = entidade;

                return notificationResult;
            }
            catch (Exception ex)
            {
                return notificationResult.Add(new NotificationError(ex.Message));
            }
        }

        public string Excluir(Aumento_Habilidade entidade)
        {
            return "";
        }

        public IEnumerable<Aumento_Habilidade> ListarTodosComEstoqueZerado()
        {
            return _aumento_Habilidade_Repositorio.ListarTodosComEstoqueZerado();
        }
  
    }
}
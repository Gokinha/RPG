using System;
using System.Collections.Generic;
using Aula09.Comum.NotificationPattern;
using Aula09.Dados;
using Aula09.Dominio;

namespace Aula09.Servico
{
    public class Ficha_Servico
    {

        private readonly Ficha_Repositorio _ficha_Repositorio;
        public Ficha_Servico()
        {
            _ficha_Repositorio = new Ficha_Repositorio();
        }


        public NotificationResult Salvar(Ficha entidade)
        {
            var notificationResult = new NotificationResult();

            try
            {
                if (entidade.CodFicha == 0)
                    notificationResult.Add(new NotificationError("Cod Ficha não pode ser zero.", NotificationErrorType.USER));

                if (notificationResult.IsValid)
                {
                    _ficha_Repositorio.Adicionar(entidade);

                    notificationResult.Add("Ficha cadastrado com sucesso.");
                }

                notificationResult.Result = entidade;

                return notificationResult;
            }
            catch (Exception ex)
            {
                return notificationResult.Add(new NotificationError(ex.Message));
            }
        }

        public string Excluir(Ficha entidade)
        {
            return "";
        }

        public IEnumerable<Ficha> ListarTodosComEstoqueZerado()
        {
            return _ficha_Repositorio.ListarTodosComEstoqueZerado();
        }
    }
}

using System;
using System.Collections.Generic;
using Aula09.Comum.NotificationPattern;
using Aula09.Dados;
using Aula09.Dominio;

namespace Aula09.Servico
{
    public class Ficha_Atributo_Servico
    {

        private readonly Ficha_Atributo_Repositorio _ficha_Atributo_Repositorio;
        public Ficha_Atributo_Servico()
        {
            _ficha_Atributo_Repositorio = new Ficha_Atributo_Repositorio();
        }


        public NotificationResult Salvar(Ficha_Atributo entidade)
        {
            var notificationResult = new NotificationResult();

            try
            {
                if (entidade.CodFicha == 0)
                    notificationResult.Add(new NotificationError("Cod Ficha não pode ser zero.", NotificationErrorType.USER));

                if (notificationResult.IsValid)
                {
                    _ficha_Atributo_Repositorio.Adicionar(entidade);

                    notificationResult.Add("Ficha Atributo cadastrado com sucesso.");
                }

                notificationResult.Result = entidade;

                return notificationResult;
            }
            catch (Exception ex)
            {
                return notificationResult.Add(new NotificationError(ex.Message));
            }
        }
        public string Excluir(Ficha_Atributo entidade)
        {
            return "";
        }

        public IEnumerable<Ficha_Atributo> ListarTodosComEstoqueZerado()
        {
            return _ficha_Atributo_Repositorio.ListarTodosComEstoqueZerado();
        }
    }
}

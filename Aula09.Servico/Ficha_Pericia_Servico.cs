using System;
using System.Collections.Generic;
using Aula09.Comum.NotificationPattern;
using Aula09.Dados;
using Aula09.Dominio;

namespace Aula09.Servico
{
    public class Ficha_Pericia_Servico
    {

        private readonly Ficha_Pericia_Repositorio _ficha_Pericia_Repositorio;
        public Ficha_Pericia_Servico()
        {
            _ficha_Pericia_Repositorio = new Ficha_Pericia_Repositorio();
        }


        public NotificationResult Salvar(Ficha_Pericia entidade)
        {
            var notificationResult = new NotificationResult();

            try
            {
                if (entidade.CodFicha == 0)
                    notificationResult.Add(new NotificationError("Cod Ficha não pode ser zero.", NotificationErrorType.USER));

                if (notificationResult.IsValid)
                {
                    _ficha_Pericia_Repositorio.Adicionar(entidade);

                    notificationResult.Add("Ficha Pericia cadastrado com sucesso.");
                }

                notificationResult.Result = entidade;

                return notificationResult;
            }
            catch (Exception ex)
            {
                return notificationResult.Add(new NotificationError(ex.Message));
            }
        }

        public string Excluir(Ficha_Pericia entidade)
        {
            return "";
        }

        public IEnumerable<Ficha_Pericia> ListarTodosComEstoqueZerado()
        {
            return _ficha_Pericia_Repositorio.ListarTodosComEstoqueZerado();
        }
    }
}

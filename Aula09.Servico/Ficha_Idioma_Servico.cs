using System;
using System.Collections.Generic;
using Aula09.Comum.NotificationPattern;
using Aula09.Dados;
using Aula09.Dominio;

namespace Aula09.Servico
{
    public class Ficha_Idioma_Servico
    {

        private readonly Ficha_Idioma_Repositorio _ficha_Idioma_Repositorio;
        public Ficha_Idioma_Servico()
        {
            _ficha_Idioma_Repositorio = new Ficha_Idioma_Repositorio();
        }


        public NotificationResult Salvar(Ficha_Idioma entidade)
        {
            var notificationResult = new NotificationResult();

            try
            {
                if (entidade.CodIdioma == 0)
                    notificationResult.Add(new NotificationError("Cod Idioma não pode ser zero.", NotificationErrorType.USER));

                if (notificationResult.IsValid)
                {
                    _ficha_Idioma_Repositorio.Adicionar(entidade);

                    notificationResult.Add("Ficha Idioma cadastrado com sucesso.");
                }

                notificationResult.Result = entidade;

                return notificationResult;
            }
            catch (Exception ex)
            {
                return notificationResult.Add(new NotificationError(ex.Message));
            }
        }

        public string Excluir(Ficha_Idioma entidade)
        {
            return "";
        }

        public IEnumerable<Ficha_Idioma> ListarTodosComEstoqueZerado()
        {
            return _ficha_Idioma_Repositorio.ListarTodosComEstoqueZerado();
        }
    }
}

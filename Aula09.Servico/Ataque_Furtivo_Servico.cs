using System;
using System.Collections.Generic;
using Aula09.Comum.NotificationPattern;
using Aula09.Dados;
using Aula09.Dominio;

namespace Aula09.Servico
{
    public class Ataque_Furtivo_Servico
    {

        private readonly Ataque_Furtivo_Repositorio _ataque_Furtivo_Repositorio;
        public Ataque_Furtivo_Servico()
        {
            _ataque_Furtivo_Repositorio = new Ataque_Furtivo_Repositorio();
        }


        public NotificationResult Salvar(Ataque_Furtivo entidade)
        {
            var notificationResult = new NotificationResult();

            try
            {
                if (entidade.CodNivel == 0)
                    notificationResult.Add(new NotificationError("CodNivel não pode ser zero.", NotificationErrorType.USER));

                if (notificationResult.IsValid)
                {
                    _ataque_Furtivo_Repositorio.Adicionar(entidade);

                    notificationResult.Add("Ataque_Furtivo cadastrado com sucesso.");
                }

                notificationResult.Result = entidade;

                return notificationResult;
            }
            catch (Exception ex)
            {
                return notificationResult.Add(new NotificationError(ex.Message));
            }
        }

        public string Excluir(Ataque_Furtivo entidade)
        {
            return "";
        }

        public IEnumerable<Ataque_Furtivo> ListarTodosComEstoqueZerado()
        {
            return _ataque_Furtivo_Repositorio.ListarTodosComEstoqueZerado();
        }
    }
}

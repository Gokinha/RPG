using System;
using System.Collections.Generic;
using Aula09.Comum.NotificationPattern;
using Aula09.Dados;
using Aula09.Dominio;

namespace Aula09.Servico
{
    public class Espacos_Magia_Servico
    {

        private readonly Espacos_Magia_Repositorio _espacos_Magia_Repositorio;
        public Espacos_Magia_Servico()
        {
            _espacos_Magia_Repositorio = new Espacos_Magia_Repositorio();
        }


        public NotificationResult Salvar(Espacos_Magia entidade)
        {
            var notificationResult = new NotificationResult();

            try
            {
                if (entidade.CodClasse == 0)
                    notificationResult.Add(new NotificationError("Cod Classe não pode ser zero.", NotificationErrorType.USER));

                if (notificationResult.IsValid)
                {
                    _espacos_Magia_Repositorio.Adicionar(entidade);

                    notificationResult.Add("Espacos Magia cadastrado com sucesso.");
                }

                notificationResult.Result = entidade;

                return notificationResult;
            }
            catch (Exception ex)
            {
                return notificationResult.Add(new NotificationError(ex.Message));
            }
        }

        public string Excluir(Espacos_Magia entidade)
        {
            return "";
        }

        public IEnumerable<Espacos_Magia> ListarTodosComEstoqueZerado()
        {
            return _espacos_Magia_Repositorio.ListarTodosComEstoqueZerado();
        }
    }
}

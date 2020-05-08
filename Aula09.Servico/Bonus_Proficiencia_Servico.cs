using System;
using System.Collections.Generic;
using Aula09.Comum.NotificationPattern;
using Aula09.Dados;
using Aula09.Dominio;

namespace Aula09.Servico
{
    public class Bonus_Proficiencia_Servico
    {

        private readonly Bonus_Proficiencia_Repositorio _bonus_Proficiencia_Repositorio;
        public Bonus_Proficiencia_Servico()
        {
            _bonus_Proficiencia_Repositorio = new Bonus_Proficiencia_Repositorio();
        }

        public NotificationResult Salvar(Bonus_Proficiencia entidade)
        {
            var notificationResult = new NotificationResult();

            try
            {
                if (entidade.CodBonusProficiencia == 0)
                    notificationResult.Add(new NotificationError("CodBonusProficiencia não pode ser zero.", NotificationErrorType.USER));

                if (notificationResult.IsValid)
                {
                    _bonus_Proficiencia_Repositorio.Adicionar(entidade);

                    notificationResult.Add("Bonus Proficiencia cadastrado com sucesso.");
                }

                notificationResult.Result = entidade;

                return notificationResult;
            }
            catch (Exception ex)
            {
                return notificationResult.Add(new NotificationError(ex.Message));
            }
        }

        public string Excluir(Bonus_Proficiencia entidade)
        {
            return "";
        }

        public IEnumerable<Bonus_Proficiencia> ListarTodosComEstoqueZerado()
        {
            return _bonus_Proficiencia_Repositorio.ListarTodosComEstoqueZerado();
        }
    }
}

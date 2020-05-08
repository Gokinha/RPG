using System;
using System.Collections.Generic;
using Aula09.Comum.NotificationPattern;
using Aula09.Dados;
using Aula09.Dominio;

namespace Aula09.Servico
{
    public class Proficiencia_Armadura_Servico
    {

        private readonly Proficiencia_Armadura_Repositorio _proficiencia_Armadura_Repositorio;
        public Proficiencia_Armadura_Servico()
        {
            _proficiencia_Armadura_Repositorio = new Proficiencia_Armadura_Repositorio();
        }


       public NotificationResult Salvar(Proficiencia_Armadura entidade)
        {
            var notificationResult = new NotificationResult();

            try
            {
                if (entidade.CodClasse == 0 || entidade.CodArmadura == 0)
                    notificationResult.Add(new NotificationError("Qtde. de produtos no Estoque inválido.", NotificationErrorType.USER));

                if (notificationResult.IsValid)
                {
                    _proficiencia_Armadura_Repositorio.Adicionar(entidade);

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

        public string Excluir(Proficiencia_Armadura entidade)
        {
            return "";
        }

        public IEnumerable<Proficiencia_Armadura> ListarTodosComEstoqueZerado()
        {
            return _proficiencia_Armadura_Repositorio.ListarTodosComEstoqueZerado();
        }
    }
}

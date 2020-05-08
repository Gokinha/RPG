using System;
using System.Collections.Generic;
using Aula09.Dados;
using Aula09.Dominio;

namespace Aula09.Servico
{
    public class Proficiencia_Teste_Resistencia_Servico
    {

        private readonly Proficiencia_Teste_Resistencia_Repositorio _proficiencia_Teste_Resistencia_Repositorio;
        public Proficiencia_Teste_Resistencia_Servico()
        {
            _proficiencia_Teste_Resistencia_Repositorio = new Proficiencia_Teste_Resistencia_Repositorio();
        }


        public NotificationResult Salvar(Proficiencia_Teste_Resistencia entidade)
        {
            var notificationResult = new NotificationResult();

            try
            {
                if (entidade.CodClasse == 0 || entidade.CodAtributo == 0)
                    notificationResult.Add(new NotificationError("Qtde. de produtos no Estoque inválido.", NotificationErrorType.USER));

                if (notificationResult.IsValid)
                {
                    _proficiencia_Teste_Resistencia_Repositorio.Adicionar(entidade);

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

        public string Excluir(Proficiencia_Teste_Resistencia entidade)
        {
            return "";
        }

        public IEnumerable<Proficiencia_Teste_Resistencia> ListarTodosComEstoqueZerado()
        {
            return _proficiencia_Teste_Resistencia_Repositorio.ListarTodosComEstoqueZerado();
        }
    }
}

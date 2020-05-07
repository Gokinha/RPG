using System;
using System.Collections.Generic;
using Aula09.Dados;
using Aula09.Dominio;

namespace Aula09.Servico
{
    public class Proficiencia_Pericia_Servico
    {

        private readonly Proficiencia_Pericias_Repositorio _proficiencia_Pericia_Repositorio;
        public Proficiencia_Pericia_Servico()
        {
            _proficiencia_Pericia_Repositorio = new Proficiencia_Pericias_Repositorio();
        }

        public NotificationResult Salvar(Proficiencia_Pericias entidade)
        {
            var notificationResult = new NotificationResult();

            try
            {
                if (entidade.CodClasse == 0 || entidade.CodPericia == 0)
                    notificationResult.Add(new NotificationError("Qtde. de produtos no Estoque inválido.", NotificationErrorType.USER));

                if (notificationResult.IsValid)
                {
                    _proficiencia_Pericia_Repositorio.Adicionar(entidade);

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

        public string Excluir(Proficiencia_Pericias entidade)
        {
            return "";
        }

        public IEnumerable<Proficiencia_Pericias> ListarTodosComEstoqueZerado()
        {
            return _proficiencia_Pericia_Repositorio.ListarTodosComEstoqueZerado();
        }
    }
}

using System;
using System.Collections.Generic;
using Aula09.Comum.NotificationPattern;
using Aula09.Dados;
using Aula09.Dominio;

namespace Aula09.Servico
{
    public class Material_Servico
    {

        private readonly Material_Repositorio _material_Repositorio;
        public Material_Servico()
        {
            _material_Repositorio = new Material_Repositorio();
        }


        public NotificationResult Salvar(Material entidade)
        {
            var notificationResult = new NotificationResult();

            try
            {
                if (entidade.CodMaterial == 0)
                    notificationResult.Add(new NotificationError("Qtde. de produtos no Estoque inválido.", NotificationErrorType.USER));

                if (notificationResult.IsValid)
                {
                    _material_Repositorio.Adicionar(entidade);

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

        public string Excluir(Material entidade)
        {
            return "";
        }

        public IEnumerable<Material> ListarTodosComEstoqueZerado()
        {
            return _material_Repositorio.ListarTodosComEstoqueZerado();
        }
    }
}

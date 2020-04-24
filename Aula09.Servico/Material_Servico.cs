using System;
using System.Collections.Generic;
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


        public string Salvar(Material entidade)
        {
            return "Ok";
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

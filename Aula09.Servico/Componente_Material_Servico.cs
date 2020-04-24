using System;
using System.Collections.Generic;
using Aula09.Dados;
using Aula09.Dominio;

namespace Aula09.Servico
{
    public class Componente_Material_Servico
    {

        private readonly Componente_Material_Repositorio _componente_Material_Repositorio;
        public Componente_Material_Servico()
        {
            _componente_Material_Repositorio = new Componente_Material_Repositorio();
        }


        public string Salvar(Componente_Material entidade)
        {
            return "Ok";
        }

        public string Excluir(Componente_Material entidade)
        {
            return "";
        }

        public IEnumerable<Componente_Material> ListarTodosComEstoqueZerado()
        {
            return _componente_Material_Repositorio.ListarTodosComEstoqueZerado();
        }
    }
}

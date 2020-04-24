using System;
using System.Collections.Generic;
using Aula09.Dados;
using Aula09.Dominio;

namespace Aula09.Servico
{
    public class Tipo_Armadura_Servico
    {

        private readonly Tipo_Armadura_Repositorio _tipo_Armadura_Repositorio;
        public Tipo_Armadura_Servico()
        {
            _tipo_Armadura_Repositorio = new Tipo_Armadura_Repositorio();
        }


        public string Salvar(Tipo_Armadura entidade)
        {
            return "Ok";
        }

        public string Excluir(Tipo_Armadura entidade)
        {
            return "";
        }

        public IEnumerable<Tipo_Armadura> ListarTodosComEstoqueZerado()
        {
            return _tipo_Armadura_Repositorio.ListarTodosComEstoqueZerado();
        }
    }
}

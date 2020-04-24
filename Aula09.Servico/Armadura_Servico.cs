using System;
using System.Collections.Generic;
using Aula09.Dados;
using Aula09.Dominio;

namespace Aula09.Servico
{
    public class Armadura_Servico
    {

        private readonly Armadura_Repositorio _armadura_Repositorio;
        public Armadura_Servico()
        {
            _armadura_Repositorio = new Armadura_Repositorio();
        }


        public string Salvar(Armadura entidade)
        {
            return "Ok";
        }

        public string Excluir(Armadura entidade)
        {
            return "";
        }

        public IEnumerable<Armadura> ListarTodosComEstoqueZerado()
        {
            return _armadura_Repositorio.ListarTodosComEstoqueZerado();
        }
    }
}

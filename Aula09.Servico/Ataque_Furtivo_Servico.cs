using System;
using System.Collections.Generic;
using Aula09.Dados;
using Aula09.Dominio;

namespace Aula09.Servico
{
    public class Ataque_Furtivo_Servico
    {

        private readonly Ataque_Furtivo_Repositorio _ataque_Furtivo_Repositorio;
        public Ataque_Furtivo_Servico()
        {
            _ataque_Furtivo_Repositorio = new Ataque_Furtivo_Repositorio();
        }


        public string Salvar(Ataque_Furtivo entidade)
        {
            return "Ok";
        }

        public string Excluir(Ataque_Furtivo entidade)
        {
            return "";
        }

        public IEnumerable<Ataque_Furtivo> ListarTodosComEstoqueZerado()
        {
            return _ataque_Furtivo_Repositorio.ListarTodosComEstoqueZerado();
        }
    }
}

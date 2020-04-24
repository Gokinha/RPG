using System;
using System.Collections.Generic;
using Aula09.Dados;
using Aula09.Dominio;

namespace Aula09.Servico
{
    public class Componente_Servico
    {

        private readonly Componente_Repositorio _componente_Repositorio;
        public Componente_Servico()
        {
            _componente_Repositorio = new Componente_Repositorio();
        }


        public string Salvar(Componente entidade)
        {
            return "Ok";
        }

        public string Excluir(Componente entidade)
        {
            return "";
        }

        public IEnumerable<Componente> ListarTodosComEstoqueZerado()
        {
            return _componente_Repositorio.ListarTodosComEstoqueZerado();
        }
    }
}

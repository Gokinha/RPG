using System;
using System.Collections.Generic;
using Aula09.Dados;
using Aula09.Dominio;

namespace Aula09.Servico
{
    public class Idioma_Servico
    {

        private readonly Idioma_Repositorio _idioma_Repositorio;
        public Idioma_Servico()
        {
            _idioma_Repositorio = new Idioma_Repositorio();
        }


        public string Salvar(Idioma entidade)
        {
            return "Ok";
        }

        public string Excluir(Idioma entidade)
        {
            return "";
        }

        public IEnumerable<Idioma> ListarTodosComEstoqueZerado()
        {
            return _idioma_Repositorio.ListarTodosComEstoqueZerado();
        }
    }
}

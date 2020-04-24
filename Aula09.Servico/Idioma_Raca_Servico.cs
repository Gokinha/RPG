using System;
using System.Collections.Generic;
using Aula09.Dados;
using Aula09.Dominio;

namespace Aula09.Servico
{
    public class Idioma_Raca_Servico
    {

        private readonly Idioma_Raca_Repositorio _idioma_Raca_Repositorio;
        public Idioma_Raca_Servico()
        {
            _idioma_Raca_Repositorio = new Idioma_Raca_Repositorio();
        }


        public string Salvar(Idioma_Raca entidade)
        {
            return "Ok";
        }

        public string Excluir(Idioma_Raca entidade)
        {
            return "";
        }

        public IEnumerable<Idioma_Raca> ListarTodosComEstoqueZerado()
        {
            return _idioma_Raca_Repositorio.ListarTodosComEstoqueZerado();
        }
    }
}

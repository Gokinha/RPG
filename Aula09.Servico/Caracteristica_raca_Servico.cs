using System;
using System.Collections.Generic;
using Aula09.Dados;
using Aula09.Dominio;

namespace Aula09.Servico
{
    public class Caracteristica_raca_Servico
    {

        private readonly Caracteristica_Raca_Repositorio _caracteristica_Raca_Repositorio;
        public Caracteristica_raca_Servico()
        {
            _caracteristica_Raca_Repositorio = new Caracteristica_Raca_Repositorio();
        }


        public string Salvar(Caracteristica_Raca entidade)
        {
            return "Ok";
        }

        public string Excluir(Caracteristica_Raca entidade)
        {
            return "";
        }

        public IEnumerable<Caracteristica_Raca> ListarTodosComEstoqueZerado()
        {
            return _caracteristica_Raca_Repositorio.ListarTodosComEstoqueZerado();
        }
    }
}

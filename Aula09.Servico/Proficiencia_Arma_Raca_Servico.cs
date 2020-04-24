using System;
using System.Collections.Generic;
using Aula09.Dados;
using Aula09.Dominio;

namespace Aula09.Servico
{
    public class Proficiencia_Arma_Raca_Servico
    {

        private readonly Proficiencia_Arma_Raca_Repositorio _proficiencia_Arma_Raca_Repositorio;
        public Proficiencia_Arma_Raca_Servico()
        {
            _proficiencia_Arma_Raca_Repositorio = new Proficiencia_Arma_Raca_Repositorio();
        }


        public string Salvar(Proficiencia_Arma_Raca entidade)
        {
            return "Ok";
        }

        public string Excluir(Proficiencia_Arma_Raca entidade)
        {
            return "";
        }

        public IEnumerable<Proficiencia_Arma_Raca> ListarTodosComEstoqueZerado()
        {
            return _proficiencia_Arma_Raca_Repositorio.ListarTodosComEstoqueZerado();
        }
    }
}

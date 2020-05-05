using System;
using System.Collections.Generic;
using Aula09.Dados;
using Aula09.Dominio;

namespace Aula09.Servico
{
    public class Proficiencia_Arma_Servico
    {

        private readonly Proficiencia_Arma_Repositorio _proficiencia_Arma_Repositorio;
        public Proficiencia_Arma_Servico()
        {
            _proficiencia_Arma_Repositorio = new Proficiencia_Arma_Repositorio();
        }


        public string Salvar(Proficiencia_Arma entidade)
        {
            return "Ok";
        }

        public string Excluir(Proficiencia_Arma entidade)
        {
            return "";
        }

        public IEnumerable<Proficiencia_Arma> ListarTodosComEstoqueZerado()
        {
            return _proficiencia_Arma_Repositorio.ListarTodosComEstoqueZerado();
        }
    }
}

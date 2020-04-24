using System;
using System.Collections.Generic;
using Aula09.Dados;
using Aula09.Dominio;

namespace Aula09.Servico
{
    public class Proficiencia_Arma_Classe_Servico
    {

        private readonly Proficiencia_Arma_Classe_Repositorio _proficiencia_Arma_Classe_Repositorio;
        public Proficiencia_Arma_Classe_Servico()
        {
            _proficiencia_Arma_Classe_Repositorio = new Proficiencia_Arma_Classe_Repositorio();
        }


        public string Salvar(Proficiencia_Arma_Classe entidade)
        {
            return "Ok";
        }

        public string Excluir(Proficiencia_Arma_Classe entidade)
        {
            return "";
        }

        public IEnumerable<Proficiencia_Arma_Classe> ListarTodosComEstoqueZerado()
        {
            return _proficiencia_Arma_Classe_Repositorio.ListarTodosComEstoqueZerado();
        }
    }
}

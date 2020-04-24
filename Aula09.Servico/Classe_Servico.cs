using System;
using System.Collections.Generic;
using Aula09.Dados;
using Aula09.Dominio;

namespace Aula09.Servico
{
    public class Classe_Servico
    {

        private readonly Classe_Repositorio _classe_Repositorio;
        public Classe_Servico()
        {
            _classe_Repositorio = new Classe_Repositorio();
        }


        public string Salvar(Classe entidade)
        {
            return "Ok";
        }

        public string Excluir(Classe entidade)
        {
            return "";
        }

        public IEnumerable<Classe> ListarTodosComEstoqueZerado()
        {
            return _classe_Repositorio.ListarTodosComEstoqueZerado();
        }
    }
}

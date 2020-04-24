using System;
using System.Collections.Generic;
using Aula09.Dados;
using Aula09.Dominio;

namespace Aula09.Servico
{
    public class Classe_Habilidade_Servico
    {

        private readonly Classe_Habilidade_Repositorio _classe_Habilidade_Repositorio;
        public Classe_Habilidade_Servico()
        {
            _classe_Habilidade_Repositorio = new Classe_Habilidade_Repositorio();
        }


        public string Salvar(Classe_Habilidade entidade)
        {
            return "Ok";
        }

        public string Excluir(Classe_Habilidade entidade)
        {
            return "";
        }

        public IEnumerable<Classe_Habilidade> ListarTodosComEstoqueZerado()
        {
            return _classe_Habilidade_Repositorio.ListarTodosComEstoqueZerado();
        }
    }
}

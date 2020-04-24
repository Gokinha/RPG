using System;
using System.Collections.Generic;
using Aula09.Dados;
using Aula09.Dominio;

namespace Aula09.Servico
{
    public class Nivel_Classe_Servico
    {

        private readonly Nivel_Classe_Repositorio _nivel_Classe_Repositorio;
        public Nivel_Classe_Servico()
        {
            _nivel_Classe_Repositorio = new Nivel_Classe_Repositorio();
        }


        public string Salvar(Nivel_Classe entidade)
        {
            return "Ok";
        }

        public string Excluir(Nivel_Classe entidade)
        {
            return "";
        }

        public IEnumerable<Nivel_Classe> ListarTodosComEstoqueZerado()
        {
            return _nivel_Classe_Repositorio.ListarTodosComEstoqueZerado();
        }
    }
}

using System;
using System.Collections.Generic;
using Aula09.Dados;
using Aula09.Dominio;

namespace Aula09.Servico
{
    public class Caracteristicas_Servico
    {

        private readonly Caracteristicas_Repositorio _caracteristicas_Repositorio;
        public Caracteristicas_Servico()
        {
            _caracteristicas_Repositorio = new Caracteristicas_Repositorio();
        }


        public string Salvar(Caracteristicas entidade)
        {
            return "Ok";
        }

        public string Excluir(Caracteristicas entidade)
        {
            return "";
        }

        public IEnumerable<Caracteristicas> ListarTodosComEstoqueZerado()
        {
            return _caracteristicas_Repositorio.ListarTodosComEstoqueZerado();
        }
    }
}

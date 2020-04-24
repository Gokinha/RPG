using System;
using System.Collections.Generic;
using Aula09.Dados;
using Aula09.Dominio;

namespace Aula09.Servico
{
    public class Habilidade_Servico
    {

        private readonly Habilidade_Repositorio _habilidade_Repositorio;
        public Habilidade_Servico()
        {
            _habilidade_Repositorio = new Habilidade_Repositorio();
        }


        public string Salvar(Habilidade entidade)
        {
            return "Ok";
        }

        public string Excluir(Habilidade entidade)
        {
            return "";
        }

        public IEnumerable<Habilidade> ListarTodosComEstoqueZerado()
        {
            return _habilidade_Repositorio.ListarTodosComEstoqueZerado();
        }
    }
}

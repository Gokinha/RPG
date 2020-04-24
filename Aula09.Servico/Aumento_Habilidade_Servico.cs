using System;
using System.Collections.Generic;
using Aula09.Dados;
using Aula09.Dominio;

namespace Aula09.Servico
{
    public class Aumento_Habilidade_Servico
    {

        private readonly Aumento_Habilidade_Repositorio _aumento_Habilidade_Repositorio;
        public Aumento_Habilidade_Servico()
        {
            _aumento_Habilidade_Repositorio = new Aumento_Habilidade_Repositorio();
        }


        public string Salvar(Aumento_Habilidade entidade)
        {
            return "Ok";
        }

        public string Excluir(Aumento_Habilidade entidade)
        {
            return "";
        }

        public IEnumerable<Aumento_Habilidade> ListarTodosComEstoqueZerado()
        {
            return _aumento_Habilidade_Repositorio.ListarTodosComEstoqueZerado();
        }
    }
}

using System;
using System.Collections.Generic;
using Aula09.Dados;
using Aula09.Dominio;

namespace Aula09.Servico
{
    public class Ficha_Idioma_Servico
    {

        private readonly Ficha_Idioma_Repositorio _ficha_Idioma_Repositorio;
        public Ficha_Idioma_Servico()
        {
            _ficha_Idioma_Repositorio = new Ficha_Idioma_Repositorio();
        }


        public string Salvar(Ficha_Idioma entidade)
        {
            return "Ok";
        }

        public string Excluir(Ficha_Idioma entidade)
        {
            return "";
        }

        public IEnumerable<Ficha_Idioma> ListarTodosComEstoqueZerado()
        {
            return _ficha_Idioma_Repositorio.ListarTodosComEstoqueZerado();
        }
    }
}

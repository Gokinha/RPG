using System;
using System.Collections.Generic;
using Aula09.Dados;
using Aula09.Dominio;

namespace Aula09.Servico
{
    public class Proficiencia_Pericia_Servico
    {

        private readonly Proficiencia_Pericia_Repositorio _proficiencia_Pericia_Repositorio;
        public Proficiencia_Pericia_Servico()
        {
            _proficiencia_Pericia_Repositorio = new Proficiencia_Pericias_Repositorio();
        }

        public string Salvar(Proficiencia_Servico entidade)
        {
            return "Ok";
        }

        public string Excluir(Proficiencia_Pericias entidade)
        {
            return "";
        }

        public IEnumerable<Proficiencia_Pericias> ListarTodosComEstoqueZerado()
        {
            return _proficiencia_Pericia_Repositorio.ListarTodosComEstoqueZerado();
        }
    }
}

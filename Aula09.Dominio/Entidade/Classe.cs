using System;
using System.Collections.Generic;
using System.Text;

namespace Aula09.Dominio
{
    public class Classe
    {
        public int CodClasse { get; set; }
        public string DescricaoClasse { get; set; }
        public string NomeClasse { get; set; }
        public int CodDado { get; set; }
        public Dado Dado { get; set; }
    }
}

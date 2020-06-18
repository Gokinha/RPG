using System;
using System.Collections.Generic;
using System.Text;

namespace Aula09.Dominio
{
    public class Ataque_Furtivo
    {
        public int CodClasse { get; set; }
        public Classe Classe { get; set; }
        public int CodNivel { get; set; }
        public Nivel Nivel { get; set; }
        public int QtdDado { get; set; }
        public int CodDado { get; set; }
        public Dado Dado { get; set; }
    }
}

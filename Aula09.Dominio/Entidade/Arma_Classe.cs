using System;
using System.Collections.Generic;
using System.Text;

namespace Aula09.Dominio
{
    public class Arma_Classe
    {
        public int CodArma { get; set; }
        public Arma Arma { get; set; }
        public int CodClasse { get; set; }
        public Classe Classe { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Aula09.Dominio
{
    public class Arma_Propriedade_Arma
    {
        public int CodArma { get; set; }
        public Arma Arma { get; set; }
        public int CodPropriedadeArma { get; set; }
        public Arma_Propriedade_Arma Propriedade_Arma { get; set; }

    }
}

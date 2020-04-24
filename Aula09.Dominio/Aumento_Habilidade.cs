using System;
using System.Collections.Generic;
using System.Text;

namespace Aula09.Dominio
{
    public class Aumento_Habilidade
    {
        public int CodAtributo { get; set; }
        public Atributo Atributo { get; set; }
        public int CodRaca { get; set; }
        public Raca Raca { get; set; }
        public int VlrAumento { get; set; }
    }
}

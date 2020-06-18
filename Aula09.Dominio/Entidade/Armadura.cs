using System;
using System.Collections.Generic;
using System.Text;

namespace Aula09.Dominio
{
    public class Armadura
    {
        public int CodArmadura { get; set; }
        public int Furtividade { get; set; }
        public decimal PesoArmadura { get; set; }
        public int ClasseArmadura { get; set; }
        public int AdicionalArmadura { get; set; }
        public int ForcaArmadura { get; set; }
        public string NomeArmadura { get; set; }
        public int CodTipoArmadura { get; set; }
        public Tipo_Armadura Tipo_Armadura { get; set; }
    }
}

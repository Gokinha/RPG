using System;
using System.Collections.Generic;
using System.Text;

namespace Aula09.Dominio
{
    public class Bonus_Proficiencia
    {
        public int CodBonusProficiencia { get; set; }
        public int Bonus { get; set; }
        public int CodNivel { get; set; }
        public Nivel Nivel { get; set; }
    }
}

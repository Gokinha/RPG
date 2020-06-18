using System;
using System.Collections.Generic;
using System.Text;

namespace Aula09.Dominio
{
    public class Classe_Habilidade
    {
        public int CodHabilidade { get; set; }
        public Habilidade Habilidade { get; set; }
        public int CodClasse { get; set; }
        public Classe Classe { get; set; }
    }
}

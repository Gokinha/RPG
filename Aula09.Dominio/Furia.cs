﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Aula09.Dominio
{
    public class Furia
    {
        public int CodClasse { get; set; }
        public Classe Classe { get; set; }
        public int CodNivel { get; set; }
        public Nivel Nivel { get; set; }
        public int QtdFuria { get; set; }
        public int DanoFuria { get; set; }
    }
}

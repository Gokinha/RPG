﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Aula09.Dominio
{
    public class Espacos_Magia
    {
        public int CodClasse { get; set; }
        public Classe Classe { get; set; }
        public int CodNivel { get; set; }
        public Nivel Nivel { get; set; }
        public int QtdMagia { get; set; }
    }
}

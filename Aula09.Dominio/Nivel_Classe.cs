using System;
using System.Collections.Generic;
using System.Text;

namespace Aula09.Dominio
{
    public class Nivel_Classe
    {
        public int CodFicha { get; set; }
        public Ficha Ficha { get; set; }
        public int CodJogador { get; set; }
        public Jogador Jogador { get; set; }
        public int CodNivel { get; set; }
        public Nivel Nivel { get; set; }
        public int CodClasse { get; set; }
        public Classe Classe { get; set; }
    }
}

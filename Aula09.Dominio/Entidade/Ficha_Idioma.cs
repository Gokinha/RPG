using System;
using System.Collections.Generic;
using System.Text;

namespace Aula09.Dominio
{
    public class Ficha_Idioma
    {
        public int CodFicha { get; set; }
        public Ficha Ficha { get; set; }
        public int CodJogador { get; set; }
        public Jogador Jogador { get; set; }
        public int CodIdioma { get; set; }
        public Idioma Idioma { get; set; }
    }
}

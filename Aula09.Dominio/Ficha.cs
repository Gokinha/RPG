using System;
using System.Collections.Generic;
using System.Text;

namespace Aula09.Dominio
{
    public class Ficha
    {
        public int CodFicha { get; set; }
        public int CodJogador { get; set; }
        public Jogador Jogador { get; set; }
        public string NomePersonagem { get; set; }
        public int Vida { get; set; }
        public int CodRaca { get; set; }
        public Raca Raca { get; set; }
    }
}

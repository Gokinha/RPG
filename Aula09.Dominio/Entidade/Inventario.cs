using System;
using System.Collections.Generic;
using System.Text;

namespace Aula09.Dominio
{
    public class Inventario
    {
        public int CodFicha { get; set; }
        public Ficha Ficha { get; set; }
        public int CodJogador { get; set; }
        public Jogador Jogador { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Aula09.Dominio
{
    public class Arma_Inventario
    {
        public int CodFicha { get; set; }
        public Ficha Ficha { get; set; }
        public int CodJogador { get; set; }
        public Jogador Jogador { get; set; }
        public int CodArma { get; set; }
        public Arma Arma { get; set; }
        public int Qtde { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Aula09.Dominio
{
    public class Equipamentos_Inventario
    { 
        public int CodFicha { get; set; }
        public Ficha Ficha { get; set; }
        public int CodJogador { get; set; }
        public Jogador Jogador { get; set; }
        public int CodEquipamento { get; set; }
        public Equipamento Equipamento { get; set; }
        public int Qtd { get; set; }
    }
}

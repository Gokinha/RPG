using System;
using System.Collections.Generic;
using System.Text;

namespace Aula09.Dominio
{
    public class Raca
    {
        public int CodRaca { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Tendencia { get; set; }
        public decimal TamanhoMin { get; set; }
        public decimal TamanhoMax { get; set; }
        public decimal PesoRaca { get; set; }
        public float VisaoEscuro { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Aula09.Dominio
{
    public class Jogador
    {
        public int CodJogador { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public DateTime DataNascimento{ get; set; }
    }
}

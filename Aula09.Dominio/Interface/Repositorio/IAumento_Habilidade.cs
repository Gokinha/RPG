using Aula09.Dominio;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WebCommerce.Dominio.Interfaces
{
    public interface IAumento_Habilidade : IRepositorioBase<Aumento_Habilidade>
    {
        IEnumerable<Aumento_Habilidade> ListarAtivos();
    }
}
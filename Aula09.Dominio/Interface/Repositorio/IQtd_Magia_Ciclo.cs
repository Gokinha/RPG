using Aula09.Dominio;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WebCommerce.Dominio.Interfaces
{
    public interface IQtd_Magia_Ciclo : IRepositorioBase<Qtd_Magia_Ciclo>
    {
        IEnumerable<Qtd_Magia_Ciclo> ListarAtivos();
    }
}
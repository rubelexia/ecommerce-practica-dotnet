using Ecommerce.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Repositorio.Contrato
{
    public interface IVentaRepositorio : IGenericoRepositorio<Venta>
    {
        Task<Venta> Registrar(Venta modelo);
    }
}

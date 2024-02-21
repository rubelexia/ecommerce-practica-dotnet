using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.DTO
{
    public class ResponseDTO<T>
    {
        public T? Resultado { get; set; }

        public bool EsCorrecto { get; set; }

        public string? Mensaje { get; set; }
    }
}

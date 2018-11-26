using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaEscritorio
{
    public class ProductosC
    {
        public int CodigoPId { get; set; }
        public string NombreDelP { get; set; }
        public int ValorDelP { get; set; }
        public int cantidad { get; set; }

        public override string ToString()
        {
            return $"{CodigoPId};{NombreDelP};{ValorDelP};{cantidad}";
        }
    }
    
}

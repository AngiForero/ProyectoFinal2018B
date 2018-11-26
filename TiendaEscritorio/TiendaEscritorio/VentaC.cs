using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TiendaEscritorio
{
    public class VentaC
    {
       public string Producto { get; set; }
         public int Cantidad{ get; set; }
         public int Total { get; set; }

        public override string ToString()
        {
            return $"{Producto};{Cantidad};{Total}";
        }
    }
}


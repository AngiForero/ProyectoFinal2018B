using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaEscritorio
{
    public class CompraC
    {
        public int CompraId { get; set; }
        public string producto { get; set; }
        public int cantidad { get; set; }
        public DateTime fecha { get; set; }

        public override string ToString()
        {
            return $"{producto};{cantidad};{CompraId}";
        }
                       

    }
}


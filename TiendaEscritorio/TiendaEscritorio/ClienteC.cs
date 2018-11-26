using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaEscritorio
{
    public class ClienteC
    {
        public int ClienteCodigoId { get; set; }
        public string NombreCliente { get; set; }
        public string ApellidoCliente { get; set; }
        public int CedulaCliente { get; set; }
        public string DireccionCliente { get; set; }
        public int TelefonoCliente { get; set; }

        public override string ToString()
        {
            return $"{ClienteCodigoId };{NombreCliente};{ApellidoCliente};{CedulaCliente};{DireccionCliente};{TelefonoCliente}";
        }
    }
}

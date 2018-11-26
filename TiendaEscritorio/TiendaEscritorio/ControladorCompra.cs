using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace TiendaEscritorio
{
    public class ControladorCompra
    {
        public static List<CompraC> Consultar2()
        {
            List<CompraC> compraCs = new List<CompraC>();
            string Cadena = @"Server=ANGIF-DESKTOP-J\SQLEXPRESS;Database=TiendaEscritorio;Trusted_Connection=True;";
            SqlConnection conexion = new SqlConnection(Cadena);
            try
            {
                
                conexion.Open();
                string sql = @"SELECT CompraId,NombreDelProducto,CantidadCompra,FechaCompra  FROM  Compra";
                SqlCommand comando = new SqlCommand(sql, conexion);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    int CompraId = reader.GetInt32(0);
                    string NombreDelProducto = reader.GetString(1);
                    int CantidadCompra = reader.GetInt32(2);
                    DateTime FechaCompra = reader.GetDateTime(3);

                   CompraC compraC = new CompraC

                    {
                       CompraId = CompraId,
                       producto = NombreDelProducto,
                       cantidad = CantidadCompra,
                       fecha = FechaCompra,
                       
                      
                    };
                    compraCs.Add(compraC);

                }
                reader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"No hay error({ex.Message })");
            }
            finally
            {
                if (conexion.State != ConnectionState.Closed)
                {
                    conexion.Close();
                }
            }
            return compraCs;

        }
    }
}

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
    public class ControladorVenta
    {
        public static List<VentaC> Consultar3()
        {
            List<VentaC> ventaCs = new List<VentaC>();
            string Cadena = @"Server=ANGIF-DESKTOP-J\SQLEXPRESS;Database=TiendaEscritorio;Trusted_Connection=True;";
            SqlConnection conexion = new SqlConnection(Cadena);
            try
            {

                conexion.Open();
                string sql = @"SELECT VentaProductoId,CantidadVenta,TotalVenta  FROM  Venta";
                SqlCommand comando = new SqlCommand(sql, conexion);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    string VentaProductoId = reader.GetString(0);
                    int CantidadVenta = reader.GetInt32(1);
                    int TotalVenta = reader.GetInt32(2);

                    VentaC ventaC = new VentaC
                    {
                        Producto = VentaProductoId,
                        Cantidad = CantidadVenta,
                        Total = TotalVenta,
                    };
                    ventaCs.Add(ventaC);

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
            return ventaCs;

        }
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TiendaEscritorio
{
    public partial class AdicionarVenta : Form
    {
        public AdicionarVenta()
        {
            InitializeComponent();
          
        }
        

        private void AdicionarVenta_Load(object sender, EventArgs e)
        {
            mostrarV();
        }

        private void mostrarV()
        {
            mostrarVenta.DataSource = ControladorVenta.Consultar3();
        }




        private void btnRegistrarVenta_Click(object sender, EventArgs e)
        {
            string cadena = @"Server=ANGIF-DESKTOP-J\SQLEXPRESS;Database=TiendaEscritorio;Trusted_Connection=True;";
            SqlConnection conexion = new SqlConnection(cadena);
            try
            {
                conexion.Open();
                string sql = @"INSERT INTO Venta(VentaProductoId,CantidadVenta,TotalVenta)
                                VALUES(@VentaProductoId,@CantidadVenta,@TotalVenta)";

                string sql1 = @"SELECT MAX(VentaProductoId) FROM Venta";

                int a = 0;

                SqlCommand comando = new SqlCommand(sql, conexion);
                SqlCommand comando1 = new SqlCommand(sql1, conexion);

                object dato = comando1.ExecuteScalar();
                if (dato is DBNull)
                {
                    a = 1;
                }
                else
                {
                    a = Convert.ToInt32(dato) + 1;
                }

                comando.Parameters.AddWithValue("@VentaProductoId", Convert.ToInt32(a));
                comando.Parameters.AddWithValue("@CantidadVenta", Convert.ToDouble(txtcantidadVenta.Text));
                comando.Parameters.AddWithValue("@TotalVenta", Convert.ToDouble(txtTventa.Text));


                int filasAfectadas = comando.ExecuteNonQuery();

                if (filasAfectadas > 0)
                {
                    MessageBox.Show("El Registro Se Inserto");

                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrio un Error({ex.Message})");
            }
            finally
            {
                if (conexion.State != ConnectionState.Closed)
                {
                    conexion.Close();
                }
            }

        }
    }
}

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
    public partial class AdicionarCompra : Form
    {
        public AdicionarCompra()
        {
            InitializeComponent();
        }

        private void AdicionarCompra_Load(object sender, EventArgs e)
        {
            mostrarC();
        }
        private void mostrarC()
        {
            mostrarcompra.DataSource = ControladorCompra.Consultar2();
        }

        private void btnRegistrarCompra_Click(object sender, EventArgs e)
        {
            string cadena = @"Server=ANGIF-DESKTOP-J\SQLEXPRESS;Database=TiendaEscritorio;Trusted_Connection=True;";
            SqlConnection conexion = new SqlConnection(cadena);
            try
            {
                conexion.Open();
                string sql = @"INSERT INTO Compra(CompraId,NombreDelProducto,CantidadCompra,FechaCompra)
                                VALUES(@CompraId,@NombreDelProducto,@CantidadCompra,@FechaCompra)";
               
                string sql1 = @"SELECT MAX(CompraId) FROM Compra";
                int a = 0;

                SqlCommand comando = new SqlCommand(sql, conexion);
                SqlCommand comando1 = new SqlCommand(sql1, conexion);

                object dato = comando1.ExecuteScalar();
                if(dato is DBNull)
                {
                    a = 1;
                }
                else
                {
                    a = Convert.ToInt32(dato) + 1;
                }

                comando.Parameters.AddWithValue("@CompraId", Convert.ToInt32(a));
                comando.Parameters.AddWithValue("@NombreDelProducto", txtNombrePCompra.Text);
                comando.Parameters.AddWithValue("@CantidadCompra", Convert.ToDouble(txtCantidadCompra.Text));
                comando.Parameters.AddWithValue("@FechaCompra", Convert.ToDateTime(datetimeCompra.Text));

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

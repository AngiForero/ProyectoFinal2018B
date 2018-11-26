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
    public partial class AdicionarProducto : Form
    {
        public AdicionarProducto()
        {
            InitializeComponent();
        }
        private void AdicionarProducto_Load(object sender, EventArgs e)
        {
            mostrarinfor();
        }
        public void mostrarinfor()
        {
            mostrarpro.DataSource = ControladorDeDatos.Consultar();
        }

        private void btnRegistrarProducto_Click(object sender, EventArgs e)
        {
            string cadena = @"Server=ANGIF-DESKTOP-J\SQLEXPRESS;Database=TiendaEscritorio;Trusted_Connection=True;";
            SqlConnection conexion = new SqlConnection(cadena);
            try
            {
                conexion.Open();
                string sql = @"INSERT INTO Producto(CodigoPId,NombreProducto,ValorProducto,cantidad)
                                VALUES(@CodigoPId,@NombreProducto,@ValorProducto,@cantidad)";
                string sql1 = @"SELECT MAX(CodigoPId) FROM Producto";
                int a = 0;

                SqlCommand comando = new SqlCommand(sql, conexion);
                SqlCommand comando1 = new SqlCommand(sql1, conexion);

                Object dato = comando1.ExecuteScalar();
                if(dato is DBNull)
                {
                    a = 1;
                }
                else
                {
                    a = Convert.ToInt32(dato) + 1;
                }
                comando.Parameters.AddWithValue("@CodigoPId", Convert.ToInt32(a));
                comando.Parameters.AddWithValue("@NombreProducto", txtNProducto.Text);
                comando.Parameters.AddWithValue("@ValorProducto", Convert.ToDouble(txtVProducto.Text));
                comando.Parameters.AddWithValue("@cantidad", Convert.ToDouble(txtCantidad.Text));
              

                int filasAfectadas = comando.ExecuteNonQuery();

                if(filasAfectadas > 0)
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
                if(conexion.State != ConnectionState.Closed)
                {
                    conexion.Close();
                }
            }
        }

        
    }
}

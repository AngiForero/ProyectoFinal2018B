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
    public partial class AdicionarCliente : Form
    {
        public AdicionarCliente()
        {
            InitializeComponent();
        }
        private void AdicionarCliente_Load(object sender, EventArgs e)
        {

            cargarInfo2();
        }
        public void cargarInfo2()
        {
            List<ClienteC> lista = ControladorDeDatos.Consultar1();
            this.dgvClientes.DataSource = lista;
        }

        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            cargarInfo2();

            string cadena = @"Server=ANGIF-DESKTOP-J\SQLEXPRESS;Database=TiendaEscritorio;Trusted_Connection=True;";
            SqlConnection conexion = new SqlConnection(cadena);
            try
            {
                conexion.Open();
                string sql2 = @"INSERT INTO Cliente(ClienteCodigoId,NombreCliente,ApellidoCliente,CedulaCliente,DireccionCliente,TelefonoCliente)
                                VALUES(@ClienteCodigoId,@NombreCliente,@ApellidoCliente,@CedulaCliente,@DireccionCliente,@TelefonoCliente )";
                string sql3 = @"SELECT MAX(ClienteCodigoId) FROM Cliente";
                int a = 0;

                SqlCommand comando = new SqlCommand(sql2, conexion);
                SqlCommand comando1 = new SqlCommand(sql3, conexion);
                Object dato = comando1.ExecuteScalar();
                if (dato is DBNull)
                {
                    a = 1;
                }
                else
                {
                    a = Convert.ToInt32(dato) + 1;
                }
                comando.Parameters.AddWithValue("@ClienteCodigoId", Convert.ToInt32(a));
                comando.Parameters.AddWithValue("@NombreCliente", txtNombreCliente.Text);
                comando.Parameters.AddWithValue("@ApellidoCliente", txtApellidoCliente.Text);
                comando.Parameters.AddWithValue("@CedulaCliente", Convert.ToDouble(txtCedulaCliente.Text));
                comando.Parameters.AddWithValue("@DireccionCliente", txtDireccionCliente.Text);
                comando.Parameters.AddWithValue("@TelefonoCliente", Convert.ToDouble(txtTelefonoCliente.Text));

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

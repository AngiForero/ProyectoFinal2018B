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
    public class ControladorDeDatos
    {
        public static List<ProductosC> Consultar()
        {
            List<ProductosC> productosCs = new List<ProductosC>();
            string Cadena = @"Server=ANGIF-DESKTOP-J\SQLEXPRESS;Database=TiendaEscritorio;Trusted_Connection=True;";
            SqlConnection conexion = new SqlConnection(Cadena);
            try
            {
                conexion.Open();
                string sql = @"SELECT CodigoPId,NombreProducto,ValorProducto,cantidad FROM  Producto";
                SqlCommand comando = new SqlCommand(sql, conexion);

                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    int CodigoPId = reader.GetInt32(0);
                    string NombreDelP = reader.GetString(1);
                    int ValorDelP = reader.GetInt32(2);
                    int cantidad = reader.GetInt32(3);


                    ProductosC productosC = new ProductosC
                    {
                        CodigoPId = CodigoPId,
                        NombreDelP = NombreDelP,
                        ValorDelP = ValorDelP,
                        cantidad = cantidad,

                    };
                    productosCs.Add(productosC);
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
            return productosCs;
        }

        public static List<ClienteC> Consultar1()
        {
            List<ClienteC> clienteCs = new List<ClienteC>();
            string Cadena = @"Server=ANGIF-DESKTOP-J\SQLEXPRESS;Database=TiendaEscritorio;Trusted_Connection=True;";
            SqlConnection conexion = new SqlConnection(Cadena);
            try
            {
                conexion.Open();
                string sql2 = @"SELECT ClienteCodigoId,NombreCliente,ApellidoCliente,CedulaCliente,DireccionCliente,TelefonoCliente FROM  Cliente";
                SqlCommand comando = new SqlCommand(sql2, conexion);

                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {

                    int ClienteCodigoId = reader.GetInt32(0);
                    string NombreCliente = reader.GetString(1);
                    string ApellidoCliente = reader.GetString(2);
                    int CedulaCliente = reader.GetInt32(3);
                    string DireccionCliente = reader.GetString(4);
                    int TelefonoCliente = reader.GetInt32(5);

                    ClienteC clienteC = new ClienteC
                    {

                       ClienteCodigoId = ClienteCodigoId,
                    NombreCliente = NombreCliente,
                   ApellidoCliente = ApellidoCliente,
                    CedulaCliente = CedulaCliente,
                     DireccionCliente = DireccionCliente,
                     TelefonoCliente = TelefonoCliente,

                    };
                   clienteCs.Add(clienteC);
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
            return clienteCs;
        }
               
              

        }
    }


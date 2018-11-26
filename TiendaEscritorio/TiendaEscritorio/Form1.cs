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
using static System.Resources.ResXFileRef;

namespace TiendaEscritorio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarInfo();
           
           
           
        }
      
        public void cargarInfo()
        {
            dgvInventario.DataSource = ControladorDeDatos.Consultar();
            dgvVenta.DataSource = Inventario();

          

        }         
       

        private void btnProducto_Click(object sender, EventArgs e)
        {

            AdicionarProducto adicionarProducto = new AdicionarProducto ();
            adicionarProducto.ShowDialog();
            cargarInfo();          
            
            
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            AdicionarCliente adicionarCliente = new AdicionarCliente();
            adicionarCliente.ShowDialog();


        }
     

        public List<ProductosC> Inventario()
        {
            
            List<ProductosC> productosCs = ControladorDeDatos.Consultar();
            List<CompraC> compraCs = ControladorCompra.Consultar2();
            List<VentaC> ventaCs = ControladorVenta.Consultar3();
            List<ProductosC> productosActuales = new List<ProductosC>();

            for(int i=0; i < productosCs.Count; i++)

            {
               

                ProductosC actual = productosCs[i];
              
                List<CompraC> comprasdelproducto = compraCs.Where(CompraC => CompraC.producto == actual.NombreDelP).ToList();
                List<VentaC> ventasdelproducto = ventaCs.Where(VentaC => Convert.ToInt32(VentaC.Producto) == actual.CodigoPId).ToList();

                ProductosC agregar = new ProductosC
                {

                    CodigoPId = actual.CodigoPId,
                    NombreDelP = actual.NombreDelP,
                    ValorDelP = actual.ValorDelP,
                    
                    cantidad = comprasdelproducto.Sum(CompraC => CompraC.cantidad) - ventasdelproducto.Sum(VentaC => VentaC.Cantidad)
                };
                productosActuales.Add(agregar);
            }
            return productosActuales;
        }




        private void btnCompra_Click(object sender, EventArgs e)
        {
            AdicionarCompra adicionarCompra = new AdicionarCompra();
            adicionarCompra.ShowDialog();
            cargarInfo();


        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            AdicionarVenta adicionarVenta = new AdicionarVenta();
            adicionarVenta.ShowDialog();
            cargarInfo();
        }

        private void dgvInventario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvVenta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}



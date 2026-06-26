using System;
using System.Linq; // Necesario para .Count()
using System.Windows.Forms;

namespace Finalv67
{
    public partial class FormDashboard : Form
    {
        public FormDashboard()
        {
            InitializeComponent();
        }

        // Añadimos el evento Load para invocar el método
        private void FormDashboard_Load_1(object sender, EventArgs e)
        {
            CargarResumen();
            CargarStockBajo();
        }

        public async void CargarResumen()
        {
            try
            {
                var client = ConexionFirebase.Conectar();
                var pedidos = await client.Child("Pedidos").OnceAsync<PedidoFirebase>();

                // si no hay pedidos, devolvemos 0 para evitar errores
                if (pedidos == null) return;

                // Contamos los estados usando LINQ
                int total = pedidos.Count;
                int pendientes = pedidos.Count(p => p.Object != null && p.Object.EstadoPedido == "Pendiente");
                int entregados = pedidos.Count(p => p.Object != null && p.Object.EstadoPedido == "Entregado");
                int cancelados = pedidos.Count(p => p.Object != null && p.Object.EstadoPedido == "Cancelado");

                // Asignamos a tus etiquetas (Labels)
                lblTotal.Text = total.ToString();
                lblPendientes.Text = pendientes.ToString();
                lblEntregados.Text = entregados.ToString();
                lblCancelados.Text = cancelados.ToString();
            }
            catch (Exception ex)
            {
                // Un pequeño aviso en caso de fallo de red
                MessageBox.Show("No se pudo conectar con la nube: " + ex.Message);
            }
        }

        private async void CargarStockBajo()
        {
            try
            {
                var client = ConexionFirebase.Conectar();
                // Traemos todos los productos
                var productosNube = await client.Child("Productos").OnceAsync<ProductoFirebase>();

                // Filtramos y transformamos al formato para el DataGridView
                var listaBajoStock = productosNube
                    .Where(p => p.Object != null && p.Object.Stock < 5)
                    .Select(p => new {
                        Nombre = p.Object.Nombre,
                        Stock = p.Object.Stock,
                        Id = p.Object.Id // Usamos el ID para saber qué editar
                    }).ToList();

                dgvStockBajo.DataSource = listaBajoStock;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar alertas de stock: " + ex.Message);
            }
        }


    }
}
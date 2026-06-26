using System;
using System.Data;
using System.Windows.Forms;
using System.Diagnostics;
using Firebase.Database;

namespace Finalv67
{
    public partial class FormListaVentas : Form
    {
        public FormListaVentas()
        {
            InitializeComponent();
        }

        public async void CargarPedidos()
        {
            try
            {
                var client = ConexionFirebase.Conectar();

                var pedidosNube = await client
                    .Child("Pedidos")
                    .OnceAsync<PedidoFirebase>();

                DataTable dt = new DataTable();
                dt.Columns.Add("Id", typeof(string));
                dt.Columns.Add("Cliente", typeof(string));
                dt.Columns.Add("DNI", typeof(string));
                dt.Columns.Add("Telefono", typeof(string));
                dt.Columns.Add("Direccion", typeof(string));
                dt.Columns.Add("TipoEntrega", typeof(string));
                dt.Columns.Add("MetodoPago", typeof(string));
                dt.Columns.Add("Total", typeof(double));
                dt.Columns.Add("EstadoPedido", typeof(string));
                dt.Columns.Add("Fecha", typeof(string));
                dt.Columns.Add("FechaEntrega", typeof(string));

                var pedidosOrdenados = pedidosNube.OrderByDescending(p => p.Object.Fecha);

                foreach (var p in pedidosOrdenados)
                {
                    if (p.Object != null)
                    {
                        dt.Rows.Add(
                            p.Key,
                            p.Object.Cliente,
                            p.Object.DNI,
                            p.Object.Telefono,
                            p.Object.Direccion,
                            p.Object.TipoEntrega,
                            p.Object.MetodoPago,
                            p.Object.Total,
                            p.Object.EstadoPedido,
                            p.Object.Fecha,
                            p.Object.FechaEntrega
                        );
                    }
                }

                dgvPedidos.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cargando pedidos desde la nube: " + ex.Message, "Error de Lectura", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormListaVentas_Load(object sender, EventArgs e)
        {
            dgvPedidos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPedidos.MultiSelect = false;
            CargarPedidos();
        }

        private void btnVerMas_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://dlolas.netlify.app/html/admin-dashboard.html",
                UseShellExecute = true
            });
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            CargarPedidos();
            this.Cursor = Cursors.Default;
        }
    }
}

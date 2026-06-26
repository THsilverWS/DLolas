using Finalv67;
using Firebase.Database;
using Firebase.Database.Query;
using System;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace Finalv67
{
    public partial class FormListaPedidos : Form
    {
        public FormListaPedidos()
        {
            InitializeComponent();
        }

        private void FormListaPedidos_Load(object sender, EventArgs e)
        {
            dgvPedidos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPedidos.MultiSelect = false;
            CargarPedidos();
        }

        //CARGAR TODOS LOS PEDIDOS DESDE LA NUBE
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

        // ACTUALIZAR ESTADO EN LA NUBE
        private async void ActualizarEstado(string nuevoEstado)
        {
            if (dgvPedidos.SelectedRows.Count > 0)
            {
                var selectedRow = dgvPedidos.SelectedRows[0];
                object idObj = dgvPedidos.Columns.Contains("Id")
                    ? selectedRow.Cells["Id"].Value
                    : selectedRow.Cells[0].Value;

                if (idObj == null || idObj == DBNull.Value)
                {
                    MessageBox.Show("Id del pedido no válido.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string idPedidoFirebase = idObj.ToString();

                try
                {
                    var client = ConexionFirebase.Conectar();

                    await client
                        .Child("Pedidos")
                        .Child(idPedidoFirebase)
                        .Child("EstadoPedido")
                        .PutAsync($"\"{nuevoEstado}\"");

                    MessageBox.Show("El pedido ahora está: " + nuevoEstado, "Estado Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarPedidos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error actualizando estado en internet: " + ex.Message, "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Selecciona un pedido de la tabla primero.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEntregado_Click(object sender, EventArgs e)
        {
            ActualizarEstado("Entregado");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ActualizarEstado("Cancelado");
        }

        // BUSCADOR POR DNI
        private async void txtBuscarDNI_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtBuscarDNI.Text.Trim();

            if (string.IsNullOrEmpty(filtro))
            {
                CargarPedidos();
                return;
            }

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

                // Filtramos el DNI
                var pedidosFiltrados = pedidosNube
                    .Where(p => p.Object.DNI != null && p.Object.DNI.StartsWith(filtro))
                    .OrderByDescending(p => p.Object.Fecha);

                foreach (var p in pedidosFiltrados)
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

                dgvPedidos.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error buscando por DNI: " + ex.Message, "Error de Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ELIMINAR PEDIDOS SELECCIONADOS
        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvPedidos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona al menos un pedido para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var resp = MessageBox.Show("¿Seguro que deseas eliminar el/los pedido(s) seleccionado(s) de la nube? Esta acción no se puede deshacer.",
                                       "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resp != DialogResult.Yes) return;

            try
            {
                var client = ConexionFirebase.Conectar();

                foreach (DataGridViewRow row in dgvPedidos.SelectedRows)
                {
                    object idObj = dgvPedidos.Columns.Contains("Id") ? row.Cells["Id"].Value : row.Cells[0].Value;
                    if (idObj == null || idObj == DBNull.Value) continue;

                    string idPedidoFirebase = idObj.ToString();

                    await client
                        .Child("Pedidos")
                        .Child(idPedidoFirebase)
                        .DeleteAsync();
                }

                MessageBox.Show("Pedido(s) eliminado(s) de la nube correctamente.", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarPedidos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar de Firebase: " + ex.Message, "Error de Red", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://dlolas.netlify.app/html/ventas.html",
                UseShellExecute = true
            });
        }
    }
}
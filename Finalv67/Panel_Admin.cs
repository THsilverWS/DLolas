using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Firebase.Database;
using Firebase.Database.Query;

namespace Finalv67
{
    public partial class Panel_Admin : Form
    {
        public Panel_Admin(string nombreUsuario, string correoUsuario, string urlFoto)
        {
            InitializeComponent();
            lblUsuario.Text = nombreUsuario;
            lblCorreo.Text = correoUsuario;
            if (!string.IsNullOrEmpty(urlFoto))
            {
                try
                {
                    pbFotoUsuario.Load(urlFoto);
                }
                catch
                {
                }
                this.Load += new System.EventHandler(this.Panel_Admin_Load);
            }

        }

        private void AbrirFormEnPanel(object FormHijo)
        {
            panelContenedor.Controls.Clear();

            Form fh = FormHijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;

            panelContenedor.Controls.Add(fh);
            panelContenedor.Tag = fh;
            fh.Show();
        }

        private async void btnVentas_Click(object sender, EventArgs e)
        {
            panelContenedor.Controls.Clear();

            dgvPedidos.Visible = true;
            dgvPedidos.Dock = DockStyle.Fill;

            if (!panelContenedor.Controls.Contains(dgvPedidos))
            {
                panelContenedor.Controls.Add(dgvPedidos);
            }

            dgvPedidos.BringToFront();

            await CargarPedidosEnGrid();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormDashboard());
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormProductos());

        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormGestionPersonal());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async System.Threading.Tasks.Task CargarPedidosEnGrid()
        {
            try
            {
                dgvPedidos.Cursor = Cursors.WaitCursor;
                var client = ConexionFirebase.Conectar();
                var pedidosNube = await client.Child("Pedidos").OnceAsync<PedidoFirebase>();

                DataTable dt = new DataTable();
                dt.Columns.Add("Id", typeof(string));
                dt.Columns.Add("Cliente", typeof(string));
                dt.Columns.Add("DNI", typeof(string));
                dt.Columns.Add("Telefono", typeof(string));
                dt.Columns.Add("Direccion", typeof(string));
                dt.Columns.Add("Total", typeof(double));
                dt.Columns.Add("Estado", typeof(string));
                dt.Columns.Add("Fecha", typeof(string));

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
                            p.Object.Total,
                            p.Object.EstadoPedido,
                            p.Object.Fecha
                        );
                    }
                }

                dgvPedidos.DataSource = dt;
                dgvPedidos.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                dgvPedidos.Cursor = Cursors.Default;
                MessageBox.Show("Error al cargar pedidos: " + ex.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este boton solo es de decoracion xdxd");
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormPerfil());
        }
        public void ActualizarPerfil(string nuevoNombre, string nuevaFotoUrl)
        {
            lblUsuario.Text = nuevoNombre;
            try { pbFotoUsuario.Load(nuevaFotoUrl); } catch { }
        }

        private void Panel_Admin_Load(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormDashboard());
        }
    }
}
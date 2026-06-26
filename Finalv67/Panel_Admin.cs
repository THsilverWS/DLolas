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
            AbrirFormEnPanel(new FormListaVentas());
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
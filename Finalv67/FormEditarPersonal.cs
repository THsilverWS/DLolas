using System;
using System.Windows.Forms;
using Firebase.Database.Query;

namespace Finalv67
{
    public partial class FormEditarPersonal : Form
    {
        private string _idPersona; //

        public FormEditarPersonal(PersonalFirebase persona, string id)
        {
            InitializeComponent();
            _idPersona = id;

            txtNombre.Text = persona.nombre;
            txtCargo.Text = persona.cargo;
            txtRol.Text = persona.rol;
            txtTelefono.Text = persona.telefono;
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                var client = ConexionFirebase.Conectar();

                var datosActualizados = new
                {
                    nombre = txtNombre.Text,
                    cargo = txtCargo.Text,
                    rol = txtRol.Text,
                    telefono = txtTelefono.Text
                };

                await client.Child("usuarios").Child(_idPersona).PatchAsync(datosActualizados);

                MessageBox.Show("Datos actualizados con éxito.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }
    }
}
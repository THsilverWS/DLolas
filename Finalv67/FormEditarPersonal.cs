using System;
using System.Windows.Forms;
using Firebase.Database.Query;

namespace Finalv67
{
    public partial class FormEditarPersonal : Form
    {
        private string _idPersona;

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
            string telefono = txtTelefono.Text.Trim();

            // Validar que solo sean números
            if (!long.TryParse(telefono, out _))
            {
                MessageBox.Show("El teléfono solo debe contener números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar que empiece por 9
            if (!telefono.StartsWith("9"))
            {
                MessageBox.Show("El número de teléfono debe comenzar con el dígito 9.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar la longitud exacta
            if (telefono.Length != 9)
            {
                MessageBox.Show("El número de teléfono debe tener exactamente 9 dígitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
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
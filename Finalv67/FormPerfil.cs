using Firebase.Database.Query;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Finalv67
{
    public partial class FormPerfil : Form
    {
        public FormPerfil()
        {
            InitializeComponent();
        }

        private async void FormPerfil_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(LoginForm.UidUsuarioActual)) return;

            var client = ConexionFirebase.Conectar();

            var usuario = await client.Child("usuarios").Child(LoginForm.UidUsuarioActual).OnceSingleAsync<UsuarioFirebase>();

            // 3. Validación de seguridad contra el null que te daba el error
            if (usuario != null)
            {
                txtNombre.Text = usuario.nombre;
                txtTelefono.Text = usuario.telefono;
                txtUrlFoto.Text = usuario.foto;

                if (!string.IsNullOrEmpty(usuario.foto))
                {
                    try { pbFotoPerfil.Load(usuario.foto); } catch { }
                }
            }
            else
            {
                MessageBox.Show("No se encontraron datos para este usuario en el nodo 'Usuarios'.");
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string telefono = txtTelefono.Text.Trim();

            //  VALIDACIONES
            if (!long.TryParse(telefono, out _))
            {
                MessageBox.Show("El teléfono solo debe contener números.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!telefono.StartsWith("9"))
            {
                MessageBox.Show("El número debe comenzar con el dígito 9.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (telefono.Length != 9)
            {
                MessageBox.Show("El teléfono debe tener exactamente 9 dígitos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var client = ConexionFirebase.Conectar();
                string uid = LoginForm.UidUsuarioActual;

                var actualizaciones = new
                {
                    nombre = txtNombre.Text.Trim(),
                    telefono = telefono,
                    foto = txtUrlFoto.Text.Trim()
                };

                await client.Child("usuarios").Child(uid).PatchAsync(actualizaciones);

                // ACTUALIZACIÓN DE INTERFAZ
                foreach (Form form in Application.OpenForms)
                {
                    if (form is Panel_Admin adminForm)
                    {
                        adminForm.ActualizarPerfil(txtNombre.Text.Trim(), txtUrlFoto.Text.Trim());
                        break;
                    }
                }

                try { pbFotoPerfil.Load(txtUrlFoto.Text); } catch { }

                MessageBox.Show("Perfil actualizado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al guardar: " + ex.Message);
            }
        }
    }
}

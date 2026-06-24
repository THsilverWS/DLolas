using Firebase.Database.Query;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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

            // 2. Asegúrate de usar la misma ruta exacta que en el Login ("Usuarios")
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
            try
            {
                var client = ConexionFirebase.Conectar();
                string uid = LoginForm.UidUsuarioActual;

                // 1. Obtenemos el objeto actual
                var usuarioExistente = await client.Child("usuarios").Child(uid).OnceSingleAsync<UsuarioFirebase>();

                // 2. VALIDACIÓN CRÍTICA: Si no existe, no podemos editar
                if (usuarioExistente == null)
                {
                    MessageBox.Show("Error: No se encontró el registro del usuario en la base de datos.");
                    return;
                }

                // 3. Editamos los campos
                usuarioExistente.nombre = txtNombre.Text;
                usuarioExistente.telefono = txtTelefono.Text;
                usuarioExistente.foto = txtUrlFoto.Text;

                // 4. Guardamos
                await client.Child("usuarios").Child(uid).PutAsync(usuarioExistente);
                foreach (Form form in Application.OpenForms)
                {
                    if (form is Panel_Admin adminForm)
                    {
                        adminForm.ActualizarPerfil(txtNombre.Text, txtUrlFoto.Text);
                        break;
                    }
                }

                // 5. Refrescamos interfaz
                pbFotoPerfil.Load(txtUrlFoto.Text);
                MessageBox.Show("Perfil actualizado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al guardar: " + ex.Message);
            }
        }
    }
}

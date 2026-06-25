using Firebase.Database.Query;
using System;
using System.Windows.Forms;

namespace Finalv67
{
    public partial class FormCodigo : Form
    {
        public FormCodigo()
        {
            InitializeComponent();

            this.Load += new System.EventHandler(this.FormCodigo_Load);
        }

        private async void FormCodigo_Load(object sender, EventArgs e)
        {
            try
            {
                lblCodigoActual.Text = "Cargando...";

                var client = ConexionFirebase.Conectar();
                var resultado = await client.Child("codigo_seguridad").OnceSingleAsync<ClaseCodigoSeguridad>();

                if (resultado != null && !string.IsNullOrEmpty(resultado.codigo))
                {
                    lblCodigoActual.Text = resultado.codigo;
                }
                else
                {
                    lblCodigoActual.Text = "No asignado";
                }
            }
            catch (Exception ex)
            {
                lblCodigoActual.Text = "Error al cargar código";
                MessageBox.Show("No se pudo obtener el código actual: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void btnGuardar_Click_1(object sender, EventArgs e)
        {
            string nuevoCodigo = txtCodigoNuevo.Text.Trim();

            if (nuevoCodigo.Length != 6)
            {
                MessageBox.Show("El código de seguridad debe tener exactamente 6 caracteres.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                btnGuardar.Enabled = false;
                var client = ConexionFirebase.Conectar();

                var datosCodigo = new
                {
                    codigo = nuevoCodigo
                };

                await client.Child("codigo_seguridad").PutAsync(datosCodigo);

                MessageBox.Show("Código de seguridad actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar en Firebase: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnGuardar.Enabled = true;
            }
        }
    }
}
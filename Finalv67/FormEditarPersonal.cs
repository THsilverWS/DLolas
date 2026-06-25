using System;
using System.Windows.Forms;
using Firebase.Database.Query;

namespace Finalv67
{
    public partial class FormEditarPersonal : Form
    {
        private string _idPersona;
        private string _cargoOperador;
        private PersonalFirebase _personaOriginal;

        public FormEditarPersonal(PersonalFirebase persona, string id, string cargoOperador)
        {
            InitializeComponent();
            _idPersona = id;
            _cargoOperador = cargoOperador;
            _personaOriginal = persona;
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

            // Validar que se haya seleccionado un elemento en los combos antes de guardar
            if (cmbRol.SelectedItem == null || cmbCargo.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un Rol y un Cargo válidos de la lista.", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var client = ConexionFirebase.Conectar();


                var datosActualizados = new
                {
                    nombre = lblNombre.Text,
                    cargo = cmbCargo.SelectedItem.ToString(),
                    rol = cmbRol.SelectedItem.ToString(),
                    telefono = telefono,
                    foto = _personaOriginal.foto
                };


                await client.Child("usuarios").Child(_idPersona).PatchAsync(datosActualizados);

                MessageBox.Show("Datos actualizados con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar en Firebase: " + ex.Message, "Error de red", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormEditarPersonal_Load(object sender, EventArgs e)
        {
            // 1. Mostrar el nombre del trabajador en el Label
            lblNombre.Text = _personaOriginal.nombre;

            // Cargar el teléfono en su campo de texto
            txtTelefono.Text = _personaOriginal.telefono;

            // ============================================================
            // 2. SELECCIONAR EL ROL POR DEFECTO
            // ============================================================
            string rolNormalizado = _personaOriginal.rol?.Trim();
            if (rolNormalizado?.ToLower() == "admin" || rolNormalizado?.ToLower() == "administrador")
            {
                cmbRol.SelectedItem = "admin";
            }
            else
            {
                cmbRol.SelectedItem = "Trabajador";
            }

            // ============================================================
            // 3. SELECCIONAR EL CARGO POR DEFECTO
            // ============================================================
            string cargoNormalizado = _personaOriginal.cargo?.Trim();

            if (cmbCargo.Items.Contains(cargoNormalizado))
            {
                cmbCargo.SelectedItem = cargoNormalizado;
            }
            else if (cargoNormalizado?.ToLower() == "dueño")
            {
                cmbCargo.SelectedItem = "Dueño";
            }

            // ============================================================
            // 4. REGLA INVIOLABLE PARA EL DUEÑO
            // ============================================================
            if (cargoNormalizado?.ToLower() == "dueño")
            {
                cmbRol.Enabled = false;
                cmbCargo.Enabled = false;
                txtTelefono.Enabled = false;
                MessageBox.Show("Nota de seguridad: Los rangos del Administrador Principal (Dueño) no pueden ser modificados.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
    
}

using Firebase.Database;
using Firebase.Database.Query;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Finalv67
{
    public partial class FormProductos : Form
    {
        private string nombreProductoOriginal = "";

        public FormProductos()
        {
            InitializeComponent();
        }

        private void FormInventario_Load(object sender, EventArgs e)
        {
            CargarStock();
        }

        // CARGAR PRODUCTOS DESDE LA NUBE
        public async void CargarStock()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                var client = ConexionFirebase.Conectar();
                var productosNube = await client.Child("Productos").OnceAsync<ProductoFirebase>();

                DataTable dt = new DataTable();
                dt.Columns.Add("Id", typeof(int));
                dt.Columns.Add("Nombre", typeof(string));
                dt.Columns.Add("Precio", typeof(double));
                dt.Columns.Add("Stock", typeof(int));
                dt.Columns.Add("Estado", typeof(int));

                foreach (var p in productosNube)
                {
                    if (p.Object != null)
                    {
                        dt.Rows.Add(p.Object.Id, p.Object.Nombre, p.Object.Precio, p.Object.Stock, p.Object.Estado);
                    }
                }
                dgvProductos.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar: " + ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        // GUARDAR O ACTUALIZAR UN PRODUCTO
        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validar campos vacíos
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtPrecio.Text) || string.IsNullOrWhiteSpace(txtStock.Text))
            {
                MessageBox.Show("Por favor, completa todos los campos obligatorios.", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar formatos numéricos
            if (!double.TryParse(txtPrecio.Text, out double precioVerificado))
            {
                MessageBox.Show("Por favor, ingrese un precio numérico válido.", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtStock.Text, out int stockVerificado))
            {
                MessageBox.Show("Por favor, ingrese un valor entero válido para el Stock.", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                this.Cursor = Cursors.WaitCursor;
                var client = ConexionFirebase.Conectar();

                int idTemporal;
                // Evaluamos si es un producto nuevo o una edición
                bool esNuevo = !int.TryParse(lblId.Text, out idTemporal) || idTemporal == 0;

                // Si es nuevo genera un ID random, si no, mantiene el idTemporal que se seleccionó del Grid
                int idFinal = esNuevo ? new Random().Next(1000, 9999) : idTemporal;

                // Si es una edición y el ID cambió por alguna razón, borramos el anterior para evitar duplicados
                if (!esNuevo && idTemporal != idFinal)
                {
                    await client.Child("Productos").Child("prod_" + idTemporal).DeleteAsync();
                }

                var producto = new ProductoFirebase
                {
                    Id = idFinal,
                    Nombre = txtNombre.Text.Trim(),
                    Precio = precioVerificado,
                    Stock = stockVerificado,
                    Estado = chkActivo.Checked ? 1 : 0
                };

                // Va directamente a "prod_XXXX"
                await client.Child("Productos").Child("prod_" + idFinal).PutAsync(producto);

                MessageBox.Show(esNuevo ? "Producto creado exitosamente en la nube." : "Producto actualizado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Limpiar();
                CargarStock();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar en Firebase: " + ex.Message, "Error de Red", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        // al hacer click en una fila del DataGridView, se cargan los datos en los controles para editar
        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvProductos.Rows[e.RowIndex];
                lblId.Text = fila.Cells["Id"].Value.ToString();
                txtNombre.Text = fila.Cells["Nombre"].Value.ToString();
                txtPrecio.Text = fila.Cells["Precio"].Value.ToString();
                txtStock.Text = fila.Cells["Stock"].Value.ToString();
                nombreProductoOriginal = txtNombre.Text;
                chkActivo.Checked = Convert.ToInt32(fila.Cells["Estado"].Value) == 1;
            }
        }

        // LIMPIAR EL FORMULARIO
        private void Limpiar()
        {
            lblId.Text = "";
            txtNombre.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
            nombreProductoOriginal = "";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        // elimna el producto seleccionado
        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblId.Text))
            {
                MessageBox.Show("Por favor, selecciona un producto de la lista primero.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("¿Está seguro de que desea eliminar este producto de la nube de forma permanente?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    this.Cursor = Cursors.WaitCursor;
                    var client = ConexionFirebase.Conectar();

                    // en teoria todos deben comenzar por "prod_" XD asi que
                    // calculamos la ruta exacta directamente. No descargamos toda la lista.
                    string llaveDirectaProd = "prod_" + lblId.Text.Trim();
                    await client.Child("Productos").Child(llaveDirectaProd).DeleteAsync();

                    MessageBox.Show("Producto eliminado correctamente de Firebase.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    CargarStock();
                    Limpiar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al intentar eliminar en Firebase: " + ex.Message, "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    this.Cursor = Cursors.Default;
                }
            }
        }
    }
}
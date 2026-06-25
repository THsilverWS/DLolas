using Finalv67;
using Firebase.Database;
using Firebase.Database.Query;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Finalv67
{
    public partial class FormVenta : Form
    {
        private DataTable carritoDt;

        public FormVenta()
        {
            InitializeComponent();
        }

        private void FormVenta_Load(object sender, EventArgs e)
        {
            cmbPago.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProductos.DropDownStyle = ComboBoxStyle.DropDownList;
            CargarProductosCombo();
            InicializarCarrito();

            // Que el calendario inicie por defecto con la fecha de mañana
            dtpFechaEntrega.Value = DateTime.Now.AddDays(1);
            if (cmbPago.Items.Count > 0)
            {
                cmbPago.SelectedIndex = 0; // Selecciona el primer elemento por defecto
            }
        }

        private void InicializarCarrito()
        {
            // La estructura de datos que vera en el DataGridView osea el carrito
            carritoDt = new DataTable();
            carritoDt.Columns.Add("Id", typeof(int));
            carritoDt.Columns.Add("Nombre", typeof(string));
            carritoDt.Columns.Add("PrecioUnit", typeof(double));
            carritoDt.Columns.Add("Cantidad", typeof(int));
            carritoDt.Columns.Add("Total", typeof(double));

            dgvCarrito.AutoGenerateColumns = true;
            dgvCarrito.DataSource = carritoDt;
            dgvCarrito.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCarrito.MultiSelect = false;
        }

        private async void btnAgregarCarrito_Click(object sender, EventArgs e)
        {
            // Validamos si hay un producto seleccionado
            if (cmbProductos.SelectedItem == null)
            {
                MessageBox.Show("Selecciona un producto primero.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var fila = (DataRowView)cmbProductos.SelectedItem;
            int idProd = Convert.ToInt32(fila["Id"]);
            string nombre = fila["Nombre"].ToString();
            double precioUnit = Convert.ToDouble(fila["Precio"]);
            int cantidad = (int)numCantidad.Value;

            if (cantidad <= 0)
            {
                MessageBox.Show("La cantidad debe ser mayor que cero.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Conectamos y descargamos la lista completa para buscar por su clave real de Firebase
                var client = ConexionFirebase.Conectar();
                var productosNube = await client.Child("Productos").OnceAsync<ProductoFirebase>();

                // Buscamos el producto cuyo ID interno coincida con el ID seleccionado del Combo
                var nodoProducto = productosNube.FirstOrDefault(p => p.Object.Id == idProd);

                // Verificamos si realmente existe en la base de datos
                if (nodoProducto == null)
                {
                    MessageBox.Show($"El producto '{nombre}' no fue encontrado en el servidor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                ProductoFirebase prodNube = nodoProducto.Object;

                // Verificamos si tiene stock disponible
                if (prodNube.Stock <= 0)
                {
                    MessageBox.Show($"El stock para '{nombre}' está completamente agotado.", "Stock Vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    CargarProductosCombo(); // Recargamos el combo para limpiar los agotados
                    return;
                }

                // Verificar si intentan llevar más cantidad de la que hay en stock en el carrito actual
                var existing = carritoDt.AsEnumerable().FirstOrDefault(r => r.Field<int>("Id") == idProd);
                int cantidadEnCarritoAnterior = existing != null ? existing.Field<int>("Cantidad") : 0;

                if (prodNube.Stock < (cantidadEnCarritoAnterior + cantidad))
                {
                    MessageBox.Show($"No puedes agregar esa cantidad. Stock disponible actual: {prodNube.Stock} unidades.", "Stock Insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Agregamos al carrito o incrementamos la cantidad
                if (existing != null)
                {
                    int nuevaCant = existing.Field<int>("Cantidad") + cantidad;
                    existing.SetField("Cantidad", nuevaCant);
                    existing.SetField("Total", nuevaCant * precioUnit);
                }
                else
                {
                    var row = carritoDt.NewRow();
                    row["Id"] = idProd;
                    row["Nombre"] = nombre;
                    row["PrecioUnit"] = precioUnit;
                    row["Cantidad"] = cantidad;
                    row["Total"] = precioUnit * cantidad;
                    carritoDt.Rows.Add(row);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al verificar el stock en tiempo real: " + ex.Message, "Error");
            }
        }

        private void btnQuitarCarrito_Click(object sender, EventArgs e)
        {
            if (dgvCarrito.SelectedRows.Count > 0)
            {
                DataGridViewRow filaVisual = dgvCarrito.SelectedRows[0];
                int idProd = Convert.ToInt32(filaVisual.Cells["Id"].Value);

                // Buscamos la fila en el DataTable para eliminarla
                var filaData = carritoDt.AsEnumerable().FirstOrDefault(r => r.Field<int>("Id") == idProd);

                if (filaData != null)
                {
                    carritoDt.Rows.Remove(filaData);
                    MessageBox.Show("Producto removido del carrito correctamente.", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona el producto que deseas quitar de la lista del carrito.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void btnFinalizar_Click(object sender, EventArgs e)
        {
            // Validaciones de los datos obligatorios
            if (carritoDt.Rows.Count == 0)
            {
                MessageBox.Show("El carrito está vacío.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtDNI.Text))
            {
                MessageBox.Show("Por favor, completa el Nombre y DNI del cliente.", "Campos Faltantes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (rbDelivery.Checked && string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                MessageBox.Show("Debes ingresar una dirección para el Delivery.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (dtpFechaEntrega.Value.Date < DateTime.Now.Date)
            {
                MessageBox.Show("La fecha de entrega no puede ser menor al día de hoy.", "Fecha Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string telefono = txtTelefono.Text;
            if (telefono.Length != 9 || !telefono.StartsWith("9") || !telefono.All(char.IsDigit))
            {
                MessageBox.Show("Ingrese un número de teléfono válido (9 dígitos y empezar con 9).");
                return;
            }

            string dni = txtDNI.Text;
            if (dni.Length != 8 || !dni.All(char.IsDigit))
            {
                MessageBox.Show("Ingrese un DNI válido (8 dígitos).");
                return;
            }

            if (cmbPago.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecciona una opción válida de la lista.", "Campo obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Bloqueamos interfaz mientras carga la venta
            AlternarBloqueoInterfaz(true);

            double totalVenta = carritoDt.AsEnumerable().Sum(r => r.Field<double>("Total"));
            var client = ConexionFirebase.Conectar();
            var listaProductosPedido = new Dictionary<string, DetalleItemCarrito>();

            try
            {
                var tareasStock = new List<Task>();

                // Descargamos TODOS los productos de la nube una sola vez ANTES del bucle
                var todosProductosNube = await client.Child("Productos").OnceAsync<ProductoFirebase>();

                // Procesamos cada item del carrito
                foreach (DataRow r in carritoDt.Rows)
                {
                    int id = r.Field<int>("Id");
                    int cantComprada = r.Field<int>("Cantidad");
                    string nombreProd = r.Field<string>("Nombre");
                    double precioUnit = r.Field<double>("PrecioUnit");

                    // Buscamos el producto localmente usando el ID
                    var nodoProd = todosProductosNube.FirstOrDefault(p => p.Object.Id == id);

                    if (nodoProd == null || nodoProd.Object.Stock < cantComprada)
                    {
                        MessageBox.Show($"¡Error de inventario! El producto '{nombreProd}' ya no cuenta con stock suficiente en la nube.\nVenta cancelada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        AlternarBloqueoInterfaz(false);
                        return;
                    }

                    ProductoFirebase prodNube = nodoProd.Object;

                    // Actualizamos el stock en el objeto
                    prodNube.Stock -= cantComprada;

                    // Guardamos en Firebase usando la llave real (nodoProd.Key)
                    tareasStock.Add(client.Child("Productos").Child(nodoProd.Key).PutAsync(prodNube));

                    var itemDetalle = new DetalleItemCarrito
                    {
                        nombre = nombreProd,
                        cantidad = cantComprada,
                        precio = precioUnit
                    };

                    listaProductosPedido.Add("item_" + id, itemDetalle);
                }

                // Ejecutamos todas las actualizaciones de stock en paralelo
                await Task.WhenAll(tareasStock);

                // Creamos los datos del pedido para subir a Firebase
                string tipoEntrega = rbDelivery.Checked ? "Delivery" : "Tienda";
                string direccionFinal = rbDelivery.Checked ? txtDireccion.Text : "Recojo en Tienda";

                var nuevoPedido = new PedidoFirebase
                {
                    Cliente = txtNombre.Text,
                    DNI = txtDNI.Text,
                    Telefono = txtTelefono.Text,
                    Direccion = direccionFinal,
                    TipoEntrega = tipoEntrega,
                    MetodoPago = cmbPago.Text,
                    Total = totalVenta,
                    EstadoPedido = "Pendiente",
                    Fecha = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                    FechaEntrega = dtpFechaEntrega.Value.ToString("yyyy-MM-dd"),
                    productos = listaProductosPedido,
                    NotaExtra = txtNota.Text.Trim()
                };

                // Subimos el pedido al firebase
                await client.Child("Pedidos").PostAsync(nuevoPedido);

                MessageBox.Show($"¡Venta Exitosa!\nTotal a cobrar: S/ {totalVenta:F2}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarFormularioVenta(); // Limpiamos el formulario para una nueva venta
                CargarProductosCombo();
            }
            catch (Exception ex)
            {
                AlternarBloqueoInterfaz(false);
                MessageBox.Show("Error al procesar la venta en Firebase: " + ex.Message, "Error de Red", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // para limpiar el formulario después de finalizar una venta
        private void LimpiarFormularioVenta()
        {
            txtNombre.Clear();
            txtDNI.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();
            txtNota.Clear();

            carritoDt.Rows.Clear();

            rbTienda.Checked = true;
            numCantidad.Value = 1;
            dtpFechaEntrega.Value = DateTime.Now.AddDays(1);
            if (cmbPago.Items.Count > 0) cmbPago.SelectedIndex = 0;

            AlternarBloqueoInterfaz(false);
            txtNombre.Focus();
        }

        private void AlternarBloqueoInterfaz(bool bloquear)
        {
            this.Cursor = bloquear ? Cursors.WaitCursor : Cursors.Default;
            btnFinalizar.Enabled = !bloquear;
            btnAgregarCarrito.Enabled = !bloquear;
            btnQuitarCarrito.Enabled = !bloquear;
            dgvCarrito.Enabled = !bloquear;
            txtNombre.Enabled = !bloquear;
            txtDNI.Enabled = !bloquear;
        }

        private async void CargarProductosCombo()
        {
            try
            {
                var client = ConexionFirebase.Conectar();
                var productosNube = await client
                    .Child("Productos")
                    .OnceAsync<ProductoFirebase>();

                DataTable dt = new DataTable();
                dt.Columns.Add("Id", typeof(int));
                dt.Columns.Add("Nombre", typeof(string));
                dt.Columns.Add("Precio", typeof(double));

                foreach (var p in productosNube)
                {
                    if (p.Object.Estado == 1 && p.Object.Stock > 0)
                    {
                        dt.Rows.Add(p.Object.Id, p.Object.Nombre, p.Object.Precio);
                    }
                }

                if (dt.Rows.Count > 0)
                {
                    cmbProductos.DataSource = dt;
                    cmbProductos.DisplayMember = "Nombre";
                    cmbProductos.ValueMember = "Id";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al descargar productos de Firebase: " + ex.Message);
            }
        }

        // esto cambia el estado de la dirección dependiendo si es delivery o tienda
        private void rbDelivery_CheckedChanged(object sender, EventArgs e)
        {
            txtDireccion.Enabled = rbDelivery.Checked;
            if (rbDelivery.Checked) txtDireccion.Focus();
        }

        private void rbTienda_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTienda.Checked)
            {
                txtDireccion.Enabled = false;
                txtDireccion.Clear();
            }
        }
    }
}
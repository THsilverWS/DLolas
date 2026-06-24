using System.Data;

namespace Finalv67
{
    public partial class FormInventario : Form
    {
        public FormInventario()
        {
            InitializeComponent();
        }
        private void FormInventario_Load(object sender, EventArgs e)
        {
            CargarStock();
        }


        public async void CargarStock()
        {
            try
            {
                var client = ConexionFirebase.Conectar();

                // cargamos la lista completa de productos
                var productosNube = await client
                    .Child("Productos")
                    .OnceAsync<ProductoFirebase>();

                // Creamos la estructura de la tabla para rellenar Productos
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
                        dt.Rows.Add(
                            p.Object.Id,
                            p.Object.Nombre,
                            p.Object.Precio,
                            p.Object.Stock,
                            p.Object.Estado
                        );
                    }
                }

                dgvProductos.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar stock desde la nube: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }


}

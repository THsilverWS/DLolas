using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Firebase.Database.Query;

namespace Finalv67
{
    public partial class FormGestionPersonal : Form
    {
        private List<PersonalFirebase> listaCompleta;

        public FormGestionPersonal()
        {
            InitializeComponent();
        }

        private async void FormGestionPersonal_Load(object sender, EventArgs e)
        {
            dgvPersonal.RowTemplate.Height = 60;
            dgvPersonal.RowHeadersVisible = false;

            ConfigurarColumnas();


            await CargarPersonal();
        }

        private void ConfigurarColumnas()
        {
            dgvPersonal.Columns.Clear();
            dgvPersonal.AutoGenerateColumns = false;

            // Columna Foto
            DataGridViewImageColumn colFoto = new DataGridViewImageColumn();
            colFoto.Name = "colFoto";
            colFoto.HeaderText = "Foto";
            colFoto.Width = 60;
            colFoto.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgvPersonal.Columns.Add(colFoto);

            // Columnas de Datos
            AgregarColumna("id", "ID");
            AgregarColumna("nombre", "Usuario");
            AgregarColumna("correo", "Email");
            AgregarColumna("rol", "Rol");
            AgregarColumna("cargo", "Cargo");
            AgregarColumna("telefono", "Teléfono");

            // Columna Botón Editar
            DataGridViewButtonColumn btnEditar = new DataGridViewButtonColumn();
            btnEditar.Name = "btnEditar";
            btnEditar.HeaderText = "Acción";
            btnEditar.Text = "Editar";
            btnEditar.UseColumnTextForButtonValue = true; 
            dgvPersonal.Columns.Add(btnEditar);

            // Columna Botón Eliminar
            DataGridViewButtonColumn btnEliminar = new DataGridViewButtonColumn();
            btnEliminar.Name = "btnEliminar";
            btnEliminar.HeaderText = "Acción";
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseColumnTextForButtonValue = true;
            dgvPersonal.Columns.Add(btnEliminar);
        }

        private void AgregarColumna(string dataPropertyName, string headerText)
        {
            DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
            col.Name = dataPropertyName;
            col.HeaderText = headerText;
            col.DataPropertyName = dataPropertyName;
            dgvPersonal.Columns.Add(col);
        }

        private async System.Threading.Tasks.Task CargarPersonal()
        {
            try
            {
                var client = ConexionFirebase.Conectar();
                var personalNube = await client.Child("usuarios").OnceAsync<PersonalFirebase>();

                listaCompleta = new List<PersonalFirebase>();

                foreach (var p in personalNube)
                {
                    if (p.Object != null)
                    {
                        p.Object.id = p.Key;
                        listaCompleta.Add(p.Object);
                    }
                }

                dgvPersonal.DataSource = listaCompleta;
                await CargarFotosEnGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }
        }

        private async System.Threading.Tasks.Task CargarFotosEnGrid()
        {
            for (int i = 0; i < dgvPersonal.Rows.Count; i++)
            {
                var persona = (PersonalFirebase)dgvPersonal.Rows[i].DataBoundItem;

                if (persona != null && !string.IsNullOrEmpty(persona.foto))
                {
                    Image img = await ObtenerImagenDesdeUrl(persona.foto);
                    if (img != null)
                        dgvPersonal.Rows[i].Cells["colFoto"].Value = img;
                }
            }
        }

        private async System.Threading.Tasks.Task<Image> ObtenerImagenDesdeUrl(string url)
        {
            try
            {
                using (var webClient = new System.Net.WebClient())
                {
                    byte[] bytes = await webClient.DownloadDataTaskAsync(url);
                    using (var ms = new System.IO.MemoryStream(bytes))
                    {
                        Image img = Image.FromStream(ms);

                        int tamaño = 60;
                        Bitmap bmp = new Bitmap(tamaño, tamaño);
                        using (Graphics g = Graphics.FromImage(bmp))
                        {
                            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                            float ratio = Math.Max((float)tamaño / img.Width, (float)tamaño / img.Height);
                            int nuevoAncho = (int)(img.Width * ratio);
                            int nuevoAlto = (int)(img.Height * ratio);
                            int posX = (tamaño - nuevoAncho) / 2;
                            int posY = (tamaño - nuevoAlto) / 2;
                            g.DrawImage(img, posX, posY, nuevoAncho, nuevoAlto);
                        }
                        return bmp;
                    }
                }
            }
            catch { return null; }
        }

        private async void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (listaCompleta == null) return;

            string filtro = txtBuscar.Text.ToLower();

            var filtrados = listaCompleta.Where(p =>
                p.nombre.ToLower().Contains(filtro) ||
                p.correo.ToLower().Contains(filtro)
            ).ToList();

            dgvPersonal.DataSource = filtrados;

            await CargarFotosEnGrid();
        }

        private async void dgvPersonal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var persona = (PersonalFirebase)dgvPersonal.Rows[e.RowIndex].DataBoundItem;

                if (persona == null) return;

                if (dgvPersonal.Columns[e.ColumnIndex].Name == "btnEditar")
                {
                    FormEditarPersonal formEdicion = new FormEditarPersonal(persona, persona.id);
                    formEdicion.ShowDialog();
                    await CargarPersonal();
                }

                if (dgvPersonal.Columns[e.ColumnIndex].Name == "btnEliminar")
                {
                    DialogResult dr = MessageBox.Show($"¿Seguro que quieres eliminar a {persona.nombre}?",
                                                      "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        EliminarPersonal(persona.id);
                    }
                }
            }
        }

        private async void EliminarPersonal(string id)
        {
            try
            {
                var client = ConexionFirebase.Conectar();
                await client.Child("usuarios").Child(id).DeleteAsync();

                MessageBox.Show("Personal eliminado correctamente.");
                await CargarPersonal();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
        }
    }
}
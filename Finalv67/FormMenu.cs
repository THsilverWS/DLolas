using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finalv67
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void btnGestionStock_Click(object sender, EventArgs e)
        {
            // Esto abre el formulario inventario donde estna los productos
            FormInventario ventanaStock = new FormInventario();
            ventanaStock.ShowDialog(); //el showDialog es para que no se pueda abrir otra ventana hasta que se cierre esta
        }

        private void btnNuevoPedido_Click(object sender, EventArgs e)
        {
            // Esto abrira el formulario de ventas
            FormVenta ventanaVenta = new FormVenta();
            ventanaVenta.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Cierra el programa XD321X3X23
        }

        private void btnListaPedidos_Click(object sender, EventArgs e)
        {
            //esto abrira el formulario de lista de pedidos
            FormListaPedidos ventanaLista = new FormListaPedidos();
            ventanaLista.ShowDialog();
        }
    }
}

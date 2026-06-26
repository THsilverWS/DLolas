namespace Finalv67
{
    partial class FormVenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVenta));
            groupBox1 = new GroupBox();
            label8 = new Label();
            txtNota = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtTelefono = new TextBox();
            txtDNI = new TextBox();
            txtNombre = new TextBox();
            groupBox2 = new GroupBox();
            label7 = new Label();
            dtpFechaEntrega = new DateTimePicker();
            txtDireccion = new TextBox();
            rbDelivery = new RadioButton();
            rbTienda = new RadioButton();
            groupBox3 = new GroupBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            btnQuitarCarrito = new Button();
            btnFinalizar = new Button();
            cmbPago = new ComboBox();
            dgvCarrito = new DataGridView();
            btnAgregarCarrito = new Button();
            numCantidad = new NumericUpDown();
            cmbProductos = new ComboBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCantidad).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.NavajoWhite;
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtNota);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtTelefono);
            groupBox1.Controls.Add(txtDNI);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Dock = DockStyle.Left;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(294, 519);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(14, 192);
            label8.Name = "label8";
            label8.Size = new Size(61, 15);
            label8.TabIndex = 7;
            label8.Text = "Nota extra";
            // 
            // txtNota
            // 
            txtNota.Location = new Point(12, 216);
            txtNota.Multiline = true;
            txtNota.Name = "txtNota";
            txtNota.ScrollBars = ScrollBars.Vertical;
            txtNota.Size = new Size(264, 246);
            txtNota.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 126);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 5;
            label3.Text = "Telefono";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 87);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(27, 15);
            label2.TabIndex = 4;
            label2.Text = "DNI";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 47);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 3;
            label1.Text = "Nombre";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(93, 123);
            txtTelefono.Margin = new Padding(4, 3, 4, 3);
            txtTelefono.MaxLength = 9;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(116, 23);
            txtTelefono.TabIndex = 2;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(93, 84);
            txtDNI.Margin = new Padding(4, 3, 4, 3);
            txtDNI.MaxLength = 8;
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(116, 23);
            txtDNI.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(93, 44);
            txtNombre.Margin = new Padding(4, 3, 4, 3);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(116, 23);
            txtNombre.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.NavajoWhite;
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(dtpFechaEntrega);
            groupBox2.Controls.Add(txtDireccion);
            groupBox2.Controls.Add(rbDelivery);
            groupBox2.Controls.Add(rbTienda);
            groupBox2.Dock = DockStyle.Right;
            groupBox2.Location = new Point(628, 0);
            groupBox2.Margin = new Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 3, 4, 3);
            groupBox2.Size = new Size(305, 519);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(80, 192);
            label7.Name = "label7";
            label7.Size = new Size(97, 15);
            label7.TabIndex = 4;
            label7.Text = "Fecha de entrega";
            // 
            // dtpFechaEntrega
            // 
            dtpFechaEntrega.CalendarMonthBackground = Color.NavajoWhite;
            dtpFechaEntrega.Format = DateTimePickerFormat.Short;
            dtpFechaEntrega.ImeMode = ImeMode.NoControl;
            dtpFechaEntrega.Location = new Point(64, 216);
            dtpFechaEntrega.MaxDate = new DateTime(2026, 12, 31, 0, 0, 0, 0);
            dtpFechaEntrega.MinDate = new DateTime(2026, 5, 22, 11, 27, 47, 0);
            dtpFechaEntrega.Name = "dtpFechaEntrega";
            dtpFechaEntrega.Size = new Size(134, 23);
            dtpFechaEntrega.TabIndex = 3;
            dtpFechaEntrega.Value = new DateTime(2026, 5, 22, 11, 27, 47, 0);
            // 
            // txtDireccion
            // 
            txtDireccion.Enabled = false;
            txtDireccion.Location = new Point(47, 118);
            txtDireccion.Margin = new Padding(4, 3, 4, 3);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(116, 23);
            txtDireccion.TabIndex = 2;
            // 
            // rbDelivery
            // 
            rbDelivery.AutoSize = true;
            rbDelivery.Location = new Point(47, 81);
            rbDelivery.Margin = new Padding(4, 3, 4, 3);
            rbDelivery.Name = "rbDelivery";
            rbDelivery.Size = new Size(67, 19);
            rbDelivery.TabIndex = 1;
            rbDelivery.TabStop = true;
            rbDelivery.Text = "Delivery";
            rbDelivery.UseVisualStyleBackColor = true;
            rbDelivery.CheckedChanged += rbDelivery_CheckedChanged;
            // 
            // rbTienda
            // 
            rbTienda.AutoSize = true;
            rbTienda.Checked = true;
            rbTienda.Location = new Point(47, 40);
            rbTienda.Margin = new Padding(4, 3, 4, 3);
            rbTienda.Name = "rbTienda";
            rbTienda.Size = new Size(61, 19);
            rbTienda.TabIndex = 0;
            rbTienda.TabStop = true;
            rbTienda.Text = "Tienda";
            rbTienda.UseVisualStyleBackColor = true;
            rbTienda.CheckedChanged += rbTienda_CheckedChanged;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.NavajoWhite;
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(btnQuitarCarrito);
            groupBox3.Controls.Add(btnFinalizar);
            groupBox3.Controls.Add(cmbPago);
            groupBox3.Controls.Add(dgvCarrito);
            groupBox3.Controls.Add(btnAgregarCarrito);
            groupBox3.Controls.Add(numCantidad);
            groupBox3.Controls.Add(cmbProductos);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Location = new Point(294, 0);
            groupBox3.Margin = new Padding(4, 3, 4, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4, 3, 4, 3);
            groupBox3.Size = new Size(639, 519);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(28, 172);
            label6.Name = "label6";
            label6.Size = new Size(46, 15);
            label6.TabIndex = 9;
            label6.Text = "Carrito:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(68, 31);
            label5.Name = "label5";
            label5.Size = new Size(181, 25);
            label5.TabIndex = 8;
            label5.Text = "Escoge un producto";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom;
            label4.AutoSize = true;
            label4.Location = new Point(102, 421);
            label4.Name = "label4";
            label4.Size = new Size(95, 15);
            label4.TabIndex = 7;
            label4.Text = "Metodo de pago";
            // 
            // btnQuitarCarrito
            // 
            btnQuitarCarrito.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnQuitarCarrito.Location = new Point(199, 130);
            btnQuitarCarrito.Name = "btnQuitarCarrito";
            btnQuitarCarrito.Size = new Size(85, 27);
            btnQuitarCarrito.TabIndex = 6;
            btnQuitarCarrito.Text = "Quitar";
            btnQuitarCarrito.UseVisualStyleBackColor = true;
            btnQuitarCarrito.Click += btnQuitarCarrito_Click;
            // 
            // btnFinalizar
            // 
            btnFinalizar.Anchor = AnchorStyles.Bottom;
            btnFinalizar.Location = new Point(97, 480);
            btnFinalizar.Margin = new Padding(4, 3, 4, 3);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(109, 27);
            btnFinalizar.TabIndex = 5;
            btnFinalizar.Text = "Finalizar Compra";
            btnFinalizar.UseVisualStyleBackColor = true;
            btnFinalizar.Click += btnFinalizar_Click;
            // 
            // cmbPago
            // 
            cmbPago.Anchor = AnchorStyles.Bottom;
            cmbPago.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPago.FormattingEnabled = true;
            cmbPago.Location = new Point(82, 439);
            cmbPago.Margin = new Padding(4, 3, 4, 3);
            cmbPago.Name = "cmbPago";
            cmbPago.Size = new Size(140, 23);
            cmbPago.TabIndex = 4;
            // 
            // dgvCarrito
            // 
            dgvCarrito.AllowUserToResizeColumns = false;
            dgvCarrito.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvCarrito.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCarrito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarrito.Location = new Point(28, 192);
            dgvCarrito.Margin = new Padding(4, 3, 4, 3);
            dgvCarrito.Name = "dgvCarrito";
            dgvCarrito.RowHeadersVisible = false;
            dgvCarrito.Size = new Size(264, 209);
            dgvCarrito.TabIndex = 3;
            // 
            // btnAgregarCarrito
            // 
            btnAgregarCarrito.Location = new Point(28, 129);
            btnAgregarCarrito.Margin = new Padding(4, 3, 4, 3);
            btnAgregarCarrito.Name = "btnAgregarCarrito";
            btnAgregarCarrito.Size = new Size(88, 27);
            btnAgregarCarrito.TabIndex = 2;
            btnAgregarCarrito.Text = "Agregar";
            btnAgregarCarrito.UseVisualStyleBackColor = true;
            btnAgregarCarrito.Click += btnAgregarCarrito_Click;
            // 
            // numCantidad
            // 
            numCantidad.Anchor = AnchorStyles.Top;
            numCantidad.Location = new Point(120, 90);
            numCantidad.Margin = new Padding(4, 3, 4, 3);
            numCantidad.Name = "numCantidad";
            numCantidad.Size = new Size(77, 23);
            numCantidad.TabIndex = 1;
            // 
            // cmbProductos
            // 
            cmbProductos.Anchor = AnchorStyles.Top;
            cmbProductos.FormattingEnabled = true;
            cmbProductos.Location = new Point(68, 61);
            cmbProductos.Margin = new Padding(4, 3, 4, 3);
            cmbProductos.Name = "cmbProductos";
            cmbProductos.Size = new Size(181, 23);
            cmbProductos.TabIndex = 0;
            // 
            // FormVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormVenta";
            Text = "Registrar venta";
            WindowState = FormWindowState.Maximized;
            Load += FormVenta_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCantidad).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.RadioButton rbDelivery;
        private System.Windows.Forms.RadioButton rbTienda;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvCarrito;
        private System.Windows.Forms.Button btnAgregarCarrito;
        private System.Windows.Forms.NumericUpDown numCantidad;
        private System.Windows.Forms.ComboBox cmbProductos;
        private System.Windows.Forms.ComboBox cmbPago;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DateTimePicker dtpFechaEntrega;
        private Button btnQuitarCarrito;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label7;
        private TextBox txtNota;
        private Label label8;
    }
}
namespace Finalv67
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            btnNuevoPedido = new Button();
            btnSalir = new Button();
            btnGestionStock = new Button();
            btnListaPedidos = new Button();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnNuevoPedido
            // 
            btnNuevoPedido.BackColor = Color.NavajoWhite;
            btnNuevoPedido.FlatStyle = FlatStyle.Flat;
            btnNuevoPedido.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNuevoPedido.Location = new Point(104, 90);
            btnNuevoPedido.Margin = new Padding(4, 3, 4, 3);
            btnNuevoPedido.Name = "btnNuevoPedido";
            btnNuevoPedido.Size = new Size(201, 51);
            btnNuevoPedido.TabIndex = 0;
            btnNuevoPedido.Text = "\U0001f6d2 Registrar Venta";
            btnNuevoPedido.UseVisualStyleBackColor = false;
            btnNuevoPedido.Click += btnNuevoPedido_Click;
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnSalir.BackColor = Color.NavajoWhite;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(104, 432);
            btnSalir.Margin = new Padding(4, 3, 4, 3);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(201, 51);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "❌ Salir del Sistema";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnGestionStock
            // 
            btnGestionStock.BackColor = Color.NavajoWhite;
            btnGestionStock.FlatStyle = FlatStyle.Flat;
            btnGestionStock.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGestionStock.Location = new Point(104, 234);
            btnGestionStock.Margin = new Padding(4, 3, 4, 3);
            btnGestionStock.Name = "btnGestionStock";
            btnGestionStock.Size = new Size(201, 51);
            btnGestionStock.TabIndex = 3;
            btnGestionStock.Text = "🍰 Inventario / Stock";
            btnGestionStock.UseVisualStyleBackColor = false;
            btnGestionStock.Click += btnGestionStock_Click;
            // 
            // btnListaPedidos
            // 
            btnListaPedidos.BackColor = Color.NavajoWhite;
            btnListaPedidos.FlatStyle = FlatStyle.Flat;
            btnListaPedidos.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnListaPedidos.Location = new Point(104, 160);
            btnListaPedidos.Margin = new Padding(4, 3, 4, 3);
            btnListaPedidos.Name = "btnListaPedidos";
            btnListaPedidos.Size = new Size(201, 51);
            btnListaPedidos.TabIndex = 4;
            btnListaPedidos.Text = "📋 Ver Pedidos";
            btnListaPedidos.UseVisualStyleBackColor = false;
            btnListaPedidos.Click += btnListaPedidos_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SaddleBrown;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnNuevoPedido);
            panel1.Controls.Add(btnSalir);
            panel1.Controls.Add(btnGestionStock);
            panel1.Controls.Add(btnListaPedidos);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(477, 519);
            panel1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.NavajoWhite;
            label1.Location = new Point(70, 27);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(313, 24);
            label1.TabIndex = 5;
            label1.Text = "SISTEMA PASTELERÍA D'LOLA";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(477, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(456, 519);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormMenu";
            Text = "FormMenu";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNuevoPedido;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGestionStock;
        private System.Windows.Forms.Button btnListaPedidos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private PictureBox pictureBox1;
    }
}
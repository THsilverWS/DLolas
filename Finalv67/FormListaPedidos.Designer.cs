namespace Finalv67
{
    partial class FormListaPedidos
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
            dgvPedidos = new DataGridView();
            groupBox1 = new GroupBox();
            btnEliminar = new Button();
            btnCancelar = new Button();
            btnEntregado = new Button();
            txtBuscarDNI = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).BeginInit();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvPedidos
            // 
            dgvPedidos.AllowUserToAddRows = false;
            dgvPedidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPedidos.Dock = DockStyle.Fill;
            dgvPedidos.Location = new Point(289, 0);
            dgvPedidos.Margin = new Padding(4, 3, 4, 3);
            dgvPedidos.Name = "dgvPedidos";
            dgvPedidos.ReadOnly = true;
            dgvPedidos.RowHeadersVisible = false;
            dgvPedidos.Size = new Size(644, 519);
            dgvPedidos.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnEliminar);
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(btnEntregado);
            groupBox1.Location = new Point(14, 25);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(258, 157);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Acciones";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(28, 104);
            btnEliminar.Margin = new Padding(4, 3, 4, 3);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(198, 27);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar Registro";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(28, 70);
            btnCancelar.Margin = new Padding(4, 3, 4, 3);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(198, 27);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar Pedido";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnEntregado
            // 
            btnEntregado.Location = new Point(28, 37);
            btnEntregado.Margin = new Padding(4, 3, 4, 3);
            btnEntregado.Name = "btnEntregado";
            btnEntregado.Size = new Size(198, 27);
            btnEntregado.TabIndex = 0;
            btnEntregado.Text = "Marcar como Entregado";
            btnEntregado.UseVisualStyleBackColor = true;
            btnEntregado.Click += btnEntregado_Click;
            // 
            // txtBuscarDNI
            // 
            txtBuscarDNI.Location = new Point(88, 225);
            txtBuscarDNI.Margin = new Padding(4, 3, 4, 3);
            txtBuscarDNI.Name = "txtBuscarDNI";
            txtBuscarDNI.Size = new Size(116, 23);
            txtBuscarDNI.TabIndex = 2;
            txtBuscarDNI.TextChanged += txtBuscarDNI_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(93, 207);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 3;
            label1.Text = "Busqueda por DNI";
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtBuscarDNI);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(289, 519);
            panel1.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(72, 284);
            button1.Name = "button1";
            button1.Size = new Size(152, 44);
            button1.TabIndex = 4;
            button1.Text = "Mas Detalles";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FormListaPedidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(dgvPedidos);
            Controls.Add(panel1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormListaPedidos";
            Text = "FormListaPedidos";
            WindowState = FormWindowState.Maximized;
            Load += FormListaPedidos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).EndInit();
            groupBox1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEntregado;
        private System.Windows.Forms.TextBox txtBuscarDNI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private Button button1;
    }
}
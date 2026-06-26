namespace Finalv67
{
    partial class FormListaVentas
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
            panel1 = new Panel();
            btnVerMas = new Button();
            btnActualizar = new Button();
            dgvPedidos = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnVerMas);
            panel1.Controls.Add(btnActualizar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(923, 108);
            panel1.TabIndex = 0;
            // 
            // btnVerMas
            // 
            btnVerMas.Anchor = AnchorStyles.Right;
            btnVerMas.Location = new Point(706, 44);
            btnVerMas.Name = "btnVerMas";
            btnVerMas.Size = new Size(183, 30);
            btnVerMas.TabIndex = 3;
            btnVerMas.Text = "Ver mas a detalle";
            btnVerMas.UseVisualStyleBackColor = true;
            btnVerMas.Click += btnVerMas_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Anchor = AnchorStyles.Left;
            btnActualizar.Location = new Point(25, 44);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(183, 30);
            btnActualizar.TabIndex = 2;
            btnActualizar.Text = "Actualizar pedidos";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // dgvPedidos
            // 
            dgvPedidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPedidos.Dock = DockStyle.Fill;
            dgvPedidos.Location = new Point(0, 108);
            dgvPedidos.Name = "dgvPedidos";
            dgvPedidos.ReadOnly = true;
            dgvPedidos.RowHeadersVisible = false;
            dgvPedidos.Size = new Size(923, 536);
            dgvPedidos.TabIndex = 1;
            // 
            // FormListaVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(923, 644);
            Controls.Add(dgvPedidos);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormListaVentas";
            Text = "FormListaVentas";
            Load += FormListaVentas_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dgvPedidos;
        private Button btnActualizar;
        private Button btnVerMas;
    }
}
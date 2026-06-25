namespace Finalv67
{
    partial class FormDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDashboard));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            lblTotal = new Label();
            panel2 = new Panel();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            lblPendientes = new Label();
            panel3 = new Panel();
            label3 = new Label();
            pictureBox3 = new PictureBox();
            lblEntregados = new Label();
            lblCancelados = new Label();
            panel4 = new Panel();
            label5 = new Label();
            panel5 = new Panel();
            label4 = new Label();
            pictureBox4 = new PictureBox();
            dgvStockBajo = new DataGridView();
            label6 = new Label();
            label7 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvStockBajo).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblTotal);
            panel1.Location = new Point(3, 74);
            panel1.Name = "panel1";
            panel1.Size = new Size(221, 113);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(98, 13);
            label1.Name = "label1";
            label1.Size = new Size(107, 17);
            label1.TabIndex = 2;
            label1.Text = "Pedidos Totales";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(15, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(70, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(98, 44);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(29, 32);
            lblTotal.TabIndex = 0;
            lblTotal.Text = "0";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(lblPendientes);
            panel2.Location = new Point(230, 74);
            panel2.Name = "panel2";
            panel2.Size = new Size(219, 113);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(99, 13);
            label2.Name = "label2";
            label2.Size = new Size(78, 17);
            label2.TabIndex = 4;
            label2.Text = "Pendientes";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(16, 25);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(70, 70);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // lblPendientes
            // 
            lblPendientes.AutoSize = true;
            lblPendientes.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPendientes.Location = new Point(99, 44);
            lblPendientes.Name = "lblPendientes";
            lblPendientes.Size = new Size(29, 32);
            lblPendientes.TabIndex = 0;
            lblPendientes.Text = "0";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.None;
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label3);
            panel3.Controls.Add(pictureBox3);
            panel3.Controls.Add(lblEntregados);
            panel3.Location = new Point(455, 74);
            panel3.Name = "panel3";
            panel3.Size = new Size(224, 113);
            panel3.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(102, 15);
            label3.Name = "label3";
            label3.Size = new Size(81, 17);
            label3.TabIndex = 6;
            label3.Text = "Entregados";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(19, 27);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(70, 70);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // lblEntregados
            // 
            lblEntregados.AutoSize = true;
            lblEntregados.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEntregados.Location = new Point(102, 44);
            lblEntregados.Name = "lblEntregados";
            lblEntregados.Size = new Size(29, 32);
            lblEntregados.TabIndex = 0;
            lblEntregados.Text = "0";
            // 
            // lblCancelados
            // 
            lblCancelados.AutoSize = true;
            lblCancelados.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCancelados.Location = new Point(102, 44);
            lblCancelados.Name = "lblCancelados";
            lblCancelados.Size = new Size(29, 32);
            lblCancelados.TabIndex = 3;
            lblCancelados.Text = "0";
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel4.BackColor = SystemColors.Control;
            panel4.Controls.Add(label5);
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(panel1);
            panel4.Controls.Add(panel2);
            panel4.Controls.Add(panel3);
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(923, 260);
            panel4.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(329, 26);
            label5.Name = "label5";
            label5.Size = new Size(274, 32);
            label5.TabIndex = 4;
            label5.Text = "Resumen de Ventas";
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.None;
            panel5.BackColor = Color.White;
            panel5.Controls.Add(label4);
            panel5.Controls.Add(pictureBox4);
            panel5.Controls.Add(lblCancelados);
            panel5.Location = new Point(685, 74);
            panel5.Name = "panel5";
            panel5.Size = new Size(229, 113);
            panel5.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Gray;
            label4.Location = new Point(102, 15);
            label4.Name = "label4";
            label4.Size = new Size(87, 17);
            label4.TabIndex = 6;
            label4.Text = "Cancelados";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(19, 27);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(70, 70);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 5;
            pictureBox4.TabStop = false;
            // 
            // dgvStockBajo
            // 
            dgvStockBajo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvStockBajo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStockBajo.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvStockBajo.BackgroundColor = SystemColors.Control;
            dgvStockBajo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStockBajo.Location = new Point(18, 337);
            dgvStockBajo.Name = "dgvStockBajo";
            dgvStockBajo.RowHeadersVisible = false;
            dgvStockBajo.Size = new Size(880, 277);
            dgvStockBajo.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(18, 272);
            label6.Name = "label6";
            label6.Size = new Size(178, 32);
            label6.TabIndex = 5;
            label6.Text = "Stock Crítico";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(25, 304);
            label7.Name = "label7";
            label7.Size = new Size(337, 17);
            label7.TabIndex = 6;
            label7.Text = "Productos con menos de 5 unidades en inventario.";
            // 
            // FormDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(923, 644);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(dgvStockBajo);
            Controls.Add(panel4);
            Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormDashboard";
            Text = "FormDashboard";
            Load += FormDashboard_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvStockBajo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label lblTotal;
        private Label lblPendientes;
        private Label lblEntregados;
        private Label lblCancelados;
        private Panel panel4;
        private Panel panel5;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox2;
        private Label label3;
        private PictureBox pictureBox3;
        private Label label4;
        private PictureBox pictureBox4;
        private DataGridView dgvStockBajo;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}
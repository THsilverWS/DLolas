namespace Finalv67
{
    partial class FormPerfil
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
            panel2 = new Panel();
            button1 = new Button();
            txtUrlFoto = new TextBox();
            txtTelefono = new TextBox();
            txtNombre = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pbFotoPerfil = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbFotoPerfil).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pbFotoPerfil);
            panel1.Location = new Point(242, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(431, 602);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(button1);
            panel2.Controls.Add(txtUrlFoto);
            panel2.Controls.Add(txtTelefono);
            panel2.Controls.Add(txtNombre);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(16, 232);
            panel2.Name = "panel2";
            panel2.Size = new Size(394, 265);
            panel2.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(41, 235);
            button1.Name = "button1";
            button1.Size = new Size(322, 23);
            button1.TabIndex = 7;
            button1.Text = "Guardar Cambios";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtUrlFoto
            // 
            txtUrlFoto.Location = new Point(44, 183);
            txtUrlFoto.Name = "txtUrlFoto";
            txtUrlFoto.Size = new Size(196, 23);
            txtUrlFoto.TabIndex = 6;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(44, 113);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(196, 23);
            txtTelefono.TabIndex = 5;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(44, 43);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(196, 23);
            txtNombre.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(41, 163);
            label3.Name = "label3";
            label3.Size = new Size(140, 15);
            label3.TabIndex = 3;
            label3.Text = "URL DE FOTO DE PERFIL";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(41, 93);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 2;
            label2.Text = "TELEFONO";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(41, 23);
            label1.Name = "label1";
            label1.Size = new Size(133, 15);
            label1.TabIndex = 1;
            label1.Text = "NOMBRE DE USUARIO";
            // 
            // pbFotoPerfil
            // 
            pbFotoPerfil.Location = new Point(141, 61);
            pbFotoPerfil.Name = "pbFotoPerfil";
            pbFotoPerfil.Size = new Size(130, 130);
            pbFotoPerfil.SizeMode = PictureBoxSizeMode.StretchImage;
            pbFotoPerfil.TabIndex = 0;
            pbFotoPerfil.TabStop = false;
            // 
            // FormPerfil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Moccasin;
            ClientSize = new Size(907, 605);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormPerfil";
            Text = "Login";
            Load += FormPerfil_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbFotoPerfil).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pbFotoPerfil;
        private Panel panel2;
        private TextBox txtUrlFoto;
        private TextBox txtTelefono;
        private TextBox txtNombre;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1;
    }
}
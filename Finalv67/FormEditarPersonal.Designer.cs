namespace Finalv67
{
    partial class FormEditarPersonal
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
            txtNombre = new TextBox();
            txtCargo = new TextBox();
            txtRol = new TextBox();
            txtTelefono = new TextBox();
            btnGuardar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(114, 155);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(114, 27);
            txtNombre.TabIndex = 0;
            // 
            // txtCargo
            // 
            txtCargo.Location = new Point(114, 215);
            txtCargo.Margin = new Padding(3, 4, 3, 4);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(114, 27);
            txtCargo.TabIndex = 1;
            // 
            // txtRol
            // 
            txtRol.Location = new Point(114, 275);
            txtRol.Margin = new Padding(3, 4, 3, 4);
            txtRol.Name = "txtRol";
            txtRol.Size = new Size(114, 27);
            txtRol.TabIndex = 2;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(114, 347);
            txtTelefono.Margin = new Padding(3, 4, 3, 4);
            txtTelefono.MaxLength = 9;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(114, 27);
            txtTelefono.TabIndex = 3;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(72, 401);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(86, 31);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 161);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 6;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 215);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 7;
            label2.Text = "Cargo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 279);
            label3.Name = "label3";
            label3.Size = new Size(31, 20);
            label3.TabIndex = 8;
            label3.Text = "Rol";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 351);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 9;
            label4.Text = "Telefono";
            // 
            // FormEditarPersonal
            // 
            AcceptButton = btnGuardar;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Moccasin;
            ClientSize = new Size(275, 600);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnGuardar);
            Controls.Add(txtTelefono);
            Controls.Add(txtRol);
            Controls.Add(txtCargo);
            Controls.Add(txtNombre);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormEditarPersonal";
            Text = "FormEditarPersonal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtCargo;
        private TextBox txtRol;
        private TextBox txtTelefono;
        private Button btnGuardar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
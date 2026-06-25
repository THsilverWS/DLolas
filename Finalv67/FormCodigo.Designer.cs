namespace Finalv67
{
    partial class FormCodigo
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
            lblCodigoActual = new Label();
            label2 = new Label();
            btnGuardar = new Button();
            txtCodigoNuevo = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // lblCodigoActual
            // 
            lblCodigoActual.AutoSize = true;
            lblCodigoActual.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCodigoActual.Location = new Point(47, 75);
            lblCodigoActual.Name = "lblCodigoActual";
            lblCodigoActual.Size = new Size(125, 37);
            lblCodigoActual.TabIndex = 0;
            lblCodigoActual.Text = "XXXXXX";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(47, 31);
            label2.Name = "label2";
            label2.Size = new Size(131, 25);
            label2.TabIndex = 1;
            label2.Text = "Codigo Actual";
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Bottom;
            btnGuardar.Location = new Point(72, 210);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click_1;
            // 
            // txtCodigoNuevo
            // 
            txtCodigoNuevo.Location = new Point(58, 161);
            txtCodigoNuevo.MaxLength = 6;
            txtCodigoNuevo.Name = "txtCodigoNuevo";
            txtCodigoNuevo.Size = new Size(114, 23);
            txtCodigoNuevo.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(25, 133);
            label3.Name = "label3";
            label3.Size = new Size(172, 20);
            label3.TabIndex = 4;
            label3.Text = "Ingrese un nuevo codigo";
            // 
            // FormCodigo
            // 
            AcceptButton = btnGuardar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(242, 255);
            Controls.Add(label3);
            Controls.Add(txtCodigoNuevo);
            Controls.Add(btnGuardar);
            Controls.Add(label2);
            Controls.Add(lblCodigoActual);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FormCodigo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Codigo";
            Load += FormCodigo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCodigoActual;
        private Label label2;
        private Button btnGuardar;
        private TextBox txtCodigoNuevo;
        private Label label3;
    }
}
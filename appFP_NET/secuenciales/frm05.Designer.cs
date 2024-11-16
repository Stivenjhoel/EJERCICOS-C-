namespace ConversionApp
{
    partial class frm05
    {
        private System.ComponentModel.IContainer components = null;

        // Declaración de controles
        private TextBox txtGigabytes;
        private Button btnConvertir;
        private Label lblGigabytes;
        private Label lblMegabytes;
        private Label lblKilobytes;
        private Label lblBytes;

        /// <summary>
        /// Limpiar los recursos en uso.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// Método para inicializar los componentes del formulario.
        /// </summary>
        private void InitializeComponent()
        {
            txtGigabytes = new TextBox();
            btnConvertir = new Button();
            lblGigabytes = new Label();
            lblMegabytes = new Label();
            lblKilobytes = new Label();
            lblBytes = new Label();
            SuspendLayout();
            // 
            // txtGigabytes
            // 
            txtGigabytes.Location = new Point(150, 30);
            txtGigabytes.Name = "txtGigabytes";
            txtGigabytes.Size = new Size(100, 23);
            txtGigabytes.TabIndex = 0;
            // 
            // btnConvertir
            // 
            btnConvertir.Location = new Point(150, 59);
            btnConvertir.Name = "btnConvertir";
            btnConvertir.Size = new Size(100, 30);
            btnConvertir.TabIndex = 1;
            btnConvertir.Text = "Convertir";
            btnConvertir.UseVisualStyleBackColor = true;
            btnConvertir.Click += btnConvertir_Click;
            // 
            // lblGigabytes
            // 
            lblGigabytes.AutoSize = true;
            lblGigabytes.Location = new Point(30, 30);
            lblGigabytes.Name = "lblGigabytes";
            lblGigabytes.Size = new Size(100, 15);
            lblGigabytes.TabIndex = 2;
            lblGigabytes.Text = "Capacidad en GB:";
            // 
            // lblMegabytes
            // 
            lblMegabytes.AutoSize = true;
            lblMegabytes.Location = new Point(30, 100);
            lblMegabytes.Name = "lblMegabytes";
            lblMegabytes.Size = new Size(133, 15);
            lblMegabytes.TabIndex = 3;
            lblMegabytes.Text = "Capacidad en MB: 0 MB";
            // 
            // lblKilobytes
            // 
            lblKilobytes.AutoSize = true;
            lblKilobytes.Location = new Point(30, 130);
            lblKilobytes.Name = "lblKilobytes";
            lblKilobytes.Size = new Size(125, 15);
            lblKilobytes.TabIndex = 4;
            lblKilobytes.Text = "Capacidad en KB: 0 KB";
            // 
            // lblBytes
            // 
            lblBytes.AutoSize = true;
            lblBytes.Location = new Point(30, 160);
            lblBytes.Name = "lblBytes";
            lblBytes.Size = new Size(153, 15);
            lblBytes.TabIndex = 5;
            lblBytes.Text = "Capacidad en Bytes: 0 Bytes";
            // 
            // frm05
            // 
            ClientSize = new Size(274, 211);
            Controls.Add(lblBytes);
            Controls.Add(lblKilobytes);
            Controls.Add(lblMegabytes);
            Controls.Add(lblGigabytes);
            Controls.Add(btnConvertir);
            Controls.Add(txtGigabytes);
            Name = "frm05";
            Text = "Conversión de Disco Duro";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}

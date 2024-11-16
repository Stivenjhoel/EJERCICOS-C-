namespace ConversionApp
{
    partial class frm06
    {
        private System.ComponentModel.IContainer components = null;

        // Declaración de controles
        private TextBox txtRadio;
        private TextBox txtAltura;
        private Button btnCalcular;
        private Label lblRadio;
        private Label lblAltura;
        private Label lblArea;
        private Label lblVolumen;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
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
            this.txtRadio = new TextBox();
            this.txtAltura = new TextBox();
            this.btnCalcular = new Button();
            this.lblRadio = new Label();
            this.lblAltura = new Label();
            this.lblArea = new Label();
            this.lblVolumen = new Label();
            this.SuspendLayout();

            // 
            // txtRadio
            // 
            this.txtRadio.Location = new System.Drawing.Point(150, 30);
            this.txtRadio.Name = "txtRadio";
            this.txtRadio.Size = new System.Drawing.Size(100, 20);
            this.txtRadio.TabIndex = 0;

            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(150, 60);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(100, 20);
            this.txtAltura.TabIndex = 1;

            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(150, 90);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 30);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new EventHandler(this.btnCalcular_Click);

            // 
            // lblRadio
            // 
            this.lblRadio.AutoSize = true;
            this.lblRadio.Location = new System.Drawing.Point(30, 30);
            this.lblRadio.Name = "lblRadio";
            this.lblRadio.Size = new System.Drawing.Size(93, 13);
            this.lblRadio.TabIndex = 3;
            this.lblRadio.Text = "Ingrese el Radio:";

            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(30, 60);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(96, 13);
            this.lblAltura.TabIndex = 4;
            this.lblAltura.Text = "Ingrese la Altura:";

            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(30, 140);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(130, 13);
            this.lblArea.TabIndex = 5;
            this.lblArea.Text = "Área Total: 0.00 unidades²";

            // 
            // lblVolumen
            // 
            this.lblVolumen.AutoSize = true;
            this.lblVolumen.Location = new System.Drawing.Point(30, 170);
            this.lblVolumen.Name = "lblVolumen";
            this.lblVolumen.Size = new System.Drawing.Size(136, 13);
            this.lblVolumen.TabIndex = 6;
            this.lblVolumen.Text = "Volumen: 0.00 unidades³";

            // 
            // frm06
            // 
            this.ClientSize = new System.Drawing.Size(284, 211);
            this.Controls.Add(this.lblVolumen);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.lblRadio);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.txtRadio);
            this.Name = "frm06";
            this.Text = "Cálculo de Cilindro";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

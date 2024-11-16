namespace ConversionApp
{
    partial class frm08
    {
        private System.ComponentModel.IContainer components = null;

        // Declaración de controles
        private TextBox txtRadio;
        private TextBox txtAltura;
        private Button btnCalcular;
        private Label lblRadio;
        private Label lblAltura;
        private Label lblAreaBase;
        private Label lblAreaLateral;
        private Label lblAreaTotal;

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
            this.lblAreaBase = new Label();
            this.lblAreaLateral = new Label();
            this.lblAreaTotal = new Label();
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
            // lblAreaBase
            // 
            this.lblAreaBase.AutoSize = true;
            this.lblAreaBase.Location = new System.Drawing.Point(30, 140);
            this.lblAreaBase.Name = "lblAreaBase";
            this.lblAreaBase.Size = new System.Drawing.Size(126, 13);
            this.lblAreaBase.TabIndex = 5;
            this.lblAreaBase.Text = "Área Base: 0.00 unidades²";

            // 
            // lblAreaLateral
            // 
            this.lblAreaLateral.AutoSize = true;
            this.lblAreaLateral.Location = new System.Drawing.Point(30, 170);
            this.lblAreaLateral.Name = "lblAreaLateral";
            this.lblAreaLateral.Size = new System.Drawing.Size(132, 13);
            this.lblAreaLateral.TabIndex = 6;
            this.lblAreaLateral.Text = "Área Lateral: 0.00 unidades²";

            // 
            // lblAreaTotal
            // 
            this.lblAreaTotal.AutoSize = true;
            this.lblAreaTotal.Location = new System.Drawing.Point(30, 200);
            this.lblAreaTotal.Name = "lblAreaTotal";
            this.lblAreaTotal.Size = new System.Drawing.Size(128, 13);
            this.lblAreaTotal.TabIndex = 7;
            this.lblAreaTotal.Text = "Área Total: 0.00 unidades²";

            // 
            // frm08
            // 
            this.ClientSize = new System.Drawing.Size(284, 251);
            this.Controls.Add(this.lblAreaTotal);
            this.Controls.Add(this.lblAreaLateral);
            this.Controls.Add(this.lblAreaBase);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.lblRadio);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.txtRadio);
            this.Name = "frm08";
            this.Text = "Cálculo de Cilindro";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

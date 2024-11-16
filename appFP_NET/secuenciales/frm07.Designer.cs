namespace ConversionApp
{
    partial class frm07
    {
        private System.ComponentModel.IContainer components = null;

        // Declaración de controles
        private TextBox txtBase;
        private TextBox txtAltura;
        private Button btnCalcular;
        private Label lblBase;
        private Label lblAltura;
        private Label lblArea;
        private Label lblPerimetro;

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
            this.txtBase = new TextBox();
            this.txtAltura = new TextBox();
            this.btnCalcular = new Button();
            this.lblBase = new Label();
            this.lblAltura = new Label();
            this.lblArea = new Label();
            this.lblPerimetro = new Label();
            this.SuspendLayout();

            // 
            // txtBase
            // 
            this.txtBase.Location = new System.Drawing.Point(150, 30);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(100, 20);
            this.txtBase.TabIndex = 0;

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
            // lblBase
            // 
            this.lblBase.AutoSize = true;
            this.lblBase.Location = new System.Drawing.Point(30, 30);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(114, 13);
            this.lblBase.TabIndex = 3;
            this.lblBase.Text = "Ingrese la Base (b):";

            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(30, 60);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(118, 13);
            this.lblAltura.TabIndex = 4;
            this.lblAltura.Text = "Ingrese la Altura (h):";

            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(30, 140);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(96, 13);
            this.lblArea.TabIndex = 5;
            this.lblArea.Text = "Área: 0.00 unidades²";

            // 
            // lblPerimetro
            // 
            this.lblPerimetro.AutoSize = true;
            this.lblPerimetro.Location = new System.Drawing.Point(30, 170);
            this.lblPerimetro.Name = "lblPerimetro";
            this.lblPerimetro.Size = new System.Drawing.Size(119, 13);
            this.lblPerimetro.TabIndex = 6;
            this.lblPerimetro.Text = "Perímetro: 0.00 unidades";

            // 
            // frm07
            // 
            this.ClientSize = new System.Drawing.Size(284, 211);
            this.Controls.Add(this.lblPerimetro);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.lblBase);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.txtBase);
            this.Name = "frm07";
            this.Text = "Cálculo de Rectángulo";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

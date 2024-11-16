namespace ConversionApp
{
    partial class frm03
    {
        private System.ComponentModel.IContainer components = null;

        // Los controles declarados aquí
        private TextBox txtTramo1Km;
        private TextBox txtTramo2Pies;
        private TextBox txtTramo3Millas;
        private Button btnCalcular;
        private Label lblResultadoMetros;
        private Label lblResultadoYardas;
        private Label lblTramo1;
        private Label lblTramo2;
        private Label lblTramo3;

        /// <summary>
        /// Requerido por el diseñador de Windows Forms.
        /// </summary>
        private void InitializeComponent()
        {
            txtTramo1Km = new TextBox();
            txtTramo2Pies = new TextBox();
            txtTramo3Millas = new TextBox();
            btnCalcular = new Button();
            lblResultadoMetros = new Label();
            lblResultadoYardas = new Label();
            lblTramo1 = new Label();
            lblTramo2 = new Label();
            lblTramo3 = new Label();
            SuspendLayout();
            // 
            // txtTramo1Km
            // 
            txtTramo1Km.Location = new Point(212, 27);
            txtTramo1Km.Name = "txtTramo1Km";
            txtTramo1Km.Size = new Size(100, 23);
            txtTramo1Km.TabIndex = 0;
            // 
            // txtTramo2Pies
            // 
            txtTramo2Pies.Location = new Point(212, 60);
            txtTramo2Pies.Name = "txtTramo2Pies";
            txtTramo2Pies.Size = new Size(100, 23);
            txtTramo2Pies.TabIndex = 1;
            // 
            // txtTramo3Millas
            // 
            txtTramo3Millas.Location = new Point(212, 89);
            txtTramo3Millas.Name = "txtTramo3Millas";
            txtTramo3Millas.Size = new Size(100, 23);
            txtTramo3Millas.TabIndex = 2;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(212, 118);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(100, 30);
            btnCalcular.TabIndex = 3;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblResultadoMetros
            // 
            lblResultadoMetros.AutoSize = true;
            lblResultadoMetros.Location = new Point(77, 155);
            lblResultadoMetros.Name = "lblResultadoMetros";
            lblResultadoMetros.Size = new Size(114, 15);
            lblResultadoMetros.TabIndex = 4;
            lblResultadoMetros.Text = "Total en metros: 0 m";
            // 
            // lblResultadoYardas
            // 
            lblResultadoYardas.AutoSize = true;
            lblResultadoYardas.Location = new Point(77, 175);
            lblResultadoYardas.Name = "lblResultadoYardas";
            lblResultadoYardas.Size = new Size(113, 15);
            lblResultadoYardas.TabIndex = 5;
            lblResultadoYardas.Text = "Total en yardas: 0 yd";
            // 
            // lblTramo1
            // 
            lblTramo1.AutoSize = true;
            lblTramo1.Location = new Point(12, 30);
            lblTramo1.Name = "lblTramo1";
            lblTramo1.Size = new Size(178, 15);
            lblTramo1.TabIndex = 6;
            lblTramo1.Text = "Longitud del primer tramo (km):";
            // 
            // lblTramo2
            // 
            lblTramo2.AutoSize = true;
            lblTramo2.Location = new Point(12, 63);
            lblTramo2.Name = "lblTramo2";
            lblTramo2.Size = new Size(193, 15);
            lblTramo2.TabIndex = 7;
            lblTramo2.Text = "Longitud del segundo tramo (pies):";
            // 
            // lblTramo3
            // 
            lblTramo3.AutoSize = true;
            lblTramo3.Location = new Point(12, 90);
            lblTramo3.Name = "lblTramo3";
            lblTramo3.Size = new Size(187, 15);
            lblTramo3.TabIndex = 8;
            lblTramo3.Text = "Longitud del tercer tramo (millas):";
            // 
            // frm03
            // 
            ClientSize = new Size(411, 211);
            Controls.Add(lblTramo3);
            Controls.Add(lblTramo2);
            Controls.Add(lblTramo1);
            Controls.Add(lblResultadoYardas);
            Controls.Add(lblResultadoMetros);
            Controls.Add(btnCalcular);
            Controls.Add(txtTramo3Millas);
            Controls.Add(txtTramo2Pies);
            Controls.Add(txtTramo1Km);
            Name = "frm03";
            Text = "Conversión de Distancias";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}

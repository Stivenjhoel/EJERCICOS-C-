namespace ConversionApp
{
    partial class frm15
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtJuan;
        private TextBox txtRosa;
        private TextBox txtDaniel;
        private Button btnCalcular;
        private Label lblJuan;
        private Label lblRosa;
        private Label lblDaniel;
        private Label lblResultado;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtJuan = new TextBox();
            txtRosa = new TextBox();
            txtDaniel = new TextBox();
            btnCalcular = new Button();
            lblJuan = new Label();
            lblRosa = new Label();
            lblDaniel = new Label();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // txtJuan
            // 
            txtJuan.Location = new Point(150, 30);
            txtJuan.Name = "txtJuan";
            txtJuan.Size = new Size(100, 23);
            txtJuan.TabIndex = 0;
            // 
            // txtRosa
            // 
            txtRosa.Location = new Point(150, 70);
            txtRosa.Name = "txtRosa";
            txtRosa.Size = new Size(100, 23);
            txtRosa.TabIndex = 1;
            // 
            // txtDaniel
            // 
            txtDaniel.Location = new Point(150, 110);
            txtDaniel.Name = "txtDaniel";
            txtDaniel.Size = new Size(100, 23);
            txtDaniel.TabIndex = 2;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(150, 150);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 3;
            btnCalcular.Text = "Calcular";
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblJuan
            // 
            lblJuan.Location = new Point(30, 30);
            lblJuan.Name = "lblJuan";
            lblJuan.Size = new Size(100, 23);
            lblJuan.TabIndex = 4;
            lblJuan.Text = "Aporte Juan (USD):";
            // 
            // lblRosa
            // 
            lblRosa.Location = new Point(30, 70);
            lblRosa.Name = "lblRosa";
            lblRosa.Size = new Size(100, 23);
            lblRosa.TabIndex = 5;
            lblRosa.Text = "Aporte Rosa (USD):";
            // 
            // lblDaniel
            // 
            lblDaniel.Location = new Point(30, 110);
            lblDaniel.Name = "lblDaniel";
            lblDaniel.Size = new Size(100, 23);
            lblDaniel.TabIndex = 6;
            lblDaniel.Text = "Aporte Daniel (Soles):";
            // 
            // lblResultado
            // 
            lblResultado.Location = new Point(30, 200);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(300, 80);
            lblResultado.TabIndex = 7;
            // 
            // frm15
            // 
            ClientSize = new Size(281, 192);
            Controls.Add(txtJuan);
            Controls.Add(txtRosa);
            Controls.Add(txtDaniel);
            Controls.Add(btnCalcular);
            Controls.Add(lblJuan);
            Controls.Add(lblRosa);
            Controls.Add(lblDaniel);
            Controls.Add(lblResultado);
            Name = "frm15";
            Text = "Cálculo del Capital y Porcentajes";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}

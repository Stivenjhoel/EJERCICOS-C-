namespace ConversionApp
{
    partial class frm12
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtA;
        private TextBox txtB;
        private TextBox txtC;
        private Button btnCalcular;
        private Label lblA;
        private Label lblB;
        private Label lblC;
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
            txtA = new TextBox();
            txtB = new TextBox();
            txtC = new TextBox();
            btnCalcular = new Button();
            lblA = new Label();
            lblB = new Label();
            lblC = new Label();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // txtA
            // 
            txtA.Location = new Point(75, 30);
            txtA.Name = "txtA";
            txtA.Size = new Size(100, 23);
            txtA.TabIndex = 0;
            // 
            // txtB
            // 
            txtB.Location = new Point(75, 59);
            txtB.Name = "txtB";
            txtB.Size = new Size(100, 23);
            txtB.TabIndex = 1;
            // 
            // txtC
            // 
            txtC.Location = new Point(75, 90);
            txtC.Name = "txtC";
            txtC.Size = new Size(100, 23);
            txtC.TabIndex = 2;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(88, 130);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 3;
            btnCalcular.Text = "Calcular";
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblA
            // 
            lblA.Location = new Point(30, 30);
            lblA.Name = "lblA";
            lblA.Size = new Size(100, 23);
            lblA.TabIndex = 4;
            lblA.Text = "a:";
            // 
            // lblB
            // 
            lblB.Location = new Point(30, 60);
            lblB.Name = "lblB";
            lblB.Size = new Size(100, 23);
            lblB.TabIndex = 5;
            lblB.Text = "b:";
            // 
            // lblC
            // 
            lblC.Location = new Point(30, 90);
            lblC.Name = "lblC";
            lblC.Size = new Size(100, 23);
            lblC.TabIndex = 6;
            lblC.Text = "c:";
            // 
            // lblResultado
            // 
            lblResultado.Location = new Point(30, 180);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(250, 60);
            lblResultado.TabIndex = 7;
            // 
            // frm12
            // 
            ClientSize = new Size(212, 175);
            Controls.Add(txtA);
            Controls.Add(txtB);
            Controls.Add(txtC);
            Controls.Add(btnCalcular);
            Controls.Add(lblA);
            Controls.Add(lblB);
            Controls.Add(lblC);
            Controls.Add(lblResultado);
            Name = "frm12";
            Text = "Ecuación Cuadrática";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}

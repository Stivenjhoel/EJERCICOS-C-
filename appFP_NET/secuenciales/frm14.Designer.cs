namespace ConversionApp
{
    partial class frm14
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtNum1;
        private TextBox txtNum2;
        private TextBox txtNum3;
        private TextBox txtNum4;
        private TextBox txtNum5;
        private Button btnCalcular;
        private Label lblNum1;
        private Label lblNum2;
        private Label lblNum3;
        private Label lblNum4;
        private Label lblNum5;
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
            this.txtNum1 = new TextBox();
            this.txtNum2 = new TextBox();
            this.txtNum3 = new TextBox();
            this.txtNum4 = new TextBox();
            this.txtNum5 = new TextBox();
            this.btnCalcular = new Button();
            this.lblNum1 = new Label();
            this.lblNum2 = new Label();
            this.lblNum3 = new Label();
            this.lblNum4 = new Label();
            this.lblNum5 = new Label();
            this.lblResultado = new Label();
            this.SuspendLayout();

            // txtNum1
            this.txtNum1.Location = new System.Drawing.Point(120, 30);

            // txtNum2
            this.txtNum2.Location = new System.Drawing.Point(120, 60);

            // txtNum3
            this.txtNum3.Location = new System.Drawing.Point(120, 90);

            // txtNum4
            this.txtNum4.Location = new System.Drawing.Point(120, 120);

            // txtNum5
            this.txtNum5.Location = new System.Drawing.Point(120, 150);

            // btnCalcular
            this.btnCalcular.Location = new System.Drawing.Point(120, 190);
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);

            // lblNum1
            this.lblNum1.Location = new System.Drawing.Point(30, 30);
            this.lblNum1.Text = "Número 1:";

            // lblNum2
            this.lblNum2.Location = new System.Drawing.Point(30, 60);
            this.lblNum2.Text = "Número 2:";

            // lblNum3
            this.lblNum3.Location = new System.Drawing.Point(30, 90);
            this.lblNum3.Text = "Número 3:";

            // lblNum4
            this.lblNum4.Location = new System.Drawing.Point(30, 120);
            this.lblNum4.Text = "Número 4:";

            // lblNum5
            this.lblNum5.Location = new System.Drawing.Point(30, 150);
            this.lblNum5.Text = "Número 5:";

            // lblResultado
            this.lblResultado.Location = new System.Drawing.Point(30, 230);
            this.lblResultado.Size = new System.Drawing.Size(250, 30);

            // frm14
            this.ClientSize = new System.Drawing.Size(320, 280);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum3);
            this.Controls.Add(this.txtNum4);
            this.Controls.Add(this.txtNum5);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblNum1);
            this.Controls.Add(this.lblNum2);
            this.Controls.Add(this.lblNum3);
            this.Controls.Add(this.lblNum4);
            this.Controls.Add(this.lblNum5);
            this.Controls.Add(this.lblResultado);
            this.Text = "Promedio de los 3 números mayores";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

namespace ConversionApp
{
    partial class frm13
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtCatetoA;
        private TextBox txtCatetoB;
        private Button btnCalcular;
        private Label lblCatetoA;
        private Label lblCatetoB;
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
            this.txtCatetoA = new TextBox();
            this.txtCatetoB = new TextBox();
            this.btnCalcular = new Button();
            this.lblCatetoA = new Label();
            this.lblCatetoB = new Label();
            this.lblResultado = new Label();
            this.SuspendLayout();

            // txtCatetoA
            this.txtCatetoA.Location = new System.Drawing.Point(120, 30);

            // txtCatetoB
            this.txtCatetoB.Location = new System.Drawing.Point(120, 70);

            // btnCalcular
            this.btnCalcular.Location = new System.Drawing.Point(120, 110);
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);

            // lblCatetoA
            this.lblCatetoA.Location = new System.Drawing.Point(30, 30);
            this.lblCatetoA.Text = "Cateto A:";

            // lblCatetoB
            this.lblCatetoB.Location = new System.Drawing.Point(30, 70);
            this.lblCatetoB.Text = "Cateto B:";

            // lblResultado
            this.lblResultado.Location = new System.Drawing.Point(30, 150);
            this.lblResultado.Size = new System.Drawing.Size(200, 30);

            // frm13
            this.ClientSize = new System.Drawing.Size(300, 220);
            this.Controls.Add(this.txtCatetoA);
            this.Controls.Add(this.txtCatetoB);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblCatetoA);
            this.Controls.Add(this.lblCatetoB);
            this.Controls.Add(this.lblResultado);
            this.Text = "Cálculo de Hipotenusa";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

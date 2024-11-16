namespace OrdenNumeros
{
    partial class frm20
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.Button btnVerificarOrden;
        private System.Windows.Forms.Label lblResultado;

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
            this.lblA = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.lblB = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
            this.lblC = new System.Windows.Forms.Label();
            this.txtC = new System.Windows.Forms.TextBox();
            this.btnVerificarOrden = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(12, 9);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(23, 17);
            this.lblA.TabIndex = 0;
            this.lblA.Text = "A:";

            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(41, 6);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 22);
            this.txtA.TabIndex = 1;

            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(12, 37);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(23, 17);
            this.lblB.TabIndex = 2;
            this.lblB.Text = "B:";

            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(41, 34);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 22);
            this.txtB.TabIndex = 3;

            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Location = new System.Drawing.Point(12, 65);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(23, 17);
            this.lblC.TabIndex = 4;
            this.lblC.Text = "C:";

            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(41, 62);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(100, 22);
            this.txtC.TabIndex = 5;

            // 
            // btnVerificarOrden
            // 
            this.btnVerificarOrden.Location = new System.Drawing.Point(12, 90);
            this.btnVerificarOrden.Name = "btnVerificarOrden";
            this.btnVerificarOrden.Size = new System.Drawing.Size(129, 30);
            this.btnVerificarOrden.TabIndex = 6;
            this.btnVerificarOrden.Text = "Verificar Orden";
            this.btnVerificarOrden.UseVisualStyleBackColor = true;
            this.btnVerificarOrden.Click += new System.EventHandler(this.btnVerificarOrden_Click);

            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(12, 127);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(78, 17);
            this.lblResultado.TabIndex = 7;
            this.lblResultado.Text = "Resultado:";

            // 
            // frm20
            // 
            this.ClientSize = new System.Drawing.Size(157, 153);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnVerificarOrden);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.lblA);
            this.Name = "frm20";
            this.Text = "Orden de Números";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

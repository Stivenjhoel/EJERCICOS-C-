namespace PromedioFinal
{
    partial class frm04
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblNota1;
        private System.Windows.Forms.TextBox txtNota1;
        private System.Windows.Forms.Label lblNota2;
        private System.Windows.Forms.TextBox txtNota2;
        private System.Windows.Forms.Label lblNota3;
        private System.Windows.Forms.TextBox txtNota3;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblPromedio;

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
            this.lblNota1 = new System.Windows.Forms.Label();
            this.txtNota1 = new System.Windows.Forms.TextBox();
            this.lblNota2 = new System.Windows.Forms.Label();
            this.txtNota2 = new System.Windows.Forms.TextBox();
            this.lblNota3 = new System.Windows.Forms.Label();
            this.txtNota3 = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // 
            // lblNota1
            // 
            this.lblNota1.AutoSize = true;
            this.lblNota1.Location = new System.Drawing.Point(13, 13);
            this.lblNota1.Name = "lblNota1";
            this.lblNota1.Size = new System.Drawing.Size(56, 17);
            this.lblNota1.TabIndex = 0;
            this.lblNota1.Text = "Nota 1:";

            // 
            // txtNota1
            // 
            this.txtNota1.Location = new System.Drawing.Point(75, 10);
            this.txtNota1.Name = "txtNota1";
            this.txtNota1.Size = new System.Drawing.Size(100, 22);
            this.txtNota1.TabIndex = 1;

            // 
            // lblNota2
            // 
            this.lblNota2.AutoSize = true;
            this.lblNota2.Location = new System.Drawing.Point(13, 45);
            this.lblNota2.Name = "lblNota2";
            this.lblNota2.Size = new System.Drawing.Size(56, 17);
            this.lblNota2.TabIndex = 2;
            this.lblNota2.Text = "Nota 2:";

            // 
            // txtNota2
            // 
            this.txtNota2.Location = new System.Drawing.Point(75, 42);
            this.txtNota2.Name = "txtNota2";
            this.txtNota2.Size = new System.Drawing.Size(100, 22);
            this.txtNota2.TabIndex = 3;

            // 
            // lblNota3
            // 
            this.lblNota3.AutoSize = true;
            this.lblNota3.Location = new System.Drawing.Point(13, 77);
            this.lblNota3.Name = "lblNota3";
            this.lblNota3.Size = new System.Drawing.Size(56, 17);
            this.lblNota3.TabIndex = 4;
            this.lblNota3.Text = "Nota 3:";

            // 
            // txtNota3
            // 
            this.txtNota3.Location = new System.Drawing.Point(75, 74);
            this.txtNota3.Name = "txtNota3";
            this.txtNota3.Size = new System.Drawing.Size(100, 22);
            this.txtNota3.TabIndex = 5;

            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(16, 106);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(159, 40);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular Promedio";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);

            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.Location = new System.Drawing.Point(13, 155);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(124, 17);
            this.lblPromedio.TabIndex = 7;
            this.lblPromedio.Text = "Promedio Final: --";

            // 
            // frm04
            // 
            this.ClientSize = new System.Drawing.Size(284, 180);
            this.Controls.Add(this.lblPromedio);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtNota3);
            this.Controls.Add(this.lblNota3);
            this.Controls.Add(this.txtNota2);
            this.Controls.Add(this.lblNota2);
            this.Controls.Add(this.txtNota1);
            this.Controls.Add(this.lblNota1);
            this.Name = "frm04";
            this.Text = "Cálculo de Promedio Final";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

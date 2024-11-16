namespace PropinaEstudiante
{
    partial class frm08
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblExamen1;
        private System.Windows.Forms.TextBox txtExamen1;
        private System.Windows.Forms.Label lblExamen2;
        private System.Windows.Forms.TextBox txtExamen2;
        private System.Windows.Forms.Label lblExamen3;
        private System.Windows.Forms.TextBox txtExamen3;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblTotal;

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
            this.lblExamen1 = new System.Windows.Forms.Label();
            this.txtExamen1 = new System.Windows.Forms.TextBox();
            this.lblExamen2 = new System.Windows.Forms.Label();
            this.txtExamen2 = new System.Windows.Forms.TextBox();
            this.lblExamen3 = new System.Windows.Forms.Label();
            this.txtExamen3 = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // 
            // lblExamen1
            // 
            this.lblExamen1.AutoSize = true;
            this.lblExamen1.Location = new System.Drawing.Point(13, 13);
            this.lblExamen1.Name = "lblExamen1";
            this.lblExamen1.Size = new System.Drawing.Size(67, 17);
            this.lblExamen1.TabIndex = 0;
            this.lblExamen1.Text = "Examen 1:";

            // 
            // txtExamen1
            // 
            this.txtExamen1.Location = new System.Drawing.Point(87, 10);
            this.txtExamen1.Name = "txtExamen1";
            this.txtExamen1.Size = new System.Drawing.Size(100, 22);
            this.txtExamen1.TabIndex = 1;

            // 
            // lblExamen2
            // 
            this.lblExamen2.AutoSize = true;
            this.lblExamen2.Location = new System.Drawing.Point(13, 45);
            this.lblExamen2.Name = "lblExamen2";
            this.lblExamen2.Size = new System.Drawing.Size(67, 17);
            this.lblExamen2.TabIndex = 2;
            this.lblExamen2.Text = "Examen 2:";

            // 
            // txtExamen2
            // 
            this.txtExamen2.Location = new System.Drawing.Point(87, 42);
            this.txtExamen2.Name = "txtExamen2";
            this.txtExamen2.Size = new System.Drawing.Size(100, 22);
            this.txtExamen2.TabIndex = 3;

            // 
            // lblExamen3
            // 
            this.lblExamen3.AutoSize = true;
            this.lblExamen3.Location = new System.Drawing.Point(13, 77);
            this.lblExamen3.Name = "lblExamen3";
            this.lblExamen3.Size = new System.Drawing.Size(67, 17);
            this.lblExamen3.TabIndex = 4;
            this.lblExamen3.Text = "Examen 3:";

            // 
            // txtExamen3
            // 
            this.txtExamen3.Location = new System.Drawing.Point(87, 74);
            this.txtExamen3.Name = "txtExamen3";
            this.txtExamen3.Size = new System.Drawing.Size(100, 22);
            this.txtExamen3.TabIndex = 5;

            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(16, 106);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(171, 40);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular Propina Total";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);

            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(13, 155);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(171, 17);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "Monto total de la propina: S/. --";

            // 
            // frm08
            // 
            this.ClientSize = new System.Drawing.Size(284, 180);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtExamen3);
            this.Controls.Add(this.lblExamen3);
            this.Controls.Add(this.txtExamen2);
            this.Controls.Add(this.lblExamen2);
            this.Controls.Add(this.txtExamen1);
            this.Controls.Add(this.lblExamen1);
            this.Name = "frm08";
            this.Text = "Monto de Propina";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

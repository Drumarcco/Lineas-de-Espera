namespace Lineas_de_Espera
{
    partial class ModeloUniServidor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_mu = new System.Windows.Forms.TextBox();
            this.txt_lambda = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_factorUtilizacion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_mu
            // 
            this.txt_mu.Location = new System.Drawing.Point(197, 45);
            this.txt_mu.Name = "txt_mu";
            this.txt_mu.Size = new System.Drawing.Size(100, 20);
            this.txt_mu.TabIndex = 10;
            this.txt_mu.TextChanged += new System.EventHandler(this.txt_mu_TextChanged);
            // 
            // txt_lambda
            // 
            this.txt_lambda.Location = new System.Drawing.Point(197, 15);
            this.txt_lambda.Name = "txt_lambda";
            this.txt_lambda.Size = new System.Drawing.Size(100, 20);
            this.txt_lambda.TabIndex = 9;
            this.txt_lambda.TextChanged += new System.EventHandler(this.txt_lambda_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "μ Tasa media de tiempo de servicio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "λ Tasa media de llegada de clientes:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "𝜌 Factor de Utilizacion:";
            // 
            // lbl_factorUtilizacion
            // 
            this.lbl_factorUtilizacion.AutoSize = true;
            this.lbl_factorUtilizacion.Location = new System.Drawing.Point(198, 77);
            this.lbl_factorUtilizacion.Name = "lbl_factorUtilizacion";
            this.lbl_factorUtilizacion.Size = new System.Drawing.Size(10, 13);
            this.lbl_factorUtilizacion.TabIndex = 12;
            this.lbl_factorUtilizacion.Text = "-";
            // 
            // ModeloUniServidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 261);
            this.Controls.Add(this.lbl_factorUtilizacion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_mu);
            this.Controls.Add(this.txt_lambda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "ModeloUniServidor";
            this.Text = "ModeloUniServidor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_mu;
        private System.Windows.Forms.TextBox txt_lambda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_factorUtilizacion;
    }
}
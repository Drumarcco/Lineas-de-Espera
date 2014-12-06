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
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_numeroEsperadoClientesSistema = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_numeroEsperadoClientesFila = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_tiempoEsperaSistema = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_tiempoEsperaCola = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbx_probabilidadNClientes = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "L Numero esperado de clientes en sistema:";
            // 
            // lbl_numeroEsperadoClientesSistema
            // 
            this.lbl_numeroEsperadoClientesSistema.AutoSize = true;
            this.lbl_numeroEsperadoClientesSistema.Location = new System.Drawing.Point(229, 106);
            this.lbl_numeroEsperadoClientesSistema.Name = "lbl_numeroEsperadoClientesSistema";
            this.lbl_numeroEsperadoClientesSistema.Size = new System.Drawing.Size(10, 13);
            this.lbl_numeroEsperadoClientesSistema.TabIndex = 14;
            this.lbl_numeroEsperadoClientesSistema.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Lq Número esperado de clientes en cola:";
            // 
            // lbl_numeroEsperadoClientesFila
            // 
            this.lbl_numeroEsperadoClientesFila.AutoSize = true;
            this.lbl_numeroEsperadoClientesFila.Location = new System.Drawing.Point(219, 137);
            this.lbl_numeroEsperadoClientesFila.Name = "lbl_numeroEsperadoClientesFila";
            this.lbl_numeroEsperadoClientesFila.Size = new System.Drawing.Size(10, 13);
            this.lbl_numeroEsperadoClientesFila.TabIndex = 16;
            this.lbl_numeroEsperadoClientesFila.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "W Tiempo de espera en el sistema:";
            // 
            // lbl_tiempoEsperaSistema
            // 
            this.lbl_tiempoEsperaSistema.AutoSize = true;
            this.lbl_tiempoEsperaSistema.Location = new System.Drawing.Point(191, 169);
            this.lbl_tiempoEsperaSistema.Name = "lbl_tiempoEsperaSistema";
            this.lbl_tiempoEsperaSistema.Size = new System.Drawing.Size(10, 13);
            this.lbl_tiempoEsperaSistema.TabIndex = 18;
            this.lbl_tiempoEsperaSistema.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Wq Tiempo de espera en cola:";
            // 
            // lbl_tiempoEsperaCola
            // 
            this.lbl_tiempoEsperaCola.AutoSize = true;
            this.lbl_tiempoEsperaCola.Location = new System.Drawing.Point(171, 200);
            this.lbl_tiempoEsperaCola.Name = "lbl_tiempoEsperaCola";
            this.lbl_tiempoEsperaCola.Size = new System.Drawing.Size(10, 13);
            this.lbl_tiempoEsperaCola.TabIndex = 20;
            this.lbl_tiempoEsperaCola.Text = "-";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbx_probabilidadNClientes);
            this.groupBox1.Location = new System.Drawing.Point(316, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 198);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Probabilidad de n clientes en sistema:";
            // 
            // lbx_probabilidadNClientes
            // 
            this.lbx_probabilidadNClientes.FormattingEnabled = true;
            this.lbx_probabilidadNClientes.Location = new System.Drawing.Point(6, 19);
            this.lbx_probabilidadNClientes.Name = "lbx_probabilidadNClientes";
            this.lbx_probabilidadNClientes.Size = new System.Drawing.Size(229, 173);
            this.lbx_probabilidadNClientes.TabIndex = 0;
            // 
            // ModeloUniServidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 335);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_tiempoEsperaCola);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbl_tiempoEsperaSistema);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_numeroEsperadoClientesFila);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_numeroEsperadoClientesSistema);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_factorUtilizacion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_mu);
            this.Controls.Add(this.txt_lambda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "ModeloUniServidor";
            this.Text = "ModeloUniServidor";
            this.groupBox1.ResumeLayout(false);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_numeroEsperadoClientesSistema;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_numeroEsperadoClientesFila;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_tiempoEsperaSistema;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_tiempoEsperaCola;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbx_probabilidadNClientes;
    }
}
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
            this.components = new System.ComponentModel.Container();
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
            this.lbl_tituloDesviacionEstandar = new System.Windows.Forms.Label();
            this.lbl_desviacionEstandar = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_numeroServidores = new System.Windows.Forms.Label();
            this.lbl_lambda = new System.Windows.Forms.Label();
            this.lbl_mu = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_wqMayorT = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbl_wMayorT = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_Tiempo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbl_costoTotal = new System.Windows.Forms.Label();
            this.lbl_costoCalculadoEspera = new System.Windows.Forms.Label();
            this.lbl_costoCalculadoServidores = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_costoEspera = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_costoServidor = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tip_universal = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "μ Tasa media de tiempo de servicio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "λ Tasa media de llegada de clientes:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "𝜌 Factor de Utilizacion:";
            // 
            // lbl_factorUtilizacion
            // 
            this.lbl_factorUtilizacion.AutoSize = true;
            this.lbl_factorUtilizacion.Location = new System.Drawing.Point(229, 108);
            this.lbl_factorUtilizacion.Name = "lbl_factorUtilizacion";
            this.lbl_factorUtilizacion.Size = new System.Drawing.Size(10, 13);
            this.lbl_factorUtilizacion.TabIndex = 12;
            this.lbl_factorUtilizacion.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "L Numero esperado de clientes en sistema:";
            // 
            // lbl_numeroEsperadoClientesSistema
            // 
            this.lbl_numeroEsperadoClientesSistema.AutoSize = true;
            this.lbl_numeroEsperadoClientesSistema.Location = new System.Drawing.Point(229, 137);
            this.lbl_numeroEsperadoClientesSistema.Name = "lbl_numeroEsperadoClientesSistema";
            this.lbl_numeroEsperadoClientesSistema.Size = new System.Drawing.Size(10, 13);
            this.lbl_numeroEsperadoClientesSistema.TabIndex = 14;
            this.lbl_numeroEsperadoClientesSistema.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Lq Número esperado de clientes en cola:";
            // 
            // lbl_numeroEsperadoClientesFila
            // 
            this.lbl_numeroEsperadoClientesFila.AutoSize = true;
            this.lbl_numeroEsperadoClientesFila.Location = new System.Drawing.Point(229, 168);
            this.lbl_numeroEsperadoClientesFila.Name = "lbl_numeroEsperadoClientesFila";
            this.lbl_numeroEsperadoClientesFila.Size = new System.Drawing.Size(10, 13);
            this.lbl_numeroEsperadoClientesFila.TabIndex = 16;
            this.lbl_numeroEsperadoClientesFila.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "W Tiempo de espera en el sistema:";
            // 
            // lbl_tiempoEsperaSistema
            // 
            this.lbl_tiempoEsperaSistema.AutoSize = true;
            this.lbl_tiempoEsperaSistema.Location = new System.Drawing.Point(229, 200);
            this.lbl_tiempoEsperaSistema.Name = "lbl_tiempoEsperaSistema";
            this.lbl_tiempoEsperaSistema.Size = new System.Drawing.Size(10, 13);
            this.lbl_tiempoEsperaSistema.TabIndex = 18;
            this.lbl_tiempoEsperaSistema.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(69, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Wq Tiempo de espera en cola:";
            // 
            // lbl_tiempoEsperaCola
            // 
            this.lbl_tiempoEsperaCola.AutoSize = true;
            this.lbl_tiempoEsperaCola.Location = new System.Drawing.Point(229, 231);
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
            this.groupBox1.Size = new System.Drawing.Size(252, 343);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Probabilidad de n clientes en sistema:";
            // 
            // lbx_probabilidadNClientes
            // 
            this.lbx_probabilidadNClientes.FormattingEnabled = true;
            this.lbx_probabilidadNClientes.Location = new System.Drawing.Point(6, 19);
            this.lbx_probabilidadNClientes.Name = "lbx_probabilidadNClientes";
            this.lbx_probabilidadNClientes.Size = new System.Drawing.Size(240, 316);
            this.lbx_probabilidadNClientes.TabIndex = 0;
            // 
            // lbl_tituloDesviacionEstandar
            // 
            this.lbl_tituloDesviacionEstandar.AutoSize = true;
            this.lbl_tituloDesviacionEstandar.Location = new System.Drawing.Point(114, 262);
            this.lbl_tituloDesviacionEstandar.Name = "lbl_tituloDesviacionEstandar";
            this.lbl_tituloDesviacionEstandar.Size = new System.Drawing.Size(108, 13);
            this.lbl_tituloDesviacionEstandar.TabIndex = 22;
            this.lbl_tituloDesviacionEstandar.Text = "Desviación Estándar:";
            this.lbl_tituloDesviacionEstandar.Visible = false;
            // 
            // lbl_desviacionEstandar
            // 
            this.lbl_desviacionEstandar.AutoSize = true;
            this.lbl_desviacionEstandar.Location = new System.Drawing.Point(228, 262);
            this.lbl_desviacionEstandar.Name = "lbl_desviacionEstandar";
            this.lbl_desviacionEstandar.Size = new System.Drawing.Size(10, 13);
            this.lbl_desviacionEstandar.TabIndex = 23;
            this.lbl_desviacionEstandar.Text = "-";
            this.lbl_desviacionEstandar.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(99, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "s Numero de Servidores:";
            // 
            // lbl_numeroServidores
            // 
            this.lbl_numeroServidores.AutoSize = true;
            this.lbl_numeroServidores.Location = new System.Drawing.Point(229, 78);
            this.lbl_numeroServidores.Name = "lbl_numeroServidores";
            this.lbl_numeroServidores.Size = new System.Drawing.Size(10, 13);
            this.lbl_numeroServidores.TabIndex = 25;
            this.lbl_numeroServidores.Text = "-";
            // 
            // lbl_lambda
            // 
            this.lbl_lambda.AutoSize = true;
            this.lbl_lambda.Location = new System.Drawing.Point(229, 18);
            this.lbl_lambda.Name = "lbl_lambda";
            this.lbl_lambda.Size = new System.Drawing.Size(10, 13);
            this.lbl_lambda.TabIndex = 26;
            this.lbl_lambda.Text = "-";
            // 
            // lbl_mu
            // 
            this.lbl_mu.AutoSize = true;
            this.lbl_mu.Location = new System.Drawing.Point(229, 48);
            this.lbl_mu.Name = "lbl_mu";
            this.lbl_mu.Size = new System.Drawing.Size(10, 13);
            this.lbl_mu.TabIndex = 27;
            this.lbl_mu.Text = "-";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_wqMayorT);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.lbl_wMayorT);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txt_Tiempo);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(316, 364);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(252, 121);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Probabilidades de tiempo de espera excedente:";
            // 
            // lbl_wqMayorT
            // 
            this.lbl_wqMayorT.AutoSize = true;
            this.lbl_wqMayorT.Location = new System.Drawing.Point(66, 81);
            this.lbl_wqMayorT.Name = "lbl_wqMayorT";
            this.lbl_wqMayorT.Size = new System.Drawing.Size(10, 13);
            this.lbl_wqMayorT.TabIndex = 5;
            this.lbl_wqMayorT.Text = "-";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 81);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "P(Wq>t):";
            // 
            // lbl_wMayorT
            // 
            this.lbl_wMayorT.AutoSize = true;
            this.lbl_wMayorT.Location = new System.Drawing.Point(66, 53);
            this.lbl_wMayorT.Name = "lbl_wMayorT";
            this.lbl_wMayorT.Size = new System.Drawing.Size(10, 13);
            this.lbl_wMayorT.TabIndex = 3;
            this.lbl_wMayorT.Text = "-";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "P(W>t):";
            // 
            // txt_Tiempo
            // 
            this.txt_Tiempo.Location = new System.Drawing.Point(65, 20);
            this.txt_Tiempo.Name = "txt_Tiempo";
            this.txt_Tiempo.Size = new System.Drawing.Size(100, 20);
            this.txt_Tiempo.TabIndex = 1;
            this.txt_Tiempo.TextChanged += new System.EventHandler(this.txt_Tiempo_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "t Tiempo:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbl_costoTotal);
            this.groupBox3.Controls.Add(this.lbl_costoCalculadoEspera);
            this.groupBox3.Controls.Add(this.lbl_costoCalculadoServidores);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.txt_costoEspera);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txt_costoServidor);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Location = new System.Drawing.Point(15, 292);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(275, 193);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cálculo de costos:";
            // 
            // lbl_costoTotal
            // 
            this.lbl_costoTotal.AutoSize = true;
            this.lbl_costoTotal.Location = new System.Drawing.Point(121, 159);
            this.lbl_costoTotal.Name = "lbl_costoTotal";
            this.lbl_costoTotal.Size = new System.Drawing.Size(10, 13);
            this.lbl_costoTotal.TabIndex = 9;
            this.lbl_costoTotal.Text = "-";
            // 
            // lbl_costoCalculadoEspera
            // 
            this.lbl_costoCalculadoEspera.AutoSize = true;
            this.lbl_costoCalculadoEspera.Location = new System.Drawing.Point(121, 124);
            this.lbl_costoCalculadoEspera.Name = "lbl_costoCalculadoEspera";
            this.lbl_costoCalculadoEspera.Size = new System.Drawing.Size(10, 13);
            this.lbl_costoCalculadoEspera.TabIndex = 8;
            this.lbl_costoCalculadoEspera.Text = "-";
            // 
            // lbl_costoCalculadoServidores
            // 
            this.lbl_costoCalculadoServidores.AutoSize = true;
            this.lbl_costoCalculadoServidores.Location = new System.Drawing.Point(121, 90);
            this.lbl_costoCalculadoServidores.Name = "lbl_costoCalculadoServidores";
            this.lbl_costoCalculadoServidores.Size = new System.Drawing.Size(10, 13);
            this.lbl_costoCalculadoServidores.TabIndex = 7;
            this.lbl_costoCalculadoServidores.Text = "-";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(52, 159);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(60, 13);
            this.label16.TabIndex = 6;
            this.label16.Text = "Costo total:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(25, 124);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(87, 13);
            this.label15.TabIndex = 5;
            this.label15.Text = "Costo de espera:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 90);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(103, 13);
            this.label14.TabIndex = 4;
            this.label14.Text = "Costo de servidores:";
            // 
            // txt_costoEspera
            // 
            this.txt_costoEspera.Location = new System.Drawing.Point(124, 54);
            this.txt_costoEspera.Name = "txt_costoEspera";
            this.txt_costoEspera.Size = new System.Drawing.Size(100, 20);
            this.txt_costoEspera.TabIndex = 3;
            this.txt_costoEspera.TextChanged += new System.EventHandler(this.txt_costoEspera_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(22, 57);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Costo por espera:";
            // 
            // txt_costoServidor
            // 
            this.txt_costoServidor.Location = new System.Drawing.Point(124, 20);
            this.txt_costoServidor.Name = "txt_costoServidor";
            this.txt_costoServidor.Size = new System.Drawing.Size(100, 20);
            this.txt_costoServidor.TabIndex = 1;
            this.txt_costoServidor.TextChanged += new System.EventHandler(this.txt_costoServidor_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Costo por servidor:";
            // 
            // ModeloUniServidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 498);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lbl_mu);
            this.Controls.Add(this.lbl_lambda);
            this.Controls.Add(this.lbl_numeroServidores);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbl_desviacionEstandar);
            this.Controls.Add(this.lbl_tituloDesviacionEstandar);
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
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "ModeloUniServidor";
            this.Text = "ModeloUniServidor";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.Label lbl_tituloDesviacionEstandar;
        private System.Windows.Forms.Label lbl_desviacionEstandar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_numeroServidores;
        private System.Windows.Forms.Label lbl_lambda;
        private System.Windows.Forms.Label lbl_mu;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_Tiempo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_wqMayorT;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbl_wMayorT;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbl_costoTotal;
        private System.Windows.Forms.Label lbl_costoCalculadoEspera;
        private System.Windows.Forms.Label lbl_costoCalculadoServidores;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_costoEspera;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_costoServidor;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ToolTip tip_universal;
    }
}
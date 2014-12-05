namespace Lineas_de_Espera
{
    partial class Inicio
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
            this.cbx_listaModelos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_CalcularModelo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_lambda = new System.Windows.Forms.TextBox();
            this.txt_mu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_numeroServidores = new System.Windows.Forms.TextBox();
            this.txt_desviacionEstandar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbx_listaModelos
            // 
            this.cbx_listaModelos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_listaModelos.FormattingEnabled = true;
            this.cbx_listaModelos.Items.AddRange(new object[] {
            "M/M/1",
            "M/G/1",
            "M/D/1",
            "M/M/S",
            "M/G/S"});
            this.cbx_listaModelos.Location = new System.Drawing.Point(201, 10);
            this.cbx_listaModelos.Name = "cbx_listaModelos";
            this.cbx_listaModelos.Size = new System.Drawing.Size(100, 21);
            this.cbx_listaModelos.TabIndex = 0;
            this.cbx_listaModelos.SelectedIndexChanged += new System.EventHandler(this.cbx_listaModelos_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccionar modelo:";
            // 
            // btn_CalcularModelo
            // 
            this.btn_CalcularModelo.Location = new System.Drawing.Point(226, 179);
            this.btn_CalcularModelo.Name = "btn_CalcularModelo";
            this.btn_CalcularModelo.Size = new System.Drawing.Size(75, 23);
            this.btn_CalcularModelo.TabIndex = 6;
            this.btn_CalcularModelo.Text = "Calcular";
            this.btn_CalcularModelo.UseVisualStyleBackColor = true;
            this.btn_CalcularModelo.Click += new System.EventHandler(this.btn_CalcularModelo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "λ Tasa media de llegada de clientes:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "μ Tasa media de tiempo de servicio:";
            // 
            // txt_lambda
            // 
            this.txt_lambda.Location = new System.Drawing.Point(201, 43);
            this.txt_lambda.Name = "txt_lambda";
            this.txt_lambda.Size = new System.Drawing.Size(100, 20);
            this.txt_lambda.TabIndex = 5;
            // 
            // txt_mu
            // 
            this.txt_mu.Location = new System.Drawing.Point(201, 73);
            this.txt_mu.Name = "txt_mu";
            this.txt_mu.Size = new System.Drawing.Size(100, 20);
            this.txt_mu.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "s Numero de Servidores:";
            // 
            // txt_numeroServidores
            // 
            this.txt_numeroServidores.Location = new System.Drawing.Point(201, 106);
            this.txt_numeroServidores.Name = "txt_numeroServidores";
            this.txt_numeroServidores.Size = new System.Drawing.Size(100, 20);
            this.txt_numeroServidores.TabIndex = 8;
            // 
            // txt_desviacionEstandar
            // 
            this.txt_desviacionEstandar.Location = new System.Drawing.Point(201, 140);
            this.txt_desviacionEstandar.Name = "txt_desviacionEstandar";
            this.txt_desviacionEstandar.Size = new System.Drawing.Size(100, 20);
            this.txt_desviacionEstandar.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(87, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Desviacion Estandar:";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 214);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_desviacionEstandar);
            this.Controls.Add(this.txt_numeroServidores);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_mu);
            this.Controls.Add(this.txt_lambda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_CalcularModelo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbx_listaModelos);
            this.Name = "Inicio";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbx_listaModelos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_CalcularModelo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_lambda;
        private System.Windows.Forms.TextBox txt_mu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_numeroServidores;
        private System.Windows.Forms.TextBox txt_desviacionEstandar;
        private System.Windows.Forms.Label label5;

    }
}


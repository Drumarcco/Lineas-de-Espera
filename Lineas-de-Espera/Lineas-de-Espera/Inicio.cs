using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lineas_de_Espera
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
            btn_CalcularModelo.Enabled = false;
        }

        private void btn_CalcularModelo_Click(object sender, EventArgs e)
        {
            float tasaMediaLlegadaClientes;
            float tasaMediaTiempoServicio;
            int numeroServidores;

            try
            {
                tasaMediaLlegadaClientes = float.Parse(txt_lambda.Text);
                tasaMediaTiempoServicio = float.Parse(txt_mu.Text);
                numeroServidores = int.Parse(txt_numeroServidores.Text);
                float desviacionEstandar=0;
                if (cbx_listaModelos.SelectedItem.ToString() == "M/G/1")
                {
                    desviacionEstandar = float.Parse(txt_desviacionEstandar.Text);
                }
                
                string nombreModelo = cbx_listaModelos.SelectedItem.ToString();
                if (nombreModelo == "M/M/1")
                {
                    ModeloMM1 modelo = new ModeloMM1(tasaMediaLlegadaClientes, tasaMediaTiempoServicio);
                    ModeloUniServidor formModelo = new ModeloUniServidor(modelo);
                    formModelo.Show();
                }
                else if (nombreModelo == "M/G/1")
                {
                    ModeloMG1 modelo = new ModeloMG1(tasaMediaLlegadaClientes, tasaMediaTiempoServicio, desviacionEstandar);
                    ModeloUniServidor formModelo = new ModeloUniServidor(modelo);
                    formModelo.Show();
                }
                else if (nombreModelo == "M/D/1")
                {
                    ModeloMD1 modelo = new ModeloMD1(tasaMediaLlegadaClientes, tasaMediaTiempoServicio);
                    ModeloUniServidor formModelo = new ModeloUniServidor(modelo);
                    formModelo.Show();
                }
                else if (nombreModelo == "M/M/S")
                {
                    ModeloMMS modelo = new ModeloMMS(tasaMediaLlegadaClientes, tasaMediaTiempoServicio, numeroServidores);
                }
                else if (nombreModelo == "M/D/S")
                {
                    throw new NotImplementedException();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Formato incorrecto en dato(s).");
            }
            catch (ArgumentException argumentException)
            {
                MessageBox.Show(argumentException.Message);
            }
        }

        private void cbx_listaModelos_SelectedIndexChanged(object sender, EventArgs e)
        {
            limpiarCampos();
            btn_CalcularModelo.Enabled = true;
            string modelo = cbx_listaModelos.SelectedItem.ToString();
            if (modelo == "M/G/1") txt_desviacionEstandar.Enabled = true;
            if (modelo == "M/M/S" || modelo == "M/G/S") txt_numeroServidores.Enabled = true;
        }

        private void limpiarCampos()
        {
            txt_desviacionEstandar.Enabled = false;
            txt_desviacionEstandar.Clear();
            txt_lambda.Clear();
            txt_mu.Clear();
            txt_numeroServidores.Enabled = false;
            txt_numeroServidores.Text = "1";
        }
    }
}

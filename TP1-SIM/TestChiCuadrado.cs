using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace TP1_SIM
{
    public partial class TestChiCuadrado : Form
    {       
        
        public TestChiCuadrado()
        {
            InitializeComponent();

            cmbIntervalos.SelectedIndex = -1;

        }

        private void ValidarIngreso()
        {
            if (string.IsNullOrEmpty(mstxtMuestra.Text))
            {
                throw new Exception("Debe llenar el campo tamaño de Muestra");
            }
            else if(!int.TryParse(mstxtMuestra.Text, out int res))
            {
                throw new Exception("El tamaño de la muestra debe ser un entero");
            }
            else if(string.IsNullOrEmpty(cmbIntervalos.SelectedItem?.ToString()))
            {
                throw new Exception("Debe ingresar la cantidad de intervalos");
            }
            else if (!int.TryParse(cmbIntervalos.SelectedItem?.ToString(), out int res2))
            {
                throw new Exception("La cantidad de intervalos debe ser un entero");
            }

            if (chkMetodoMixto.Checked)
            {
                if (string.IsNullOrEmpty(txtA.Text) || string.IsNullOrEmpty(txtC.Text) || string.IsNullOrEmpty(txtSemilla.Text) || string.IsNullOrEmpty(txtM.Text))
                    throw new Exception("Complete todos los campos referentes al método mixto por favor");
                else if (!int.TryParse(txtA.Text, out int a))
                    throw new Exception("El campo A debe ser un número");
                else if (a % 2 == 0 || a % 3 == 0 || a % 5 == 0)
                    throw new Exception("En este método A no puede ser par ni divisible por 3 ni por 5. ");
            }



        }
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                dgvFrecuencias.DataSource = null;
                dgvSerie.DataSource = null;
                LimpiarTablas();
                ValidarIngreso();
                                
                double[] elem;
                if (chkMetodoMixto.Checked)
                {
                    elem = GenerarRNDsConMetodoMixto(int.Parse(mstxtMuestra.Text), int.Parse(txtSemilla.Text),int.Parse(txtA.Text), int.Parse(txtC.Text), int.Parse(txtM.Text));                    
                }
                else
                {
                    elem = GenerarRNDsConLenguaje(int.Parse(mstxtMuestra.Text));
                }
                int cantidadIntervalos = int.Parse(cmbIntervalos.SelectedItem.ToString());
                double[] intervalos = GenerarIntervalos(cantidadIntervalos);
                CargarFrecuencias(elem, intervalos);

                ////
                int nroFila = dgvFrecuencias.RowCount;
                String valorAcumulado = dgvFrecuencias.Rows[nroFila - 2].Cells[5].Value.ToString();
                txt_calculado.Text = valorAcumulado;
                txt_gradoslibertad.Text = (cantidadIntervalos - 1).ToString();

                string msg = ValidarHipotesis(valorAcumulado, cantidadIntervalos);
                MessageBox.Show(msg, "Validación de Hipotesis", MessageBoxButtons.OK);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Error", MessageBoxButtons.OK);
            }
        }

        public double[] GenerarRNDsConMetodoMixto(int cantidadAGenerar, int x0, int a, int c, int m)
        {
            double xAnterior = (a * x0 + c) % m;
            double xActual;
            double rndActual;
            double[] numeros = new double[cantidadAGenerar];

            for(int i = 1; i < cantidadAGenerar; i++)
            {
                xActual = (a * xAnterior + c) % m;
                rndActual = xActual / m;
                
                numeros[i] = (Math.Round(rndActual, 4));
                xAnterior = xActual;
            }
            dgvSerie.DataSource = numeros.Select(x => new { Serie = x }).ToList();
            return numeros;
        }

        private double[] GenerarRNDsConLenguaje(int n)
        {
            Random rnd = new Random();
            double[] numeros = new double[n];

            for (int i = 1; i < n; i++)
            {
                numeros[i] = Math.Round(rnd.NextDouble(), 4);
            }
            dgvSerie.DataSource = numeros.Select(x => new { Serie = x }).ToList();
            return numeros;
        }

 
        public double[] GenerarIntervalos(int cantidadIntervalos)
        {            
            double[] intervalos = new double[cantidadIntervalos];
            float tam =  1 / (float) cantidadIntervalos;

            for (int i = 0; i < intervalos.Length; i++)
            {
                if (i == 0)
                {
                    intervalos[i] = Math.Round(tam,4);                   
                }
                else
                {                   
                    intervalos[i] = Math.Round(intervalos[i-1] + tam,4);         
                }
            }
            return intervalos;           
        }
       
        private void CargarFrecuencias(double[] numeros , double[] intervalos)
        {
            int[] frecuencias = new int[intervalos.Length];
            
            double suma = 0;
            double frecEsperada =  numeros.Length / intervalos.Length;
         
            for (int i = 0; i < numeros.Length; i++)
            {
                suma += numeros[i];

                for (int j = 0; j < intervalos.Length; j++)
                {
                    if (j == 0)
                    {
                        if (numeros[i] < intervalos[j])
                        {
                            frecuencias[j]++;

                        }
                    }
                    else
                    {
                        if (intervalos[j - 1] < numeros[i] && numeros[i] < intervalos[j])
                        {
                            frecuencias[j]++;                         
                        }
                    }
                }
            }
            double sumaC = 0;
            for (int i = 0; i < intervalos.Length; i++)
            {

                double c = Math.Round(Math.Pow(frecuencias[i] - frecEsperada, 2) / frecEsperada, 4);
                sumaC += c;
                if (i == 0)
                {   
                    dgvFrecuencias.Rows.Add(0, intervalos[i], frecuencias[i], Math.Round(frecEsperada, 4),c,sumaC);
                }
                else
                {                                        
                    dgvFrecuencias.Rows.Add(intervalos[i - 1], intervalos[i],frecuencias[i], Math.Round(frecEsperada, 4),c,sumaC);
                }
            }    
            
            
            chart1.ChartAreas[0].AxisY.Minimum = 0;
            Series serie_observada = chart1.Series.Add("Valores");            
            this.chart1.ChartAreas[0].AxisY.Title = "Fo";
            this.chart1.ChartAreas[0].AxisX.Title = "Intervalo";
            chart1.Series[0].IsValueShownAsLabel = true;
            for (int i = 0; i < intervalos.Length; i++)
            {
                serie_observada.Points.AddXY(intervalos[i], frecuencias[i]);
            }     
        }

        private string ValidarHipotesis(string valorCalculado, int cantidadIntervalos)
        {
            string msg = "Se {2} la hipotesis dado que el valor tabulado {0} es {1} al calculado";

            double calculado = Convert.ToDouble(valorCalculado);
            double valorTabulado;
            switch (cantidadIntervalos)
            {
                case 5:
                    valorTabulado = 9.4877;
                    break;
                case 8:
                    valorTabulado = 14.0671;
                    break;
                case 10:
                    valorTabulado = 16.9190;
                    break;
                case 12:
                    valorTabulado = 19.7;
                    break;
                default:
                    valorTabulado = 10000;
                    break;
            }

            if (calculado >= valorTabulado)
            {
                msg = string.Format(msg, valorTabulado.ToString(), "MENOR", "RECHAZA");
            }
            else
            {
                msg = string.Format(msg, valorTabulado.ToString(), "MAYOR", "ACEPTA");
            }
            return msg;
        }



        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            cmbIntervalos.SelectedIndex = -1;
            mstxtMuestra.Clear();            
            txt_calculado.Clear();
            txt_gradoslibertad.Clear();
            txtM.Clear();
            txtA.Clear();
            txtC.Clear();
            txtSemilla.Clear();            

            LimpiarTablas();
        }

        private void LimpiarTablas()
        {
            
            dgvSerie.DataSource = null;
            dgvFrecuencias.Rows.Clear();
            chart1.Series.Clear();
            System.GC.Collect();
        }

        private void TestChiCuadrado_Load(object sender, EventArgs e)
        {

        }

        // los métodos "KeyPress" sirven solo para que el usuario no ingrese letras o simbolos

        private void txtN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
             (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // solo permite un punto para representar decimales
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void chkMetodoMixto_Click(object sender, EventArgs e)
        {
            txtA.Enabled = !txtA.Enabled;
            txtC.Enabled = !txtC.Enabled;
            txtSemilla.Enabled = !txtSemilla.Enabled;
            txtM.Enabled = !txtM.Enabled;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

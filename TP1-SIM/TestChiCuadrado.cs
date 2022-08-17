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
        bool band_Ok = false;
        
        public TestChiCuadrado()
        {
            InitializeComponent();
        }

        private void validarIngreso()
        {
            if(mstxtMuestra.Text == "")
            {
                MessageBox.Show("Debe Ingresar el Tamaño de la Muestra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!rb5.Checked && !rb10.Checked && !rb15.Checked && !rb20.Checked)
            {
                MessageBox.Show("Debe Seleccionar un Intervalo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
                
            }
            if (band_Ok == false)
            {
                band_Ok = true;
            }

        }
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            validarIngreso();
            dgvFrecuencias.Rows.Clear();
            dgvSerie.Rows.Clear();
            if (band_Ok)
            {
                double[] elem = generarAleatorios(mstxtMuestra.Text);
                double media = metodoMedia(elem);
                double varianza = metodoVarianza(elem);
                double[] intervalos = generarIntervalos(elem);
                CargarFrecuencias(elem, intervalos);

                ////
                int nroFila = dgvFrecuencias.RowCount;
                String ValorAcumulado = dgvFrecuencias.Rows[nroFila - 2].Cells[5].Value.ToString();
                txt_calculado.Text = ValorAcumulado;

            }            
            validarHipotesis();
        }

        private void validarHipotesis()
        {
            if (rb5.Checked)
            {
                double calculado = Convert.ToDouble(txt_calculado.Text);
                if (calculado >= 9.5)
                {
                    MessageBox.Show("El valor tabulado es de 9.5 y es MENOR al calculado por lo tanto se RECHAZA la hipotesis");
                }
                else
                {
                    MessageBox.Show("El valor tabulado es de 9.5 y es MAYOR al calculado por lo tanto se ACEPTA la hipotesis");
                }
            }
            else if (rb10.Checked)
            {
                double calculado = Convert.ToDouble(txt_calculado.Text);
                if (calculado >= 14.1)
                {
                    MessageBox.Show("El valor tabulado es de 14.1 y es MENOR al calculado por lo tanto se RECHAZA la hipotesis");
                }
                else
                {
                    MessageBox.Show("El valor tabulado es de 14.1 y es MAYOR al calculado por lo tanto se ACEPTA la hipotesis");
                }
            }
            else if (rb15.Checked)
            {
                double calculado = Convert.ToDouble(txt_calculado.Text);
                if (calculado >= 16.9)
                {
                    MessageBox.Show("El valor tabulado es de 16.9 y es MENOR al calculado por lo tanto se RECHAZA la hipotesis");
                }
                else
                {
                    MessageBox.Show("El valor tabulado es de 16.9 y es MAYOR al calculado por lo tanto se ACEPTA la hipotesis");
                }
            }
            else
            {
                double calculado = Convert.ToDouble(txt_calculado.Text);
                if (calculado >= 19.7)
                {
                    MessageBox.Show("El valor tabulado es de 19.7 y es MENOR al calculado por lo tanto se RECHAZA la hipotesis");
                }
                else
                {
                    MessageBox.Show("El valor tabulado es de 19.7 y es MAYOR al calculado por lo tanto se ACEPTA la hipotesis");
                }
            }
        }


        private int cantidadIntervalos()
        {
            int num;

            if (rb5.Checked)
            {
                num = 5;
                txt_gradoslibertad.Text = 4.ToString();
            }
            else if (rb10.Checked)
            {
                num = 8;
                txt_gradoslibertad.Text = 7.ToString();
            }
            else if (rb15.Checked)
            {
                num = 10;
                txt_gradoslibertad.Text = 9.ToString();
            }
            else { 
                num = 12;
                txt_gradoslibertad.Text = 11.ToString();
            }

            return num;
        }

        public double[] generarIntervalos(double [] numeros)
        {
            int num = cantidadIntervalos()+1;
            
            double[] intervalos = new double[num];
            float tam =  1 / (float) num;

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
                Console.WriteLine(intervalos[i]);
            }

            return intervalos;
           
        }
        

        
        private void CargarFrecuencias(double[] numeros , double[] intervalos)
        {
            int[] frecuencias = new int[intervalos.Length];
            
            double suma = 0;
            double frecEsperada = 0;
           

            for (int i = 0; i < numeros.Length; i++)
            {
                suma += numeros[i];
                frecEsperada = numeros.Length;
                //MessageBox.Show("Frecuencia observada: " + frecEsperada);
                //suma1 = numeros.Length;
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
                

                if (i == 0)
                {

                    double c = Math.Round(Math.Pow(frecuencias[i] - (frecEsperada / intervalos.Length), 2) / (frecEsperada / intervalos.Length), 4);
                    sumaC += c;
                    dgvFrecuencias.Rows.Add(0, intervalos[i], frecuencias[i], Math.Round(frecEsperada / intervalos.Length, 4),c,sumaC);
                }
                else
                {
                    double c = Math.Round(Math.Pow(frecuencias[i] - (frecEsperada / intervalos.Length), 2) / (frecEsperada / intervalos.Length), 4); 
                    sumaC += c;
                    dgvFrecuencias.Rows.Add(intervalos[i - 1], intervalos[i],frecuencias[i], Math.Round(frecEsperada / intervalos.Length, 4),c,sumaC);
                }
            }

            ///         
            
            
            chart1.ChartAreas[0].AxisY.Minimum = 0;
            Series serie_observada = chart1.Series.Add("Valores");            
            this.chart1.ChartAreas[0].AxisY.Title = "Fo";
            this.chart1.ChartAreas[0].AxisX.Title = "Intervalo";
            chart1.Series[0].IsValueShownAsLabel = true;
            for (int i = 0; i < intervalos.Length; i++)
            {
                serie_observada.Points.AddXY(intervalos[i], frecuencias[i]);
            }     
            // COLOR EN EL GRAFICO:
            //chart1.Series[0].Palette = ChartColorPalette.BrightPastel;


        }

        private double[]  generarAleatorios(string muestra)
        {
            int n = int.Parse(muestra);
            Random rnd = new Random();
            double[] numeros = new double[n];
            Console.WriteLine("Generando "+ n + " numeros aleatorios");

            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = Math.Round(rnd.NextDouble(), 4);
                Console.WriteLine(numeros[i]);
                dgvSerie.Rows.Add(numeros[i]);
            }

            return numeros;
        }
        private double metodoMedia(double[] elem)
        {
            double media;
            double suma = 0;
            
            for (int i = 0; i < elem.Length ; i++)
            {
                suma += elem[i];
            }
            media = Math.Round(suma / elem.Length,4); 

            Console.WriteLine("La Media es:"+ media);
            return media;
            
        }
        private double metodoVarianza(double[] elem)
        {
            double varianza;
            double suma = 0;
            double media = metodoMedia(elem);

            for (int i = 0; i < elem.Length; i++)
            {
                suma += Math.Pow(elem[i] - media ,2) ;
            }

            varianza = Math.Round(suma / elem.Length,4);
            Console.WriteLine("La Varianza es:" + varianza);
            return varianza;
        }

        

        //private void btnSalir_Click(object sender, EventArgs e)
        //{
        //    this.Dispose();
        //}


        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            mstxtMuestra.Clear();
            rb5.Checked = false;
            rb10.Checked = false;
            rb15.Checked = false;
            rb20.Checked = false;
            dgvSerie.Rows.Clear();
            dgvFrecuencias.Rows.Clear();
            chart1.Series.Clear();
            txt_calculado.Clear();
            txt_gradoslibertad.Clear();
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
    }
}

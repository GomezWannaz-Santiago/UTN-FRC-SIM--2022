using Amazon.S3.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1_SIM
{
    public partial class TestKS : Form
    {
        bool band_Ok = false;
        public TestKS()
        {
            InitializeComponent();
        }
        private void validarIngreso()
        {
            if (mstxtMuestra.Text == "")
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
                double[] elem = generarAleatorios(mstxtMuestra.Text); //si piden con 30 cambiar el parentesis por un 30
                double media = metodoMedia(elem);
                double varianza = metodoVarianza(elem);
                double[] intervalos = generarIntervalos(elem);
                double ks = CargarFrecYProb(elem, intervalos);
                ////
                /*int nroFila = dgvFrecuencias.RowCount;
                String ValorAcumulado = dgvFrecuencias.Rows[nroFila - 2].Cells[5].Value.ToString(); */
                txt_calculado.Text = ks.ToString();
                txt_gradoslibertad.Text = mstxtMuestra.Text;

            }
            validarHipotesis();
        }
        
        private void validarHipotesis()
        {
            //double[] tablaKS = new double[50];
            double[] tablaKS = { 0.97500, 0.84189,0.70760,0.62394,0.56328,0.51926,0.48342,0.45427,0.43001,0.40925,0.39122,
            0.37543,0.36143,0.34890,0.33750,0.32733,0.31796,0.30936,0.30143,0.29408,0.28724,0.28087,0.2749,0.26931,0.26404,
            0.25908,0.25438,0.24993,0.24571,0.24170,0.23788,0.23424,0.23076,0.22743,0.22425,0.22119,0.21826,0.21544, 0.21273,
            0.21012,0.20760, 0.20517,0.20283,0.20056,0.19837,0.19625,0.19420,0.19221,0.19028,0.18841 };
            double ks = Convert.ToDouble(txt_calculado.Text);
            int gradosLib = int.Parse(mstxtMuestra.Text);
            double calculado = Convert.ToDouble(txt_calculado.Text);
            if (gradosLib <= 50)
            {
                
                if (ks >= tablaKS[gradosLib-1])
                {
                    MessageBox.Show("El valor tabulado es MENOR al calculado por lo tanto se RECHAZA la hipotesis nula.");
                }
                else   
                {
                    MessageBox.Show("El valor tabulado es MAYOR al calculado por lo tanto NO se puede RECHAZAR la hipótesis nula.");
                }
            }
            else 
            {
                
                if (ks >= Convert.ToDouble(1.36/Math.Sqrt(gradosLib)))
                {
                    MessageBox.Show("El valor tabulado es MENOR al calculado por lo tanto se RECHAZA la hipotesis nula.");
                }
                else
                {
                    MessageBox.Show("El valor tabulado es MAYOR al calculado por lo tanto NO se puede RECHAZAR la hipótesis nula.");
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
            else
            {
                num = 12;
                txt_gradoslibertad.Text = 11.ToString();
            }

            return num;
        }

        public double[] generarIntervalos(double[] numeros)
        {
            int num = cantidadIntervalos();

            double[] intervalos = new double[num];
            float tam = 1 / (float)num;

            for (int i = 0; i < intervalos.Length; i++)
            {
                if (i == 0)
                {
                    intervalos[i] = Math.Round(tam, 4);
                }
                else
                {
                    intervalos[i] = Math.Round(intervalos[i - 1] + tam, 4);
                }
                Console.WriteLine(intervalos[i]);
            }

            return intervalos;

        }



        private double CargarFrecYProb(double[] numeros, double[] intervalos) 
        {
            int[] frecuencias = new int[intervalos.Length];
            double[] prob = new double[intervalos.Length]; 
            double[] probAC = new double[intervalos.Length]; 
            double[] ks_prev = new double[intervalos.Length];
            double[] probEsp = new double[intervalos.Length]; 
            double[] probEspAC = new double[intervalos.Length];
            double suma = 0;
            double n = 0;
            double ks = 0;




            for (int i = 0; i < numeros.Length; i++)
            {
                suma += numeros[i];
                n = numeros.Length;

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


            for (int i = 0; i < intervalos.Length; i++)
            {
                prob[i] = frecuencias[i] / n;
                //probEsp[i] = (1 / intervalos.Length);
                probEsp[i] = ((n / intervalos.Length) / n);
                    


                if (i == 0)
                {
                    probAC[i] = prob[i];
                    probEspAC[i] = probEsp[i];
                    ks_prev[i] = Math.Round((Math.Abs(probAC[i] - probEspAC[i])), 4);

                    dgvFrecuencias.Rows.Add(0, intervalos[i], frecuencias[i], Math.Round(n / intervalos.Length,4), Math.Round(prob[i],4),
                    Math.Round(probEsp[i],4), Math.Round(probAC[i],4), Math.Round(probEspAC[i],4), Math.Round(ks_prev[i],4));

                    
                }
                else
                {
                    probAC[i] = prob[i] + probAC[(i - 1)];
                    probEspAC[i] = probEsp[i] + probEspAC[(i - 1)];
                    
                   
                    ks_prev[i] = Math.Round((Math.Abs(probAC[i] - probEspAC[i])), 4);

                    dgvFrecuencias.Rows.Add(intervalos[i - 1], intervalos[i], frecuencias[i], Math.Round(n / intervalos.Length,4), Math.Round(prob[i],4),
                        Math.Round(probEsp[i],4), Math.Round(probAC[i],4), Math.Round(probEspAC[i],4), Math.Round(ks_prev[i],4));
                    ks = Math.Max(ks_prev[i], ks);

                    
                }              






            }

            return ks;
            ///         


           /* chart1.ChartAreas[0].AxisY.Minimum = 0;
            Series serie_observada = chart1.Series.Add("Valores");
            this.chart1.ChartAreas[0].AxisY.Title = "Fo";
            this.chart1.ChartAreas[0].AxisX.Title = "Intervalo";
            chart1.Series[0].IsValueShownAsLabel = true;
            for (int i = 0; i < intervalos.Length; i++)
            {
                serie_observada.Points.AddXY(intervalos[i], frecuencias[i]);


            } */
            // COLOR EN EL GRAFICO:
            //chart1.Series[0].Palette = ChartColorPalette.BrightPastel;


        }

        private double[] generarAleatorios(string muestra)
        {
            int n = int.Parse(muestra);
            Random rnd = new Random();
            double[] numeros = new double[n];
            Console.WriteLine("Generando " + n + " numeros aleatorios");

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

            for (int i = 0; i < elem.Length; i++)
            {
                suma += elem[i];
            }
            media = Math.Round(suma / elem.Length, 4);

            Console.WriteLine("La Media es:" + media);
            return media;

        }
        private double metodoVarianza(double[] elem)
        {
            double varianza;
            double suma = 0;
            double media = metodoMedia(elem);

            for (int i = 0; i < elem.Length; i++)
            {
                suma += Math.Pow(elem[i] - media, 2);
            }

            varianza = Math.Round(suma / elem.Length, 4);
            Console.WriteLine("La Varianza es:" + varianza);
            return varianza;
        }



        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            mstxtMuestra.Clear();
            rb5.Checked = false;
            rb10.Checked = false;
            rb15.Checked = false;
            rb20.Checked = false;
            dgvSerie.Rows.Clear();
            dgvFrecuencias.Rows.Clear();
            //chart1.Series.Clear(); (era parte del grafico, se puede borrar)
            txt_calculado.Clear();
            txt_gradoslibertad.Clear();
        }
       
    }
}


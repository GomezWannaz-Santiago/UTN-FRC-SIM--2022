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
    public partial class GeneradorAleatorios : Form
    {
        //COMENTARIO
        private bool bandOk = true;
        private bool proximo = false;
        private bool proximo20 = false;
        private bool final = false;
        private bool generarDH = false;
        private bool primeraVuelta = true;
        double[] elem;

        public GeneradorAleatorios()
        {
            InitializeComponent();
        }
                
        private int ValidarVariables(string variable)
        {
            // Verifica que se haya ingresado un número positivo 
            if (int.TryParse(variable, out int resultado))
            {                
                if (resultado > 0)
                {
                    return resultado;
                }
            }

            return -1;
        }


        private void ControlarVariables()
        {
            // Valida que se hayan ingresado los parámetros necesarios
            if (ValidarVariables(txtRaiz.Text) == -1)
            {
                throw new Exception(message: "Error la Raiz \"X0\" debe ser entero y mayor a cero");
            }
            else if (rbMixto.Checked)
            {
                if (ValidarVariables(txtC.Text) == -1)                
                    throw new Exception(message: "Error la constante \"c\" debe ser entero y mayor a cero");                
            }

            if (txtK.Text == "" && txtA.Text == "")
            {
                throw new Exception(message: "DEBE COMPLETAR EL CAMPO DE LOS VALORES A O K OBLIGATORIAMENTE");
            }
            else if (txtK.Text == "")
            {
                if (ValidarVariables(txtA.Text) == -1)                
                    throw new Exception(message: "Error la constante \"a\" debe ser entero y mayor a cero");                    
                
            }
            else if (txtA.Text == "")
            {
                if (ValidarVariables(txtK.Text) == -1)               
                    throw new Exception(message: "Error el numero \"k\" debe ser entero y mayor a cero");                                    
            }

            if (txtM.Text == "" && txtG.Text == "")
            {
                throw new Exception(message: "DEBE COMPLETAR EL CAMPO DE LOS VALORES M O G OBLIGATORIAMENTE");                
            }
            else if (txtM.Text == "")
            {
                if (ValidarVariables(txtG.Text) == -1)                
                    throw new Exception(message: "Error el numero \"g\" debe ser entero y mayor a cero");                                    
            }
            else if (txtG.Text == "")
            {
                if (ValidarVariables(txtM.Text) == -1)                
                    throw new Exception(message: "Error el modulo \"m\" debe ser entero y mayor a cero");                                    
            }
            if (!bandOk)            
                bandOk = true;            
        }

        private List<int> GenerarAditivo()
        {
            // Retorna una lista con los parámetros necesarios para el aditivo

            int x = 37;
            int c = 0;
            int a = 0;
            int m = 53;
            int k = 0;
            int g = 0;

            if (txtRaiz.Text != "" || txtM.Text != "")
            {
                x = int.Parse(txtRaiz.Text);

                c = 0;
                a = 0;
                m = 0;
                k = 0;
                g = 0;

                if ((txtM.Text == "" && txtG.Text == ""))
                {
                    ControlarVariables();
                    return null;
                }
                else
                {
                    if (txtK.Text != "" && txtA.Text != "")
                    {
                        a = int.Parse(txtA.Text);
                        k = int.Parse(txtK.Text);
                    }
                    else if (txtK.Text == "")
                    {
                        a = int.Parse(txtA.Text);

                    }
                    else if (txtA.Text == "")
                    {
                        k = int.Parse(txtK.Text);
                        a = 3 + 8 * k;

                        txtA.Text = a.ToString();
                    }

                    if (txtM.Text != "" && txtG.Text != "")
                    {
                        g = int.Parse(txtG.Text);
                        m = int.Parse(txtM.Text);
                    }
                    else if (txtG.Text == "")
                    {
                        m = int.Parse(txtM.Text);
                    }

                    else if (txtM.Text == "")
                    {
                        g = int.Parse(txtG.Text);
                        m = (int)Math.Pow(2, g);
                        txtM.Text = m.ToString();
                    }
                }
            }
            return new List<int>() { x, a, c, m, k, g };
        }

        private List<int> generarMixto()
        {
            if (rbMixto.Checked)
            {
                int x = 37;
                int c = 7;
                int a = 19;
                int m = 53;
                int k = 0;
                int g = 0;

                if (txtC.Text != "")
                {
                    x = int.Parse(txtRaiz.Text);
                    c = int.Parse(txtC.Text);

                    a = 0;
                    m = 0;
                    k = 0;
                    g = 0;


                    if ((txtK.Text == "" && txtA.Text == "") || (txtM.Text == "" && txtG.Text == ""))
                    {
                        ControlarVariables();
                        return null;
                    }
                    else
                    {
                        if (txtK.Text != "" && txtA.Text != "")
                        {
                            a = int.Parse(txtA.Text);
                            k = int.Parse(txtK.Text);
                        }
                        else if (txtK.Text == "")
                        {
                            a = int.Parse(txtA.Text);

                        }
                        else if (txtA.Text == "")
                        {
                            k = int.Parse(txtK.Text);
                            a = 1 + 4 * k;                            
                            txtA.Text = a.ToString();
                        }

                        if (txtM.Text != "" && txtG.Text != "")
                        {
                            g = int.Parse(txtG.Text);
                            m = int.Parse(txtM.Text);
                        }
                        else if (txtG.Text == "")
                        {
                            m = int.Parse(txtM.Text);

                        }

                        else if (txtM.Text == "")
                        {
                            g = int.Parse(txtG.Text);
                            m = (int)Math.Pow(2, g);
                            //
                            txtM.Text = m.ToString();
                        }

                        if (primeraVuelta == true)
                        {
                            x = int.Parse(txtRaiz.Text);

                        }
                        else
                        {
                            int registros = dgvTabla.RowCount;

                            double rnd = Convert.ToDouble(dgvTabla.Rows[registros - 2].Cells[1].Value);
                            x = int.Parse((rnd * (m)).ToString());
                        }

                    }                    
                }
                return new List<int>() { x, a, c, m, k, g };
            }
            return null;
        }
    


        private List<int> generarMultiplicativo()
        {


            int x = int.Parse(txtRaiz.Text);

            int c = 0;
            int a = 0;
            int m = 0;
            int k = 0;
            int g = 0;
            if ((txtK.Text == "" && txtA.Text == "") || (txtM.Text == "" && txtG.Text == ""))
            {
                ControlarVariables();
                return null;
            }
            else
            {
                if (txtK.Text != "" && txtA.Text != "")
                {
                    a = int.Parse(txtA.Text);
                    k = int.Parse(txtK.Text);
                }
                else if (txtK.Text == "")
                {
                    a = int.Parse(txtA.Text);

                }
                else if (txtA.Text == "")
                {
                    k = int.Parse(txtK.Text);
                    a = 3 + 8 * k;

                    txtA.Text = a.ToString();
                }


                if (txtM.Text != "" && txtG.Text != "")
                {
                    g = int.Parse(txtG.Text);
                    m = int.Parse(txtM.Text);
                }
                else if (txtG.Text == "")
                {
                    m = int.Parse(txtM.Text);
                }

                else if (txtM.Text == "")
                {
                    g = int.Parse(txtG.Text);
                    m = (int)Math.Pow(2, g);
                    txtM.Text = m.ToString();
                }

                if (primeraVuelta == true)
                {
                    x = int.Parse(txtRaiz.Text);
                }
                else
                {
                    int col = 1;

                    int registros = dgvTabla.RowCount;
                    double rnd = Convert.ToDouble(dgvTabla.Rows[registros - 2].Cells[col].Value);
                    x = int.Parse((rnd * (m)).ToString());
                }
            }
            return new List<int>() { x, a, c, m, k, g };             
        }        

        private double[] ValidarMetodo()
        {
            double[] numeros = new double[20];
            if (bandOk == true)
            {

                if (rbMixto.Checked)

                {
                    var elementos = generarMixto();
                    if (elementos != null)
                    {
                        numeros = cargarTabla(elementos);
                    }
                }

                else if (rbMultiplicativo.Checked)
                {
                    if (txtRaiz.Text != "")
                    {
                        int x = int.Parse(txtRaiz.Text);
                        if (x % 2 == 0)
                        {
                            Exception error = new Exception(message: "La raiz debe ser un numero Impar");
                            throw error;
                        }
                        else
                        {
                            var elementos = generarMultiplicativo();
                            if (elementos != null)
                            {
                                numeros = cargarTabla(elementos);
                            }


                        }
                    }
                    else
                    {
                        var elementos = generarMultiplicativo();
                        if (elementos != null)
                        {
                            numeros = cargarTabla(elementos);
                        }
                    }
                }

                else if (rbAditivo.Checked)
                {
                    var elementos = GenerarAditivo();
                    if (elementos != null)
                    {
                        numeros = cargarTabla(elementos);
                    }
                }

                else
                {
                    Exception error = new Exception(message: "Por favor seleccione un método ");
                    throw error;
                }
            }
            return numeros;
        }
        //Este metodo genera los numeros aleatorios
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            dgvTabla.Rows.Clear();
            dgvMetodo.Rows.Clear();
            chartRnd.Series.Clear();

            try
            {
                if (string.IsNullOrEmpty(txtRaiz.Text) && string.IsNullOrEmpty(txtC.Text) && string.IsNullOrEmpty(txtA.Text) && string.IsNullOrEmpty(txtM.Text))
                {
                    MessageBox.Show("Se usarán los valores por defecto");
                    txtRaiz.Text = "37";
                    txtC.Text = "7";
                    txtA.Text = "19";
                    txtM.Text = "53";
                }
                else
                {
                    ControlarVariables();
                }

                elem = ValidarMetodo();
                int num = 10;
                double[] intervalos = generarIntervalos(num);
                CargarFrecuencia(elem, intervalos);

                btnUnValor.Enabled = true;
                btnVeinte.Enabled = true;
                btnMil.Enabled = true;
                primeraVuelta = true;
                rbAditivo.Enabled = false;
                rbMixto.Enabled = false;
                rbMultiplicativo.Enabled = false;
                txtA.Enabled = false;
                txtC.Enabled = false;
                txtG.Enabled = false;
                txtK.Enabled = false;
                txtM.Enabled = false;
                txtRaiz.Enabled = false;
                btnGenerar.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private double[] cargarTabla(List<int> elements, int vueltas = 20)
        {
            int x = elements[0];
            int a = elements[1];
            int c = elements[2];
            int m = elements[3];
            int k = elements[4];
            int g = elements[5];

            double xAnterior = 0;
            double axc;
            double resto = 0;
            double rnd;
            int inicio = 0;
            //sé que no es lo más prolijo, cuando esté más despierta lo cambio jaja
            int Sumindice = dgvTabla.Rows.Count - 1;

            if (proximo)
            {
                vueltas = 1;
                proximo = false;
            }

            if (proximo20)
            {
                vueltas = 20;
                proximo20 = false;
            }

            if (final)
            {
                //razonar bien si va ese +1 o me lo inventé
                vueltas = 10000 - dgvTabla.Rows.Count + 1;
                final = false;
            }


            double[] numeros = new double[vueltas + 1];

            // ver esto del generador DH

            if (vueltas <= 10000 && generarDH == false)
            {
                for (int i = 1; i <= vueltas; i++)
                {
                    if(rbMixto.Checked || rbMultiplicativo.Checked)
                    {
                        if (i == 1)
                        {

                            axc = a * x + c;
                            resto = axc % m;
                            rnd = resto / m;


                        }
                        else
                        {
                            axc = a * resto + c;
                            resto = axc % m;
                            rnd = resto / m;

                        }
                    }
                    else
                    {
                        if (i == 1)
                        {
                            axc = x;
                            resto = axc % m;
                            rnd = resto / m;
                            xAnterior = x;
                        }
                        else
                        {
                            xAnterior = resto;
                            axc = resto + xAnterior;
                            resto = axc % m;
                            rnd = resto / m;
                        }
                    }

                    dgvTabla.Rows.Add((i + Sumindice), rnd);
                    numeros[i] = rnd;

                }

            }
            else if (generarDH == true)
            {
                for (int i = inicio; i <= vueltas; i++)
                {
                    if (rbMixto.Checked || rbMultiplicativo.Checked)
                    {
                        if (i == inicio)
                        {

                            axc = a * x + c;
                            resto = axc % m;
                            rnd = resto / m;

                        }
                        else
                        {
                            axc = a * resto + c;
                            resto = axc % m;
                            rnd = resto / m;

                        }

                    }
                    else
                    {
                        if (i == inicio)
                        {
                            axc = x;
                            resto = axc % m;
                            rnd = resto / m;
                            xAnterior = x;
                        }
                        else
                        {
                            xAnterior = resto;
                            axc = resto + xAnterior;
                            resto = axc % m;
                            rnd = resto / m;
                        }

                    }


                    dgvTabla.Rows.Add((i + Sumindice), rnd);
                    numeros[i] = rnd;
                }
                generarDH = false;
            }
            else
            {
                throw new Exception(message: "No se pueden generar mas numeros");
            }

            return numeros;

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            primeraVuelta = true;
            txtRaiz.Clear();
            txtA.Clear();
            txtC.Clear();
            txtG.Clear();
            txtK.Clear();
            txtM.Clear();
            rbMixto.Checked = false;
            rbMultiplicativo.Checked = false;
            dgvTabla.Rows.Clear();
            dgvMetodo.Rows.Clear();
            chartRnd.Series.Clear();
            btnUnValor.Enabled = false;
            btnVeinte.Enabled = false;
            btnMil.Enabled = false;

            rbAditivo.Enabled = true;
            rbMixto.Enabled = true;
            rbMultiplicativo.Enabled = true;
            txtA.Enabled = true;
            txtC.Enabled = true;
            txtG.Enabled = true;
            txtK.Enabled = true;
            txtM.Enabled = true;
            txtRaiz.Enabled = true;
            btnGenerar.Enabled = true;
        }

        private void CargarFrecuencia(double[] numeros, double[] intervalos)
        {
            int[] frecuencias = new int[intervalos.Length];

            for (int i = 0; i < numeros.Length; i++)
            {
                for (int j = 0; j < intervalos.Length; j++)
                {
                    if (j == 0)
                    {
                        if (numeros[i] <= intervalos[j])
                            frecuencias[j]++;
                    }
                    else
                    {
                        if (intervalos[j - 1] < numeros[i] && numeros[i] <= intervalos[j])
                            frecuencias[j]++;
                    }
                }
            }

            for (int i = 0; i < intervalos.Length; i++)
            {
                if (i == 0)
                {

                    dgvMetodo.Rows.Add(0, intervalos[i], frecuencias[i] - 1, (double)(frecuencias[i] - 1)/ (double)(numeros.Length - 1));
                }
                else
                {
                    dgvMetodo.Rows.Add(intervalos[i - 1], intervalos[i], frecuencias[i], (double)(frecuencias[i]) / (double)(numeros.Length - 1));
                }
            }
            //Esta ultima sección de la función, grafica la tabla de frecuencia
            chartRnd.ChartAreas[0].AxisY.Minimum = 0;
            chartRnd.ChartAreas[0].AxisY.Maximum = numeros.Length/4;
            Series serie_resultante = chartRnd.Series.Add("RND");
            this.chartRnd.ChartAreas[0].AxisY.Title = "Fo";
            this.chartRnd.ChartAreas[0].AxisX.Title = "Intervalo";
            chartRnd.Series[0].IsValueShownAsLabel = true;
            for (int j = 0; j < intervalos.Length; j++)
            {
                if (j == 0)
                {
                    serie_resultante.Points.AddXY(intervalos[j], frecuencias[j] - 1);
                }
                else
                {
                    serie_resultante.Points.AddXY(intervalos[j], frecuencias[j]); ;
                }
            }
        }
        public double[] generarIntervalos(int num)
        {
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
            }

            return intervalos;

        }

        // los métodos "KeyPress" sirven para que el usuario no ingrese letras o simbolos
        private void txt_KeyPress(object sender, KeyPressEventArgs e)
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


        private void btnUnValor_Click(object sender, EventArgs e)
        {
            try
            {
                primeraVuelta = false;
                proximo = true;

                ControlarVariables();
                dgvMetodo.Rows.Clear();
                chartRnd.Series.Clear();

                elem = elem.Concat(ValidarMetodo()).ToArray();
                CargarFrecuencia(elem, generarIntervalos(10));
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnVeinte_Click(object sender, EventArgs e)
        {
            try
            {
                proximo20 = true;
                ControlarVariables();
                dgvMetodo.Rows.Clear();
                chartRnd.Series.Clear();
               
                elem = elem.Concat(ValidarMetodo()).ToArray();

            }            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnMil_Click(object sender, EventArgs e)
        {
            try
            {
                final = true;
                ControlarVariables();
                dgvMetodo.Rows.Clear();
                chartRnd.Series.Clear();
                
                elem = elem.Concat(ValidarMetodo()).ToArray();

                CargarFrecuencia(elem, generarIntervalos(10));
            }            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}

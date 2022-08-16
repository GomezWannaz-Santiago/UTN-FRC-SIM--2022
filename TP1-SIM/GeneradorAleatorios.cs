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
        public GeneradorAleatorios()
        {
            InitializeComponent();            
        }
        // Verificamos que lo ingresado en el txt sea un numero
        //creo que lo de validar que sea número ya no hacia falta por una funcion que habia puesto yo para que no acepte letras (KeyPress) (mari)
        private int validarVariables(string variable)
        {
            if (int.TryParse(variable, out int resultado)) {

                //verificamos que el numero es positivo
                if (resultado > 0)
                {
                    return resultado;
                }
            }

            return -1;
        }
     
        //mari para validar que ya esta el generar
        private void controlarVariables()
        {


            if (validarVariables(txtRaiz.Text) == -1)
            {
                MessageBox.Show("Error la Raiz \"X0\" debe ser entero y mayor a cero");
                return;
            }
            else if (rbMixto.Checked)
            {
                if (validarVariables(txtC.Text) == -1)
                {
                    MessageBox.Show("Error la constante \"c\" debe ser entero y mayor a cero");
                    return;

                }
            }

            // AL SER SOLO 20 VALORES AHORA YA ESTÁ DE MÁS LA VALIDACIÓN (mari)
            //if (txt_valores.Text == "")
            //{
            //    MessageBox.Show("DEBE COMPLETAR EL CAMPO CANTIDAD DE VALORES A GENERAR");
            //    return;

            //}
            if (txtK.Text == "" && txtA.Text == "")
            {
                MessageBox.Show("DEBE COMPLETAR EL CAMPO DE LOS VALORES A O K OBLIGATORIAMENTE");
                return;

            }
            else if (txtK.Text == "")
            {
                if (validarVariables(txtA.Text) == -1)
                {
                    MessageBox.Show("Error la constante \"a\" debe ser entero y mayor a cero");
                    return;
                }
            }
            else if (txtA.Text == "")
            {
                if (validarVariables(txtK.Text) == -1)
                {
                    MessageBox.Show("Error el numero \"k\" debe ser entero y mayor a cero");
                    return;
                }

            }

            if (txtM.Text == "" && txtG.Text == "")
            {
                MessageBox.Show("DEBE COMPLETAR EL CAMPO DE LOS VALORES M O G OBLIGATORIAMENTE");
                return;

            }
            else if (txtM.Text == "")
            {
                if (validarVariables(txtG.Text) == -1)
                {
                    MessageBox.Show("Error el numero \"g\" debe ser entero y mayor a cero");
                    return;
                }

            }
            else if (txtG.Text == "")
            {
                if (validarVariables(txtM.Text) == -1)
                {
                    MessageBox.Show("Error el modulo \"m\" debe ser entero y mayor a cero");
                    return;
                }


            }

            //esto de las banderas podría borrarse porque ya no lo usamos (mari)
            if (bandOk == false)
            {
                bandOk = true;
            }
        }

        // ya no va (mari)
        //private int cantidadIntervalos()
        //{
        //    int num;

        //    if (rb5.Checked)
        //    {
        //        num = 5;

        //    }
        //    else if (rb8.Checked)
        //    {
        //        num = 8;

        //    }
        //    else if (rb15.Checked)
        //    {
        //        num = 10;

        //    }
        //    else
        //    {
        //        num = 12;

        //    }

        //    return num;
        //}

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
                        controlarVariables();
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
                            //
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
                    }
                }

                List<int> elementos = new List<int>();
                elementos.Add(x);
                elementos.Add(a);
                elementos.Add(c);
                elementos.Add(m);
                elementos.Add(k);
                elementos.Add(g);

                return elementos;

            }
            else
            {
                return null;
            }

            
        }
        private List<int> generarMultiplicativo()
        {
            int x = 37;
            int c = 0;
            int a = 19;
            int m = 53;
            int k = 0;
            int g = 0;
            
            if (txtRaiz.Text != "" && txtA.Text != "" && txtM.Text != "")
            {
                x = int.Parse(txtRaiz.Text);

                c = 0;
                a = 0;
                m = 0;
                k = 0;
                g = 0;


                if ((txtK.Text == "" && txtA.Text == "") || (txtM.Text == "" && txtG.Text == ""))
                {
                    controlarVariables();
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
            
            List<int> elementos = new List<int>();
            elementos.Add(x);
            elementos.Add(a);
            elementos.Add(c);
            elementos.Add(m);
            elementos.Add(k);
            elementos.Add(g);

            return elementos;


        }

        private double[] validarMetodo()
        {
            //double[] numeros = new double[int.Parse(txt_valores.Text)];
            // cambie por 20 igual ver si es necesario pasarlo a double o poner 20,0000 (mari)
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
                            Exception raizPar = new Exception(message: "La raiz debe ser un numero Impar");
                            throw raizPar;
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
                else
                {
                    Exception raizPar = new Exception(message: "Por favor seleccione un método ");
                    throw raizPar;
                }

            }
            return numeros;
        }
        //Este metodo genera los numeros aleatorios
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            dgvTabla.Rows.Clear();
            dgvMetodo.Rows.Clear();
            //controlarVariables();
            chartRnd.Series.Clear();

            double[] elem;

            try
            {
                elem = validarMetodo();
                int num = 10;
                double[] intervalos = generarIntervalos(num);
                CargarFrecuencia(elem, intervalos);

                btnUnValor.Enabled = true;
                btnVeinte.Enabled = true;
                btnMil.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        
       
        private double[] cargarTabla(List<int> elements )
        {
            int x = elements[0];
            int a = elements[1];
            int c = elements[2];
            int m = elements[3];
            int k = elements[4];
            int g = elements[5];

            double axc;
            double resto = 0;
            double rnd;
            // int vueltas = Convert.ToInt32(txt_valores.Text);
            // Acá agregue lo de los 20 valores a generar y borré la selección del usuario (mari)
            int vueltas = 20 ;
            int inicio = 0;
            

            try
            {
                if (proximo == true)
                {
                    vueltas = dgvTabla.Rows.Count;
                    dgvTabla.Rows.Clear();
                    proximo = false;
                }

                if (proximo20 == true)
                {
                    vueltas = dgvTabla.Rows.Count + 19;
                    dgvTabla.Rows.Clear();
                    proximo20 = false;
                }

                if (final == true)
                {
                    vueltas = 50000;
                    dgvTabla.Rows.Clear();
                    final = false;
                }
            }
            catch (Exception xx)
            {

                MessageBox.Show("Error: " + xx);
                throw;
            }

            double[] numeros = new double[vueltas + 1];

            if (vueltas <= 50000 && generarDH == false)
            {
                for (int i = 1; i <= vueltas; i++)
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

                    dgvTabla.Rows.Add(i, rnd);
                    numeros[i] = rnd;

                }

            }
            else if(generarDH == true){
                for (int i = inicio; i <= vueltas; i++)
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

                    
                    dgvTabla.Rows.Add(i, rnd);
                    numeros[i] = rnd;
                }
                generarDH = false;
            }
            else
            {
                MessageBox.Show("No se pueden generar mas numeros");
            }

            return numeros;

        }

        
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();         
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
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


        }

        // BORRAR SI NO LO LLEGO A USAR !!!!!!!!!!!!!!!
        private void limpiar()
        {
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
                        {
                            frecuencias[j]++;
                            
                        }
                        
                    }
                    else
                    {
                        if (intervalos[j - 1] < numeros[i] && numeros[i] <= intervalos[j])
                        {
                            frecuencias[j]++;
                        }
                    }


                }

                


            }

            for (int i = 0; i < intervalos.Length; i++)
            {


                if (i == 0)
                {
                    dgvMetodo.Rows.Add(0, intervalos[i], frecuencias[i] - 1);
                }
                else
                {
                    dgvMetodo.Rows.Add(intervalos[i - 1], intervalos[i], frecuencias[i]); 
                }
                

            }
            //Esta ultima sección de la función, grafica la tabla de frecuencia
            chartRnd.ChartAreas[0].AxisY.Minimum = 0;
            Series serie_resultante = chartRnd.Series.Add("RND");
            this.chartRnd.ChartAreas[0].AxisY.Title = "Fo";
            this.chartRnd.ChartAreas[0].AxisX.Title = "Intervalo";
            chartRnd.Series[0].IsValueShownAsLabel = true;
            for (int j = 0; j < intervalos.Length; j++)
            {
                serie_resultante.Points.AddXY(intervalos[j], frecuencias[j]);

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
                Console.WriteLine(intervalos[i]);
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
    }
}

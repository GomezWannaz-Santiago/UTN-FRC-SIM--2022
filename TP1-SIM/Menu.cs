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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnGenerarAlea_Click(object sender, EventArgs e)
        {
            GeneradorAleatorios g = new GeneradorAleatorios();
            g.ShowDialog();
        }

        private void btnTestChi_Click(object sender, EventArgs e)
        {
            TestChiCuadrado t  = new TestChiCuadrado();
            t.ShowDialog();
      
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            Menu menu = new Menu();
           
            //menu.CenterToScreen();
        }

        private void btnTestKS_Click(object sender, EventArgs e)
        {
            TestKS t = new TestKS();
            t.ShowDialog();
        }
    }
}

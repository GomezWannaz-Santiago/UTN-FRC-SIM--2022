using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_SIM
{
    class PruebaChiCuadrado : IComparable
    {
        public double LimInf { get; set; }

        public double LimSup { get; set; }

        public double FrecObs { get; set; }

        public double FrecEsp { get; set; }

        public double c { get; set; }

        // Comparador para poder usar .Max()
        public int CompareTo(object obj)
        {
            var fila = (PruebaChiCuadrado)obj;
            if (fila.LimInf < this.LimInf) 
                return -1;
            if (fila.LimInf > this.LimInf) 
                return 1;
            else return 0;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_2
{
    internal class Almuerzo
    {
        private string sopa;
        private string segundo;
        private string postre;
        private double costo;
        public Almuerzo(string sopa, string segundo, string postre, double costo) {
            this.sopa = sopa;
            this.segundo = segundo;
            this.postre = postre;
            this.costo = costo;
        }
        public void mostrarAlmuerzo()
        {
            Console.WriteLine("---Almuerzo---");
            Console.WriteLine("Sopa: " + this.sopa + "\nSegundo: " + this.segundo + "\nPostre: " + this.postre + "\nCosto: "+this.costo);
        }
        public string Sopa { get => sopa; set => sopa = value; }
        public string Segundo { get => segundo; set => segundo = value; }
        public string Postre { get => postre; set => postre = value; }
        public double Costo { get => costo; set => costo = value; }

    }
}

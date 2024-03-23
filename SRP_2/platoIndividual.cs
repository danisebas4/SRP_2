using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISRP
{
    internal class PlatoIndividual
    {
        private double costo;
        private string tipo;
        private string nombre;
        public PlatoIndividual(string nombre, string tipo, double costo) {
            this.nombre = nombre;
            this.tipo = tipo;
            this.costo = costo;
        }
        public void imprimirPlatoIndividual() {
            Console.WriteLine("Nombre: " + this.nombre+"\nTipo: "+this.tipo+"\nCosto: "+this.costo);
        }
        public double Costo { get => costo; set => costo = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
    }
}

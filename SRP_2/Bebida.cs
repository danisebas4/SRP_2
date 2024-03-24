using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_2
{
    internal class Bebida
    {
        private string nombre;
        private double costo; 
        public Bebida(string nombre, double costo)
        {
            this.nombre = nombre;
            this.costo = costo;
        }
        public void mostrarBebida()
        {
            Console.WriteLine("Nombre: " + this.nombre + "\nCosto: " + this.costo);
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public double Costo { get => costo; set => costo = value; }
    }
}

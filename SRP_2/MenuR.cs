using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SRP_2
{
    [Serializable]
    internal class MenuR
    {
        private Dictionary <string, double> sopas;
        private Dictionary <string, double> segundos;
        private Dictionary <string, double> postres;
        private Dictionary <string, double> bebidas;
        private Dictionary<string, double> especiales;
        public MenuR()
        {
            this.sopas = new Dictionary<string, double>();
            this.segundos = new Dictionary<string, double>();
            this.postres = new Dictionary<string, double>();
            this.bebidas = new Dictionary<string, double>();
            this.especiales = new Dictionary<string, double>();
        }
        public MenuR(Dictionary<string, double> sopas,
            Dictionary<string, double> segundos,
            Dictionary<string, double> postres,
            Dictionary<string, double> bebidas,
            Dictionary<string, double> especiales)
        {
            this.sopas = sopas;
            this.segundos = segundos;
            this.postres = postres;
            this.bebidas = bebidas;
            this.especiales = especiales;
        }

       
        public void mostrarMenu()
        {
            Console.WriteLine("========Sopas=======");
            imprimirLista(this.sopas);
            Console.WriteLine("========Segundos=====");
            imprimirLista(this.segundos);
            Console.WriteLine("========Postres=======");
            imprimirLista(this.postres);
            Console.WriteLine("=======Bebidas=======");
            imprimirLista(this.bebidas);
            Console.WriteLine("=======Especiales=====");
            imprimirLista(this.especiales);
        }
        private void imprimirLista(Dictionary<string, double> a)
        {
            foreach (KeyValuePair<string, double> entry in a)
            {
                Console.WriteLine("${Comida: {entry.Key}, Precio: {entry.Value}");
            }
        }

        public Dictionary<string, double> Sopas { get => sopas; set => sopas = value; }
        public Dictionary<string, double> Segundos { get => segundos; set => segundos = value; }
        public Dictionary<string, double> Postres { get => postres; set => postres = value; }
        public Dictionary<string, double> Bebidas { get => bebidas; set => bebidas = value; }
        public Dictionary<string, double> Especiales { get => especiales; set => especiales=value; }
    }
}

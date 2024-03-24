using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace SRP_2
{
    internal class Pedido
    {
        private int nro;
        private List <Almuerzo> alm;
        private List <PlatoIndividual> plInd;
        private string platoEspecial;
        private List <Bebida> bebidas;
        private double costoTotal;

        public Pedido(int nro, List <Almuerzo> alm, List<PlatoIndividual> plInd, List<Bebida> 
            bebida, string platoEspecial,double costoTotal) {

            this.alm = alm;
            this.plInd = plInd;
            this.bebidas = bebida;
            this.platoEspecial = platoEspecial;
        }
        public double totalCosto()
        {
            double costoAlm = 0;
            double costoPlInt = 0;
            double costoBebida = 0;

            for (int i = 0; i < this.alm.Count; i++)
            {
                costoAlm = costoAlm + this.alm[i].Costo;
            }
            for (int i = 0; i < this.plInd.Length; i++)
            {
                costoPlInt = costoPlInt + this.plInd[i].Costo;
            }
            for (int i = 0; i < this.bebidas.Length; i++)
            {
                costoBebida = costoBebida +this.bebidas[i].Costo;
            }
            return costoAlm + costoPlInt + costoBebida;
        }
        public void imprimirPedido() {
            Console.WriteLine(nro + "");
            Console.ReadKey();
        }

    }
}
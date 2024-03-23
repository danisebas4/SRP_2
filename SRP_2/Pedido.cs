using System;

namespace SISRP
{
    internal class Pedido
    {
        private int nro;
        private Almuerzo [] alm;
        private PlatoIndividual [] plInd;
        private Bebida [] bebidas;
        private double costoTotal;
        public Pedido(int nro, Almuerzo [] alm, PlatoIndividual[] plInd, Bebida[] 
            bebida, double costoTotal) {

            this.alm = alm;
            this.plInd = plInd;
            this.bebidas = bebida;
        }
        public double totalCosto()
        {
            double costoAlm = 0;
            double costoPlInt = 0;
            double costoBebida = 0;
            for (int i = 0; i < this.alm.Length; i++)
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
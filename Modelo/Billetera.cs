using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_13_Billetera.Modelo
{
    internal class Billetera
    {
        // Propiedades
        public int billetesDe10 { get; set; }
        public int BilletesDe20 { get; set; }

        public int BilletesDe50 { get; set; }

        public int BilletesDe100 { get; set; }

        public int BilletesDe200 { get; set; }

        public int BilletesDe500 { get; set; }

        public int BilletesDe1000 { get; set; }


        // Constructor 
        public Billetera(int billetesDe10, int billetesDe20, int billetesDe50, int billetesDe100, int billetesDe200, int billetesDe500, int billetesDe1000)
        {
            this.billetesDe10 = billetesDe10; // this. se utiliza para hacer referencia a la propiedad de la clase para no tener que escribir con mayusculas o diferenciar de alguna manera
            BilletesDe20 = billetesDe20;
            BilletesDe50 = billetesDe50;
            BilletesDe100 = billetesDe100;
            BilletesDe200 = billetesDe200;
            BilletesDe500 = billetesDe500;
            BilletesDe1000 = billetesDe1000;
        }

        // Métodos / Funciones
        public decimal Total()      // Sumo total de billetes y sus valores
        {
            return (billetesDe10 * 10) + (BilletesDe20 * 20) + (BilletesDe50 * 50) + (BilletesDe100 * 100) + (BilletesDe200 * 200) + (BilletesDe500 * 500) + (BilletesDe1000 * 1000);
        }

        public decimal BorrarBilleteras() // Borro el total de billetes
        {
            return (billetesDe10 = 0) + (BilletesDe20 = 0) + (BilletesDe50 = 0) + (BilletesDe100 = 0) + (BilletesDe200 = 0) + (BilletesDe500 = 0) + (BilletesDe1000 = 0);
        }
    }
}

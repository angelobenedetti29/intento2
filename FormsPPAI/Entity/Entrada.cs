using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashbord.Entity
{
    public class Entrada
    {
        public DateTime FechaVencimiento { get; set; }
        public DateTime HoraVenta { get; set; }
        public float Monto { get; set; }
        public int Numero { get; set; }
        //public void sonDeFechaHoraSede(int nroEntradas, int nroSede)
        //{
        //    //DataTable tabla = 
        //    //foreach (DataRow tarifa in tarifas.Rows)
        //    //{
        //    //    tarifa.ItemArray[0].ToString();
        //    //    tarifa.ItemArray[1].ToString();
        //    //}
        //}

    }
}

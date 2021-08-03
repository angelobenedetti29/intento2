using Dashbord.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashbord.Entity
{
    public class Tarifa
    {        
        public int MontoAdicionalGuia { get; set; }

        public DataTable mostrarMontosVigentes()
        {
            DataTable tarifas = TarifaAdapter.ReadTarifasWithMontos();
            foreach (DataRow tarifa in tarifas.Rows)
            {
                tarifa.ItemArray[0].ToString();
                tarifa.ItemArray[1].ToString();
            }
            return tarifas;
        }
    }
}

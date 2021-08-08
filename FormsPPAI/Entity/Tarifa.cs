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

        public DataTable mostrarMontosVigentesYNombres(string idTarifa, string idSede)
        {
            DataTable tarifa = TarifaAdapter.ReadTarifaWithMontosVigentesSede(idTarifa, idSede);
            return tarifa;
        }
    }
}

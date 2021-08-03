using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashbord.DataAccessLayer
{
    public class ReservaAdapter
    {
        public static DataTable ObtenerReservas(string idSede) => GeneralAdapter.Query("SELECT * FROM ReservaVisita WHERE idSede = @idSede AND fecha_hora_reserva = '2021-08-03 09:30:00.000'", new Dictionary<string, string>() { { "@idSede", idSede } });
    }
}

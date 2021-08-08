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
        public static DataTable ObtenerReservas() => GeneralAdapter.Query("SELECT * FROM ReservaVisita", new Dictionary<string, string>());
    }
}

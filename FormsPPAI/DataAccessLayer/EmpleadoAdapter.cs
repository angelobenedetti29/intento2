using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashbord.DataAccessLayer
{
    public static class EmpleadoAdapter
    {
        public static int obtenerSedeEmpleado(string idEmpleado) => GeneralAdapter.QueryScalar("SELECT id_sede FROM Empleado WHERE dni = @idEmpleado", new Dictionary<string, string>() { { "@idEmpleado", idEmpleado } });
    }
}

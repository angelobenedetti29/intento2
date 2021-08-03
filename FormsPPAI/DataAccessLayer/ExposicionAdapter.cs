using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashbord.DataAccessLayer
{
	public static class ExposicionAdapter
	{
		public static DataTable ObtenerObrasPorExposicion(string idExposicion) => GeneralAdapter.Query("SELECT o.* FROM Exposicion e JOIN ObraPorExposicion oe ON(e.id = oe.id_exposicion) JOIN Obra o ON(oe.id_obra = o.id) WHERE e.id = @idExpo", new Dictionary<string, string>() { { "@idExpo", idExposicion } });
	}
}

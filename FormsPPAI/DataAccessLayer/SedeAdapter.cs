using Dashbord.DataAccessLayer;
using System.Collections.Generic;
using System.Data;

namespace Dashbord.DataAccessLayer {
	public static class SedeAdapter {
		public static int ReadMaxEntradas(string id) => GeneralAdapter.QueryScalar("SELECT maximo_visitantes FROM Sede WHERE id = @idSede", new Dictionary<string, string>() {{"@idSede", id}});
		
		public static DataTable obtenerExposiciones() => GeneralAdapter.Query("SELECT * FROM Exposicion");
		public static int ObtenerVisitantes(string idSede) => GeneralAdapter.QueryScalar("SELECT cantidad FROM EntradasPorSede WHERE id_sede = @idSede", new Dictionary<string, string>() { { "@idSede", idSede } });


	}
}


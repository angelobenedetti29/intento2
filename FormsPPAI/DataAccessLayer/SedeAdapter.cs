using Dashbord.DataAccessLayer;
using System.Collections.Generic;
using System.Data;

namespace Dashbord.DataAccessLayer {
	public static class SedeAdapter {
		public static int ReadMaxEntradas(string id) => GeneralAdapter.QueryScalar("SELECT maximo_visitantes FROM Sede WHERE id = @idSede", new Dictionary<string, string>() {{"@idSede", id}});
		
		public static DataTable obtenerExposiciones(string idSede) => GeneralAdapter.Query("SELECT e.* FROM Exposicion e JOIN ExposicionPorSede eps ON e.id = eps.id_exposicion WHERE eps.id_sede = @idSede", new Dictionary<string, string>() { { "@idSede", idSede } });
		public static int ObtenerVisitantes(string idSede) => GeneralAdapter.QueryScalar("SELECT cantidad FROM EntradasPorSede WHERE id_sede = @idSede", new Dictionary<string, string>() { { "@idSede", idSede } });

		public static int ReadEntradasDisponibles(string idSede) => GeneralAdapter.QueryScalar("SELECT s.maximo_visitantes - (rv.cant_alumnos_confirmados + es.cantidad) FROM Sede s JOIN ReservaVisita rv ON s.id = rv.idSede JOIN EntradasPorSede es ON es.id_sede = s.id WHERE id_sede = @idSede", new Dictionary<string, string>() { { "@idSede", idSede } });


	}
}


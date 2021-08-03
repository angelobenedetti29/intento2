using System.Collections.Generic;

namespace Dashbord.DataAccessLayer {
	public static class ObraAdapter {
		public static int ReadTiempo(string idObra) => GeneralAdapter.QueryScalar("SELECT duracion_resumida FROM Obra WHERE id = @idObra", new Dictionary<string, string>() { { "@idObra", idObra } });
	}
}

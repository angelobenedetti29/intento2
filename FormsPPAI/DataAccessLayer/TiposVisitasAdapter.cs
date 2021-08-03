using System.Data;

namespace Dashbord.DataAccessLayer {
	public static class TiposVisitasAdapter {
		public static DataTable ReadTiposVisitas() => GeneralAdapter.Query("SELECT * FROM TipoVisita");
	}
}

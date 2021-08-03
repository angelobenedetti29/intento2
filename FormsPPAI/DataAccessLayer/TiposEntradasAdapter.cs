using System.Data;

namespace Dashbord.DataAccessLayer {
	public static class TiposEntradasAdapter {
		public static DataTable ReadTipoEntrada() => GeneralAdapter.Query("SELECT * FROM TipoEntrada");
	}
}

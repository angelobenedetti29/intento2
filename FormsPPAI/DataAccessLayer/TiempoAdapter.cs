namespace Dashbord.DataAccessLayer {
	public static class TiempoAdapter {
		public static int ReadDuracion() => GeneralAdapter.QueryScalar("SELECT SUM(duracion_resumida) FROM Obra");
	}
}

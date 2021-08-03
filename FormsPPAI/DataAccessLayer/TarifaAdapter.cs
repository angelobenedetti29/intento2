using System.Data;

namespace Dashbord.DataAccessLayer {
	public static class TarifaAdapter {
		public static DataTable ReadTarifasWithMontos() => GeneralAdapter.Query("SELECT E.nombre AS tipo_entrada, V.nombre AS tipo_visita, E.monto + V.monto AS precio, T.monto_adicional_guia AS monto_guia FROM Tarifa T JOIN TipoEntrada E ON T.id_tipo_entrada = E.id JOIN TipoVisita V ON T.id_tipo_visita = V.id");
	}
}

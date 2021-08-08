using System.Collections.Generic;
using System.Data;

namespace Dashbord.DataAccessLayer {
	public static class TarifaAdapter {
		public static DataTable ReadTarifaWithMontosVigentesSede(string idTarifa, string idSede) => GeneralAdapter.Query("SELECT E.nombre AS tipo_entrada, V.nombre AS tipo_visita, E.monto + V.monto AS precio, T.monto_adicional_guia AS monto_guia FROM Tarifa T JOIN TipoEntrada E ON T.id_tipo_entrada = E.id JOIN TipoVisita V ON T.id_tipo_visita = V.id WHERE T.id_sede = @idSede AND T.id = @idTarifa AND T.esVigente = 1", new Dictionary<string, string>() { { "@idSede", idSede }, { "@idTarifa", idTarifa } } );
		public static DataTable ReadTarifasSede(string idSede) => GeneralAdapter.Query("SELECT t.id, t.id_tipo_entrada, t.id_tipo_visita, t.monto_adicional_guia FROM Tarifa t WHERE t.id_sede = @idSede", new Dictionary<string, string>() { { "@idSede", idSede } });
		public static int ReadTarifaPuntual(string idSede, string idTipoEntrada, string idTipoVisita) => GeneralAdapter.QueryScalar("SELECT t.id FROM Tarifa t WHERE t.id_sede = @idSede AND t.id_tipo_entrada = @idTipoEntrada AND t.id_tipo_visita = @idVisita", new Dictionary<string, string>() { { "@idSede", idSede }, { "@idTipoEntrada", idTipoEntrada }, { "@idVisita", idTipoVisita } });
	}
}

using System;
using System.Collections.Generic;
using System.Data;

namespace Dashbord.DataAccessLayer {
	public static class EntradaAdapter {
		public static int ReadCantEntradas(string idSede) => GeneralAdapter.QueryScalar("SELECT cantidad FROM EntradasPorSede WHERE id_sede = @idSede", new Dictionary<string, string>() { { "@idSede", idSede } });

		public static void UpdateEntradasPorSede(string cantidad, string idSede) => GeneralAdapter.Execute("UPDATE EntradasPorSede SET cantidad = cantidad + @cantidad WHERE id_sede = @idSede", new Dictionary<string, string>() { { "@cantidad", cantidad }, { "@idSede", idSede } });

		public static void UpdateEntradasCompradas(int idTarifa, DateTime fechaHora, float monto) => GeneralAdapter.Execute("INSERT INTO Entrada VALUES (@fecha,@idTarifa,@precio)", new Dictionary<string, string>() { { "@idTarifa", idTarifa.ToString() },{ "@fecha", fechaHora.ToString() }, { "precio", monto.ToString() } });
		public static DataTable ComprobarFechaHoraSede(string idSede, string fechaHoraActual) => GeneralAdapter.Query("SELECT * FROM EntradasPorSede WHERE id_sede = @idSede AND fechaHora = @fechaHora", new Dictionary<string, string>() { { "@idSede", idSede }, { "@fechaHora", fechaHoraActual } });
		public static int GetUltimoNro() => GeneralAdapter.QueryScalar("SELECT MAX(id) + 1 FROM Entrada", new Dictionary<string, string>());

	}
}

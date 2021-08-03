using System;
using System.Collections.Generic;
using System.Data;

namespace Dashbord.DataAccessLayer {
	public static class EntradaAdapter {
		public static int ReadCantEntradas(string idSede) => GeneralAdapter.QueryScalar("SELECT cantidad FROM EntradasPorSede WHERE id_sede = @idSede", new Dictionary<string, string>() { { "@idSede", idSede } });

		public static void UpdateEntradas(string cantidad) => GeneralAdapter.Execute("UPDATE EntradasPorSede SET cantidad = cantidad + @cantidad WHERE id_sede = 1", new Dictionary<string, string>() { { "@cantidad", cantidad } });

		public static void UpdateEntradasCompradas(int precio) => GeneralAdapter.Execute("INSERT INTO Entrada VALUES (fecha, precio)", new Dictionary<string, string>() { { "fecha", DateTime.Now.ToString() }, { "precio", precio.ToString() } });
	//	public static DataTable obtenerEntradas() => GeneralAdapter.Query("SELECT ");
	}
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Dashbord.DataAccessLayer {
	public static class GeneralAdapter {
		public static DataTable Query(string query) {
			using (var conn = new SqlConnection(System.Configuration.ConfigurationManager.AppSettings["ConnectionString"]))
			using (var cmd = new SqlCommand(query, conn))
			using (var adapter = new SqlDataAdapter(cmd)) {
				conn.Open();

				var table = new DataTable();
				adapter.Fill(table);

				return table;
			}
		}

		public static DataTable Query(string query, Dictionary<string, string> parameters) {
			using (var conn = new SqlConnection(System.Configuration.ConfigurationManager.AppSettings["ConnectionString"]))
			using (var cmd = new SqlCommand(query, conn))
			using (var adapter = new SqlDataAdapter(cmd)) {
				conn.Open();

				foreach (var item in parameters) cmd.Parameters.AddWithValue(item.Key, item.Value);

				var table = new DataTable();
				adapter.Fill(table);

				return table;
			}
		}

		public static int QueryScalar(string query) {
			using (var conn = new SqlConnection(System.Configuration.ConfigurationManager.AppSettings["ConnectionString"]))
			using (var cmd = new SqlCommand(query, conn)) {
				conn.Open();

				return cmd.ExecuteScalar() == null ? 0 : int.Parse(cmd.ExecuteScalar().ToString());
			}
		}

		public static int QueryScalar(string query, Dictionary<string, string> parameters) {
			using (var conn = new SqlConnection(System.Configuration.ConfigurationManager.AppSettings["ConnectionString"]))
			using (var cmd = new SqlCommand(query, conn)) {
				conn.Open();

				foreach (var item in parameters) cmd.Parameters.AddWithValue(item.Key, item.Value);

				return cmd.ExecuteScalar() == null ? 0 : int.Parse(cmd.ExecuteScalar().ToString());
			}
		}

		public static void Execute(string query, Dictionary<string, string> parameters) {
			using (var conn = new SqlConnection(System.Configuration.ConfigurationManager.AppSettings["ConnectionString"]))
			using (var cmd = new SqlCommand(query, conn)) {
				conn.Open();

				foreach (var item in parameters) {
					cmd.Parameters.AddWithValue(item.Key, item.Value);
				}

				cmd.ExecuteNonQuery();
			}
		}
	}
}

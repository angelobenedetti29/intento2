using System.Collections.Generic;
using System.Data;

namespace Dashbord.DataAccessLayer {
	public static class UsuarioAdapter {
		public static DataTable ReadUsuarioEnSesion(string idUsuario) => GeneralAdapter.Query("SELECT e.*, s.id AS 'IdSesion' FROM Usuario u JOIN Empleado e ON u.id_empleado = e.dni JOIN Sesion s ON u.id = s.id_usuario WHERE u.id = @idUsuario", new Dictionary<string, string>() { { "@idUsuario", idUsuario } });

		public static int ReadIDUsuario(string username, string password) => GeneralAdapter.QueryScalar("SELECT id FROM Usuario WHERE nombre = @nombre AND contraseña = @password", new Dictionary<string, string>() { { "@nombre", username }, { "@password", password } });

		public static DataTable ReadUsuarioExiste(string username, string password) => GeneralAdapter.Query("SELECT * FROM Usuario WHERE nombre = @nombre AND contraseña = @password", new Dictionary<string, string>() { { "@nombre", username }, { "@password", password } });

		public static DataTable ReadCargo(string idUsuario) => GeneralAdapter.Query("SELECT C.nombre FROM Usuario U JOIN Empleado E ON U.id_empleado = E.dni JOIN Cargo C ON E.id_cargo = C.id WHERE U.id = @idUsuario", new Dictionary<string, string>() { { "@idUsuario", idUsuario } });

		public static DataTable ReadSede(string idUsuario) => GeneralAdapter.Query("SELECT S.nombre FROM Usuario U JOIN Empleado E ON U.id_empleado = E.dni JOIN Sede S ON E.id_sede = S.id WHERE U.id = @idUsuario", new Dictionary<string, string>() { { "@idUsuario", idUsuario } });
	}
}

using System.Collections.Generic;
using System.Data;

namespace Dashbord.DataAccessLayer {
	public static class UsuarioAdapter {
		public static DataTable ReadUsuarioEnSesion(string username, string password) => GeneralAdapter.Query("SELECT e.*, s.id AS 'IdSesion' FROM Usuario u JOIN Empleado e ON u.id_empleado = e.dni JOIN Sesion s ON u.id = s.id_usuario WHERE u.nombre = @username AND u.contraseña = @password", new Dictionary<string, string>() { { "@username", username }, { "@password", password } });

		public static DataTable ReadCargo(string username) => GeneralAdapter.Query("SELECT C.nombre FROM Usuario U JOIN Empleado E ON U.id_empleado = E.dni JOIN Cargo C ON E.id_cargo = C.id WHERE U.nombre = @username", new Dictionary<string, string>() { { "@username", username } });

		public static DataTable ReadSede(string username) => GeneralAdapter.Query("SELECT S.nombre FROM Usuario U JOIN Empleado E ON U.id_empleado = E.dni JOIN Sede S ON E.id_sede = S.id WHERE U.nombre = @username", new Dictionary<string, string>() { { "@username", username } });
	}
}

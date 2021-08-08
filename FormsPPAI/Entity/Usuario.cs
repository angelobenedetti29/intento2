using System;
using System.Data;
using Dashbord.DataAccessLayer;

namespace Dashbord.Entity
{
    public class Usuario
    {
        public int Caducidad { get; set; }
        public string Contraseña { get; set; }
        public string Nombre { get; set; }
        public Tuple<Empleado,int> obtenerEmpleado(int idUsuario)
        {
            DataTable tabla = new DataTable();
            tabla = UsuarioAdapter.ReadUsuarioEnSesion(idUsuario.ToString());
            Empleado empleado = new Empleado();
            empleado.Dni = int.Parse(tabla.Rows[0][0].ToString());
            empleado.Nombre = tabla.Rows[0][1].ToString();
            empleado.Apellido = tabla.Rows[0][2].ToString();
            if (tabla.Rows[0][3].ToString() == "")
            {
                empleado.CodigoValidacion = 0;
            }
            else
            {
                empleado.CodigoValidacion = int.Parse(tabla.Rows[0][3].ToString());
            }
            empleado.Cuit = tabla.Rows[0][4].ToString();
            empleado.Domicilio = tabla.Rows[0][5].ToString();
            DateTime fecha = DateTime.Parse(tabla.Rows[0][6].ToString());
            empleado.FechaNacimiento = fecha;
            DateTime fechaIngreso = DateTime.Parse(tabla.Rows[0][7].ToString());
            empleado.FechaIngreso = fechaIngreso;
            empleado.Email = tabla.Rows[0][8].ToString();
            empleado.EsHombre = bool.Parse(tabla.Rows[0][9].ToString());
            empleado.Telefono = tabla.Rows[0][10].ToString();
            empleado.IdCargo = int.Parse(tabla.Rows[0][11].ToString());
            empleado.IdSede = int.Parse(tabla.Rows[0][12].ToString());
            int idSesion = int.Parse(tabla.Rows[0][13].ToString());
            var tupla = new Tuple<Empleado, int>(empleado, idSesion);
            return tupla;
        }
    }
}


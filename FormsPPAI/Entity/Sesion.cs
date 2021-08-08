using System;
using System.Data;
using Dashbord.Entity;

namespace Dashbord.Entity
{
    public class Sesion
    {
        public DateTime FechaFin { get; set; }
        public DateTime FechaInicio { get; set; }
        public Tuple<Empleado,int> getEmpleadoEnSesion(int idUsuario)
        {
            var userEnSesion = new Usuario();
            var tupla = userEnSesion.obtenerEmpleado(idUsuario);
            return tupla;
        }
    }
}

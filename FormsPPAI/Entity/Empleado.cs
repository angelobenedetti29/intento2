using System;
using Dashbord.DataAccessLayer;


namespace Dashbord.Entity
{
    public class Empleado
    {
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public int Dni { get; set; }
        public int CodigoValidacion { get; set; }
        public string Domicilio { get; set; }
        public string Cuit { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string Email { get; set; }
        public bool EsHombre { get; set; }
        public string Telefono { get; set; }
        public int IdCargo { get; set; }
        public int IdSede { get; set; }

        public int obtenerSede(int idEmpleado)
        {
            int sedeEmpleado = EmpleadoAdapter.obtenerSedeEmpleado(idEmpleado.ToString());
            return sedeEmpleado;
        }
    }
}

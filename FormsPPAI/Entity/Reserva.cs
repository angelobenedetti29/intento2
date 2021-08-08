using Dashbord.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashbord.Entity
{
    public class Reserva
    {
        public int CantidadAlumnos { get; set; }
        public int CantidadAlumnosConfirmados { get; set; }
        public int DuracionEstimada { get; set; }
        public DateTime FechaHoraCreacion { get; set; }
        public DateTime FechaHoraReserva { get; set; }
        public string HoraFinReal { get; set; }
        public string HoraInicioReal { get; set; }
        public int NroReserva { get; set; }

        public bool sonParaFechaHoraSede(Reserva reserva, int Sede, int sedeReserva, DateTime fechaHoraActual)
        {
            bool es = false;
            if (Sede == sedeReserva && reserva.FechaHoraReserva == fechaHoraActual)
            {
                es = true;
            }
            return es;
        }


    }
}

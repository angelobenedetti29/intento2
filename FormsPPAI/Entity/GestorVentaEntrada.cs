using Dashbord.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashbord.Entity
{
    public static class GestorVentaEntrada
    {
        public static int Empleado { get; set; }
        public static int Entrada { get; set; }
        public static int ImpresoraEntradas { get; set; }
        public static int PantallaEntrada { get; set; }
        public static int PantallaVentaEntrada { get; set; }
        public static int ReservaVisita { get; set; }
        public static int Sede { get; set; }
        public static int Sesion { get; set; }
        public static int Visita { get; set; }
        public static bool ServicioGuia { get; set; }

        public static Empleado logueado { get; set; }
        public static void opcionVentaEntrada()
        {
            buscarEmpleadoLogueado();
        }
        public static void buscarEmpleadoLogueado()
        {
            var sesion = new Sesion();
            var tupla = sesion.getEmpleadoEnSesion();
            logueado = tupla.Item1;
            Empleado = logueado.Dni;
            Sesion = tupla.Item2;
            buscarSede();
        }
        public static void buscarSede()
        {
            int sede = obtenerSede();
            Sede = sede;
            buscarTarifasDeSede();
        }

        public static int obtenerSede()
        {
            int sede = logueado.IdSede;
            return sede;
        }

        public static void buscarTarifasDeSede()
        {
            var Actual = new Sede();
            DataTable tablaTarifas = Actual.obtenerTarifasVigentes();
            //return sedeActual.obtenerTarifasVigentes();
            string username = "tanomartinoli";
            TarifasSede pantalla = new TarifasSede(username);
            pantalla.mostrarTarifasVigentes(tablaTarifas);
            pantalla.ShowDialog();
        }
        public static void tomarSeleccionTarifa(int idEntrada, int idVisita, bool servicioGuia)
        {
            Entrada = idEntrada;
            Visita = idVisita;
            ServicioGuia = servicioGuia;
            buscarExposicionVigente();
            new ElegirEntradas(idEntrada, idVisita, servicioGuia, Sede).ShowDialog();
        }

        public static void buscarExposicionVigente()
        {
            var Actual = new Sede();
            var duracionesObra = Actual.calcularDuracionExposicionesVigentes();
        }
        public static void tomarCantidadEntradas(int nroEntradas)
        {
            int capacidad = buscarCapacidadSede();
            obtenerFechaHoraActual();
            int cantidadVisitantes = buscarVisitantesEnSede(Sede);
            var reservaEnFechaHoraSede = buscarReservasParaAsistir();
            ReservaVisita = reservaEnFechaHoraSede.NroReserva;
            bool loSupero = validarLimiteVisitantes(capacidad, cantidadVisitantes, reservaEnFechaHoraSede, nroEntradas);
            if (loSupero)
            {
                mensaje();
            }
            else
            {
                int precioTotal = calcularTotalVenta(nroEntradas);
                DetalleEntradas ventana = new DetalleEntradas("tanomartinoli", Entrada.ToString(), Visita.ToString(), ServicioGuia, nroEntradas, precioTotal, Sede);
                ventana.ShowDialog();
            }
        }

        private static int calcularTotalVenta(int nroEntradas)
        {
            int precioTotal = nroEntradas* PrecioAdapter.ReadPrecio(Entrada.ToString(), Visita.ToString(), ServicioGuia ? "true" : "false", Sede.ToString());
            return precioTotal;
        }

        private static bool validarLimiteVisitantes(int capacidad, int cantidadVisitantes, Reserva reserva, int nroEntradas)
        {
            bool loSupero = false;
            int cantidadConfirmados = int.Parse(reserva.CantidadAlumnosConfirmados.ToString());
            int capacidadActual = capacidad - (cantidadVisitantes + cantidadConfirmados);
            if (nroEntradas > capacidadActual)
            {
                loSupero = true;
            }
            return loSupero;
        }

        public static Reserva buscarReservasParaAsistir()
        {
            DataTable tablaReservas = ReservaAdapter.ObtenerReservas(Sede.ToString());
            DataTable tablaReservasSede = tablaReservas.Clone();
            Reserva reservaConfirmada = new Reserva();
            foreach(DataRow reservas in tablaReservas.Rows)
            {
                Reserva reserva = new Reserva();
                reserva.CantidadAlumnos = int.Parse(reservas.ItemArray[1].ToString());
                reserva.CantidadAlumnosConfirmados = int.Parse(reservas.ItemArray[2].ToString());
                reserva.DuracionEstimada = int.Parse(reservas.ItemArray[5].ToString());
                reserva.FechaHoraCreacion = DateTime.Parse(reservas.ItemArray[3].ToString());
                reserva.FechaHoraReserva = DateTime.Parse(reservas.ItemArray[4].ToString());
                reserva.HoraFinReal = reservas.ItemArray[7].ToString();
                reserva.HoraInicioReal = reservas.ItemArray[6].ToString();
                reserva.NroReserva = int.Parse(reservas.ItemArray[0].ToString());
                int sedeReserva = int.Parse(reservas.ItemArray[8].ToString());
                bool es = reserva.sonParaFechaHoraSede(reserva, Sede, sedeReserva);
                if (es)
                {
                    reservaConfirmada = reserva;
                }
            }
            return reservaConfirmada;
        }

        private static void mensaje()
        {
            MessageBox.Show("El nro de entradas que desea comprar supera el limite. Intentelo de nuevo");
        }

        public static void obtenerFechaHoraActual()
        {
            DateTime fechaHoraActual = DateTime.Now;
        }

        public static int buscarVisitantesEnSede(int Sede)
        {
            var entrada = new Entrada();
            int visitantes = SedeAdapter.ObtenerVisitantes(Sede.ToString());
            return visitantes;
        }

        public static int buscarCapacidadSede()
        {
            var Actual = new Sede();
            int cantidadMaxima = Actual.mostrarCantidadMaximaVisitantes(Sede);
            return cantidadMaxima;
        }
    }
}

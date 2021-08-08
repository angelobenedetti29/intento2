using Dashbord.DataAccessLayer;
using Dashbord.Forms;
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
        public static int Usuario { get; set; }
        public static int ImpresoraEntradas { get; set; }
        public static int PantallaEntrada { get; set; }
        public static int PantallaVentaEntrada { get; set; }
        public static int ReservaVisita { get; set; }
        public static int Sede { get; set; }
        public static int Sesion { get; set; }
        public static int Visita { get; set; }
        public static bool ServicioGuia { get; set; }
        public static int DuracionObras { get; set; }

        //public static Empleado logueado { get; set; }
        public static void opcionVentaEntrada(int idUsuario)
        {
            Usuario = idUsuario;
            buscarEmpleadoLogueado();
        }
        public static void buscarEmpleadoLogueado()
        {
            var actual = new Sesion();
            var tupla = actual.getEmpleadoEnSesion(Usuario);
            //logueado = tupla.Item1;
            Empleado = tupla.Item1.Dni;
            Sesion = tupla.Item2;
            buscarSede();
        }
        public static void buscarSede()
        {
            Empleado logueado = new Empleado();
            int sede = logueado.obtenerSede(Empleado);
            Sede = sede;
            buscarTarifasDeSede();
        }

        public static void buscarTarifasDeSede()
        {
            var Actual = new Sede();
            DataTable tablaTarifas = Actual.obtenerTarifasVigentes(Sede);
            TarifasSede pantalla = new TarifasSede(Usuario);
            pantalla.mostrarTarifasVigentes(tablaTarifas);
            pantalla.ShowDialog();
        }
        public static void tomarSeleccionTarifa(int idEntrada, int idVisita, bool servicioGuia)
        {
            Entrada = idEntrada;
            Visita = idVisita;
            ServicioGuia = servicioGuia;
            buscarExposicionVigente();
            new ElegirEntradas(Entrada, Visita, ServicioGuia, Sede, Usuario).ShowDialog();
        }

        public static void buscarExposicionVigente()
        {
            var Actual = new Sede();
            var duracionesObrasExposicionesVigentes = Actual.calcularDuracionExposicionesVigentes(Sede);
            DuracionObras = duracionesObrasExposicionesVigentes;
        }
        public static void tomarCantidadEntradas(int nroEntradas)
        {
            int capacidad = buscarCapacidadSede();
            var fechaHoraActual = obtenerFechaHoraActual();
            int cantidadVisitantes = buscarVisitantesEnSede(Sede, fechaHoraActual);
            int reservaAlumnosConfirmados = buscarReservaParaAsistir(Sede, fechaHoraActual);
            bool loSupero = validarLimiteVisitantes(capacidad, cantidadVisitantes, reservaAlumnosConfirmados, nroEntradas);
            if (loSupero)
            {
                new ElegirEntradas().mensajeUsuario();
            }
            else
            {
                int precioTotal = calcularTotalVenta(nroEntradas);
                DetalleEntradas ventana = new DetalleEntradas(Usuario, Entrada.ToString(), Visita.ToString(), ServicioGuia, nroEntradas, precioTotal, Sede);
                ventana.ShowDialog();
            }
        }

        private static int calcularTotalVenta(int nroEntradas)
        {
            int precioTotal = nroEntradas* PrecioAdapter.ReadPrecio(Entrada.ToString(), Visita.ToString(), ServicioGuia ? "true" : "false", Sede.ToString());
            return precioTotal;
        }

        private static bool validarLimiteVisitantes(int capacidad, int cantidadVisitantes, int alumnosConfirmados, int nroEntradas)
        {
            bool loSupero = false;
            int capacidadActual = capacidad - (cantidadVisitantes + alumnosConfirmados);
            if (nroEntradas > capacidadActual)
            {
                loSupero = true;
            }
            return loSupero;
        }

        public static int buscarReservaParaAsistir(int Sede, DateTime fechaHoraActual)
        {
            DataTable tablaReservas = ReservaAdapter.ObtenerReservas();
            DataTable tablaReservasSede = tablaReservas.Clone();
            Reserva reservaRelevante = new Reserva();
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
                bool es = reserva.sonParaFechaHoraSede(reserva, Sede, sedeReserva, fechaHoraActual);
                if (es)
                {
                    reservaRelevante = reserva;
                    ReservaVisita = reservaRelevante.NroReserva;
                }
            }
            return reservaRelevante.CantidadAlumnosConfirmados;
        }

        public static DateTime obtenerFechaHoraActual()
        {
            //DateTime fechaHoraActual = DateTime.Now;
            DateTime fechaHoraActual = DateTime.Parse("08/10/2021 11:00"); 
            return fechaHoraActual;
        }

        public static int buscarVisitantesEnSede(int Sede, DateTime fechaHoraActual)
        {
            int visitantes = SedeAdapter.ObtenerVisitantes(Sede.ToString());
            var entrada = new Entrada();
            var son = entrada.sonDeFechaHoraSede(Sede, fechaHoraActual);
            if (son)
            {
                return visitantes;
            }
            else
            {
                return 0;
            }
        }

        public static int buscarCapacidadSede()
        {
            var Actual = new Sede();
            int cantidadMaxima = Actual.mostrarCantidadMaximaVisitantes(Sede);
            return cantidadMaxima;
        }
        public static void tomarConfirmacionVenta(string cantidad, int precioTotal)
        {
            var ultimoNro = buscarUltimoNumeroEntrada();
            generarEntradas(cantidad, precioTotal, ultimoNro);
            new DetalleEntradas().mensajeEntradas();
            imprimirEntradas(int.Parse(cantidad));
        }

        public static void imprimirEntradas(int cantidad)
        {
            new InformeEntrada(cantidad).ShowDialog();
        }

        public static void finCU()
        {
            Application.Exit();
        }

        public static void generarEntradas(string cantidad ,int precioTotal, int ultimoNro)
        {
            float monto = precioTotal / int.Parse(cantidad);
            int idTarifa = TarifaAdapter.ReadTarifaPuntual(Sede.ToString(), Entrada.ToString(), Visita.ToString());
            for (int i = 0; i < int.Parse(cantidad); i++)
            {
                var entrada = new Entrada();
                entrada.HoraVenta = DateTime.Now;
                entrada.FechaVencimiento = DateTime.Parse("08/15/2021 11:00");
                entrada.Numero = ultimoNro;
                entrada.Monto = monto;
                ultimoNro = ultimoNro + 1;
                EntradaAdapter.UpdateEntradasCompradas(idTarifa, entrada.HoraVenta, entrada.Monto);
            }
            EntradaAdapter.UpdateEntradasPorSede(cantidad.ToString(), Sede.ToString());
        }
        public static int buscarUltimoNumeroEntrada()
        {
            return new Entrada().getUltimoNroEntrada();
            //return EntradaAdapter.ReadCantEntradas("1");
        }
        

    }
}

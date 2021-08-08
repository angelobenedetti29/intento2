using Dashbord.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Dashbord.Entity
{
    public class Sede
    {
        bool primerIteracion = true;
        public DataTable obtenerTarifasVigentes(int idSede)
        {
            DataTable tarifas = TarifaAdapter.ReadTarifasSede(idSede.ToString());
            DataTable tarifasVigentes = new DataTable();
            foreach (DataRow tarifa in tarifas.Rows)
            {
                Tarifa tar = new Tarifa();
                DataTable tarifapuntual = tar.mostrarMontosVigentesYNombres(tarifa.ItemArray[0].ToString(),idSede.ToString());
                if (primerIteracion)
                {
                    tarifasVigentes = tarifapuntual.Clone();
                    primerIteracion = false;
                }
                if (tarifapuntual.Rows.Count == 1)
                {
                    tarifasVigentes.ImportRow(tarifapuntual.Rows[0]);
                    tarifapuntual.Rows.Clear();
                }
            }
            return tarifasVigentes;
        }

        public int calcularDuracionExposicionesVigentes(int idSede)
        {
            DataTable tabla_Exposiciones = SedeAdapter.obtenerExposiciones(idSede.ToString());
            DataTable tabla_ExposicionesVigentes = new DataTable();
            tabla_ExposicionesVigentes = tabla_Exposiciones.Clone();
            foreach (DataRow exposicion in tabla_Exposiciones.Rows)
            {
                Exposicion expo = new Exposicion();
                expo.IdExposicion = int.Parse(exposicion.ItemArray[0].ToString());
                expo.FechaFinReal = DateTime.Parse(exposicion.ItemArray[1].ToString());
                expo.FechaFinPlanificada = DateTime.Parse(exposicion.ItemArray[2].ToString());
                expo.FechaInicioReal = DateTime.Parse(exposicion.ItemArray[3].ToString());
                expo.FechaInicioPlanificada = DateTime.Parse(exposicion.ItemArray[4].ToString());
                expo.IdTipo = int.Parse(exposicion.ItemArray[7].ToString());
                expo.IdEstado = int.Parse(exposicion.ItemArray[8].ToString());
                expo.Nombre = exposicion.ItemArray[9].ToString();
                expo.Esvigente = bool.Parse(exposicion.ItemArray[10].ToString());

                bool Vigencia = expo.esVigente(expo.Esvigente);
                if (Vigencia)
                {
                    //var fila = exposicion;
                    tabla_ExposicionesVigentes.ImportRow(exposicion);
                    //tabla_ExposicionesVigentes.Rows.Add(exposicion);
                }
            }
            int duracionObrasExpuestas = 0;
            foreach (DataRow exposicionVigente in tabla_ExposicionesVigentes.Rows)
            {
                Exposicion expov = new Exposicion();
                expov.IdExposicion = int.Parse(exposicionVigente.ItemArray[0].ToString());
                duracionObrasExpuestas = duracionObrasExpuestas + expov.calcularDuracionObrasExpuestas_buscarDuracionObras(expov.IdExposicion.ToString());
            }
            return duracionObrasExpuestas;
        }
        public int mostrarCantidadMaximaVisitantes(int idSede)
        {
            string id = idSede.ToString();
            int cantidadMaxima = SedeAdapter.ReadMaxEntradas(id);
            return cantidadMaxima;
        }
    }
}

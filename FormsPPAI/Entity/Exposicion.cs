using Dashbord.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashbord.Entity
{
    public class Exposicion
    {
        public int IdExposicion { get; set; }
        public DateTime FechaFinReal { get; set; }
        public DateTime FechaFinPlanificada { get; set; }
        public DateTime FechaInicioReal { get; set; }
        public DateTime FechaInicioPlanificada { get; set; }
        public int IdTipo { get; set; }
        public int IdEstado { get; set; }
        public string Nombre { get; set; }
        public bool Esvigente { get; set; }
        public bool esVigente(bool vigencia)
        {
            bool controlVigencia = false;
            if (vigencia)
            {
                controlVigencia = true;
                return controlVigencia;
            }
            else
            {
                controlVigencia = false;
                return controlVigencia;
            }
        }
        public int calcularDuracionObrasExpuestas_buscarDuracionObras(string idExposicion)
        {
            DataTable tabla_obrasPorExposicion = ExposicionAdapter.ObtenerObrasPorExposicion(idExposicion);
            var lista = new List<int>();
            foreach (DataRow obraEnExposcion in tabla_obrasPorExposicion.Rows)
            {
                Obra obra = new Obra();
                int duracionResumida = obra.getDuracionResumida(obraEnExposcion.ItemArray[0].ToString());
                lista.Add(duracionResumida);
            }
            int sumaDuracion = lista.Sum();
            return sumaDuracion;
        }
    }
}


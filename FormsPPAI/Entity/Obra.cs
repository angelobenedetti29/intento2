using Dashbord.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashbord.Entity
{
    public class Obra
    {
        public float Alto { get; set; }
        public float Ancho { get; set; }
        public int CodSensor { get; set; }
        public int DuracionExtendida { get; set; }
        public int DuracionReducida { get; set; }

        public DateTime FechaCreacion { get; set; }
        public DateTime FechaPrimerIngreso { get; set; }
        public string NombreObra { get; set; }
        public float Peso { get; set; }
        public float valuacion { get; set; }

        public int getDuracionResumida(string idObra)
        {
            int duracionReducida = ObraAdapter.ReadTiempo(idObra);
            return duracionReducida;
        }
    }
}

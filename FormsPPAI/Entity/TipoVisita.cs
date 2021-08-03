using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashbord.Entity
{
    public class TipoVisita
    {
        private int monto;
        private int nombre;

        public int Monto
        {
            get => monto;
            set => monto = value;
        }
        public int Nombre
        {
            get => nombre;
            set => nombre = value;
        }
    }
}

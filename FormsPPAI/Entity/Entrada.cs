using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dashbord.DataAccessLayer;

namespace Dashbord.Entity
{
    public class Entrada
    {
        public DateTime FechaVencimiento { get; set; }
        public DateTime HoraVenta { get; set; }
        public float Monto { get; set; }
        public int Numero { get; set; }

        public bool sonDeFechaHoraSede(int idSede, DateTime fechaHoraActual)
        {
            DataTable tabla = EntradaAdapter.ComprobarFechaHoraSede(idSede.ToString(), fechaHoraActual.ToString());
            if (tabla.Rows.Count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public DataTable getInforme(int cantidad)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["ConnectionString"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string query = "GetInformeEntrada";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@cantidad", cantidad);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = query;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                return tabla;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
        }

        public int getUltimoNroEntrada()
        {
            return EntradaAdapter.GetUltimoNro();
        }
        //public void sonDeFechaHoraSede(int nroEntradas, int nroSede)
        //{
        //    //DataTable tabla = 
        //    //foreach (DataRow tarifa in tarifas.Rows)
        //    //{
        //    //    tarifa.ItemArray[0].ToString();
        //    //    tarifa.ItemArray[1].ToString();
        //    //}
        //}

    }
}

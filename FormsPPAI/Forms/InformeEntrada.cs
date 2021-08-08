using Dashbord.Entity;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashbord.Forms
{
    public partial class InformeEntrada : Form
    {
        int cantidad = 0;
        public InformeEntrada(int cant)
        {
            InitializeComponent();
            cantidad = cant;
        }

        private void InformeEntrada_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
            armarReporte(cantidad);
        }

        private void armarReporte(int cantidad)
        {
            DataTable tabla = new Entrada().getInforme(cantidad);
            ReportDataSource ds = new ReportDataSource("DataSet_Entrada", tabla);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
            //reportViewer1.LocalReport.ReportPath = "C:/Users/UsuarioCony/Desktop/Gestor Psicologico/Report.rdlc";
            reportViewer1.RefreshReport();
        }

        private void btn_Close(object sender, FormClosedEventArgs e)
        {
            GestorVentaEntrada.finCU();
        }
    }
}

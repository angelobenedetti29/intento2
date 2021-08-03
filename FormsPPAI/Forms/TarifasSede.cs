using Dashbord.Entity;
using System;
using System.Data;
using System.Windows.Forms;

namespace Dashbord {
	public partial class TarifasSede : Form {
		private string username;

		public TarifasSede(string username) {
			InitializeComponent();
			
			this.username = username;
		}
		public void mostrarTarifasVigentes(DataTable tablaTarifas)
        {
			dtgTarifaSede.DataSource = tablaTarifas;
		}

		private void btnAceptar_Click(object sender, EventArgs e) => new ElegirTarifa(username).ShowDialog();

		private void TarifasSede_Load(object sender, EventArgs e) {
			//var gestor = new GestorVentaEntrada();

			//lblCargo.Text = gestor.buscarEmpleadoLogueado().Apellido;
			//dtgTarifaSede.DataSource = gestor.obtenerTarifasVigentes();
			//mostrarTarifasVigentes(tablaTarifas);
		}

		private void btnCloseForm_Click(object sender, EventArgs e) => Close();
	}
}

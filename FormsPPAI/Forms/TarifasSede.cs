using Dashbord.Entity;
using System;
using System.Data;
using System.Windows.Forms;

namespace Dashbord {
	public partial class TarifasSede : Form {
		private int idUsuario;

		public TarifasSede(int idUser) {
			InitializeComponent();
			
			this.idUsuario = idUser;
		}
		public void mostrarTarifasVigentes(DataTable tablaTarifas)
        {
			dtgTarifaSede.DataSource = tablaTarifas;
		}

		private void btnAceptar_Click(object sender, EventArgs e) => new ElegirTarifa(idUsuario).ShowDialog();

		private void TarifasSede_Load(object sender, EventArgs e) {
			//var gestor = new GestorVentaEntrada();

			//lblCargo.Text = gestor.buscarEmpleadoLogueado().Apellido;
			//dtgTarifaSede.DataSource = gestor.obtenerTarifasVigentes();
			//mostrarTarifasVigentes(tablaTarifas);
		}

		private void btnCloseForm_Click(object sender, EventArgs e) => Close();
	}
}

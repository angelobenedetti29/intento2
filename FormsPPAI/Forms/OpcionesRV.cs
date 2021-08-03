using Dashbord.DataAccessLayer;
using Dashbord.Entity;
using System;
using System.Data;
using System.Windows.Forms;

namespace Dashbord {
	public partial class OpcionesRV : Form {
		private string username;

		public OpcionesRV(string username) {
			InitializeComponent();
			this.username = username;
		}
		public void tomarOpcionVentaEntrada()
        {
			habilitarPantalla();
        }

        private void habilitarPantalla()
        {
			GestorVentaEntrada.opcionVentaEntrada();
        }

        private void btnCloseForm_Click(object sender, EventArgs e) => Application.Exit();

		//DataTable table = new DataTable();
		//private void btnRegistrarVenta_Click(object sender, EventArgs e) => new TarifasSede(username,table ).ShowDialog();
		private void btnRegistrarVenta_Click(object sender, EventArgs e)
        {
			tomarOpcionVentaEntrada();
		}

		private void OpcionesRV_Load(object sender, EventArgs e)
        {
			//tomarOpcionVentaEntrada();
        }
		//private void OpcionesRV_Load(object sender, EventArgs e) => lblCargo.Text = UsuarioAdapter.ReadCargo(username).Rows[0][0].ToString();
    }
}

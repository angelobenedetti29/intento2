using Dashbord.DataAccessLayer;
using Dashbord.Entity;
using System.Windows.Forms;

namespace Dashbord {
	public partial class DetalleEntradas : Form {
		private string username;
		private string tipo_entrada;
		private string tipoVisita;
		private bool hayGuia;
		private int cantidad;
		private int precioTotal;
		private int idSede;

		public DetalleEntradas(string username, string tipoEntrada, string tipoVisita, bool hayGuia, int cantidad, int precioTotal, int idSede) {
			InitializeComponent();

			this.username = username;
			tipo_entrada = tipoEntrada;
			this.tipoVisita = tipoVisita;
			this.hayGuia = hayGuia;
			this.cantidad = cantidad;
			this.precioTotal = precioTotal;
			this.idSede = idSede;
		}

		private void btnCloseForm_Click(object sender, System.EventArgs e) => Close();

		private void btnAceptar_Click(object sender, System.EventArgs e) {
			if (GestorVentaEntrada.SolicitarConfirmacionVenta()) return;

			GestorVentaEntrada.GenerarEntradas(cantidad.ToString() , precioTotal);

			MessageBox.Show("Exito.");
			
		}

		private void DetalleEntradas_Load(object sender, System.EventArgs e) {
			lblCargo.Text = UsuarioAdapter.ReadCargo(username).Rows[0][0].ToString();

			dtgDetalleEntradas.Rows.Add(cantidad, tipo_entrada, tipoVisita, hayGuia, PrecioAdapter.ReadPrecio(tipo_entrada, tipoVisita, hayGuia ? "true" : "false", idSede.ToString()));

			lblTotal.Text = $"Total $" + precioTotal.ToString();
		}
	}
}

using Dashbord.DataAccessLayer;
using Dashbord.Entity;
using System.Windows.Forms;

namespace Dashbord {
	public partial class DetalleEntradas : Form {
		private int idUsuario;
		private string tipo_entrada;
		private string tipoVisita;
		private bool hayGuia;
		private int cantidad;
		private int precioTotal;
		private int idSede;

		public DetalleEntradas(int idUsuario, string tipoEntrada, string tipoVisita, bool hayGuia, int cantidad, int precioTotal, int idSede) {
			InitializeComponent();

			this.idUsuario = idUsuario;
			this.tipo_entrada = tipoEntrada;
			this.tipoVisita = tipoVisita;
			this.hayGuia = hayGuia;
			this.cantidad = cantidad;
			this.precioTotal = precioTotal;
			this.idSede = idSede;
		}
		public DetalleEntradas()
		{ }

		private void btnCloseForm_Click(object sender, System.EventArgs e) => Close();


		private void DetalleEntradas_Load(object sender, System.EventArgs e) {
			lblCargo.Text = UsuarioAdapter.ReadCargo(idUsuario.ToString()).Rows[0][0].ToString();

			dtgDetalleEntradas.Rows.Add(cantidad, tipo_entrada, tipoVisita, hayGuia, PrecioAdapter.ReadPrecio(tipo_entrada, tipoVisita, hayGuia ? "true" : "false", idSede.ToString()));

			lblTotal.Text = $"Total $" + precioTotal.ToString();
		}

        private void tomarConfirmacionVenta(object sender, System.EventArgs e)
        {
			bool confirmacion = MessageBox.Show("Confirmar?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes ? true : false;
            if (confirmacion)
            {
				GestorVentaEntrada.tomarConfirmacionVenta(cantidad.ToString(), precioTotal);
            }
            else
            {
				return;
            }
		}
		public void mensajeEntradas()
        {
			MessageBox.Show("La operacion fue exitosa");
        }
	} 
}


using Dashbord.DataAccessLayer;
using System;
using System.Windows.Forms;
using Dashbord.Entity;

namespace Dashbord {
	public partial class ElegirEntradas : Form {
		
		private int tipoEntrada;
		private int tipoVisita;
		private bool hayGuia;
		private int idSede;
		private bool loSupero;
		private int idUsuario;
		

		public ElegirEntradas(int tipoEntrada, int tipoVisita, bool hayGuia, int idSede, int idUsuario/*, int tiempo*/) {
			InitializeComponent();

			this.tipoEntrada = tipoEntrada;
			this.tipoVisita = tipoVisita;
			this.hayGuia = hayGuia;
			this.idSede = idSede;
			this.idUsuario = idUsuario;
		}
		public ElegirEntradas()
        {}

		private void btnCloseForm_Click(object sender, EventArgs e) => Close();

		private void ElegirEntradas_Load(object sender, EventArgs e) {
			lblCargo.Text = UsuarioAdapter.ReadCargo(idUsuario.ToString()).Rows[0][0].ToString();
			string id = idSede.ToString();
			lblMaximo.Text = $"Maximo: {SedeAdapter.ReadMaxEntradas(id)} entradas en la \nSede {UsuarioAdapter.ReadSede(idUsuario.ToString()).Rows[0][0]}";
			lbl_Disponibles.Text = $"Hay disponibles en este momento, \n{SedeAdapter.ReadEntradasDisponibles(id)} entradas";
		}

        private void tomarCantidadEntradas(object sender, EventArgs e)
        {
			if (txtNroEntradas.Text.Equals(""))
			{
				MessageBox.Show("Insertar datos.");
				return;
			}
            if (txtNroEntradas.Text.Equals(0))
            {
				MessageBox.Show("Debe ingresar una cantidad de entradas mayor a 0. Intentelo de nuevo");
				return;
			}

            GestorVentaEntrada.tomarCantidadEntradas(int.Parse(txtNroEntradas.Text));
			//new DetalleEntradas(username, tipoEntrada, tipoVisita, hayGuia, int.Parse(txtNroEntradas.Text.Trim())).ShowDialog();
		}
		public void mensajeUsuario()
        {
			MessageBox.Show("El nro de entradas que desea comprar supera el limite. Intentelo de nuevo");
        }
    }
}

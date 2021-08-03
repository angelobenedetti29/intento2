using Dashbord.DataAccessLayer;
using System;
using System.Windows.Forms;
using Dashbord.Entity;

namespace Dashbord {
	public partial class ElegirEntradas : Form {
		//private string username;
		private int tipoEntrada;
		private int tipoVisita;
		private bool hayGuia;
		private int idSede;
		private bool loSupero;
		//private int tiempo;

		public ElegirEntradas(/*string username,*/ int tipoEntrada, int tipoVisita, bool hayGuia, int idSede/*, int tiempo*/) {
			InitializeComponent();

			//this.username = username;
			this.tipoEntrada = tipoEntrada;
			this.tipoVisita = tipoVisita;
			this.hayGuia = hayGuia;
			this.idSede = idSede;

			//this.tiempo = tiempo;
		}

		private void btnCloseForm_Click(object sender, EventArgs e) => Close();

		private void ElegirEntradas_Load(object sender, EventArgs e) {
			string username = "tanomartinoli";
			lblCargo.Text = UsuarioAdapter.ReadCargo(username).Rows[0][0].ToString();
			string id = idSede.ToString();
			lblMaximo.Text = $"Maximo: {SedeAdapter.ReadMaxEntradas(id) - EntradaAdapter.ReadCantEntradas(idSede.ToString())} entradas en la \nSede {UsuarioAdapter.ReadSede(username).Rows[0][0]}";
		}

        private void tomarCantidadEntradas(object sender, EventArgs e)
        {
			if (txtNroEntradas.Text.Equals(""))
			{
				MessageBox.Show("Insertar datos.");
				return;
			}

            GestorVentaEntrada.tomarCantidadEntradas(int.Parse(txtNroEntradas.Text));
			//new DetalleEntradas(username, tipoEntrada, tipoVisita, hayGuia, int.Parse(txtNroEntradas.Text.Trim())).ShowDialog();
		}
    }
}

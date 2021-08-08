using Dashbord.DataAccessLayer;
using Dashbord.Entity;
using Dashbord.Utilities;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Dashbord {
	public partial class ElegirTarifa : Form {
		private int idUsuario;

		public ElegirTarifa(int idUser) {
			InitializeComponent();

			this.idUsuario = idUser;
		}

		private void btnCloseForm_Click(object sender, EventArgs e) => Close();

		private void ElegirTarifa_Load(object sender, EventArgs e) {
			lblCargo.Text = UsuarioAdapter.ReadCargo(idUsuario.ToString()).Rows[0][0].ToString();

			try {
				Generics.LoadComboBox(cmbEntrada, "nombre", "id" ,() => TiposEntradasAdapter.ReadTipoEntrada());
				Generics.LoadComboBox(cmbVisita, "nombre", "id", () => TiposVisitasAdapter.ReadTiposVisitas());
			} catch (SqlException) {
				MessageBox.Show("Error con la base de datos.");
				Application.Exit();
			}
		}

        private void tomarSeleccionTarifa(object sender, EventArgs e)
        {
			if (cmbEntrada.SelectedIndex == -1 && cmbVisita.SelectedIndex == -1 && (rdoSi.Checked || rdoNo.Checked))
			{
				MessageBox.Show("Insertar todos los datos.");
				return;
			}
			bool servicioGuia = false;
            if (rdoSi.Checked)
            {
				servicioGuia = true;
            }
			GestorVentaEntrada.tomarSeleccionTarifa(int.Parse(cmbEntrada.SelectedValue.ToString()), int.Parse(cmbVisita.SelectedValue.ToString()),servicioGuia);
			//MessageBox.Show("Se guardo la tarifa correctamente");
			////new ElegirEntradas(int.Parse(cmbEntrada.SelectedValue.ToString()), int.Parse(cmbVisita.ToString()),servicioGuia).ShowDialog();

			// TODO: preguntarle a la profe que hacer con este dato
			//ObraAdapter.ReadTiempo();

			//new ElegirEntradas(username, cmbEntrada.SelectedValue.ToString(), cmbVisita.SelectedValue.ToString(), rdoSi.Checked, TiempoAdapter.ReadDuracion()).ShowDialog();
		}
	}
}

using Dashbord.DataAccessLayer;
using Dashbord.Utilities;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Dashbord {
	public partial class IniciarSesion : Form {
		public IniciarSesion() => InitializeComponent();

		private void btnClose_Click(object sender, EventArgs e) => Application.Exit();

		private void btnIniciarSesion_Click(object sender, EventArgs e) {
			if (txtNombreUsuario.Text.Equals("") || txtPassword.Text.Equals("")) {
				MessageBox.Show("Insertar datos");
				return;
			}

			try {
				if (UsuarioAdapter.ReadUsuarioExiste(txtNombreUsuario.Text.Trim(), txtPassword.Text.Trim()).Rows.Count != 1) {
					MessageBox.Show("Usuario inexistente");
					Generics.CleanFields(this);

					return;
				}
			} catch (SqlException) {
				MessageBox.Show("Error con la base de datos");
				Application.Exit();
			}
			int idUsuario = UsuarioAdapter.ReadIDUsuario(txtNombreUsuario.Text.Trim(), txtPassword.Text.Trim());
			new OpcionesRV(idUsuario).ShowDialog();
			Hide();
		}

        private void IniciarSesion_Load(object sender, EventArgs e)
        {}
    }
}

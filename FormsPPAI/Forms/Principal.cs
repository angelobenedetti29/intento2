using System;
using System.Windows.Forms;

namespace Dashbord {
	public partial class Principal : Form {
		public Principal() => InitializeComponent();

		private void btnCloseForm_Click(object sender, EventArgs e) => Application.Exit();

		private void btnInicio_Click(object sender, EventArgs e) {
			new IniciarSesion().Show();
			Hide();
		}
	}
}

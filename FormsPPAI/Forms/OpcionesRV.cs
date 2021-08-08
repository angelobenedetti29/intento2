using Dashbord.DataAccessLayer;
using Dashbord.Entity;
using System;
using System.Data;
using System.Windows.Forms;

namespace Dashbord {
	public partial class OpcionesRV : Form {
		private int idUsuario;

		public OpcionesRV(int idUser) {
			InitializeComponent();
			this.idUsuario = idUser;
		}

        private void habilitarPantalla()
        {
			GestorVentaEntrada.opcionVentaEntrada(idUsuario); // Le pasariamos al gestor como parametro que opcion eligio
            //pero en este caso no hace falta porque se contempla una sola opcion
        }

        private void btnCloseForm_Click(object sender, EventArgs e) => Application.Exit();


		private void OpcionesRV_Load(object sender, EventArgs e)
        {}

        private void tomarOpcionVentaEntrada(object sender, EventArgs e)
        {
            habilitarPantalla();
        }
        //private void OpcionesRV_Load(object sender, EventArgs e) => lblCargo.Text = UsuarioAdapter.ReadCargo(username).Rows[0][0].ToString();
    }
}

using System;
using System.Windows.Forms;

namespace Dashbord.Forms {
	public partial class Ticket : Form {
		public Ticket() => InitializeComponent();

		private void Ticket_Load(object sender, EventArgs e) {
			
			reportTicket.RefreshReport();
		}
	}
}

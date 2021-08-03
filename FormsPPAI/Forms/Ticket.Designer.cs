
namespace Dashbord.Forms {
	partial class Ticket {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
			this.reportTicket = new Microsoft.Reporting.WinForms.ReportViewer();
			this.dSIDataSet = new Dashbord.DSIDataSet();
			this.dSIDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dSIDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.dSIDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dSIDataSetBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dSIDataSetBindingSource1)).BeginInit();
			this.SuspendLayout();
			// 
			// reportTicket
			// 
			this.reportTicket.Dock = System.Windows.Forms.DockStyle.Fill;
			reportDataSource1.Name = "Ticket";
			reportDataSource1.Value = this.dSIDataSetBindingSource;
			this.reportTicket.LocalReport.DataSources.Add(reportDataSource1);
			this.reportTicket.LocalReport.ReportEmbeddedResource = "Dashbord.Forms.Ticket.rdlc";
			this.reportTicket.Location = new System.Drawing.Point(0, 0);
			this.reportTicket.Name = "reportTicket";
			this.reportTicket.ServerReport.BearerToken = null;
			this.reportTicket.Size = new System.Drawing.Size(800, 450);
			this.reportTicket.TabIndex = 0;
			// 
			// dSIDataSet
			// 
			this.dSIDataSet.DataSetName = "DSIDataSet";
			this.dSIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// dSIDataSetBindingSource
			// 
			this.dSIDataSetBindingSource.DataSource = this.dSIDataSet;
			this.dSIDataSetBindingSource.Position = 0;
			// 
			// dSIDataSetBindingSource1
			// 
			this.dSIDataSetBindingSource1.DataSource = this.dSIDataSet;
			this.dSIDataSetBindingSource1.Position = 0;
			// 
			// Ticket
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.reportTicket);
			this.Name = "Ticket";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Ticket";
			this.Load += new System.EventHandler(this.Ticket_Load);
			((System.ComponentModel.ISupportInitialize)(this.dSIDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dSIDataSetBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dSIDataSetBindingSource1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Microsoft.Reporting.WinForms.ReportViewer reportTicket;
		private System.Windows.Forms.BindingSource dSIDataSetBindingSource;
		private DSIDataSet dSIDataSet;
		private System.Windows.Forms.BindingSource dSIDataSetBindingSource1;
	}
}
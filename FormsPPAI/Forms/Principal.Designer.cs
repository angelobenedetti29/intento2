
namespace Dashbord {
	partial class Principal {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
			this.pibPrincipal = new System.Windows.Forms.PictureBox();
			this.lblMuseoPictorico = new System.Windows.Forms.Label();
			this.pibGobCbaPrincipal = new System.Windows.Forms.PictureBox();
			this.btnInicio = new System.Windows.Forms.Button();
			this.btnCloseForm = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pibPrincipal)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pibGobCbaPrincipal)).BeginInit();
			this.SuspendLayout();
			// 
			// pibPrincipal
			// 
			this.pibPrincipal.Image = ((System.Drawing.Image)(resources.GetObject("pibPrincipal.Image")));
			this.pibPrincipal.Location = new System.Drawing.Point(-35, 82);
			this.pibPrincipal.Name = "pibPrincipal";
			this.pibPrincipal.Size = new System.Drawing.Size(813, 461);
			this.pibPrincipal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pibPrincipal.TabIndex = 1;
			this.pibPrincipal.TabStop = false;
			// 
			// lblMuseoPictorico
			// 
			this.lblMuseoPictorico.BackColor = System.Drawing.Color.Transparent;
			this.lblMuseoPictorico.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F);
			this.lblMuseoPictorico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(230)))));
			this.lblMuseoPictorico.Location = new System.Drawing.Point(430, 54);
			this.lblMuseoPictorico.Name = "lblMuseoPictorico";
			this.lblMuseoPictorico.Size = new System.Drawing.Size(379, 489);
			this.lblMuseoPictorico.TabIndex = 2;
			this.lblMuseoPictorico.Text = "Museo Pictórico de Córdoba";
			this.lblMuseoPictorico.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// pibGobCbaPrincipal
			// 
			this.pibGobCbaPrincipal.Image = ((System.Drawing.Image)(resources.GetObject("pibGobCbaPrincipal.Image")));
			this.pibGobCbaPrincipal.Location = new System.Drawing.Point(-8, -15);
			this.pibGobCbaPrincipal.Name = "pibGobCbaPrincipal";
			this.pibGobCbaPrincipal.Size = new System.Drawing.Size(204, 108);
			this.pibGobCbaPrincipal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pibGobCbaPrincipal.TabIndex = 3;
			this.pibGobCbaPrincipal.TabStop = false;
			// 
			// btnInicio
			// 
			this.btnInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(166)))), ((int)(((byte)(75)))));
			this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(230)))));
			this.btnInicio.Location = new System.Drawing.Point(479, 12);
			this.btnInicio.Name = "btnInicio";
			this.btnInicio.Size = new System.Drawing.Size(197, 64);
			this.btnInicio.TabIndex = 9;
			this.btnInicio.Text = "Iniciar Sesión";
			this.btnInicio.UseVisualStyleBackColor = false;
			this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
			// 
			// btnCloseForm
			// 
			this.btnCloseForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
			this.btnCloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnCloseForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCloseForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(230)))));
			this.btnCloseForm.Location = new System.Drawing.Point(751, -2);
			this.btnCloseForm.Name = "btnCloseForm";
			this.btnCloseForm.Size = new System.Drawing.Size(43, 40);
			this.btnCloseForm.TabIndex = 21;
			this.btnCloseForm.Text = "X";
			this.btnCloseForm.UseVisualStyleBackColor = false;
			this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
			// 
			// Principal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.ClientSize = new System.Drawing.Size(790, 542);
			this.Controls.Add(this.btnCloseForm);
			this.Controls.Add(this.btnInicio);
			this.Controls.Add(this.lblMuseoPictorico);
			this.Controls.Add(this.pibPrincipal);
			this.Controls.Add(this.pibGobCbaPrincipal);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Principal";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.pibPrincipal)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pibGobCbaPrincipal)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.PictureBox pibPrincipal;
		private System.Windows.Forms.Label lblMuseoPictorico;
		private System.Windows.Forms.PictureBox pibGobCbaPrincipal;
		private System.Windows.Forms.Button btnInicio;
		private System.Windows.Forms.Button btnCloseForm;
	}
}
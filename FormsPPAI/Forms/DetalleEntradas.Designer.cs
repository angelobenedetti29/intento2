
namespace Dashbord {
	partial class DetalleEntradas {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetalleEntradas));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panelRV = new System.Windows.Forms.Panel();
			this.btnCerrarSesion = new System.Windows.Forms.Button();
			this.pibUsuario = new System.Windows.Forms.PictureBox();
			this.lblCargo = new System.Windows.Forms.Label();
			this.btnAceptar = new System.Windows.Forms.Button();
			this.lblDetalleEntradas = new System.Windows.Forms.Label();
			this.dtgDetalleEntradas = new System.Windows.Forms.DataGridView();
			this.cantEntradas = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tipoEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TipoVisita = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.guia = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnCloseForm = new System.Windows.Forms.Button();
			this.lblTotal = new System.Windows.Forms.Label();
			this.panelRV.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pibUsuario)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dtgDetalleEntradas)).BeginInit();
			this.SuspendLayout();
			// 
			// panelRV
			// 
			this.panelRV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(92)))), ((int)(((byte)(81)))));
			this.panelRV.Controls.Add(this.btnCerrarSesion);
			this.panelRV.Controls.Add(this.pibUsuario);
			this.panelRV.Controls.Add(this.lblCargo);
			this.panelRV.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelRV.Location = new System.Drawing.Point(0, 0);
			this.panelRV.Name = "panelRV";
			this.panelRV.Size = new System.Drawing.Size(200, 542);
			this.panelRV.TabIndex = 5;
			// 
			// btnCerrarSesion
			// 
			this.btnCerrarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
			this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCerrarSesion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(230)))));
			this.btnCerrarSesion.Location = new System.Drawing.Point(43, 428);
			this.btnCerrarSesion.Name = "btnCerrarSesion";
			this.btnCerrarSesion.Size = new System.Drawing.Size(114, 58);
			this.btnCerrarSesion.TabIndex = 4;
			this.btnCerrarSesion.Text = "Cerrar Sesión";
			this.btnCerrarSesion.UseVisualStyleBackColor = false;
			// 
			// pibUsuario
			// 
			this.pibUsuario.Image = ((System.Drawing.Image)(resources.GetObject("pibUsuario.Image")));
			this.pibUsuario.Location = new System.Drawing.Point(0, 12);
			this.pibUsuario.Name = "pibUsuario";
			this.pibUsuario.Size = new System.Drawing.Size(200, 97);
			this.pibUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pibUsuario.TabIndex = 3;
			this.pibUsuario.TabStop = false;
			// 
			// lblCargo
			// 
			this.lblCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCargo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(230)))));
			this.lblCargo.Location = new System.Drawing.Point(3, 112);
			this.lblCargo.Name = "lblCargo";
			this.lblCargo.Size = new System.Drawing.Size(197, 61);
			this.lblCargo.TabIndex = 2;
			this.lblCargo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnAceptar
			// 
			this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(104)))), ((int)(((byte)(166)))));
			this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAceptar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(230)))));
			this.btnAceptar.Location = new System.Drawing.Point(427, 445);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(151, 41);
			this.btnAceptar.TabIndex = 15;
			this.btnAceptar.Text = "Aceptar";
			this.btnAceptar.UseVisualStyleBackColor = false;
			this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
			// 
			// lblDetalleEntradas
			// 
			this.lblDetalleEntradas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(104)))), ((int)(((byte)(166)))));
			this.lblDetalleEntradas.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDetalleEntradas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(230)))));
			this.lblDetalleEntradas.Location = new System.Drawing.Point(276, 61);
			this.lblDetalleEntradas.Name = "lblDetalleEntradas";
			this.lblDetalleEntradas.Size = new System.Drawing.Size(454, 72);
			this.lblDetalleEntradas.TabIndex = 16;
			this.lblDetalleEntradas.Text = "Detalle de Entradas";
			this.lblDetalleEntradas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dtgDetalleEntradas
			// 
			this.dtgDetalleEntradas.AllowUserToAddRows = false;
			this.dtgDetalleEntradas.AllowUserToDeleteRows = false;
			this.dtgDetalleEntradas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(166)))), ((int)(((byte)(141)))));
			this.dtgDetalleEntradas.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dtgDetalleEntradas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(166)))), ((int)(((byte)(141)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dtgDetalleEntradas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dtgDetalleEntradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtgDetalleEntradas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cantEntradas,
            this.tipoEntrada,
            this.TipoVisita,
            this.guia,
            this.Precio});
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(166)))), ((int)(((byte)(141)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dtgDetalleEntradas.DefaultCellStyle = dataGridViewCellStyle2;
			this.dtgDetalleEntradas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.dtgDetalleEntradas.Location = new System.Drawing.Point(232, 151);
			this.dtgDetalleEntradas.Name = "dtgDetalleEntradas";
			this.dtgDetalleEntradas.ReadOnly = true;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(92)))), ((int)(((byte)(81)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(92)))), ((int)(((byte)(81)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dtgDetalleEntradas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dtgDetalleEntradas.Size = new System.Drawing.Size(546, 212);
			this.dtgDetalleEntradas.TabIndex = 19;
			// 
			// cantEntradas
			// 
			this.cantEntradas.HeaderText = "Cant";
			this.cantEntradas.Name = "cantEntradas";
			this.cantEntradas.ReadOnly = true;
			// 
			// tipoEntrada
			// 
			this.tipoEntrada.HeaderText = "Tipo Entrada";
			this.tipoEntrada.Name = "tipoEntrada";
			this.tipoEntrada.ReadOnly = true;
			// 
			// TipoVisita
			// 
			this.TipoVisita.HeaderText = "Tipo Visita";
			this.TipoVisita.Name = "TipoVisita";
			this.TipoVisita.ReadOnly = true;
			// 
			// guia
			// 
			this.guia.HeaderText = "Guía";
			this.guia.Name = "guia";
			this.guia.ReadOnly = true;
			// 
			// Precio
			// 
			this.Precio.HeaderText = "Precio";
			this.Precio.Name = "Precio";
			this.Precio.ReadOnly = true;
			// 
			// btnCloseForm
			// 
			this.btnCloseForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
			this.btnCloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnCloseForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCloseForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(230)))));
			this.btnCloseForm.Location = new System.Drawing.Point(750, 0);
			this.btnCloseForm.Name = "btnCloseForm";
			this.btnCloseForm.Size = new System.Drawing.Size(43, 40);
			this.btnCloseForm.TabIndex = 20;
			this.btnCloseForm.Text = "X";
			this.btnCloseForm.UseVisualStyleBackColor = false;
			this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
			// 
			// lblTotal
			// 
			this.lblTotal.AutoSize = true;
			this.lblTotal.Location = new System.Drawing.Point(232, 382);
			this.lblTotal.Name = "lblTotal";
			this.lblTotal.Size = new System.Drawing.Size(31, 13);
			this.lblTotal.TabIndex = 21;
			this.lblTotal.Text = "Total";
			// 
			// DetalleEntradas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.ClientSize = new System.Drawing.Size(790, 542);
			this.Controls.Add(this.lblTotal);
			this.Controls.Add(this.btnCloseForm);
			this.Controls.Add(this.dtgDetalleEntradas);
			this.Controls.Add(this.lblDetalleEntradas);
			this.Controls.Add(this.btnAceptar);
			this.Controls.Add(this.panelRV);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "DetalleEntradas";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "detalleEntradas";
			this.Load += new System.EventHandler(this.DetalleEntradas_Load);
			this.panelRV.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pibUsuario)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dtgDetalleEntradas)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panelRV;
		private System.Windows.Forms.Button btnCerrarSesion;
		private System.Windows.Forms.PictureBox pibUsuario;
		private System.Windows.Forms.Label lblCargo;
		private System.Windows.Forms.Button btnAceptar;
		private System.Windows.Forms.Label lblDetalleEntradas;
		private System.Windows.Forms.DataGridView dtgDetalleEntradas;
		private System.Windows.Forms.DataGridViewTextBoxColumn cantEntradas;
		private System.Windows.Forms.DataGridViewTextBoxColumn tipoEntrada;
		private System.Windows.Forms.DataGridViewTextBoxColumn TipoVisita;
		private System.Windows.Forms.DataGridViewTextBoxColumn guia;
		private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
		private System.Windows.Forms.Button btnCloseForm;
		private System.Windows.Forms.Label lblTotal;
	}
}
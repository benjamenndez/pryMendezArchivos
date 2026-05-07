namespace pryMendezArchivos
{
    partial class frmDeudores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gpbConsultaDatos = new System.Windows.Forms.GroupBox();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDeuda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLimite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPromedioDeuda = new System.Windows.Forms.Label();
            this.lblCantidadClie = new System.Windows.Forms.Label();
            this.lblPromDeudatxt = new System.Windows.Forms.Label();
            this.lblTotalDeudatxt = new System.Windows.Forms.Label();
            this.lblTotalDeuda = new System.Windows.Forms.Label();
            this.lblClientestxt = new System.Windows.Forms.Label();
            this.gpbConsultaDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbConsultaDatos
            // 
            this.gpbConsultaDatos.Controls.Add(this.dgvClientes);
            this.gpbConsultaDatos.Controls.Add(this.lblPromedioDeuda);
            this.gpbConsultaDatos.Controls.Add(this.lblCantidadClie);
            this.gpbConsultaDatos.Controls.Add(this.lblPromDeudatxt);
            this.gpbConsultaDatos.Controls.Add(this.lblTotalDeudatxt);
            this.gpbConsultaDatos.Controls.Add(this.lblTotalDeuda);
            this.gpbConsultaDatos.Controls.Add(this.lblClientestxt);
            this.gpbConsultaDatos.Location = new System.Drawing.Point(12, 12);
            this.gpbConsultaDatos.Name = "gpbConsultaDatos";
            this.gpbConsultaDatos.Size = new System.Drawing.Size(494, 380);
            this.gpbConsultaDatos.TabIndex = 15;
            this.gpbConsultaDatos.TabStop = false;
            this.gpbConsultaDatos.Text = "Consulta de Datos";
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colNombre,
            this.colDeuda,
            this.colLimite});
            this.dgvClientes.Location = new System.Drawing.Point(6, 38);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.RowHeadersVisible = false;
            this.dgvClientes.Size = new System.Drawing.Size(470, 182);
            this.dgvClientes.TabIndex = 5;
            // 
            // colCodigo
            // 
            this.colCodigo.HeaderText = "Código";
            this.colCodigo.Name = "colCodigo";
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.Width = 170;
            // 
            // colDeuda
            // 
            this.colDeuda.HeaderText = "Deuda";
            this.colDeuda.Name = "colDeuda";
            // 
            // colLimite
            // 
            this.colLimite.HeaderText = "Limite Crédito";
            this.colLimite.Name = "colLimite";
            // 
            // lblPromedioDeuda
            // 
            this.lblPromedioDeuda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPromedioDeuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromedioDeuda.Location = new System.Drawing.Point(382, 332);
            this.lblPromedioDeuda.Name = "lblPromedioDeuda";
            this.lblPromedioDeuda.Size = new System.Drawing.Size(94, 26);
            this.lblPromedioDeuda.TabIndex = 11;
            // 
            // lblCantidadClie
            // 
            this.lblCantidadClie.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCantidadClie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadClie.Location = new System.Drawing.Point(382, 290);
            this.lblCantidadClie.Name = "lblCantidadClie";
            this.lblCantidadClie.Size = new System.Drawing.Size(94, 26);
            this.lblCantidadClie.TabIndex = 9;
            // 
            // lblPromDeudatxt
            // 
            this.lblPromDeudatxt.AutoSize = true;
            this.lblPromDeudatxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromDeudatxt.Location = new System.Drawing.Point(263, 333);
            this.lblPromDeudatxt.Name = "lblPromDeudatxt";
            this.lblPromDeudatxt.Size = new System.Drawing.Size(113, 16);
            this.lblPromDeudatxt.TabIndex = 10;
            this.lblPromDeudatxt.Text = "Promedio Deuda:";
            // 
            // lblTotalDeudatxt
            // 
            this.lblTotalDeudatxt.AutoSize = true;
            this.lblTotalDeudatxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDeudatxt.Location = new System.Drawing.Point(261, 252);
            this.lblTotalDeudatxt.Name = "lblTotalDeudatxt";
            this.lblTotalDeudatxt.Size = new System.Drawing.Size(85, 16);
            this.lblTotalDeudatxt.TabIndex = 6;
            this.lblTotalDeudatxt.Text = "Total Deuda:";
            // 
            // lblTotalDeuda
            // 
            this.lblTotalDeuda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalDeuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDeuda.Location = new System.Drawing.Point(382, 242);
            this.lblTotalDeuda.Name = "lblTotalDeuda";
            this.lblTotalDeuda.Size = new System.Drawing.Size(94, 26);
            this.lblTotalDeuda.TabIndex = 7;
            // 
            // lblClientestxt
            // 
            this.lblClientestxt.AutoSize = true;
            this.lblClientestxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientestxt.Location = new System.Drawing.Point(261, 291);
            this.lblClientestxt.Name = "lblClientestxt";
            this.lblClientestxt.Size = new System.Drawing.Size(115, 16);
            this.lblClientestxt.TabIndex = 8;
            this.lblClientestxt.Text = "Cantidad Clientes:";
            // 
            // frmDeudores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 399);
            this.Controls.Add(this.gpbConsultaDatos);
            this.Name = "frmDeudores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes Deudores";
            this.Load += new System.EventHandler(this.frmDeudores_Load);
            this.gpbConsultaDatos.ResumeLayout(false);
            this.gpbConsultaDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbConsultaDatos;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDeuda;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLimite;
        private System.Windows.Forms.Label lblPromedioDeuda;
        private System.Windows.Forms.Label lblCantidadClie;
        private System.Windows.Forms.Label lblPromDeudatxt;
        private System.Windows.Forms.Label lblTotalDeudatxt;
        private System.Windows.Forms.Label lblTotalDeuda;
        private System.Windows.Forms.Label lblClientestxt;
    }
}
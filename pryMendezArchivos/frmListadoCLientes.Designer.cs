namespace pryMendezArchivos
{
    partial class frmListadoCLientes
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpbConsultaDatos = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCantidadClientes = new System.Windows.Forms.Label();
            this.PromedioDeuda = new System.Windows.Forms.Label();
            this.CantidadCLientes = new System.Windows.Forms.Label();
            this.TotalDeuda = new System.Windows.Forms.Label();
            this.btnReporte = new System.Windows.Forms.Button();
            this.btnOrdenar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.gpbConsultaDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(255, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Total de Deuda:";
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column3});
            this.dgvClientes.Location = new System.Drawing.Point(6, 19);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(537, 218);
            this.dgvClientes.TabIndex = 14;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Còdigo";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Usuario";
            this.Column2.Name = "Column2";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Deuda";
            this.Column4.Name = "Column4";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Limite de Credito";
            this.Column3.Name = "Column3";
            // 
            // gpbConsultaDatos
            // 
            this.gpbConsultaDatos.Controls.Add(this.btnOrdenar);
            this.gpbConsultaDatos.Controls.Add(this.btnReporte);
            this.gpbConsultaDatos.Controls.Add(this.label2);
            this.gpbConsultaDatos.Controls.Add(this.lblCantidadClientes);
            this.gpbConsultaDatos.Controls.Add(this.PromedioDeuda);
            this.gpbConsultaDatos.Controls.Add(this.dgvClientes);
            this.gpbConsultaDatos.Controls.Add(this.CantidadCLientes);
            this.gpbConsultaDatos.Controls.Add(this.label1);
            this.gpbConsultaDatos.Controls.Add(this.TotalDeuda);
            this.gpbConsultaDatos.Location = new System.Drawing.Point(12, 12);
            this.gpbConsultaDatos.Name = "gpbConsultaDatos";
            this.gpbConsultaDatos.Size = new System.Drawing.Size(560, 396);
            this.gpbConsultaDatos.TabIndex = 15;
            this.gpbConsultaDatos.TabStop = false;
            this.gpbConsultaDatos.Text = "Consulta de Datos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(246, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Promedio Deuda:";
            // 
            // lblCantidadClientes
            // 
            this.lblCantidadClientes.AutoSize = true;
            this.lblCantidadClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadClientes.Location = new System.Drawing.Point(244, 309);
            this.lblCantidadClientes.Name = "lblCantidadClientes";
            this.lblCantidadClientes.Size = new System.Drawing.Size(115, 16);
            this.lblCantidadClientes.TabIndex = 19;
            this.lblCantidadClientes.Text = "Cantidad Clientes:";
            // 
            // PromedioDeuda
            // 
            this.PromedioDeuda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PromedioDeuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PromedioDeuda.Location = new System.Drawing.Point(388, 343);
            this.PromedioDeuda.Name = "PromedioDeuda";
            this.PromedioDeuda.Size = new System.Drawing.Size(159, 28);
            this.PromedioDeuda.TabIndex = 18;
            this.PromedioDeuda.Text = "             ";
            // 
            // CantidadCLientes
            // 
            this.CantidadCLientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CantidadCLientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantidadCLientes.Location = new System.Drawing.Point(388, 297);
            this.CantidadCLientes.Name = "CantidadCLientes";
            this.CantidadCLientes.Size = new System.Drawing.Size(159, 28);
            this.CantidadCLientes.TabIndex = 17;
            this.CantidadCLientes.Text = "             ";
            // 
            // TotalDeuda
            // 
            this.TotalDeuda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TotalDeuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalDeuda.Location = new System.Drawing.Point(388, 259);
            this.TotalDeuda.Name = "TotalDeuda";
            this.TotalDeuda.Size = new System.Drawing.Size(159, 28);
            this.TotalDeuda.TabIndex = 14;
            this.TotalDeuda.Text = "             ";
            // 
            // btnReporte
            // 
            this.btnReporte.Location = new System.Drawing.Point(78, 352);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(75, 23);
            this.btnReporte.TabIndex = 21;
            this.btnReporte.Text = "Reporte";
            this.btnReporte.UseVisualStyleBackColor = true;
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(78, 306);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(75, 23);
            this.btnOrdenar.TabIndex = 22;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // frmListadoCLientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 426);
            this.Controls.Add(this.gpbConsultaDatos);
            this.Name = "frmListadoCLientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmListadoCLientes";
            this.Load += new System.EventHandler(this.frmListadoCLientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.gpbConsultaDatos.ResumeLayout(false);
            this.gpbConsultaDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.GroupBox gpbConsultaDatos;
        private System.Windows.Forms.Label TotalDeuda;
        private System.Windows.Forms.Label CantidadCLientes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCantidadClientes;
        private System.Windows.Forms.Label PromedioDeuda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.Button btnReporte;
    }
}
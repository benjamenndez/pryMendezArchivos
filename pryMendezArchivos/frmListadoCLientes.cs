using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryMendezArchivos
{
    public partial class frmListadoCLientes : Form
    {
        public frmListadoCLientes()
        {
            InitializeComponent();
        }
        clsArchivo x = new clsArchivo();
        private void frmListadoCLientes_Load(object sender, EventArgs e)
        {
            x.Listar(dgvClientes);
            TotalDeuda.Text = "$" + x.TotalDeuda().ToString();
            CantidadCLientes.Text = x.CantClientes().ToString();
            PromedioDeuda.Text = "$" + x.Promedio().ToString();
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            x.OrdenarArchivo();
            x.Listar(dgvClientes);
            MessageBox.Show("El reporte se ha ordenado", "Archivo Ordenado",
            MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            x.GenerarReporte();
            MessageBox.Show("El reporte ha sido realizado", "Reporte Generado",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

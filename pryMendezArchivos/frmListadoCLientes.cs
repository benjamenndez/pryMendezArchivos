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
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            x.OrdenarArchivo();
            MessageBox.Show("Archivo Ordenado");
            x.Listar(dgvClientes);


        }
    }
}

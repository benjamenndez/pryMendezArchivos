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
    public partial class frmDeudores : Form
    {
        public frmDeudores()
        {
            InitializeComponent();
        }
        clsArchivo x = new clsArchivo();
        private void frmDeudores_Load(object sender, EventArgs e)
        {
            x.Listar(dgvClientes);
            lblTotalDeuda.Text = "$" + x.TotalDeuda().ToString();
            lblCantidadClie.Text = x.CantDeudores().ToString();
            lblPromedioDeuda.Text = "$" + x.PromDeudores().ToString();
        }
    }
}

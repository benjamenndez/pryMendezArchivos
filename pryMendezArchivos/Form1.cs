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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        clsArchivo x = new clsArchivo();
        private void gpbCarga_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnCargar.Enabled = false;
        }
        private void comprobar()
        {
            if (txtCodigo.Text != "" && txtNombreApellido.Text != "" && txtDeuda.Text != "" && txtLimiteCredito.Text != "")
            {
                btnCargar.Enabled = true;
            }
            else
            {
                btnCargar.Enabled = false; 
            }
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            comprobar();
        }

        private void txtNombreApellido_TextChanged(object sender, EventArgs e)
        {
            comprobar();
        }

        private void txtDeuda_TextChanged(object sender, EventArgs e)
        {
            comprobar();
        }

        private void txtLimiteCredito_TextChanged(object sender, EventArgs e)
        {
            comprobar();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            x.Grabar(txtCodigo.Text, txtNombreApellido.Text, txtDeuda.Text, txtLimiteCredito.Text);
            MessageBox.Show("Datos Grabados");

            txtCodigo.Text = "";
            txtNombreApellido.Text = "";
            txtDeuda.Text = "";
            txtLimiteCredito.Text = "";
        }

    }
}

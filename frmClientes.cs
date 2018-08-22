using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xtremgym
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevoS_Click(object sender, EventArgs e)
        {
            frmCliente frmc = new frmCliente();
            frmc.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmPagos frp = new frmPagos();
            frp.Show();
        }
    }
}

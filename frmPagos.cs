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
    public partial class frmPagos : Form
    {
        public frmPagos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double pago = Convert.ToDouble(txtPago.Text.TrimEnd());
                double total = Convert.ToDouble(lbTotal.Text);
                double Cambio = pago - total;
                this.Close();
                MessageBox.Show("El cambio es:" + Cambio.ToString());
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocurrio un error:"+ex.ToString()+MessageBoxIcon.Error+MessageBoxButtons.OK);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

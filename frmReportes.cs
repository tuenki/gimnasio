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
    public partial class frmReportes : Form
    {
        public frmReportes()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            frmMostrarReportes frmR = new frmMostrarReportes();
            frmR.fecha = Convert.ToDateTime(dateTimePicker1.Value);
            frmR.ShowDialog();
            //MessageBox.Show(Convert.ToDateTime(dateTimePicker1.Value.ToLongDateString()).ToString());
        }
    }
}

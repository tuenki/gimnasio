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
    public partial class frmMostrarReportes : Form
    {
        public frmMostrarReportes()
        {
            InitializeComponent();
        }
        public DateTime fecha { get; set; }
        private void frmMostrarReportes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetReporte.reporteFech' table. You can move, or remove it, as needed.
            this.reporteFechTableAdapter.Fill(this.DataSetReporte.reporteFech,fecha);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}

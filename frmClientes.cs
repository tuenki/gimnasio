using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GYMDatos;

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

        private void frmClientes_Load(object sender, EventArgs e)
        {
            MostrarClient();
        }
        private void MostrarClient()
        {
            CDUsuario ObjCliente = new CDUsuario();
            dataGridView1.DataSource = ObjCliente.MostrarClientes();
            dataGridView1.Columns["IDUsuario"].Visible = false;
            dataGridView1.Columns["IDSuscripcion"].Visible = false;
        }
    }
}

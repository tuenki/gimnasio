using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GYMNegocio;

namespace xtremgym
{
    public partial class frmMembresia : Form
    {
        CNMembresia objectCN = new CNMembresia();

        public frmMembresia()
        {
            InitializeComponent();
        }

        private void btnNuevoS_Click(object sender, EventArgs e)
        {
            frmNuevaMembresia frmm = new frmNuevaMembresia();
            frmm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmNuevaMembresia frmm = new frmNuevaMembresia();
            frmm.Show();
        }

        private void frmMembresia_Load(object sender, EventArgs e)
        {
            ShowMembership();
        }
        
        private void ShowMembership()
        {
            dataGridView1.DataSource = objectCN.ShowMembership();
        }

    }
}

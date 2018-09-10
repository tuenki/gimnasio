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
    public partial class SelectNewUser : Form
    {
        public SelectNewUser()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmCliente FC = new frmCliente();
            FC.Tipo = 1;
            Close();
            FC.ShowDialog();
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnExistente_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = true;
            ListaUsuarios();
        }

        private void btnCancelG2_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            groupBox1.Visible = true;
        }
        private void ListaUsuarios()
        {
            CDUsuario LUs = new CDUsuario();
            comboBox1.DataSource = LUs.ListaUsuarios();
            comboBox1.DisplayMember = "Nombre";
            comboBox1.ValueMember = "IDUsuario";

        }

        private void btnSigSelect_Click(object sender, EventArgs e)
        {
            frmDatosUser FDU = new frmDatosUser();
            FDU.Tipo = 1; // Madar ID
            FDU.IDCliente = Convert.ToInt32(comboBox1.SelectedValue);
            Close();
            FDU.ShowDialog();
            

        }
    }
}

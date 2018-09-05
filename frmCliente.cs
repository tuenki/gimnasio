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
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NuevoUsuario();
           /* frmPagos frmp = new frmPagos();
            this.Close();
            frmp.Show();*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void NuevoUsuario()
        {
            CNUsuario ObjNu = new CNUsuario();
            ObjNu.Nombre = txtNombre.Text;
            ObjNu.ApellidoP = txtApellidoP.Text;
            ObjNu.ApellidoM = txtApellidoM.Text;
            if(ObjNu.Nombre == txtNombre.Text)
            {
                if(ObjNu.ApellidoP == txtApellidoP.Text)
                {
                    if(ObjNu.ApellidoM == txtApellidoM.Text)
                    {
                        ObjNu.NuevoUsuario();
                        MessageBox.Show("Se ingreso correctamente");
                    }
                }
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

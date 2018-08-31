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
    public partial class frmNusuarios : Form
    {
        public frmNusuarios()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked == true)
            {
                // Existente
                GExistente.Visible = true;
                GNuevo.Visible = false;
                txtuser.ReadOnly = false;
                txtpwd.ReadOnly = false;
                
            }
            else if(radioButton1.Checked == false)
            {
                GExistente.Visible = false;
                GNuevo.Visible = true;
                txtuser.ReadOnly = false;
                txtpwd.ReadOnly = false;

            }
        }
        private void ListaUsuarios()
        {
            CDUsuario LUs = new CDUsuario();
            CBNombre.DataSource = LUs.ListaUsuarios();
            CBNombre.DisplayMember = "Nombre";
            CBNombre.ValueMember = "IDUsuario";

        }
        
        
        

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void frmNusuarios_Load(object sender, EventArgs e)
        {
            ListaUsuarios();
        }
    }
}

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
using GYMNegocio;

namespace xtremgym
{
    public partial class frmNusuarios : Form
    {
        CNUsuario ObjUs = new CNUsuario();
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
                ListaUsuarios();
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
            NuevoLogin();
        }

        private void frmNusuarios_Load(object sender, EventArgs e)
        {
            ListaCargo();
        }
        private void ListaCargo()
        {
            CDUsuario LCar = new CDUsuario();
            CBCargo.DataSource = LCar.ListaCargos();
            CBCargo.DisplayMember = "NombreCargo";
            CBCargo.ValueMember = "IDCargo";
        }
        private void NuevoLogin()
        {
            ObjUs.IDUsuario = Convert.ToInt32(CBNombre.SelectedValue);
            ObjUs.Cargo = Convert.ToInt32(CBCargo.SelectedValue);
            ObjUs.Usuario = txtuser.Text;
            ObjUs.Contrasenia = txtpwd.Text;
            ObjUs.NuevoLogin();
        }
    }
}

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
        public int Editar = 0; // Si cambia a 1 es editar
        public int IDUsuario;
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
            Checar();
        }
        private void Checar()
        {
            if (radioButton1.Checked == true)
            {
                // Existente
                ListaUsuarios();
                GExistente.Visible = true;
                GNuevo.Visible = false;
                txtuser.ReadOnly = false;
                txtpwd.ReadOnly = false;

            }
            else if (radioButton1.Checked == false)
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
            if(radioButton1.Checked)
            {
                // Existente
                //NuevoLogin();
                MessageBox.Show("Nuevo Existente");
            }
            else if(radioButton2.Checked)
            {
                //NuevoUsuarioLog();
                MessageBox.Show("Nuevo NO Existente");
            }
            else if (Editar == 1)
            {
                //editar
                MessageBox.Show("Editar");
            }
            
        }

        private void frmNusuarios_Load(object sender, EventArgs e)
        {
            //ListaCargo();
        }
        public void ListaCargo()
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
        private void NuevoUsuarioLog()
        {
            ObjUs.Nombre = txtNombre.Text;
            ObjUs.ApellidoP = txtApellidoP.Text;
            ObjUs.ApellidoM = txtApellidoM.Text;
            ObjUs.Cargo = Convert.ToInt32(CBCargo.SelectedValue);
            ObjUs.Usuario = txtuser.Text;
            ObjUs.Contrasenia = txtpwd.Text;
            ObjUs.NuevoUsuarioLogin();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Checar();
        }

        private void btnExistente_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmCliente FMC = new frmCliente();
            this.Hide();
            FMC.Tipo = 1;
            FMC.ShowDialog();
        }
    }
}

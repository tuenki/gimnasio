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
    public partial class frmDatosUser : Form
    {
        public int Tipo = 0; 
        private int _IDCliente;
        private string _Nombre;
        private string _ApellidoP;
        private string _ApellidoM;
        private DPFP.Template _Template;

        public int IDCliente { set { _IDCliente = value; } get { return _IDCliente; } }
        public string Nombre { set { _Nombre = value; } get { return _Nombre; } }
        public string ApellidoP { set { _ApellidoP = value; } get { return _ApellidoP; } }
        public string ApellidoM { set { _ApellidoM = value; } get { return _ApellidoM; } }
        public DPFP.Template Template { set { _Template = value; } get { return _Template; } }
        public frmDatosUser()
        {
            InitializeComponent();
        }
        private void CargarPuestos()
        {
            CDUsuario LCar = new CDUsuario();
            comboOpcion.DataSource = LCar.ListaCargos();
            comboOpcion.DisplayMember = "NombreCargo";
            comboOpcion.ValueMember = "IDCargo";
        }

        private void frmDatosUser_Load(object sender, EventArgs e)
        {
            CargarPuestos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            /*
             * 0 = Nuevo usuario con nombre y huella
             * 1 = Nuevo usuario existente
             * 2 = Editar Login
             * */
            if(Tipo == 0)
            {
                CNUsuario US = new CNUsuario();
                US.Nombre = Nombre;
                US.ApellidoP = ApellidoP;
                US.ApellidoM = ApellidoM;
                US.Usuario = txtUsuario.Text;
                US.Contrasenia = txtPass.Text;
                US.Cargo = Convert.ToInt32(comboOpcion.SelectedValue);
                US.Huella = US.ConvertirHuellaAString(Template);
                US.NuevoUsuarioLogin();
                MessageBox.Show("Usuario creado correctamente");
            }
            else if(Tipo == 1)
            {
                CNUsuario US = new CNUsuario();
                US.IDUsuario = IDCliente;
                US.Usuario = txtUsuario.Text;
                US.Contrasenia = txtPass.Text;
                US.Cargo = Convert.ToInt32(comboOpcion.SelectedValue);
                US.NuevoLogin();
                MessageBox.Show("Usuario creado correctamente");
            }
            else if(Tipo == 2)
            {
                if (string.IsNullOrEmpty(txtPass.Text))
                {
                    //No modifico contraseña
                    CNUsuario US = new CNUsuario();
                    US.IDUsuario = IDCliente;
                    US.Usuario = txtUsuario.Text;
                    US.Cargo = Convert.ToInt32(comboOpcion.SelectedValue);
                    US.ActualizarLogin();
                }
                else
                {
                    // Modifico contraseña
                    CNUsuario US = new CNUsuario();
                    US.IDUsuario = IDCliente;
                    US.Usuario = txtUsuario.Text;
                    US.Contrasenia = txtPass.Text;
                    US.Cargo = Convert.ToInt32(comboOpcion.SelectedValue);
                    US.ActualizarLoginConPass();
                }
                MessageBox.Show("Se Actualizo correctamente");
            }
            
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}

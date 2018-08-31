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
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void btnNuevoS_Click(object sender, EventArgs e)
        {
            frmNusuarios frmu = new frmNusuarios();
            frmu.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmNusuarios frmu = new frmNusuarios();
            frmu.Show();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            //Cargar Grid
            CargarClientes();
        }
        private void CargarClientes()
        {
            CDUsuario ObjEmpleado = new CDUsuario();
            dataGridView1.DataSource = ObjEmpleado.MostrarEmpleados();

        }
        
    }
}

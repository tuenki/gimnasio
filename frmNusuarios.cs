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
            
        }
        private void ListaUsuarios()
        {
           

        }
        
        
        

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void frmNusuarios_Load(object sender, EventArgs e)
        {
            //ListaCargo();
        }
        public void ListaCargo()
        {
            
        }
        private void NuevoLogin()
        {
            
        }
        private void NuevoUsuarioLog()
        {
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void btnExistente_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
    
        }
    }
}

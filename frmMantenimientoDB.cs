using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace xtremgym
{
    public partial class frmMantenimientoDB : Form
    {
        public frmMantenimientoDB()
        {
            InitializeComponent();
        }

        private void btnCrearReslpado_Click(object sender, EventArgs e)
        {
            frmVerficarDedo VD = new frmVerficarDedo();
            VD.IDUsuario = Program.IDUsuario;
            if(VD.ShowDialog() == DialogResult.OK)
            {
                FolderBrowserDialog FBD = new FolderBrowserDialog();
                if(FBD.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string Dir = FBD.SelectedPath;
                         
                    }
                    catch
                    {

                    }
                }
            }
            else 
            {
                MessageBox.Show("Dedo incorrecto");
            }
        }

        private void btnSubirRespaldo_Click(object sender, EventArgs e)
        {
            frmVeriTodasHuellas VTD = new frmVeriTodasHuellas();
            VTD.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

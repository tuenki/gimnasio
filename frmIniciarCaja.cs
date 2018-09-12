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
    public partial class frmIniciarCaja : Form
    {
        public frmIniciarCaja()
        {
            InitializeComponent();
        }
        login lg = new login();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDineroInicial.Text != "")
                {
                    Program.DineroInicial = Convert.ToDouble(txtDineroInicial.Text);
                    Program.FechaInicio = DateTime.Now;
                    this.Hide();
                    Form1 frm1 = new Form1();
                    frm1.Show();
                }
                else
                    MessageBox.Show("Registre la cantidad de dinero en caja", "Campo vacio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: "+ex.ToString(),"Error inesperado",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtDineroInicial.Text = "";
            }
           
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {      
            lg.Show();
            this.Close();   
        }

        private void txtDineroInicial_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))

            {
                e.Handled = true;

                return;

            }*/
        }

        private void txtDineroInicial_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using GYMNegocio;
using System.Data.SqlClient;

namespace xtremgym
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        
        

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparm, int lparam);

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                CNUsuario objEmpleado = new CNUsuario();
                SqlDataReader Logear;
                objEmpleado.Usuario = txtUser.Text;
                objEmpleado.Contrasenia = txtContra.Text;
                if(objEmpleado.Usuario == txtUser.Text)
                {
                    if (objEmpleado.Contrasenia == txtContra.Text)
                    {
                        Logear = objEmpleado.IniciarSesion();
                        if (Logear.Read() == true)
                        {
                            this.Hide();
                            Program.IDUsuario =Convert.ToInt32(Logear["IDUsuario"]);
                            //Form1 frm1 = new Form1();
                            //frm1.Show();
                            frmIniciarCaja InitCaja = new frmIniciarCaja();
                            InitCaja.ShowDialog();
                        }
                        else
                            MessageBox.Show("Datos Incorrectos");
                    }
                    else
                    {
                        MessageBox.Show(objEmpleado.Contrasenia);
                    }
               
                }
                else
                {
                    MessageBox.Show(objEmpleado.Usuario);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error:" + ex.ToString(), "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

        private void txtContra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}

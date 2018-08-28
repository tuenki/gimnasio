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
using MySql.Data.MySqlClient;

namespace xtremgym
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        Conexion Con = new Conexion();
        
        

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
            if (!string.IsNullOrEmpty(txtUser.Text) && !string.IsNullOrEmpty(txtContra.Text)) 
            {
                validar();
            }
            else
            {
                MessageBox.Show("Campos vacios verifica");
            }
            
        }
        private void validar()
        {
            MySqlConnection Co = Con.Con();
            Co.Open();

            try
            {
                
                string user = txtUser.Text;
                string contra = txtContra.Text;
                MySqlDataReader Read = Con.Select("SELECT IDLogin FROM login WHERE UserName = '"+user+"' AND pwd ='"+contra+"'; ",Co).ExecuteReader();
                /*
                if (user == "hola" && contra == "contra")
                {
                    this.Hide();
                    Form1 frm = new Form1();
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Los datos ingresados son incorrectos","Error al iniciar sesion", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }*/
                if(Read.HasRows)
                {
                    Co.Close();
                    this.Hide();
                    Form1 frm = new Form1();
                    frm.Show();
                }
                else
                {
                    Co.Close();
                    MessageBox.Show("Los datos ingresados son incorrectos", "Error al iniciar sesion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                Co.Close();
                MessageBox.Show("Ocurrio un erro: " + ex.ToString(),"Error inesperado" , MessageBoxButtons.OK , MessageBoxIcon.Error);
                
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

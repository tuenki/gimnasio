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
    public partial class frmMantenimientoDB : Form
    {
        public frmMantenimientoDB()
        {
            InitializeComponent();
        }

        private void btnCrearReslpado_Click(object sender, EventArgs e)
        {
            try
            {
                frmVerficarDedo VD = new frmVerficarDedo();
                VD.IDUsuario = Program.IDUsuario;
                if (VD.ShowDialog() == DialogResult.OK)
                {
                   
                        try
                        {
                            Mantenimiento Man = new Mantenimiento();
                            
                            string Dir = "C:\\respaldo";
                            Man.Direccion = Dir;
                            Man.CrearRespaldo();
                            MessageBox.Show("Reslpado hecho");


                        }
                        catch(Exception EX)
                        {
                            MessageBox.Show("ERROR: "+EX.ToString(),"Error en tomar direccion",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        }
                    
                }
                else
                {
                    MessageBox.Show("Dedo incorrecto");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error:" + ex.ToString(), "Error inesperado en metodo crear", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSubirRespaldo_Click(object sender, EventArgs e)
        {
            try
            {
                frmVerficarDedo VD = new frmVerficarDedo();
                VD.IDUsuario = Program.IDUsuario;
                if (VD.ShowDialog() == DialogResult.OK)
                {
                    //FolderBrowserDialog FBD = new FolderBrowserDialog();
                    OpenFileDialog Opn = new OpenFileDialog();
                    Opn.Filter = "Bak files (*.bak) | *.bak";
                    if (Opn.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            Mantenimiento Man = new Mantenimiento();
                            string Dir = Opn.FileName;
                            Man.Direccion = Dir;
                            Man.SubirRespaldo();
                            MessageBox.Show("Base de datos restaurada");
                        }
                        catch (Exception EX)
                        {
                            MessageBox.Show("ERROR: " + EX.ToString(), "Error en tomar direccion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Dedo incorrecto");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error:" + ex.ToString(), "Error inesperado en metodo crear", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

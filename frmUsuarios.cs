﻿using System;
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

            SelectNewUser SNU = new SelectNewUser();
            SNU.ShowDialog();
            CargarClientes();
            /*frmNusuarios frmu = new frmNusuarios();
            frmu.ListaCargo();
            frmu.ShowDialog();*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    // Solo mandar los datos de login

                    frmDatosUser FDUM = new frmDatosUser();
                    FDUM.Tipo = 2;
                    FDUM.IDCliente = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                    FDUM.txtUsuario.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    FDUM.comboOpcion.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                    FDUM.ShowDialog();
                    CargarClientes();

                    /* //Editar
                     frmNusuarios frmu = new frmNusuarios();
                     frmu.ListaCargo();
                     frmu.Editar = 1;
                     string[] Nombresep = dataGridView1.CurrentRow.Cells[2].Value.ToString().Split(' ');
                     frmu.IDUsuario = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value);
                     frmu.txtuser.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                     frmu.txtuser.ReadOnly = false;
                     frmu.CBCargo.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                     frmu.txtpwd.ReadOnly = false;
                     //Editar consulta
                     if(Nombresep.Length == 4)
                     {
                         frmu.txtNombre.Text = Nombresep[0] + " "+Nombresep[1];
                         frmu.txtApellidoP.Text = Nombresep[2];
                         frmu.txtApellidoM.Text = Nombresep[3];
                     }
                     else
                     {
                         frmu.txtNombre.Text = Nombresep[0];
                         frmu.txtApellidoP.Text = Nombresep[1];
                         frmu.txtApellidoM.Text = Nombresep[2];
                     }
                     frmu.GNuevo.Visible = true;
                     frmu.GbxRadiob.Visible = false;
                     frmu.ShowDialog();*/

                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error:" + ex.ToString(), "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    CDUsuario ObjE = new CDUsuario();
                    ObjE.IDUsuario = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                    ObjE.EliminarLogin();
                    CargarClientes();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error:" + ex.ToString(), "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtBuscar.Text != "")
                {
                    dataGridView1.CurrentCell = null;
                    foreach (DataGridViewRow r in dataGridView1.Rows)
                    {
                        r.Visible = false;
                    }
                    foreach (DataGridViewRow r in dataGridView1.Rows)
                    {
                        foreach (DataGridViewCell c in r.Cells)
                        {
                            if ((c.Value.ToString().ToUpper()).IndexOf(txtBuscar.Text.ToUpper()) == 0)
                            {
                                r.Visible = true;
                                break;
                            }
                        }
                    }

                }
                else
                {
                    CargarClientes();
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: "+ex.ToString());
            }
        }
    }
}

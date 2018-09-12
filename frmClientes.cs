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
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }
        //boton para cerrar
        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //boton nuevo cliente
        private void btnNuevoS_Click(object sender, EventArgs e)
        {
            try
            {
                frmCliente frmc = new frmCliente();
                frmc.ShowDialog();
                MostrarClient();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString(), "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        //boton renovar cliente
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    if (dataGridView1.CurrentRow.Cells["Expiracion"].Value.ToString() != "")
                    {
                        if (Convert.ToDateTime(dataGridView1.CurrentRow.Cells["Expiracion"].Value) < DateTime.Now)
                        {
                            frmPagos frp = new frmPagos();
                            frp.IDCliente = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                            if (dataGridView1.CurrentRow.Cells["IDSuscripcion"].Value.ToString() != "")
                                frp.Suscripcion = Convert.ToInt32(dataGridView1.CurrentRow.Cells["IDSuscripcion"].Value);
                            frp.ShowDialog();
                            MostrarClient();
                        }
                        else
                        {
                            MessageBox.Show("Este cliente ya tiene una suscripcion");
                        }
                    }
                    else
                    {
                        frmPagos frp = new frmPagos();
                        frp.IDCliente = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                        if (dataGridView1.CurrentRow.Cells["IDSuscripcion"].Value.ToString() != "")
                            frp.Suscripcion = Convert.ToInt32(dataGridView1.CurrentRow.Cells["IDSuscripcion"].Value);
                        frp.ShowDialog();
                        MostrarClient();

                    }


                }
                else
                {
                    MessageBox.Show("Selecciona un cliente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString(), "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        //boton para editar
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {

                }
                else
                {
                    MessageBox.Show("Selecciona un usuario para editar");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString(), "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        //cargar grid al inicio
        private void frmClientes_Load(object sender, EventArgs e)
        {
            try
            {
                MostrarClient();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString(), "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            
        }
        //Filtrar texto en el grid
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "")
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
                            if ((c.Value.ToString().ToUpper()).IndexOf(textBox1.Text.ToUpper()) == 0)
                            {
                                r.Visible = true;
                                break;
                            }
                        }
                    }

                }
                else
                {
                    MostrarClient();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
        }
        //metodo para llamar cliente
        private void MostrarClient()
        {
            CDUsuario ObjCliente = new CDUsuario();
            dataGridView1.DataSource = ObjCliente.MostrarClientes();
            dataGridView1.Columns["IDUsuario"].Visible = false;
            dataGridView1.Columns["IDSuscripcion"].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmPagos frmp = new frmPagos();
            frmp.Show();
        }
    }
}

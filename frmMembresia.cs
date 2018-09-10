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
    public partial class frmMembresia : Form
    {
        CNMembresia objectCN = new CNMembresia();

        public frmMembresia()
        {
            InitializeComponent();
        }
        //cargar data grid al inicio
        private void frmMembresia_Load(object sender, EventArgs e)
        {
            try
            {
                ShowMembership();
                Showtype();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString(), "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //boton guardar
        private void btnNuevoS_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtidM.Text != "")
                    updateMemberShip();
                else
                    addNewMemberShip();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString(), "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        //boton editar
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult M = MessageBox.Show("Estas seguro de editar este dato?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if(M == DialogResult.OK)
            {
                try
                {
                    if (dataGridView1.SelectedRows.Count > 0)
                    {
                        fillInTXT();
                    }
                    else
                        MessageBox.Show("Fila no seleccionada", "Se tiene que seleccionar una fila", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.ToString(), "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

        }
        //boton eliminar
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult M= MessageBox.Show("Estas seguro de eliminar este dato?","Advertencia",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
            if (M == DialogResult.OK)
            {
                try
                {
                    fillInTXT();
                    deleteMembership();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.ToString(), "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        //codigo buscar en grid
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
                    ShowMembership();
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString(), "Error inesperado",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }
        // metodo para cargar datos en el grid
        private void ShowMembership()
        {
            dataGridView1.DataSource = objectCN.ShowMembership();
        }
        //metodo para cargar combo box
        private void Showtype()
        {
            cbxM.DataSource = objectCN.ShowTypeMembership();
            cbxM.DisplayMember = "Tipo";
            cbxM.ValueMember = "IDTipo";
        }
        //metodo para nueva membresia
        private void addNewMemberShip()
        {
            objectCN.NameMembership =txtNombreM.Text;
            objectCN.Days = txtDuracionM.Text;
            objectCN.IdType = cbxM.SelectedValue.ToString();
            objectCN.Price = txtPrecioM.Text;
            objectCN.NewMembership();
            MessageBox.Show("Se inserto satisfactoriamente");
            cleanGrupBox();
            ShowMembership();
            
        }
        //metodo para editar una membresia
        private void updateMemberShip()
        {
            objectCN.ID = txtidM.Text;
            objectCN.NameMembership = txtNombreM.Text;
            objectCN.Days = txtDuracionM.Text;
            objectCN.IdType = cbxM.SelectedValue.ToString();
            objectCN.Price = txtPrecioM.Text;
            objectCN.EditMembership();
            MessageBox.Show("Se actualizo satisfactoriamente");
            cleanGrupBox();
            ShowMembership();
        }
        //metodo eliminar membresia
        private void deleteMembership()
        {
            objectCN.ID = txtidM.Text;
            objectCN.DeleteMembership();
            MessageBox.Show("Se elimino satisfactoriamente");
            cleanGrupBox();
            ShowMembership();

        }
        //llenar los texbox
        private void fillInTXT()
        {
            txtidM.Text = dataGridView1.CurrentRow.Cells["IDMembrecia"].Value.ToString();
            txtNombreM.Text = dataGridView1.CurrentRow.Cells["NombreMembrecia"].Value.ToString();
            txtDuracionM.Text = dataGridView1.CurrentRow.Cells["Duracion"].Value.ToString();
            cbxM.Text = dataGridView1.CurrentRow.Cells["Tipo"].Value.ToString();
            txtPrecioM.Text = dataGridView1.CurrentRow.Cells["Precio"].Value.ToString();
        }
        //limpiar texbox
        private void cleanGrupBox()
        {
            txtidM.Text = "";
            txtNombreM.Text = "";
            txtPrecioM.Text = "";
            cbxM.SelectedIndex = 0;
        }
        //boton cerrar form hijo
        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbxM_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxM.SelectedIndex==0)
            {
                txtDuracionM.Text = "";
                txtDuracionM.ReadOnly = false;
            }
            else
            {
                txtDuracionM.ReadOnly = true;
                if (cbxM.SelectedIndex == 1)
                {
                    txtDuracionM.Text = "";
                    txtDuracionM.Text = "7";
                }
                else if (cbxM.SelectedIndex == 2)
                {
                    txtDuracionM.Text = "";
                    txtDuracionM.Text = "31";
                }
                else if (cbxM.SelectedIndex == 3)
                {
                    txtDuracionM.Text = "";
                    txtDuracionM.Text = "365";
                }
            }
        }
    }
}

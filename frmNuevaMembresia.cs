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
using GYMDatos;

namespace xtremgym
{
    public partial class frmNuevaMembresia : Form
    {
        CNMembresia objectCN = new CNMembresia();
        public frmNuevaMembresia()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmNuevaMembresia_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewMembership();
        }

        private void NewMembership()
        {
            objectCN.NameMembership = txtNameMember.Text;
            objectCN.Days = txtDays.Text;
            objectCN.IdType = comboBoxType.SelectedItem.ToString();
            objectCN.Price = txtPrice.Text;

        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxType.SelectedItem.ToString() == "Semanal")
            {
                txtDays.Clear();
                txtDays.Text = "7";
            }
            else if (comboBoxType.SelectedItem.ToString() == "Mensual")
            {
                txtDays.Clear();
                txtDays.Text = "30";
            }
            else if (comboBoxType.SelectedItem.ToString() == "Anual")
            {
                txtDays.Clear();
                txtDays.Text = "365";
            }
            else if (comboBoxType.SelectedItem.ToString() == "Dias")
            {
                txtDays.Clear();
                txtDays.ReadOnly = false;
            }

        }
    }
}

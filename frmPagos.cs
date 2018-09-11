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
    public partial class frmPagos : Form
    {
        public int IDCliente;
        public int Suscripcion = 0;
        public frmPagos()
        {
            InitializeComponent();
        }
        CNSuscripcion Sus = new CNSuscripcion();

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double pago = Convert.ToDouble(txtPago.Text.TrimEnd());
                if (pago < costo)
                    MessageBox.Show("No se puede realizar este pago");
                else
                {
                    double Cambio = pago - costo;
                    this.Close();
                    CNRecibo orec = new CNRecibo();
                    orec.IDCliente = IDCliente;
                    orec.IDEmpleado = Program.IDUsuario;
                    orec.Pago = costo;
                    if (Suscripcion > 0)
                    {
                        Sus.IDSuscripcion = Suscripcion;
                        Sus.IDCliente = IDCliente;
                        Sus.IDMem = Convert.ToInt32(comboBox1.SelectedValue);
                        Sus.Dias = Convert.ToInt32(txtDias.Text);
                        Sus.RenovarSuscrip();
                        
                        orec.InsertarRecibo();
                    }
                    else
                    {
                        Sus.IDCliente = IDCliente;
                        Sus.IDMem = Convert.ToInt32(comboBox1.SelectedValue);
                        Sus.Dias = Convert.ToInt32(txtDias.Text);
                        Sus.NuevaSuscrip();
                        orec.InsertarRecibo();
                    }
                    MessageBox.Show("El cambio es:" + Cambio.ToString());

                }
                
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocurrio un error:"+ex.ToString()+MessageBoxIcon.Error+MessageBoxButtons.OK);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPagos_Load(object sender, EventArgs e)
        {
            CargarCombo();
        }
        CNMembresia Mem = new CNMembresia();
        DataTable DTC;
        private void CargarCombo()
        {
            DTC = Mem.ShowMembership();
            comboBox1.DataSource = DTC;
            comboBox1.DisplayMember = "NombreMembrecia";
            comboBox1.ValueMember = "IDMembrecia";
        }
        DataRow[] Row;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        double costo;
        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string val = comboBox1.SelectedValue.ToString();
            Row = DTC.Select(string.Format("IDMembrecia = {0}", val));
            costo= Convert.ToDouble(Row[0][4]);
            lbTotal.Text = costo.ToString("C2");
            if(Row[0][3].ToString() == "Dias")
            {
                txtDias.Text = "";
                txtDias.Enabled = true;
            }
            else if (Row[0][3].ToString() == "Semana")
            {
                txtDias.Text = "7";
                txtDias.Enabled = false;
            }
            else if (Row[0][3].ToString() == "Mes")
            {
                txtDias.Text = "31";
                txtDias.Enabled =false;
            }
            else if (Row[0][3].ToString() == "Año")
            {
                txtDias.Text = "365";
                txtDias.Enabled = false;
            }
            
        }

        private void txtPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))

            {
                e.Handled = true;

                return;

            }
        }
    }
}

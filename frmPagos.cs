using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GYMNegocio;
using LibPrintTicket;


namespace xtremgym
{
    public partial class frmPagos : Form
    {
        public int IDCliente;
        public int Suscripcion = 0;

        private double costo;
        private double Cambio;

        CNSuscripcion Sus = new CNSuscripcion();
        CNMembresia Mem = new CNMembresia();
        DataTable DTC;
        DataRow[] Row;

        public frmPagos()
        {
            InitializeComponent();
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double pago = Convert.ToDouble(txtPago.Text.TrimEnd());
                if (pago < costo)
                    MessageBox.Show("No se puede realizar este pago");
                else
                {
                    Cambio = pago - costo;
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
                        PrintTicket();
                    }
                    else
                    {
                        Sus.IDCliente = IDCliente;
                        Sus.IDMem = Convert.ToInt32(comboBox1.SelectedValue);
                        Sus.Dias = Convert.ToInt32(txtDias.Text);
                        Sus.NuevaSuscrip();
                        orec.InsertarRecibo();
                        PrintTicket();
                    }
                    MessageBox.Show("El cambio es: " + Cambio.ToString());

                }
                
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocurrio un error:"+ex.ToString(),"Insertar/REnovar",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPagos_Load(object sender, EventArgs e)
        {
            try
            {
                PopulateInstalledPrintersCombo();
                CargarCombo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error:" + ex.ToString(), "Cargar comboBox", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        
        private void CargarCombo()
        {
            DTC = Mem.ShowMembership();
            comboBox1.DataSource = DTC;
            comboBox1.DisplayMember = "NombreMembrecia";
            comboBox1.ValueMember = "IDMembrecia";
        }
     

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        
        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                string val = comboBox1.SelectedValue.ToString();
                Row = DTC.Select(string.Format("IDMembrecia = {0}", val));
                costo = Convert.ToDouble(Row[0][4]);
                lbTotal.Text = costo.ToString("C3");
                txtDias.Text = Row[0][2].ToString();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error:" + ex.ToString(), "Seleccion CBX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void PrintTicket()
        {
            
            string nombreE = Program.NomUse;//el usaurio que atiende en turno va en el recibo

            //el nombre del cliente y su ID igual
            string idcleinte =IDCliente.ToString();

            string precio = costo.ToString();//Las cantidades y la operacion de dar el cambio TOTAL=recibio-precio
            string recibio = txtPago.Text;
            string camb = Cambio.ToString();
            double dias = Convert.ToDouble(txtDias.Text);


            //aqui se arman las cadenas 
            StringBuilder nombreUs = new StringBuilder();
            nombreUs.Append("Le atendio: " + nombreE);


            StringBuilder nombreC = new StringBuilder();
            nombreC.Append("Cliente ID: 00" + idcleinte);

            Ticket ticket = new Ticket();

            ticket.HeaderImage = pictureBox1.Image;
            ticket.AddHeaderLine("XTREMEGYM");
            ticket.AddHeaderLine("EXPEDIDO EN:");
            ticket.AddHeaderLine("Calle 16 avenida 28");
            ticket.AddHeaderLine("Agua Prieta Son.");
            ticket.AddHeaderLine("RFC: AUHE71052589A");

            ticket.AddSubHeaderLine("Caja #1");
            ticket.AddSubHeaderLine(nombreUs.ToString());//nombre del esclavo en turno
            ticket.AddSubHeaderLine(DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString());//fecha y hora
            ticket.AddSubHeaderLine(nombreC.ToString());//id del cliente


            ticket.AddItem("1", comboBox1.Text, "$ "+precio);//Aqui va: cantidad - nombre membrecia - costo membresia
            ticket.AddItem("", "", "");
            ticket.AddItem("", "Expira: "+DateTime.Now.AddDays(dias).ToShortDateString(), "");//fecha de expiracion

            ticket.AddTotal("SUBTOTAL", "$ "+precio);//precio membresia
            ticket.AddTotal("IVA", "0");
            ticket.AddTotal("TOTAL", "$ "+precio);//precio membresia
            ticket.AddTotal("", "");
            ticket.AddTotal("RECIBIDO", "$ "+recibio);//dinero que recibio
            ticket.AddTotal("CAMBIO", Cambio.ToString());//Cambio que se dio
            ticket.AddTotal("", "");

            ticket.AddFooterLine("La membresia es intrasferible, no esta sujeta a devolucion y le da derecho a una visita por dia");
            ticket.AddFooterLine("");
            ticket.AddFooterLine("GRACIAS POR SU PREFERENCIA!");

            ticket.PrintTicket(cbxImp.SelectedItem.ToString());//es importante saber el nombre de la impresora
        }

        private void txtPago_KeyPress(object sender, KeyPressEventArgs e)
        {
           /* if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))

            {
                e.Handled = true;

                return;

            }*/
        }
        private void PopulateInstalledPrintersCombo()
        {
            // Add list of installed printers found to the combo box.
            // The pkInstalledPrinters string will be used to provide the display string.
            String pkInstalledPrinters;
            for (int i = 0; i < PrinterSettings.InstalledPrinters.Count; i++)
            {
                pkInstalledPrinters = PrinterSettings.InstalledPrinters[i];
                cbxImp.Items.Add(pkInstalledPrinters);
            }
        }
        private void cbxImp_SelectionChanged(object sender, System.EventArgs e)
        {

            // Set the printer to a printer in the combo box when the selection changes.

            if (cbxImp.SelectedIndex != -1)
            {
                // The combo box's Text property returns the selected item's text, which is the printer name.
                PrintDocument printDoc = new PrintDocument();
                printDoc.PrinterSettings.PrinterName = cbxImp.Text;
            }

        }

    }
}

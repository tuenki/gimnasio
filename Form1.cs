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

namespace xtremgym
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparm, int lparam);

        private void iconClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        int lx, ly;
        private void iconMaximizar_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;
            lx = this.Location.X;
            ly = this.Location.Y;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            iconRestaurar.Visible = true;
            iconMaximizar.Visible = false;
        }

        private void iconRestaurar_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Normal;
            this.Size = new Size(900, 600);
            this.Location = new Point(lx, ly);
            iconMaximizar.Visible = true;
            iconRestaurar.Visible = false;
        }

        private void iconMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void barraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void AbrirFormInPanel(object FormHijo)
        {
            if (this.panelContainer.Controls.Count > 0)
                this.panelContainer.Controls.RemoveAt(0);
            Form fh = FormHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContainer.Controls.Add(fh);
            fh.Show();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new frmClientes());
        }

        private void btnMembresia_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new frmMembresia());
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new frmReportes());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new frmUsuarios());
        }

        private void HoraFEcha_Tick(object sender, EventArgs e)
        {
            lavelTime.Text =DateTime.Now.ToString("HH:mm:ss");
            lavelDate.Text =DateTime.Now.ToShortDateString();
        }

        protected override void WndProc(ref Message msj)
        {
            const int CoordenandaWFP = 0x84;
            const int DesIzquierda = 16;
            const int DesDerecha = 17;
            if (msj.Msg == CoordenandaWFP)
            {
                int x = (int)(msj.LParam.ToInt64() & 0xFFFF);
                int y = (int)((msj.LParam.ToInt64() & 0xFFFF0000) >> 16);
                Point coordenadaArea = PointToClient(new Point(x, y));
                Size TamañoAreaForm = ClientSize;
                if (coordenadaArea.X >= TamañoAreaForm.Width -16 && coordenadaArea.Y >= TamañoAreaForm.Height-16 && TamañoAreaForm.Height >= 16)
                {
                    msj.Result = (IntPtr)(IsMirrored ? DesIzquierda : DesDerecha);
                    return;
                }
            }
            base.WndProc(ref msj);
        }
    }
}

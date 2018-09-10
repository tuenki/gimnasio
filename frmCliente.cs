using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DPFP;
using DPFP.Capture;
using GYMNegocio;

namespace xtremgym
{
    public partial class frmCliente : Form, DPFP.Capture.EventHandler
    {

        delegate void Function();
        private DPFP.Capture.Capture Capturer;
        private DPFP.Processing.Enrollment Enroller;
        public delegate void OnTemplateEventHandler(DPFP.Template template);
        public event OnTemplateEventHandler OnTemplate;
        private DPFP.Template Template;

        public int Tipo = 0; // 0  =  Nuevo Usuario procedimiento normal
                            /// 1 = Nuevo usuario con contrasenia
                            /// 
                            /// </summary>

        public frmCliente()
        {
            InitializeComponent();
        }

        private void Init()
        {
            try
            {
                Capturer = new DPFP.Capture.Capture();
                Enroller = new DPFP.Processing.Enrollment();
                if (null != Capturer)
                    Capturer.EventHandler = this;

                // Un procedimiento
            }
            catch
            {
                MessageBox.Show("No se puede iniciar la operacion de caputra");
            }
        }
        protected Bitmap ConvertSampleTobitmap(DPFP.Sample Sample)
        {
            DPFP.Capture.SampleConversion Convertor = new DPFP.Capture.SampleConversion();
            Bitmap bitmap = null;
            Convertor.ConvertToPicture(Sample, ref bitmap);
            return bitmap;
        }
        protected DPFP.FeatureSet ExtractFeaTures(DPFP.Sample Sample, DPFP.Processing.DataPurpose Purpose)
        {
            DPFP.Processing.FeatureExtraction Extractor = new DPFP.Processing.FeatureExtraction();
            DPFP.Capture.CaptureFeedback feedback = DPFP.Capture.CaptureFeedback.None;
            DPFP.FeatureSet features = new DPFP.FeatureSet();
            Extractor.CreateFeatureSet(Sample, Purpose, ref feedback, ref features);
            if (feedback == DPFP.Capture.CaptureFeedback.Good)
                return features;
            else
                return null;
        }
        private void DrawPicture(Bitmap bt)
        {
            pictureBox1.Image = new Bitmap(bt);
        }
        protected void Start()
        {
            if (null != Capturer)
            {
                try
                {
                    Capturer.StartCapture();
                    //setpropt
                }
                catch
                {
                    //erorr
                }
            }
        }
        protected void Stop()
        {
            if (null != Capturer)
            {
                try
                {
                    Capturer.StopCapture();
                }
                catch
                {
                    //error
                }
            }
        }
        private void Procces(DPFP.Sample Sample)
        {
            Bitmap BMP = ConvertSampleTobitmap(Sample);
            DrawPicture(BMP);
            DPFP.FeatureSet Features = ExtractFeaTures(Sample, DPFP.Processing.DataPurpose.Enrollment);
            if (Features != null) try
                {
                    Enroller.AddFeatures(Features);
                }
                catch
                {
                    MessageBox.Show("Error de guardado");
                    Enroller.Clear();
                    Stop();
                    ActualizarStado();
                    OnTemplate(null);
                    Start();
                }
                finally
                {
                    ActualizarStado();
                    switch (Enroller.TemplateStatus)
                    {
                        case DPFP.Processing.Enrollment.Status.Ready:
                            OnTemplate(Enroller.Template);
                            //Anunciar("Dedo guardado");
                            //MessageBox.Show("Dedo Guardado");
                            Stop();
                            break;
                        case DPFP.Processing.Enrollment.Status.Failed:
                            Enroller.Clear();
                            Stop();
                            ActualizarStado();
                            OnTemplate(null);
                            Start();
                            break;
                    }
                }

        }
        private void ActualizarStado()
        {
            this.Invoke(new Function(delegate () {
                labelcontador.Text = String.Format("{0}", Enroller.FeaturesNeeded);

            }));
        }
        private void Mensaje(string MS)
        {
            this.Invoke(new Function(delegate () {
                labelAlert.Text = MS;

            }));
        }
        private void Leer(object sender,EventArgs ead)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Tipo == 0)
            {
                NuevoUsuario();
            }
                //
            else if (Tipo == 1)
            {
                frmDatosUser FDU = new frmDatosUser();
                FDU.Nombre = txtNombre.Text;
                FDU.ApellidoP = txtApellidoP.Text;
                FDU.ApellidoM = txtApellidoM.Text;
                FDU.Template = Template;
                this.Hide();
                FDU.ShowDialog();
            }
                
           /* frmPagos frmp = new frmPagos();
            this.Close();
            frmp.Show();*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void NuevoUsuario()
        {
            CNUsuario ObjNu = new CNUsuario();
            ObjNu.Nombre = txtNombre.Text;
            ObjNu.ApellidoP = txtApellidoP.Text;
            ObjNu.ApellidoM = txtApellidoM.Text;
            ObjNu.Huella = ObjNu.ConvertirHuellaAString(Template);
            if(ObjNu.Nombre == txtNombre.Text)
            {
                if(ObjNu.ApellidoP == txtApellidoP.Text)
                {
                    if(ObjNu.ApellidoM == txtApellidoM.Text)
                    {
                        ObjNu.NuevoUsuario();
                       MessageBox.Show("Se ingreso correctamente");
                        this.Close();
                    }
                }
            }

        }


        private void OnTemplate2(DPFP.Template template)
        {

            this.Invoke(new Function(delegate ()
            {
                Template = template;
                //VerifyButton.Enabled = SaveButton.Enabled = (Template != null);
                btnborrar.Enabled = button1.Enabled = (Template != null);
                if (Template != null)
                {
                    MessageBox.Show("El dedo esta listo para guardar", "Dedo listo");
                    
                    
                   // TextD(Template);
                }
                else
                {
                    MessageBox.Show("El dedo se ha limpiado", "Limpio");
                }

            }));
        }
        private void frmCliente_Load(object sender, EventArgs e)
        {
            Init();
            Start();
            this.OnTemplate += this.OnTemplate2;
        }
        #region EventHandler Members:
        public void OnComplete(object Capture, string ReaderSerialNumber, Sample Sample)
        {
            Procces(Sample);
        }

        public void OnFingerGone(object Capture, string ReaderSerialNumber)
        {
           
        }

        public void OnFingerTouch(object Capture, string ReaderSerialNumber)
        {
            
        }

        public void OnReaderConnect(object Capture, string ReaderSerialNumber)
        {
            Mensaje("Sensor conectado");
        }

        public void OnReaderDisconnect(object Capture, string ReaderSerialNumber)
        {
            Mensaje("SENSOR DESCONECTADO");
        }

        public void OnSampleQuality(object Capture, string ReaderSerialNumber, CaptureFeedback CaptureFeedback)
        {
           
        }

        #endregion

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            Enroller.Clear();
            Stop();
            ActualizarStado();
            OnTemplate(null);
            Start();
            
        }

        private void frmCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            Stop();
        }
    }
}

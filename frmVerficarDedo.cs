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
    public partial class frmVerficarDedo : Form, DPFP.Capture.EventHandler
    {

        private DPFP.Template Template;
        private DPFP.Verification.Verification Verificator;
        private DPFP.Capture.Capture Capturer;

        public int IDUsuario;



        delegate void Function();
        public frmVerficarDedo()
        {
            InitializeComponent();
        }
        private void Mostarmensaje(string mensaje)
        {
            this.Invoke(new Function(delegate {
                labelEstatus.Text = mensaje;
            }));

        }
        private void Aviso(string mensaje)
        {
            this.Invoke(new Function(delegate {
                labelVerificador.Text = mensaje;
            }));

        }
        protected DPFP.FeatureSet ExtractFeatures(DPFP.Sample Sample, DPFP.Processing.DataPurpose Purpose)
        {
            DPFP.Processing.FeatureExtraction Extractor = new DPFP.Processing.FeatureExtraction();  // Create a feature extractor
            DPFP.Capture.CaptureFeedback feedback = DPFP.Capture.CaptureFeedback.None;
            DPFP.FeatureSet features = new DPFP.FeatureSet();
            Extractor.CreateFeatureSet(Sample, Purpose, ref feedback, ref features);            // TODO: return features as a result?
            if (feedback == DPFP.Capture.CaptureFeedback.Good)
                return features;
            else
                return null;
        }
        protected Bitmap ConvertSampleTobitmap(DPFP.Sample Sample)
        {
            DPFP.Capture.SampleConversion Convertor = new DPFP.Capture.SampleConversion();
            Bitmap bitmap = null;
            Convertor.ConvertToPicture(Sample, ref bitmap);
            return bitmap;
        }
        protected virtual void Process(DPFP.Sample Sample)
        {
            Bitmap BMP = ConvertSampleTobitmap(Sample);
            DrawPicture(BMP);
            DPFP.FeatureSet features = ExtractFeatures(Sample, DPFP.Processing.DataPurpose.Verification);

            if (features != null)
            {
                // Compare the feature set with our template
                DPFP.Verification.Verification.Result result = new DPFP.Verification.Verification.Result();
                Verificator.Verify(features, Template, ref result);
                //UpdateStatus(result.FARAchieved);
                Verificador(result.Verified);
            }
        }
        private void Verificador(bool Veri)
        {
            this.Invoke(new Function(delegate {
                

            if (Veri)
            {
                //Correcto
                Aviso("CORRECTO");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                // incorrecto
                Aviso("INCORRECTO");
                this.DialogResult = DialogResult.No;
                this.Close();
            }

            }));
        }
        private void cerrar()
        {
            this.Invoke(new Function(delegate
            {
                MessageBox.Show("Sensor desconectado");
                this.Close();
            }));
        }
        private void DrawPicture(Bitmap bitmap)
        {

            pictureBox1.Image = new Bitmap(bitmap);

        }
        protected virtual void Init()
        {
            try
            {
                
                Verificator = new DPFP.Verification.Verification();
                // Enroller = new DPFP.Processing.Enrollment();
                //ActualizarStado();
                if (null != Capturer)
                    Capturer.EventHandler = this;

                // Un procedimiento
            }
            catch
            {
                MessageBox.Show("No se puede iniciar la operacion de captura");
            }
        }

        private void frmVerficarDedo_Load(object sender, EventArgs e)
        {
            Capturer = new DPFP.Capture.Capture();
            CNUsuario Uh = new CNUsuario();
            Uh.IDUsuario = IDUsuario;
            Template = Uh.RegresarHuellaTemp();
            Init();
            Capturer.StartCapture();

        }
        #region Header
        public void OnComplete(object Capture, string ReaderSerialNumber, Sample Sample)
        {
            Process(Sample);
        }

        public void OnFingerGone(object Capture, string ReaderSerialNumber)
        {
            
        }

        public void OnFingerTouch(object Capture, string ReaderSerialNumber)
        {
            
        }

        public void OnReaderConnect(object Capture, string ReaderSerialNumber)
        {
            Mostarmensaje("Sensor conectado");
        }

        public void OnReaderDisconnect(object Capture, string ReaderSerialNumber)
        {
            Mostarmensaje("Sensor desconectado");
            cerrar();
        }

        public void OnSampleQuality(object Capture, string ReaderSerialNumber, CaptureFeedback CaptureFeedback)
        {
            
        }
        #endregion

        private void frmVerficarDedo_FormClosed(object sender, FormClosedEventArgs e)
        {
            Capturer.StopCapture();
        }
    }
}

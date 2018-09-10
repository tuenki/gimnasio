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
    public partial class frmVeriTodasHuellas : Form,DPFP.Capture.EventHandler
    {
        List<AppData> Temp = new List<AppData>();
        private void ObtenerHuellas()
        {
            CNUsuario ob = new CNUsuario();
            Temp = ob.HuellasTemplate();
            labelTotal.Text = Temp.Count().ToString();
        }

        public frmVeriTodasHuellas()
        {
            InitializeComponent();
        }
        private DPFP.Capture.Capture Capturer;
        private void frmVeriTodasHuellas_Load(object sender, EventArgs e)
        {
            Capturer = new DPFP.Capture.Capture();
            CNUsuario Uh = new CNUsuario();
           // Uh.IDUsuario = IDUsuario;
            ObtenerHuellas();
            // Init();
            if (null != Capturer)
                Capturer.EventHandler = this;

            Capturer.StartCapture();
            
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

        public void OnComplete(object Capture, string ReaderSerialNumber, Sample Sample)
        {
            DPFP.Verification.Verification Ver = new DPFP.Verification.Verification();
            DPFP.Verification.Verification.Result Res = new DPFP.Verification.Verification.Result();
            DPFP.FeatureSet features = ExtractFeatures(Sample, DPFP.Processing.DataPurpose.Verification);
            foreach (AppData Te in Temp)
            {
                if(Te != null)
                {
                    
                    Ver.Verify(features, Te.Template, ref Res);
                    if (Res.Verified)
                    {
                        MessageBox.Show(String.Format("Se encontro la huella en el usuario {0}",Te.IDCliente));
                        break; // se encontro
                    }
                        
                }
            }
        }

        public void OnFingerGone(object Capture, string ReaderSerialNumber)
        {
            
        }

        public void OnFingerTouch(object Capture, string ReaderSerialNumber)
        {
            
        }

        public void OnReaderConnect(object Capture, string ReaderSerialNumber)
        {
            
        }

        public void OnReaderDisconnect(object Capture, string ReaderSerialNumber)
        {
            
        }

        public void OnSampleQuality(object Capture, string ReaderSerialNumber, CaptureFeedback CaptureFeedback)
        {
            
        }
    }
}

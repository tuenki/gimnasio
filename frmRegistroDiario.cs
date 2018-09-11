﻿using System;
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
    public partial class frmRegistroDiario : Form,DPFP.Capture.EventHandler
    {
        public frmRegistroDiario()
        {
            InitializeComponent();
        }
        delegate void Function();
        private DPFP.Capture.Capture Capturer;
        List<AppData> HuellasSus = new List<AppData>();

        private void frmRegistroDiario_Load(object sender, EventArgs e)
        {
            Capturer = new DPFP.Capture.Capture();
            obtenerHuellas();
            MostrarLista();
            if (null != Capturer)
                Capturer.EventHandler = this;

            Capturer.StartCapture();
        }
        
        private void obtenerHuellas()
        {
            CNUsuario Us = new CNUsuario();
            HuellasSus = Us.HuellasTemplate();
            lbCount.Text = HuellasSus.Count().ToString();
        }
        private void MostrarLista()
        {
            this.Invoke(new Function(delegate {
                CNSuscripcion Sus = new CNSuscripcion();
                dataGridView1.DataSource = Sus.MostrarSuscripHoy();
                dataGridView1.Columns["Entrada"].DefaultCellStyle.Format = "hh\\:mm\\:ss";
                dataGridView1.Columns["Salida"].DefaultCellStyle.Format = "hh\\:mm\\:ss";
                dataGridView1.Columns["IDUsuario"].Visible = false;
                dataGridView1.Columns["IDRegistro"].Visible = false;

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

        public void OnComplete(object Capture, string ReaderSerialNumber, Sample Sample)
        {
            DPFP.Verification.Verification Ver = new DPFP.Verification.Verification();
            DPFP.Verification.Verification.Result Res = new DPFP.Verification.Verification.Result();
            DPFP.FeatureSet features = ExtractFeatures(Sample, DPFP.Processing.DataPurpose.Verification);
            foreach (AppData Te in HuellasSus)
            {
                if (Te != null)
                {

                    Ver.Verify(features, Te.Template, ref Res);
                    if (Res.Verified)
                    {
                        //if()
                        SeEncuentra(Convert.ToInt32(Te.IDCliente));
                        MostrarLista();
                        break; // se encontro
                    }

                }
            }
        }
        private void InsertarNuevoRegistro(int Cliente)
        {
            CNSuscripcion Sus = new CNSuscripcion();
            Sus.IDCliente = Cliente;
            Sus.InsertaRegistroDiario();
        }
        private void SeEncuentra(int IDCliente)
        {
            foreach(DataGridViewRow Row in dataGridView1.Rows)
            {
                if(IDCliente == Convert.ToInt32(Row.Cells["IDUsuario"].Value))
                {
                    // se encuentra ya dentro del grid
                    // Verficamos si el valor de salida se encuentra vacio
                    if(string.IsNullOrEmpty(Row.Cells["Salida"].Value.ToString()))
                    {
                        //si esta vacio se manda a a insertar la hora
                        CNSuscripcion Sus = new CNSuscripcion();
                        Sus.IDRegistro = Convert.ToInt32(Row.Cells["IDRegistro"].Value);
                        Sus.ActualizarHoraFin();
                        MessageBox.Show("Se ha insertado");
                        break;
                    }
                    else
                    {
                        //si es falso entonces se manda la alerta que este usuario ya habia ingresado anteriormente.
                        DialogResult Res= MessageBox.Show("El cliente ya habia realizado una visita el dia de hoy \n ¿Deseas continuar con el registro?", "Alerta", MessageBoxButtons.YesNo);
                        if (Res == DialogResult.Yes)
                        {
                            InsertarNuevoRegistro(IDCliente);
                            MessageBox.Show("Se ha insertado");
                        }
                            
                        break;
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
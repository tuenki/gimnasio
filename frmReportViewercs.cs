﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xtremgym
{
    public partial class frmReportViewercs : Form
    {
        public frmReportViewercs()
        {
            InitializeComponent();
        }

        private void frmReportViewercs_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NHAHANG_RIENG
{
    public partial class HoaDon : Form
    {
        public HoaDon()
        {
            InitializeComponent();
        }
       private void HoaDon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QUANLYNHAHANGDataSet.BILL' table. You can move, or remove it, as needed.
            this.BILLTableAdapter.Fill(this.QUANLYNHAHANGDataSet.BILL);

            this.reportViewer1.RefreshReport();
        }
    }
}

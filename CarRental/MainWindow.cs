﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void viewRentalRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addRentalRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addRentalRecord = new AddCarRentalRecord();
            addRentalRecord.MdiParent = this;
            addRentalRecord.Show();
           
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Remi
{
    public partial class principal : Form
    {
        public principal()
        {
            InitializeComponent();
        }

        private void fROM1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fROM1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNPM
{
    public partial class homenv : Form
    {
        public homenv()
        {
            InitializeComponent();
        }

        private void homenv_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
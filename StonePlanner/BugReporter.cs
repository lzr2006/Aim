﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StonePlanner
{
    public partial class BugReporter : Form
    {
        string info;
        public BugReporter(string pInfo)
        {
            InitializeComponent();

            this.info = pInfo;
        }

        private void BugReporter_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = info;
        }
    }
}

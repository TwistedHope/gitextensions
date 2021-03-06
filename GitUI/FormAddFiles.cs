﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;
using GitCommands;

namespace GitUI
{
    public partial class FormAddFiles : GitExtensionsForm
    {
        public FormAddFiles()
        {
            InitializeComponent(); Translate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (force.Checked)
                new FormProcess("add -f \"" + Filter.Text + "\"").ShowDialog();
            else
                new FormProcess("add \"" + Filter.Text + "\"").ShowDialog();
            Close();
        }

        private void FormAddFiles_Load(object sender, EventArgs e)
        {

        }

        private void ShowFiles_Click(object sender, EventArgs e)
        {
            new FormProcess("add --dry-run \"" + Filter.Text + "\"").ShowDialog();
        }
    }
}

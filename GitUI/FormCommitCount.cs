﻿using System;
using System.Windows.Forms;
using GitCommands.Statistics;

namespace GitUI
{
    public partial class FormCommitCount : GitExtensionsForm
    {
        public FormCommitCount()
        {
            InitializeComponent();
            Translate();
        }

        private void FormCommitCountFormClosing(object sender, FormClosingEventArgs e)
        {
            SavePosition("commit-count");
        }

        private void FormCommitCountLoad(object sender, EventArgs e)
        {
            RestorePosition("commit-count");
            Loading.Visible = true;

            foreach (var keyValuePair in CommitCounter.GroupAllCommitsByContributer().Item1)
            {
                CommitCount.Text += string.Format("{1,6} - {0}\r\n", keyValuePair.Key, keyValuePair.Value);
            }

            Loading.Visible = false;
        }
    }
}
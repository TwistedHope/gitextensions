﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using GitCommands;
using GitCommands.Repository;
using GitUI.Properties;

namespace GitUI
{
    public partial class DashboardItem : GitExtensionsControl
    {
        public DashboardItem(Repository repository)
        {
            InitializeComponent(); Translate();

            if (repository == null)
                return;

            Bitmap icon = null;
            if (repository.RepositoryType == RepositoryType.RssFeed)
                icon = Resources.rss.ToBitmap();
            if (repository.RepositoryType == RepositoryType.Repository)
                icon = Resources._14;
            if (repository.RepositoryType == RepositoryType.History)
                icon = Resources.history.ToBitmap();

            Initialize(icon, repository.Path, repository.Title, repository.Description);
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        public DashboardItem(Bitmap icon, string title)
        {
            InitializeComponent(); Translate();

            Initialize(icon, title, title, null);
        }

        public DashboardItem(Bitmap icon, string title, string text)
        {
            InitializeComponent(); Translate();

            Initialize(icon, title, title, text);
        }

        private void Initialize(Bitmap icon, string path, string title, string text)
        {
            _Title.Text = title;
            _Title.AutoEllipsis = true;

            Path = path;

            if (string.IsNullOrEmpty(_Title.Text))
                _Title.Text = Path;

            _Description.Visible = !string.IsNullOrEmpty(text);
            _Description.Text = text;

            //if (Description.Visible)
            //{
            //    SizeF size = Description.CreateGraphics().MeasureString(Description.Text, Description.Font);
            //    int lines = ((int)size.Width / (int)Description.Width) + 1;
            //    Description.Height = ((int)size.Height) * lines;
            //}


            this.Height = _Title.Height+6;
            if (_Description.Visible)
            {
                _Description.Top = _Title.Height+4;
                this.Height += _Description.Height+2;
            }
            
                

            if (icon != null)
                Icon.Image = icon;


            ToolTip toolTip = new ToolTip();
            toolTip.InitialDelay = 1;
            toolTip.AutomaticDelay = 1;
            toolTip.AutoPopDelay = 5000;
            toolTip.UseFading = false;
            toolTip.UseAnimation = false;
            toolTip.ReshowDelay = 1;
            toolTip.SetToolTip(_Title, Path);
            
            _Title.MouseDown += new MouseEventHandler(Title_MouseDown);
            _Title.Click += new EventHandler(Title_Click);
            _Description.Click += new EventHandler(Title_Click);
            Icon.Click += new EventHandler(Title_Click);
        }

        void Title_Click(object sender, EventArgs e)
        {
            OnClick(e);
        }

        void Title_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (this.ContextMenuStrip != null)
                    this.ContextMenuStrip.Show((Control)sender, e.Location);
            }
        }

        public string GetTitle()
        {
            return _Title.Text;
        }

        public string Path { get; set; }

        private void DashboardItem_Resize(object sender, EventArgs e)
        {

        }

        private void DashboardItem_SizeChanged(object sender, EventArgs e)
        {
            _Title.Width = Width - _Title.Location.X;
            _Description.Width = Width - _Title.Location.X;
        }

        private void DashboardItem_Enter(object sender, EventArgs e)
        {

        }

        private void DashboardItem_Leave(object sender, EventArgs e)
        {

        }

        private void DashboardItem_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.ControlLight;
        }

        private void DashboardItem_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.Control;
        }
    }
}

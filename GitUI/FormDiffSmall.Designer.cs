﻿namespace GitUI
{
    partial class FormDiffSmall
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.DiffFiles = new GitUI.FileStatusList();
            this.DiffText = new GitUI.FileViewer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.commitInfo = new GitUI.CommitInfo();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.DiffFiles);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.DiffText);
            this.splitContainer1.Size = new System.Drawing.Size(717, 410);
            this.splitContainer1.SplitterDistance = 239;
            this.splitContainer1.TabIndex = 0;
            // 
            // DiffFiles
            // 
            this.DiffFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DiffFiles.GitItemStatusses = null;
            this.DiffFiles.Location = new System.Drawing.Point(0, 0);
            this.DiffFiles.Name = "DiffFiles";
            this.DiffFiles.SelectedItem = null;
            this.DiffFiles.Size = new System.Drawing.Size(239, 410);
            this.DiffFiles.TabIndex = 0;
            this.DiffFiles.SelectedIndexChanged += new System.EventHandler(this.DiffFiles_SelectedIndexChanged);
            // 
            // DiffText
            // 
            this.DiffText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DiffText.IgnoreWhitespaceChanges = false;
            this.DiffText.Location = new System.Drawing.Point(0, 0);
            this.DiffText.Margin = new System.Windows.Forms.Padding(4);
            this.DiffText.Name = "DiffText";
            this.DiffText.NumberOfVisibleLines = 3;
            this.DiffText.ScrollPos = 0;
            this.DiffText.ShowEntireFile = false;
            this.DiffText.Size = new System.Drawing.Size(474, 410);
            this.DiffText.TabIndex = 0;
            this.DiffText.TreatAllFilesAsText = false;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.commitInfo);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer1);
            this.splitContainer2.Size = new System.Drawing.Size(717, 529);
            this.splitContainer2.SplitterDistance = 115;
            this.splitContainer2.TabIndex = 1;
            // 
            // commitInfo
            // 
            this.commitInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.commitInfo.Location = new System.Drawing.Point(0, 0);
            this.commitInfo.Name = "commitInfo";
            this.commitInfo.Size = new System.Drawing.Size(717, 115);
            this.commitInfo.TabIndex = 0;
            // 
            // FormDiffSmall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 529);
            this.Controls.Add(this.splitContainer2);
            this.Name = "FormDiffSmall";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Diff";
            this.Load += new System.EventHandler(this.FormDiffSmall_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private FileStatusList DiffFiles;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private FileViewer DiffText;
        private CommitInfo commitInfo;
    }
}
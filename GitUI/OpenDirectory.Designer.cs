﻿namespace GitUI
{
    partial class Open
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
            this.label1 = new System.Windows.Forms.Label();
            this._Directory = new System.Windows.Forms.ComboBox();
            this.Browse = new System.Windows.Forms.Button();
            this.Load = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Directory";
            // 
            // _Directory
            // 
            this._Directory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this._Directory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this._Directory.FormattingEnabled = true;
            this._Directory.Location = new System.Drawing.Point(85, 10);
            this._Directory.Name = "_Directory";
            this._Directory.Size = new System.Drawing.Size(266, 21);
            this._Directory.TabIndex = 1;
            this._Directory.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DirectoryKeyPress);
            // 
            // Browse
            // 
            this.Browse.Location = new System.Drawing.Point(360, 8);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(75, 23);
            this.Browse.TabIndex = 2;
            this.Browse.Text = "Browse";
            this.Browse.UseVisualStyleBackColor = true;
            this.Browse.Click += new System.EventHandler(this.BrowseClick);
            // 
            // Load
            // 
            this.Load.Location = new System.Drawing.Point(360, 43);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(75, 23);
            this.Load.TabIndex = 3;
            this.Load.Text = "Open";
            this.Load.UseVisualStyleBackColor = true;
            this.Load.Click += new System.EventHandler(this.LoadClick);
            // 
            // Open
            // 
            this.AcceptButton = this.Load;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 78);
            this.Controls.Add(this.Load);
            this.Controls.Add(this.Browse);
            this.Controls.Add(this._Directory);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Open";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Open repository";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox _Directory;
        private System.Windows.Forms.Button Browse;
        private new System.Windows.Forms.Button Load;
    }
}
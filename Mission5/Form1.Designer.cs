﻿namespace Mission5
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inputPegawaiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lihatSemuaPegawaiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inputPegawaiToolStripMenuItem,
            this.lihatSemuaPegawaiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(311, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inputPegawaiToolStripMenuItem
            // 
            this.inputPegawaiToolStripMenuItem.Name = "inputPegawaiToolStripMenuItem";
            this.inputPegawaiToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.inputPegawaiToolStripMenuItem.Text = "Input Pegawai";
            this.inputPegawaiToolStripMenuItem.Click += new System.EventHandler(this.inputPegawaiToolStripMenuItem_Click);
            // 
            // lihatSemuaPegawaiToolStripMenuItem
            // 
            this.lihatSemuaPegawaiToolStripMenuItem.Name = "lihatSemuaPegawaiToolStripMenuItem";
            this.lihatSemuaPegawaiToolStripMenuItem.Size = new System.Drawing.Size(131, 20);
            this.lihatSemuaPegawaiToolStripMenuItem.Text = "Lihat Semua Pegawai";
            this.lihatSemuaPegawaiToolStripMenuItem.Click += new System.EventHandler(this.lihatSemuaPegawaiToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 118);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "SISTEM CRUD DATA PEGAWAI";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inputPegawaiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lihatSemuaPegawaiToolStripMenuItem;
    }
}


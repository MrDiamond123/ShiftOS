﻿namespace ShiftOS.WinForms.Applications
{
    partial class MindBlow
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabs = new System.Windows.Forms.TabControl();
            this.console = new System.Windows.Forms.TabPage();
            this.program = new System.Windows.Forms.TabPage();
            this.monitor = new System.Windows.Forms.TabPage();
            this.consoleout = new System.Windows.Forms.TextBox();
            this.programinput = new System.Windows.Forms.TextBox();
            this.load = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.memptr = new System.Windows.Forms.Label();
            this.instptr = new System.Windows.Forms.Label();
            this.memlist = new System.Windows.Forms.ListBox();
            this.run = new System.Windows.Forms.Button();
            this.tabs.SuspendLayout();
            this.console.SuspendLayout();
            this.program.SuspendLayout();
            this.monitor.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.console);
            this.tabs.Controls.Add(this.program);
            this.tabs.Controls.Add(this.monitor);
            this.tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabs.Location = new System.Drawing.Point(0, 0);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(392, 269);
            this.tabs.TabIndex = 0;
            this.tabs.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabs_Selected);
            // 
            // console
            // 
            this.console.Controls.Add(this.consoleout);
            this.console.Location = new System.Drawing.Point(4, 22);
            this.console.Name = "console";
            this.console.Padding = new System.Windows.Forms.Padding(3);
            this.console.Size = new System.Drawing.Size(384, 243);
            this.console.TabIndex = 0;
            this.console.Text = "Console";
            this.console.UseVisualStyleBackColor = true;
            // 
            // program
            // 
            this.program.Controls.Add(this.run);
            this.program.Controls.Add(this.save);
            this.program.Controls.Add(this.load);
            this.program.Controls.Add(this.programinput);
            this.program.Location = new System.Drawing.Point(4, 22);
            this.program.Name = "program";
            this.program.Padding = new System.Windows.Forms.Padding(3);
            this.program.Size = new System.Drawing.Size(384, 243);
            this.program.TabIndex = 1;
            this.program.Text = "Program";
            this.program.UseVisualStyleBackColor = true;
            // 
            // monitor
            // 
            this.monitor.Controls.Add(this.memlist);
            this.monitor.Controls.Add(this.instptr);
            this.monitor.Controls.Add(this.memptr);
            this.monitor.Location = new System.Drawing.Point(4, 22);
            this.monitor.Name = "monitor";
            this.monitor.Size = new System.Drawing.Size(384, 243);
            this.monitor.TabIndex = 2;
            this.monitor.Text = "Monitor";
            this.monitor.UseVisualStyleBackColor = true;
            // 
            // consoleout
            // 
            this.consoleout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.consoleout.Location = new System.Drawing.Point(3, 3);
            this.consoleout.Multiline = true;
            this.consoleout.Name = "consoleout";
            this.consoleout.ReadOnly = true;
            this.consoleout.Size = new System.Drawing.Size(378, 237);
            this.consoleout.TabIndex = 0;
            // 
            // programinput
            // 
            this.programinput.Location = new System.Drawing.Point(3, 0);
            this.programinput.Multiline = true;
            this.programinput.Name = "programinput";
            this.programinput.Size = new System.Drawing.Size(378, 218);
            this.programinput.TabIndex = 0;
            // 
            // load
            // 
            this.load.Location = new System.Drawing.Point(6, 217);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(115, 23);
            this.load.TabIndex = 1;
            this.load.Text = "Load";
            this.load.UseVisualStyleBackColor = true;
            this.load.Click += new System.EventHandler(this.load_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(127, 217);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(114, 23);
            this.save.TabIndex = 2;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // memptr
            // 
            this.memptr.AutoSize = true;
            this.memptr.Location = new System.Drawing.Point(8, 8);
            this.memptr.Name = "memptr";
            this.memptr.Size = new System.Drawing.Size(56, 13);
            this.memptr.TabIndex = 0;
            this.memptr.Text = "Memory: 0";
            // 
            // instptr
            // 
            this.instptr.AutoSize = true;
            this.instptr.Location = new System.Drawing.Point(8, 21);
            this.instptr.Name = "instptr";
            this.instptr.Size = new System.Drawing.Size(68, 13);
            this.instptr.TabIndex = 1;
            this.instptr.Text = "Instruction: 0";
            // 
            // memlist
            // 
            this.memlist.FormattingEnabled = true;
            this.memlist.Location = new System.Drawing.Point(11, 37);
            this.memlist.Name = "memlist";
            this.memlist.ScrollAlwaysVisible = true;
            this.memlist.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.memlist.Size = new System.Drawing.Size(370, 199);
            this.memlist.TabIndex = 2;
            // 
            // run
            // 
            this.run.Location = new System.Drawing.Point(247, 217);
            this.run.Name = "run";
            this.run.Size = new System.Drawing.Size(131, 23);
            this.run.TabIndex = 3;
            this.run.Text = "Run";
            this.run.UseVisualStyleBackColor = true;
            this.run.Click += new System.EventHandler(this.run_Click);
            // 
            // MindBlow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabs);
            this.Name = "MindBlow";
            this.Size = new System.Drawing.Size(392, 269);
            this.Resize += new System.EventHandler(this.MindBlow_Resize);
            this.tabs.ResumeLayout(false);
            this.console.ResumeLayout(false);
            this.console.PerformLayout();
            this.program.ResumeLayout(false);
            this.program.PerformLayout();
            this.monitor.ResumeLayout(false);
            this.monitor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage console;
        private System.Windows.Forms.TabPage program;
        private System.Windows.Forms.TabPage monitor;
        private System.Windows.Forms.TextBox consoleout;
        private System.Windows.Forms.TextBox programinput;
        private System.Windows.Forms.Button load;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Label instptr;
        private System.Windows.Forms.Label memptr;
        private System.Windows.Forms.ListBox memlist;
        private System.Windows.Forms.Button run;
    }
}

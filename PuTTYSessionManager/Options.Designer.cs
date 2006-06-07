/* 
 * Copyright (C) 2006 David Riseley 
 *
 * This program is free software; you can redistribute it and/or
 * modify it under the terms of the GNU General Public License
 * as published by the Free Software Foundation; either version 2
 * of the License, or (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program; if not, write to the Free Software
 * Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.
 */
namespace uk.org.riseley.puttySessionManager
{
    partial class Options
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
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.onTopCheckBox = new System.Windows.Forms.CheckBox();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.sampletextTextbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.locatePuttyButton = new System.Windows.Forms.Button();
            this.puttyLocation = new System.Windows.Forms.TextBox();
            this.transparencyCheckBox = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.okButton = new System.Windows.Forms.Button();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "putty.exe";
            this.openFileDialog.Filter = "putty.exe|putty.exe|All Files|*.*";
            this.openFileDialog.InitialDirectory = "C:\\Program Files\\PuTTY\\";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.onTopCheckBox);
            this.groupBox1.Controls.Add(this.trackBar);
            this.groupBox1.Controls.Add(this.sampletextTextbox);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.locatePuttyButton);
            this.groupBox1.Controls.Add(this.puttyLocation);
            this.groupBox1.Controls.Add(this.transparencyCheckBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 190);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // onTopCheckBox
            // 
            this.onTopCheckBox.AutoSize = true;
            this.onTopCheckBox.Checked = global::uk.org.riseley.puttySessionManager.Properties.Settings.Default.AlwaysOnTop;
            this.onTopCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.onTopCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::uk.org.riseley.puttySessionManager.Properties.Settings.Default, "AlwaysOnTop", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.onTopCheckBox.Location = new System.Drawing.Point(123, 19);
            this.onTopCheckBox.Name = "onTopCheckBox";
            this.onTopCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.onTopCheckBox.Size = new System.Drawing.Size(92, 17);
            this.onTopCheckBox.TabIndex = 6;
            this.onTopCheckBox.Text = "Always on top";
            this.onTopCheckBox.UseVisualStyleBackColor = true;
            // 
            // trackBar
            // 
            this.trackBar.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", global::uk.org.riseley.puttySessionManager.Properties.Settings.Default, "TransparencyEnabled", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.trackBar.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::uk.org.riseley.puttySessionManager.Properties.Settings.Default, "TransparencyValueInt", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.trackBar.Enabled = global::uk.org.riseley.puttySessionManager.Properties.Settings.Default.TransparencyEnabled;
            this.trackBar.Location = new System.Drawing.Point(15, 56);
            this.trackBar.Maximum = 99;
            this.trackBar.Minimum = 20;
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(332, 45);
            this.trackBar.TabIndex = 5;
            this.trackBar.Value = global::uk.org.riseley.puttySessionManager.Properties.Settings.Default.TransparencyValueInt;
            // 
            // sampletextTextbox
            // 
            this.sampletextTextbox.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::uk.org.riseley.puttySessionManager.Properties.Settings.Default, "TreeFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.sampletextTextbox.Font = global::uk.org.riseley.puttySessionManager.Properties.Settings.Default.TreeFont;
            this.sampletextTextbox.Location = new System.Drawing.Point(116, 137);
            this.sampletextTextbox.Name = "sampletextTextbox";
            this.sampletextTextbox.ReadOnly = true;
            this.sampletextTextbox.Size = new System.Drawing.Size(232, 20);
            this.sampletextTextbox.TabIndex = 4;
            this.sampletextTextbox.Text = "Sample Text for Tree";
            this.sampletextTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 22);
            this.button1.TabIndex = 3;
            this.button1.Text = "Choose Font";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // locatePuttyButton
            // 
            this.locatePuttyButton.Location = new System.Drawing.Point(15, 107);
            this.locatePuttyButton.Name = "locatePuttyButton";
            this.locatePuttyButton.Size = new System.Drawing.Size(98, 22);
            this.locatePuttyButton.TabIndex = 2;
            this.locatePuttyButton.Text = "Locate putty.exe";
            this.locatePuttyButton.UseVisualStyleBackColor = true;
            this.locatePuttyButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // puttyLocation
            // 
            this.puttyLocation.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::uk.org.riseley.puttySessionManager.Properties.Settings.Default, "PuttyLocation", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.puttyLocation.Location = new System.Drawing.Point(116, 107);
            this.puttyLocation.Name = "puttyLocation";
            this.puttyLocation.ReadOnly = true;
            this.puttyLocation.Size = new System.Drawing.Size(232, 20);
            this.puttyLocation.TabIndex = 1;
            this.puttyLocation.Text = global::uk.org.riseley.puttySessionManager.Properties.Settings.Default.PuttyLocation;
            // 
            // transparencyCheckBox
            // 
            this.transparencyCheckBox.AutoSize = true;
            this.transparencyCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.transparencyCheckBox.Checked = global::uk.org.riseley.puttySessionManager.Properties.Settings.Default.TransparencyEnabled;
            this.transparencyCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::uk.org.riseley.puttySessionManager.Properties.Settings.Default, "TransparencyEnabled", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.transparencyCheckBox.Location = new System.Drawing.Point(88, 42);
            this.transparencyCheckBox.Name = "transparencyCheckBox";
            this.transparencyCheckBox.Size = new System.Drawing.Size(127, 17);
            this.transparencyCheckBox.TabIndex = 0;
            this.transparencyCheckBox.Text = "Enable Transparency";
            this.transparencyCheckBox.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.okButton, 0, 1);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.35354F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.64646F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(369, 230);
            this.tableLayoutPanel.TabIndex = 1;
            // 
            // okButton
            // 
            this.okButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(151, 202);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(67, 22);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // fontDialog
            // 
            this.fontDialog.Font = global::uk.org.riseley.puttySessionManager.Properties.Settings.Default.TreeFont;
            this.fontDialog.ShowColor = true;
            this.fontDialog.ShowEffects = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(15, 162);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 22);
            this.button2.TabIndex = 7;
            this.button2.Text = "Edit Hotkeys...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Options
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 230);
            this.Controls.Add(this.tableLayoutPanel);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(369, 252);
            this.Name = "Options";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Options";
            this.TopMost = true;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            this.tableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button locatePuttyButton;
        private System.Windows.Forms.TextBox puttyLocation;
        private System.Windows.Forms.CheckBox transparencyCheckBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.TextBox sampletextTextbox;
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.CheckBox onTopCheckBox;
        private System.Windows.Forms.Button button2;
    }
}
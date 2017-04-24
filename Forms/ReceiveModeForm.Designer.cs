#region Copyright
//=======================================================================================
// Microsoft Azure Customer Advisory Team 
//
// This sample is supplemental to the technical guidance published on my personal
// blog at http://blogs.msdn.com/b/paolos/. 
// 
// Author: Paolo Salvatori
//=======================================================================================
// Copyright (c) Microsoft Corporation. All rights reserved.
// 
// LICENSED UNDER THE APACHE LICENSE, VERSION 2.0 (THE "LICENSE"); YOU MAY NOT USE THESE 
// FILES EXCEPT IN COMPLIANCE WITH THE LICENSE. YOU MAY OBTAIN A COPY OF THE LICENSE AT 
// http://www.apache.org/licenses/LICENSE-2.0
// UNLESS REQUIRED BY APPLICABLE LAW OR AGREED TO IN WRITING, SOFTWARE DISTRIBUTED UNDER THE 
// LICENSE IS DISTRIBUTED ON AN "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY 
// KIND, EITHER EXPRESS OR IMPLIED. SEE THE LICENSE FOR THE SPECIFIC LANGUAGE GOVERNING 
// PERMISSIONS AND LIMITATIONS UNDER THE LICENSE.
//=======================================================================================
#endregion

using Microsoft.Azure.ServiceBusExplorer.Controls;

namespace Microsoft.Azure.ServiceBusExplorer.Forms
{
    partial class ReceiveModeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        #region Private Fields
        private System.ComponentModel.IContainer components = null;
        #endregion

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceiveModeForm));
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.grouper1 = new Microsoft.Azure.ServiceBusExplorer.Controls.Grouper();
            this.txtEncryptionKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbEncryptionType = new System.Windows.Forms.ComboBox();
            this.grouperInspector = new Microsoft.Azure.ServiceBusExplorer.Controls.Grouper();
            this.cboReceiverInspector = new System.Windows.Forms.ComboBox();
            this.grouperMessages = new Microsoft.Azure.ServiceBusExplorer.Controls.Grouper();
            this.txtMessageCount = new System.Windows.Forms.TextBox();
            this.btnTop = new System.Windows.Forms.RadioButton();
            this.btnAll = new System.Windows.Forms.RadioButton();
            this.grouperReadMode = new Microsoft.Azure.ServiceBusExplorer.Controls.Grouper();
            this.btnReceive = new System.Windows.Forms.RadioButton();
            this.btnPeek = new System.Windows.Forms.RadioButton();
            this.mainPanel.SuspendLayout();
            this.grouper1.SuspendLayout();
            this.grouperInspector.SuspendLayout();
            this.grouperMessages.SuspendLayout();
            this.grouperReadMode.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.btnOk.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.btnOk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.btnOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Location = new System.Drawing.Point(444, 438);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(108, 37);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            this.btnOk.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.btnOk.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(564, 438);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(108, 37);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            this.btnCancel.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.btnCancel.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.BackColor = System.Drawing.SystemColors.Window;
            this.mainPanel.Controls.Add(this.grouper1);
            this.mainPanel.Controls.Add(this.grouperInspector);
            this.mainPanel.Controls.Add(this.grouperMessages);
            this.mainPanel.Controls.Add(this.grouperReadMode);
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(696, 428);
            this.mainPanel.TabIndex = 0;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            // 
            // grouper1
            // 
            this.grouper1.BackgroundColor = System.Drawing.Color.White;
            this.grouper1.BackgroundGradientColor = System.Drawing.Color.White;
            this.grouper1.BackgroundGradientMode = Microsoft.Azure.ServiceBusExplorer.Controls.Grouper.GroupBoxGradientMode.None;
            this.grouper1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.grouper1.BorderThickness = 1F;
            this.grouper1.Controls.Add(this.txtEncryptionKey);
            this.grouper1.Controls.Add(this.label1);
            this.grouper1.Controls.Add(this.cmbEncryptionType);
            this.grouper1.CustomGroupBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.grouper1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.grouper1.ForeColor = System.Drawing.Color.White;
            this.grouper1.GroupImage = null;
            this.grouper1.GroupTitle = "Encryption";
            this.grouper1.Location = new System.Drawing.Point(24, 244);
            this.grouper1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grouper1.Name = "grouper1";
            this.grouper1.Padding = new System.Windows.Forms.Padding(30, 31, 30, 31);
            this.grouper1.PaintGroupBox = true;
            this.grouper1.RoundCorners = 4;
            this.grouper1.ShadowColor = System.Drawing.Color.DarkGray;
            this.grouper1.ShadowControl = false;
            this.grouper1.ShadowThickness = 1;
            this.grouper1.Size = new System.Drawing.Size(648, 156);
            this.grouper1.TabIndex = 44;
            this.grouper1.CustomPaint += new System.Action<System.Windows.Forms.PaintEventArgs>(this.grouperInspector_CustomPaint);
            // 
            // txtEncryptionKey
            // 
            this.txtEncryptionKey.Location = new System.Drawing.Point(120, 105);
            this.txtEncryptionKey.Name = "txtEncryptionKey";
            this.txtEncryptionKey.Size = new System.Drawing.Size(502, 26);
            this.txtEncryptionKey.TabIndex = 94;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(20, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 20);
            this.label1.TabIndex = 93;
            this.label1.Text = "Key";
            // 
            // cmbEncryptionType
            // 
            this.cmbEncryptionType.BackColor = System.Drawing.SystemColors.Window;
            this.cmbEncryptionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEncryptionType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbEncryptionType.FormattingEnabled = true;
            this.cmbEncryptionType.Location = new System.Drawing.Point(24, 49);
            this.cmbEncryptionType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbEncryptionType.Name = "cmbEncryptionType";
            this.cmbEncryptionType.Size = new System.Drawing.Size(598, 28);
            this.cmbEncryptionType.TabIndex = 92;
            // 
            // grouperInspector
            // 
            this.grouperInspector.BackgroundColor = System.Drawing.Color.White;
            this.grouperInspector.BackgroundGradientColor = System.Drawing.Color.White;
            this.grouperInspector.BackgroundGradientMode = Microsoft.Azure.ServiceBusExplorer.Controls.Grouper.GroupBoxGradientMode.None;
            this.grouperInspector.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.grouperInspector.BorderThickness = 1F;
            this.grouperInspector.Controls.Add(this.cboReceiverInspector);
            this.grouperInspector.CustomGroupBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.grouperInspector.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.grouperInspector.ForeColor = System.Drawing.Color.White;
            this.grouperInspector.GroupImage = null;
            this.grouperInspector.GroupTitle = "Message Inspector";
            this.grouperInspector.Location = new System.Drawing.Point(24, 123);
            this.grouperInspector.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grouperInspector.Name = "grouperInspector";
            this.grouperInspector.Padding = new System.Windows.Forms.Padding(30, 31, 30, 31);
            this.grouperInspector.PaintGroupBox = true;
            this.grouperInspector.RoundCorners = 4;
            this.grouperInspector.ShadowColor = System.Drawing.Color.DarkGray;
            this.grouperInspector.ShadowControl = false;
            this.grouperInspector.ShadowThickness = 1;
            this.grouperInspector.Size = new System.Drawing.Size(648, 111);
            this.grouperInspector.TabIndex = 43;
            this.grouperInspector.CustomPaint += new System.Action<System.Windows.Forms.PaintEventArgs>(this.grouperInspector_CustomPaint);
            // 
            // cboReceiverInspector
            // 
            this.cboReceiverInspector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboReceiverInspector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboReceiverInspector.FormattingEnabled = true;
            this.cboReceiverInspector.Location = new System.Drawing.Point(24, 49);
            this.cboReceiverInspector.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboReceiverInspector.Name = "cboReceiverInspector";
            this.cboReceiverInspector.Size = new System.Drawing.Size(598, 28);
            this.cboReceiverInspector.TabIndex = 92;
            // 
            // grouperMessages
            // 
            this.grouperMessages.BackgroundColor = System.Drawing.Color.White;
            this.grouperMessages.BackgroundGradientColor = System.Drawing.Color.White;
            this.grouperMessages.BackgroundGradientMode = Microsoft.Azure.ServiceBusExplorer.Controls.Grouper.GroupBoxGradientMode.None;
            this.grouperMessages.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.grouperMessages.BorderThickness = 1F;
            this.grouperMessages.Controls.Add(this.txtMessageCount);
            this.grouperMessages.Controls.Add(this.btnTop);
            this.grouperMessages.Controls.Add(this.btnAll);
            this.grouperMessages.CustomGroupBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.grouperMessages.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.grouperMessages.ForeColor = System.Drawing.Color.White;
            this.grouperMessages.GroupImage = null;
            this.grouperMessages.GroupTitle = "Message Count";
            this.grouperMessages.Location = new System.Drawing.Point(360, 12);
            this.grouperMessages.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grouperMessages.Name = "grouperMessages";
            this.grouperMessages.Padding = new System.Windows.Forms.Padding(30, 31, 30, 31);
            this.grouperMessages.PaintGroupBox = true;
            this.grouperMessages.RoundCorners = 4;
            this.grouperMessages.ShadowColor = System.Drawing.Color.DarkGray;
            this.grouperMessages.ShadowControl = false;
            this.grouperMessages.ShadowThickness = 1;
            this.grouperMessages.Size = new System.Drawing.Size(312, 98);
            this.grouperMessages.TabIndex = 42;
            // 
            // txtMessageCount
            // 
            this.txtMessageCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMessageCount.Location = new System.Drawing.Point(168, 49);
            this.txtMessageCount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMessageCount.Name = "txtMessageCount";
            this.txtMessageCount.Size = new System.Drawing.Size(118, 26);
            this.txtMessageCount.TabIndex = 42;
            this.txtMessageCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMessageCount_KeyPress);
            // 
            // btnTop
            // 
            this.btnTop.AutoSize = true;
            this.btnTop.Checked = true;
            this.btnTop.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTop.Location = new System.Drawing.Point(96, 49);
            this.btnTop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTop.Name = "btnTop";
            this.btnTop.Size = new System.Drawing.Size(62, 24);
            this.btnTop.TabIndex = 41;
            this.btnTop.TabStop = true;
            this.btnTop.Text = "Top";
            this.btnTop.UseVisualStyleBackColor = true;
            this.btnTop.CheckedChanged += new System.EventHandler(this.btnTop_CheckedChanged);
            // 
            // btnAll
            // 
            this.btnAll.AutoSize = true;
            this.btnAll.Enabled = false;
            this.btnAll.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAll.Location = new System.Drawing.Point(24, 49);
            this.btnAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(53, 24);
            this.btnAll.TabIndex = 40;
            this.btnAll.Text = "All";
            this.btnAll.UseVisualStyleBackColor = true;
            // 
            // grouperReadMode
            // 
            this.grouperReadMode.BackgroundColor = System.Drawing.Color.White;
            this.grouperReadMode.BackgroundGradientColor = System.Drawing.Color.White;
            this.grouperReadMode.BackgroundGradientMode = Microsoft.Azure.ServiceBusExplorer.Controls.Grouper.GroupBoxGradientMode.None;
            this.grouperReadMode.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.grouperReadMode.BorderThickness = 1F;
            this.grouperReadMode.Controls.Add(this.btnReceive);
            this.grouperReadMode.Controls.Add(this.btnPeek);
            this.grouperReadMode.CustomGroupBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.grouperReadMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.grouperReadMode.ForeColor = System.Drawing.Color.White;
            this.grouperReadMode.GroupImage = null;
            this.grouperReadMode.GroupTitle = "Receive Mode";
            this.grouperReadMode.Location = new System.Drawing.Point(24, 12);
            this.grouperReadMode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grouperReadMode.Name = "grouperReadMode";
            this.grouperReadMode.Padding = new System.Windows.Forms.Padding(30, 31, 30, 31);
            this.grouperReadMode.PaintGroupBox = true;
            this.grouperReadMode.RoundCorners = 4;
            this.grouperReadMode.ShadowColor = System.Drawing.Color.DarkGray;
            this.grouperReadMode.ShadowControl = false;
            this.grouperReadMode.ShadowThickness = 1;
            this.grouperReadMode.Size = new System.Drawing.Size(312, 98);
            this.grouperReadMode.TabIndex = 41;
            // 
            // btnReceive
            // 
            this.btnReceive.AutoSize = true;
            this.btnReceive.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnReceive.Location = new System.Drawing.Point(120, 49);
            this.btnReceive.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReceive.Name = "btnReceive";
            this.btnReceive.Size = new System.Drawing.Size(180, 24);
            this.btnReceive.TabIndex = 39;
            this.btnReceive.Text = "Receive and Delete";
            this.btnReceive.UseVisualStyleBackColor = true;
            this.btnReceive.CheckedChanged += new System.EventHandler(this.receiveMode_CheckedChanged);
            // 
            // btnPeek
            // 
            this.btnPeek.AutoSize = true;
            this.btnPeek.Checked = true;
            this.btnPeek.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPeek.Location = new System.Drawing.Point(24, 49);
            this.btnPeek.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPeek.Name = "btnPeek";
            this.btnPeek.Size = new System.Drawing.Size(71, 24);
            this.btnPeek.TabIndex = 38;
            this.btnPeek.TabStop = true;
            this.btnPeek.Text = "Peek";
            this.btnPeek.UseVisualStyleBackColor = true;
            this.btnPeek.CheckedChanged += new System.EventHandler(this.receiveMode_CheckedChanged);
            // 
            // ReceiveModeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(696, 494);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReceiveModeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enter Value";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ReceiveModeForm_KeyPress);
            this.mainPanel.ResumeLayout(false);
            this.grouper1.ResumeLayout(false);
            this.grouper1.PerformLayout();
            this.grouperInspector.ResumeLayout(false);
            this.grouperMessages.ResumeLayout(false);
            this.grouperMessages.PerformLayout();
            this.grouperReadMode.ResumeLayout(false);
            this.grouperReadMode.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel mainPanel;
        private Grouper grouperMessages;
        private System.Windows.Forms.TextBox txtMessageCount;
        private System.Windows.Forms.RadioButton btnTop;
        private System.Windows.Forms.RadioButton btnAll;
        private Grouper grouperReadMode;
        private System.Windows.Forms.RadioButton btnReceive;
        private System.Windows.Forms.RadioButton btnPeek;
        private Grouper grouperInspector;
        private System.Windows.Forms.ComboBox cboReceiverInspector;
        private Grouper grouper1;
        private System.Windows.Forms.ComboBox cmbEncryptionType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEncryptionKey;
    }
}
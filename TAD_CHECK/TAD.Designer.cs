using System;
using System.Windows.Forms;

namespace TAD_CHECK
{
    partial class TAD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TAD));
            this.UserText = new System.Windows.Forms.Label();
            this.Connect = new System.Windows.Forms.Button();
            this.XIP = new System.Windows.Forms.Label();
            this.XPORT = new System.Windows.Forms.Label();
            this.IP_input = new System.Windows.Forms.TextBox();
            this.Port_input = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DIO1 = new System.Windows.Forms.Button();
            this.DIO0 = new System.Windows.Forms.Button();
            this.HILO2 = new System.Windows.Forms.Button();
            this.DIO2_Label = new System.Windows.Forms.Button();
            this._READ = new System.Windows.Forms.Label();
            this._WRITE = new System.Windows.Forms.Label();
            this.cancel = new System.Windows.Forms.Button();
            this.minimise = new System.Windows.Forms.Button();
            this.Error_Prompt = new System.Windows.Forms.Label();
            this.Read_Prompt = new System.Windows.Forms.Label();
            this.HILO3 = new System.Windows.Forms.Button();
            this.DIO3_Label = new System.Windows.Forms.Button();
            this.DIO0_ = new System.Windows.Forms.Label();
            this.DIO1_ = new System.Windows.Forms.Label();
            this.reading_panel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.WRITE2 = new System.Windows.Forms.Button();
            this.WRITE3 = new System.Windows.Forms.Button();
            this.READ_BOTH = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.reading_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserText
            // 
            this.UserText.BackColor = System.Drawing.Color.Transparent;
            this.UserText.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserText.ForeColor = System.Drawing.Color.White;
            this.UserText.Location = new System.Drawing.Point(36, 172);
            this.UserText.Name = "UserText";
            this.UserText.Size = new System.Drawing.Size(161, 14);
            this.UserText.TabIndex = 9;
            this.UserText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Connect
            // 
            this.Connect.BackColor = System.Drawing.Color.Transparent;
            this.Connect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Connect.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Connect.FlatAppearance.BorderSize = 2;
            this.Connect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.Connect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.Connect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Connect.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Connect.ForeColor = System.Drawing.Color.White;
            this.Connect.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Connect.Location = new System.Drawing.Point(38, 304);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(159, 31);
            this.Connect.TabIndex = 17;
            this.Connect.Text = "CONNECT";
            this.Connect.UseVisualStyleBackColor = false;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // XIP
            // 
            this.XIP.BackColor = System.Drawing.Color.White;
            this.XIP.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XIP.ForeColor = System.Drawing.Color.Red;
            this.XIP.Location = new System.Drawing.Point(175, 216);
            this.XIP.Margin = new System.Windows.Forms.Padding(0);
            this.XIP.Name = "XIP";
            this.XIP.Size = new System.Drawing.Size(16, 25);
            this.XIP.TabIndex = 11;
            this.XIP.Text = "X";
            this.XIP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.XIP.Visible = false;
            // 
            // XPORT
            // 
            this.XPORT.BackColor = System.Drawing.Color.White;
            this.XPORT.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XPORT.ForeColor = System.Drawing.Color.Red;
            this.XPORT.Location = new System.Drawing.Point(175, 262);
            this.XPORT.Margin = new System.Windows.Forms.Padding(0);
            this.XPORT.Name = "XPORT";
            this.XPORT.Size = new System.Drawing.Size(14, 25);
            this.XPORT.TabIndex = 12;
            this.XPORT.Text = "X";
            this.XPORT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.XPORT.Visible = false;
            // 
            // IP_input
            // 
            this.IP_input.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.IP_input.BackColor = System.Drawing.Color.White;
            this.IP_input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IP_input.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IP_input.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.IP_input.Location = new System.Drawing.Point(36, 215);
            this.IP_input.MaxLength = 15;
            this.IP_input.Name = "IP_input";
            this.IP_input.Size = new System.Drawing.Size(161, 27);
            this.IP_input.TabIndex = 15;
            this.IP_input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.IP_input_KeyDown);
            // 
            // Port_input
            // 
            this.Port_input.BackColor = System.Drawing.Color.White;
            this.Port_input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Port_input.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Port_input.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Port_input.Location = new System.Drawing.Point(36, 261);
            this.Port_input.MaxLength = 5;
            this.Port_input.Name = "Port_input";
            this.Port_input.Size = new System.Drawing.Size(161, 27);
            this.Port_input.TabIndex = 16;
            this.Port_input.Text = "5001";
            this.Port_input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Port_input_KeyDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(38, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(33, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "IP ADDRESS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(33, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 14);
            this.label2.TabIndex = 19;
            this.label2.Text = "PORT";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DIO1
            // 
            this.DIO1.BackColor = System.Drawing.Color.Transparent;
            this.DIO1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DIO1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.DIO1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DIO1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.DIO1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DIO1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DIO1.ForeColor = System.Drawing.Color.White;
            this.DIO1.Location = new System.Drawing.Point(334, 215);
            this.DIO1.Margin = new System.Windows.Forms.Padding(0);
            this.DIO1.Name = "DIO1";
            this.DIO1.Size = new System.Drawing.Size(49, 23);
            this.DIO1.TabIndex = 59;
            this.DIO1.TabStop = false;
            this.DIO1.Text = "DIO1";
            this.DIO1.UseVisualStyleBackColor = false;
            this.DIO1.Click += new System.EventHandler(this.DIO1_READ_Click);
            // 
            // DIO0
            // 
            this.DIO0.BackColor = System.Drawing.Color.Transparent;
            this.DIO0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DIO0.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.DIO0.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DIO0.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.DIO0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DIO0.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DIO0.ForeColor = System.Drawing.Color.White;
            this.DIO0.Location = new System.Drawing.Point(279, 215);
            this.DIO0.Margin = new System.Windows.Forms.Padding(0);
            this.DIO0.Name = "DIO0";
            this.DIO0.Size = new System.Drawing.Size(49, 23);
            this.DIO0.TabIndex = 58;
            this.DIO0.TabStop = false;
            this.DIO0.Text = "DIO0";
            this.DIO0.UseVisualStyleBackColor = false;
            this.DIO0.Click += new System.EventHandler(this.DIO0_READ_Click);
            // 
            // HILO2
            // 
            this.HILO2.BackColor = System.Drawing.Color.Transparent;
            this.HILO2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HILO2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.HILO2.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.HILO2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.HILO2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HILO2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HILO2.ForeColor = System.Drawing.Color.White;
            this.HILO2.Location = new System.Drawing.Point(334, 114);
            this.HILO2.Margin = new System.Windows.Forms.Padding(0);
            this.HILO2.Name = "HILO2";
            this.HILO2.Size = new System.Drawing.Size(49, 23);
            this.HILO2.TabIndex = 57;
            this.HILO2.TabStop = false;
            this.HILO2.Text = "LOW";
            this.HILO2.UseVisualStyleBackColor = false;
            this.HILO2.Click += new System.EventHandler(this.HILO2_Click);
            // 
            // DIO2_Label
            // 
            this.DIO2_Label.BackColor = System.Drawing.Color.Transparent;
            this.DIO2_Label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DIO2_Label.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.DIO2_Label.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DIO2_Label.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.DIO2_Label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DIO2_Label.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DIO2_Label.ForeColor = System.Drawing.Color.White;
            this.DIO2_Label.Location = new System.Drawing.Point(279, 114);
            this.DIO2_Label.Margin = new System.Windows.Forms.Padding(0);
            this.DIO2_Label.Name = "DIO2_Label";
            this.DIO2_Label.Size = new System.Drawing.Size(49, 23);
            this.DIO2_Label.TabIndex = 56;
            this.DIO2_Label.TabStop = false;
            this.DIO2_Label.Text = "DIO2";
            this.DIO2_Label.UseVisualStyleBackColor = false;
            // 
            // _READ
            // 
            this._READ.BackColor = System.Drawing.Color.Transparent;
            this._READ.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._READ.ForeColor = System.Drawing.Color.Transparent;
            this._READ.Location = new System.Drawing.Point(250, 178);
            this._READ.Name = "_READ";
            this._READ.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._READ.Size = new System.Drawing.Size(217, 23);
            this._READ.TabIndex = 49;
            this._READ.Text = "READ";
            this._READ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _WRITE
            // 
            this._WRITE.BackColor = System.Drawing.Color.Transparent;
            this._WRITE.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._WRITE.ForeColor = System.Drawing.Color.Transparent;
            this._WRITE.Location = new System.Drawing.Point(249, 77);
            this._WRITE.Name = "_WRITE";
            this._WRITE.Size = new System.Drawing.Size(218, 23);
            this._WRITE.TabIndex = 48;
            this._WRITE.Text = "WRITE";
            this._WRITE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cancel
            // 
            this.cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cancel.BackColor = System.Drawing.Color.Transparent;
            this.cancel.FlatAppearance.BorderSize = 0;
            this.cancel.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.ForeColor = System.Drawing.Color.White;
            this.cancel.Location = new System.Drawing.Point(196, 3);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(26, 34);
            this.cancel.TabIndex = 62;
            this.cancel.TabStop = false;
            this.cancel.Text = "X";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // minimise
            // 
            this.minimise.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimise.BackColor = System.Drawing.Color.Transparent;
            this.minimise.FlatAppearance.BorderSize = 0;
            this.minimise.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.minimise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimise.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimise.ForeColor = System.Drawing.Color.White;
            this.minimise.Location = new System.Drawing.Point(163, 3);
            this.minimise.Name = "minimise";
            this.minimise.Size = new System.Drawing.Size(26, 34);
            this.minimise.TabIndex = 63;
            this.minimise.TabStop = false;
            this.minimise.Text = "-";
            this.minimise.UseMnemonic = false;
            this.minimise.UseVisualStyleBackColor = false;
            this.minimise.Click += new System.EventHandler(this.Minimise_Click);
            // 
            // Error_Prompt
            // 
            this.Error_Prompt.BackColor = System.Drawing.Color.Transparent;
            this.Error_Prompt.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Error_Prompt.ForeColor = System.Drawing.Color.White;
            this.Error_Prompt.Location = new System.Drawing.Point(250, 251);
            this.Error_Prompt.Name = "Error_Prompt";
            this.Error_Prompt.Size = new System.Drawing.Size(217, 20);
            this.Error_Prompt.TabIndex = 64;
            this.Error_Prompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Read_Prompt
            // 
            this.Read_Prompt.BackColor = System.Drawing.Color.Transparent;
            this.Read_Prompt.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Read_Prompt.ForeColor = System.Drawing.Color.White;
            this.Read_Prompt.Location = new System.Drawing.Point(250, 274);
            this.Read_Prompt.Name = "Read_Prompt";
            this.Read_Prompt.Size = new System.Drawing.Size(217, 20);
            this.Read_Prompt.TabIndex = 65;
            this.Read_Prompt.Text = "[DIO#] [INPUT/OUTPUT] [LOW/HIGH]";
            this.Read_Prompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HILO3
            // 
            this.HILO3.BackColor = System.Drawing.Color.Transparent;
            this.HILO3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HILO3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.HILO3.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.HILO3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.HILO3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HILO3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HILO3.ForeColor = System.Drawing.Color.White;
            this.HILO3.Location = new System.Drawing.Point(334, 146);
            this.HILO3.Margin = new System.Windows.Forms.Padding(0);
            this.HILO3.Name = "HILO3";
            this.HILO3.Size = new System.Drawing.Size(49, 23);
            this.HILO3.TabIndex = 67;
            this.HILO3.TabStop = false;
            this.HILO3.Text = "LOW";
            this.HILO3.UseVisualStyleBackColor = false;
            this.HILO3.Click += new System.EventHandler(this.HILO3_Click);
            // 
            // DIO3_Label
            // 
            this.DIO3_Label.BackColor = System.Drawing.Color.Transparent;
            this.DIO3_Label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DIO3_Label.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.DIO3_Label.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DIO3_Label.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.DIO3_Label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DIO3_Label.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DIO3_Label.ForeColor = System.Drawing.Color.White;
            this.DIO3_Label.Location = new System.Drawing.Point(279, 146);
            this.DIO3_Label.Margin = new System.Windows.Forms.Padding(0);
            this.DIO3_Label.Name = "DIO3_Label";
            this.DIO3_Label.Size = new System.Drawing.Size(49, 23);
            this.DIO3_Label.TabIndex = 66;
            this.DIO3_Label.TabStop = false;
            this.DIO3_Label.Text = "DIO3";
            this.DIO3_Label.UseVisualStyleBackColor = false;
            // 
            // DIO0_
            // 
            this.DIO0_.BackColor = System.Drawing.Color.Transparent;
            this.DIO0_.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DIO0_.ForeColor = System.Drawing.Color.Red;
            this.DIO0_.Location = new System.Drawing.Point(250, 297);
            this.DIO0_.Name = "DIO0_";
            this.DIO0_.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DIO0_.Size = new System.Drawing.Size(217, 20);
            this.DIO0_.TabIndex = 68;
            this.DIO0_.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DIO1_
            // 
            this.DIO1_.BackColor = System.Drawing.Color.Transparent;
            this.DIO1_.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DIO1_.ForeColor = System.Drawing.Color.Red;
            this.DIO1_.Location = new System.Drawing.Point(250, 320);
            this.DIO1_.Name = "DIO1_";
            this.DIO1_.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DIO1_.Size = new System.Drawing.Size(217, 20);
            this.DIO1_.TabIndex = 69;
            this.DIO1_.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reading_panel
            // 
            this.reading_panel.BackColor = System.Drawing.Color.Transparent;
            this.reading_panel.Controls.Add(this.label3);
            this.reading_panel.Location = new System.Drawing.Point(253, 77);
            this.reading_panel.Name = "reading_panel";
            this.reading_panel.Size = new System.Drawing.Size(225, 173);
            this.reading_panel.TabIndex = 70;
            this.reading_panel.Visible = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 59);
            this.label3.TabIndex = 0;
            this.label3.Text = "TESTING . . .";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WRITE2
            // 
            this.WRITE2.BackColor = System.Drawing.Color.Transparent;
            this.WRITE2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WRITE2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.WRITE2.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.WRITE2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.WRITE2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WRITE2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WRITE2.ForeColor = System.Drawing.Color.White;
            this.WRITE2.Location = new System.Drawing.Point(389, 114);
            this.WRITE2.Margin = new System.Windows.Forms.Padding(0);
            this.WRITE2.Name = "WRITE2";
            this.WRITE2.Size = new System.Drawing.Size(52, 23);
            this.WRITE2.TabIndex = 71;
            this.WRITE2.TabStop = false;
            this.WRITE2.Text = "WRITE";
            this.WRITE2.UseVisualStyleBackColor = false;
            this.WRITE2.Click += new System.EventHandler(this.WRITE2_Click);
            // 
            // WRITE3
            // 
            this.WRITE3.BackColor = System.Drawing.Color.Transparent;
            this.WRITE3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WRITE3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.WRITE3.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.WRITE3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.WRITE3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WRITE3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WRITE3.ForeColor = System.Drawing.Color.White;
            this.WRITE3.Location = new System.Drawing.Point(389, 146);
            this.WRITE3.Margin = new System.Windows.Forms.Padding(0);
            this.WRITE3.Name = "WRITE3";
            this.WRITE3.Size = new System.Drawing.Size(52, 23);
            this.WRITE3.TabIndex = 72;
            this.WRITE3.TabStop = false;
            this.WRITE3.Text = "WRITE";
            this.WRITE3.UseVisualStyleBackColor = false;
            this.WRITE3.Click += new System.EventHandler(this.WRITE3_Click);
            // 
            // READ_BOTH
            // 
            this.READ_BOTH.BackColor = System.Drawing.Color.Transparent;
            this.READ_BOTH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.READ_BOTH.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.READ_BOTH.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.READ_BOTH.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.READ_BOTH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.READ_BOTH.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.READ_BOTH.ForeColor = System.Drawing.Color.White;
            this.READ_BOTH.Location = new System.Drawing.Point(389, 215);
            this.READ_BOTH.Margin = new System.Windows.Forms.Padding(0);
            this.READ_BOTH.Name = "READ_BOTH";
            this.READ_BOTH.Size = new System.Drawing.Size(52, 23);
            this.READ_BOTH.TabIndex = 73;
            this.READ_BOTH.TabStop = false;
            this.READ_BOTH.Text = "BOTH";
            this.READ_BOTH.UseVisualStyleBackColor = false;
            this.READ_BOTH.Click += new System.EventHandler(this.READ_BOTH_Click);
            // 
            // TAD
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(224, 350);
            this.Controls.Add(this.reading_panel);
            this.Controls.Add(this.READ_BOTH);
            this.Controls.Add(this.WRITE3);
            this.Controls.Add(this.WRITE2);
            this.Controls.Add(this.DIO1_);
            this.Controls.Add(this.DIO0_);
            this.Controls.Add(this.HILO3);
            this.Controls.Add(this.DIO3_Label);
            this.Controls.Add(this.Read_Prompt);
            this.Controls.Add(this.Error_Prompt);
            this.Controls.Add(this.minimise);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.DIO1);
            this.Controls.Add(this.DIO0);
            this.Controls.Add(this.HILO2);
            this.Controls.Add(this.DIO2_Label);
            this.Controls.Add(this._READ);
            this.Controls.Add(this._WRITE);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.XPORT);
            this.Controls.Add(this.XIP);
            this.Controls.Add(this.UserText);
            this.Controls.Add(this.Connect);
            this.Controls.Add(this.IP_input);
            this.Controls.Add(this.Port_input);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TAD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "    ";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TAD_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TAD_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TAD_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.reading_panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label UserText;
        private System.Windows.Forms.Button Connect;
        public System.Windows.Forms.Label XIP;
        public System.Windows.Forms.Label XPORT;
        private System.Windows.Forms.TextBox IP_input;
        private System.Windows.Forms.TextBox Port_input;
        private PictureBox pictureBox1;
        public Label label1;
        public Label label2;
        public Button DIO1;
        public Button DIO0;
        public Button HILO2;
        public Button DIO2_Label;
        private Label _READ;
        private Label _WRITE;
        private Button cancel;
        private Button minimise;
        public Label Error_Prompt;
        public Label Read_Prompt;
        public Button HILO3;
        public Button DIO3_Label;
        private Label DIO0_;
        private Label DIO1_;
        private Panel reading_panel;
        private Label label3;
        public Button WRITE2;
        public Button WRITE3;
        public Button READ_BOTH;
    }
}


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
            this.WRITE4 = new System.Windows.Forms.Button();
            this.WRITE3 = new System.Windows.Forms.Button();
            this.WRITE2 = new System.Windows.Forms.Button();
            this.WRITE1 = new System.Windows.Forms.Button();
            this.READ4 = new System.Windows.Forms.Button();
            this.READ3 = new System.Windows.Forms.Button();
            this.READ2 = new System.Windows.Forms.Button();
            this.READ1 = new System.Windows.Forms.Button();
            this.HILO4 = new System.Windows.Forms.Button();
            this.HILO3 = new System.Windows.Forms.Button();
            this.HILO2 = new System.Windows.Forms.Button();
            this.HILO1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cancel = new System.Windows.Forms.Button();
            this.minimise = new System.Windows.Forms.Button();
            this.DIO1_icon = new System.Windows.Forms.Label();
            this.DIO2_icon = new System.Windows.Forms.Label();
            this.DIO3_icon = new System.Windows.Forms.Label();
            this.DIO4_icon = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.IP_input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDownHandler);
            this.IP_input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnKeyPressHandler);
            this.IP_input.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnKeyUpHandler);
            // 
            // Port_input
            // 
            this.Port_input.BackColor = System.Drawing.Color.White;
            this.Port_input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Port_input.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Port_input.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Port_input.Location = new System.Drawing.Point(36, 261);
            this.Port_input.MaxLength = 4;
            this.Port_input.Name = "Port_input";
            this.Port_input.Size = new System.Drawing.Size(161, 27);
            this.Port_input.TabIndex = 16;
            this.Port_input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PortKeyDown);
            this.Port_input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PortKeyPress);
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
            // WRITE4
            // 
            this.WRITE4.BackColor = System.Drawing.Color.Transparent;
            this.WRITE4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WRITE4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.WRITE4.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.WRITE4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.WRITE4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WRITE4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WRITE4.ForeColor = System.Drawing.Color.White;
            this.WRITE4.Location = new System.Drawing.Point(363, 285);
            this.WRITE4.Margin = new System.Windows.Forms.Padding(0);
            this.WRITE4.Name = "WRITE4";
            this.WRITE4.Size = new System.Drawing.Size(55, 23);
            this.WRITE4.TabIndex = 61;
            this.WRITE4.Text = "TEST";
            this.WRITE4.UseVisualStyleBackColor = false;
            this.WRITE4.Click += new System.EventHandler(this.WRITE4_Click);
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
            this.WRITE3.Location = new System.Drawing.Point(363, 239);
            this.WRITE3.Margin = new System.Windows.Forms.Padding(0);
            this.WRITE3.Name = "WRITE3";
            this.WRITE3.Size = new System.Drawing.Size(55, 23);
            this.WRITE3.TabIndex = 60;
            this.WRITE3.Text = "TEST";
            this.WRITE3.UseVisualStyleBackColor = false;
            this.WRITE3.Click += new System.EventHandler(this.WRITE3_Click);
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
            this.WRITE2.Location = new System.Drawing.Point(365, 137);
            this.WRITE2.Margin = new System.Windows.Forms.Padding(0);
            this.WRITE2.Name = "WRITE2";
            this.WRITE2.Size = new System.Drawing.Size(55, 23);
            this.WRITE2.TabIndex = 59;
            this.WRITE2.Text = "TEST";
            this.WRITE2.UseVisualStyleBackColor = false;
            this.WRITE2.Click += new System.EventHandler(this.WRITE2_Click);
            // 
            // WRITE1
            // 
            this.WRITE1.BackColor = System.Drawing.Color.Transparent;
            this.WRITE1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WRITE1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.WRITE1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.WRITE1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.WRITE1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WRITE1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WRITE1.ForeColor = System.Drawing.Color.White;
            this.WRITE1.Location = new System.Drawing.Point(365, 91);
            this.WRITE1.Margin = new System.Windows.Forms.Padding(0);
            this.WRITE1.Name = "WRITE1";
            this.WRITE1.Size = new System.Drawing.Size(55, 23);
            this.WRITE1.TabIndex = 58;
            this.WRITE1.Text = "TEST";
            this.WRITE1.UseVisualStyleBackColor = false;
            this.WRITE1.Click += new System.EventHandler(this.WRITE1_Click);
            // 
            // READ4
            // 
            this.READ4.BackColor = System.Drawing.Color.Transparent;
            this.READ4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.READ4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.READ4.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.READ4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.READ4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.READ4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.READ4.ForeColor = System.Drawing.Color.White;
            this.READ4.Location = new System.Drawing.Point(302, 285);
            this.READ4.Margin = new System.Windows.Forms.Padding(0);
            this.READ4.Name = "READ4";
            this.READ4.Size = new System.Drawing.Size(55, 23);
            this.READ4.TabIndex = 57;
            this.READ4.Text = "READ";
            this.READ4.UseVisualStyleBackColor = false;
            this.READ4.Click += new System.EventHandler(this.READ4_Click);
            // 
            // READ3
            // 
            this.READ3.BackColor = System.Drawing.Color.Transparent;
            this.READ3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.READ3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.READ3.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.READ3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.READ3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.READ3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.READ3.ForeColor = System.Drawing.Color.White;
            this.READ3.Location = new System.Drawing.Point(302, 239);
            this.READ3.Margin = new System.Windows.Forms.Padding(0);
            this.READ3.Name = "READ3";
            this.READ3.Size = new System.Drawing.Size(55, 23);
            this.READ3.TabIndex = 56;
            this.READ3.Text = "READ";
            this.READ3.UseVisualStyleBackColor = false;
            this.READ3.Click += new System.EventHandler(this.READ3_Click);
            // 
            // READ2
            // 
            this.READ2.BackColor = System.Drawing.Color.Transparent;
            this.READ2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.READ2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.READ2.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.READ2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.READ2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.READ2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.READ2.ForeColor = System.Drawing.Color.White;
            this.READ2.Location = new System.Drawing.Point(304, 137);
            this.READ2.Margin = new System.Windows.Forms.Padding(0);
            this.READ2.Name = "READ2";
            this.READ2.Size = new System.Drawing.Size(55, 23);
            this.READ2.TabIndex = 55;
            this.READ2.Text = "READ";
            this.READ2.UseVisualStyleBackColor = false;
            this.READ2.Click += new System.EventHandler(this.READ2_Click);
            // 
            // READ1
            // 
            this.READ1.BackColor = System.Drawing.Color.Transparent;
            this.READ1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.READ1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.READ1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.READ1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.READ1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.READ1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.READ1.ForeColor = System.Drawing.Color.White;
            this.READ1.Location = new System.Drawing.Point(304, 91);
            this.READ1.Margin = new System.Windows.Forms.Padding(0);
            this.READ1.Name = "READ1";
            this.READ1.Size = new System.Drawing.Size(55, 23);
            this.READ1.TabIndex = 54;
            this.READ1.Text = "READ";
            this.READ1.UseVisualStyleBackColor = false;
            this.READ1.Click += new System.EventHandler(this.READ1_Click);
            // 
            // HILO4
            // 
            this.HILO4.BackColor = System.Drawing.Color.Transparent;
            this.HILO4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HILO4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.HILO4.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.HILO4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.HILO4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HILO4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HILO4.ForeColor = System.Drawing.Color.White;
            this.HILO4.Location = new System.Drawing.Point(241, 285);
            this.HILO4.Margin = new System.Windows.Forms.Padding(0);
            this.HILO4.Name = "HILO4";
            this.HILO4.Size = new System.Drawing.Size(55, 23);
            this.HILO4.TabIndex = 53;
            this.HILO4.Text = "HIGH";
            this.HILO4.UseVisualStyleBackColor = false;
            this.HILO4.Click += new System.EventHandler(this.HILO4_Click);
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
            this.HILO3.Location = new System.Drawing.Point(241, 239);
            this.HILO3.Margin = new System.Windows.Forms.Padding(0);
            this.HILO3.Name = "HILO3";
            this.HILO3.Size = new System.Drawing.Size(55, 23);
            this.HILO3.TabIndex = 52;
            this.HILO3.Text = "HIGH";
            this.HILO3.UseVisualStyleBackColor = false;
            this.HILO3.Click += new System.EventHandler(this.HILO3_Click);
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
            this.HILO2.Location = new System.Drawing.Point(243, 137);
            this.HILO2.Margin = new System.Windows.Forms.Padding(0);
            this.HILO2.Name = "HILO2";
            this.HILO2.Size = new System.Drawing.Size(55, 23);
            this.HILO2.TabIndex = 51;
            this.HILO2.Text = "HIGH";
            this.HILO2.UseVisualStyleBackColor = false;
            this.HILO2.Click += new System.EventHandler(this.HILO2_Click);
            // 
            // HILO1
            // 
            this.HILO1.BackColor = System.Drawing.Color.Transparent;
            this.HILO1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HILO1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.HILO1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.HILO1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.HILO1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HILO1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HILO1.ForeColor = System.Drawing.Color.White;
            this.HILO1.Location = new System.Drawing.Point(243, 91);
            this.HILO1.Margin = new System.Windows.Forms.Padding(0);
            this.HILO1.Name = "HILO1";
            this.HILO1.Size = new System.Drawing.Size(55, 23);
            this.HILO1.TabIndex = 50;
            this.HILO1.Text = "HIGH";
            this.HILO1.UseVisualStyleBackColor = false;
            this.HILO1.Click += new System.EventHandler(this.HILO1_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(241, 193);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(68, 23);
            this.label7.TabIndex = 49;
            this.label7.Text = "OUTPUT";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(240, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 23);
            this.label5.TabIndex = 48;
            this.label5.Text = "INPUT";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(241, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 23);
            this.label4.TabIndex = 47;
            this.label4.Text = "DIO 4";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(241, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 23);
            this.label3.TabIndex = 46;
            this.label3.Text = "DIO 3";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(243, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 23);
            this.label6.TabIndex = 45;
            this.label6.Text = "DIO 2";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.Location = new System.Drawing.Point(243, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 23);
            this.label8.TabIndex = 44;
            this.label8.Text = "DIO 1";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.cancel.Location = new System.Drawing.Point(426, 3);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(26, 34);
            this.cancel.TabIndex = 62;
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
            this.minimise.Location = new System.Drawing.Point(393, 3);
            this.minimise.Name = "minimise";
            this.minimise.Size = new System.Drawing.Size(26, 34);
            this.minimise.TabIndex = 63;
            this.minimise.Text = "-";
            this.minimise.UseMnemonic = false;
            this.minimise.UseVisualStyleBackColor = false;
            this.minimise.Click += new System.EventHandler(this.Minimise_Click);
            // 
            // DIO1_icon
            // 
            this.DIO1_icon.BackColor = System.Drawing.Color.Transparent;
            this.DIO1_icon.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DIO1_icon.ForeColor = System.Drawing.Color.LawnGreen;
            this.DIO1_icon.Location = new System.Drawing.Point(430, 89);
            this.DIO1_icon.Margin = new System.Windows.Forms.Padding(0);
            this.DIO1_icon.Name = "DIO1_icon";
            this.DIO1_icon.Size = new System.Drawing.Size(16, 25);
            this.DIO1_icon.TabIndex = 64;
            this.DIO1_icon.Text = "O";
            this.DIO1_icon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DIO1_icon.Visible = false;
            // 
            // DIO2_icon
            // 
            this.DIO2_icon.BackColor = System.Drawing.Color.Transparent;
            this.DIO2_icon.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DIO2_icon.ForeColor = System.Drawing.Color.LawnGreen;
            this.DIO2_icon.Location = new System.Drawing.Point(430, 137);
            this.DIO2_icon.Margin = new System.Windows.Forms.Padding(0);
            this.DIO2_icon.Name = "DIO2_icon";
            this.DIO2_icon.Size = new System.Drawing.Size(16, 25);
            this.DIO2_icon.TabIndex = 65;
            this.DIO2_icon.Text = "O";
            this.DIO2_icon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DIO2_icon.Visible = false;
            // 
            // DIO3_icon
            // 
            this.DIO3_icon.BackColor = System.Drawing.Color.Transparent;
            this.DIO3_icon.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DIO3_icon.ForeColor = System.Drawing.Color.LawnGreen;
            this.DIO3_icon.Location = new System.Drawing.Point(430, 237);
            this.DIO3_icon.Margin = new System.Windows.Forms.Padding(0);
            this.DIO3_icon.Name = "DIO3_icon";
            this.DIO3_icon.Size = new System.Drawing.Size(16, 25);
            this.DIO3_icon.TabIndex = 66;
            this.DIO3_icon.Text = "O";
            this.DIO3_icon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DIO3_icon.Visible = false;
            // 
            // DIO4_icon
            // 
            this.DIO4_icon.BackColor = System.Drawing.Color.Transparent;
            this.DIO4_icon.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DIO4_icon.ForeColor = System.Drawing.Color.LawnGreen;
            this.DIO4_icon.Location = new System.Drawing.Point(430, 285);
            this.DIO4_icon.Margin = new System.Windows.Forms.Padding(0);
            this.DIO4_icon.Name = "DIO4_icon";
            this.DIO4_icon.Size = new System.Drawing.Size(16, 25);
            this.DIO4_icon.TabIndex = 67;
            this.DIO4_icon.Text = "O";
            this.DIO4_icon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DIO4_icon.Visible = false;
            // 
            // TAD
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(454, 360);
            this.Controls.Add(this.DIO4_icon);
            this.Controls.Add(this.DIO3_icon);
            this.Controls.Add(this.DIO2_icon);
            this.Controls.Add(this.DIO1_icon);
            this.Controls.Add(this.minimise);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.WRITE4);
            this.Controls.Add(this.WRITE3);
            this.Controls.Add(this.WRITE2);
            this.Controls.Add(this.WRITE1);
            this.Controls.Add(this.READ4);
            this.Controls.Add(this.READ3);
            this.Controls.Add(this.READ2);
            this.Controls.Add(this.READ1);
            this.Controls.Add(this.HILO4);
            this.Controls.Add(this.HILO3);
            this.Controls.Add(this.HILO2);
            this.Controls.Add(this.HILO1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        public Button WRITE4;
        public Button WRITE3;
        public Button WRITE2;
        public Button WRITE1;
        public Button READ4;
        public Button READ3;
        public Button READ2;
        public Button READ1;
        private Button HILO4;
        private Button HILO3;
        private Button HILO2;
        public Button HILO1;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label6;
        private Label label8;
        private Button cancel;
        private Button minimise;
        public Label DIO1_icon;
        public Label DIO2_icon;
        public Label DIO3_icon;
        public Label DIO4_icon;
    }
}


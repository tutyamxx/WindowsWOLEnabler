namespace WindowsWOL
{
    partial class FormUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUI));
            this.label_NetworkAdapterName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_InfoPCTip = new System.Windows.Forms.Label();
            this.textBox_IPv4_Address = new System.Windows.Forms.TextBox();
            this.textBox_MacAddress = new System.Windows.Forms.TextBox();
            this.label_LocalIP = new System.Windows.Forms.Label();
            this.label_MacAdress = new System.Windows.Forms.Label();
            this.Button_EnableWOL = new System.Windows.Forms.Button();
            this.pictureBox_IPAddress = new System.Windows.Forms.PictureBox();
            this.pictureBox_MacAddress = new System.Windows.Forms.PictureBox();
            this.pictureBox_Logo = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_IPAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_MacAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // label_NetworkAdapterName
            // 
            this.label_NetworkAdapterName.Location = new System.Drawing.Point(6, 109);
            this.label_NetworkAdapterName.Name = "label_NetworkAdapterName";
            this.label_NetworkAdapterName.Size = new System.Drawing.Size(324, 23);
            this.label_NetworkAdapterName.TabIndex = 1;
            this.label_NetworkAdapterName.Text = "-";
            this.label_NetworkAdapterName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox_Logo);
            this.groupBox1.Controls.Add(this.label_NetworkAdapterName);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 148);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Network Information";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox_IPAddress);
            this.groupBox2.Controls.Add(this.pictureBox_MacAddress);
            this.groupBox2.Controls.Add(this.label_InfoPCTip);
            this.groupBox2.Controls.Add(this.textBox_IPv4_Address);
            this.groupBox2.Controls.Add(this.textBox_MacAddress);
            this.groupBox2.Controls.Add(this.label_LocalIP);
            this.groupBox2.Controls.Add(this.label_MacAdress);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(12, 177);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(336, 123);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PC Information";
            // 
            // label_InfoPCTip
            // 
            this.label_InfoPCTip.Cursor = System.Windows.Forms.Cursors.Help;
            this.label_InfoPCTip.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label_InfoPCTip.Location = new System.Drawing.Point(9, 97);
            this.label_InfoPCTip.Name = "label_InfoPCTip";
            this.label_InfoPCTip.Size = new System.Drawing.Size(321, 23);
            this.label_InfoPCTip.TabIndex = 4;
            this.label_InfoPCTip.Text = "Information needed for setting up Wake-on-LAN";
            this.label_InfoPCTip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_IPv4_Address
            // 
            this.textBox_IPv4_Address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_IPv4_Address.Location = new System.Drawing.Point(118, 65);
            this.textBox_IPv4_Address.Name = "textBox_IPv4_Address";
            this.textBox_IPv4_Address.ReadOnly = true;
            this.textBox_IPv4_Address.Size = new System.Drawing.Size(212, 20);
            this.textBox_IPv4_Address.TabIndex = 3;
            this.textBox_IPv4_Address.TabStop = false;
            this.textBox_IPv4_Address.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_MacAddress
            // 
            this.textBox_MacAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_MacAddress.Location = new System.Drawing.Point(118, 27);
            this.textBox_MacAddress.Name = "textBox_MacAddress";
            this.textBox_MacAddress.ReadOnly = true;
            this.textBox_MacAddress.Size = new System.Drawing.Size(212, 20);
            this.textBox_MacAddress.TabIndex = 2;
            this.textBox_MacAddress.TabStop = false;
            this.textBox_MacAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_LocalIP
            // 
            this.label_LocalIP.AutoSize = true;
            this.label_LocalIP.Location = new System.Drawing.Point(39, 67);
            this.label_LocalIP.Name = "label_LocalIP";
            this.label_LocalIP.Size = new System.Drawing.Size(73, 13);
            this.label_LocalIP.TabIndex = 1;
            this.label_LocalIP.Text = "IPv4 Address:";
            // 
            // label_MacAdress
            // 
            this.label_MacAdress.AutoSize = true;
            this.label_MacAdress.Location = new System.Drawing.Point(40, 29);
            this.label_MacAdress.Name = "label_MacAdress";
            this.label_MacAdress.Size = new System.Drawing.Size(72, 13);
            this.label_MacAdress.TabIndex = 0;
            this.label_MacAdress.Text = "Mac Address:";
            // 
            // Button_EnableWOL
            // 
            this.Button_EnableWOL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_EnableWOL.Location = new System.Drawing.Point(107, 333);
            this.Button_EnableWOL.Name = "Button_EnableWOL";
            this.Button_EnableWOL.Size = new System.Drawing.Size(141, 33);
            this.Button_EnableWOL.TabIndex = 4;
            this.Button_EnableWOL.Text = "Enable Wake-on-LAN";
            this.Button_EnableWOL.UseVisualStyleBackColor = true;
            this.Button_EnableWOL.Click += new System.EventHandler(this.Button_EnableWOL_Click);
            // 
            // pictureBox_IPAddress
            // 
            this.pictureBox_IPAddress.Image = global::WindowsWOLEnabler.Properties.Resources.ip;
            this.pictureBox_IPAddress.Location = new System.Drawing.Point(6, 57);
            this.pictureBox_IPAddress.Name = "pictureBox_IPAddress";
            this.pictureBox_IPAddress.Size = new System.Drawing.Size(32, 32);
            this.pictureBox_IPAddress.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_IPAddress.TabIndex = 6;
            this.pictureBox_IPAddress.TabStop = false;
            // 
            // pictureBox_MacAddress
            // 
            this.pictureBox_MacAddress.Image = global::WindowsWOLEnabler.Properties.Resources.macicon;
            this.pictureBox_MacAddress.Location = new System.Drawing.Point(6, 19);
            this.pictureBox_MacAddress.Name = "pictureBox_MacAddress";
            this.pictureBox_MacAddress.Size = new System.Drawing.Size(32, 32);
            this.pictureBox_MacAddress.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_MacAddress.TabIndex = 5;
            this.pictureBox_MacAddress.TabStop = false;
            // 
            // pictureBox_Logo
            // 
            this.pictureBox_Logo.Image = global::WindowsWOLEnabler.Properties.Resources.logo;
            this.pictureBox_Logo.Location = new System.Drawing.Point(95, 19);
            this.pictureBox_Logo.Name = "pictureBox_Logo";
            this.pictureBox_Logo.Size = new System.Drawing.Size(141, 75);
            this.pictureBox_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Logo.TabIndex = 0;
            this.pictureBox_Logo.TabStop = false;
            // 
            // FormUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 378);
            this.Controls.Add(this.Button_EnableWOL);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Windows WOL Enabler";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_IPAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_MacAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox_Logo;
        private System.Windows.Forms.Label label_NetworkAdapterName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_IPv4_Address;
        private System.Windows.Forms.TextBox textBox_MacAddress;
        private System.Windows.Forms.Label label_LocalIP;
        private System.Windows.Forms.Label label_MacAdress;
        private System.Windows.Forms.Label label_InfoPCTip;
        private System.Windows.Forms.Button Button_EnableWOL;
        private System.Windows.Forms.PictureBox pictureBox_MacAddress;
        private System.Windows.Forms.PictureBox pictureBox_IPAddress;
    }
}


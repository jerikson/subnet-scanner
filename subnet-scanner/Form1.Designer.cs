namespace subnet_scanner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_Scan = new System.Windows.Forms.Button();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.txtBox_Ip = new System.Windows.Forms.TextBox();
            this.lbl_Ip = new System.Windows.Forms.Label();
            this.txtBox_Hosts = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Scan
            // 
            this.btn_Scan.Font = new System.Drawing.Font("Lucida Console", 8.25F);
            this.btn_Scan.Location = new System.Drawing.Point(266, 13);
            this.btn_Scan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Scan.Name = "btn_Scan";
            this.btn_Scan.Size = new System.Drawing.Size(75, 35);
            this.btn_Scan.TabIndex = 0;
            this.btn_Scan.Text = "Scan";
            this.btn_Scan.UseVisualStyleBackColor = true;
            this.btn_Scan.Click += new System.EventHandler(this.btn_Scan_Click);
            // 
            // btn_Stop
            // 
            this.btn_Stop.Font = new System.Drawing.Font("Lucida Console", 8.25F);
            this.btn_Stop.ForeColor = System.Drawing.Color.Black;
            this.btn_Stop.Location = new System.Drawing.Point(347, 13);
            this.btn_Stop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(75, 35);
            this.btn_Stop.TabIndex = 1;
            this.btn_Stop.TabStop = false;
            this.btn_Stop.Text = "Stop";
            this.btn_Stop.UseVisualStyleBackColor = true;
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // txtBox_Ip
            // 
            this.txtBox_Ip.Font = new System.Drawing.Font("Lucida Console", 8.25F);
            this.txtBox_Ip.ForeColor = System.Drawing.Color.Black;
            this.txtBox_Ip.Location = new System.Drawing.Point(10, 27);
            this.txtBox_Ip.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBox_Ip.MaxLength = 24;
            this.txtBox_Ip.Name = "txtBox_Ip";
            this.txtBox_Ip.Size = new System.Drawing.Size(250, 18);
            this.txtBox_Ip.TabIndex = 2;
            // 
            // lbl_Ip
            // 
            this.lbl_Ip.AutoSize = true;
            this.lbl_Ip.Font = new System.Drawing.Font("Lucida Console", 8.25F);
            this.lbl_Ip.Location = new System.Drawing.Point(12, 9);
            this.lbl_Ip.Name = "lbl_Ip";
            this.lbl_Ip.Size = new System.Drawing.Size(82, 11);
            this.lbl_Ip.TabIndex = 4;
            this.lbl_Ip.Text = "IP Address:";
            // 
            // txtBox_Hosts
            // 
            this.txtBox_Hosts.Font = new System.Drawing.Font("Lucida Console", 8.25F);
            this.txtBox_Hosts.Location = new System.Drawing.Point(10, 53);
            this.txtBox_Hosts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBox_Hosts.Multiline = true;
            this.txtBox_Hosts.Name = "txtBox_Hosts";
            this.txtBox_Hosts.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBox_Hosts.Size = new System.Drawing.Size(412, 232);
            this.txtBox_Hosts.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 297);
            this.Controls.Add(this.txtBox_Hosts);
            this.Controls.Add(this.lbl_Ip);
            this.Controls.Add(this.txtBox_Ip);
            this.Controls.Add(this.btn_Stop);
            this.Controls.Add(this.btn_Scan);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(450, 336);
            this.MinimumSize = new System.Drawing.Size(450, 336);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Subnet Scanner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Scan;
        private System.Windows.Forms.Button btn_Stop;
        private System.Windows.Forms.TextBox txtBox_Ip;
        private System.Windows.Forms.Label lbl_Ip;
        private System.Windows.Forms.TextBox txtBox_Hosts;
    }
}


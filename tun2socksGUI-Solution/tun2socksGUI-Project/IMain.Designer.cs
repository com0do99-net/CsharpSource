namespace tun2socksGUI_Project
{
    partial class IMain
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
            this.textLocalIP = new System.Windows.Forms.TextBox();
            this.textDNS = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.socksProxy = new System.Windows.Forms.TextBox();
            this.startStopButton = new System.Windows.Forms.Button();
            this.InstallButton = new System.Windows.Forms.Button();
            this.routeButton = new System.Windows.Forms.Button();
            this.statusInformation = new System.Windows.Forms.StatusStrip();
            this.tunTapAdapter = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.addRoute = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.netInterface = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.remTapButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.routeProxy = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Local IP";
            // 
            // textLocalIP
            // 
            this.textLocalIP.BackColor = System.Drawing.SystemColors.Window;
            this.textLocalIP.Location = new System.Drawing.Point(142, 30);
            this.textLocalIP.Name = "textLocalIP";
            this.textLocalIP.ReadOnly = true;
            this.textLocalIP.Size = new System.Drawing.Size(152, 21);
            this.textLocalIP.TabIndex = 177;
            this.textLocalIP.TabStop = false;
            this.textLocalIP.Text = "0.0.0.0";
            // 
            // textDNS
            // 
            this.textDNS.Location = new System.Drawing.Point(142, 54);
            this.textDNS.Multiline = true;
            this.textDNS.Name = "textDNS";
            this.textDNS.Size = new System.Drawing.Size(152, 54);
            this.textDNS.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dns Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Socks Proxy";
            // 
            // socksProxy
            // 
            this.socksProxy.Location = new System.Drawing.Point(142, 112);
            this.socksProxy.Name = "socksProxy";
            this.socksProxy.Size = new System.Drawing.Size(152, 21);
            this.socksProxy.TabIndex = 5;
            this.socksProxy.Text = "127.0.0.1:1080";
            // 
            // startStopButton
            // 
            this.startStopButton.Location = new System.Drawing.Point(299, 66);
            this.startStopButton.Name = "startStopButton";
            this.startStopButton.Size = new System.Drawing.Size(113, 30);
            this.startStopButton.TabIndex = 6;
            this.startStopButton.Text = "Start";
            this.startStopButton.UseVisualStyleBackColor = true;
            this.startStopButton.Click += new System.EventHandler(this.startStopButton_Click);
            // 
            // InstallButton
            // 
            this.InstallButton.Location = new System.Drawing.Point(299, 4);
            this.InstallButton.Name = "InstallButton";
            this.InstallButton.Size = new System.Drawing.Size(113, 30);
            this.InstallButton.TabIndex = 7;
            this.InstallButton.Text = "Install Driver";
            this.InstallButton.UseVisualStyleBackColor = true;
            this.InstallButton.Click += new System.EventHandler(this.InstallButton_Click);
            // 
            // routeButton
            // 
            this.routeButton.Location = new System.Drawing.Point(299, 35);
            this.routeButton.Name = "routeButton";
            this.routeButton.Size = new System.Drawing.Size(113, 30);
            this.routeButton.TabIndex = 8;
            this.routeButton.Text = "Route Print";
            this.routeButton.UseVisualStyleBackColor = true;
            this.routeButton.Click += new System.EventHandler(this.routeButton_Click);
            // 
            // statusInformation
            // 
            this.statusInformation.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusInformation.Location = new System.Drawing.Point(0, 187);
            this.statusInformation.Name = "statusInformation";
            this.statusInformation.Size = new System.Drawing.Size(758, 22);
            this.statusInformation.TabIndex = 13;
            // 
            // tunTapAdapter
            // 
            this.tunTapAdapter.FormattingEnabled = true;
            this.tunTapAdapter.Location = new System.Drawing.Point(142, 136);
            this.tunTapAdapter.Name = "tunTapAdapter";
            this.tunTapAdapter.Size = new System.Drawing.Size(152, 23);
            this.tunTapAdapter.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Tap/Tun Adapter";
            // 
            // addRoute
            // 
            this.addRoute.AutoSize = true;
            this.addRoute.Location = new System.Drawing.Point(9, 163);
            this.addRoute.Name = "addRoute";
            this.addRoute.Size = new System.Drawing.Size(131, 19);
            this.addRoute.TabIndex = 16;
            this.addRoute.Text = "Add route proxy";
            this.addRoute.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "Connection";
            // 
            // netInterface
            // 
            this.netInterface.FormattingEnabled = true;
            this.netInterface.Location = new System.Drawing.Point(142, 4);
            this.netInterface.Name = "netInterface";
            this.netInterface.Size = new System.Drawing.Size(152, 23);
            this.netInterface.TabIndex = 1;
            this.netInterface.SelectedIndexChanged += new System.EventHandler(this.netInterface_SelectedIndexChanged);
            this.netInterface.TextChanged += new System.EventHandler(this.netInterface_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(418, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(336, 176);
            this.textBox1.TabIndex = 21;
            // 
            // remTapButton
            // 
            this.remTapButton.Location = new System.Drawing.Point(299, 97);
            this.remTapButton.Name = "remTapButton";
            this.remTapButton.Size = new System.Drawing.Size(113, 30);
            this.remTapButton.TabIndex = 22;
            this.remTapButton.Text = "Remove";
            this.remTapButton.UseVisualStyleBackColor = true;
            this.remTapButton.Click += new System.EventHandler(this.remTapButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(299, 129);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(113, 30);
            this.refreshButton.TabIndex = 23;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // routeProxy
            // 
            this.routeProxy.Location = new System.Drawing.Point(142, 163);
            this.routeProxy.Name = "routeProxy";
            this.routeProxy.Size = new System.Drawing.Size(152, 21);
            this.routeProxy.TabIndex = 178;
            // 
            // IMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(758, 209);
            this.Controls.Add(this.routeProxy);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.remTapButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.netInterface);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.addRoute);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tunTapAdapter);
            this.Controls.Add(this.statusInformation);
            this.Controls.Add(this.routeButton);
            this.Controls.Add(this.InstallButton);
            this.Controls.Add(this.startStopButton);
            this.Controls.Add(this.socksProxy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textDNS);
            this.Controls.Add(this.textLocalIP);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "IMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "openSource tun2socksGUI [com0do99-net]";
            this.Load += new System.EventHandler(this.IMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textLocalIP;
        private System.Windows.Forms.TextBox textDNS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox socksProxy;
        private System.Windows.Forms.Button startStopButton;
        private System.Windows.Forms.Button InstallButton;
        private System.Windows.Forms.Button routeButton;
        private System.Windows.Forms.StatusStrip statusInformation;
        private System.Windows.Forms.ComboBox tunTapAdapter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox addRoute;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox netInterface;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button remTapButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.TextBox routeProxy;
    }
}


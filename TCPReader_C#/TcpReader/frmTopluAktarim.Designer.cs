namespace TCPReader
{
    partial class frmTopluAktarim
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.label31 = new System.Windows.Forms.Label();
            this.txtUygulamaTipi = new System.Windows.Forms.ComboBox();
            this.cbAutoRxEnabled = new System.Windows.Forms.CheckBox();
            this.cbAutoConnect = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbDfSize = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.edtCmtRetry = new System.Windows.Forms.NumericUpDown();
            this.edtDeviceKey = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.edtPortNo = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.edtTimeOut = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.cbProtocol = new System.Windows.Forms.ComboBox();
            this.label24 = new System.Windows.Forms.Label();
            this.cbReaderType = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlListe = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nmrKayit = new System.Windows.Forms.NumericUpDown();
            this.button3 = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edtCmtRetry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtPortNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtTimeOut)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrKayit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label31);
            this.panel3.Controls.Add(this.txtUygulamaTipi);
            this.panel3.Controls.Add(this.cbAutoRxEnabled);
            this.panel3.Controls.Add(this.cbAutoConnect);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.cbDfSize);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.edtCmtRetry);
            this.panel3.Controls.Add(this.edtDeviceKey);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.edtPortNo);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.edtTimeOut);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.cbProtocol);
            this.panel3.Controls.Add(this.label24);
            this.panel3.Controls.Add(this.cbReaderType);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(931, 90);
            this.panel3.TabIndex = 4;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(273, 10);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(52, 13);
            this.label31.TabIndex = 100;
            this.label31.Text = "Uyg.  Tipi";
            // 
            // txtUygulamaTipi
            // 
            this.txtUygulamaTipi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtUygulamaTipi.FormattingEnabled = true;
            this.txtUygulamaTipi.Items.AddRange(new object[] {
            "PDKS",
            "HGS",
            "YMK KONTOR"});
            this.txtUygulamaTipi.Location = new System.Drawing.Point(331, 6);
            this.txtUygulamaTipi.Name = "txtUygulamaTipi";
            this.txtUygulamaTipi.Size = new System.Drawing.Size(90, 21);
            this.txtUygulamaTipi.TabIndex = 99;
            // 
            // cbAutoRxEnabled
            // 
            this.cbAutoRxEnabled.AutoSize = true;
            this.cbAutoRxEnabled.Location = new System.Drawing.Point(461, 65);
            this.cbAutoRxEnabled.Name = "cbAutoRxEnabled";
            this.cbAutoRxEnabled.Size = new System.Drawing.Size(163, 17);
            this.cbAutoRxEnabled.TabIndex = 97;
            this.cbAutoRxEnabled.Text = "Cihazdan Otomatik Veri Dinle";
            this.cbAutoRxEnabled.UseVisualStyleBackColor = true;
            // 
            // cbAutoConnect
            // 
            this.cbAutoConnect.AutoSize = true;
            this.cbAutoConnect.Checked = true;
            this.cbAutoConnect.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAutoConnect.Location = new System.Drawing.Point(309, 64);
            this.cbAutoConnect.Name = "cbAutoConnect";
            this.cbAutoConnect.Size = new System.Drawing.Size(146, 17);
            this.cbAutoConnect.TabIndex = 96;
            this.cbAutoConnect.Text = "Otomatik Yeniden Bağlan";
            this.cbAutoConnect.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(443, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 94;
            this.label9.Text = "DF Size";
            // 
            // cbDfSize
            // 
            this.cbDfSize.DisplayMember = "2";
            this.cbDfSize.FormattingEnabled = true;
            this.cbDfSize.Items.AddRange(new object[] {
            "4MB",
            "8MB"});
            this.cbDfSize.Location = new System.Drawing.Point(493, 7);
            this.cbDfSize.Name = "cbDfSize";
            this.cbDfSize.Size = new System.Drawing.Size(57, 21);
            this.cbDfSize.TabIndex = 93;
            this.cbDfSize.Text = "4MB";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(183, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 92;
            this.label8.Text = "Komut Tekrarı";
            // 
            // edtCmtRetry
            // 
            this.edtCmtRetry.Location = new System.Drawing.Point(262, 60);
            this.edtCmtRetry.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.edtCmtRetry.Name = "edtCmtRetry";
            this.edtCmtRetry.Size = new System.Drawing.Size(38, 20);
            this.edtCmtRetry.TabIndex = 91;
            this.edtCmtRetry.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // edtDeviceKey
            // 
            this.edtDeviceKey.Location = new System.Drawing.Point(268, 33);
            this.edtDeviceKey.Name = "edtDeviceKey";
            this.edtDeviceKey.Size = new System.Drawing.Size(208, 20);
            this.edtDeviceKey.TabIndex = 90;
            this.edtDeviceKey.Text = "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(168, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 13);
            this.label7.TabIndex = 89;
            this.label7.Text = "Haberleşme Şifresi";
            // 
            // edtPortNo
            // 
            this.edtPortNo.Location = new System.Drawing.Point(202, 8);
            this.edtPortNo.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.edtPortNo.Name = "edtPortNo";
            this.edtPortNo.Size = new System.Drawing.Size(60, 20);
            this.edtPortNo.TabIndex = 88;
            this.edtPortNo.Value = new decimal(new int[] {
            6565,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(170, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 87;
            this.label6.Text = "Port";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 84;
            this.label5.Text = "Bağlantı Zaman Aşımı";
            // 
            // edtTimeOut
            // 
            this.edtTimeOut.Location = new System.Drawing.Point(117, 60);
            this.edtTimeOut.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.edtTimeOut.Name = "edtTimeOut";
            this.edtTimeOut.Size = new System.Drawing.Size(60, 20);
            this.edtTimeOut.TabIndex = 83;
            this.edtTimeOut.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Protokol";
            // 
            // cbProtocol
            // 
            this.cbProtocol.DisplayMember = "2";
            this.cbProtocol.FormattingEnabled = true;
            this.cbProtocol.Items.AddRange(new object[] {
            "PR0",
            "PR1",
            "PR2",
            "PR3"});
            this.cbProtocol.Location = new System.Drawing.Point(79, 33);
            this.cbProtocol.Name = "cbProtocol";
            this.cbProtocol.Size = new System.Drawing.Size(81, 21);
            this.cbProtocol.TabIndex = 28;
            this.cbProtocol.Text = "PR2";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(3, 9);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(70, 13);
            this.label24.TabIndex = 27;
            this.label24.Text = "Okuyucu Tipi";
            // 
            // cbReaderType
            // 
            this.cbReaderType.DisplayMember = "2";
            this.cbReaderType.FormattingEnabled = true;
            this.cbReaderType.Items.AddRange(new object[] {
            "ART63MV3",
            "ART63MV5",
            "ART26M"});
            this.cbReaderType.Location = new System.Drawing.Point(79, 6);
            this.cbReaderType.Name = "cbReaderType";
            this.cbReaderType.Size = new System.Drawing.Size(81, 21);
            this.cbReaderType.TabIndex = 26;
            this.cbReaderType.Text = "ART63MV3";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.nmrKayit);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(931, 54);
            this.panel1.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(390, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 37);
            this.button2.TabIndex = 3;
            this.button2.Text = "Bağlan";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(228, 14);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(72, 20);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(309, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "Liste Oluştur";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kaç Cihazla Bağlantı Kurmak İstiyorsunuz ?";
            // 
            // pnlListe
            // 
            this.pnlListe.AutoScroll = true;
            this.pnlListe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlListe.Location = new System.Drawing.Point(0, 144);
            this.pnlListe.Name = "pnlListe";
            this.pnlListe.Size = new System.Drawing.Size(931, 370);
            this.pnlListe.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtLog);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(565, 144);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(366, 370);
            this.panel2.TabIndex = 7;
            // 
            // txtLog
            // 
            this.txtLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLog.Location = new System.Drawing.Point(0, 28);
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.Size = new System.Drawing.Size(366, 342);
            this.txtLog.TabIndex = 1;
            this.txtLog.Text = "";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Chartreuse;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOGLAR";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nmrKayit
            // 
            this.nmrKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nmrKayit.Location = new System.Drawing.Point(616, 17);
            this.nmrKayit.Name = "nmrKayit";
            this.nmrKayit.Size = new System.Drawing.Size(123, 26);
            this.nmrKayit.TabIndex = 7;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Right;
            this.button3.Location = new System.Drawing.Point(759, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(172, 54);
            this.button3.TabIndex = 8;
            this.button3.Text = "Random Kayıt Aktar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // frmTopluAktarim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 514);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlListe);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Name = "frmTopluAktarim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmTopluAktarim";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmTopluAktarim_FormClosed);
            this.Load += new System.EventHandler(this.frmTopluAktarim_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edtCmtRetry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtPortNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtTimeOut)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmrKayit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.ComboBox txtUygulamaTipi;
        private System.Windows.Forms.CheckBox cbAutoRxEnabled;
        private System.Windows.Forms.CheckBox cbAutoConnect;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbDfSize;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown edtCmtRetry;
        private System.Windows.Forms.TextBox edtDeviceKey;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown edtPortNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown edtTimeOut;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbProtocol;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.ComboBox cbReaderType;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlListe;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox txtLog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown nmrKayit;
        private System.Windows.Forms.Button button3;
    }
}
namespace TCPReader
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabCihazGenelBilgileri = new System.Windows.Forms.TabControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.tbpDeviceGeneralSettings = new System.Windows.Forms.TabPage();
            this.btnHaftaninGunIsimleri = new System.Windows.Forms.Button();
            this.groupBox21 = new System.Windows.Forms.GroupBox();
            this.cbSerialAppType = new System.Windows.Forms.ComboBox();
            this.label162 = new System.Windows.Forms.Label();
            this.btnSeriPortGonder = new System.Windows.Forms.Button();
            this.btnSeriPortGetir = new System.Windows.Forms.Button();
            this.btnSeriPortTest = new System.Windows.Forms.Button();
            this.txtSeri1BaudRate = new System.Windows.Forms.ComboBox();
            this.txtSeri0BaudRate = new System.Windows.Forms.ComboBox();
            this.label152 = new System.Windows.Forms.Label();
            this.label138 = new System.Windows.Forms.Label();
            this.grSerialNumber = new System.Windows.Forms.GroupBox();
            this.btnSetSerialNumber = new System.Windows.Forms.Button();
            this.btnGetSerialNumber = new System.Windows.Forms.Button();
            this.edtSerialNumber = new System.Windows.Forms.TextBox();
            this.grDeviceWorkMode = new System.Windows.Forms.GroupBox();
            this.cmbOnlineKartModu = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label187 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbOnlineEnabledOffline = new System.Windows.Forms.CheckBox();
            this.btnSetWorkMode = new System.Windows.Forms.Button();
            this.btnGetWorkMode = new System.Windows.Forms.Button();
            this.edtOnlineTimeOut = new System.Windows.Forms.NumericUpDown();
            this.rbOnlineUDP = new System.Windows.Forms.RadioButton();
            this.rbOnlineTCP = new System.Windows.Forms.RadioButton();
            this.rbOfflineCardBlackList = new System.Windows.Forms.RadioButton();
            this.rbOfflineWhiteList = new System.Windows.Forms.RadioButton();
            this.grDeviceGeneralSettings = new System.Windows.Forms.GroupBox();
            this.label185 = new System.Windows.Forms.Label();
            this.cmbFontTipi = new System.Windows.Forms.ComboBox();
            this.btnGonder = new System.Windows.Forms.Button();
            this.btnGetir = new System.Windows.Forms.Button();
            this.label61 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.nmrKartLoginBeklemeSuresi = new System.Windows.Forms.NumericUpDown();
            this.edtAyniKartiOkumaAraligi = new System.Windows.Forms.NumericUpDown();
            this.label186 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.edtArdasikKartOkumaAraligi = new System.Windows.Forms.NumericUpDown();
            this.label58 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.edtKartOkumaSuresi = new System.Windows.Forms.NumericUpDown();
            this.label51 = new System.Windows.Forms.Label();
            this.edtGunlukYenidenBaslatmaZamani = new System.Windows.Forms.DateTimePicker();
            this.chkGunlukYenidenBaslatma = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.radioTransistorCikisi2NormalClosed = new System.Windows.Forms.RadioButton();
            this.radioTransistorCikisi2NormalOpen = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioTransistorCikisi1NormalClosed = new System.Windows.Forms.RadioButton();
            this.radioTransistorCikisi1NormalOpen = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkVarsayilanLogo = new System.Windows.Forms.RadioButton();
            this.chkVarsayilanMesaj = new System.Windows.Forms.RadioButton();
            this.label56 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.edtRenkYogunlugu = new System.Windows.Forms.NumericUpDown();
            this.edtArkaPlanIsigi = new System.Windows.Forms.NumericUpDown();
            this.label54 = new System.Windows.Forms.Label();
            this.edtIkinciSatir = new System.Windows.Forms.TextBox();
            this.label53 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.edtBirinciSatir = new System.Windows.Forms.TextBox();
            this.edtCihazNo = new System.Windows.Forms.NumericUpDown();
            this.label50 = new System.Windows.Forms.Label();
            this.gbDeviceİnfo = new System.Windows.Forms.GroupBox();
            this.grDeviceOperation = new System.Windows.Forms.GroupBox();
            this.cdSaveIPAddr = new System.Windows.Forms.CheckBox();
            this.btnSetDeviceFactoryDefaults = new System.Windows.Forms.Button();
            this.btnReboot = new System.Windows.Forms.Button();
            this.grDeviceStatus = new System.Windows.Forms.GroupBox();
            this.btnSetDeviceStatus = new System.Windows.Forms.Button();
            this.btnGetDeviceStatus = new System.Windows.Forms.Button();
            this.rbDeviceDisabled = new System.Windows.Forms.RadioButton();
            this.rbDeviceEnabled = new System.Windows.Forms.RadioButton();
            this.grDateTime = new System.Windows.Forms.GroupBox();
            this.btnSetDateTime = new System.Windows.Forms.Button();
            this.edtDateTime = new System.Windows.Forms.DateTimePicker();
            this.grHeadTail = new System.Windows.Forms.GroupBox();
            this.btnSetHead = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.edtTail = new System.Windows.Forms.NumericUpDown();
            this.edtHead = new System.Windows.Forms.NumericUpDown();
            this.btnGetHead = new System.Windows.Forms.Button();
            this.lblfwVersion = new System.Windows.Forms.Label();
            this.btnfwVersion = new System.Windows.Forms.Button();
            this.tsCominicationSettings = new System.Windows.Forms.TabPage();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.button43 = new System.Windows.Forms.Button();
            this.label27 = new System.Windows.Forms.Label();
            this.txtWebAraYuzuSifresi = new System.Windows.Forms.TextBox();
            this.button13 = new System.Windows.Forms.Button();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.btnMacAdresiGetir = new System.Windows.Forms.Button();
            this.label26 = new System.Windows.Forms.Label();
            this.txtMacAdresi = new System.Windows.Forms.TextBox();
            this.btnMacAdresiGonder = new System.Windows.Forms.Button();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.label25 = new System.Windows.Forms.Label();
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.button10 = new System.Windows.Forms.Button();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.edtHaberlesmeAyarlariTCPclientAyarlariPortNumarasi = new System.Windows.Forms.NumericUpDown();
            this.edtHaberlesmeAyarlariTCPclientAyarlariIpAdresi = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.edtUDPayarlariPortNumarasi = new System.Windows.Forms.NumericUpDown();
            this.edtUDPayarlariIpAdresi = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.chkUDPayarlariUDPLogAktif = new System.Windows.Forms.CheckBox();
            this.chkUDPayarlariUDPAktif = new System.Windows.Forms.CheckBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtServerEchoZamanAsimi = new System.Windows.Forms.NumericUpDown();
            this.label160 = new System.Windows.Forms.Label();
            this.edtHaberlesmeAyarlariServerIpAdress = new System.Windows.Forms.TextBox();
            this.edtHaberlesmeAyarlariPortNumarasi = new System.Windows.Forms.NumericUpDown();
            this.edtHaberlesmeIkinciDnsSunucu = new System.Windows.Forms.TextBox();
            this.edtHaberlesmeBirinciDnsSunucu = new System.Windows.Forms.TextBox();
            this.edtHaberlesmeAyarlariVarsayilanAgGecidi = new System.Windows.Forms.TextBox();
            this.edtHaberlesmeAltAgMaskesi = new System.Windows.Forms.TextBox();
            this.edtHaberlesmeIpAdresi = new System.Windows.Forms.TextBox();
            this.edtHaberlesmeAyarlariProtokol = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.chkHaberlesmeAyarlariDHCPAktif = new System.Windows.Forms.CheckBox();
            this.chkHaberlesmeAyarlariSadeceServerIleHaberles = new System.Windows.Forms.CheckBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tsMfrKeyTable = new System.Windows.Forms.TabPage();
            this.groupBox23 = new System.Windows.Forms.GroupBox();
            this.button16 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.tsLCDMessages = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox25 = new System.Windows.Forms.GroupBox();
            this.label179 = new System.Windows.Forms.Label();
            this.label178 = new System.Windows.Forms.Label();
            this.txtInputBoxMesajGonderKlavyeTipi = new System.Windows.Forms.NumericUpDown();
            this.btnInputBoxMesajGonder = new System.Windows.Forms.Button();
            this.txtInputBoxMesajGonderIsBlink = new System.Windows.Forms.CheckBox();
            this.label177 = new System.Windows.Forms.Label();
            this.label175 = new System.Windows.Forms.Label();
            this.txtInputBoxMesajGonderBuzzerSure1 = new System.Windows.Forms.NumericUpDown();
            this.label176 = new System.Windows.Forms.Label();
            this.label171 = new System.Windows.Forms.Label();
            this.label172 = new System.Windows.Forms.Label();
            this.txtInputBoxMesajGonderRoleSure2 = new System.Windows.Forms.NumericUpDown();
            this.txtInputBoxMesajGonderRoleSure1 = new System.Windows.Forms.NumericUpDown();
            this.label173 = new System.Windows.Forms.Label();
            this.label174 = new System.Windows.Forms.Label();
            this.label169 = new System.Windows.Forms.Label();
            this.txtInputBoxMesajGonderEkranSure = new System.Windows.Forms.NumericUpDown();
            this.label170 = new System.Windows.Forms.Label();
            this.txtInputBoxMesajGonderIkinciSatirZ = new System.Windows.Forms.NumericUpDown();
            this.txtInputBoxMesajGonderIkinciSatirX = new System.Windows.Forms.NumericUpDown();
            this.txtInputBoxMesajGonderIkinciSatir = new System.Windows.Forms.TextBox();
            this.label168 = new System.Windows.Forms.Label();
            this.txtInputBoxMesajGonderBirinciSatirZ = new System.Windows.Forms.NumericUpDown();
            this.txtInputBoxMesajGonderBirinciSatirx = new System.Windows.Forms.NumericUpDown();
            this.txtInputBoxMesajGonderBirinciSatir = new System.Windows.Forms.TextBox();
            this.label167 = new System.Windows.Forms.Label();
            this.label165 = new System.Windows.Forms.Label();
            this.label166 = new System.Windows.Forms.Label();
            this.txtInputBoxMesajGonderBaslik = new System.Windows.Forms.TextBox();
            this.label164 = new System.Windows.Forms.Label();
            this.label163 = new System.Windows.Forms.Label();
            this.txtInputBoxMesajGonderUstBaslikTipi = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label83 = new System.Windows.Forms.Label();
            this.label82 = new System.Windows.Forms.Label();
            this.label81 = new System.Windows.Forms.Label();
            this.label80 = new System.Windows.Forms.Label();
            this.ekranMesajiOnlieSatir5y = new System.Windows.Forms.NumericUpDown();
            this.ekranMesajiOnlieSatir5x = new System.Windows.Forms.NumericUpDown();
            this.ekranMesajiOnlieSatir4y = new System.Windows.Forms.NumericUpDown();
            this.ekranMesajiOnlieSatir4x = new System.Windows.Forms.NumericUpDown();
            this.ekranMesajiOnlieSatir3y = new System.Windows.Forms.NumericUpDown();
            this.ekranMesajiOnlieSatir3x = new System.Windows.Forms.NumericUpDown();
            this.ekranMesajiOnlieSatir2y = new System.Windows.Forms.NumericUpDown();
            this.ekranMesajiOnlieSatir2x = new System.Windows.Forms.NumericUpDown();
            this.ekranMesajiOnlieSatir1y = new System.Windows.Forms.NumericUpDown();
            this.ekranMesajiOnlieSatir1x = new System.Windows.Forms.NumericUpDown();
            this.btnHaberlesmeAyariGonder = new System.Windows.Forms.Button();
            this.chkedtEkranMesajlariBlink = new System.Windows.Forms.CheckBox();
            this.edtEkranMesajlariBuzzerSuresi = new System.Windows.Forms.NumericUpDown();
            this.edtEkranMesajlariRoleSuresi2 = new System.Windows.Forms.NumericUpDown();
            this.edtEkranMesajlariRoleSuresi1 = new System.Windows.Forms.NumericUpDown();
            this.edtEkranMesajlariEkranSure = new System.Windows.Forms.NumericUpDown();
            this.edtEkranMesajlariFontTipi = new System.Windows.Forms.ComboBox();
            this.edtEkranMesajiSatirSayisi = new System.Windows.Forms.NumericUpDown();
            this.edtEkranMesajlariAltBaslik = new System.Windows.Forms.TextBox();
            this.edtEkranMesajlariAltBaslikTipi = new System.Windows.Forms.ComboBox();
            this.ekranMesajiOnlieSatir5 = new System.Windows.Forms.TextBox();
            this.ekranMesajiOnlieSatir4 = new System.Windows.Forms.TextBox();
            this.ekranMesajiOnlieSatir3 = new System.Windows.Forms.TextBox();
            this.ekranMesajiOnlieSatir2 = new System.Windows.Forms.TextBox();
            this.ekranMesajiOnlieSatir1 = new System.Windows.Forms.TextBox();
            this.edtEkranMesajlariUstBaslik = new System.Windows.Forms.TextBox();
            this.label79 = new System.Windows.Forms.Label();
            this.label78 = new System.Windows.Forms.Label();
            this.label77 = new System.Windows.Forms.Label();
            this.label76 = new System.Windows.Forms.Label();
            this.label75 = new System.Windows.Forms.Label();
            this.label74 = new System.Windows.Forms.Label();
            this.label73 = new System.Windows.Forms.Label();
            this.label72 = new System.Windows.Forms.Label();
            this.label71 = new System.Windows.Forms.Label();
            this.label70 = new System.Windows.Forms.Label();
            this.label69 = new System.Windows.Forms.Label();
            this.label68 = new System.Windows.Forms.Label();
            this.label66 = new System.Windows.Forms.Label();
            this.label67 = new System.Windows.Forms.Label();
            this.label65 = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.label63 = new System.Windows.Forms.Label();
            this.label62 = new System.Windows.Forms.Label();
            this.edtEkranMesajlariUstBaslikTipi = new System.Windows.Forms.ComboBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label149 = new System.Windows.Forms.Label();
            this.edtCihazMesajTipiOffline = new System.Windows.Forms.ComboBox();
            this.label84 = new System.Windows.Forms.Label();
            this.label85 = new System.Windows.Forms.Label();
            this.label86 = new System.Windows.Forms.Label();
            this.label87 = new System.Windows.Forms.Label();
            this.ekranMesajiOfflineSatir5z = new System.Windows.Forms.NumericUpDown();
            this.ekranMesajiOfflineSatir5x = new System.Windows.Forms.NumericUpDown();
            this.ekranMesajiOfflineSatir4z = new System.Windows.Forms.NumericUpDown();
            this.ekranMesajiOfflineSatir4x = new System.Windows.Forms.NumericUpDown();
            this.ekranMesajiOfflineSatir3z = new System.Windows.Forms.NumericUpDown();
            this.ekranMesajiOfflineSatir3x = new System.Windows.Forms.NumericUpDown();
            this.ekranMesajiOfflineSatir2z = new System.Windows.Forms.NumericUpDown();
            this.ekranMesajiOfflineSatir2x = new System.Windows.Forms.NumericUpDown();
            this.ekranMesajiOfflineSatir1z = new System.Windows.Forms.NumericUpDown();
            this.ekranMesajiOfflineSatir1x = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.chkekranMesajiOfflineBlink = new System.Windows.Forms.CheckBox();
            this.ekranMesajiOfflineBuzzerSuresi = new System.Windows.Forms.NumericUpDown();
            this.ekranMesajiOfflineRoleSuresi2 = new System.Windows.Forms.NumericUpDown();
            this.ekranMesajiOfflineRoleSuresi1 = new System.Windows.Forms.NumericUpDown();
            this.ekranMesajiOfflineEkranSuresi = new System.Windows.Forms.NumericUpDown();
            this.ekranMesajiOfflinealtBaslikFontTipi = new System.Windows.Forms.ComboBox();
            this.edtEkranMesajiSatirSayisiOffline = new System.Windows.Forms.NumericUpDown();
            this.ekranMesajiOfflinealtBaslik = new System.Windows.Forms.TextBox();
            this.ekranMesajiOfflinealtBaslikTipi = new System.Windows.Forms.ComboBox();
            this.ekranMesajiOfflineSatir5 = new System.Windows.Forms.TextBox();
            this.ekranMesajiOfflineSatir4 = new System.Windows.Forms.TextBox();
            this.ekranMesajiOfflineSatir3 = new System.Windows.Forms.TextBox();
            this.ekranMesajiOfflineSatir2 = new System.Windows.Forms.TextBox();
            this.ekranMesajiOfflineSatir1 = new System.Windows.Forms.TextBox();
            this.edtCihazMesajUstBaslikOffline = new System.Windows.Forms.TextBox();
            this.label88 = new System.Windows.Forms.Label();
            this.label89 = new System.Windows.Forms.Label();
            this.label90 = new System.Windows.Forms.Label();
            this.label91 = new System.Windows.Forms.Label();
            this.label92 = new System.Windows.Forms.Label();
            this.label93 = new System.Windows.Forms.Label();
            this.label94 = new System.Windows.Forms.Label();
            this.label95 = new System.Windows.Forms.Label();
            this.label96 = new System.Windows.Forms.Label();
            this.label97 = new System.Windows.Forms.Label();
            this.label98 = new System.Windows.Forms.Label();
            this.label99 = new System.Windows.Forms.Label();
            this.label100 = new System.Windows.Forms.Label();
            this.label101 = new System.Windows.Forms.Label();
            this.label102 = new System.Windows.Forms.Label();
            this.label103 = new System.Windows.Forms.Label();
            this.label104 = new System.Windows.Forms.Label();
            this.label105 = new System.Windows.Forms.Label();
            this.edtCihazMesajUstBaslikTipiOffline = new System.Windows.Forms.ComboBox();
            this.tsAccessSettings = new System.Windows.Forms.TabPage();
            this.button17 = new System.Windows.Forms.Button();
            this.chkYenidenBaslat = new System.Windows.Forms.CheckBox();
            this.groupBox17 = new System.Windows.Forms.GroupBox();
            this.chkZilCaldirmaTransistorCikisi1 = new System.Windows.Forms.RadioButton();
            this.chkZilCaldirmaTransistorCikisi2 = new System.Windows.Forms.RadioButton();
            this.button28 = new System.Windows.Forms.Button();
            this.button29 = new System.Windows.Forms.Button();
            this.button30 = new System.Windows.Forms.Button();
            this.edtZilCaldirma2Satir = new System.Windows.Forms.TextBox();
            this.edtZilCaldirma1Satir = new System.Windows.Forms.TextBox();
            this.label113 = new System.Windows.Forms.Label();
            this.label114 = new System.Windows.Forms.Label();
            this.label115 = new System.Windows.Forms.Label();
            this.chkZilCaldirmaEtkin = new System.Windows.Forms.CheckBox();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.chkOkuyucuHizmetDisiAyarlariTransistorCikisi2 = new System.Windows.Forms.RadioButton();
            this.chkOkuyucuHizmetDisiAyarlariTransistorCikisi1 = new System.Windows.Forms.RadioButton();
            this.chkOkuyucuHizmetDisiAyarlariTransistorCikisiDegisiklikYok = new System.Windows.Forms.RadioButton();
            this.label116 = new System.Windows.Forms.Label();
            this.button25 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.chkOkuyucuHizmetDisiAyarlariHizmet2Satir = new System.Windows.Forms.TextBox();
            this.chkOkuyucuHizmetDisiAyarlariHizmet1Satir = new System.Windows.Forms.TextBox();
            this.label111 = new System.Windows.Forms.Label();
            this.label112 = new System.Windows.Forms.Label();
            this.label110 = new System.Windows.Forms.Label();
            this.chkOkuyucuHizmetDisiAyarlariHizmetDisiEtkin = new System.Windows.Forms.CheckBox();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.digerEKSAyarlariEKSverisi = new System.Windows.Forms.NumericUpDown();
            this.label109 = new System.Windows.Forms.Label();
            this.digerEKSAyarlariKisiVerisi = new System.Windows.Forms.NumericUpDown();
            this.label108 = new System.Windows.Forms.Label();
            this.label107 = new System.Windows.Forms.Label();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.edtAntiPassBackArdisikGecisAraligi = new System.Windows.Forms.NumericUpDown();
            this.edtUygulamaAyarlariGuvenlikBolgeNo = new System.Windows.Forms.NumericUpDown();
            this.edtUygulamaAyarlariAPBtipi = new System.Windows.Forms.ComboBox();
            this.radioUygulamaAyarlariAntiPassBackGiris = new System.Windows.Forms.RadioButton();
            this.radioUygulamaAyarlariAntiPassBackCikis = new System.Windows.Forms.RadioButton();
            this.labeGecisAraligi = new System.Windows.Forms.Label();
            this.labelGuvenlikBolgeNo = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.btnPersTZMode = new System.Windows.Forms.Button();
            this.lblInputDuration = new System.Windows.Forms.Label();
            this.cbPersTZMode = new System.Windows.Forms.ComboBox();
            this.edtGenelAyarlarZamanKisitTablosuEtkin = new System.Windows.Forms.CheckBox();
            this.button20 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.edtUygulamaayarlariGecisSuresi = new System.Windows.Forms.NumericUpDown();
            this.labelGecisSuresi = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.edtUygulamaAyariGirisTipi = new System.Windows.Forms.ComboBox();
            this.label29 = new System.Windows.Forms.Label();
            this.edtGenelAyarlarSifreGecisTipi = new System.Windows.Forms.ComboBox();
            this.label28 = new System.Windows.Forms.Label();
            this.edtGenelAyarlarGecisTipi = new System.Windows.Forms.ComboBox();
            this.tsAddWhitelist = new System.Windows.Forms.TabPage();
            this.button35 = new System.Windows.Forms.Button();
            this.groupBox26 = new System.Windows.Forms.GroupBox();
            this.nmrNeedCmdControl = new System.Windows.Forms.NumericUpDown();
            this.nmrToplamAylikHak = new System.Windows.Forms.NumericUpDown();
            this.nmrToplamHaftalikHak = new System.Windows.Forms.NumericUpDown();
            this.nmrAyarListeNo = new System.Windows.Forms.NumericUpDown();
            this.label192 = new System.Windows.Forms.Label();
            this.label191 = new System.Windows.Forms.Label();
            this.label190 = new System.Windows.Forms.Label();
            this.label189 = new System.Windows.Forms.Label();
            this.label188 = new System.Windows.Forms.Label();
            this.dtDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.btnTopluAktarim = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            this.lblIndexNo = new System.Windows.Forms.Label();
            this.lblTanimliKisi = new System.Windows.Forms.Label();
            this.btnClearWhiteList = new System.Windows.Forms.Button();
            this.btnCardIDCnt = new System.Windows.Forms.Button();
            this.btnGetWhiteList = new System.Windows.Forms.Button();
            this.btnDeleteWhiteList = new System.Windows.Forms.Button();
            this.btnEditWhiteList = new System.Windows.Forms.Button();
            this.btnAddWhiteList = new System.Windows.Forms.Button();
            this.cbAccessCardEnabled = new System.Windows.Forms.CheckBox();
            this.chkAcilDurumlardaGecizIzni = new System.Windows.Forms.CheckBox();
            this.chkKartOfflinedaOnlineCalissin = new System.Windows.Forms.CheckBox();
            this.cbATCEnabled = new System.Windows.Forms.CheckBox();
            this.cbAPBEnabled = new System.Windows.Forms.CheckBox();
            this.cbAccessEnabled = new System.Windows.Forms.CheckBox();
            this.label46 = new System.Windows.Forms.Label();
            this.edtEndDate = new System.Windows.Forms.DateTimePicker();
            this.label45 = new System.Windows.Forms.Label();
            this.sePassword = new System.Windows.Forms.NumericUpDown();
            this.label44 = new System.Windows.Forms.Label();
            this.seCode = new System.Windows.Forms.NumericUpDown();
            this.label37 = new System.Windows.Forms.Label();
            this.seAccMask1 = new System.Windows.Forms.NumericUpDown();
            this.label35 = new System.Windows.Forms.Label();
            this.edtName = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.edtCardID = new System.Windows.Forms.TextBox();
            this.tsInOutValues = new System.Windows.Forms.TabPage();
            this.label151 = new System.Windows.Forms.Label();
            this.numericUpDown63 = new System.Windows.Forms.NumericUpDown();
            this.label150 = new System.Windows.Forms.Label();
            this.button42 = new System.Windows.Forms.Button();
            this.richTextBoxRecs = new System.Windows.Forms.RichTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.edtHowManyRead = new System.Windows.Forms.NumericUpDown();
            this.edtStartRead = new System.Windows.Forms.NumericUpDown();
            this.label47 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.btnTransferRecs = new System.Windows.Forms.Button();
            this.btnReadRecs = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.label49 = new System.Windows.Forms.Label();
            this.edtFilePath = new System.Windows.Forms.TextBox();
            this.tbpHgsGenelAyarlar = new System.Windows.Forms.TabPage();
            this.btnDaireBul = new System.Windows.Forms.Button();
            this.btnDaireSil = new System.Windows.Forms.Button();
            this.groupBox20 = new System.Windows.Forms.GroupBox();
            this.btnDaireAracHakkiGonder = new System.Windows.Forms.Button();
            this.btnDaireAracHakkiGetir = new System.Windows.Forms.Button();
            this.txtDaireAracHakkiOtoparkHakki = new System.Windows.Forms.NumericUpDown();
            this.label106 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.txtDaireAracHakkiOtoparkHakkiDaire = new System.Windows.Forms.NumericUpDown();
            this.txtHgsGenelAyarlarKartinSonKullanmaTarihi = new System.Windows.Forms.DateTimePicker();
            this.label145 = new System.Windows.Forms.Label();
            this.label144 = new System.Windows.Forms.Label();
            this.label143 = new System.Windows.Forms.Label();
            this.label142 = new System.Windows.Forms.Label();
            this.label141 = new System.Windows.Forms.Label();
            this.label140 = new System.Windows.Forms.Label();
            this.label139 = new System.Windows.Forms.Label();
            this.txtHgsGenelAyarlarArac = new System.Windows.Forms.NumericUpDown();
            this.txtHgsGenelAyarlarDaireHak = new System.Windows.Forms.NumericUpDown();
            this.txtHgsGenelAyarlarDaire = new System.Windows.Forms.NumericUpDown();
            this.lblHGSIndexNo = new System.Windows.Forms.Label();
            this.txtHgsGenelAyarlarKartHGSAdi = new System.Windows.Forms.TextBox();
            this.txtHgsGenelAyarlarKartId = new System.Windows.Forms.TextBox();
            this.button38 = new System.Windows.Forms.Button();
            this.labelHgsTanimliKisiSayisi = new System.Windows.Forms.Label();
            this.button37 = new System.Windows.Forms.Button();
            this.btnHgsBul = new System.Windows.Forms.Button();
            this.btnHgsDegistir = new System.Windows.Forms.Button();
            this.btnHgsSil = new System.Windows.Forms.Button();
            this.btnHgsEkle = new System.Windows.Forms.Button();
            this.txtHgsGenelAyarlarKisitKontroluOlsunMu = new System.Windows.Forms.CheckBox();
            this.txtHgsGenelAyarlarAntiPassBackKontroluOlsunMu = new System.Windows.Forms.CheckBox();
            this.txtHgsGenelAyarlarKisiCihazdaAktifMi = new System.Windows.Forms.CheckBox();
            this.label136 = new System.Windows.Forms.Label();
            this.txtHgsGenelAyarlarPazar = new System.Windows.Forms.NumericUpDown();
            this.txtHgsGenelAyarlarCumartesi = new System.Windows.Forms.NumericUpDown();
            this.txtHgsGenelAyarlarCuma = new System.Windows.Forms.NumericUpDown();
            this.txtHgsGenelAyarlarPersembe = new System.Windows.Forms.NumericUpDown();
            this.txtHgsGenelAyarlarCarsamb = new System.Windows.Forms.NumericUpDown();
            this.txtHgsGenelAyarlarSali = new System.Windows.Forms.NumericUpDown();
            this.txtHgsGenelAyarlarPazartesi = new System.Windows.Forms.NumericUpDown();
            this.label135 = new System.Windows.Forms.Label();
            this.label134 = new System.Windows.Forms.Label();
            this.label133 = new System.Windows.Forms.Label();
            this.label132 = new System.Windows.Forms.Label();
            this.label131 = new System.Windows.Forms.Label();
            this.label130 = new System.Windows.Forms.Label();
            this.groupBox18 = new System.Windows.Forms.GroupBox();
            this.label181 = new System.Windows.Forms.Label();
            this.label180 = new System.Windows.Forms.Label();
            this.txtHgsGenelAyarlarAppType = new System.Windows.Forms.NumericUpDown();
            this.label137 = new System.Windows.Forms.Label();
            this.txtHgsGenelAyarlarArdisikGecisSuresi = new System.Windows.Forms.NumericUpDown();
            this.txtHgsGenelAyarlarAracDaireSayisi = new System.Windows.Forms.NumericUpDown();
            this.txtHgsGenelAyarlarAntenKtanima = new System.Windows.Forms.NumericUpDown();
            this.txtHgsGenelAyarlarAntenGuc2 = new System.Windows.Forms.NumericUpDown();
            this.txtHgsGenelAyarlarAntenGuc1 = new System.Windows.Forms.NumericUpDown();
            this.txtHgsGenelAyarlarDiziArdisikKontrol2 = new System.Windows.Forms.NumericUpDown();
            this.txtHgsGenelAyarlarDiziArdisikKontrol1 = new System.Windows.Forms.NumericUpDown();
            this.txtHgsGenelAyarlarProgramModu = new System.Windows.Forms.ComboBox();
            this.txtHgsGenelAyarlarTransistorCikisi2 = new System.Windows.Forms.NumericUpDown();
            this.txtHgsGenelAyarlarTransistorCikisi1 = new System.Windows.Forms.NumericUpDown();
            this.txtHgsGenelAyarlarTagId = new System.Windows.Forms.NumericUpDown();
            this.txtHgsGenelAyarlarKartBaslangici = new System.Windows.Forms.NumericUpDown();
            this.txtHgsGenelAyarlarSeriPaketBoyutu = new System.Windows.Forms.NumericUpDown();
            this.btnHgsGenelAyarlariGonder = new System.Windows.Forms.Button();
            this.btnHgsGenelAyarlariGetir = new System.Windows.Forms.Button();
            this.label129 = new System.Windows.Forms.Label();
            this.label128 = new System.Windows.Forms.Label();
            this.label127 = new System.Windows.Forms.Label();
            this.label126 = new System.Windows.Forms.Label();
            this.label125 = new System.Windows.Forms.Label();
            this.txtHgsGenelAyarlarZamanKisitEtkin = new System.Windows.Forms.CheckBox();
            this.label124 = new System.Windows.Forms.Label();
            this.label123 = new System.Windows.Forms.Label();
            this.label122 = new System.Windows.Forms.Label();
            this.label121 = new System.Windows.Forms.Label();
            this.label120 = new System.Windows.Forms.Label();
            this.label119 = new System.Windows.Forms.Label();
            this.label118 = new System.Windows.Forms.Label();
            this.label117 = new System.Windows.Forms.Label();
            this.tbpCihazdanBilgiTransfer = new System.Windows.Forms.TabPage();
            this.richTextRec2 = new System.Windows.Forms.ListBox();
            this.groupBox19 = new System.Windows.Forms.GroupBox();
            this.btnHgsVerileriTransferEt = new System.Windows.Forms.Button();
            this.btnHgsCihazdangelenBilgileriOku = new System.Windows.Forms.Button();
            this.label148 = new System.Windows.Forms.Label();
            this.txtSayi = new System.Windows.Forms.NumericUpDown();
            this.label147 = new System.Windows.Forms.Label();
            this.txtBaslangic = new System.Windows.Forms.NumericUpDown();
            this.label146 = new System.Windows.Forms.Label();
            this.textBox32 = new System.Windows.Forms.TextBox();
            this.button39 = new System.Windows.Forms.Button();
            this.tbpYmk = new System.Windows.Forms.TabPage();
            this.button45 = new System.Windows.Forms.Button();
            this.button44 = new System.Windows.Forms.Button();
            this.button41 = new System.Windows.Forms.Button();
            this.button40 = new System.Windows.Forms.Button();
            this.button36 = new System.Windows.Forms.Button();
            this.btnKontorFiyatListesi = new System.Windows.Forms.Button();
            this.button31 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.groupBox22 = new System.Windows.Forms.GroupBox();
            this.cmbOgunDisindaOkuyucuNeYapsin = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button33 = new System.Windows.Forms.Button();
            this.btnYemekhaneAyariGonder = new System.Windows.Forms.Button();
            this.btnYemekhaneAyarlariGetir = new System.Windows.Forms.Button();
            this.txtYemekhaneYenidenOkumaZamanAralik = new System.Windows.Forms.NumericUpDown();
            this.txtYemekhaneYenidenOkumaFiyatListesi = new System.Windows.Forms.NumericUpDown();
            this.txtYemekhaneYenidenKartOkumaSayi = new System.Windows.Forms.NumericUpDown();
            this.txtYemekhaneIstasyon = new System.Windows.Forms.NumericUpDown();
            this.txtYemekhaneKartSektor = new System.Windows.Forms.NumericUpDown();
            this.txtYemekhaneSeciliFiyatListesi = new System.Windows.Forms.NumericUpDown();
            this.label195 = new System.Windows.Forms.Label();
            this.label159 = new System.Windows.Forms.Label();
            this.label158 = new System.Windows.Forms.Label();
            this.label157 = new System.Windows.Forms.Label();
            this.label156 = new System.Windows.Forms.Label();
            this.label155 = new System.Windows.Forms.Label();
            this.label154 = new System.Windows.Forms.Label();
            this.label153 = new System.Windows.Forms.Label();
            this.txtYemekhaneUygulamaTipi = new System.Windows.Forms.ComboBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label182 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblMesaj = new System.Windows.Forms.Label();
            this.button32 = new System.Windows.Forms.Button();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label183 = new System.Windows.Forms.Label();
            this.label184 = new System.Windows.Forms.Label();
            this.button34 = new System.Windows.Forms.Button();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.lblTanimliBlackListSayisi = new System.Windows.Forms.Label();
            this.btnTanimliBlackListKullanicilariSil = new System.Windows.Forms.Button();
            this.BtnBlackListPersonelBul = new System.Windows.Forms.Button();
            this.BtnBlackListPersonelSil = new System.Windows.Forms.Button();
            this.BtnBlackListPersonelDegistir = new System.Windows.Forms.Button();
            this.BtnBlackListPersonelSayisi = new System.Windows.Forms.Button();
            this.BtnBlackListPersonelEkle = new System.Windows.Forms.Button();
            this.nmrBlackListNo = new System.Windows.Forms.NumericUpDown();
            this.label39 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.edtBlackListAd = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.edtBlackListKartId = new System.Windows.Forms.TextBox();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.btnNodeGetir = new System.Windows.Forms.Button();
            this.btnNodeGonder = new System.Windows.Forms.Button();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.nmrParent = new System.Windows.Forms.NumericUpDown();
            this.nmrRight = new System.Windows.Forms.NumericUpDown();
            this.nmrLeft = new System.Windows.Forms.NumericUpDown();
            this.nmrColor = new System.Windows.Forms.NumericUpDown();
            this.nmrAdres = new System.Windows.Forms.NumericUpDown();
            this.label194 = new System.Windows.Forms.Label();
            this.label193 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label31 = new System.Windows.Forms.Label();
            this.txtUygulamaTipi = new System.Windows.Forms.ComboBox();
            this.btnDisConnect = new System.Windows.Forms.Button();
            this.cbAutoRxEnabled = new System.Windows.Forms.CheckBox();
            this.cbAutoConnect = new System.Windows.Forms.CheckBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cbDfSize = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.edtCmtRetry = new System.Windows.Forms.NumericUpDown();
            this.edtDeviceKey = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.edtPortNo = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.edtIp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.edtTimeOut = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.cbProtocol = new System.Windows.Forms.ComboBox();
            this.label24 = new System.Windows.Forms.Label();
            this.cbReaderType = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.appLog = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.udPlog = new System.Windows.Forms.GroupBox();
            this.udpLogText = new System.Windows.Forms.TextBox();
            this.groupBox24 = new System.Windows.Forms.GroupBox();
            this.txtUdpPortNumber = new System.Windows.Forms.NumericUpDown();
            this.label161 = new System.Windows.Forms.Label();
            this.btnUdpTemizle = new System.Windows.Forms.Button();
            this.btnUDPbaslat = new System.Windows.Forms.Button();
            this.dtTimer = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox27 = new System.Windows.Forms.GroupBox();
            this.label196 = new System.Windows.Forms.Label();
            this.label197 = new System.Windows.Forms.Label();
            this.edtStatusMode = new System.Windows.Forms.NumericUpDown();
            this.edtStatusModeType = new System.Windows.Forms.NumericUpDown();
            this.btnSendStatusMode = new System.Windows.Forms.Button();
            this.btnGetStatusMode = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabCihazGenelBilgileri.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.tbpDeviceGeneralSettings.SuspendLayout();
            this.groupBox21.SuspendLayout();
            this.grSerialNumber.SuspendLayout();
            this.grDeviceWorkMode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edtOnlineTimeOut)).BeginInit();
            this.grDeviceGeneralSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrKartLoginBeklemeSuresi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtAyniKartiOkumaAraligi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtArdasikKartOkumaAraligi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtKartOkumaSuresi)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edtRenkYogunlugu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtArkaPlanIsigi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtCihazNo)).BeginInit();
            this.gbDeviceİnfo.SuspendLayout();
            this.grDeviceOperation.SuspendLayout();
            this.grDeviceStatus.SuspendLayout();
            this.grDateTime.SuspendLayout();
            this.grHeadTail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edtTail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtHead)).BeginInit();
            this.tsCominicationSettings.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edtHaberlesmeAyarlariTCPclientAyarlariPortNumarasi)).BeginInit();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edtUDPayarlariPortNumarasi)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtServerEchoZamanAsimi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtHaberlesmeAyarlariPortNumarasi)).BeginInit();
            this.tsMfrKeyTable.SuspendLayout();
            this.tsLCDMessages.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox25.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtInputBoxMesajGonderKlavyeTipi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInputBoxMesajGonderBuzzerSure1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInputBoxMesajGonderRoleSure2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInputBoxMesajGonderRoleSure1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInputBoxMesajGonderEkranSure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInputBoxMesajGonderIkinciSatirZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInputBoxMesajGonderIkinciSatirX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInputBoxMesajGonderBirinciSatirZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInputBoxMesajGonderBirinciSatirx)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ekranMesajiOnlieSatir5y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ekranMesajiOnlieSatir5x)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ekranMesajiOnlieSatir4y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ekranMesajiOnlieSatir4x)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ekranMesajiOnlieSatir3y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ekranMesajiOnlieSatir3x)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ekranMesajiOnlieSatir2y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ekranMesajiOnlieSatir2x)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ekranMesajiOnlieSatir1y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ekranMesajiOnlieSatir1x)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEkranMesajlariBuzzerSuresi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEkranMesajlariRoleSuresi2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEkranMesajlariRoleSuresi1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEkranMesajlariEkranSure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEkranMesajiSatirSayisi)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ekranMesajiOfflineSatir5z)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ekranMesajiOfflineSatir5x)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ekranMesajiOfflineSatir4z)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ekranMesajiOfflineSatir4x)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ekranMesajiOfflineSatir3z)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ekranMesajiOfflineSatir3x)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ekranMesajiOfflineSatir2z)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ekranMesajiOfflineSatir2x)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ekranMesajiOfflineSatir1z)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ekranMesajiOfflineSatir1x)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ekranMesajiOfflineBuzzerSuresi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ekranMesajiOfflineRoleSuresi2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ekranMesajiOfflineRoleSuresi1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ekranMesajiOfflineEkranSuresi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEkranMesajiSatirSayisiOffline)).BeginInit();
            this.tsAccessSettings.SuspendLayout();
            this.groupBox17.SuspendLayout();
            this.groupBox16.SuspendLayout();
            this.groupBox15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.digerEKSAyarlariEKSverisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.digerEKSAyarlariKisiVerisi)).BeginInit();
            this.groupBox14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edtAntiPassBackArdisikGecisAraligi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtUygulamaAyarlariGuvenlikBolgeNo)).BeginInit();
            this.groupBox13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edtUygulamaayarlariGecisSuresi)).BeginInit();
            this.tsAddWhitelist.SuspendLayout();
            this.groupBox26.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrNeedCmdControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrToplamAylikHak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrToplamHaftalikHak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAyarListeNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sePassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seAccMask1)).BeginInit();
            this.tsInOutValues.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown63)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edtHowManyRead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStartRead)).BeginInit();
            this.tbpHgsGenelAyarlar.SuspendLayout();
            this.groupBox20.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDaireAracHakkiOtoparkHakki)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDaireAracHakkiOtoparkHakkiDaire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHgsGenelAyarlarArac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHgsGenelAyarlarDaireHak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHgsGenelAyarlarDaire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHgsGenelAyarlarPazar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHgsGenelAyarlarCumartesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHgsGenelAyarlarCuma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHgsGenelAyarlarPersembe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHgsGenelAyarlarCarsamb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHgsGenelAyarlarSali)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHgsGenelAyarlarPazartesi)).BeginInit();
            this.groupBox18.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHgsGenelAyarlarAppType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHgsGenelAyarlarArdisikGecisSuresi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHgsGenelAyarlarAracDaireSayisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHgsGenelAyarlarAntenKtanima)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHgsGenelAyarlarAntenGuc2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHgsGenelAyarlarAntenGuc1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHgsGenelAyarlarDiziArdisikKontrol2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHgsGenelAyarlarDiziArdisikKontrol1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHgsGenelAyarlarTransistorCikisi2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHgsGenelAyarlarTransistorCikisi1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHgsGenelAyarlarTagId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHgsGenelAyarlarKartBaslangici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHgsGenelAyarlarSeriPaketBoyutu)).BeginInit();
            this.tbpCihazdanBilgiTransfer.SuspendLayout();
            this.groupBox19.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSayi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBaslangic)).BeginInit();
            this.tbpYmk.SuspendLayout();
            this.groupBox22.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtYemekhaneYenidenOkumaZamanAralik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYemekhaneYenidenOkumaFiyatListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYemekhaneYenidenKartOkumaSayi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYemekhaneIstasyon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYemekhaneKartSektor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYemekhaneSeciliFiyatListesi)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrBlackListNo)).BeginInit();
            this.tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrParent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAdres)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edtCmtRetry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtPortNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtTimeOut)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.udPlog.SuspendLayout();
            this.groupBox24.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUdpPortNumber)).BeginInit();
            this.groupBox27.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edtStatusMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStatusModeType)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabCihazGenelBilgileri);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1116, 741);
            this.panel1.TabIndex = 2;
            // 
            // tabCihazGenelBilgileri
            // 
            this.tabCihazGenelBilgileri.ContextMenuStrip = this.contextMenuStrip1;
            this.tabCihazGenelBilgileri.Controls.Add(this.tbpDeviceGeneralSettings);
            this.tabCihazGenelBilgileri.Controls.Add(this.tsCominicationSettings);
            this.tabCihazGenelBilgileri.Controls.Add(this.tsMfrKeyTable);
            this.tabCihazGenelBilgileri.Controls.Add(this.tsLCDMessages);
            this.tabCihazGenelBilgileri.Controls.Add(this.tsAccessSettings);
            this.tabCihazGenelBilgileri.Controls.Add(this.tsAddWhitelist);
            this.tabCihazGenelBilgileri.Controls.Add(this.tsInOutValues);
            this.tabCihazGenelBilgileri.Controls.Add(this.tbpHgsGenelAyarlar);
            this.tabCihazGenelBilgileri.Controls.Add(this.tbpCihazdanBilgiTransfer);
            this.tabCihazGenelBilgileri.Controls.Add(this.tbpYmk);
            this.tabCihazGenelBilgileri.Controls.Add(this.tabPage5);
            this.tabCihazGenelBilgileri.Controls.Add(this.tabPage6);
            this.tabCihazGenelBilgileri.Controls.Add(this.tabPage7);
            this.tabCihazGenelBilgileri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCihazGenelBilgileri.Location = new System.Drawing.Point(0, 86);
            this.tabCihazGenelBilgileri.Name = "tabCihazGenelBilgileri";
            this.tabCihazGenelBilgileri.SelectedIndex = 0;
            this.tabCihazGenelBilgileri.ShowToolTips = true;
            this.tabCihazGenelBilgileri.Size = new System.Drawing.Size(1116, 655);
            this.tabCihazGenelBilgileri.TabIndex = 4;
            this.tabCihazGenelBilgileri.SelectedIndexChanged += new System.EventHandler(this.tabControl2_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 136);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "Cihaz Genel Ayarlar";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem2.Text = "toolStripMenuItem2";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem3.Text = "toolStripMenuItem3";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem4.Text = "toolStripMenuItem4";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem5.Text = "toolStripMenuItem5";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem6.Text = "toolStripMenuItem6";
            // 
            // tbpDeviceGeneralSettings
            // 
            this.tbpDeviceGeneralSettings.Controls.Add(this.btnHaftaninGunIsimleri);
            this.tbpDeviceGeneralSettings.Controls.Add(this.groupBox21);
            this.tbpDeviceGeneralSettings.Controls.Add(this.grSerialNumber);
            this.tbpDeviceGeneralSettings.Controls.Add(this.grDeviceWorkMode);
            this.tbpDeviceGeneralSettings.Controls.Add(this.grDeviceGeneralSettings);
            this.tbpDeviceGeneralSettings.Controls.Add(this.gbDeviceİnfo);
            this.tbpDeviceGeneralSettings.Location = new System.Drawing.Point(4, 22);
            this.tbpDeviceGeneralSettings.Name = "tbpDeviceGeneralSettings";
            this.tbpDeviceGeneralSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tbpDeviceGeneralSettings.Size = new System.Drawing.Size(1108, 629);
            this.tbpDeviceGeneralSettings.TabIndex = 0;
            this.tbpDeviceGeneralSettings.Text = "Cihaz Genel Ayarları";
            this.tbpDeviceGeneralSettings.UseVisualStyleBackColor = true;
            // 
            // btnHaftaninGunIsimleri
            // 
            this.btnHaftaninGunIsimleri.Location = new System.Drawing.Point(6, 446);
            this.btnHaftaninGunIsimleri.Name = "btnHaftaninGunIsimleri";
            this.btnHaftaninGunIsimleri.Size = new System.Drawing.Size(180, 38);
            this.btnHaftaninGunIsimleri.TabIndex = 5;
            this.btnHaftaninGunIsimleri.Text = "Haftanın Gün İsimleri";
            this.btnHaftaninGunIsimleri.UseVisualStyleBackColor = true;
            this.btnHaftaninGunIsimleri.Click += new System.EventHandler(this.btnHaftaninGunIsimleri_Click);
            // 
            // groupBox21
            // 
            this.groupBox21.Controls.Add(this.cbSerialAppType);
            this.groupBox21.Controls.Add(this.label162);
            this.groupBox21.Controls.Add(this.btnSeriPortGonder);
            this.groupBox21.Controls.Add(this.btnSeriPortGetir);
            this.groupBox21.Controls.Add(this.btnSeriPortTest);
            this.groupBox21.Controls.Add(this.txtSeri1BaudRate);
            this.groupBox21.Controls.Add(this.txtSeri0BaudRate);
            this.groupBox21.Controls.Add(this.label152);
            this.groupBox21.Controls.Add(this.label138);
            this.groupBox21.Location = new System.Drawing.Point(526, 276);
            this.groupBox21.Name = "groupBox21";
            this.groupBox21.Size = new System.Drawing.Size(214, 145);
            this.groupBox21.TabIndex = 4;
            this.groupBox21.TabStop = false;
            this.groupBox21.Text = " Seri Port Baudrate Ayarları";
            // 
            // cbSerialAppType
            // 
            this.cbSerialAppType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSerialAppType.FormattingEnabled = true;
            this.cbSerialAppType.Items.AddRange(new object[] {
            "Okunulan Değeri Server\'a gönder",
            "Card Okutulmuş Gibi yap"});
            this.cbSerialAppType.Location = new System.Drawing.Point(9, 36);
            this.cbSerialAppType.Name = "cbSerialAppType";
            this.cbSerialAppType.Size = new System.Drawing.Size(196, 21);
            this.cbSerialAppType.TabIndex = 8;
            // 
            // label162
            // 
            this.label162.AutoSize = true;
            this.label162.Location = new System.Drawing.Point(6, 19);
            this.label162.Name = "label162";
            this.label162.Size = new System.Drawing.Size(83, 13);
            this.label162.TabIndex = 7;
            this.label162.Text = "Uygulama Tipi : ";
            // 
            // btnSeriPortGonder
            // 
            this.btnSeriPortGonder.Location = new System.Drawing.Point(134, 116);
            this.btnSeriPortGonder.Name = "btnSeriPortGonder";
            this.btnSeriPortGonder.Size = new System.Drawing.Size(75, 23);
            this.btnSeriPortGonder.TabIndex = 6;
            this.btnSeriPortGonder.Text = "Gönder";
            this.btnSeriPortGonder.UseVisualStyleBackColor = true;
            this.btnSeriPortGonder.Click += new System.EventHandler(this.btnSeriPortGonder_Click);
            // 
            // btnSeriPortGetir
            // 
            this.btnSeriPortGetir.Location = new System.Drawing.Point(52, 116);
            this.btnSeriPortGetir.Name = "btnSeriPortGetir";
            this.btnSeriPortGetir.Size = new System.Drawing.Size(75, 23);
            this.btnSeriPortGetir.TabIndex = 5;
            this.btnSeriPortGetir.Text = "Getir";
            this.btnSeriPortGetir.UseVisualStyleBackColor = true;
            this.btnSeriPortGetir.Click += new System.EventHandler(this.btnSeriPortGetir_Click);
            // 
            // btnSeriPortTest
            // 
            this.btnSeriPortTest.Location = new System.Drawing.Point(134, 61);
            this.btnSeriPortTest.Name = "btnSeriPortTest";
            this.btnSeriPortTest.Size = new System.Drawing.Size(75, 49);
            this.btnSeriPortTest.TabIndex = 4;
            this.btnSeriPortTest.Text = "Seri Port Test";
            this.btnSeriPortTest.UseVisualStyleBackColor = true;
            this.btnSeriPortTest.Visible = false;
            this.btnSeriPortTest.Click += new System.EventHandler(this.btnSeriPortTest_Click);
            // 
            // txtSeri1BaudRate
            // 
            this.txtSeri1BaudRate.FormattingEnabled = true;
            this.txtSeri1BaudRate.Items.AddRange(new object[] {
            "2400",
            "4800",
            "7200",
            "9600",
            "14400",
            "19200",
            "28800",
            "57600",
            "115200",
            "230400"});
            this.txtSeri1BaudRate.Location = new System.Drawing.Point(55, 89);
            this.txtSeri1BaudRate.Name = "txtSeri1BaudRate";
            this.txtSeri1BaudRate.Size = new System.Drawing.Size(72, 21);
            this.txtSeri1BaudRate.TabIndex = 3;
            // 
            // txtSeri0BaudRate
            // 
            this.txtSeri0BaudRate.FormattingEnabled = true;
            this.txtSeri0BaudRate.Items.AddRange(new object[] {
            "2400",
            "4800",
            "7200",
            "9600",
            "14400",
            "19200",
            "28800",
            "57600",
            "115200",
            "230400"});
            this.txtSeri0BaudRate.Location = new System.Drawing.Point(55, 63);
            this.txtSeri0BaudRate.Name = "txtSeri0BaudRate";
            this.txtSeri0BaudRate.Size = new System.Drawing.Size(72, 21);
            this.txtSeri0BaudRate.TabIndex = 2;
            // 
            // label152
            // 
            this.label152.AutoSize = true;
            this.label152.Location = new System.Drawing.Point(9, 92);
            this.label152.Name = "label152";
            this.label152.Size = new System.Drawing.Size(43, 13);
            this.label152.TabIndex = 1;
            this.label152.Text = "Seri 1 : ";
            // 
            // label138
            // 
            this.label138.AutoSize = true;
            this.label138.Location = new System.Drawing.Point(9, 69);
            this.label138.Name = "label138";
            this.label138.Size = new System.Drawing.Size(43, 13);
            this.label138.TabIndex = 0;
            this.label138.Text = "Seri 0 : ";
            // 
            // grSerialNumber
            // 
            this.grSerialNumber.Controls.Add(this.btnSetSerialNumber);
            this.grSerialNumber.Controls.Add(this.btnGetSerialNumber);
            this.grSerialNumber.Controls.Add(this.edtSerialNumber);
            this.grSerialNumber.Location = new System.Drawing.Point(526, 427);
            this.grSerialNumber.Name = "grSerialNumber";
            this.grSerialNumber.Size = new System.Drawing.Size(214, 79);
            this.grSerialNumber.TabIndex = 3;
            this.grSerialNumber.TabStop = false;
            this.grSerialNumber.Text = " Cihaz Seri Numarası";
            // 
            // btnSetSerialNumber
            // 
            this.btnSetSerialNumber.Location = new System.Drawing.Point(111, 45);
            this.btnSetSerialNumber.Name = "btnSetSerialNumber";
            this.btnSetSerialNumber.Size = new System.Drawing.Size(83, 23);
            this.btnSetSerialNumber.TabIndex = 89;
            this.btnSetSerialNumber.Text = "Gönder";
            this.btnSetSerialNumber.UseVisualStyleBackColor = true;
            this.btnSetSerialNumber.Click += new System.EventHandler(this.btnSetSerialNumber_Click);
            // 
            // btnGetSerialNumber
            // 
            this.btnGetSerialNumber.Location = new System.Drawing.Point(12, 45);
            this.btnGetSerialNumber.Name = "btnGetSerialNumber";
            this.btnGetSerialNumber.Size = new System.Drawing.Size(93, 23);
            this.btnGetSerialNumber.TabIndex = 88;
            this.btnGetSerialNumber.Text = "Getir";
            this.btnGetSerialNumber.UseVisualStyleBackColor = true;
            this.btnGetSerialNumber.Click += new System.EventHandler(this.btnGetSerialNumber_Click);
            // 
            // edtSerialNumber
            // 
            this.edtSerialNumber.Location = new System.Drawing.Point(12, 19);
            this.edtSerialNumber.Name = "edtSerialNumber";
            this.edtSerialNumber.Size = new System.Drawing.Size(182, 20);
            this.edtSerialNumber.TabIndex = 87;
            // 
            // grDeviceWorkMode
            // 
            this.grDeviceWorkMode.Controls.Add(this.cmbOnlineKartModu);
            this.grDeviceWorkMode.Controls.Add(this.label11);
            this.grDeviceWorkMode.Controls.Add(this.label187);
            this.grDeviceWorkMode.Controls.Add(this.label3);
            this.grDeviceWorkMode.Controls.Add(this.cbOnlineEnabledOffline);
            this.grDeviceWorkMode.Controls.Add(this.btnSetWorkMode);
            this.grDeviceWorkMode.Controls.Add(this.btnGetWorkMode);
            this.grDeviceWorkMode.Controls.Add(this.edtOnlineTimeOut);
            this.grDeviceWorkMode.Controls.Add(this.rbOnlineUDP);
            this.grDeviceWorkMode.Controls.Add(this.rbOnlineTCP);
            this.grDeviceWorkMode.Controls.Add(this.rbOfflineCardBlackList);
            this.grDeviceWorkMode.Controls.Add(this.rbOfflineWhiteList);
            this.grDeviceWorkMode.Location = new System.Drawing.Point(526, 6);
            this.grDeviceWorkMode.Name = "grDeviceWorkMode";
            this.grDeviceWorkMode.Size = new System.Drawing.Size(327, 264);
            this.grDeviceWorkMode.TabIndex = 2;
            this.grDeviceWorkMode.TabStop = false;
            this.grDeviceWorkMode.Text = "  Cihaz Çalışma Modu  ";
            // 
            // cmbOnlineKartModu
            // 
            this.cmbOnlineKartModu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOnlineKartModu.FormattingEnabled = true;
            this.cmbOnlineKartModu.Items.AddRange(new object[] {
            "TCP",
            "UDP",
            "TCP Client Mode"});
            this.cmbOnlineKartModu.Location = new System.Drawing.Point(120, 75);
            this.cmbOnlineKartModu.Name = "cmbOnlineKartModu";
            this.cmbOnlineKartModu.Size = new System.Drawing.Size(140, 21);
            this.cmbOnlineKartModu.TabIndex = 56;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(170, 187);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 55;
            this.label11.Text = "(M.Sn)";
            // 
            // label187
            // 
            this.label187.AutoSize = true;
            this.label187.Location = new System.Drawing.Point(27, 79);
            this.label187.Name = "label187";
            this.label187.Size = new System.Drawing.Size(83, 13);
            this.label187.TabIndex = 54;
            this.label187.Text = "Online Kart Mod";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 54;
            this.label3.Text = "Zaman Aşımı ";
            // 
            // cbOnlineEnabledOffline
            // 
            this.cbOnlineEnabledOffline.Checked = true;
            this.cbOnlineEnabledOffline.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbOnlineEnabledOffline.Location = new System.Drawing.Point(6, 145);
            this.cbOnlineEnabledOffline.Name = "cbOnlineEnabledOffline";
            this.cbOnlineEnabledOffline.Size = new System.Drawing.Size(205, 57);
            this.cbOnlineEnabledOffline.TabIndex = 50;
            this.cbOnlineEnabledOffline.Text = "Online sistemde varsayılan süre kadar server ile iletişim kurulamadı ise offline " +
    "çalışsın mı ?";
            this.cbOnlineEnabledOffline.UseVisualStyleBackColor = true;
            // 
            // btnSetWorkMode
            // 
            this.btnSetWorkMode.Location = new System.Drawing.Point(115, 234);
            this.btnSetWorkMode.Name = "btnSetWorkMode";
            this.btnSetWorkMode.Size = new System.Drawing.Size(83, 23);
            this.btnSetWorkMode.TabIndex = 53;
            this.btnSetWorkMode.Text = "Gönder";
            this.btnSetWorkMode.UseVisualStyleBackColor = true;
            this.btnSetWorkMode.Click += new System.EventHandler(this.btnSetWorkMode_Click);
            // 
            // btnGetWorkMode
            // 
            this.btnGetWorkMode.Location = new System.Drawing.Point(16, 234);
            this.btnGetWorkMode.Name = "btnGetWorkMode";
            this.btnGetWorkMode.Size = new System.Drawing.Size(93, 23);
            this.btnGetWorkMode.TabIndex = 52;
            this.btnGetWorkMode.Text = "Getir";
            this.btnGetWorkMode.UseVisualStyleBackColor = true;
            this.btnGetWorkMode.Click += new System.EventHandler(this.btnGetWorkMode_Click);
            // 
            // edtOnlineTimeOut
            // 
            this.edtOnlineTimeOut.Location = new System.Drawing.Point(82, 203);
            this.edtOnlineTimeOut.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.edtOnlineTimeOut.Name = "edtOnlineTimeOut";
            this.edtOnlineTimeOut.Size = new System.Drawing.Size(83, 20);
            this.edtOnlineTimeOut.TabIndex = 51;
            // 
            // rbOnlineUDP
            // 
            this.rbOnlineUDP.AutoSize = true;
            this.rbOnlineUDP.Location = new System.Drawing.Point(30, 124);
            this.rbOnlineUDP.Name = "rbOnlineUDP";
            this.rbOnlineUDP.Size = new System.Drawing.Size(81, 17);
            this.rbOnlineUDP.TabIndex = 49;
            this.rbOnlineUDP.TabStop = true;
            this.rbOnlineUDP.Text = "Online UDP";
            this.rbOnlineUDP.UseVisualStyleBackColor = true;
            // 
            // rbOnlineTCP
            // 
            this.rbOnlineTCP.AutoSize = true;
            this.rbOnlineTCP.Location = new System.Drawing.Point(30, 99);
            this.rbOnlineTCP.Name = "rbOnlineTCP";
            this.rbOnlineTCP.Size = new System.Drawing.Size(79, 17);
            this.rbOnlineTCP.TabIndex = 48;
            this.rbOnlineTCP.TabStop = true;
            this.rbOnlineTCP.Text = "Online TCP";
            this.rbOnlineTCP.UseVisualStyleBackColor = true;
            // 
            // rbOfflineCardBlackList
            // 
            this.rbOfflineCardBlackList.AutoSize = true;
            this.rbOfflineCardBlackList.Location = new System.Drawing.Point(30, 55);
            this.rbOfflineCardBlackList.Name = "rbOfflineCardBlackList";
            this.rbOfflineCardBlackList.Size = new System.Drawing.Size(134, 17);
            this.rbOfflineCardBlackList.TabIndex = 47;
            this.rbOfflineCardBlackList.TabStop = true;
            this.rbOfflineCardBlackList.Text = "Offline Kart ve Blacklist";
            this.rbOfflineCardBlackList.UseVisualStyleBackColor = true;
            // 
            // rbOfflineWhiteList
            // 
            this.rbOfflineWhiteList.AutoSize = true;
            this.rbOfflineWhiteList.Location = new System.Drawing.Point(30, 30);
            this.rbOfflineWhiteList.Name = "rbOfflineWhiteList";
            this.rbOfflineWhiteList.Size = new System.Drawing.Size(101, 17);
            this.rbOfflineWhiteList.TabIndex = 46;
            this.rbOfflineWhiteList.TabStop = true;
            this.rbOfflineWhiteList.Text = "Offline White list";
            this.rbOfflineWhiteList.UseVisualStyleBackColor = true;
            // 
            // grDeviceGeneralSettings
            // 
            this.grDeviceGeneralSettings.Controls.Add(this.label185);
            this.grDeviceGeneralSettings.Controls.Add(this.cmbFontTipi);
            this.grDeviceGeneralSettings.Controls.Add(this.btnGonder);
            this.grDeviceGeneralSettings.Controls.Add(this.btnGetir);
            this.grDeviceGeneralSettings.Controls.Add(this.label61);
            this.grDeviceGeneralSettings.Controls.Add(this.label60);
            this.grDeviceGeneralSettings.Controls.Add(this.nmrKartLoginBeklemeSuresi);
            this.grDeviceGeneralSettings.Controls.Add(this.edtAyniKartiOkumaAraligi);
            this.grDeviceGeneralSettings.Controls.Add(this.label186);
            this.grDeviceGeneralSettings.Controls.Add(this.label59);
            this.grDeviceGeneralSettings.Controls.Add(this.edtArdasikKartOkumaAraligi);
            this.grDeviceGeneralSettings.Controls.Add(this.label58);
            this.grDeviceGeneralSettings.Controls.Add(this.label57);
            this.grDeviceGeneralSettings.Controls.Add(this.edtKartOkumaSuresi);
            this.grDeviceGeneralSettings.Controls.Add(this.label51);
            this.grDeviceGeneralSettings.Controls.Add(this.edtGunlukYenidenBaslatmaZamani);
            this.grDeviceGeneralSettings.Controls.Add(this.chkGunlukYenidenBaslatma);
            this.grDeviceGeneralSettings.Controls.Add(this.groupBox5);
            this.grDeviceGeneralSettings.Controls.Add(this.groupBox3);
            this.grDeviceGeneralSettings.Controls.Add(this.groupBox2);
            this.grDeviceGeneralSettings.Controls.Add(this.label56);
            this.grDeviceGeneralSettings.Controls.Add(this.label55);
            this.grDeviceGeneralSettings.Controls.Add(this.edtRenkYogunlugu);
            this.grDeviceGeneralSettings.Controls.Add(this.edtArkaPlanIsigi);
            this.grDeviceGeneralSettings.Controls.Add(this.label54);
            this.grDeviceGeneralSettings.Controls.Add(this.edtIkinciSatir);
            this.grDeviceGeneralSettings.Controls.Add(this.label53);
            this.grDeviceGeneralSettings.Controls.Add(this.label52);
            this.grDeviceGeneralSettings.Controls.Add(this.edtBirinciSatir);
            this.grDeviceGeneralSettings.Controls.Add(this.edtCihazNo);
            this.grDeviceGeneralSettings.Controls.Add(this.label50);
            this.grDeviceGeneralSettings.Location = new System.Drawing.Point(192, 6);
            this.grDeviceGeneralSettings.Name = "grDeviceGeneralSettings";
            this.grDeviceGeneralSettings.Size = new System.Drawing.Size(328, 500);
            this.grDeviceGeneralSettings.TabIndex = 1;
            this.grDeviceGeneralSettings.TabStop = false;
            this.grDeviceGeneralSettings.Text = " Cihaz Genel Ayarları ";
            // 
            // label185
            // 
            this.label185.AutoSize = true;
            this.label185.Location = new System.Drawing.Point(179, 97);
            this.label185.Name = "label185";
            this.label185.Size = new System.Drawing.Size(48, 13);
            this.label185.TabIndex = 39;
            this.label185.Text = "Font Tipi";
            // 
            // cmbFontTipi
            // 
            this.cmbFontTipi.FormattingEnabled = true;
            this.cmbFontTipi.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
            this.cmbFontTipi.Location = new System.Drawing.Point(179, 113);
            this.cmbFontTipi.Name = "cmbFontTipi";
            this.cmbFontTipi.Size = new System.Drawing.Size(71, 21);
            this.cmbFontTipi.TabIndex = 38;
            this.cmbFontTipi.Text = "0";
            // 
            // btnGonder
            // 
            this.btnGonder.Location = new System.Drawing.Point(86, 451);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(75, 38);
            this.btnGonder.TabIndex = 37;
            this.btnGonder.Text = "Gönder";
            this.btnGonder.UseVisualStyleBackColor = true;
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // btnGetir
            // 
            this.btnGetir.Location = new System.Drawing.Point(6, 451);
            this.btnGetir.Name = "btnGetir";
            this.btnGetir.Size = new System.Drawing.Size(75, 38);
            this.btnGetir.TabIndex = 36;
            this.btnGetir.Text = "Getir";
            this.btnGetir.UseVisualStyleBackColor = true;
            this.btnGetir.Click += new System.EventHandler(this.btnGetir_Click);
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Location = new System.Drawing.Point(232, 369);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(23, 13);
            this.label61.TabIndex = 35;
            this.label61.Text = "ms.";
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(232, 347);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(23, 13);
            this.label60.TabIndex = 34;
            this.label60.Text = "ms.";
            // 
            // nmrKartLoginBeklemeSuresi
            // 
            this.nmrKartLoginBeklemeSuresi.Location = new System.Drawing.Point(168, 391);
            this.nmrKartLoginBeklemeSuresi.Maximum = new decimal(new int[] {
            6500,
            0,
            0,
            0});
            this.nmrKartLoginBeklemeSuresi.Name = "nmrKartLoginBeklemeSuresi";
            this.nmrKartLoginBeklemeSuresi.Size = new System.Drawing.Size(57, 20);
            this.nmrKartLoginBeklemeSuresi.TabIndex = 33;
            // 
            // edtAyniKartiOkumaAraligi
            // 
            this.edtAyniKartiOkumaAraligi.Location = new System.Drawing.Point(168, 365);
            this.edtAyniKartiOkumaAraligi.Maximum = new decimal(new int[] {
            6500,
            0,
            0,
            0});
            this.edtAyniKartiOkumaAraligi.Name = "edtAyniKartiOkumaAraligi";
            this.edtAyniKartiOkumaAraligi.Size = new System.Drawing.Size(57, 20);
            this.edtAyniKartiOkumaAraligi.TabIndex = 33;
            // 
            // label186
            // 
            this.label186.AutoSize = true;
            this.label186.Location = new System.Drawing.Point(13, 397);
            this.label186.Name = "label186";
            this.label186.Size = new System.Drawing.Size(131, 13);
            this.label186.TabIndex = 32;
            this.label186.Text = "Kart Login Bekleme Süresi";
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Location = new System.Drawing.Point(13, 369);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(155, 13);
            this.label59.TabIndex = 32;
            this.label59.Text = "Aynı Kart\'ı Ardışık Okuma Aralığı";
            // 
            // edtArdasikKartOkumaAraligi
            // 
            this.edtArdasikKartOkumaAraligi.Location = new System.Drawing.Point(168, 342);
            this.edtArdasikKartOkumaAraligi.Maximum = new decimal(new int[] {
            6500,
            0,
            0,
            0});
            this.edtArdasikKartOkumaAraligi.Name = "edtArdasikKartOkumaAraligi";
            this.edtArdasikKartOkumaAraligi.Size = new System.Drawing.Size(57, 20);
            this.edtArdasikKartOkumaAraligi.TabIndex = 31;
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(13, 347);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(128, 13);
            this.label58.TabIndex = 30;
            this.label58.Text = "Ardışık Kart Okuma Aralığı";
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(173, 321);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(129, 13);
            this.label57.TabIndex = 29;
            this.label57.Text = "0..250 (x10 ms) (0=Kapalı)";
            // 
            // edtKartOkumaSuresi
            // 
            this.edtKartOkumaSuresi.Location = new System.Drawing.Point(113, 318);
            this.edtKartOkumaSuresi.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.edtKartOkumaSuresi.Name = "edtKartOkumaSuresi";
            this.edtKartOkumaSuresi.Size = new System.Drawing.Size(57, 20);
            this.edtKartOkumaSuresi.TabIndex = 28;
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(13, 321);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(95, 13);
            this.label51.TabIndex = 27;
            this.label51.Text = "Kart Okuma Süresi";
            // 
            // edtGunlukYenidenBaslatmaZamani
            // 
            this.edtGunlukYenidenBaslatmaZamani.Enabled = false;
            this.edtGunlukYenidenBaslatmaZamani.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.edtGunlukYenidenBaslatmaZamani.Location = new System.Drawing.Point(163, 293);
            this.edtGunlukYenidenBaslatmaZamani.Name = "edtGunlukYenidenBaslatmaZamani";
            this.edtGunlukYenidenBaslatmaZamani.ShowUpDown = true;
            this.edtGunlukYenidenBaslatmaZamani.Size = new System.Drawing.Size(151, 20);
            this.edtGunlukYenidenBaslatmaZamani.TabIndex = 26;
            this.edtGunlukYenidenBaslatmaZamani.Value = new System.DateTime(2014, 3, 11, 0, 0, 0, 0);
            // 
            // chkGunlukYenidenBaslatma
            // 
            this.chkGunlukYenidenBaslatma.AutoSize = true;
            this.chkGunlukYenidenBaslatma.Location = new System.Drawing.Point(16, 295);
            this.chkGunlukYenidenBaslatma.Name = "chkGunlukYenidenBaslatma";
            this.chkGunlukYenidenBaslatma.Size = new System.Drawing.Size(148, 17);
            this.chkGunlukYenidenBaslatma.TabIndex = 25;
            this.chkGunlukYenidenBaslatma.Text = "Günlük Yeniden Başlatma";
            this.chkGunlukYenidenBaslatma.UseVisualStyleBackColor = true;
            this.chkGunlukYenidenBaslatma.CheckedChanged += new System.EventHandler(this.chkGunlukYenidenBaslatma_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.radioTransistorCikisi2NormalClosed);
            this.groupBox5.Controls.Add(this.radioTransistorCikisi2NormalOpen);
            this.groupBox5.Location = new System.Drawing.Point(71, 248);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(244, 36);
            this.groupBox5.TabIndex = 23;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Transistör Çıkışı 2";
            // 
            // radioTransistorCikisi2NormalClosed
            // 
            this.radioTransistorCikisi2NormalClosed.AutoSize = true;
            this.radioTransistorCikisi2NormalClosed.Location = new System.Drawing.Point(130, 16);
            this.radioTransistorCikisi2NormalClosed.Name = "radioTransistorCikisi2NormalClosed";
            this.radioTransistorCikisi2NormalClosed.Size = new System.Drawing.Size(93, 17);
            this.radioTransistorCikisi2NormalClosed.TabIndex = 19;
            this.radioTransistorCikisi2NormalClosed.Text = "Normal Closed";
            this.radioTransistorCikisi2NormalClosed.UseVisualStyleBackColor = true;
            // 
            // radioTransistorCikisi2NormalOpen
            // 
            this.radioTransistorCikisi2NormalOpen.AutoSize = true;
            this.radioTransistorCikisi2NormalOpen.Checked = true;
            this.radioTransistorCikisi2NormalOpen.Location = new System.Drawing.Point(19, 15);
            this.radioTransistorCikisi2NormalOpen.Name = "radioTransistorCikisi2NormalOpen";
            this.radioTransistorCikisi2NormalOpen.Size = new System.Drawing.Size(87, 17);
            this.radioTransistorCikisi2NormalOpen.TabIndex = 18;
            this.radioTransistorCikisi2NormalOpen.TabStop = true;
            this.radioTransistorCikisi2NormalOpen.Text = "Normal Open";
            this.radioTransistorCikisi2NormalOpen.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioTransistorCikisi1NormalClosed);
            this.groupBox3.Controls.Add(this.radioTransistorCikisi1NormalOpen);
            this.groupBox3.Location = new System.Drawing.Point(72, 208);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(244, 38);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Transistör Çıkışı 1";
            // 
            // radioTransistorCikisi1NormalClosed
            // 
            this.radioTransistorCikisi1NormalClosed.AutoSize = true;
            this.radioTransistorCikisi1NormalClosed.Checked = true;
            this.radioTransistorCikisi1NormalClosed.Location = new System.Drawing.Point(129, 16);
            this.radioTransistorCikisi1NormalClosed.Name = "radioTransistorCikisi1NormalClosed";
            this.radioTransistorCikisi1NormalClosed.Size = new System.Drawing.Size(93, 17);
            this.radioTransistorCikisi1NormalClosed.TabIndex = 19;
            this.radioTransistorCikisi1NormalClosed.TabStop = true;
            this.radioTransistorCikisi1NormalClosed.Text = "Normal Closed";
            this.radioTransistorCikisi1NormalClosed.UseVisualStyleBackColor = true;
            // 
            // radioTransistorCikisi1NormalOpen
            // 
            this.radioTransistorCikisi1NormalOpen.AutoSize = true;
            this.radioTransistorCikisi1NormalOpen.Location = new System.Drawing.Point(19, 15);
            this.radioTransistorCikisi1NormalOpen.Name = "radioTransistorCikisi1NormalOpen";
            this.radioTransistorCikisi1NormalOpen.Size = new System.Drawing.Size(87, 17);
            this.radioTransistorCikisi1NormalOpen.TabIndex = 18;
            this.radioTransistorCikisi1NormalOpen.Text = "Normal Open";
            this.radioTransistorCikisi1NormalOpen.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkVarsayilanLogo);
            this.groupBox2.Controls.Add(this.chkVarsayilanMesaj);
            this.groupBox2.Location = new System.Drawing.Point(72, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(244, 41);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Varsayılan Ekran Türü";
            // 
            // chkVarsayilanLogo
            // 
            this.chkVarsayilanLogo.AccessibleName = "ekranTuru";
            this.chkVarsayilanLogo.AutoSize = true;
            this.chkVarsayilanLogo.Checked = true;
            this.chkVarsayilanLogo.Location = new System.Drawing.Point(129, 18);
            this.chkVarsayilanLogo.Name = "chkVarsayilanLogo";
            this.chkVarsayilanLogo.Size = new System.Drawing.Size(49, 17);
            this.chkVarsayilanLogo.TabIndex = 7;
            this.chkVarsayilanLogo.TabStop = true;
            this.chkVarsayilanLogo.Text = "Logo";
            this.chkVarsayilanLogo.UseVisualStyleBackColor = true;
            // 
            // chkVarsayilanMesaj
            // 
            this.chkVarsayilanMesaj.AccessibleName = "ekranTuru";
            this.chkVarsayilanMesaj.AutoSize = true;
            this.chkVarsayilanMesaj.Location = new System.Drawing.Point(19, 18);
            this.chkVarsayilanMesaj.Name = "chkVarsayilanMesaj";
            this.chkVarsayilanMesaj.Size = new System.Drawing.Size(104, 17);
            this.chkVarsayilanMesaj.TabIndex = 6;
            this.chkVarsayilanMesaj.Text = "Varsayılan Mesaj";
            this.chkVarsayilanMesaj.UseVisualStyleBackColor = true;
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(13, 185);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(87, 13);
            this.label56.TabIndex = 14;
            this.label56.Text = "Renk Yoğunluğu";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(13, 159);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(74, 13);
            this.label55.TabIndex = 13;
            this.label55.Text = "Arka Plan Işığı";
            // 
            // edtRenkYogunlugu
            // 
            this.edtRenkYogunlugu.Location = new System.Drawing.Point(105, 182);
            this.edtRenkYogunlugu.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.edtRenkYogunlugu.Name = "edtRenkYogunlugu";
            this.edtRenkYogunlugu.Size = new System.Drawing.Size(120, 20);
            this.edtRenkYogunlugu.TabIndex = 12;
            this.edtRenkYogunlugu.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // edtArkaPlanIsigi
            // 
            this.edtArkaPlanIsigi.Location = new System.Drawing.Point(105, 156);
            this.edtArkaPlanIsigi.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.edtArkaPlanIsigi.Name = "edtArkaPlanIsigi";
            this.edtArkaPlanIsigi.Size = new System.Drawing.Size(120, 20);
            this.edtArkaPlanIsigi.TabIndex = 11;
            this.edtArkaPlanIsigi.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(72, 135);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(102, 13);
            this.label54.TabIndex = 10;
            this.label54.Text = "Ekran (LCD) Ayarları";
            // 
            // edtIkinciSatir
            // 
            this.edtIkinciSatir.Location = new System.Drawing.Point(72, 113);
            this.edtIkinciSatir.Name = "edtIkinciSatir";
            this.edtIkinciSatir.Size = new System.Drawing.Size(100, 20);
            this.edtIkinciSatir.TabIndex = 9;
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(13, 118);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(40, 13);
            this.label53.TabIndex = 8;
            this.label53.Text = "2. Satır";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(13, 91);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(40, 13);
            this.label52.TabIndex = 7;
            this.label52.Text = "1. Satır";
            // 
            // edtBirinciSatir
            // 
            this.edtBirinciSatir.Location = new System.Drawing.Point(72, 88);
            this.edtBirinciSatir.Name = "edtBirinciSatir";
            this.edtBirinciSatir.Size = new System.Drawing.Size(100, 20);
            this.edtBirinciSatir.TabIndex = 6;
            // 
            // edtCihazNo
            // 
            this.edtCihazNo.Location = new System.Drawing.Point(72, 20);
            this.edtCihazNo.Maximum = new decimal(new int[] {
            6565,
            0,
            0,
            0});
            this.edtCihazNo.Name = "edtCihazNo";
            this.edtCihazNo.Size = new System.Drawing.Size(57, 20);
            this.edtCihazNo.TabIndex = 2;
            this.edtCihazNo.Value = new decimal(new int[] {
            6565,
            0,
            0,
            0});
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(16, 23);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(53, 13);
            this.label50.TabIndex = 1;
            this.label50.Text = "Cihaz No ";
            // 
            // gbDeviceİnfo
            // 
            this.gbDeviceİnfo.Controls.Add(this.grDeviceOperation);
            this.gbDeviceİnfo.Controls.Add(this.grDeviceStatus);
            this.gbDeviceİnfo.Controls.Add(this.grDateTime);
            this.gbDeviceİnfo.Controls.Add(this.grHeadTail);
            this.gbDeviceİnfo.Controls.Add(this.lblfwVersion);
            this.gbDeviceİnfo.Controls.Add(this.btnfwVersion);
            this.gbDeviceİnfo.Location = new System.Drawing.Point(6, 6);
            this.gbDeviceİnfo.Name = "gbDeviceİnfo";
            this.gbDeviceİnfo.Size = new System.Drawing.Size(180, 433);
            this.gbDeviceİnfo.TabIndex = 0;
            this.gbDeviceİnfo.TabStop = false;
            this.gbDeviceİnfo.Text = "Cihaz Bilgileri";
            // 
            // grDeviceOperation
            // 
            this.grDeviceOperation.Controls.Add(this.cdSaveIPAddr);
            this.grDeviceOperation.Controls.Add(this.btnSetDeviceFactoryDefaults);
            this.grDeviceOperation.Controls.Add(this.btnReboot);
            this.grDeviceOperation.Location = new System.Drawing.Point(2, 332);
            this.grDeviceOperation.Name = "grDeviceOperation";
            this.grDeviceOperation.Size = new System.Drawing.Size(168, 95);
            this.grDeviceOperation.TabIndex = 5;
            this.grDeviceOperation.TabStop = false;
            this.grDeviceOperation.Text = "Cihaz Operasyonları";
            // 
            // cdSaveIPAddr
            // 
            this.cdSaveIPAddr.AutoSize = true;
            this.cdSaveIPAddr.Checked = true;
            this.cdSaveIPAddr.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cdSaveIPAddr.Location = new System.Drawing.Point(35, 47);
            this.cdSaveIPAddr.Name = "cdSaveIPAddr";
            this.cdSaveIPAddr.Size = new System.Drawing.Size(117, 17);
            this.cdSaveIPAddr.TabIndex = 5;
            this.cdSaveIPAddr.Text = "Ip Adresini Sıfırlama";
            this.cdSaveIPAddr.UseVisualStyleBackColor = true;
            // 
            // btnSetDeviceFactoryDefaults
            // 
            this.btnSetDeviceFactoryDefaults.Location = new System.Drawing.Point(11, 69);
            this.btnSetDeviceFactoryDefaults.Name = "btnSetDeviceFactoryDefaults";
            this.btnSetDeviceFactoryDefaults.Size = new System.Drawing.Size(146, 20);
            this.btnSetDeviceFactoryDefaults.TabIndex = 4;
            this.btnSetDeviceFactoryDefaults.Text = "Fabrika Ayarlarına Dön";
            this.btnSetDeviceFactoryDefaults.UseVisualStyleBackColor = true;
            this.btnSetDeviceFactoryDefaults.Click += new System.EventHandler(this.btnSetDeviceFactoryDefaults_Click);
            // 
            // btnReboot
            // 
            this.btnReboot.Location = new System.Drawing.Point(11, 21);
            this.btnReboot.Name = "btnReboot";
            this.btnReboot.Size = new System.Drawing.Size(146, 20);
            this.btnReboot.TabIndex = 3;
            this.btnReboot.Text = "Cihazı Yeniden Başlat";
            this.btnReboot.UseVisualStyleBackColor = true;
            this.btnReboot.Click += new System.EventHandler(this.btnReboot_Click);
            // 
            // grDeviceStatus
            // 
            this.grDeviceStatus.Controls.Add(this.btnSetDeviceStatus);
            this.grDeviceStatus.Controls.Add(this.btnGetDeviceStatus);
            this.grDeviceStatus.Controls.Add(this.rbDeviceDisabled);
            this.grDeviceStatus.Controls.Add(this.rbDeviceEnabled);
            this.grDeviceStatus.Location = new System.Drawing.Point(2, 251);
            this.grDeviceStatus.Name = "grDeviceStatus";
            this.grDeviceStatus.Size = new System.Drawing.Size(168, 75);
            this.grDeviceStatus.TabIndex = 4;
            this.grDeviceStatus.TabStop = false;
            this.grDeviceStatus.Text = "Cihaz Durum Bilgisi";
            // 
            // btnSetDeviceStatus
            // 
            this.btnSetDeviceStatus.Location = new System.Drawing.Point(91, 46);
            this.btnSetDeviceStatus.Name = "btnSetDeviceStatus";
            this.btnSetDeviceStatus.Size = new System.Drawing.Size(68, 23);
            this.btnSetDeviceStatus.TabIndex = 48;
            this.btnSetDeviceStatus.Text = "Gönder";
            this.btnSetDeviceStatus.UseVisualStyleBackColor = true;
            this.btnSetDeviceStatus.Click += new System.EventHandler(this.btnSetDeviceStatus_Click);
            // 
            // btnGetDeviceStatus
            // 
            this.btnGetDeviceStatus.Location = new System.Drawing.Point(10, 46);
            this.btnGetDeviceStatus.Name = "btnGetDeviceStatus";
            this.btnGetDeviceStatus.Size = new System.Drawing.Size(75, 23);
            this.btnGetDeviceStatus.TabIndex = 47;
            this.btnGetDeviceStatus.Text = "Getir";
            this.btnGetDeviceStatus.UseVisualStyleBackColor = true;
            this.btnGetDeviceStatus.Click += new System.EventHandler(this.btnGetDeviceStatus_Click);
            // 
            // rbDeviceDisabled
            // 
            this.rbDeviceDisabled.AutoSize = true;
            this.rbDeviceDisabled.Location = new System.Drawing.Point(99, 18);
            this.rbDeviceDisabled.Name = "rbDeviceDisabled";
            this.rbDeviceDisabled.Size = new System.Drawing.Size(48, 17);
            this.rbDeviceDisabled.TabIndex = 46;
            this.rbDeviceDisabled.TabStop = true;
            this.rbDeviceDisabled.Text = "Pasif";
            this.rbDeviceDisabled.UseVisualStyleBackColor = true;
            // 
            // rbDeviceEnabled
            // 
            this.rbDeviceEnabled.AutoSize = true;
            this.rbDeviceEnabled.Location = new System.Drawing.Point(13, 18);
            this.rbDeviceEnabled.Name = "rbDeviceEnabled";
            this.rbDeviceEnabled.Size = new System.Drawing.Size(46, 17);
            this.rbDeviceEnabled.TabIndex = 45;
            this.rbDeviceEnabled.TabStop = true;
            this.rbDeviceEnabled.Text = "Aktif";
            this.rbDeviceEnabled.UseVisualStyleBackColor = true;
            // 
            // grDateTime
            // 
            this.grDateTime.Controls.Add(this.btnSetDateTime);
            this.grDateTime.Controls.Add(this.edtDateTime);
            this.grDateTime.Location = new System.Drawing.Point(2, 170);
            this.grDateTime.Name = "grDateTime";
            this.grDateTime.Size = new System.Drawing.Size(168, 75);
            this.grDateTime.TabIndex = 3;
            this.grDateTime.TabStop = false;
            this.grDateTime.Text = "Tarih/Saat";
            // 
            // btnSetDateTime
            // 
            this.btnSetDateTime.Location = new System.Drawing.Point(10, 45);
            this.btnSetDateTime.Name = "btnSetDateTime";
            this.btnSetDateTime.Size = new System.Drawing.Size(123, 23);
            this.btnSetDateTime.TabIndex = 24;
            this.btnSetDateTime.Text = "Tarih Saat Gönder";
            this.btnSetDateTime.UseVisualStyleBackColor = true;
            this.btnSetDateTime.Click += new System.EventHandler(this.btnSetDateTime_Click);
            // 
            // edtDateTime
            // 
            this.edtDateTime.CustomFormat = " dd.MM.yyyy HH:mm:ss";
            this.edtDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.edtDateTime.Location = new System.Drawing.Point(10, 19);
            this.edtDateTime.Name = "edtDateTime";
            this.edtDateTime.Size = new System.Drawing.Size(145, 20);
            this.edtDateTime.TabIndex = 23;
            // 
            // grHeadTail
            // 
            this.grHeadTail.Controls.Add(this.btnSetHead);
            this.grHeadTail.Controls.Add(this.label10);
            this.grHeadTail.Controls.Add(this.label2);
            this.grHeadTail.Controls.Add(this.lblCapacity);
            this.grHeadTail.Controls.Add(this.edtTail);
            this.grHeadTail.Controls.Add(this.edtHead);
            this.grHeadTail.Controls.Add(this.btnGetHead);
            this.grHeadTail.Location = new System.Drawing.Point(0, 64);
            this.grHeadTail.Name = "grHeadTail";
            this.grHeadTail.Size = new System.Drawing.Size(168, 100);
            this.grHeadTail.TabIndex = 2;
            this.grHeadTail.TabStop = false;
            this.grHeadTail.Text = "Head - Tail - Kapasite";
            // 
            // btnSetHead
            // 
            this.btnSetHead.Location = new System.Drawing.Point(105, 45);
            this.btnSetHead.Name = "btnSetHead";
            this.btnSetHead.Size = new System.Drawing.Size(52, 23);
            this.btnSetHead.TabIndex = 7;
            this.btnSetHead.Text = "Gönder";
            this.btnSetHead.UseVisualStyleBackColor = true;
            this.btnSetHead.Click += new System.EventHandler(this.btnSetHead_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(2, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Tail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Head";
            // 
            // lblCapacity
            // 
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.Location = new System.Drawing.Point(2, 71);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(48, 13);
            this.lblCapacity.TabIndex = 4;
            this.lblCapacity.Text = "Kapasite";
            // 
            // edtTail
            // 
            this.edtTail.Location = new System.Drawing.Point(37, 45);
            this.edtTail.Maximum = new decimal(new int[] {
            255619527,
            146921512,
            5427,
            0});
            this.edtTail.Name = "edtTail";
            this.edtTail.Size = new System.Drawing.Size(62, 20);
            this.edtTail.TabIndex = 3;
            // 
            // edtHead
            // 
            this.edtHead.Location = new System.Drawing.Point(38, 22);
            this.edtHead.Maximum = new decimal(new int[] {
            651588039,
            2587007,
            0,
            0});
            this.edtHead.Name = "edtHead";
            this.edtHead.Size = new System.Drawing.Size(61, 20);
            this.edtHead.TabIndex = 2;
            // 
            // btnGetHead
            // 
            this.btnGetHead.Location = new System.Drawing.Point(105, 19);
            this.btnGetHead.Name = "btnGetHead";
            this.btnGetHead.Size = new System.Drawing.Size(52, 23);
            this.btnGetHead.TabIndex = 0;
            this.btnGetHead.Text = "Getir";
            this.btnGetHead.UseVisualStyleBackColor = true;
            this.btnGetHead.Click += new System.EventHandler(this.btnGetHead_Click);
            // 
            // lblfwVersion
            // 
            this.lblfwVersion.AutoSize = true;
            this.lblfwVersion.Location = new System.Drawing.Point(45, 41);
            this.lblfwVersion.Name = "lblfwVersion";
            this.lblfwVersion.Size = new System.Drawing.Size(79, 13);
            this.lblfwVersion.TabIndex = 1;
            this.lblfwVersion.Text = "........................";
            // 
            // btnfwVersion
            // 
            this.btnfwVersion.Location = new System.Drawing.Point(6, 19);
            this.btnfwVersion.Name = "btnfwVersion";
            this.btnfwVersion.Size = new System.Drawing.Size(161, 19);
            this.btnfwVersion.TabIndex = 0;
            this.btnfwVersion.Text = "Cihaz fw Versiyon Getir";
            this.btnfwVersion.UseVisualStyleBackColor = true;
            this.btnfwVersion.Click += new System.EventHandler(this.btnfwVersion_Click);
            // 
            // tsCominicationSettings
            // 
            this.tsCominicationSettings.Controls.Add(this.groupBox12);
            this.tsCominicationSettings.Controls.Add(this.groupBox11);
            this.tsCominicationSettings.Controls.Add(this.groupBox10);
            this.tsCominicationSettings.Controls.Add(this.groupBox9);
            this.tsCominicationSettings.Controls.Add(this.groupBox8);
            this.tsCominicationSettings.Controls.Add(this.groupBox1);
            this.tsCominicationSettings.Location = new System.Drawing.Point(4, 22);
            this.tsCominicationSettings.Name = "tsCominicationSettings";
            this.tsCominicationSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tsCominicationSettings.Size = new System.Drawing.Size(1108, 629);
            this.tsCominicationSettings.TabIndex = 1;
            this.tsCominicationSettings.Text = "Haberleşme Ayarları";
            this.tsCominicationSettings.UseVisualStyleBackColor = true;
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.button43);
            this.groupBox12.Controls.Add(this.label27);
            this.groupBox12.Controls.Add(this.txtWebAraYuzuSifresi);
            this.groupBox12.Controls.Add(this.button13);
            this.groupBox12.Location = new System.Drawing.Point(499, 239);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(244, 104);
            this.groupBox12.TabIndex = 5;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Web Arayüzü Şifresi";
            // 
            // button43
            // 
            this.button43.Location = new System.Drawing.Point(97, 73);
            this.button43.Name = "button43";
            this.button43.Size = new System.Drawing.Size(75, 26);
            this.button43.TabIndex = 9;
            this.button43.Text = "Getir";
            this.button43.UseVisualStyleBackColor = true;
            this.button43.Click += new System.EventHandler(this.button43_Click);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(6, 28);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(28, 13);
            this.label27.TabIndex = 8;
            this.label27.Text = "Şifre";
            // 
            // txtWebAraYuzuSifresi
            // 
            this.txtWebAraYuzuSifresi.Location = new System.Drawing.Point(42, 25);
            this.txtWebAraYuzuSifresi.Name = "txtWebAraYuzuSifresi";
            this.txtWebAraYuzuSifresi.Size = new System.Drawing.Size(196, 20);
            this.txtWebAraYuzuSifresi.TabIndex = 7;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(178, 73);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(60, 26);
            this.button13.TabIndex = 6;
            this.button13.Text = "Gönder";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.btnMacAdresiGetir);
            this.groupBox11.Controls.Add(this.label26);
            this.groupBox11.Controls.Add(this.txtMacAdresi);
            this.groupBox11.Controls.Add(this.btnMacAdresiGonder);
            this.groupBox11.Location = new System.Drawing.Point(499, 126);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(244, 107);
            this.groupBox11.TabIndex = 4;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Mac Adresi";
            // 
            // btnMacAdresiGetir
            // 
            this.btnMacAdresiGetir.Location = new System.Drawing.Point(97, 75);
            this.btnMacAdresiGetir.Name = "btnMacAdresiGetir";
            this.btnMacAdresiGetir.Size = new System.Drawing.Size(75, 26);
            this.btnMacAdresiGetir.TabIndex = 9;
            this.btnMacAdresiGetir.Text = "Getir";
            this.btnMacAdresiGetir.UseVisualStyleBackColor = true;
            this.btnMacAdresiGetir.Click += new System.EventHandler(this.btnMacAdresiGetir_Click);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(6, 28);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(34, 13);
            this.label26.TabIndex = 8;
            this.label26.Text = "Adres";
            // 
            // txtMacAdresi
            // 
            this.txtMacAdresi.Location = new System.Drawing.Point(42, 25);
            this.txtMacAdresi.Name = "txtMacAdresi";
            this.txtMacAdresi.Size = new System.Drawing.Size(196, 20);
            this.txtMacAdresi.TabIndex = 7;
            // 
            // btnMacAdresiGonder
            // 
            this.btnMacAdresiGonder.Location = new System.Drawing.Point(178, 75);
            this.btnMacAdresiGonder.Name = "btnMacAdresiGonder";
            this.btnMacAdresiGonder.Size = new System.Drawing.Size(60, 26);
            this.btnMacAdresiGonder.TabIndex = 6;
            this.btnMacAdresiGonder.Text = "Gönder";
            this.btnMacAdresiGonder.UseVisualStyleBackColor = true;
            this.btnMacAdresiGonder.Click += new System.EventHandler(this.btnMacAdresiGonder_Click);
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.label25);
            this.groupBox10.Controls.Add(this.textBox23);
            this.groupBox10.Controls.Add(this.button10);
            this.groupBox10.Location = new System.Drawing.Point(500, 7);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(244, 109);
            this.groupBox10.TabIndex = 3;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Haberleşme Şifresi";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(6, 28);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(28, 13);
            this.label25.TabIndex = 8;
            this.label25.Text = "Şifre";
            // 
            // textBox23
            // 
            this.textBox23.Location = new System.Drawing.Point(42, 25);
            this.textBox23.Name = "textBox23";
            this.textBox23.Size = new System.Drawing.Size(196, 20);
            this.textBox23.TabIndex = 7;
            this.textBox23.Text = "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF";
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(178, 75);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(60, 26);
            this.button10.TabIndex = 6;
            this.button10.Text = "Gönder";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.edtHaberlesmeAyarlariTCPclientAyarlariPortNumarasi);
            this.groupBox9.Controls.Add(this.edtHaberlesmeAyarlariTCPclientAyarlariIpAdresi);
            this.groupBox9.Controls.Add(this.button8);
            this.groupBox9.Controls.Add(this.button9);
            this.groupBox9.Controls.Add(this.label23);
            this.groupBox9.Controls.Add(this.label22);
            this.groupBox9.Location = new System.Drawing.Point(305, 177);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(188, 166);
            this.groupBox9.TabIndex = 2;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "TCP Client Ayarları  ";
            // 
            // edtHaberlesmeAyarlariTCPclientAyarlariPortNumarasi
            // 
            this.edtHaberlesmeAyarlariTCPclientAyarlariPortNumarasi.Location = new System.Drawing.Point(89, 43);
            this.edtHaberlesmeAyarlariTCPclientAyarlariPortNumarasi.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.edtHaberlesmeAyarlariTCPclientAyarlariPortNumarasi.Name = "edtHaberlesmeAyarlariTCPclientAyarlariPortNumarasi";
            this.edtHaberlesmeAyarlariTCPclientAyarlariPortNumarasi.Size = new System.Drawing.Size(57, 20);
            this.edtHaberlesmeAyarlariTCPclientAyarlariPortNumarasi.TabIndex = 32;
            this.edtHaberlesmeAyarlariTCPclientAyarlariPortNumarasi.Value = new decimal(new int[] {
            6555,
            0,
            0,
            0});
            // 
            // edtHaberlesmeAyarlariTCPclientAyarlariIpAdresi
            // 
            this.edtHaberlesmeAyarlariTCPclientAyarlariIpAdresi.Location = new System.Drawing.Point(89, 17);
            this.edtHaberlesmeAyarlariTCPclientAyarlariIpAdresi.Name = "edtHaberlesmeAyarlariTCPclientAyarlariIpAdresi";
            this.edtHaberlesmeAyarlariTCPclientAyarlariIpAdresi.Size = new System.Drawing.Size(87, 20);
            this.edtHaberlesmeAyarlariTCPclientAyarlariIpAdresi.TabIndex = 31;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(96, 134);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(84, 26);
            this.button8.TabIndex = 7;
            this.button8.Text = "Gönder";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(10, 134);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(80, 26);
            this.button9.TabIndex = 6;
            this.button9.Text = "Getir";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(7, 48);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(73, 13);
            this.label23.TabIndex = 2;
            this.label23.Text = "Port Numarası";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(6, 22);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(48, 13);
            this.label22.TabIndex = 1;
            this.label22.Text = "Ip Adresi";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.edtUDPayarlariPortNumarasi);
            this.groupBox8.Controls.Add(this.edtUDPayarlariIpAdresi);
            this.groupBox8.Controls.Add(this.button7);
            this.groupBox8.Controls.Add(this.button6);
            this.groupBox8.Controls.Add(this.chkUDPayarlariUDPLogAktif);
            this.groupBox8.Controls.Add(this.chkUDPayarlariUDPAktif);
            this.groupBox8.Controls.Add(this.label21);
            this.groupBox8.Controls.Add(this.label20);
            this.groupBox8.Location = new System.Drawing.Point(305, 7);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(188, 163);
            this.groupBox8.TabIndex = 1;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "UDP Ayarları  ";
            // 
            // edtUDPayarlariPortNumarasi
            // 
            this.edtUDPayarlariPortNumarasi.Location = new System.Drawing.Point(89, 43);
            this.edtUDPayarlariPortNumarasi.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.edtUDPayarlariPortNumarasi.Name = "edtUDPayarlariPortNumarasi";
            this.edtUDPayarlariPortNumarasi.Size = new System.Drawing.Size(57, 20);
            this.edtUDPayarlariPortNumarasi.TabIndex = 30;
            this.edtUDPayarlariPortNumarasi.Value = new decimal(new int[] {
            514,
            0,
            0,
            0});
            // 
            // edtUDPayarlariIpAdresi
            // 
            this.edtUDPayarlariIpAdresi.Location = new System.Drawing.Point(89, 17);
            this.edtUDPayarlariIpAdresi.Name = "edtUDPayarlariIpAdresi";
            this.edtUDPayarlariIpAdresi.Size = new System.Drawing.Size(87, 20);
            this.edtUDPayarlariIpAdresi.TabIndex = 14;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(120, 131);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(60, 26);
            this.button7.TabIndex = 5;
            this.button7.Text = "Gönder";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(54, 131);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(60, 26);
            this.button6.TabIndex = 4;
            this.button6.Text = "Getir";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // chkUDPayarlariUDPLogAktif
            // 
            this.chkUDPayarlariUDPLogAktif.AutoSize = true;
            this.chkUDPayarlariUDPLogAktif.Checked = true;
            this.chkUDPayarlariUDPLogAktif.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUDPayarlariUDPLogAktif.Location = new System.Drawing.Point(10, 104);
            this.chkUDPayarlariUDPLogAktif.Name = "chkUDPayarlariUDPLogAktif";
            this.chkUDPayarlariUDPLogAktif.Size = new System.Drawing.Size(94, 17);
            this.chkUDPayarlariUDPLogAktif.TabIndex = 3;
            this.chkUDPayarlariUDPLogAktif.Text = "UDP Log Aktif";
            this.chkUDPayarlariUDPLogAktif.UseVisualStyleBackColor = true;
            // 
            // chkUDPayarlariUDPAktif
            // 
            this.chkUDPayarlariUDPAktif.AutoSize = true;
            this.chkUDPayarlariUDPAktif.Checked = true;
            this.chkUDPayarlariUDPAktif.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUDPayarlariUDPAktif.Location = new System.Drawing.Point(10, 77);
            this.chkUDPayarlariUDPAktif.Name = "chkUDPayarlariUDPAktif";
            this.chkUDPayarlariUDPAktif.Size = new System.Drawing.Size(73, 17);
            this.chkUDPayarlariUDPAktif.TabIndex = 2;
            this.chkUDPayarlariUDPAktif.Text = "UDP Aktif";
            this.chkUDPayarlariUDPAktif.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkUDPayarlariUDPAktif.UseVisualStyleBackColor = true;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 48);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(73, 13);
            this.label21.TabIndex = 1;
            this.label21.Text = "Port Numarası";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(7, 24);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(48, 13);
            this.label20.TabIndex = 0;
            this.label20.Text = "Ip Adresi";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtServerEchoZamanAsimi);
            this.groupBox1.Controls.Add(this.label160);
            this.groupBox1.Controls.Add(this.edtHaberlesmeAyarlariServerIpAdress);
            this.groupBox1.Controls.Add(this.edtHaberlesmeAyarlariPortNumarasi);
            this.groupBox1.Controls.Add(this.edtHaberlesmeIkinciDnsSunucu);
            this.groupBox1.Controls.Add(this.edtHaberlesmeBirinciDnsSunucu);
            this.groupBox1.Controls.Add(this.edtHaberlesmeAyarlariVarsayilanAgGecidi);
            this.groupBox1.Controls.Add(this.edtHaberlesmeAltAgMaskesi);
            this.groupBox1.Controls.Add(this.edtHaberlesmeIpAdresi);
            this.groupBox1.Controls.Add(this.edtHaberlesmeAyarlariProtokol);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.chkHaberlesmeAyarlariDHCPAktif);
            this.groupBox1.Controls.Add(this.chkHaberlesmeAyarlariSadeceServerIleHaberles);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Location = new System.Drawing.Point(9, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 336);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "  TCP Ayarları  ";
            // 
            // txtServerEchoZamanAsimi
            // 
            this.txtServerEchoZamanAsimi.Location = new System.Drawing.Point(153, 243);
            this.txtServerEchoZamanAsimi.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.txtServerEchoZamanAsimi.Name = "txtServerEchoZamanAsimi";
            this.txtServerEchoZamanAsimi.Size = new System.Drawing.Size(76, 20);
            this.txtServerEchoZamanAsimi.TabIndex = 32;
            // 
            // label160
            // 
            this.label160.AutoSize = true;
            this.label160.Location = new System.Drawing.Point(13, 248);
            this.label160.Name = "label160";
            this.label160.Size = new System.Drawing.Size(137, 13);
            this.label160.TabIndex = 31;
            this.label160.Text = "Server Echo Zaman aşımı : ";
            // 
            // edtHaberlesmeAyarlariServerIpAdress
            // 
            this.edtHaberlesmeAyarlariServerIpAdress.Location = new System.Drawing.Point(137, 211);
            this.edtHaberlesmeAyarlariServerIpAdress.Name = "edtHaberlesmeAyarlariServerIpAdress";
            this.edtHaberlesmeAyarlariServerIpAdress.Size = new System.Drawing.Size(100, 20);
            this.edtHaberlesmeAyarlariServerIpAdress.TabIndex = 30;
            // 
            // edtHaberlesmeAyarlariPortNumarasi
            // 
            this.edtHaberlesmeAyarlariPortNumarasi.Location = new System.Drawing.Point(137, 184);
            this.edtHaberlesmeAyarlariPortNumarasi.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.edtHaberlesmeAyarlariPortNumarasi.Name = "edtHaberlesmeAyarlariPortNumarasi";
            this.edtHaberlesmeAyarlariPortNumarasi.Size = new System.Drawing.Size(57, 20);
            this.edtHaberlesmeAyarlariPortNumarasi.TabIndex = 29;
            this.edtHaberlesmeAyarlariPortNumarasi.Value = new decimal(new int[] {
            6565,
            0,
            0,
            0});
            // 
            // edtHaberlesmeIkinciDnsSunucu
            // 
            this.edtHaberlesmeIkinciDnsSunucu.Location = new System.Drawing.Point(137, 158);
            this.edtHaberlesmeIkinciDnsSunucu.Name = "edtHaberlesmeIkinciDnsSunucu";
            this.edtHaberlesmeIkinciDnsSunucu.Size = new System.Drawing.Size(100, 20);
            this.edtHaberlesmeIkinciDnsSunucu.TabIndex = 17;
            // 
            // edtHaberlesmeBirinciDnsSunucu
            // 
            this.edtHaberlesmeBirinciDnsSunucu.Location = new System.Drawing.Point(137, 133);
            this.edtHaberlesmeBirinciDnsSunucu.Name = "edtHaberlesmeBirinciDnsSunucu";
            this.edtHaberlesmeBirinciDnsSunucu.Size = new System.Drawing.Size(100, 20);
            this.edtHaberlesmeBirinciDnsSunucu.TabIndex = 16;
            // 
            // edtHaberlesmeAyarlariVarsayilanAgGecidi
            // 
            this.edtHaberlesmeAyarlariVarsayilanAgGecidi.Location = new System.Drawing.Point(137, 104);
            this.edtHaberlesmeAyarlariVarsayilanAgGecidi.Name = "edtHaberlesmeAyarlariVarsayilanAgGecidi";
            this.edtHaberlesmeAyarlariVarsayilanAgGecidi.Size = new System.Drawing.Size(100, 20);
            this.edtHaberlesmeAyarlariVarsayilanAgGecidi.TabIndex = 15;
            // 
            // edtHaberlesmeAltAgMaskesi
            // 
            this.edtHaberlesmeAltAgMaskesi.Location = new System.Drawing.Point(137, 75);
            this.edtHaberlesmeAltAgMaskesi.Name = "edtHaberlesmeAltAgMaskesi";
            this.edtHaberlesmeAltAgMaskesi.Size = new System.Drawing.Size(100, 20);
            this.edtHaberlesmeAltAgMaskesi.TabIndex = 14;
            // 
            // edtHaberlesmeIpAdresi
            // 
            this.edtHaberlesmeIpAdresi.Location = new System.Drawing.Point(137, 48);
            this.edtHaberlesmeIpAdresi.Name = "edtHaberlesmeIpAdresi";
            this.edtHaberlesmeIpAdresi.Size = new System.Drawing.Size(100, 20);
            this.edtHaberlesmeIpAdresi.TabIndex = 13;
            // 
            // edtHaberlesmeAyarlariProtokol
            // 
            this.edtHaberlesmeAyarlariProtokol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.edtHaberlesmeAyarlariProtokol.FormattingEnabled = true;
            this.edtHaberlesmeAyarlariProtokol.Items.AddRange(new object[] {
            "PR0",
            "PR1",
            "PR2"});
            this.edtHaberlesmeAyarlariProtokol.Location = new System.Drawing.Point(137, 19);
            this.edtHaberlesmeAyarlariProtokol.Name = "edtHaberlesmeAyarlariProtokol";
            this.edtHaberlesmeAyarlariProtokol.Size = new System.Drawing.Size(66, 21);
            this.edtHaberlesmeAyarlariProtokol.TabIndex = 12;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(205, 307);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 11;
            this.button5.Text = "Gönder";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(128, 307);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 10;
            this.button4.Text = "Getir";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // chkHaberlesmeAyarlariDHCPAktif
            // 
            this.chkHaberlesmeAyarlariDHCPAktif.AutoSize = true;
            this.chkHaberlesmeAyarlariDHCPAktif.Checked = true;
            this.chkHaberlesmeAyarlariDHCPAktif.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkHaberlesmeAyarlariDHCPAktif.Location = new System.Drawing.Point(9, 295);
            this.chkHaberlesmeAyarlariDHCPAktif.Name = "chkHaberlesmeAyarlariDHCPAktif";
            this.chkHaberlesmeAyarlariDHCPAktif.Size = new System.Drawing.Size(80, 17);
            this.chkHaberlesmeAyarlariDHCPAktif.TabIndex = 9;
            this.chkHaberlesmeAyarlariDHCPAktif.Text = "DHCP Aktif";
            this.chkHaberlesmeAyarlariDHCPAktif.UseVisualStyleBackColor = true;
            // 
            // chkHaberlesmeAyarlariSadeceServerIleHaberles
            // 
            this.chkHaberlesmeAyarlariSadeceServerIleHaberles.AutoSize = true;
            this.chkHaberlesmeAyarlariSadeceServerIleHaberles.Checked = true;
            this.chkHaberlesmeAyarlariSadeceServerIleHaberles.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkHaberlesmeAyarlariSadeceServerIleHaberles.Location = new System.Drawing.Point(9, 272);
            this.chkHaberlesmeAyarlariSadeceServerIleHaberles.Name = "chkHaberlesmeAyarlariSadeceServerIleHaberles";
            this.chkHaberlesmeAyarlariSadeceServerIleHaberles.Size = new System.Drawing.Size(155, 17);
            this.chkHaberlesmeAyarlariSadeceServerIleHaberles.TabIndex = 8;
            this.chkHaberlesmeAyarlariSadeceServerIleHaberles.Text = "Sadece Server ile Haberleş";
            this.chkHaberlesmeAyarlariSadeceServerIleHaberles.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(14, 218);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(82, 13);
            this.label19.TabIndex = 7;
            this.label19.Text = "Server Ip Adresi";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(14, 192);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(73, 13);
            this.label18.TabIndex = 6;
            this.label18.Text = "Port Numarası";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(14, 165);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(98, 13);
            this.label17.TabIndex = 5;
            this.label17.Text = "İkinci DNS Sunucu";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(14, 139);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(101, 13);
            this.label16.TabIndex = 4;
            this.label16.Text = "Birinci DNS Sunucu";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(14, 111);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(104, 13);
            this.label15.TabIndex = 3;
            this.label15.Text = "Varsayılan Ağ Geçidi";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(14, 85);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "Alt Ağ Maskesi";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(14, 57);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Ip Adresi";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Protokol";
            // 
            // tsMfrKeyTable
            // 
            this.tsMfrKeyTable.Controls.Add(this.groupBox23);
            this.tsMfrKeyTable.Controls.Add(this.button16);
            this.tsMfrKeyTable.Controls.Add(this.button15);
            this.tsMfrKeyTable.Controls.Add(this.button14);
            this.tsMfrKeyTable.Location = new System.Drawing.Point(4, 22);
            this.tsMfrKeyTable.Name = "tsMfrKeyTable";
            this.tsMfrKeyTable.Padding = new System.Windows.Forms.Padding(3);
            this.tsMfrKeyTable.Size = new System.Drawing.Size(1108, 629);
            this.tsMfrKeyTable.TabIndex = 2;
            this.tsMfrKeyTable.Text = "Mifare Şifre Tablosu";
            this.tsMfrKeyTable.UseVisualStyleBackColor = true;
            // 
            // groupBox23
            // 
            this.groupBox23.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox23.Location = new System.Drawing.Point(3, 3);
            this.groupBox23.Name = "groupBox23";
            this.groupBox23.Size = new System.Drawing.Size(647, 623);
            this.groupBox23.TabIndex = 4;
            this.groupBox23.TabStop = false;
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(656, 434);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(174, 46);
            this.button16.TabIndex = 3;
            this.button16.Text = "Factory Key";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(656, 382);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(174, 46);
            this.button15.TabIndex = 2;
            this.button15.Text = "Gönder";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(656, 330);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(174, 46);
            this.button14.TabIndex = 1;
            this.button14.Text = "Getir";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // tsLCDMessages
            // 
            this.tsLCDMessages.Controls.Add(this.tabControl2);
            this.tsLCDMessages.Location = new System.Drawing.Point(4, 22);
            this.tsLCDMessages.Name = "tsLCDMessages";
            this.tsLCDMessages.Padding = new System.Windows.Forms.Padding(3);
            this.tsLCDMessages.Size = new System.Drawing.Size(1108, 629);
            this.tsLCDMessages.TabIndex = 3;
            this.tsLCDMessages.Text = "Ekran Mesajları";
            this.tsLCDMessages.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(3, 3);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1102, 623);
            this.tabControl2.TabIndex = 8;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox25);
            this.tabPage3.Controls.Add(this.groupBox6);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1094, 597);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Online Mesaj";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox25
            // 
            this.groupBox25.Controls.Add(this.label179);
            this.groupBox25.Controls.Add(this.label178);
            this.groupBox25.Controls.Add(this.txtInputBoxMesajGonderKlavyeTipi);
            this.groupBox25.Controls.Add(this.btnInputBoxMesajGonder);
            this.groupBox25.Controls.Add(this.txtInputBoxMesajGonderIsBlink);
            this.groupBox25.Controls.Add(this.label177);
            this.groupBox25.Controls.Add(this.label175);
            this.groupBox25.Controls.Add(this.txtInputBoxMesajGonderBuzzerSure1);
            this.groupBox25.Controls.Add(this.label176);
            this.groupBox25.Controls.Add(this.label171);
            this.groupBox25.Controls.Add(this.label172);
            this.groupBox25.Controls.Add(this.txtInputBoxMesajGonderRoleSure2);
            this.groupBox25.Controls.Add(this.txtInputBoxMesajGonderRoleSure1);
            this.groupBox25.Controls.Add(this.label173);
            this.groupBox25.Controls.Add(this.label174);
            this.groupBox25.Controls.Add(this.label169);
            this.groupBox25.Controls.Add(this.txtInputBoxMesajGonderEkranSure);
            this.groupBox25.Controls.Add(this.label170);
            this.groupBox25.Controls.Add(this.txtInputBoxMesajGonderIkinciSatirZ);
            this.groupBox25.Controls.Add(this.txtInputBoxMesajGonderIkinciSatirX);
            this.groupBox25.Controls.Add(this.txtInputBoxMesajGonderIkinciSatir);
            this.groupBox25.Controls.Add(this.label168);
            this.groupBox25.Controls.Add(this.txtInputBoxMesajGonderBirinciSatirZ);
            this.groupBox25.Controls.Add(this.txtInputBoxMesajGonderBirinciSatirx);
            this.groupBox25.Controls.Add(this.txtInputBoxMesajGonderBirinciSatir);
            this.groupBox25.Controls.Add(this.label167);
            this.groupBox25.Controls.Add(this.label165);
            this.groupBox25.Controls.Add(this.label166);
            this.groupBox25.Controls.Add(this.txtInputBoxMesajGonderBaslik);
            this.groupBox25.Controls.Add(this.label164);
            this.groupBox25.Controls.Add(this.label163);
            this.groupBox25.Controls.Add(this.txtInputBoxMesajGonderUstBaslikTipi);
            this.groupBox25.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox25.Location = new System.Drawing.Point(344, 3);
            this.groupBox25.Name = "groupBox25";
            this.groupBox25.Size = new System.Drawing.Size(747, 591);
            this.groupBox25.TabIndex = 6;
            this.groupBox25.TabStop = false;
            this.groupBox25.Text = "Cihaza Inpu Box Mesajı Gönder (Online)";
            // 
            // label179
            // 
            this.label179.AutoSize = true;
            this.label179.Location = new System.Drawing.Point(165, 256);
            this.label179.Name = "label179";
            this.label179.Size = new System.Drawing.Size(188, 13);
            this.label179.TabIndex = 63;
            this.label179.Text = "0 - Küçük Harf , 1- Büyük Harf , 2-Sayı";
            // 
            // label178
            // 
            this.label178.AutoSize = true;
            this.label178.Location = new System.Drawing.Point(10, 256);
            this.label178.Name = "label178";
            this.label178.Size = new System.Drawing.Size(59, 13);
            this.label178.TabIndex = 62;
            this.label178.Text = "Klavye Tipi";
            // 
            // txtInputBoxMesajGonderKlavyeTipi
            // 
            this.txtInputBoxMesajGonderKlavyeTipi.Location = new System.Drawing.Point(90, 252);
            this.txtInputBoxMesajGonderKlavyeTipi.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.txtInputBoxMesajGonderKlavyeTipi.Name = "txtInputBoxMesajGonderKlavyeTipi";
            this.txtInputBoxMesajGonderKlavyeTipi.Size = new System.Drawing.Size(65, 20);
            this.txtInputBoxMesajGonderKlavyeTipi.TabIndex = 61;
            this.txtInputBoxMesajGonderKlavyeTipi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnInputBoxMesajGonder
            // 
            this.btnInputBoxMesajGonder.Location = new System.Drawing.Point(9, 425);
            this.btnInputBoxMesajGonder.Name = "btnInputBoxMesajGonder";
            this.btnInputBoxMesajGonder.Size = new System.Drawing.Size(112, 47);
            this.btnInputBoxMesajGonder.TabIndex = 60;
            this.btnInputBoxMesajGonder.Text = "Gönder";
            this.btnInputBoxMesajGonder.UseVisualStyleBackColor = true;
            this.btnInputBoxMesajGonder.Click += new System.EventHandler(this.btnInputBoxMesajGonder_Click);
            // 
            // txtInputBoxMesajGonderIsBlink
            // 
            this.txtInputBoxMesajGonderIsBlink.AutoSize = true;
            this.txtInputBoxMesajGonderIsBlink.Location = new System.Drawing.Point(90, 230);
            this.txtInputBoxMesajGonderIsBlink.Name = "txtInputBoxMesajGonderIsBlink";
            this.txtInputBoxMesajGonderIsBlink.Size = new System.Drawing.Size(15, 14);
            this.txtInputBoxMesajGonderIsBlink.TabIndex = 59;
            this.txtInputBoxMesajGonderIsBlink.UseVisualStyleBackColor = true;
            // 
            // label177
            // 
            this.label177.AutoSize = true;
            this.label177.Location = new System.Drawing.Point(9, 230);
            this.label177.Name = "label177";
            this.label177.Size = new System.Drawing.Size(30, 13);
            this.label177.TabIndex = 58;
            this.label177.Text = "Blink";
            // 
            // label175
            // 
            this.label175.AutoSize = true;
            this.label175.Location = new System.Drawing.Point(162, 207);
            this.label175.Name = "label175";
            this.label175.Size = new System.Drawing.Size(20, 13);
            this.label175.TabIndex = 57;
            this.label175.Text = "ms";
            // 
            // txtInputBoxMesajGonderBuzzerSure1
            // 
            this.txtInputBoxMesajGonderBuzzerSure1.Location = new System.Drawing.Point(90, 204);
            this.txtInputBoxMesajGonderBuzzerSure1.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.txtInputBoxMesajGonderBuzzerSure1.Name = "txtInputBoxMesajGonderBuzzerSure1";
            this.txtInputBoxMesajGonderBuzzerSure1.Size = new System.Drawing.Size(62, 20);
            this.txtInputBoxMesajGonderBuzzerSure1.TabIndex = 56;
            this.txtInputBoxMesajGonderBuzzerSure1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label176
            // 
            this.label176.AutoSize = true;
            this.label176.Location = new System.Drawing.Point(9, 207);
            this.label176.Name = "label176";
            this.label176.Size = new System.Drawing.Size(71, 13);
            this.label176.TabIndex = 55;
            this.label176.Text = "Buzzer Süresi";
            // 
            // label171
            // 
            this.label171.AutoSize = true;
            this.label171.Location = new System.Drawing.Point(162, 182);
            this.label171.Name = "label171";
            this.label171.Size = new System.Drawing.Size(20, 13);
            this.label171.TabIndex = 54;
            this.label171.Text = "ms";
            // 
            // label172
            // 
            this.label172.AutoSize = true;
            this.label172.Location = new System.Drawing.Point(162, 155);
            this.label172.Name = "label172";
            this.label172.Size = new System.Drawing.Size(20, 13);
            this.label172.TabIndex = 53;
            this.label172.Text = "ms";
            // 
            // txtInputBoxMesajGonderRoleSure2
            // 
            this.txtInputBoxMesajGonderRoleSure2.Location = new System.Drawing.Point(90, 178);
            this.txtInputBoxMesajGonderRoleSure2.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.txtInputBoxMesajGonderRoleSure2.Name = "txtInputBoxMesajGonderRoleSure2";
            this.txtInputBoxMesajGonderRoleSure2.Size = new System.Drawing.Size(62, 20);
            this.txtInputBoxMesajGonderRoleSure2.TabIndex = 52;
            // 
            // txtInputBoxMesajGonderRoleSure1
            // 
            this.txtInputBoxMesajGonderRoleSure1.Location = new System.Drawing.Point(90, 152);
            this.txtInputBoxMesajGonderRoleSure1.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.txtInputBoxMesajGonderRoleSure1.Name = "txtInputBoxMesajGonderRoleSure1";
            this.txtInputBoxMesajGonderRoleSure1.Size = new System.Drawing.Size(62, 20);
            this.txtInputBoxMesajGonderRoleSure1.TabIndex = 51;
            // 
            // label173
            // 
            this.label173.AutoSize = true;
            this.label173.Location = new System.Drawing.Point(8, 181);
            this.label173.Name = "label173";
            this.label173.Size = new System.Drawing.Size(70, 13);
            this.label173.TabIndex = 50;
            this.label173.Text = "Röle Süresi 2";
            // 
            // label174
            // 
            this.label174.AutoSize = true;
            this.label174.Location = new System.Drawing.Point(8, 156);
            this.label174.Name = "label174";
            this.label174.Size = new System.Drawing.Size(70, 13);
            this.label174.TabIndex = 49;
            this.label174.Text = "Röle Süresi 1";
            // 
            // label169
            // 
            this.label169.AutoSize = true;
            this.label169.Location = new System.Drawing.Point(159, 132);
            this.label169.Name = "label169";
            this.label169.Size = new System.Drawing.Size(45, 13);
            this.label169.TabIndex = 48;
            this.label169.Text = "*100 ms";
            // 
            // txtInputBoxMesajGonderEkranSure
            // 
            this.txtInputBoxMesajGonderEkranSure.Location = new System.Drawing.Point(90, 126);
            this.txtInputBoxMesajGonderEkranSure.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.txtInputBoxMesajGonderEkranSure.Name = "txtInputBoxMesajGonderEkranSure";
            this.txtInputBoxMesajGonderEkranSure.Size = new System.Drawing.Size(62, 20);
            this.txtInputBoxMesajGonderEkranSure.TabIndex = 47;
            this.txtInputBoxMesajGonderEkranSure.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // label170
            // 
            this.label170.AutoSize = true;
            this.label170.Location = new System.Drawing.Point(9, 133);
            this.label170.Name = "label170";
            this.label170.Size = new System.Drawing.Size(60, 13);
            this.label170.TabIndex = 46;
            this.label170.Text = "Ekran Süre";
            // 
            // txtInputBoxMesajGonderIkinciSatirZ
            // 
            this.txtInputBoxMesajGonderIkinciSatirZ.Location = new System.Drawing.Point(288, 99);
            this.txtInputBoxMesajGonderIkinciSatirZ.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.txtInputBoxMesajGonderIkinciSatirZ.Name = "txtInputBoxMesajGonderIkinciSatirZ";
            this.txtInputBoxMesajGonderIkinciSatirZ.Size = new System.Drawing.Size(46, 20);
            this.txtInputBoxMesajGonderIkinciSatirZ.TabIndex = 44;
            this.txtInputBoxMesajGonderIkinciSatirZ.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // txtInputBoxMesajGonderIkinciSatirX
            // 
            this.txtInputBoxMesajGonderIkinciSatirX.Location = new System.Drawing.Point(223, 100);
            this.txtInputBoxMesajGonderIkinciSatirX.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.txtInputBoxMesajGonderIkinciSatirX.Name = "txtInputBoxMesajGonderIkinciSatirX";
            this.txtInputBoxMesajGonderIkinciSatirX.Size = new System.Drawing.Size(46, 20);
            this.txtInputBoxMesajGonderIkinciSatirX.TabIndex = 43;
            this.txtInputBoxMesajGonderIkinciSatirX.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // txtInputBoxMesajGonderIkinciSatir
            // 
            this.txtInputBoxMesajGonderIkinciSatir.Location = new System.Drawing.Point(90, 100);
            this.txtInputBoxMesajGonderIkinciSatir.Name = "txtInputBoxMesajGonderIkinciSatir";
            this.txtInputBoxMesajGonderIkinciSatir.Size = new System.Drawing.Size(121, 20);
            this.txtInputBoxMesajGonderIkinciSatir.TabIndex = 42;
            // 
            // label168
            // 
            this.label168.AutoSize = true;
            this.label168.Location = new System.Drawing.Point(10, 107);
            this.label168.Name = "label168";
            this.label168.Size = new System.Drawing.Size(37, 13);
            this.label168.TabIndex = 41;
            this.label168.Text = "2.Satır";
            // 
            // txtInputBoxMesajGonderBirinciSatirZ
            // 
            this.txtInputBoxMesajGonderBirinciSatirZ.Location = new System.Drawing.Point(288, 73);
            this.txtInputBoxMesajGonderBirinciSatirZ.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.txtInputBoxMesajGonderBirinciSatirZ.Name = "txtInputBoxMesajGonderBirinciSatirZ";
            this.txtInputBoxMesajGonderBirinciSatirZ.Size = new System.Drawing.Size(46, 20);
            this.txtInputBoxMesajGonderBirinciSatirZ.TabIndex = 40;
            this.txtInputBoxMesajGonderBirinciSatirZ.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // txtInputBoxMesajGonderBirinciSatirx
            // 
            this.txtInputBoxMesajGonderBirinciSatirx.Location = new System.Drawing.Point(223, 74);
            this.txtInputBoxMesajGonderBirinciSatirx.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.txtInputBoxMesajGonderBirinciSatirx.Name = "txtInputBoxMesajGonderBirinciSatirx";
            this.txtInputBoxMesajGonderBirinciSatirx.Size = new System.Drawing.Size(46, 20);
            this.txtInputBoxMesajGonderBirinciSatirx.TabIndex = 39;
            this.txtInputBoxMesajGonderBirinciSatirx.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // txtInputBoxMesajGonderBirinciSatir
            // 
            this.txtInputBoxMesajGonderBirinciSatir.Location = new System.Drawing.Point(90, 74);
            this.txtInputBoxMesajGonderBirinciSatir.Name = "txtInputBoxMesajGonderBirinciSatir";
            this.txtInputBoxMesajGonderBirinciSatir.Size = new System.Drawing.Size(121, 20);
            this.txtInputBoxMesajGonderBirinciSatir.TabIndex = 38;
            // 
            // label167
            // 
            this.label167.AutoSize = true;
            this.label167.Location = new System.Drawing.Point(10, 81);
            this.label167.Name = "label167";
            this.label167.Size = new System.Drawing.Size(37, 13);
            this.label167.TabIndex = 37;
            this.label167.Text = "1.Satır";
            // 
            // label165
            // 
            this.label165.AutoSize = true;
            this.label165.Location = new System.Drawing.Point(295, 55);
            this.label165.Name = "label165";
            this.label165.Size = new System.Drawing.Size(14, 13);
            this.label165.TabIndex = 23;
            this.label165.Text = "Z";
            // 
            // label166
            // 
            this.label166.AutoSize = true;
            this.label166.Location = new System.Drawing.Point(237, 56);
            this.label166.Name = "label166";
            this.label166.Size = new System.Drawing.Size(14, 13);
            this.label166.TabIndex = 22;
            this.label166.Text = "X";
            // 
            // txtInputBoxMesajGonderBaslik
            // 
            this.txtInputBoxMesajGonderBaslik.Location = new System.Drawing.Point(90, 49);
            this.txtInputBoxMesajGonderBaslik.Name = "txtInputBoxMesajGonderBaslik";
            this.txtInputBoxMesajGonderBaslik.Size = new System.Drawing.Size(121, 20);
            this.txtInputBoxMesajGonderBaslik.TabIndex = 21;
            // 
            // label164
            // 
            this.label164.AutoSize = true;
            this.label164.Location = new System.Drawing.Point(10, 55);
            this.label164.Name = "label164";
            this.label164.Size = new System.Drawing.Size(35, 13);
            this.label164.TabIndex = 20;
            this.label164.Text = "Başlık";
            // 
            // label163
            // 
            this.label163.AutoSize = true;
            this.label163.Location = new System.Drawing.Point(10, 29);
            this.label163.Name = "label163";
            this.label163.Size = new System.Drawing.Size(74, 13);
            this.label163.TabIndex = 3;
            this.label163.Text = "Üst Başlık Tipi";
            // 
            // txtInputBoxMesajGonderUstBaslikTipi
            // 
            this.txtInputBoxMesajGonderUstBaslikTipi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtInputBoxMesajGonderUstBaslikTipi.FormattingEnabled = true;
            this.txtInputBoxMesajGonderUstBaslikTipi.Items.AddRange(new object[] {
            "Yok",
            "Üst Bilgi",
            "Başlık"});
            this.txtInputBoxMesajGonderUstBaslikTipi.Location = new System.Drawing.Point(90, 24);
            this.txtInputBoxMesajGonderUstBaslikTipi.Name = "txtInputBoxMesajGonderUstBaslikTipi";
            this.txtInputBoxMesajGonderUstBaslikTipi.Size = new System.Drawing.Size(121, 21);
            this.txtInputBoxMesajGonderUstBaslikTipi.TabIndex = 2;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label83);
            this.groupBox6.Controls.Add(this.label82);
            this.groupBox6.Controls.Add(this.label81);
            this.groupBox6.Controls.Add(this.label80);
            this.groupBox6.Controls.Add(this.ekranMesajiOnlieSatir5y);
            this.groupBox6.Controls.Add(this.ekranMesajiOnlieSatir5x);
            this.groupBox6.Controls.Add(this.ekranMesajiOnlieSatir4y);
            this.groupBox6.Controls.Add(this.ekranMesajiOnlieSatir4x);
            this.groupBox6.Controls.Add(this.ekranMesajiOnlieSatir3y);
            this.groupBox6.Controls.Add(this.ekranMesajiOnlieSatir3x);
            this.groupBox6.Controls.Add(this.ekranMesajiOnlieSatir2y);
            this.groupBox6.Controls.Add(this.ekranMesajiOnlieSatir2x);
            this.groupBox6.Controls.Add(this.ekranMesajiOnlieSatir1y);
            this.groupBox6.Controls.Add(this.ekranMesajiOnlieSatir1x);
            this.groupBox6.Controls.Add(this.btnHaberlesmeAyariGonder);
            this.groupBox6.Controls.Add(this.chkedtEkranMesajlariBlink);
            this.groupBox6.Controls.Add(this.edtEkranMesajlariBuzzerSuresi);
            this.groupBox6.Controls.Add(this.edtEkranMesajlariRoleSuresi2);
            this.groupBox6.Controls.Add(this.edtEkranMesajlariRoleSuresi1);
            this.groupBox6.Controls.Add(this.edtEkranMesajlariEkranSure);
            this.groupBox6.Controls.Add(this.edtEkranMesajlariFontTipi);
            this.groupBox6.Controls.Add(this.edtEkranMesajiSatirSayisi);
            this.groupBox6.Controls.Add(this.edtEkranMesajlariAltBaslik);
            this.groupBox6.Controls.Add(this.edtEkranMesajlariAltBaslikTipi);
            this.groupBox6.Controls.Add(this.ekranMesajiOnlieSatir5);
            this.groupBox6.Controls.Add(this.ekranMesajiOnlieSatir4);
            this.groupBox6.Controls.Add(this.ekranMesajiOnlieSatir3);
            this.groupBox6.Controls.Add(this.ekranMesajiOnlieSatir2);
            this.groupBox6.Controls.Add(this.ekranMesajiOnlieSatir1);
            this.groupBox6.Controls.Add(this.edtEkranMesajlariUstBaslik);
            this.groupBox6.Controls.Add(this.label79);
            this.groupBox6.Controls.Add(this.label78);
            this.groupBox6.Controls.Add(this.label77);
            this.groupBox6.Controls.Add(this.label76);
            this.groupBox6.Controls.Add(this.label75);
            this.groupBox6.Controls.Add(this.label74);
            this.groupBox6.Controls.Add(this.label73);
            this.groupBox6.Controls.Add(this.label72);
            this.groupBox6.Controls.Add(this.label71);
            this.groupBox6.Controls.Add(this.label70);
            this.groupBox6.Controls.Add(this.label69);
            this.groupBox6.Controls.Add(this.label68);
            this.groupBox6.Controls.Add(this.label66);
            this.groupBox6.Controls.Add(this.label67);
            this.groupBox6.Controls.Add(this.label65);
            this.groupBox6.Controls.Add(this.label64);
            this.groupBox6.Controls.Add(this.label63);
            this.groupBox6.Controls.Add(this.label62);
            this.groupBox6.Controls.Add(this.edtEkranMesajlariUstBaslikTipi);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox6.Location = new System.Drawing.Point(3, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(341, 591);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Cihaza Mesaj Gönder (Online)";
            // 
            // label83
            // 
            this.label83.AutoSize = true;
            this.label83.Location = new System.Drawing.Point(158, 373);
            this.label83.Name = "label83";
            this.label83.Size = new System.Drawing.Size(20, 13);
            this.label83.TabIndex = 48;
            this.label83.Text = "ms";
            // 
            // label82
            // 
            this.label82.AutoSize = true;
            this.label82.Location = new System.Drawing.Point(158, 349);
            this.label82.Name = "label82";
            this.label82.Size = new System.Drawing.Size(20, 13);
            this.label82.TabIndex = 47;
            this.label82.Text = "ms";
            // 
            // label81
            // 
            this.label81.AutoSize = true;
            this.label81.Location = new System.Drawing.Point(158, 321);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(20, 13);
            this.label81.TabIndex = 46;
            this.label81.Text = "ms";
            // 
            // label80
            // 
            this.label80.AutoSize = true;
            this.label80.Location = new System.Drawing.Point(155, 298);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(45, 13);
            this.label80.TabIndex = 45;
            this.label80.Text = "*100 ms";
            // 
            // ekranMesajiOnlieSatir5y
            // 
            this.ekranMesajiOnlieSatir5y.Location = new System.Drawing.Point(284, 168);
            this.ekranMesajiOnlieSatir5y.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.ekranMesajiOnlieSatir5y.Name = "ekranMesajiOnlieSatir5y";
            this.ekranMesajiOnlieSatir5y.Size = new System.Drawing.Size(46, 20);
            this.ekranMesajiOnlieSatir5y.TabIndex = 44;
            this.ekranMesajiOnlieSatir5y.Value = new decimal(new int[] {
            75,
            0,
            0,
            0});
            // 
            // ekranMesajiOnlieSatir5x
            // 
            this.ekranMesajiOnlieSatir5x.Location = new System.Drawing.Point(219, 169);
            this.ekranMesajiOnlieSatir5x.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.ekranMesajiOnlieSatir5x.Name = "ekranMesajiOnlieSatir5x";
            this.ekranMesajiOnlieSatir5x.Size = new System.Drawing.Size(46, 20);
            this.ekranMesajiOnlieSatir5x.TabIndex = 43;
            this.ekranMesajiOnlieSatir5x.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // ekranMesajiOnlieSatir4y
            // 
            this.ekranMesajiOnlieSatir4y.Location = new System.Drawing.Point(284, 143);
            this.ekranMesajiOnlieSatir4y.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.ekranMesajiOnlieSatir4y.Name = "ekranMesajiOnlieSatir4y";
            this.ekranMesajiOnlieSatir4y.Size = new System.Drawing.Size(46, 20);
            this.ekranMesajiOnlieSatir4y.TabIndex = 42;
            this.ekranMesajiOnlieSatir4y.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // ekranMesajiOnlieSatir4x
            // 
            this.ekranMesajiOnlieSatir4x.Location = new System.Drawing.Point(219, 144);
            this.ekranMesajiOnlieSatir4x.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.ekranMesajiOnlieSatir4x.Name = "ekranMesajiOnlieSatir4x";
            this.ekranMesajiOnlieSatir4x.Size = new System.Drawing.Size(46, 20);
            this.ekranMesajiOnlieSatir4x.TabIndex = 41;
            this.ekranMesajiOnlieSatir4x.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // ekranMesajiOnlieSatir3y
            // 
            this.ekranMesajiOnlieSatir3y.Location = new System.Drawing.Point(284, 118);
            this.ekranMesajiOnlieSatir3y.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.ekranMesajiOnlieSatir3y.Name = "ekranMesajiOnlieSatir3y";
            this.ekranMesajiOnlieSatir3y.Size = new System.Drawing.Size(46, 20);
            this.ekranMesajiOnlieSatir3y.TabIndex = 40;
            this.ekranMesajiOnlieSatir3y.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            // 
            // ekranMesajiOnlieSatir3x
            // 
            this.ekranMesajiOnlieSatir3x.Location = new System.Drawing.Point(219, 119);
            this.ekranMesajiOnlieSatir3x.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.ekranMesajiOnlieSatir3x.Name = "ekranMesajiOnlieSatir3x";
            this.ekranMesajiOnlieSatir3x.Size = new System.Drawing.Size(46, 20);
            this.ekranMesajiOnlieSatir3x.TabIndex = 39;
            this.ekranMesajiOnlieSatir3x.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // ekranMesajiOnlieSatir2y
            // 
            this.ekranMesajiOnlieSatir2y.Location = new System.Drawing.Point(284, 94);
            this.ekranMesajiOnlieSatir2y.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.ekranMesajiOnlieSatir2y.Name = "ekranMesajiOnlieSatir2y";
            this.ekranMesajiOnlieSatir2y.Size = new System.Drawing.Size(46, 20);
            this.ekranMesajiOnlieSatir2y.TabIndex = 38;
            this.ekranMesajiOnlieSatir2y.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // ekranMesajiOnlieSatir2x
            // 
            this.ekranMesajiOnlieSatir2x.Location = new System.Drawing.Point(219, 95);
            this.ekranMesajiOnlieSatir2x.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.ekranMesajiOnlieSatir2x.Name = "ekranMesajiOnlieSatir2x";
            this.ekranMesajiOnlieSatir2x.Size = new System.Drawing.Size(46, 20);
            this.ekranMesajiOnlieSatir2x.TabIndex = 37;
            this.ekranMesajiOnlieSatir2x.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // ekranMesajiOnlieSatir1y
            // 
            this.ekranMesajiOnlieSatir1y.Location = new System.Drawing.Point(284, 69);
            this.ekranMesajiOnlieSatir1y.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.ekranMesajiOnlieSatir1y.Name = "ekranMesajiOnlieSatir1y";
            this.ekranMesajiOnlieSatir1y.Size = new System.Drawing.Size(46, 20);
            this.ekranMesajiOnlieSatir1y.TabIndex = 36;
            this.ekranMesajiOnlieSatir1y.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // ekranMesajiOnlieSatir1x
            // 
            this.ekranMesajiOnlieSatir1x.Location = new System.Drawing.Point(219, 70);
            this.ekranMesajiOnlieSatir1x.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.ekranMesajiOnlieSatir1x.Name = "ekranMesajiOnlieSatir1x";
            this.ekranMesajiOnlieSatir1x.Size = new System.Drawing.Size(46, 20);
            this.ekranMesajiOnlieSatir1x.TabIndex = 35;
            this.ekranMesajiOnlieSatir1x.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // btnHaberlesmeAyariGonder
            // 
            this.btnHaberlesmeAyariGonder.Location = new System.Drawing.Point(224, 425);
            this.btnHaberlesmeAyariGonder.Name = "btnHaberlesmeAyariGonder";
            this.btnHaberlesmeAyariGonder.Size = new System.Drawing.Size(111, 47);
            this.btnHaberlesmeAyariGonder.TabIndex = 34;
            this.btnHaberlesmeAyariGonder.Text = "Gönder";
            this.btnHaberlesmeAyariGonder.UseVisualStyleBackColor = true;
            this.btnHaberlesmeAyariGonder.Click += new System.EventHandler(this.btnHaberlesmeAyariGonder_Click_1);
            // 
            // chkedtEkranMesajlariBlink
            // 
            this.chkedtEkranMesajlariBlink.AutoSize = true;
            this.chkedtEkranMesajlariBlink.Location = new System.Drawing.Point(84, 400);
            this.chkedtEkranMesajlariBlink.Name = "chkedtEkranMesajlariBlink";
            this.chkedtEkranMesajlariBlink.Size = new System.Drawing.Size(15, 14);
            this.chkedtEkranMesajlariBlink.TabIndex = 33;
            this.chkedtEkranMesajlariBlink.UseVisualStyleBackColor = true;
            // 
            // edtEkranMesajlariBuzzerSuresi
            // 
            this.edtEkranMesajlariBuzzerSuresi.Location = new System.Drawing.Point(85, 370);
            this.edtEkranMesajlariBuzzerSuresi.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.edtEkranMesajlariBuzzerSuresi.Name = "edtEkranMesajlariBuzzerSuresi";
            this.edtEkranMesajlariBuzzerSuresi.Size = new System.Drawing.Size(62, 20);
            this.edtEkranMesajlariBuzzerSuresi.TabIndex = 32;
            this.edtEkranMesajlariBuzzerSuresi.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // edtEkranMesajlariRoleSuresi2
            // 
            this.edtEkranMesajlariRoleSuresi2.Location = new System.Drawing.Point(86, 344);
            this.edtEkranMesajlariRoleSuresi2.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.edtEkranMesajlariRoleSuresi2.Name = "edtEkranMesajlariRoleSuresi2";
            this.edtEkranMesajlariRoleSuresi2.Size = new System.Drawing.Size(62, 20);
            this.edtEkranMesajlariRoleSuresi2.TabIndex = 31;
            this.edtEkranMesajlariRoleSuresi2.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // edtEkranMesajlariRoleSuresi1
            // 
            this.edtEkranMesajlariRoleSuresi1.Location = new System.Drawing.Point(86, 318);
            this.edtEkranMesajlariRoleSuresi1.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.edtEkranMesajlariRoleSuresi1.Name = "edtEkranMesajlariRoleSuresi1";
            this.edtEkranMesajlariRoleSuresi1.Size = new System.Drawing.Size(62, 20);
            this.edtEkranMesajlariRoleSuresi1.TabIndex = 30;
            this.edtEkranMesajlariRoleSuresi1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // edtEkranMesajlariEkranSure
            // 
            this.edtEkranMesajlariEkranSure.Location = new System.Drawing.Point(86, 292);
            this.edtEkranMesajlariEkranSure.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.edtEkranMesajlariEkranSure.Name = "edtEkranMesajlariEkranSure";
            this.edtEkranMesajlariEkranSure.Size = new System.Drawing.Size(62, 20);
            this.edtEkranMesajlariEkranSure.TabIndex = 29;
            this.edtEkranMesajlariEkranSure.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // edtEkranMesajlariFontTipi
            // 
            this.edtEkranMesajlariFontTipi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.edtEkranMesajlariFontTipi.FormattingEnabled = true;
            this.edtEkranMesajlariFontTipi.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
            this.edtEkranMesajlariFontTipi.Location = new System.Drawing.Point(86, 265);
            this.edtEkranMesajlariFontTipi.Name = "edtEkranMesajlariFontTipi";
            this.edtEkranMesajlariFontTipi.Size = new System.Drawing.Size(121, 21);
            this.edtEkranMesajlariFontTipi.TabIndex = 28;
            // 
            // edtEkranMesajiSatirSayisi
            // 
            this.edtEkranMesajiSatirSayisi.Location = new System.Drawing.Point(86, 241);
            this.edtEkranMesajiSatirSayisi.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.edtEkranMesajiSatirSayisi.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.edtEkranMesajiSatirSayisi.Name = "edtEkranMesajiSatirSayisi";
            this.edtEkranMesajiSatirSayisi.Size = new System.Drawing.Size(62, 20);
            this.edtEkranMesajiSatirSayisi.TabIndex = 27;
            this.edtEkranMesajiSatirSayisi.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // edtEkranMesajlariAltBaslik
            // 
            this.edtEkranMesajlariAltBaslik.Location = new System.Drawing.Point(86, 219);
            this.edtEkranMesajlariAltBaslik.Name = "edtEkranMesajlariAltBaslik";
            this.edtEkranMesajlariAltBaslik.Size = new System.Drawing.Size(121, 20);
            this.edtEkranMesajlariAltBaslik.TabIndex = 26;
            // 
            // edtEkranMesajlariAltBaslikTipi
            // 
            this.edtEkranMesajlariAltBaslikTipi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.edtEkranMesajlariAltBaslikTipi.FormattingEnabled = true;
            this.edtEkranMesajlariAltBaslikTipi.Items.AddRange(new object[] {
            "Yok",
            "Alt Bilgi",
            "Başlık"});
            this.edtEkranMesajlariAltBaslikTipi.Location = new System.Drawing.Point(86, 195);
            this.edtEkranMesajlariAltBaslikTipi.Name = "edtEkranMesajlariAltBaslikTipi";
            this.edtEkranMesajlariAltBaslikTipi.Size = new System.Drawing.Size(121, 21);
            this.edtEkranMesajlariAltBaslikTipi.TabIndex = 25;
            this.edtEkranMesajlariAltBaslikTipi.SelectedIndexChanged += new System.EventHandler(this.edtEkranMesajlariAltBaslikTipi_SelectedIndexChanged);
            // 
            // ekranMesajiOnlieSatir5
            // 
            this.ekranMesajiOnlieSatir5.Location = new System.Drawing.Point(86, 169);
            this.ekranMesajiOnlieSatir5.Name = "ekranMesajiOnlieSatir5";
            this.ekranMesajiOnlieSatir5.Size = new System.Drawing.Size(121, 20);
            this.ekranMesajiOnlieSatir5.TabIndex = 24;
            // 
            // ekranMesajiOnlieSatir4
            // 
            this.ekranMesajiOnlieSatir4.Location = new System.Drawing.Point(86, 144);
            this.ekranMesajiOnlieSatir4.Name = "ekranMesajiOnlieSatir4";
            this.ekranMesajiOnlieSatir4.Size = new System.Drawing.Size(121, 20);
            this.ekranMesajiOnlieSatir4.TabIndex = 23;
            // 
            // ekranMesajiOnlieSatir3
            // 
            this.ekranMesajiOnlieSatir3.Location = new System.Drawing.Point(86, 119);
            this.ekranMesajiOnlieSatir3.Name = "ekranMesajiOnlieSatir3";
            this.ekranMesajiOnlieSatir3.Size = new System.Drawing.Size(121, 20);
            this.ekranMesajiOnlieSatir3.TabIndex = 22;
            // 
            // ekranMesajiOnlieSatir2
            // 
            this.ekranMesajiOnlieSatir2.Location = new System.Drawing.Point(86, 95);
            this.ekranMesajiOnlieSatir2.Name = "ekranMesajiOnlieSatir2";
            this.ekranMesajiOnlieSatir2.Size = new System.Drawing.Size(121, 20);
            this.ekranMesajiOnlieSatir2.TabIndex = 21;
            // 
            // ekranMesajiOnlieSatir1
            // 
            this.ekranMesajiOnlieSatir1.Location = new System.Drawing.Point(86, 70);
            this.ekranMesajiOnlieSatir1.Name = "ekranMesajiOnlieSatir1";
            this.ekranMesajiOnlieSatir1.Size = new System.Drawing.Size(121, 20);
            this.ekranMesajiOnlieSatir1.TabIndex = 20;
            // 
            // edtEkranMesajlariUstBaslik
            // 
            this.edtEkranMesajlariUstBaslik.Location = new System.Drawing.Point(86, 46);
            this.edtEkranMesajlariUstBaslik.Name = "edtEkranMesajlariUstBaslik";
            this.edtEkranMesajlariUstBaslik.Size = new System.Drawing.Size(121, 20);
            this.edtEkranMesajlariUstBaslik.TabIndex = 19;
            // 
            // label79
            // 
            this.label79.AutoSize = true;
            this.label79.Location = new System.Drawing.Point(293, 52);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(14, 13);
            this.label79.TabIndex = 18;
            this.label79.Text = "Z";
            // 
            // label78
            // 
            this.label78.AutoSize = true;
            this.label78.Location = new System.Drawing.Point(235, 53);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(14, 13);
            this.label78.TabIndex = 17;
            this.label78.Text = "X";
            // 
            // label77
            // 
            this.label77.AutoSize = true;
            this.label77.Location = new System.Drawing.Point(3, 404);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(30, 13);
            this.label77.TabIndex = 16;
            this.label77.Text = "Blink";
            // 
            // label76
            // 
            this.label76.AutoSize = true;
            this.label76.Location = new System.Drawing.Point(4, 373);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(71, 13);
            this.label76.TabIndex = 15;
            this.label76.Text = "Buzzer Süresi";
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.label75.Location = new System.Drawing.Point(4, 347);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(70, 13);
            this.label75.TabIndex = 14;
            this.label75.Text = "Röle Süresi 2";
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.label74.Location = new System.Drawing.Point(4, 322);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(70, 13);
            this.label74.TabIndex = 13;
            this.label74.Text = "Röle Süresi 1";
            // 
            // label73
            // 
            this.label73.AutoSize = true;
            this.label73.Location = new System.Drawing.Point(5, 299);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(60, 13);
            this.label73.TabIndex = 12;
            this.label73.Text = "Ekran Süre";
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.Location = new System.Drawing.Point(5, 273);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(48, 13);
            this.label72.TabIndex = 11;
            this.label72.Text = "Font Tipi";
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.Location = new System.Drawing.Point(5, 248);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(58, 13);
            this.label71.TabIndex = 10;
            this.label71.Text = "Satır Sayısı";
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.Location = new System.Drawing.Point(6, 222);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(50, 13);
            this.label70.TabIndex = 9;
            this.label70.Text = "Alt Başlık";
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.Location = new System.Drawing.Point(6, 199);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(70, 13);
            this.label69.TabIndex = 8;
            this.label69.Text = "Alt Başlık Tipi";
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Location = new System.Drawing.Point(6, 172);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(37, 13);
            this.label68.TabIndex = 7;
            this.label68.Text = "5.Satır";
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Location = new System.Drawing.Point(6, 148);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(37, 13);
            this.label66.TabIndex = 6;
            this.label66.Text = "4.Satır";
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.Location = new System.Drawing.Point(6, 125);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(37, 13);
            this.label67.TabIndex = 5;
            this.label67.Text = "3.Satır";
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Location = new System.Drawing.Point(6, 100);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(37, 13);
            this.label65.TabIndex = 4;
            this.label65.Text = "2.Satır";
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Location = new System.Drawing.Point(6, 77);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(37, 13);
            this.label64.TabIndex = 3;
            this.label64.Text = "1.Satır";
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Location = new System.Drawing.Point(6, 52);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(35, 13);
            this.label63.TabIndex = 2;
            this.label63.Text = "Başlık";
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Location = new System.Drawing.Point(6, 27);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(74, 13);
            this.label62.TabIndex = 1;
            this.label62.Text = "Üst Başlık Tipi";
            // 
            // edtEkranMesajlariUstBaslikTipi
            // 
            this.edtEkranMesajlariUstBaslikTipi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.edtEkranMesajlariUstBaslikTipi.FormattingEnabled = true;
            this.edtEkranMesajlariUstBaslikTipi.Items.AddRange(new object[] {
            "Yok",
            "Üst Bilgi",
            "Başlık"});
            this.edtEkranMesajlariUstBaslikTipi.Location = new System.Drawing.Point(86, 22);
            this.edtEkranMesajlariUstBaslikTipi.Name = "edtEkranMesajlariUstBaslikTipi";
            this.edtEkranMesajlariUstBaslikTipi.Size = new System.Drawing.Size(121, 21);
            this.edtEkranMesajlariUstBaslikTipi.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.button3);
            this.tabPage4.Controls.Add(this.groupBox7);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1094, 597);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Offline Mesaj";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(563, 440);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(214, 35);
            this.button3.TabIndex = 8;
            this.button3.Text = "Offline Mesajlar Fabrika Ayarına dön";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label149);
            this.groupBox7.Controls.Add(this.edtCihazMesajTipiOffline);
            this.groupBox7.Controls.Add(this.label84);
            this.groupBox7.Controls.Add(this.label85);
            this.groupBox7.Controls.Add(this.label86);
            this.groupBox7.Controls.Add(this.label87);
            this.groupBox7.Controls.Add(this.ekranMesajiOfflineSatir5z);
            this.groupBox7.Controls.Add(this.ekranMesajiOfflineSatir5x);
            this.groupBox7.Controls.Add(this.ekranMesajiOfflineSatir4z);
            this.groupBox7.Controls.Add(this.ekranMesajiOfflineSatir4x);
            this.groupBox7.Controls.Add(this.ekranMesajiOfflineSatir3z);
            this.groupBox7.Controls.Add(this.ekranMesajiOfflineSatir3x);
            this.groupBox7.Controls.Add(this.ekranMesajiOfflineSatir2z);
            this.groupBox7.Controls.Add(this.ekranMesajiOfflineSatir2x);
            this.groupBox7.Controls.Add(this.ekranMesajiOfflineSatir1z);
            this.groupBox7.Controls.Add(this.ekranMesajiOfflineSatir1x);
            this.groupBox7.Controls.Add(this.button1);
            this.groupBox7.Controls.Add(this.chkekranMesajiOfflineBlink);
            this.groupBox7.Controls.Add(this.ekranMesajiOfflineBuzzerSuresi);
            this.groupBox7.Controls.Add(this.ekranMesajiOfflineRoleSuresi2);
            this.groupBox7.Controls.Add(this.ekranMesajiOfflineRoleSuresi1);
            this.groupBox7.Controls.Add(this.ekranMesajiOfflineEkranSuresi);
            this.groupBox7.Controls.Add(this.ekranMesajiOfflinealtBaslikFontTipi);
            this.groupBox7.Controls.Add(this.edtEkranMesajiSatirSayisiOffline);
            this.groupBox7.Controls.Add(this.ekranMesajiOfflinealtBaslik);
            this.groupBox7.Controls.Add(this.ekranMesajiOfflinealtBaslikTipi);
            this.groupBox7.Controls.Add(this.ekranMesajiOfflineSatir5);
            this.groupBox7.Controls.Add(this.ekranMesajiOfflineSatir4);
            this.groupBox7.Controls.Add(this.ekranMesajiOfflineSatir3);
            this.groupBox7.Controls.Add(this.ekranMesajiOfflineSatir2);
            this.groupBox7.Controls.Add(this.ekranMesajiOfflineSatir1);
            this.groupBox7.Controls.Add(this.edtCihazMesajUstBaslikOffline);
            this.groupBox7.Controls.Add(this.label88);
            this.groupBox7.Controls.Add(this.label89);
            this.groupBox7.Controls.Add(this.label90);
            this.groupBox7.Controls.Add(this.label91);
            this.groupBox7.Controls.Add(this.label92);
            this.groupBox7.Controls.Add(this.label93);
            this.groupBox7.Controls.Add(this.label94);
            this.groupBox7.Controls.Add(this.label95);
            this.groupBox7.Controls.Add(this.label96);
            this.groupBox7.Controls.Add(this.label97);
            this.groupBox7.Controls.Add(this.label98);
            this.groupBox7.Controls.Add(this.label99);
            this.groupBox7.Controls.Add(this.label100);
            this.groupBox7.Controls.Add(this.label101);
            this.groupBox7.Controls.Add(this.label102);
            this.groupBox7.Controls.Add(this.label103);
            this.groupBox7.Controls.Add(this.label104);
            this.groupBox7.Controls.Add(this.label105);
            this.groupBox7.Controls.Add(this.edtCihazMesajUstBaslikTipiOffline);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox7.Location = new System.Drawing.Point(3, 3);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(341, 591);
            this.groupBox7.TabIndex = 6;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Cihaz Mesajları  (Offline)";
            // 
            // label149
            // 
            this.label149.AutoSize = true;
            this.label149.Location = new System.Drawing.Point(10, 31);
            this.label149.Name = "label149";
            this.label149.Size = new System.Drawing.Size(55, 13);
            this.label149.TabIndex = 50;
            this.label149.Text = "Mesaj Tipi";
            // 
            // edtCihazMesajTipiOffline
            // 
            this.edtCihazMesajTipiOffline.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.edtCihazMesajTipiOffline.FormattingEnabled = true;
            this.edtCihazMesajTipiOffline.Items.AddRange(new object[] {
            "Yok",
            "Üst Bilgi",
            "Başlık"});
            this.edtCihazMesajTipiOffline.Location = new System.Drawing.Point(90, 26);
            this.edtCihazMesajTipiOffline.Name = "edtCihazMesajTipiOffline";
            this.edtCihazMesajTipiOffline.Size = new System.Drawing.Size(244, 21);
            this.edtCihazMesajTipiOffline.TabIndex = 49;
            this.edtCihazMesajTipiOffline.SelectedIndexChanged += new System.EventHandler(this.edtCihazMesajTipiOffline_SelectedIndexChanged);
            // 
            // label84
            // 
            this.label84.AutoSize = true;
            this.label84.Location = new System.Drawing.Point(157, 405);
            this.label84.Name = "label84";
            this.label84.Size = new System.Drawing.Size(20, 13);
            this.label84.TabIndex = 48;
            this.label84.Text = "ms";
            // 
            // label85
            // 
            this.label85.AutoSize = true;
            this.label85.Location = new System.Drawing.Point(157, 381);
            this.label85.Name = "label85";
            this.label85.Size = new System.Drawing.Size(20, 13);
            this.label85.TabIndex = 47;
            this.label85.Text = "ms";
            // 
            // label86
            // 
            this.label86.AutoSize = true;
            this.label86.Location = new System.Drawing.Point(157, 353);
            this.label86.Name = "label86";
            this.label86.Size = new System.Drawing.Size(20, 13);
            this.label86.TabIndex = 46;
            this.label86.Text = "ms";
            // 
            // label87
            // 
            this.label87.AutoSize = true;
            this.label87.Location = new System.Drawing.Point(158, 327);
            this.label87.Name = "label87";
            this.label87.Size = new System.Drawing.Size(45, 13);
            this.label87.TabIndex = 45;
            this.label87.Text = "*100 ms";
            // 
            // ekranMesajiOfflineSatir5z
            // 
            this.ekranMesajiOfflineSatir5z.Location = new System.Drawing.Point(288, 199);
            this.ekranMesajiOfflineSatir5z.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.ekranMesajiOfflineSatir5z.Name = "ekranMesajiOfflineSatir5z";
            this.ekranMesajiOfflineSatir5z.Size = new System.Drawing.Size(46, 20);
            this.ekranMesajiOfflineSatir5z.TabIndex = 44;
            this.ekranMesajiOfflineSatir5z.Value = new decimal(new int[] {
            75,
            0,
            0,
            0});
            // 
            // ekranMesajiOfflineSatir5x
            // 
            this.ekranMesajiOfflineSatir5x.Location = new System.Drawing.Point(223, 200);
            this.ekranMesajiOfflineSatir5x.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.ekranMesajiOfflineSatir5x.Name = "ekranMesajiOfflineSatir5x";
            this.ekranMesajiOfflineSatir5x.Size = new System.Drawing.Size(46, 20);
            this.ekranMesajiOfflineSatir5x.TabIndex = 43;
            this.ekranMesajiOfflineSatir5x.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // ekranMesajiOfflineSatir4z
            // 
            this.ekranMesajiOfflineSatir4z.Location = new System.Drawing.Point(288, 174);
            this.ekranMesajiOfflineSatir4z.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.ekranMesajiOfflineSatir4z.Name = "ekranMesajiOfflineSatir4z";
            this.ekranMesajiOfflineSatir4z.Size = new System.Drawing.Size(46, 20);
            this.ekranMesajiOfflineSatir4z.TabIndex = 42;
            this.ekranMesajiOfflineSatir4z.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // ekranMesajiOfflineSatir4x
            // 
            this.ekranMesajiOfflineSatir4x.Location = new System.Drawing.Point(223, 175);
            this.ekranMesajiOfflineSatir4x.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.ekranMesajiOfflineSatir4x.Name = "ekranMesajiOfflineSatir4x";
            this.ekranMesajiOfflineSatir4x.Size = new System.Drawing.Size(46, 20);
            this.ekranMesajiOfflineSatir4x.TabIndex = 41;
            this.ekranMesajiOfflineSatir4x.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // ekranMesajiOfflineSatir3z
            // 
            this.ekranMesajiOfflineSatir3z.Location = new System.Drawing.Point(288, 149);
            this.ekranMesajiOfflineSatir3z.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.ekranMesajiOfflineSatir3z.Name = "ekranMesajiOfflineSatir3z";
            this.ekranMesajiOfflineSatir3z.Size = new System.Drawing.Size(46, 20);
            this.ekranMesajiOfflineSatir3z.TabIndex = 40;
            this.ekranMesajiOfflineSatir3z.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            // 
            // ekranMesajiOfflineSatir3x
            // 
            this.ekranMesajiOfflineSatir3x.Location = new System.Drawing.Point(223, 150);
            this.ekranMesajiOfflineSatir3x.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.ekranMesajiOfflineSatir3x.Name = "ekranMesajiOfflineSatir3x";
            this.ekranMesajiOfflineSatir3x.Size = new System.Drawing.Size(46, 20);
            this.ekranMesajiOfflineSatir3x.TabIndex = 39;
            this.ekranMesajiOfflineSatir3x.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // ekranMesajiOfflineSatir2z
            // 
            this.ekranMesajiOfflineSatir2z.Location = new System.Drawing.Point(288, 125);
            this.ekranMesajiOfflineSatir2z.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.ekranMesajiOfflineSatir2z.Name = "ekranMesajiOfflineSatir2z";
            this.ekranMesajiOfflineSatir2z.Size = new System.Drawing.Size(46, 20);
            this.ekranMesajiOfflineSatir2z.TabIndex = 38;
            this.ekranMesajiOfflineSatir2z.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // ekranMesajiOfflineSatir2x
            // 
            this.ekranMesajiOfflineSatir2x.Location = new System.Drawing.Point(223, 126);
            this.ekranMesajiOfflineSatir2x.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.ekranMesajiOfflineSatir2x.Name = "ekranMesajiOfflineSatir2x";
            this.ekranMesajiOfflineSatir2x.Size = new System.Drawing.Size(46, 20);
            this.ekranMesajiOfflineSatir2x.TabIndex = 37;
            this.ekranMesajiOfflineSatir2x.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // ekranMesajiOfflineSatir1z
            // 
            this.ekranMesajiOfflineSatir1z.Location = new System.Drawing.Point(288, 100);
            this.ekranMesajiOfflineSatir1z.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.ekranMesajiOfflineSatir1z.Name = "ekranMesajiOfflineSatir1z";
            this.ekranMesajiOfflineSatir1z.Size = new System.Drawing.Size(46, 20);
            this.ekranMesajiOfflineSatir1z.TabIndex = 36;
            this.ekranMesajiOfflineSatir1z.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // ekranMesajiOfflineSatir1x
            // 
            this.ekranMesajiOfflineSatir1x.Location = new System.Drawing.Point(223, 101);
            this.ekranMesajiOfflineSatir1x.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.ekranMesajiOfflineSatir1x.Name = "ekranMesajiOfflineSatir1x";
            this.ekranMesajiOfflineSatir1x.Size = new System.Drawing.Size(46, 20);
            this.ekranMesajiOfflineSatir1x.TabIndex = 35;
            this.ekranMesajiOfflineSatir1x.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(224, 427);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 34);
            this.button1.TabIndex = 34;
            this.button1.Text = "Gönder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chkekranMesajiOfflineBlink
            // 
            this.chkekranMesajiOfflineBlink.AutoSize = true;
            this.chkekranMesajiOfflineBlink.Location = new System.Drawing.Point(88, 431);
            this.chkekranMesajiOfflineBlink.Name = "chkekranMesajiOfflineBlink";
            this.chkekranMesajiOfflineBlink.Size = new System.Drawing.Size(15, 14);
            this.chkekranMesajiOfflineBlink.TabIndex = 33;
            this.chkekranMesajiOfflineBlink.UseVisualStyleBackColor = true;
            // 
            // ekranMesajiOfflineBuzzerSuresi
            // 
            this.ekranMesajiOfflineBuzzerSuresi.Location = new System.Drawing.Point(89, 401);
            this.ekranMesajiOfflineBuzzerSuresi.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.ekranMesajiOfflineBuzzerSuresi.Name = "ekranMesajiOfflineBuzzerSuresi";
            this.ekranMesajiOfflineBuzzerSuresi.Size = new System.Drawing.Size(62, 20);
            this.ekranMesajiOfflineBuzzerSuresi.TabIndex = 32;
            this.ekranMesajiOfflineBuzzerSuresi.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // ekranMesajiOfflineRoleSuresi2
            // 
            this.ekranMesajiOfflineRoleSuresi2.Location = new System.Drawing.Point(90, 375);
            this.ekranMesajiOfflineRoleSuresi2.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.ekranMesajiOfflineRoleSuresi2.Name = "ekranMesajiOfflineRoleSuresi2";
            this.ekranMesajiOfflineRoleSuresi2.Size = new System.Drawing.Size(62, 20);
            this.ekranMesajiOfflineRoleSuresi2.TabIndex = 31;
            this.ekranMesajiOfflineRoleSuresi2.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // ekranMesajiOfflineRoleSuresi1
            // 
            this.ekranMesajiOfflineRoleSuresi1.Location = new System.Drawing.Point(90, 349);
            this.ekranMesajiOfflineRoleSuresi1.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.ekranMesajiOfflineRoleSuresi1.Name = "ekranMesajiOfflineRoleSuresi1";
            this.ekranMesajiOfflineRoleSuresi1.Size = new System.Drawing.Size(62, 20);
            this.ekranMesajiOfflineRoleSuresi1.TabIndex = 30;
            this.ekranMesajiOfflineRoleSuresi1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // ekranMesajiOfflineEkranSuresi
            // 
            this.ekranMesajiOfflineEkranSuresi.Location = new System.Drawing.Point(90, 323);
            this.ekranMesajiOfflineEkranSuresi.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.ekranMesajiOfflineEkranSuresi.Name = "ekranMesajiOfflineEkranSuresi";
            this.ekranMesajiOfflineEkranSuresi.Size = new System.Drawing.Size(62, 20);
            this.ekranMesajiOfflineEkranSuresi.TabIndex = 29;
            this.ekranMesajiOfflineEkranSuresi.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // ekranMesajiOfflinealtBaslikFontTipi
            // 
            this.ekranMesajiOfflinealtBaslikFontTipi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ekranMesajiOfflinealtBaslikFontTipi.FormattingEnabled = true;
            this.ekranMesajiOfflinealtBaslikFontTipi.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
            this.ekranMesajiOfflinealtBaslikFontTipi.Location = new System.Drawing.Point(90, 297);
            this.ekranMesajiOfflinealtBaslikFontTipi.Name = "ekranMesajiOfflinealtBaslikFontTipi";
            this.ekranMesajiOfflinealtBaslikFontTipi.Size = new System.Drawing.Size(121, 21);
            this.ekranMesajiOfflinealtBaslikFontTipi.TabIndex = 28;
            // 
            // edtEkranMesajiSatirSayisiOffline
            // 
            this.edtEkranMesajiSatirSayisiOffline.Location = new System.Drawing.Point(90, 273);
            this.edtEkranMesajiSatirSayisiOffline.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.edtEkranMesajiSatirSayisiOffline.Name = "edtEkranMesajiSatirSayisiOffline";
            this.edtEkranMesajiSatirSayisiOffline.Size = new System.Drawing.Size(62, 20);
            this.edtEkranMesajiSatirSayisiOffline.TabIndex = 27;
            this.edtEkranMesajiSatirSayisiOffline.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // ekranMesajiOfflinealtBaslik
            // 
            this.ekranMesajiOfflinealtBaslik.Location = new System.Drawing.Point(90, 250);
            this.ekranMesajiOfflinealtBaslik.Name = "ekranMesajiOfflinealtBaslik";
            this.ekranMesajiOfflinealtBaslik.Size = new System.Drawing.Size(244, 20);
            this.ekranMesajiOfflinealtBaslik.TabIndex = 26;
            // 
            // ekranMesajiOfflinealtBaslikTipi
            // 
            this.ekranMesajiOfflinealtBaslikTipi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ekranMesajiOfflinealtBaslikTipi.FormattingEnabled = true;
            this.ekranMesajiOfflinealtBaslikTipi.Items.AddRange(new object[] {
            "Yok",
            "Var"});
            this.ekranMesajiOfflinealtBaslikTipi.Location = new System.Drawing.Point(90, 226);
            this.ekranMesajiOfflinealtBaslikTipi.Name = "ekranMesajiOfflinealtBaslikTipi";
            this.ekranMesajiOfflinealtBaslikTipi.Size = new System.Drawing.Size(121, 21);
            this.ekranMesajiOfflinealtBaslikTipi.TabIndex = 25;
            this.ekranMesajiOfflinealtBaslikTipi.SelectedIndexChanged += new System.EventHandler(this.ekranMesajiOfflinealtBaslikTipi_SelectedIndexChanged);
            // 
            // ekranMesajiOfflineSatir5
            // 
            this.ekranMesajiOfflineSatir5.Location = new System.Drawing.Point(90, 200);
            this.ekranMesajiOfflineSatir5.Name = "ekranMesajiOfflineSatir5";
            this.ekranMesajiOfflineSatir5.Size = new System.Drawing.Size(121, 20);
            this.ekranMesajiOfflineSatir5.TabIndex = 24;
            // 
            // ekranMesajiOfflineSatir4
            // 
            this.ekranMesajiOfflineSatir4.Location = new System.Drawing.Point(90, 175);
            this.ekranMesajiOfflineSatir4.Name = "ekranMesajiOfflineSatir4";
            this.ekranMesajiOfflineSatir4.Size = new System.Drawing.Size(121, 20);
            this.ekranMesajiOfflineSatir4.TabIndex = 23;
            // 
            // ekranMesajiOfflineSatir3
            // 
            this.ekranMesajiOfflineSatir3.Location = new System.Drawing.Point(90, 150);
            this.ekranMesajiOfflineSatir3.Name = "ekranMesajiOfflineSatir3";
            this.ekranMesajiOfflineSatir3.Size = new System.Drawing.Size(121, 20);
            this.ekranMesajiOfflineSatir3.TabIndex = 22;
            // 
            // ekranMesajiOfflineSatir2
            // 
            this.ekranMesajiOfflineSatir2.Location = new System.Drawing.Point(90, 126);
            this.ekranMesajiOfflineSatir2.Name = "ekranMesajiOfflineSatir2";
            this.ekranMesajiOfflineSatir2.Size = new System.Drawing.Size(121, 20);
            this.ekranMesajiOfflineSatir2.TabIndex = 21;
            // 
            // ekranMesajiOfflineSatir1
            // 
            this.ekranMesajiOfflineSatir1.Location = new System.Drawing.Point(90, 101);
            this.ekranMesajiOfflineSatir1.Name = "ekranMesajiOfflineSatir1";
            this.ekranMesajiOfflineSatir1.Size = new System.Drawing.Size(121, 20);
            this.ekranMesajiOfflineSatir1.TabIndex = 20;
            // 
            // edtCihazMesajUstBaslikOffline
            // 
            this.edtCihazMesajUstBaslikOffline.Location = new System.Drawing.Point(90, 77);
            this.edtCihazMesajUstBaslikOffline.Name = "edtCihazMesajUstBaslikOffline";
            this.edtCihazMesajUstBaslikOffline.Size = new System.Drawing.Size(121, 20);
            this.edtCihazMesajUstBaslikOffline.TabIndex = 19;
            // 
            // label88
            // 
            this.label88.AutoSize = true;
            this.label88.Location = new System.Drawing.Point(297, 83);
            this.label88.Name = "label88";
            this.label88.Size = new System.Drawing.Size(14, 13);
            this.label88.TabIndex = 18;
            this.label88.Text = "Z";
            // 
            // label89
            // 
            this.label89.AutoSize = true;
            this.label89.Location = new System.Drawing.Point(239, 84);
            this.label89.Name = "label89";
            this.label89.Size = new System.Drawing.Size(14, 13);
            this.label89.TabIndex = 17;
            this.label89.Text = "X";
            // 
            // label90
            // 
            this.label90.AutoSize = true;
            this.label90.Location = new System.Drawing.Point(8, 427);
            this.label90.Name = "label90";
            this.label90.Size = new System.Drawing.Size(30, 13);
            this.label90.TabIndex = 16;
            this.label90.Text = "Blink";
            // 
            // label91
            // 
            this.label91.AutoSize = true;
            this.label91.Location = new System.Drawing.Point(8, 404);
            this.label91.Name = "label91";
            this.label91.Size = new System.Drawing.Size(71, 13);
            this.label91.TabIndex = 15;
            this.label91.Text = "Buzzer Süresi";
            // 
            // label92
            // 
            this.label92.AutoSize = true;
            this.label92.Location = new System.Drawing.Point(8, 378);
            this.label92.Name = "label92";
            this.label92.Size = new System.Drawing.Size(70, 13);
            this.label92.TabIndex = 14;
            this.label92.Text = "Röle Süresi 2";
            // 
            // label93
            // 
            this.label93.AutoSize = true;
            this.label93.Location = new System.Drawing.Point(8, 353);
            this.label93.Name = "label93";
            this.label93.Size = new System.Drawing.Size(70, 13);
            this.label93.TabIndex = 13;
            this.label93.Text = "Röle Süresi 1";
            // 
            // label94
            // 
            this.label94.AutoSize = true;
            this.label94.Location = new System.Drawing.Point(9, 330);
            this.label94.Name = "label94";
            this.label94.Size = new System.Drawing.Size(60, 13);
            this.label94.TabIndex = 12;
            this.label94.Text = "Ekran Süre";
            // 
            // label95
            // 
            this.label95.AutoSize = true;
            this.label95.Location = new System.Drawing.Point(9, 304);
            this.label95.Name = "label95";
            this.label95.Size = new System.Drawing.Size(48, 13);
            this.label95.TabIndex = 11;
            this.label95.Text = "Font Tipi";
            // 
            // label96
            // 
            this.label96.AutoSize = true;
            this.label96.Location = new System.Drawing.Point(9, 279);
            this.label96.Name = "label96";
            this.label96.Size = new System.Drawing.Size(58, 13);
            this.label96.TabIndex = 10;
            this.label96.Text = "Satır Sayısı";
            // 
            // label97
            // 
            this.label97.AutoSize = true;
            this.label97.Location = new System.Drawing.Point(10, 253);
            this.label97.Name = "label97";
            this.label97.Size = new System.Drawing.Size(50, 13);
            this.label97.TabIndex = 9;
            this.label97.Text = "Alt Başlık";
            // 
            // label98
            // 
            this.label98.AutoSize = true;
            this.label98.Location = new System.Drawing.Point(10, 230);
            this.label98.Name = "label98";
            this.label98.Size = new System.Drawing.Size(70, 13);
            this.label98.TabIndex = 8;
            this.label98.Text = "Alt Başlık Tipi";
            // 
            // label99
            // 
            this.label99.AutoSize = true;
            this.label99.Location = new System.Drawing.Point(10, 203);
            this.label99.Name = "label99";
            this.label99.Size = new System.Drawing.Size(37, 13);
            this.label99.TabIndex = 7;
            this.label99.Text = "5.Satır";
            // 
            // label100
            // 
            this.label100.AutoSize = true;
            this.label100.Location = new System.Drawing.Point(10, 179);
            this.label100.Name = "label100";
            this.label100.Size = new System.Drawing.Size(37, 13);
            this.label100.TabIndex = 6;
            this.label100.Text = "4.Satır";
            // 
            // label101
            // 
            this.label101.AutoSize = true;
            this.label101.Location = new System.Drawing.Point(10, 156);
            this.label101.Name = "label101";
            this.label101.Size = new System.Drawing.Size(37, 13);
            this.label101.TabIndex = 5;
            this.label101.Text = "3.Satır";
            // 
            // label102
            // 
            this.label102.AutoSize = true;
            this.label102.Location = new System.Drawing.Point(10, 131);
            this.label102.Name = "label102";
            this.label102.Size = new System.Drawing.Size(37, 13);
            this.label102.TabIndex = 4;
            this.label102.Text = "2.Satır";
            // 
            // label103
            // 
            this.label103.AutoSize = true;
            this.label103.Location = new System.Drawing.Point(10, 108);
            this.label103.Name = "label103";
            this.label103.Size = new System.Drawing.Size(37, 13);
            this.label103.TabIndex = 3;
            this.label103.Text = "1.Satır";
            // 
            // label104
            // 
            this.label104.AutoSize = true;
            this.label104.Location = new System.Drawing.Point(10, 83);
            this.label104.Name = "label104";
            this.label104.Size = new System.Drawing.Size(35, 13);
            this.label104.TabIndex = 2;
            this.label104.Text = "Başlık";
            // 
            // label105
            // 
            this.label105.AutoSize = true;
            this.label105.Location = new System.Drawing.Point(10, 58);
            this.label105.Name = "label105";
            this.label105.Size = new System.Drawing.Size(74, 13);
            this.label105.TabIndex = 1;
            this.label105.Text = "Üst Başlık Tipi";
            // 
            // edtCihazMesajUstBaslikTipiOffline
            // 
            this.edtCihazMesajUstBaslikTipiOffline.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.edtCihazMesajUstBaslikTipiOffline.FormattingEnabled = true;
            this.edtCihazMesajUstBaslikTipiOffline.Items.AddRange(new object[] {
            "Yok",
            "Üst Bilgi",
            "Başlık"});
            this.edtCihazMesajUstBaslikTipiOffline.Location = new System.Drawing.Point(90, 53);
            this.edtCihazMesajUstBaslikTipiOffline.Name = "edtCihazMesajUstBaslikTipiOffline";
            this.edtCihazMesajUstBaslikTipiOffline.Size = new System.Drawing.Size(121, 21);
            this.edtCihazMesajUstBaslikTipiOffline.TabIndex = 0;
            this.edtCihazMesajUstBaslikTipiOffline.SelectedIndexChanged += new System.EventHandler(this.edtCihazMesajUstBaslikTipiOffline_SelectedIndexChanged);
            // 
            // tsAccessSettings
            // 
            this.tsAccessSettings.Controls.Add(this.groupBox27);
            this.tsAccessSettings.Controls.Add(this.button17);
            this.tsAccessSettings.Controls.Add(this.chkYenidenBaslat);
            this.tsAccessSettings.Controls.Add(this.groupBox17);
            this.tsAccessSettings.Controls.Add(this.groupBox16);
            this.tsAccessSettings.Controls.Add(this.groupBox15);
            this.tsAccessSettings.Controls.Add(this.groupBox14);
            this.tsAccessSettings.Controls.Add(this.groupBox13);
            this.tsAccessSettings.Location = new System.Drawing.Point(4, 22);
            this.tsAccessSettings.Name = "tsAccessSettings";
            this.tsAccessSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tsAccessSettings.Size = new System.Drawing.Size(1108, 629);
            this.tsAccessSettings.TabIndex = 4;
            this.tsAccessSettings.Text = "Uygulama Ayarları";
            this.tsAccessSettings.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(478, 450);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(375, 37);
            this.button17.TabIndex = 6;
            this.button17.Text = "Uygulama Ayarlarını Fabrika ayarlarına getir";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // chkYenidenBaslat
            // 
            this.chkYenidenBaslat.AutoSize = true;
            this.chkYenidenBaslat.Location = new System.Drawing.Point(478, 427);
            this.chkYenidenBaslat.Name = "chkYenidenBaslat";
            this.chkYenidenBaslat.Size = new System.Drawing.Size(97, 17);
            this.chkYenidenBaslat.TabIndex = 5;
            this.chkYenidenBaslat.Text = "Yeniden Başlat";
            this.chkYenidenBaslat.UseVisualStyleBackColor = true;
            // 
            // groupBox17
            // 
            this.groupBox17.Controls.Add(this.chkZilCaldirmaTransistorCikisi1);
            this.groupBox17.Controls.Add(this.chkZilCaldirmaTransistorCikisi2);
            this.groupBox17.Controls.Add(this.button28);
            this.groupBox17.Controls.Add(this.button29);
            this.groupBox17.Controls.Add(this.button30);
            this.groupBox17.Controls.Add(this.edtZilCaldirma2Satir);
            this.groupBox17.Controls.Add(this.edtZilCaldirma1Satir);
            this.groupBox17.Controls.Add(this.label113);
            this.groupBox17.Controls.Add(this.label114);
            this.groupBox17.Controls.Add(this.label115);
            this.groupBox17.Controls.Add(this.chkZilCaldirmaEtkin);
            this.groupBox17.Location = new System.Drawing.Point(478, 205);
            this.groupBox17.Name = "groupBox17";
            this.groupBox17.Size = new System.Drawing.Size(375, 199);
            this.groupBox17.TabIndex = 4;
            this.groupBox17.TabStop = false;
            this.groupBox17.Text = "Zil Tablosu Ayarları";
            // 
            // chkZilCaldirmaTransistorCikisi1
            // 
            this.chkZilCaldirmaTransistorCikisi1.AutoSize = true;
            this.chkZilCaldirmaTransistorCikisi1.Location = new System.Drawing.Point(85, 131);
            this.chkZilCaldirmaTransistorCikisi1.Name = "chkZilCaldirmaTransistorCikisi1";
            this.chkZilCaldirmaTransistorCikisi1.Size = new System.Drawing.Size(107, 17);
            this.chkZilCaldirmaTransistorCikisi1.TabIndex = 41;
            this.chkZilCaldirmaTransistorCikisi1.Text = "Transistör Çıkışı 1";
            this.chkZilCaldirmaTransistorCikisi1.UseVisualStyleBackColor = true;
            // 
            // chkZilCaldirmaTransistorCikisi2
            // 
            this.chkZilCaldirmaTransistorCikisi2.AutoSize = true;
            this.chkZilCaldirmaTransistorCikisi2.Checked = true;
            this.chkZilCaldirmaTransistorCikisi2.Location = new System.Drawing.Point(211, 131);
            this.chkZilCaldirmaTransistorCikisi2.Name = "chkZilCaldirmaTransistorCikisi2";
            this.chkZilCaldirmaTransistorCikisi2.Size = new System.Drawing.Size(107, 17);
            this.chkZilCaldirmaTransistorCikisi2.TabIndex = 40;
            this.chkZilCaldirmaTransistorCikisi2.TabStop = true;
            this.chkZilCaldirmaTransistorCikisi2.Text = "Transistör Çıkışı 2";
            this.chkZilCaldirmaTransistorCikisi2.UseVisualStyleBackColor = true;
            // 
            // button28
            // 
            this.button28.Location = new System.Drawing.Point(235, 164);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(135, 23);
            this.button28.TabIndex = 39;
            this.button28.Text = "Zil Tablosu";
            this.button28.UseVisualStyleBackColor = true;
            this.button28.Click += new System.EventHandler(this.button28_Click);
            // 
            // button29
            // 
            this.button29.Location = new System.Drawing.Point(154, 164);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(75, 23);
            this.button29.TabIndex = 38;
            this.button29.Text = "Gönder";
            this.button29.UseVisualStyleBackColor = true;
            this.button29.Click += new System.EventHandler(this.button29_Click);
            // 
            // button30
            // 
            this.button30.Location = new System.Drawing.Point(73, 164);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(75, 23);
            this.button30.TabIndex = 37;
            this.button30.Text = "Getir";
            this.button30.UseVisualStyleBackColor = true;
            this.button30.Click += new System.EventHandler(this.button30_Click);
            // 
            // edtZilCaldirma2Satir
            // 
            this.edtZilCaldirma2Satir.Location = new System.Drawing.Point(89, 91);
            this.edtZilCaldirma2Satir.Name = "edtZilCaldirma2Satir";
            this.edtZilCaldirma2Satir.Size = new System.Drawing.Size(121, 20);
            this.edtZilCaldirma2Satir.TabIndex = 30;
            // 
            // edtZilCaldirma1Satir
            // 
            this.edtZilCaldirma1Satir.Location = new System.Drawing.Point(89, 66);
            this.edtZilCaldirma1Satir.Name = "edtZilCaldirma1Satir";
            this.edtZilCaldirma1Satir.Size = new System.Drawing.Size(121, 20);
            this.edtZilCaldirma1Satir.TabIndex = 29;
            // 
            // label113
            // 
            this.label113.AutoSize = true;
            this.label113.Location = new System.Drawing.Point(45, 94);
            this.label113.Name = "label113";
            this.label113.Size = new System.Drawing.Size(37, 13);
            this.label113.TabIndex = 28;
            this.label113.Text = "2.Satır";
            // 
            // label114
            // 
            this.label114.AutoSize = true;
            this.label114.Location = new System.Drawing.Point(45, 71);
            this.label114.Name = "label114";
            this.label114.Size = new System.Drawing.Size(37, 13);
            this.label114.TabIndex = 27;
            this.label114.Text = "1.Satır";
            // 
            // label115
            // 
            this.label115.AutoSize = true;
            this.label115.Location = new System.Drawing.Point(45, 46);
            this.label115.Name = "label115";
            this.label115.Size = new System.Drawing.Size(68, 13);
            this.label115.TabIndex = 26;
            this.label115.Text = "Ekran Mesajı";
            // 
            // chkZilCaldirmaEtkin
            // 
            this.chkZilCaldirmaEtkin.AutoSize = true;
            this.chkZilCaldirmaEtkin.Location = new System.Drawing.Point(45, 20);
            this.chkZilCaldirmaEtkin.Name = "chkZilCaldirmaEtkin";
            this.chkZilCaldirmaEtkin.Size = new System.Drawing.Size(107, 17);
            this.chkZilCaldirmaEtkin.TabIndex = 0;
            this.chkZilCaldirmaEtkin.Text = "Zil Çaldırma Etkin";
            this.chkZilCaldirmaEtkin.UseVisualStyleBackColor = true;
            // 
            // groupBox16
            // 
            this.groupBox16.Controls.Add(this.chkOkuyucuHizmetDisiAyarlariTransistorCikisi2);
            this.groupBox16.Controls.Add(this.chkOkuyucuHizmetDisiAyarlariTransistorCikisi1);
            this.groupBox16.Controls.Add(this.chkOkuyucuHizmetDisiAyarlariTransistorCikisiDegisiklikYok);
            this.groupBox16.Controls.Add(this.label116);
            this.groupBox16.Controls.Add(this.button25);
            this.groupBox16.Controls.Add(this.button26);
            this.groupBox16.Controls.Add(this.button27);
            this.groupBox16.Controls.Add(this.chkOkuyucuHizmetDisiAyarlariHizmet2Satir);
            this.groupBox16.Controls.Add(this.chkOkuyucuHizmetDisiAyarlariHizmet1Satir);
            this.groupBox16.Controls.Add(this.label111);
            this.groupBox16.Controls.Add(this.label112);
            this.groupBox16.Controls.Add(this.label110);
            this.groupBox16.Controls.Add(this.chkOkuyucuHizmetDisiAyarlariHizmetDisiEtkin);
            this.groupBox16.Location = new System.Drawing.Point(478, 7);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new System.Drawing.Size(376, 189);
            this.groupBox16.TabIndex = 3;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "Okuyucu Hizmet Dışı Ayarları  ";
            // 
            // chkOkuyucuHizmetDisiAyarlariTransistorCikisi2
            // 
            this.chkOkuyucuHizmetDisiAyarlariTransistorCikisi2.AutoSize = true;
            this.chkOkuyucuHizmetDisiAyarlariTransistorCikisi2.Location = new System.Drawing.Point(267, 116);
            this.chkOkuyucuHizmetDisiAyarlariTransistorCikisi2.Name = "chkOkuyucuHizmetDisiAyarlariTransistorCikisi2";
            this.chkOkuyucuHizmetDisiAyarlariTransistorCikisi2.Size = new System.Drawing.Size(31, 17);
            this.chkOkuyucuHizmetDisiAyarlariTransistorCikisi2.TabIndex = 40;
            this.chkOkuyucuHizmetDisiAyarlariTransistorCikisi2.TabStop = true;
            this.chkOkuyucuHizmetDisiAyarlariTransistorCikisi2.Text = "2";
            this.chkOkuyucuHizmetDisiAyarlariTransistorCikisi2.UseVisualStyleBackColor = true;
            // 
            // chkOkuyucuHizmetDisiAyarlariTransistorCikisi1
            // 
            this.chkOkuyucuHizmetDisiAyarlariTransistorCikisi1.AutoSize = true;
            this.chkOkuyucuHizmetDisiAyarlariTransistorCikisi1.Location = new System.Drawing.Point(230, 116);
            this.chkOkuyucuHizmetDisiAyarlariTransistorCikisi1.Name = "chkOkuyucuHizmetDisiAyarlariTransistorCikisi1";
            this.chkOkuyucuHizmetDisiAyarlariTransistorCikisi1.Size = new System.Drawing.Size(31, 17);
            this.chkOkuyucuHizmetDisiAyarlariTransistorCikisi1.TabIndex = 39;
            this.chkOkuyucuHizmetDisiAyarlariTransistorCikisi1.TabStop = true;
            this.chkOkuyucuHizmetDisiAyarlariTransistorCikisi1.Text = "1";
            this.chkOkuyucuHizmetDisiAyarlariTransistorCikisi1.UseVisualStyleBackColor = true;
            // 
            // chkOkuyucuHizmetDisiAyarlariTransistorCikisiDegisiklikYok
            // 
            this.chkOkuyucuHizmetDisiAyarlariTransistorCikisiDegisiklikYok.AutoSize = true;
            this.chkOkuyucuHizmetDisiAyarlariTransistorCikisiDegisiklikYok.Location = new System.Drawing.Point(134, 116);
            this.chkOkuyucuHizmetDisiAyarlariTransistorCikisiDegisiklikYok.Name = "chkOkuyucuHizmetDisiAyarlariTransistorCikisiDegisiklikYok";
            this.chkOkuyucuHizmetDisiAyarlariTransistorCikisiDegisiklikYok.Size = new System.Drawing.Size(90, 17);
            this.chkOkuyucuHizmetDisiAyarlariTransistorCikisiDegisiklikYok.TabIndex = 38;
            this.chkOkuyucuHizmetDisiAyarlariTransistorCikisiDegisiklikYok.TabStop = true;
            this.chkOkuyucuHizmetDisiAyarlariTransistorCikisiDegisiklikYok.Text = "Değişiklik yok";
            this.chkOkuyucuHizmetDisiAyarlariTransistorCikisiDegisiklikYok.UseVisualStyleBackColor = true;
            // 
            // label116
            // 
            this.label116.AutoSize = true;
            this.label116.Location = new System.Drawing.Point(45, 120);
            this.label116.Name = "label116";
            this.label116.Size = new System.Drawing.Size(83, 13);
            this.label116.TabIndex = 37;
            this.label116.Text = "Transistör Çıkışı ";
            // 
            // button25
            // 
            this.button25.Location = new System.Drawing.Point(230, 160);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(135, 23);
            this.button25.TabIndex = 36;
            this.button25.Text = "Hizmet Dışı Tablosu";
            this.button25.UseVisualStyleBackColor = true;
            this.button25.Click += new System.EventHandler(this.button25_Click);
            // 
            // button26
            // 
            this.button26.Location = new System.Drawing.Point(155, 160);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(71, 23);
            this.button26.TabIndex = 35;
            this.button26.Text = "Gönder";
            this.button26.UseVisualStyleBackColor = true;
            this.button26.Click += new System.EventHandler(this.button26_Click);
            // 
            // button27
            // 
            this.button27.Location = new System.Drawing.Point(77, 160);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(75, 23);
            this.button27.TabIndex = 34;
            this.button27.Text = "Getir";
            this.button27.UseVisualStyleBackColor = true;
            this.button27.Click += new System.EventHandler(this.button27_Click);
            // 
            // chkOkuyucuHizmetDisiAyarlariHizmet2Satir
            // 
            this.chkOkuyucuHizmetDisiAyarlariHizmet2Satir.Location = new System.Drawing.Point(86, 90);
            this.chkOkuyucuHizmetDisiAyarlariHizmet2Satir.Name = "chkOkuyucuHizmetDisiAyarlariHizmet2Satir";
            this.chkOkuyucuHizmetDisiAyarlariHizmet2Satir.Size = new System.Drawing.Size(121, 20);
            this.chkOkuyucuHizmetDisiAyarlariHizmet2Satir.TabIndex = 25;
            // 
            // chkOkuyucuHizmetDisiAyarlariHizmet1Satir
            // 
            this.chkOkuyucuHizmetDisiAyarlariHizmet1Satir.Location = new System.Drawing.Point(86, 65);
            this.chkOkuyucuHizmetDisiAyarlariHizmet1Satir.Name = "chkOkuyucuHizmetDisiAyarlariHizmet1Satir";
            this.chkOkuyucuHizmetDisiAyarlariHizmet1Satir.Size = new System.Drawing.Size(121, 20);
            this.chkOkuyucuHizmetDisiAyarlariHizmet1Satir.TabIndex = 24;
            // 
            // label111
            // 
            this.label111.AutoSize = true;
            this.label111.Location = new System.Drawing.Point(42, 93);
            this.label111.Name = "label111";
            this.label111.Size = new System.Drawing.Size(37, 13);
            this.label111.TabIndex = 23;
            this.label111.Text = "2.Satır";
            // 
            // label112
            // 
            this.label112.AutoSize = true;
            this.label112.Location = new System.Drawing.Point(42, 70);
            this.label112.Name = "label112";
            this.label112.Size = new System.Drawing.Size(37, 13);
            this.label112.TabIndex = 22;
            this.label112.Text = "1.Satır";
            // 
            // label110
            // 
            this.label110.AutoSize = true;
            this.label110.Location = new System.Drawing.Point(42, 45);
            this.label110.Name = "label110";
            this.label110.Size = new System.Drawing.Size(68, 13);
            this.label110.TabIndex = 1;
            this.label110.Text = "Ekran Mesajı";
            // 
            // chkOkuyucuHizmetDisiAyarlariHizmetDisiEtkin
            // 
            this.chkOkuyucuHizmetDisiAyarlariHizmetDisiEtkin.AutoSize = true;
            this.chkOkuyucuHizmetDisiAyarlariHizmetDisiEtkin.Location = new System.Drawing.Point(45, 21);
            this.chkOkuyucuHizmetDisiAyarlariHizmetDisiEtkin.Name = "chkOkuyucuHizmetDisiAyarlariHizmetDisiEtkin";
            this.chkOkuyucuHizmetDisiAyarlariHizmetDisiEtkin.Size = new System.Drawing.Size(151, 17);
            this.chkOkuyucuHizmetDisiAyarlariHizmetDisiEtkin.TabIndex = 0;
            this.chkOkuyucuHizmetDisiAyarlariHizmetDisiEtkin.Text = "Okuyucu Hizmet Dışı Etkin";
            this.chkOkuyucuHizmetDisiAyarlariHizmetDisiEtkin.UseVisualStyleBackColor = true;
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.button23);
            this.groupBox15.Controls.Add(this.button24);
            this.groupBox15.Controls.Add(this.digerEKSAyarlariEKSverisi);
            this.groupBox15.Controls.Add(this.label109);
            this.groupBox15.Controls.Add(this.digerEKSAyarlariKisiVerisi);
            this.groupBox15.Controls.Add(this.label108);
            this.groupBox15.Controls.Add(this.label107);
            this.groupBox15.Location = new System.Drawing.Point(10, 361);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(456, 132);
            this.groupBox15.TabIndex = 2;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "Diğer EKS Ayarları  ";
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(265, 102);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(75, 23);
            this.button23.TabIndex = 38;
            this.button23.Text = "Gönder";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.button23_Click);
            // 
            // button24
            // 
            this.button24.Location = new System.Drawing.Point(184, 102);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(75, 23);
            this.button24.TabIndex = 37;
            this.button24.Text = "Getir";
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.button24_Click);
            // 
            // digerEKSAyarlariEKSverisi
            // 
            this.digerEKSAyarlariEKSverisi.Location = new System.Drawing.Point(124, 61);
            this.digerEKSAyarlariEKSverisi.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.digerEKSAyarlariEKSverisi.Name = "digerEKSAyarlariEKSverisi";
            this.digerEKSAyarlariEKSverisi.Size = new System.Drawing.Size(57, 20);
            this.digerEKSAyarlariEKSverisi.TabIndex = 36;
            // 
            // label109
            // 
            this.label109.AutoSize = true;
            this.label109.Location = new System.Drawing.Point(12, 64);
            this.label109.Name = "label109";
            this.label109.Size = new System.Drawing.Size(53, 13);
            this.label109.TabIndex = 35;
            this.label109.Text = "Eks Verisi";
            // 
            // digerEKSAyarlariKisiVerisi
            // 
            this.digerEKSAyarlariKisiVerisi.Location = new System.Drawing.Point(124, 37);
            this.digerEKSAyarlariKisiVerisi.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.digerEKSAyarlariKisiVerisi.Name = "digerEKSAyarlariKisiVerisi";
            this.digerEKSAyarlariKisiVerisi.Size = new System.Drawing.Size(57, 20);
            this.digerEKSAyarlariKisiVerisi.TabIndex = 34;
            // 
            // label108
            // 
            this.label108.AutoSize = true;
            this.label108.Location = new System.Drawing.Point(12, 43);
            this.label108.Name = "label108";
            this.label108.Size = new System.Drawing.Size(51, 13);
            this.label108.TabIndex = 33;
            this.label108.Text = "Kişi Verisi";
            // 
            // label107
            // 
            this.label107.AutoSize = true;
            this.label107.Location = new System.Drawing.Point(12, 20);
            this.label107.Name = "label107";
            this.label107.Size = new System.Drawing.Size(183, 13);
            this.label107.TabIndex = 0;
            this.label107.Text = "Karttan Okumada Kullanılan Sektörler";
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.button21);
            this.groupBox14.Controls.Add(this.button22);
            this.groupBox14.Controls.Add(this.edtAntiPassBackArdisikGecisAraligi);
            this.groupBox14.Controls.Add(this.edtUygulamaAyarlariGuvenlikBolgeNo);
            this.groupBox14.Controls.Add(this.edtUygulamaAyarlariAPBtipi);
            this.groupBox14.Controls.Add(this.radioUygulamaAyarlariAntiPassBackGiris);
            this.groupBox14.Controls.Add(this.radioUygulamaAyarlariAntiPassBackCikis);
            this.groupBox14.Controls.Add(this.labeGecisAraligi);
            this.groupBox14.Controls.Add(this.labelGuvenlikBolgeNo);
            this.groupBox14.Controls.Add(this.label32);
            this.groupBox14.Location = new System.Drawing.Point(10, 205);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(456, 148);
            this.groupBox14.TabIndex = 1;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "Anti Passback Ayarları  ";
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(265, 119);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(75, 23);
            this.button21.TabIndex = 34;
            this.button21.Text = "Gönder";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(184, 119);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(75, 23);
            this.button22.TabIndex = 33;
            this.button22.Text = "Getir";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.button22_Click);
            // 
            // edtAntiPassBackArdisikGecisAraligi
            // 
            this.edtAntiPassBackArdisikGecisAraligi.Location = new System.Drawing.Point(126, 92);
            this.edtAntiPassBackArdisikGecisAraligi.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.edtAntiPassBackArdisikGecisAraligi.Name = "edtAntiPassBackArdisikGecisAraligi";
            this.edtAntiPassBackArdisikGecisAraligi.Size = new System.Drawing.Size(57, 20);
            this.edtAntiPassBackArdisikGecisAraligi.TabIndex = 32;
            // 
            // edtUygulamaAyarlariGuvenlikBolgeNo
            // 
            this.edtUygulamaAyarlariGuvenlikBolgeNo.Location = new System.Drawing.Point(127, 45);
            this.edtUygulamaAyarlariGuvenlikBolgeNo.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.edtUygulamaAyarlariGuvenlikBolgeNo.Name = "edtUygulamaAyarlariGuvenlikBolgeNo";
            this.edtUygulamaAyarlariGuvenlikBolgeNo.Size = new System.Drawing.Size(57, 20);
            this.edtUygulamaAyarlariGuvenlikBolgeNo.TabIndex = 31;
            // 
            // edtUygulamaAyarlariAPBtipi
            // 
            this.edtUygulamaAyarlariAPBtipi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.edtUygulamaAyarlariAPBtipi.FormattingEnabled = true;
            this.edtUygulamaAyarlariAPBtipi.Items.AddRange(new object[] {
            "Kapalı",
            "Anti Pass Back",
            "Girişten Süre Kontrolü + Anti Pass Back",
            "Süre Kontrolü + Anti Pass Back",
            "Girişten Süre Kontrolü",
            "Süre Kontrolü"});
            this.edtUygulamaAyarlariAPBtipi.Location = new System.Drawing.Point(127, 17);
            this.edtUygulamaAyarlariAPBtipi.Name = "edtUygulamaAyarlariAPBtipi";
            this.edtUygulamaAyarlariAPBtipi.Size = new System.Drawing.Size(213, 21);
            this.edtUygulamaAyarlariAPBtipi.TabIndex = 5;
            this.edtUygulamaAyarlariAPBtipi.SelectedIndexChanged += new System.EventHandler(this.edtUygulamaAyarlariAPBtipi_SelectedIndexChanged);
            // 
            // radioUygulamaAyarlariAntiPassBackGiris
            // 
            this.radioUygulamaAyarlariAntiPassBackGiris.AutoSize = true;
            this.radioUygulamaAyarlariAntiPassBackGiris.Location = new System.Drawing.Point(127, 70);
            this.radioUygulamaAyarlariAntiPassBackGiris.Name = "radioUygulamaAyarlariAntiPassBackGiris";
            this.radioUygulamaAyarlariAntiPassBackGiris.Size = new System.Drawing.Size(45, 17);
            this.radioUygulamaAyarlariAntiPassBackGiris.TabIndex = 4;
            this.radioUygulamaAyarlariAntiPassBackGiris.Text = "Giriş";
            this.radioUygulamaAyarlariAntiPassBackGiris.UseVisualStyleBackColor = true;
            // 
            // radioUygulamaAyarlariAntiPassBackCikis
            // 
            this.radioUygulamaAyarlariAntiPassBackCikis.AutoSize = true;
            this.radioUygulamaAyarlariAntiPassBackCikis.Checked = true;
            this.radioUygulamaAyarlariAntiPassBackCikis.Location = new System.Drawing.Point(189, 70);
            this.radioUygulamaAyarlariAntiPassBackCikis.Name = "radioUygulamaAyarlariAntiPassBackCikis";
            this.radioUygulamaAyarlariAntiPassBackCikis.Size = new System.Drawing.Size(47, 17);
            this.radioUygulamaAyarlariAntiPassBackCikis.TabIndex = 3;
            this.radioUygulamaAyarlariAntiPassBackCikis.TabStop = true;
            this.radioUygulamaAyarlariAntiPassBackCikis.Text = "Çıkış";
            this.radioUygulamaAyarlariAntiPassBackCikis.UseVisualStyleBackColor = true;
            // 
            // labeGecisAraligi
            // 
            this.labeGecisAraligi.AutoSize = true;
            this.labeGecisAraligi.Location = new System.Drawing.Point(14, 94);
            this.labeGecisAraligi.Name = "labeGecisAraligi";
            this.labeGecisAraligi.Size = new System.Drawing.Size(96, 13);
            this.labeGecisAraligi.TabIndex = 2;
            this.labeGecisAraligi.Text = "Ardışık geçiş aralığı";
            // 
            // labelGuvenlikBolgeNo
            // 
            this.labelGuvenlikBolgeNo.AutoSize = true;
            this.labelGuvenlikBolgeNo.Location = new System.Drawing.Point(14, 48);
            this.labelGuvenlikBolgeNo.Name = "labelGuvenlikBolgeNo";
            this.labelGuvenlikBolgeNo.Size = new System.Drawing.Size(96, 13);
            this.labelGuvenlikBolgeNo.TabIndex = 1;
            this.labelGuvenlikBolgeNo.Text = "Güvenlik Bölge No";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(14, 20);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(48, 13);
            this.label32.TabIndex = 0;
            this.label32.Text = "APB Tipi";
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.btnPersTZMode);
            this.groupBox13.Controls.Add(this.lblInputDuration);
            this.groupBox13.Controls.Add(this.cbPersTZMode);
            this.groupBox13.Controls.Add(this.edtGenelAyarlarZamanKisitTablosuEtkin);
            this.groupBox13.Controls.Add(this.button20);
            this.groupBox13.Controls.Add(this.button19);
            this.groupBox13.Controls.Add(this.button18);
            this.groupBox13.Controls.Add(this.edtUygulamaayarlariGecisSuresi);
            this.groupBox13.Controls.Add(this.labelGecisSuresi);
            this.groupBox13.Controls.Add(this.label30);
            this.groupBox13.Controls.Add(this.edtUygulamaAyariGirisTipi);
            this.groupBox13.Controls.Add(this.label29);
            this.groupBox13.Controls.Add(this.edtGenelAyarlarSifreGecisTipi);
            this.groupBox13.Controls.Add(this.label28);
            this.groupBox13.Controls.Add(this.edtGenelAyarlarGecisTipi);
            this.groupBox13.Location = new System.Drawing.Point(9, 7);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(457, 189);
            this.groupBox13.TabIndex = 0;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Genel Ayarlar  ";
            // 
            // btnPersTZMode
            // 
            this.btnPersTZMode.Location = new System.Drawing.Point(229, 125);
            this.btnPersTZMode.Name = "btnPersTZMode";
            this.btnPersTZMode.Size = new System.Drawing.Size(166, 24);
            this.btnPersTZMode.TabIndex = 37;
            this.btnPersTZMode.Text = "Kişi Zaman Kısıt Tablosu";
            this.btnPersTZMode.UseVisualStyleBackColor = true;
            this.btnPersTZMode.Click += new System.EventHandler(this.btnPersTZMode_Click);
            // 
            // lblInputDuration
            // 
            this.lblInputDuration.AutoSize = true;
            this.lblInputDuration.Location = new System.Drawing.Point(6, 106);
            this.lblInputDuration.Name = "lblInputDuration";
            this.lblInputDuration.Size = new System.Drawing.Size(92, 13);
            this.lblInputDuration.TabIndex = 36;
            this.lblInputDuration.Text = "Zaman Kısıt Modu";
            // 
            // cbPersTZMode
            // 
            this.cbPersTZMode.FormattingEnabled = true;
            this.cbPersTZMode.Items.AddRange(new object[] {
            "Kapalı",
            "Zaman Aralığı",
            "Zaman Tablo No"});
            this.cbPersTZMode.Location = new System.Drawing.Point(158, 100);
            this.cbPersTZMode.Name = "cbPersTZMode";
            this.cbPersTZMode.Size = new System.Drawing.Size(121, 21);
            this.cbPersTZMode.TabIndex = 35;
            this.cbPersTZMode.SelectedIndexChanged += new System.EventHandler(this.cbPersTZMode_SelectedIndexChanged);
            // 
            // edtGenelAyarlarZamanKisitTablosuEtkin
            // 
            this.edtGenelAyarlarZamanKisitTablosuEtkin.AutoSize = true;
            this.edtGenelAyarlarZamanKisitTablosuEtkin.Location = new System.Drawing.Point(293, 17);
            this.edtGenelAyarlarZamanKisitTablosuEtkin.Name = "edtGenelAyarlarZamanKisitTablosuEtkin";
            this.edtGenelAyarlarZamanKisitTablosuEtkin.Size = new System.Drawing.Size(149, 17);
            this.edtGenelAyarlarZamanKisitTablosuEtkin.TabIndex = 34;
            this.edtGenelAyarlarZamanKisitTablosuEtkin.Text = "Zaman Kısıt Tablosu Etkin";
            this.edtGenelAyarlarZamanKisitTablosuEtkin.UseVisualStyleBackColor = true;
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(293, 40);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(149, 23);
            this.button20.TabIndex = 33;
            this.button20.Text = "Zaman Kısıt Tablosu";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(283, 155);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(112, 28);
            this.button19.TabIndex = 32;
            this.button19.Text = "Gönder";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(158, 155);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(121, 28);
            this.button18.TabIndex = 31;
            this.button18.Text = "Getir";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // edtUygulamaayarlariGecisSuresi
            // 
            this.edtUygulamaayarlariGecisSuresi.Location = new System.Drawing.Point(158, 128);
            this.edtUygulamaayarlariGecisSuresi.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.edtUygulamaayarlariGecisSuresi.Name = "edtUygulamaayarlariGecisSuresi";
            this.edtUygulamaayarlariGecisSuresi.Size = new System.Drawing.Size(57, 20);
            this.edtUygulamaayarlariGecisSuresi.TabIndex = 30;
            // 
            // labelGecisSuresi
            // 
            this.labelGecisSuresi.AutoSize = true;
            this.labelGecisSuresi.Location = new System.Drawing.Point(6, 131);
            this.labelGecisSuresi.Name = "labelGecisSuresi";
            this.labelGecisSuresi.Size = new System.Drawing.Size(66, 13);
            this.labelGecisSuresi.TabIndex = 6;
            this.labelGecisSuresi.Text = "Geçiş Süresi";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(6, 76);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(47, 13);
            this.label30.TabIndex = 5;
            this.label30.Text = "Giriş Tipi";
            // 
            // edtUygulamaAyariGirisTipi
            // 
            this.edtUygulamaAyariGirisTipi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.edtUygulamaAyariGirisTipi.FormattingEnabled = true;
            this.edtUygulamaAyariGirisTipi.Items.AddRange(new object[] {
            "Kapalı",
            "Butonla Kapı Açmak İçin Kullan",
            "Turnike veya Kapıdan Dönüş Bilgisini Almak için Kullan",
            "Kapı Açık Kaldı Alarmı"});
            this.edtUygulamaAyariGirisTipi.Location = new System.Drawing.Point(158, 73);
            this.edtUygulamaAyariGirisTipi.Name = "edtUygulamaAyariGirisTipi";
            this.edtUygulamaAyariGirisTipi.Size = new System.Drawing.Size(237, 21);
            this.edtUygulamaAyariGirisTipi.TabIndex = 4;
            this.edtUygulamaAyariGirisTipi.SelectedIndexChanged += new System.EventHandler(this.edtUygulamaAyariGirisTipi_SelectedIndexChanged);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(6, 49);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(78, 13);
            this.label29.TabIndex = 3;
            this.label29.Text = "Şifre Geçiş Tipi";
            // 
            // edtGenelAyarlarSifreGecisTipi
            // 
            this.edtGenelAyarlarSifreGecisTipi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.edtGenelAyarlarSifreGecisTipi.FormattingEnabled = true;
            this.edtGenelAyarlarSifreGecisTipi.Items.AddRange(new object[] {
            "Sadece Şifre",
            "Kişi No +  Şifre"});
            this.edtGenelAyarlarSifreGecisTipi.Location = new System.Drawing.Point(158, 46);
            this.edtGenelAyarlarSifreGecisTipi.Name = "edtGenelAyarlarSifreGecisTipi";
            this.edtGenelAyarlarSifreGecisTipi.Size = new System.Drawing.Size(121, 21);
            this.edtGenelAyarlarSifreGecisTipi.TabIndex = 2;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(6, 25);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(54, 13);
            this.label28.TabIndex = 1;
            this.label28.Text = "Geçiş Tipi";
            // 
            // edtGenelAyarlarGecisTipi
            // 
            this.edtGenelAyarlarGecisTipi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.edtGenelAyarlarGecisTipi.FormattingEnabled = true;
            this.edtGenelAyarlarGecisTipi.Items.AddRange(new object[] {
            "Sadece Kart",
            "Kart veya Şifre",
            "Kart ve Şifre"});
            this.edtGenelAyarlarGecisTipi.Location = new System.Drawing.Point(158, 17);
            this.edtGenelAyarlarGecisTipi.Name = "edtGenelAyarlarGecisTipi";
            this.edtGenelAyarlarGecisTipi.Size = new System.Drawing.Size(121, 21);
            this.edtGenelAyarlarGecisTipi.TabIndex = 0;
            this.edtGenelAyarlarGecisTipi.SelectedIndexChanged += new System.EventHandler(this.edtGenelAyarlarGecisTipi_SelectedIndexChanged);
            // 
            // tsAddWhitelist
            // 
            this.tsAddWhitelist.Controls.Add(this.button35);
            this.tsAddWhitelist.Controls.Add(this.groupBox26);
            this.tsAddWhitelist.Controls.Add(this.label188);
            this.tsAddWhitelist.Controls.Add(this.dtDogumTarihi);
            this.tsAddWhitelist.Controls.Add(this.btnTopluAktarim);
            this.tsAddWhitelist.Controls.Add(this.numericUpDown1);
            this.tsAddWhitelist.Controls.Add(this.button2);
            this.tsAddWhitelist.Controls.Add(this.lblIndexNo);
            this.tsAddWhitelist.Controls.Add(this.lblTanimliKisi);
            this.tsAddWhitelist.Controls.Add(this.btnClearWhiteList);
            this.tsAddWhitelist.Controls.Add(this.btnCardIDCnt);
            this.tsAddWhitelist.Controls.Add(this.btnGetWhiteList);
            this.tsAddWhitelist.Controls.Add(this.btnDeleteWhiteList);
            this.tsAddWhitelist.Controls.Add(this.btnEditWhiteList);
            this.tsAddWhitelist.Controls.Add(this.btnAddWhiteList);
            this.tsAddWhitelist.Controls.Add(this.cbAccessCardEnabled);
            this.tsAddWhitelist.Controls.Add(this.chkAcilDurumlardaGecizIzni);
            this.tsAddWhitelist.Controls.Add(this.chkKartOfflinedaOnlineCalissin);
            this.tsAddWhitelist.Controls.Add(this.cbATCEnabled);
            this.tsAddWhitelist.Controls.Add(this.cbAPBEnabled);
            this.tsAddWhitelist.Controls.Add(this.cbAccessEnabled);
            this.tsAddWhitelist.Controls.Add(this.label46);
            this.tsAddWhitelist.Controls.Add(this.edtEndDate);
            this.tsAddWhitelist.Controls.Add(this.label45);
            this.tsAddWhitelist.Controls.Add(this.sePassword);
            this.tsAddWhitelist.Controls.Add(this.label44);
            this.tsAddWhitelist.Controls.Add(this.seCode);
            this.tsAddWhitelist.Controls.Add(this.label37);
            this.tsAddWhitelist.Controls.Add(this.seAccMask1);
            this.tsAddWhitelist.Controls.Add(this.label35);
            this.tsAddWhitelist.Controls.Add(this.edtName);
            this.tsAddWhitelist.Controls.Add(this.label34);
            this.tsAddWhitelist.Controls.Add(this.edtCardID);
            this.tsAddWhitelist.Location = new System.Drawing.Point(4, 22);
            this.tsAddWhitelist.Name = "tsAddWhitelist";
            this.tsAddWhitelist.Padding = new System.Windows.Forms.Padding(3);
            this.tsAddWhitelist.Size = new System.Drawing.Size(1108, 629);
            this.tsAddWhitelist.TabIndex = 5;
            this.tsAddWhitelist.Text = "Kişi Ekleme";
            this.tsAddWhitelist.UseVisualStyleBackColor = true;
            // 
            // button35
            // 
            this.button35.Location = new System.Drawing.Point(39, 471);
            this.button35.Name = "button35";
            this.button35.Size = new System.Drawing.Size(134, 42);
            this.button35.TabIndex = 134;
            this.button35.Text = "Personel Komut Listesi";
            this.button35.UseVisualStyleBackColor = true;
            this.button35.Click += new System.EventHandler(this.button35_Click);
            // 
            // groupBox26
            // 
            this.groupBox26.Controls.Add(this.nmrNeedCmdControl);
            this.groupBox26.Controls.Add(this.nmrToplamAylikHak);
            this.groupBox26.Controls.Add(this.nmrToplamHaftalikHak);
            this.groupBox26.Controls.Add(this.nmrAyarListeNo);
            this.groupBox26.Controls.Add(this.label192);
            this.groupBox26.Controls.Add(this.label191);
            this.groupBox26.Controls.Add(this.label190);
            this.groupBox26.Controls.Add(this.label189);
            this.groupBox26.Location = new System.Drawing.Point(555, 64);
            this.groupBox26.Name = "groupBox26";
            this.groupBox26.Size = new System.Drawing.Size(253, 174);
            this.groupBox26.TabIndex = 133;
            this.groupBox26.TabStop = false;
            this.groupBox26.Text = "Kişi Yemekhane Ayarları";
            // 
            // nmrNeedCmdControl
            // 
            this.nmrNeedCmdControl.Location = new System.Drawing.Point(128, 131);
            this.nmrNeedCmdControl.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nmrNeedCmdControl.Name = "nmrNeedCmdControl";
            this.nmrNeedCmdControl.Size = new System.Drawing.Size(53, 20);
            this.nmrNeedCmdControl.TabIndex = 99;
            // 
            // nmrToplamAylikHak
            // 
            this.nmrToplamAylikHak.Location = new System.Drawing.Point(128, 98);
            this.nmrToplamAylikHak.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nmrToplamAylikHak.Name = "nmrToplamAylikHak";
            this.nmrToplamAylikHak.Size = new System.Drawing.Size(53, 20);
            this.nmrToplamAylikHak.TabIndex = 99;
            // 
            // nmrToplamHaftalikHak
            // 
            this.nmrToplamHaftalikHak.Location = new System.Drawing.Point(128, 68);
            this.nmrToplamHaftalikHak.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nmrToplamHaftalikHak.Name = "nmrToplamHaftalikHak";
            this.nmrToplamHaftalikHak.Size = new System.Drawing.Size(53, 20);
            this.nmrToplamHaftalikHak.TabIndex = 99;
            // 
            // nmrAyarListeNo
            // 
            this.nmrAyarListeNo.Location = new System.Drawing.Point(128, 37);
            this.nmrAyarListeNo.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nmrAyarListeNo.Name = "nmrAyarListeNo";
            this.nmrAyarListeNo.Size = new System.Drawing.Size(53, 20);
            this.nmrAyarListeNo.TabIndex = 99;
            // 
            // label192
            // 
            this.label192.AutoSize = true;
            this.label192.Location = new System.Drawing.Point(18, 135);
            this.label192.Name = "label192";
            this.label192.Size = new System.Drawing.Size(96, 13);
            this.label192.TabIndex = 0;
            this.label192.Text = "Need CMD Control";
            // 
            // label191
            // 
            this.label191.AutoSize = true;
            this.label191.Location = new System.Drawing.Point(18, 103);
            this.label191.Name = "label191";
            this.label191.Size = new System.Drawing.Size(90, 13);
            this.label191.TabIndex = 0;
            this.label191.Text = "Toplam Aylık Hak";
            // 
            // label190
            // 
            this.label190.AutoSize = true;
            this.label190.Location = new System.Drawing.Point(18, 73);
            this.label190.Name = "label190";
            this.label190.Size = new System.Drawing.Size(98, 13);
            this.label190.TabIndex = 0;
            this.label190.Text = "Toplam Haftalı Hak";
            // 
            // label189
            // 
            this.label189.AutoSize = true;
            this.label189.Location = new System.Drawing.Point(18, 39);
            this.label189.Name = "label189";
            this.label189.Size = new System.Drawing.Size(70, 13);
            this.label189.TabIndex = 0;
            this.label189.Text = "Ayar Liste No";
            // 
            // label188
            // 
            this.label188.AutoSize = true;
            this.label188.Location = new System.Drawing.Point(397, 20);
            this.label188.Name = "label188";
            this.label188.Size = new System.Drawing.Size(104, 13);
            this.label188.TabIndex = 132;
            this.label188.Text = "Kart Başlangıç Tarihi";
            // 
            // dtDogumTarihi
            // 
            this.dtDogumTarihi.CustomFormat = " dd.MM.yyyy HH:mm:ss";
            this.dtDogumTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDogumTarihi.Location = new System.Drawing.Point(400, 41);
            this.dtDogumTarihi.Name = "dtDogumTarihi";
            this.dtDogumTarihi.Size = new System.Drawing.Size(81, 20);
            this.dtDogumTarihi.TabIndex = 131;
            this.dtDogumTarihi.Value = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            // 
            // btnTopluAktarim
            // 
            this.btnTopluAktarim.Location = new System.Drawing.Point(39, 422);
            this.btnTopluAktarim.Name = "btnTopluAktarim";
            this.btnTopluAktarim.Size = new System.Drawing.Size(134, 42);
            this.btnTopluAktarim.TabIndex = 130;
            this.btnTopluAktarim.Text = "Toplu Aktarım Testi";
            this.btnTopluAktarim.UseVisualStyleBackColor = true;
            this.btnTopluAktarim.Click += new System.EventHandler(this.btnTopluAktarim_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(39, 358);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(132, 20);
            this.numericUpDown1.TabIndex = 129;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(39, 384);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 32);
            this.button2.TabIndex = 128;
            this.button2.Text = "Toplu Atım";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblIndexNo
            // 
            this.lblIndexNo.AutoSize = true;
            this.lblIndexNo.Location = new System.Drawing.Point(240, 16);
            this.lblIndexNo.Name = "lblIndexNo";
            this.lblIndexNo.Size = new System.Drawing.Size(34, 13);
            this.lblIndexNo.TabIndex = 127;
            this.lblIndexNo.Text = ".........";
            // 
            // lblTanimliKisi
            // 
            this.lblTanimliKisi.AutoSize = true;
            this.lblTanimliKisi.Location = new System.Drawing.Point(187, 334);
            this.lblTanimliKisi.Name = "lblTanimliKisi";
            this.lblTanimliKisi.Size = new System.Drawing.Size(49, 13);
            this.lblTanimliKisi.TabIndex = 126;
            this.lblTanimliKisi.Text = "..............";
            // 
            // btnClearWhiteList
            // 
            this.btnClearWhiteList.Location = new System.Drawing.Point(242, 329);
            this.btnClearWhiteList.Name = "btnClearWhiteList";
            this.btnClearWhiteList.Size = new System.Drawing.Size(139, 23);
            this.btnClearWhiteList.TabIndex = 125;
            this.btnClearWhiteList.Text = "Tanımlı Tüm Kişileri Sil";
            this.btnClearWhiteList.UseVisualStyleBackColor = true;
            this.btnClearWhiteList.Click += new System.EventHandler(this.btnClearWhiteList_Click);
            // 
            // btnCardIDCnt
            // 
            this.btnCardIDCnt.Location = new System.Drawing.Point(39, 329);
            this.btnCardIDCnt.Name = "btnCardIDCnt";
            this.btnCardIDCnt.Size = new System.Drawing.Size(134, 23);
            this.btnCardIDCnt.TabIndex = 124;
            this.btnCardIDCnt.Text = "Tanımlı Kart Sayısı";
            this.btnCardIDCnt.UseVisualStyleBackColor = true;
            this.btnCardIDCnt.Click += new System.EventHandler(this.btnCardIDCnt_Click);
            // 
            // btnGetWhiteList
            // 
            this.btnGetWhiteList.Location = new System.Drawing.Point(319, 290);
            this.btnGetWhiteList.Name = "btnGetWhiteList";
            this.btnGetWhiteList.Size = new System.Drawing.Size(80, 23);
            this.btnGetWhiteList.TabIndex = 123;
            this.btnGetWhiteList.Text = "Bul";
            this.btnGetWhiteList.UseVisualStyleBackColor = true;
            this.btnGetWhiteList.Click += new System.EventHandler(this.btnGetWhiteList_Click);
            // 
            // btnDeleteWhiteList
            // 
            this.btnDeleteWhiteList.Location = new System.Drawing.Point(228, 290);
            this.btnDeleteWhiteList.Name = "btnDeleteWhiteList";
            this.btnDeleteWhiteList.Size = new System.Drawing.Size(80, 23);
            this.btnDeleteWhiteList.TabIndex = 122;
            this.btnDeleteWhiteList.Text = "Sil";
            this.btnDeleteWhiteList.UseVisualStyleBackColor = true;
            this.btnDeleteWhiteList.Click += new System.EventHandler(this.btnDeleteWhiteList_Click);
            // 
            // btnEditWhiteList
            // 
            this.btnEditWhiteList.Location = new System.Drawing.Point(132, 290);
            this.btnEditWhiteList.Name = "btnEditWhiteList";
            this.btnEditWhiteList.Size = new System.Drawing.Size(80, 23);
            this.btnEditWhiteList.TabIndex = 121;
            this.btnEditWhiteList.Text = "Değiştir";
            this.btnEditWhiteList.UseVisualStyleBackColor = true;
            this.btnEditWhiteList.Click += new System.EventHandler(this.btnEditWhiteList_Click);
            // 
            // btnAddWhiteList
            // 
            this.btnAddWhiteList.Location = new System.Drawing.Point(39, 290);
            this.btnAddWhiteList.Name = "btnAddWhiteList";
            this.btnAddWhiteList.Size = new System.Drawing.Size(80, 23);
            this.btnAddWhiteList.TabIndex = 120;
            this.btnAddWhiteList.Text = "Ekle";
            this.btnAddWhiteList.UseVisualStyleBackColor = true;
            this.btnAddWhiteList.Click += new System.EventHandler(this.btnAddWhiteList_Click);
            // 
            // cbAccessCardEnabled
            // 
            this.cbAccessCardEnabled.AutoSize = true;
            this.cbAccessCardEnabled.Location = new System.Drawing.Point(39, 267);
            this.cbAccessCardEnabled.Name = "cbAccessCardEnabled";
            this.cbAccessCardEnabled.Size = new System.Drawing.Size(179, 17);
            this.cbAccessCardEnabled.TabIndex = 119;
            this.cbAccessCardEnabled.Text = "Karttan Access Kontrolü Yapılsın";
            this.cbAccessCardEnabled.UseVisualStyleBackColor = true;
            // 
            // chkAcilDurumlardaGecizIzni
            // 
            this.chkAcilDurumlardaGecizIzni.AutoSize = true;
            this.chkAcilDurumlardaGecizIzni.Location = new System.Drawing.Point(264, 221);
            this.chkAcilDurumlardaGecizIzni.Name = "chkAcilDurumlardaGecizIzni";
            this.chkAcilDurumlardaGecizIzni.Size = new System.Drawing.Size(144, 17);
            this.chkAcilDurumlardaGecizIzni.TabIndex = 118;
            this.chkAcilDurumlardaGecizIzni.Text = "Acil durumlarda geçiş izni";
            this.chkAcilDurumlardaGecizIzni.UseVisualStyleBackColor = true;
            // 
            // chkKartOfflinedaOnlineCalissin
            // 
            this.chkKartOfflinedaOnlineCalissin.AutoSize = true;
            this.chkKartOfflinedaOnlineCalissin.Location = new System.Drawing.Point(264, 198);
            this.chkKartOfflinedaOnlineCalissin.Name = "chkKartOfflinedaOnlineCalissin";
            this.chkKartOfflinedaOnlineCalissin.Size = new System.Drawing.Size(186, 17);
            this.chkKartOfflinedaOnlineCalissin.TabIndex = 118;
            this.chkKartOfflinedaOnlineCalissin.Text = "Kart Offlineda  Online Çalışsın mı ?";
            this.chkKartOfflinedaOnlineCalissin.UseVisualStyleBackColor = true;
            // 
            // cbATCEnabled
            // 
            this.cbATCEnabled.AutoSize = true;
            this.cbATCEnabled.Checked = true;
            this.cbATCEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbATCEnabled.Location = new System.Drawing.Point(39, 244);
            this.cbATCEnabled.Name = "cbATCEnabled";
            this.cbATCEnabled.Size = new System.Drawing.Size(172, 17);
            this.cbATCEnabled.TabIndex = 118;
            this.cbATCEnabled.Text = "Zaman kısıt kontrolü olsun mu?";
            this.cbATCEnabled.UseVisualStyleBackColor = true;
            // 
            // cbAPBEnabled
            // 
            this.cbAPBEnabled.AutoSize = true;
            this.cbAPBEnabled.Checked = true;
            this.cbAPBEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAPBEnabled.Location = new System.Drawing.Point(39, 221);
            this.cbAPBEnabled.Name = "cbAPBEnabled";
            this.cbAPBEnabled.Size = new System.Drawing.Size(184, 17);
            this.cbAPBEnabled.TabIndex = 117;
            this.cbAPBEnabled.Text = "AntiPassBack kontrolü olsun mu?";
            this.cbAPBEnabled.UseVisualStyleBackColor = true;
            // 
            // cbAccessEnabled
            // 
            this.cbAccessEnabled.AutoSize = true;
            this.cbAccessEnabled.Checked = true;
            this.cbAccessEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAccessEnabled.Location = new System.Drawing.Point(39, 198);
            this.cbAccessEnabled.Name = "cbAccessEnabled";
            this.cbAccessEnabled.Size = new System.Drawing.Size(124, 17);
            this.cbAccessEnabled.TabIndex = 116;
            this.cbAccessEnabled.Text = "Kişi cihazda aktif mi?";
            this.cbAccessEnabled.UseVisualStyleBackColor = true;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(397, 76);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(109, 13);
            this.label46.TabIndex = 115;
            this.label46.Text = "Kartın Son. Kul. Tarihi";
            // 
            // edtEndDate
            // 
            this.edtEndDate.CustomFormat = " dd.MM.yyyy HH:mm:ss";
            this.edtEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.edtEndDate.Location = new System.Drawing.Point(400, 92);
            this.edtEndDate.Name = "edtEndDate";
            this.edtEndDate.Size = new System.Drawing.Size(81, 20);
            this.edtEndDate.TabIndex = 114;
            this.edtEndDate.Value = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(18, 118);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(28, 13);
            this.label45.TabIndex = 113;
            this.label45.Text = "Şifre";
            // 
            // sePassword
            // 
            this.sePassword.Location = new System.Drawing.Point(105, 116);
            this.sePassword.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.sePassword.Name = "sePassword";
            this.sePassword.Size = new System.Drawing.Size(70, 20);
            this.sePassword.TabIndex = 112;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(18, 92);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(26, 13);
            this.label44.TabIndex = 111;
            this.label44.Text = "Kod";
            // 
            // seCode
            // 
            this.seCode.Location = new System.Drawing.Point(105, 90);
            this.seCode.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.seCode.Name = "seCode";
            this.seCode.Size = new System.Drawing.Size(131, 20);
            this.seCode.TabIndex = 110;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(18, 66);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(62, 13);
            this.label37.TabIndex = 97;
            this.label37.Text = "Zaman Kısıt";
            // 
            // seAccMask1
            // 
            this.seAccMask1.Location = new System.Drawing.Point(105, 64);
            this.seAccMask1.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.seAccMask1.Name = "seAccMask1";
            this.seAccMask1.Size = new System.Drawing.Size(53, 20);
            this.seAccMask1.TabIndex = 95;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(16, 44);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(20, 13);
            this.label35.TabIndex = 92;
            this.label35.Text = "Ad";
            // 
            // edtName
            // 
            this.edtName.Location = new System.Drawing.Point(105, 38);
            this.edtName.MaxLength = 18;
            this.edtName.Name = "edtName";
            this.edtName.Size = new System.Drawing.Size(129, 20);
            this.edtName.TabIndex = 91;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(16, 19);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(18, 13);
            this.label34.TabIndex = 90;
            this.label34.Text = "ID";
            // 
            // edtCardID
            // 
            this.edtCardID.Location = new System.Drawing.Point(105, 13);
            this.edtCardID.MaxLength = 14;
            this.edtCardID.Name = "edtCardID";
            this.edtCardID.Size = new System.Drawing.Size(129, 20);
            this.edtCardID.TabIndex = 89;
            // 
            // tsInOutValues
            // 
            this.tsInOutValues.Controls.Add(this.label151);
            this.tsInOutValues.Controls.Add(this.numericUpDown63);
            this.tsInOutValues.Controls.Add(this.label150);
            this.tsInOutValues.Controls.Add(this.button42);
            this.tsInOutValues.Controls.Add(this.richTextBoxRecs);
            this.tsInOutValues.Controls.Add(this.groupBox4);
            this.tsInOutValues.Location = new System.Drawing.Point(4, 22);
            this.tsInOutValues.Name = "tsInOutValues";
            this.tsInOutValues.Padding = new System.Windows.Forms.Padding(3);
            this.tsInOutValues.Size = new System.Drawing.Size(1108, 629);
            this.tsInOutValues.TabIndex = 6;
            this.tsInOutValues.Text = "Giriş Çıkış Bilgileri";
            this.tsInOutValues.UseVisualStyleBackColor = true;
            // 
            // label151
            // 
            this.label151.AutoSize = true;
            this.label151.Location = new System.Drawing.Point(559, 93);
            this.label151.Name = "label151";
            this.label151.Size = new System.Drawing.Size(79, 13);
            this.label151.TabIndex = 114;
            this.label151.Text = "........................";
            // 
            // numericUpDown63
            // 
            this.numericUpDown63.Location = new System.Drawing.Point(560, 37);
            this.numericUpDown63.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericUpDown63.Name = "numericUpDown63";
            this.numericUpDown63.Size = new System.Drawing.Size(60, 20);
            this.numericUpDown63.TabIndex = 113;
            this.numericUpDown63.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // label150
            // 
            this.label150.AutoSize = true;
            this.label150.Location = new System.Drawing.Point(495, 41);
            this.label150.Name = "label150";
            this.label150.Size = new System.Drawing.Size(59, 13);
            this.label150.TabIndex = 112;
            this.label150.Text = "Başlangıç :";
            // 
            // button42
            // 
            this.button42.Location = new System.Drawing.Point(558, 63);
            this.button42.Name = "button42";
            this.button42.Size = new System.Drawing.Size(150, 23);
            this.button42.TabIndex = 54;
            this.button42.Text = "Test Kayıtları Oluştur";
            this.button42.UseVisualStyleBackColor = true;
            // 
            // richTextBoxRecs
            // 
            this.richTextBoxRecs.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.richTextBoxRecs.Location = new System.Drawing.Point(3, 293);
            this.richTextBoxRecs.Name = "richTextBoxRecs";
            this.richTextBoxRecs.Size = new System.Drawing.Size(1102, 333);
            this.richTextBoxRecs.TabIndex = 53;
            this.richTextBoxRecs.Text = "";
            this.richTextBoxRecs.WordWrap = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.edtHowManyRead);
            this.groupBox4.Controls.Add(this.edtStartRead);
            this.groupBox4.Controls.Add(this.label47);
            this.groupBox4.Controls.Add(this.label48);
            this.groupBox4.Controls.Add(this.btnTransferRecs);
            this.groupBox4.Controls.Add(this.btnReadRecs);
            this.groupBox4.Controls.Add(this.button11);
            this.groupBox4.Controls.Add(this.label49);
            this.groupBox4.Controls.Add(this.edtFilePath);
            this.groupBox4.Location = new System.Drawing.Point(5, 15);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(467, 123);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Cihazdan G/C Bilgilerini Transfer Etme";
            // 
            // edtHowManyRead
            // 
            this.edtHowManyRead.Location = new System.Drawing.Point(77, 88);
            this.edtHowManyRead.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.edtHowManyRead.Name = "edtHowManyRead";
            this.edtHowManyRead.Size = new System.Drawing.Size(60, 20);
            this.edtHowManyRead.TabIndex = 112;
            // 
            // edtStartRead
            // 
            this.edtStartRead.Location = new System.Drawing.Point(77, 62);
            this.edtStartRead.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.edtStartRead.Name = "edtStartRead";
            this.edtStartRead.Size = new System.Drawing.Size(60, 20);
            this.edtStartRead.TabIndex = 111;
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(12, 66);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(59, 13);
            this.label47.TabIndex = 109;
            this.label47.Text = "Başlangıç :";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(14, 91);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(60, 13);
            this.label48.TabIndex = 110;
            this.label48.Text = "Kaç Tane :";
            // 
            // btnTransferRecs
            // 
            this.btnTransferRecs.Location = new System.Drawing.Point(327, 94);
            this.btnTransferRecs.Name = "btnTransferRecs";
            this.btnTransferRecs.Size = new System.Drawing.Size(134, 23);
            this.btnTransferRecs.TabIndex = 108;
            this.btnTransferRecs.Text = "Verileri Transfer Et";
            this.btnTransferRecs.UseVisualStyleBackColor = true;
            this.btnTransferRecs.Click += new System.EventHandler(this.btnTransferRecs_Click);
            // 
            // btnReadRecs
            // 
            this.btnReadRecs.Location = new System.Drawing.Point(214, 94);
            this.btnReadRecs.Name = "btnReadRecs";
            this.btnReadRecs.Size = new System.Drawing.Size(107, 23);
            this.btnReadRecs.TabIndex = 107;
            this.btnReadRecs.Text = "Verileri Oku";
            this.btnReadRecs.UseVisualStyleBackColor = true;
            this.btnReadRecs.Click += new System.EventHandler(this.btnReadRecs_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(308, 33);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(24, 23);
            this.button11.TabIndex = 103;
            this.button11.Text = "...";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(11, 35);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(61, 13);
            this.label49.TabIndex = 102;
            this.label49.Text = "Dosya Yolu";
            // 
            // edtFilePath
            // 
            this.edtFilePath.Location = new System.Drawing.Point(77, 35);
            this.edtFilePath.Name = "edtFilePath";
            this.edtFilePath.Size = new System.Drawing.Size(227, 20);
            this.edtFilePath.TabIndex = 101;
            // 
            // tbpHgsGenelAyarlar
            // 
            this.tbpHgsGenelAyarlar.Controls.Add(this.btnDaireBul);
            this.tbpHgsGenelAyarlar.Controls.Add(this.btnDaireSil);
            this.tbpHgsGenelAyarlar.Controls.Add(this.groupBox20);
            this.tbpHgsGenelAyarlar.Controls.Add(this.txtHgsGenelAyarlarKartinSonKullanmaTarihi);
            this.tbpHgsGenelAyarlar.Controls.Add(this.label145);
            this.tbpHgsGenelAyarlar.Controls.Add(this.label144);
            this.tbpHgsGenelAyarlar.Controls.Add(this.label143);
            this.tbpHgsGenelAyarlar.Controls.Add(this.label142);
            this.tbpHgsGenelAyarlar.Controls.Add(this.label141);
            this.tbpHgsGenelAyarlar.Controls.Add(this.label140);
            this.tbpHgsGenelAyarlar.Controls.Add(this.label139);
            this.tbpHgsGenelAyarlar.Controls.Add(this.txtHgsGenelAyarlarArac);
            this.tbpHgsGenelAyarlar.Controls.Add(this.txtHgsGenelAyarlarDaireHak);
            this.tbpHgsGenelAyarlar.Controls.Add(this.txtHgsGenelAyarlarDaire);
            this.tbpHgsGenelAyarlar.Controls.Add(this.lblHGSIndexNo);
            this.tbpHgsGenelAyarlar.Controls.Add(this.txtHgsGenelAyarlarKartHGSAdi);
            this.tbpHgsGenelAyarlar.Controls.Add(this.txtHgsGenelAyarlarKartId);
            this.tbpHgsGenelAyarlar.Controls.Add(this.button38);
            this.tbpHgsGenelAyarlar.Controls.Add(this.labelHgsTanimliKisiSayisi);
            this.tbpHgsGenelAyarlar.Controls.Add(this.button37);
            this.tbpHgsGenelAyarlar.Controls.Add(this.btnHgsBul);
            this.tbpHgsGenelAyarlar.Controls.Add(this.btnHgsDegistir);
            this.tbpHgsGenelAyarlar.Controls.Add(this.btnHgsSil);
            this.tbpHgsGenelAyarlar.Controls.Add(this.btnHgsEkle);
            this.tbpHgsGenelAyarlar.Controls.Add(this.txtHgsGenelAyarlarKisitKontroluOlsunMu);
            this.tbpHgsGenelAyarlar.Controls.Add(this.txtHgsGenelAyarlarAntiPassBackKontroluOlsunMu);
            this.tbpHgsGenelAyarlar.Controls.Add(this.txtHgsGenelAyarlarKisiCihazdaAktifMi);
            this.tbpHgsGenelAyarlar.Controls.Add(this.label136);
            this.tbpHgsGenelAyarlar.Controls.Add(this.txtHgsGenelAyarlarPazar);
            this.tbpHgsGenelAyarlar.Controls.Add(this.txtHgsGenelAyarlarCumartesi);
            this.tbpHgsGenelAyarlar.Controls.Add(this.txtHgsGenelAyarlarCuma);
            this.tbpHgsGenelAyarlar.Controls.Add(this.txtHgsGenelAyarlarPersembe);
            this.tbpHgsGenelAyarlar.Controls.Add(this.txtHgsGenelAyarlarCarsamb);
            this.tbpHgsGenelAyarlar.Controls.Add(this.txtHgsGenelAyarlarSali);
            this.tbpHgsGenelAyarlar.Controls.Add(this.txtHgsGenelAyarlarPazartesi);
            this.tbpHgsGenelAyarlar.Controls.Add(this.label135);
            this.tbpHgsGenelAyarlar.Controls.Add(this.label134);
            this.tbpHgsGenelAyarlar.Controls.Add(this.label133);
            this.tbpHgsGenelAyarlar.Controls.Add(this.label132);
            this.tbpHgsGenelAyarlar.Controls.Add(this.label131);
            this.tbpHgsGenelAyarlar.Controls.Add(this.label130);
            this.tbpHgsGenelAyarlar.Controls.Add(this.groupBox18);
            this.tbpHgsGenelAyarlar.Location = new System.Drawing.Point(4, 22);
            this.tbpHgsGenelAyarlar.Name = "tbpHgsGenelAyarlar";
            this.tbpHgsGenelAyarlar.Padding = new System.Windows.Forms.Padding(3);
            this.tbpHgsGenelAyarlar.Size = new System.Drawing.Size(1108, 629);
            this.tbpHgsGenelAyarlar.TabIndex = 8;
            this.tbpHgsGenelAyarlar.Text = "Hgs Genel Ayarlar";
            this.tbpHgsGenelAyarlar.UseVisualStyleBackColor = true;
            this.tbpHgsGenelAyarlar.Click += new System.EventHandler(this.tbpHgsGenelAyarlar_Click);
            // 
            // btnDaireBul
            // 
            this.btnDaireBul.Location = new System.Drawing.Point(636, 303);
            this.btnDaireBul.Name = "btnDaireBul";
            this.btnDaireBul.Size = new System.Drawing.Size(103, 23);
            this.btnDaireBul.TabIndex = 64;
            this.btnDaireBul.Text = "Bul (Daire Araç)";
            this.btnDaireBul.UseVisualStyleBackColor = true;
            this.btnDaireBul.Click += new System.EventHandler(this.btnDaireBul_Click);
            // 
            // btnDaireSil
            // 
            this.btnDaireSil.Location = new System.Drawing.Point(559, 303);
            this.btnDaireSil.Name = "btnDaireSil";
            this.btnDaireSil.Size = new System.Drawing.Size(75, 23);
            this.btnDaireSil.TabIndex = 63;
            this.btnDaireSil.Text = "Sil (Daire Araç)";
            this.btnDaireSil.UseVisualStyleBackColor = true;
            this.btnDaireSil.Click += new System.EventHandler(this.btnDaireSil_Click);
            // 
            // groupBox20
            // 
            this.groupBox20.Controls.Add(this.btnDaireAracHakkiGonder);
            this.groupBox20.Controls.Add(this.btnDaireAracHakkiGetir);
            this.groupBox20.Controls.Add(this.txtDaireAracHakkiOtoparkHakki);
            this.groupBox20.Controls.Add(this.label106);
            this.groupBox20.Controls.Add(this.label33);
            this.groupBox20.Controls.Add(this.txtDaireAracHakkiOtoparkHakkiDaire);
            this.groupBox20.Location = new System.Drawing.Point(288, 341);
            this.groupBox20.Name = "groupBox20";
            this.groupBox20.Size = new System.Drawing.Size(451, 92);
            this.groupBox20.TabIndex = 62;
            this.groupBox20.TabStop = false;
            this.groupBox20.Text = " Daire Araç Hakkı Otopark Hakkı";
            // 
            // btnDaireAracHakkiGonder
            // 
            this.btnDaireAracHakkiGonder.Location = new System.Drawing.Point(370, 49);
            this.btnDaireAracHakkiGonder.Name = "btnDaireAracHakkiGonder";
            this.btnDaireAracHakkiGonder.Size = new System.Drawing.Size(75, 31);
            this.btnDaireAracHakkiGonder.TabIndex = 5;
            this.btnDaireAracHakkiGonder.Text = "Gönder";
            this.btnDaireAracHakkiGonder.UseVisualStyleBackColor = true;
            this.btnDaireAracHakkiGonder.Click += new System.EventHandler(this.btnDaireAracHakkiGonder_Click);
            // 
            // btnDaireAracHakkiGetir
            // 
            this.btnDaireAracHakkiGetir.Location = new System.Drawing.Point(370, 15);
            this.btnDaireAracHakkiGetir.Name = "btnDaireAracHakkiGetir";
            this.btnDaireAracHakkiGetir.Size = new System.Drawing.Size(75, 30);
            this.btnDaireAracHakkiGetir.TabIndex = 4;
            this.btnDaireAracHakkiGetir.Text = "Getir";
            this.btnDaireAracHakkiGetir.UseVisualStyleBackColor = true;
            this.btnDaireAracHakkiGetir.Click += new System.EventHandler(this.btnDaireAracHakkiGetir_Click);
            // 
            // txtDaireAracHakkiOtoparkHakki
            // 
            this.txtDaireAracHakkiOtoparkHakki.Location = new System.Drawing.Point(212, 33);
            this.txtDaireAracHakkiOtoparkHakki.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.txtDaireAracHakkiOtoparkHakki.Name = "txtDaireAracHakkiOtoparkHakki";
            this.txtDaireAracHakkiOtoparkHakki.Size = new System.Drawing.Size(60, 20);
            this.txtDaireAracHakkiOtoparkHakki.TabIndex = 3;
            // 
            // label106
            // 
            this.label106.AutoSize = true;
            this.label106.Location = new System.Drawing.Point(129, 38);
            this.label106.Name = "label106";
            this.label106.Size = new System.Drawing.Size(85, 13);
            this.label106.TabIndex = 2;
            this.label106.Text = "Otopark Hakkı : ";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(10, 40);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(41, 13);
            this.label33.TabIndex = 1;
            this.label33.Text = "Daire : ";
            // 
            // txtDaireAracHakkiOtoparkHakkiDaire
            // 
            this.txtDaireAracHakkiOtoparkHakkiDaire.Location = new System.Drawing.Point(60, 36);
            this.txtDaireAracHakkiOtoparkHakkiDaire.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.txtDaireAracHakkiOtoparkHakkiDaire.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtDaireAracHakkiOtoparkHakkiDaire.Name = "txtDaireAracHakkiOtoparkHakkiDaire";
            this.txtDaireAracHakkiOtoparkHakkiDaire.Size = new System.Drawing.Size(60, 20);
            this.txtDaireAracHakkiOtoparkHakkiDaire.TabIndex = 0;
            this.txtDaireAracHakkiOtoparkHakkiDaire.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtHgsGenelAyarlarKartinSonKullanmaTarihi
            // 
            this.txtHgsGenelAyarlarKartinSonKullanmaTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtHgsGenelAyarlarKartinSonKullanmaTarihi.Location = new System.Drawing.Point(423, 194);
            this.txtHgsGenelAyarlarKartinSonKullanmaTarihi.Name = "txtHgsGenelAyarlarKartinSonKullanmaTarihi";
            this.txtHgsGenelAyarlarKartinSonKullanmaTarihi.Size = new System.Drawing.Size(107, 20);
            this.txtHgsGenelAyarlarKartinSonKullanmaTarihi.TabIndex = 61;
            // 
            // label145
            // 
            this.label145.AutoSize = true;
            this.label145.Location = new System.Drawing.Point(694, 146);
            this.label145.Name = "label145";
            this.label145.Size = new System.Drawing.Size(34, 13);
            this.label145.TabIndex = 60;
            this.label145.Text = "Pazar";
            // 
            // label144
            // 
            this.label144.AutoSize = true;
            this.label144.Location = new System.Drawing.Point(637, 146);
            this.label144.Name = "label144";
            this.label144.Size = new System.Drawing.Size(53, 13);
            this.label144.TabIndex = 59;
            this.label144.Text = "Cumartesi";
            // 
            // label143
            // 
            this.label143.AutoSize = true;
            this.label143.Location = new System.Drawing.Point(581, 146);
            this.label143.Name = "label143";
            this.label143.Size = new System.Drawing.Size(34, 13);
            this.label143.TabIndex = 58;
            this.label143.Text = "Cuma";
            // 
            // label142
            // 
            this.label142.AutoSize = true;
            this.label142.Location = new System.Drawing.Point(529, 146);
            this.label142.Name = "label142";
            this.label142.Size = new System.Drawing.Size(54, 13);
            this.label142.TabIndex = 57;
            this.label142.Text = "Perşembe";
            // 
            // label141
            // 
            this.label141.AutoSize = true;
            this.label141.Location = new System.Drawing.Point(475, 146);
            this.label141.Name = "label141";
            this.label141.Size = new System.Drawing.Size(54, 13);
            this.label141.TabIndex = 56;
            this.label141.Text = "Çarşamba";
            // 
            // label140
            // 
            this.label140.AutoSize = true;
            this.label140.Location = new System.Drawing.Point(424, 146);
            this.label140.Name = "label140";
            this.label140.Size = new System.Drawing.Size(24, 13);
            this.label140.TabIndex = 55;
            this.label140.Text = "Salı";
            // 
            // label139
            // 
            this.label139.AutoSize = true;
            this.label139.Location = new System.Drawing.Point(368, 146);
            this.label139.Name = "label139";
            this.label139.Size = new System.Drawing.Size(50, 13);
            this.label139.TabIndex = 54;
            this.label139.Text = "Pazartesi";
            // 
            // txtHgsGenelAyarlarArac
            // 
            this.txtHgsGenelAyarlarArac.Location = new System.Drawing.Point(381, 110);
            this.txtHgsGenelAyarlarArac.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.txtHgsGenelAyarlarArac.Name = "txtHgsGenelAyarlarArac";
            this.txtHgsGenelAyarlarArac.Size = new System.Drawing.Size(70, 20);
            this.txtHgsGenelAyarlarArac.TabIndex = 53;
            // 
            // txtHgsGenelAyarlarDaireHak
            // 
            this.txtHgsGenelAyarlarDaireHak.Location = new System.Drawing.Point(511, 84);
            this.txtHgsGenelAyarlarDaireHak.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.txtHgsGenelAyarlarDaireHak.Name = "txtHgsGenelAyarlarDaireHak";
            this.txtHgsGenelAyarlarDaireHak.Size = new System.Drawing.Size(70, 20);
            this.txtHgsGenelAyarlarDaireHak.TabIndex = 52;
            this.txtHgsGenelAyarlarDaireHak.Visible = false;
            // 
            // txtHgsGenelAyarlarDaire
            // 
            this.txtHgsGenelAyarlarDaire.Location = new System.Drawing.Point(381, 84);
            this.txtHgsGenelAyarlarDaire.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.txtHgsGenelAyarlarDaire.Name = "txtHgsGenelAyarlarDaire";
            this.txtHgsGenelAyarlarDaire.Size = new System.Drawing.Size(70, 20);
            this.txtHgsGenelAyarlarDaire.TabIndex = 51;
            // 
            // lblHGSIndexNo
            // 
            this.lblHGSIndexNo.AutoSize = true;
            this.lblHGSIndexNo.Location = new System.Drawing.Point(484, 33);
            this.lblHGSIndexNo.Name = "lblHGSIndexNo";
            this.lblHGSIndexNo.Size = new System.Drawing.Size(46, 13);
            this.lblHGSIndexNo.TabIndex = 50;
            this.lblHGSIndexNo.Text = ".............";
            // 
            // txtHgsGenelAyarlarKartHGSAdi
            // 
            this.txtHgsGenelAyarlarKartHGSAdi.Location = new System.Drawing.Point(381, 55);
            this.txtHgsGenelAyarlarKartHGSAdi.MaxLength = 18;
            this.txtHgsGenelAyarlarKartHGSAdi.Name = "txtHgsGenelAyarlarKartHGSAdi";
            this.txtHgsGenelAyarlarKartHGSAdi.Size = new System.Drawing.Size(200, 20);
            this.txtHgsGenelAyarlarKartHGSAdi.TabIndex = 49;
            // 
            // txtHgsGenelAyarlarKartId
            // 
            this.txtHgsGenelAyarlarKartId.Location = new System.Drawing.Point(381, 27);
            this.txtHgsGenelAyarlarKartId.Name = "txtHgsGenelAyarlarKartId";
            this.txtHgsGenelAyarlarKartId.Size = new System.Drawing.Size(100, 20);
            this.txtHgsGenelAyarlarKartId.TabIndex = 48;
            // 
            // button38
            // 
            this.button38.Location = new System.Drawing.Point(606, 23);
            this.button38.Name = "button38";
            this.button38.Size = new System.Drawing.Size(138, 23);
            this.button38.TabIndex = 47;
            this.button38.Text = "Tanımlı Tüm Kişileri Sil";
            this.button38.UseVisualStyleBackColor = true;
            this.button38.Click += new System.EventHandler(this.button38_Click);
            // 
            // labelHgsTanimliKisiSayisi
            // 
            this.labelHgsTanimliKisiSayisi.AutoSize = true;
            this.labelHgsTanimliKisiSayisi.Location = new System.Drawing.Point(420, 459);
            this.labelHgsTanimliKisiSayisi.Name = "labelHgsTanimliKisiSayisi";
            this.labelHgsTanimliKisiSayisi.Size = new System.Drawing.Size(16, 13);
            this.labelHgsTanimliKisiSayisi.TabIndex = 46;
            this.labelHgsTanimliKisiSayisi.Text = "...";
            // 
            // button37
            // 
            this.button37.Location = new System.Drawing.Point(288, 454);
            this.button37.Name = "button37";
            this.button37.Size = new System.Drawing.Size(109, 23);
            this.button37.TabIndex = 45;
            this.button37.Text = "Tanımlı Kart Sayısı";
            this.button37.UseVisualStyleBackColor = true;
            this.button37.Click += new System.EventHandler(this.button37_Click);
            // 
            // btnHgsBul
            // 
            this.btnHgsBul.Location = new System.Drawing.Point(493, 303);
            this.btnHgsBul.Name = "btnHgsBul";
            this.btnHgsBul.Size = new System.Drawing.Size(65, 23);
            this.btnHgsBul.TabIndex = 44;
            this.btnHgsBul.Text = "Bul";
            this.btnHgsBul.UseVisualStyleBackColor = true;
            this.btnHgsBul.Click += new System.EventHandler(this.btnHgsBul_Click);
            // 
            // btnHgsDegistir
            // 
            this.btnHgsDegistir.Location = new System.Drawing.Point(417, 303);
            this.btnHgsDegistir.Name = "btnHgsDegistir";
            this.btnHgsDegistir.Size = new System.Drawing.Size(75, 23);
            this.btnHgsDegistir.TabIndex = 43;
            this.btnHgsDegistir.Text = "Değiştir";
            this.btnHgsDegistir.UseVisualStyleBackColor = true;
            this.btnHgsDegistir.Click += new System.EventHandler(this.btnHgsDegistir_Click);
            // 
            // btnHgsSil
            // 
            this.btnHgsSil.Location = new System.Drawing.Point(352, 303);
            this.btnHgsSil.Name = "btnHgsSil";
            this.btnHgsSil.Size = new System.Drawing.Size(63, 23);
            this.btnHgsSil.TabIndex = 42;
            this.btnHgsSil.Text = "Sil";
            this.btnHgsSil.UseVisualStyleBackColor = true;
            this.btnHgsSil.Click += new System.EventHandler(this.btnHgsSil_Click);
            // 
            // btnHgsEkle
            // 
            this.btnHgsEkle.Location = new System.Drawing.Point(288, 303);
            this.btnHgsEkle.Name = "btnHgsEkle";
            this.btnHgsEkle.Size = new System.Drawing.Size(62, 23);
            this.btnHgsEkle.TabIndex = 41;
            this.btnHgsEkle.Text = "Ekle";
            this.btnHgsEkle.UseVisualStyleBackColor = true;
            this.btnHgsEkle.Click += new System.EventHandler(this.btnHgsEkle_Click);
            // 
            // txtHgsGenelAyarlarKisitKontroluOlsunMu
            // 
            this.txtHgsGenelAyarlarKisitKontroluOlsunMu.AutoSize = true;
            this.txtHgsGenelAyarlarKisitKontroluOlsunMu.Checked = true;
            this.txtHgsGenelAyarlarKisitKontroluOlsunMu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.txtHgsGenelAyarlarKisitKontroluOlsunMu.Location = new System.Drawing.Point(405, 277);
            this.txtHgsGenelAyarlarKisitKontroluOlsunMu.Name = "txtHgsGenelAyarlarKisitKontroluOlsunMu";
            this.txtHgsGenelAyarlarKisitKontroluOlsunMu.Size = new System.Drawing.Size(172, 17);
            this.txtHgsGenelAyarlarKisitKontroluOlsunMu.TabIndex = 40;
            this.txtHgsGenelAyarlarKisitKontroluOlsunMu.Text = "Zaman kısıt kontrolü olsun mu?";
            this.txtHgsGenelAyarlarKisitKontroluOlsunMu.UseVisualStyleBackColor = true;
            // 
            // txtHgsGenelAyarlarAntiPassBackKontroluOlsunMu
            // 
            this.txtHgsGenelAyarlarAntiPassBackKontroluOlsunMu.AutoSize = true;
            this.txtHgsGenelAyarlarAntiPassBackKontroluOlsunMu.Checked = true;
            this.txtHgsGenelAyarlarAntiPassBackKontroluOlsunMu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.txtHgsGenelAyarlarAntiPassBackKontroluOlsunMu.Location = new System.Drawing.Point(405, 253);
            this.txtHgsGenelAyarlarAntiPassBackKontroluOlsunMu.Name = "txtHgsGenelAyarlarAntiPassBackKontroluOlsunMu";
            this.txtHgsGenelAyarlarAntiPassBackKontroluOlsunMu.Size = new System.Drawing.Size(184, 17);
            this.txtHgsGenelAyarlarAntiPassBackKontroluOlsunMu.TabIndex = 39;
            this.txtHgsGenelAyarlarAntiPassBackKontroluOlsunMu.Text = "AntiPassBack kontrolü olsun mu?";
            this.txtHgsGenelAyarlarAntiPassBackKontroluOlsunMu.UseVisualStyleBackColor = true;
            // 
            // txtHgsGenelAyarlarKisiCihazdaAktifMi
            // 
            this.txtHgsGenelAyarlarKisiCihazdaAktifMi.AutoSize = true;
            this.txtHgsGenelAyarlarKisiCihazdaAktifMi.Checked = true;
            this.txtHgsGenelAyarlarKisiCihazdaAktifMi.CheckState = System.Windows.Forms.CheckState.Checked;
            this.txtHgsGenelAyarlarKisiCihazdaAktifMi.Location = new System.Drawing.Point(405, 230);
            this.txtHgsGenelAyarlarKisiCihazdaAktifMi.Name = "txtHgsGenelAyarlarKisiCihazdaAktifMi";
            this.txtHgsGenelAyarlarKisiCihazdaAktifMi.Size = new System.Drawing.Size(124, 17);
            this.txtHgsGenelAyarlarKisiCihazdaAktifMi.TabIndex = 38;
            this.txtHgsGenelAyarlarKisiCihazdaAktifMi.Text = "Kişi cihazda aktif mi?";
            this.txtHgsGenelAyarlarKisiCihazdaAktifMi.UseVisualStyleBackColor = true;
            // 
            // label136
            // 
            this.label136.AutoSize = true;
            this.label136.Location = new System.Drawing.Point(305, 202);
            this.label136.Name = "label136";
            this.label136.Size = new System.Drawing.Size(109, 13);
            this.label136.TabIndex = 37;
            this.label136.Text = "Kartın Son. Kul. Tarihi";
            // 
            // txtHgsGenelAyarlarPazar
            // 
            this.txtHgsGenelAyarlarPazar.Location = new System.Drawing.Point(696, 162);
            this.txtHgsGenelAyarlarPazar.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.txtHgsGenelAyarlarPazar.Name = "txtHgsGenelAyarlarPazar";
            this.txtHgsGenelAyarlarPazar.Size = new System.Drawing.Size(43, 20);
            this.txtHgsGenelAyarlarPazar.TabIndex = 36;
            // 
            // txtHgsGenelAyarlarCumartesi
            // 
            this.txtHgsGenelAyarlarCumartesi.Location = new System.Drawing.Point(640, 162);
            this.txtHgsGenelAyarlarCumartesi.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.txtHgsGenelAyarlarCumartesi.Name = "txtHgsGenelAyarlarCumartesi";
            this.txtHgsGenelAyarlarCumartesi.Size = new System.Drawing.Size(50, 20);
            this.txtHgsGenelAyarlarCumartesi.TabIndex = 35;
            // 
            // txtHgsGenelAyarlarCuma
            // 
            this.txtHgsGenelAyarlarCuma.Location = new System.Drawing.Point(584, 162);
            this.txtHgsGenelAyarlarCuma.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.txtHgsGenelAyarlarCuma.Name = "txtHgsGenelAyarlarCuma";
            this.txtHgsGenelAyarlarCuma.Size = new System.Drawing.Size(50, 20);
            this.txtHgsGenelAyarlarCuma.TabIndex = 34;
            // 
            // txtHgsGenelAyarlarPersembe
            // 
            this.txtHgsGenelAyarlarPersembe.Location = new System.Drawing.Point(532, 162);
            this.txtHgsGenelAyarlarPersembe.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.txtHgsGenelAyarlarPersembe.Name = "txtHgsGenelAyarlarPersembe";
            this.txtHgsGenelAyarlarPersembe.Size = new System.Drawing.Size(46, 20);
            this.txtHgsGenelAyarlarPersembe.TabIndex = 33;
            // 
            // txtHgsGenelAyarlarCarsamb
            // 
            this.txtHgsGenelAyarlarCarsamb.Location = new System.Drawing.Point(478, 162);
            this.txtHgsGenelAyarlarCarsamb.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.txtHgsGenelAyarlarCarsamb.Name = "txtHgsGenelAyarlarCarsamb";
            this.txtHgsGenelAyarlarCarsamb.Size = new System.Drawing.Size(45, 20);
            this.txtHgsGenelAyarlarCarsamb.TabIndex = 32;
            // 
            // txtHgsGenelAyarlarSali
            // 
            this.txtHgsGenelAyarlarSali.Location = new System.Drawing.Point(424, 162);
            this.txtHgsGenelAyarlarSali.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.txtHgsGenelAyarlarSali.Name = "txtHgsGenelAyarlarSali";
            this.txtHgsGenelAyarlarSali.Size = new System.Drawing.Size(48, 20);
            this.txtHgsGenelAyarlarSali.TabIndex = 31;
            // 
            // txtHgsGenelAyarlarPazartesi
            // 
            this.txtHgsGenelAyarlarPazartesi.Location = new System.Drawing.Point(371, 162);
            this.txtHgsGenelAyarlarPazartesi.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.txtHgsGenelAyarlarPazartesi.Name = "txtHgsGenelAyarlarPazartesi";
            this.txtHgsGenelAyarlarPazartesi.Size = new System.Drawing.Size(47, 20);
            this.txtHgsGenelAyarlarPazartesi.TabIndex = 30;
            // 
            // label135
            // 
            this.label135.AutoSize = true;
            this.label135.Location = new System.Drawing.Point(305, 169);
            this.label135.Name = "label135";
            this.label135.Size = new System.Drawing.Size(62, 13);
            this.label135.TabIndex = 7;
            this.label135.Text = "Zaman Kısıt";
            // 
            // label134
            // 
            this.label134.AutoSize = true;
            this.label134.Location = new System.Drawing.Point(454, 86);
            this.label134.Name = "label134";
            this.label134.Size = new System.Drawing.Size(55, 13);
            this.label134.TabIndex = 6;
            this.label134.Text = "Daire Hak";
            this.label134.Visible = false;
            // 
            // label133
            // 
            this.label133.AutoSize = true;
            this.label133.Location = new System.Drawing.Point(305, 120);
            this.label133.Name = "label133";
            this.label133.Size = new System.Drawing.Size(29, 13);
            this.label133.TabIndex = 5;
            this.label133.Text = "Araç";
            // 
            // label132
            // 
            this.label132.AutoSize = true;
            this.label132.Location = new System.Drawing.Point(305, 91);
            this.label132.Name = "label132";
            this.label132.Size = new System.Drawing.Size(32, 13);
            this.label132.TabIndex = 4;
            this.label132.Text = "Daire";
            // 
            // label131
            // 
            this.label131.AutoSize = true;
            this.label131.Location = new System.Drawing.Point(305, 62);
            this.label131.Name = "label131";
            this.label131.Size = new System.Drawing.Size(34, 13);
            this.label131.TabIndex = 3;
            this.label131.Text = "Plaka";
            // 
            // label130
            // 
            this.label130.AutoSize = true;
            this.label130.Location = new System.Drawing.Point(305, 34);
            this.label130.Name = "label130";
            this.label130.Size = new System.Drawing.Size(38, 13);
            this.label130.TabIndex = 2;
            this.label130.Text = "Kart Id";
            // 
            // groupBox18
            // 
            this.groupBox18.Controls.Add(this.label181);
            this.groupBox18.Controls.Add(this.label180);
            this.groupBox18.Controls.Add(this.txtHgsGenelAyarlarAppType);
            this.groupBox18.Controls.Add(this.label137);
            this.groupBox18.Controls.Add(this.txtHgsGenelAyarlarArdisikGecisSuresi);
            this.groupBox18.Controls.Add(this.txtHgsGenelAyarlarAracDaireSayisi);
            this.groupBox18.Controls.Add(this.txtHgsGenelAyarlarAntenKtanima);
            this.groupBox18.Controls.Add(this.txtHgsGenelAyarlarAntenGuc2);
            this.groupBox18.Controls.Add(this.txtHgsGenelAyarlarAntenGuc1);
            this.groupBox18.Controls.Add(this.txtHgsGenelAyarlarDiziArdisikKontrol2);
            this.groupBox18.Controls.Add(this.txtHgsGenelAyarlarDiziArdisikKontrol1);
            this.groupBox18.Controls.Add(this.txtHgsGenelAyarlarProgramModu);
            this.groupBox18.Controls.Add(this.txtHgsGenelAyarlarTransistorCikisi2);
            this.groupBox18.Controls.Add(this.txtHgsGenelAyarlarTransistorCikisi1);
            this.groupBox18.Controls.Add(this.txtHgsGenelAyarlarTagId);
            this.groupBox18.Controls.Add(this.txtHgsGenelAyarlarKartBaslangici);
            this.groupBox18.Controls.Add(this.txtHgsGenelAyarlarSeriPaketBoyutu);
            this.groupBox18.Controls.Add(this.btnHgsGenelAyarlariGonder);
            this.groupBox18.Controls.Add(this.btnHgsGenelAyarlariGetir);
            this.groupBox18.Controls.Add(this.label129);
            this.groupBox18.Controls.Add(this.label128);
            this.groupBox18.Controls.Add(this.label127);
            this.groupBox18.Controls.Add(this.label126);
            this.groupBox18.Controls.Add(this.label125);
            this.groupBox18.Controls.Add(this.txtHgsGenelAyarlarZamanKisitEtkin);
            this.groupBox18.Controls.Add(this.label124);
            this.groupBox18.Controls.Add(this.label123);
            this.groupBox18.Controls.Add(this.label122);
            this.groupBox18.Controls.Add(this.label121);
            this.groupBox18.Controls.Add(this.label120);
            this.groupBox18.Controls.Add(this.label119);
            this.groupBox18.Controls.Add(this.label118);
            this.groupBox18.Controls.Add(this.label117);
            this.groupBox18.Location = new System.Drawing.Point(8, 12);
            this.groupBox18.Name = "groupBox18";
            this.groupBox18.Size = new System.Drawing.Size(273, 471);
            this.groupBox18.TabIndex = 1;
            this.groupBox18.TabStop = false;
            this.groupBox18.Text = " HGS Genel Ayarları ";
            // 
            // label181
            // 
            this.label181.AutoSize = true;
            this.label181.Location = new System.Drawing.Point(202, 232);
            this.label181.Name = "label181";
            this.label181.Size = new System.Drawing.Size(18, 13);
            this.label181.TabIndex = 45;
            this.label181.Text = "sn";
            // 
            // label180
            // 
            this.label180.AutoSize = true;
            this.label180.Location = new System.Drawing.Point(202, 200);
            this.label180.Name = "label180";
            this.label180.Size = new System.Drawing.Size(18, 13);
            this.label180.TabIndex = 44;
            this.label180.Text = "sn";
            // 
            // txtHgsGenelAyarlarAppType
            // 
            this.txtHgsGenelAyarlarAppType.Location = new System.Drawing.Point(138, 404);
            this.txtHgsGenelAyarlarAppType.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.txtHgsGenelAyarlarAppType.Name = "txtHgsGenelAyarlarAppType";
            this.txtHgsGenelAyarlarAppType.Size = new System.Drawing.Size(57, 20);
            this.txtHgsGenelAyarlarAppType.TabIndex = 43;
            this.txtHgsGenelAyarlarAppType.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // label137
            // 
            this.label137.AutoSize = true;
            this.label137.Location = new System.Drawing.Point(6, 409);
            this.label137.Name = "label137";
            this.label137.Size = new System.Drawing.Size(62, 13);
            this.label137.TabIndex = 42;
            this.label137.Text = "App Type : ";
            // 
            // txtHgsGenelAyarlarArdisikGecisSuresi
            // 
            this.txtHgsGenelAyarlarArdisikGecisSuresi.Location = new System.Drawing.Point(138, 379);
            this.txtHgsGenelAyarlarArdisikGecisSuresi.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.txtHgsGenelAyarlarArdisikGecisSuresi.Name = "txtHgsGenelAyarlarArdisikGecisSuresi";
            this.txtHgsGenelAyarlarArdisikGecisSuresi.Size = new System.Drawing.Size(57, 20);
            this.txtHgsGenelAyarlarArdisikGecisSuresi.TabIndex = 41;
            this.txtHgsGenelAyarlarArdisikGecisSuresi.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // txtHgsGenelAyarlarAracDaireSayisi
            // 
            this.txtHgsGenelAyarlarAracDaireSayisi.Location = new System.Drawing.Point(138, 354);
            this.txtHgsGenelAyarlarAracDaireSayisi.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.txtHgsGenelAyarlarAracDaireSayisi.Name = "txtHgsGenelAyarlarAracDaireSayisi";
            this.txtHgsGenelAyarlarAracDaireSayisi.Size = new System.Drawing.Size(57, 20);
            this.txtHgsGenelAyarlarAracDaireSayisi.TabIndex = 40;
            this.txtHgsGenelAyarlarAracDaireSayisi.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // txtHgsGenelAyarlarAntenKtanima
            // 
            this.txtHgsGenelAyarlarAntenKtanima.Location = new System.Drawing.Point(138, 329);
            this.txtHgsGenelAyarlarAntenKtanima.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.txtHgsGenelAyarlarAntenKtanima.Name = "txtHgsGenelAyarlarAntenKtanima";
            this.txtHgsGenelAyarlarAntenKtanima.Size = new System.Drawing.Size(57, 20);
            this.txtHgsGenelAyarlarAntenKtanima.TabIndex = 39;
            this.txtHgsGenelAyarlarAntenKtanima.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // txtHgsGenelAyarlarAntenGuc2
            // 
            this.txtHgsGenelAyarlarAntenGuc2.Location = new System.Drawing.Point(138, 304);
            this.txtHgsGenelAyarlarAntenGuc2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.txtHgsGenelAyarlarAntenGuc2.Name = "txtHgsGenelAyarlarAntenGuc2";
            this.txtHgsGenelAyarlarAntenGuc2.Size = new System.Drawing.Size(57, 20);
            this.txtHgsGenelAyarlarAntenGuc2.TabIndex = 38;
            this.txtHgsGenelAyarlarAntenGuc2.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // txtHgsGenelAyarlarAntenGuc1
            // 
            this.txtHgsGenelAyarlarAntenGuc1.Location = new System.Drawing.Point(138, 279);
            this.txtHgsGenelAyarlarAntenGuc1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.txtHgsGenelAyarlarAntenGuc1.Name = "txtHgsGenelAyarlarAntenGuc1";
            this.txtHgsGenelAyarlarAntenGuc1.Size = new System.Drawing.Size(57, 20);
            this.txtHgsGenelAyarlarAntenGuc1.TabIndex = 37;
            this.txtHgsGenelAyarlarAntenGuc1.Value = new decimal(new int[] {
            14,
            0,
            0,
            0});
            // 
            // txtHgsGenelAyarlarDiziArdisikKontrol2
            // 
            this.txtHgsGenelAyarlarDiziArdisikKontrol2.Location = new System.Drawing.Point(138, 228);
            this.txtHgsGenelAyarlarDiziArdisikKontrol2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.txtHgsGenelAyarlarDiziArdisikKontrol2.Name = "txtHgsGenelAyarlarDiziArdisikKontrol2";
            this.txtHgsGenelAyarlarDiziArdisikKontrol2.Size = new System.Drawing.Size(57, 20);
            this.txtHgsGenelAyarlarDiziArdisikKontrol2.TabIndex = 36;
            this.txtHgsGenelAyarlarDiziArdisikKontrol2.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // txtHgsGenelAyarlarDiziArdisikKontrol1
            // 
            this.txtHgsGenelAyarlarDiziArdisikKontrol1.Location = new System.Drawing.Point(138, 196);
            this.txtHgsGenelAyarlarDiziArdisikKontrol1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.txtHgsGenelAyarlarDiziArdisikKontrol1.Name = "txtHgsGenelAyarlarDiziArdisikKontrol1";
            this.txtHgsGenelAyarlarDiziArdisikKontrol1.Size = new System.Drawing.Size(57, 20);
            this.txtHgsGenelAyarlarDiziArdisikKontrol1.TabIndex = 35;
            this.txtHgsGenelAyarlarDiziArdisikKontrol1.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // txtHgsGenelAyarlarProgramModu
            // 
            this.txtHgsGenelAyarlarProgramModu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtHgsGenelAyarlarProgramModu.FormattingEnabled = true;
            this.txtHgsGenelAyarlarProgramModu.Items.AddRange(new object[] {
            "Tek Anten",
            "Çift Anten Tek Geçiş",
            "Çift Anten Çift Geçiş"});
            this.txtHgsGenelAyarlarProgramModu.Location = new System.Drawing.Point(138, 168);
            this.txtHgsGenelAyarlarProgramModu.Name = "txtHgsGenelAyarlarProgramModu";
            this.txtHgsGenelAyarlarProgramModu.Size = new System.Drawing.Size(129, 21);
            this.txtHgsGenelAyarlarProgramModu.TabIndex = 34;
            // 
            // txtHgsGenelAyarlarTransistorCikisi2
            // 
            this.txtHgsGenelAyarlarTransistorCikisi2.Location = new System.Drawing.Point(138, 138);
            this.txtHgsGenelAyarlarTransistorCikisi2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.txtHgsGenelAyarlarTransistorCikisi2.Name = "txtHgsGenelAyarlarTransistorCikisi2";
            this.txtHgsGenelAyarlarTransistorCikisi2.Size = new System.Drawing.Size(57, 20);
            this.txtHgsGenelAyarlarTransistorCikisi2.TabIndex = 33;
            this.txtHgsGenelAyarlarTransistorCikisi2.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // txtHgsGenelAyarlarTransistorCikisi1
            // 
            this.txtHgsGenelAyarlarTransistorCikisi1.Location = new System.Drawing.Point(138, 109);
            this.txtHgsGenelAyarlarTransistorCikisi1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.txtHgsGenelAyarlarTransistorCikisi1.Name = "txtHgsGenelAyarlarTransistorCikisi1";
            this.txtHgsGenelAyarlarTransistorCikisi1.Size = new System.Drawing.Size(57, 20);
            this.txtHgsGenelAyarlarTransistorCikisi1.TabIndex = 32;
            this.txtHgsGenelAyarlarTransistorCikisi1.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // txtHgsGenelAyarlarTagId
            // 
            this.txtHgsGenelAyarlarTagId.Location = new System.Drawing.Point(138, 79);
            this.txtHgsGenelAyarlarTagId.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.txtHgsGenelAyarlarTagId.Name = "txtHgsGenelAyarlarTagId";
            this.txtHgsGenelAyarlarTagId.Size = new System.Drawing.Size(57, 20);
            this.txtHgsGenelAyarlarTagId.TabIndex = 31;
            this.txtHgsGenelAyarlarTagId.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // txtHgsGenelAyarlarKartBaslangici
            // 
            this.txtHgsGenelAyarlarKartBaslangici.Location = new System.Drawing.Point(138, 50);
            this.txtHgsGenelAyarlarKartBaslangici.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.txtHgsGenelAyarlarKartBaslangici.Name = "txtHgsGenelAyarlarKartBaslangici";
            this.txtHgsGenelAyarlarKartBaslangici.Size = new System.Drawing.Size(57, 20);
            this.txtHgsGenelAyarlarKartBaslangici.TabIndex = 30;
            this.txtHgsGenelAyarlarKartBaslangici.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // txtHgsGenelAyarlarSeriPaketBoyutu
            // 
            this.txtHgsGenelAyarlarSeriPaketBoyutu.Location = new System.Drawing.Point(138, 22);
            this.txtHgsGenelAyarlarSeriPaketBoyutu.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.txtHgsGenelAyarlarSeriPaketBoyutu.Name = "txtHgsGenelAyarlarSeriPaketBoyutu";
            this.txtHgsGenelAyarlarSeriPaketBoyutu.Size = new System.Drawing.Size(57, 20);
            this.txtHgsGenelAyarlarSeriPaketBoyutu.TabIndex = 29;
            this.txtHgsGenelAyarlarSeriPaketBoyutu.Value = new decimal(new int[] {
            14,
            0,
            0,
            0});
            // 
            // btnHgsGenelAyarlariGonder
            // 
            this.btnHgsGenelAyarlariGonder.Location = new System.Drawing.Point(135, 432);
            this.btnHgsGenelAyarlariGonder.Name = "btnHgsGenelAyarlariGonder";
            this.btnHgsGenelAyarlariGonder.Size = new System.Drawing.Size(132, 31);
            this.btnHgsGenelAyarlariGonder.TabIndex = 15;
            this.btnHgsGenelAyarlariGonder.Text = "Gönder";
            this.btnHgsGenelAyarlariGonder.UseVisualStyleBackColor = true;
            this.btnHgsGenelAyarlariGonder.Click += new System.EventHandler(this.btnHgsGenelAyarlariGonder_Click);
            // 
            // btnHgsGenelAyarlariGetir
            // 
            this.btnHgsGenelAyarlariGetir.Location = new System.Drawing.Point(9, 432);
            this.btnHgsGenelAyarlariGetir.Name = "btnHgsGenelAyarlariGetir";
            this.btnHgsGenelAyarlariGetir.Size = new System.Drawing.Size(120, 32);
            this.btnHgsGenelAyarlariGetir.TabIndex = 14;
            this.btnHgsGenelAyarlariGetir.Text = "Getir";
            this.btnHgsGenelAyarlariGetir.UseVisualStyleBackColor = true;
            this.btnHgsGenelAyarlariGetir.Click += new System.EventHandler(this.btnHgsGenelAyarlariGetir_Click);
            // 
            // label129
            // 
            this.label129.AutoSize = true;
            this.label129.Location = new System.Drawing.Point(6, 385);
            this.label129.Name = "label129";
            this.label129.Size = new System.Drawing.Size(100, 13);
            this.label129.TabIndex = 13;
            this.label129.Text = "Ardışık Geçiş Süresi";
            // 
            // label128
            // 
            this.label128.AutoSize = true;
            this.label128.Location = new System.Drawing.Point(4, 358);
            this.label128.Name = "label128";
            this.label128.Size = new System.Drawing.Size(114, 13);
            this.label128.TabIndex = 12;
            this.label128.Text = "Vars. Daire Araç Sayısı";
            // 
            // label127
            // 
            this.label127.AutoSize = true;
            this.label127.Location = new System.Drawing.Point(6, 332);
            this.label127.Name = "label127";
            this.label127.Size = new System.Drawing.Size(112, 13);
            this.label127.TabIndex = 11;
            this.label127.Text = "Anten Güç K. Tanıtma";
            // 
            // label126
            // 
            this.label126.AutoSize = true;
            this.label126.Location = new System.Drawing.Point(6, 308);
            this.label126.Name = "label126";
            this.label126.Size = new System.Drawing.Size(67, 13);
            this.label126.TabIndex = 10;
            this.label126.Text = "Anten Güç 2";
            // 
            // label125
            // 
            this.label125.AutoSize = true;
            this.label125.Location = new System.Drawing.Point(6, 286);
            this.label125.Name = "label125";
            this.label125.Size = new System.Drawing.Size(67, 13);
            this.label125.TabIndex = 9;
            this.label125.Text = "Anten Güç 1";
            // 
            // txtHgsGenelAyarlarZamanKisitEtkin
            // 
            this.txtHgsGenelAyarlarZamanKisitEtkin.AutoSize = true;
            this.txtHgsGenelAyarlarZamanKisitEtkin.Location = new System.Drawing.Point(6, 260);
            this.txtHgsGenelAyarlarZamanKisitEtkin.Name = "txtHgsGenelAyarlarZamanKisitEtkin";
            this.txtHgsGenelAyarlarZamanKisitEtkin.Size = new System.Drawing.Size(108, 17);
            this.txtHgsGenelAyarlarZamanKisitEtkin.TabIndex = 8;
            this.txtHgsGenelAyarlarZamanKisitEtkin.Text = "Zaman Kısıt Etkin";
            this.txtHgsGenelAyarlarZamanKisitEtkin.UseVisualStyleBackColor = true;
            // 
            // label124
            // 
            this.label124.AutoSize = true;
            this.label124.Location = new System.Drawing.Point(6, 235);
            this.label124.Name = "label124";
            this.label124.Size = new System.Drawing.Size(103, 13);
            this.label124.TabIndex = 7;
            this.label124.Text = "Dizi Ardışık Kontrol 2";
            // 
            // label123
            // 
            this.label123.AutoSize = true;
            this.label123.Location = new System.Drawing.Point(6, 203);
            this.label123.Name = "label123";
            this.label123.Size = new System.Drawing.Size(103, 13);
            this.label123.TabIndex = 6;
            this.label123.Text = "Dizi Ardışık Kontrol 1";
            // 
            // label122
            // 
            this.label122.AutoSize = true;
            this.label122.Location = new System.Drawing.Point(6, 175);
            this.label122.Name = "label122";
            this.label122.Size = new System.Drawing.Size(76, 13);
            this.label122.TabIndex = 5;
            this.label122.Text = "Program Modu";
            // 
            // label121
            // 
            this.label121.AutoSize = true;
            this.label121.Location = new System.Drawing.Point(6, 145);
            this.label121.Name = "label121";
            this.label121.Size = new System.Drawing.Size(89, 13);
            this.label121.TabIndex = 4;
            this.label121.Text = "Transistör Çıkışı 2";
            // 
            // label120
            // 
            this.label120.AutoSize = true;
            this.label120.Location = new System.Drawing.Point(6, 116);
            this.label120.Name = "label120";
            this.label120.Size = new System.Drawing.Size(89, 13);
            this.label120.TabIndex = 3;
            this.label120.Text = "Transistör Çıkışı 1";
            // 
            // label119
            // 
            this.label119.AutoSize = true;
            this.label119.Location = new System.Drawing.Point(6, 84);
            this.label119.Name = "label119";
            this.label119.Size = new System.Drawing.Size(76, 13);
            this.label119.TabIndex = 2;
            this.label119.Text = "Tag ID Boyutu";
            // 
            // label118
            // 
            this.label118.AutoSize = true;
            this.label118.Location = new System.Drawing.Point(6, 55);
            this.label118.Name = "label118";
            this.label118.Size = new System.Drawing.Size(75, 13);
            this.label118.TabIndex = 1;
            this.label118.Text = "Kart Başlangıç";
            // 
            // label117
            // 
            this.label117.AutoSize = true;
            this.label117.Location = new System.Drawing.Point(6, 28);
            this.label117.Name = "label117";
            this.label117.Size = new System.Drawing.Size(83, 13);
            this.label117.TabIndex = 0;
            this.label117.Text = "Seri Paket Boyu";
            // 
            // tbpCihazdanBilgiTransfer
            // 
            this.tbpCihazdanBilgiTransfer.Controls.Add(this.richTextRec2);
            this.tbpCihazdanBilgiTransfer.Controls.Add(this.groupBox19);
            this.tbpCihazdanBilgiTransfer.Location = new System.Drawing.Point(4, 22);
            this.tbpCihazdanBilgiTransfer.Name = "tbpCihazdanBilgiTransfer";
            this.tbpCihazdanBilgiTransfer.Padding = new System.Windows.Forms.Padding(3);
            this.tbpCihazdanBilgiTransfer.Size = new System.Drawing.Size(1108, 629);
            this.tbpCihazdanBilgiTransfer.TabIndex = 9;
            this.tbpCihazdanBilgiTransfer.Text = "Bilgi Transferleri";
            this.tbpCihazdanBilgiTransfer.UseVisualStyleBackColor = true;
            // 
            // richTextRec2
            // 
            this.richTextRec2.FormattingEnabled = true;
            this.richTextRec2.Location = new System.Drawing.Point(9, 155);
            this.richTextRec2.Name = "richTextRec2";
            this.richTextRec2.Size = new System.Drawing.Size(735, 355);
            this.richTextRec2.TabIndex = 56;
            // 
            // groupBox19
            // 
            this.groupBox19.Controls.Add(this.btnHgsVerileriTransferEt);
            this.groupBox19.Controls.Add(this.btnHgsCihazdangelenBilgileriOku);
            this.groupBox19.Controls.Add(this.label148);
            this.groupBox19.Controls.Add(this.txtSayi);
            this.groupBox19.Controls.Add(this.label147);
            this.groupBox19.Controls.Add(this.txtBaslangic);
            this.groupBox19.Controls.Add(this.label146);
            this.groupBox19.Controls.Add(this.textBox32);
            this.groupBox19.Controls.Add(this.button39);
            this.groupBox19.Location = new System.Drawing.Point(9, 18);
            this.groupBox19.Name = "groupBox19";
            this.groupBox19.Size = new System.Drawing.Size(735, 129);
            this.groupBox19.TabIndex = 0;
            this.groupBox19.TabStop = false;
            this.groupBox19.Text = "Cihazdan G/C Bilgilerini Transfer Etme";
            // 
            // btnHgsVerileriTransferEt
            // 
            this.btnHgsVerileriTransferEt.Location = new System.Drawing.Point(604, 100);
            this.btnHgsVerileriTransferEt.Name = "btnHgsVerileriTransferEt";
            this.btnHgsVerileriTransferEt.Size = new System.Drawing.Size(125, 23);
            this.btnHgsVerileriTransferEt.TabIndex = 38;
            this.btnHgsVerileriTransferEt.Text = "Verileri Transfer Et";
            this.btnHgsVerileriTransferEt.UseVisualStyleBackColor = true;
            this.btnHgsVerileriTransferEt.Click += new System.EventHandler(this.btnHgsVerileriTransferEt_Click);
            // 
            // btnHgsCihazdangelenBilgileriOku
            // 
            this.btnHgsCihazdangelenBilgileriOku.Location = new System.Drawing.Point(523, 100);
            this.btnHgsCihazdangelenBilgileriOku.Name = "btnHgsCihazdangelenBilgileriOku";
            this.btnHgsCihazdangelenBilgileriOku.Size = new System.Drawing.Size(75, 23);
            this.btnHgsCihazdangelenBilgileriOku.TabIndex = 37;
            this.btnHgsCihazdangelenBilgileriOku.Text = "Verileri Oku";
            this.btnHgsCihazdangelenBilgileriOku.UseVisualStyleBackColor = true;
            this.btnHgsCihazdangelenBilgileriOku.Click += new System.EventHandler(this.btnHgsCihazdangelenBilgileriOku_Click);
            // 
            // label148
            // 
            this.label148.AutoSize = true;
            this.label148.Location = new System.Drawing.Point(14, 81);
            this.label148.Name = "label148";
            this.label148.Size = new System.Drawing.Size(36, 13);
            this.label148.TabIndex = 36;
            this.label148.Text = "Sayı : ";
            // 
            // txtSayi
            // 
            this.txtSayi.Location = new System.Drawing.Point(90, 78);
            this.txtSayi.Maximum = new decimal(new int[] {
            54000,
            0,
            0,
            0});
            this.txtSayi.Name = "txtSayi";
            this.txtSayi.Size = new System.Drawing.Size(57, 20);
            this.txtSayi.TabIndex = 35;
            // 
            // label147
            // 
            this.label147.AutoSize = true;
            this.label147.Location = new System.Drawing.Point(15, 55);
            this.label147.Name = "label147";
            this.label147.Size = new System.Drawing.Size(62, 13);
            this.label147.TabIndex = 34;
            this.label147.Text = "Başlangıç : ";
            // 
            // txtBaslangic
            // 
            this.txtBaslangic.Location = new System.Drawing.Point(91, 52);
            this.txtBaslangic.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.txtBaslangic.Name = "txtBaslangic";
            this.txtBaslangic.Size = new System.Drawing.Size(57, 20);
            this.txtBaslangic.TabIndex = 33;
            // 
            // label146
            // 
            this.label146.AutoSize = true;
            this.label146.Location = new System.Drawing.Point(15, 31);
            this.label146.Name = "label146";
            this.label146.Size = new System.Drawing.Size(70, 13);
            this.label146.TabIndex = 2;
            this.label146.Text = "Dosya Yolu : ";
            // 
            // textBox32
            // 
            this.textBox32.Location = new System.Drawing.Point(91, 26);
            this.textBox32.Name = "textBox32";
            this.textBox32.Size = new System.Drawing.Size(215, 20);
            this.textBox32.TabIndex = 1;
            // 
            // button39
            // 
            this.button39.Location = new System.Drawing.Point(309, 25);
            this.button39.Name = "button39";
            this.button39.Size = new System.Drawing.Size(23, 23);
            this.button39.TabIndex = 0;
            this.button39.Text = "...";
            this.button39.UseVisualStyleBackColor = true;
            this.button39.Click += new System.EventHandler(this.button39_Click);
            // 
            // tbpYmk
            // 
            this.tbpYmk.Controls.Add(this.button45);
            this.tbpYmk.Controls.Add(this.button44);
            this.tbpYmk.Controls.Add(this.button41);
            this.tbpYmk.Controls.Add(this.button40);
            this.tbpYmk.Controls.Add(this.button36);
            this.tbpYmk.Controls.Add(this.btnKontorFiyatListesi);
            this.tbpYmk.Controls.Add(this.button31);
            this.tbpYmk.Controls.Add(this.button12);
            this.tbpYmk.Controls.Add(this.groupBox22);
            this.tbpYmk.Location = new System.Drawing.Point(4, 22);
            this.tbpYmk.Name = "tbpYmk";
            this.tbpYmk.Padding = new System.Windows.Forms.Padding(3);
            this.tbpYmk.Size = new System.Drawing.Size(1108, 629);
            this.tbpYmk.TabIndex = 10;
            this.tbpYmk.Text = "Yemekhane";
            this.tbpYmk.UseVisualStyleBackColor = true;
            // 
            // button45
            // 
            this.button45.Location = new System.Drawing.Point(380, 311);
            this.button45.Name = "button45";
            this.button45.Size = new System.Drawing.Size(188, 41);
            this.button45.TabIndex = 139;
            this.button45.Text = "Öğün İzinleri Tablosu";
            this.button45.UseVisualStyleBackColor = true;
            this.button45.Click += new System.EventHandler(this.button45_Click);
            // 
            // button44
            // 
            this.button44.Location = new System.Drawing.Point(380, 266);
            this.button44.Name = "button44";
            this.button44.Size = new System.Drawing.Size(188, 38);
            this.button44.TabIndex = 138;
            this.button44.Text = "Aylık Kişi Hak Tablosu";
            this.button44.UseVisualStyleBackColor = true;
            this.button44.Click += new System.EventHandler(this.button44_Click);
            // 
            // button41
            // 
            this.button41.Location = new System.Drawing.Point(380, 222);
            this.button41.Name = "button41";
            this.button41.Size = new System.Drawing.Size(188, 38);
            this.button41.TabIndex = 137;
            this.button41.Text = "Haftalık Hak Tablosu";
            this.button41.UseVisualStyleBackColor = true;
            this.button41.Click += new System.EventHandler(this.button41_Click);
            // 
            // button40
            // 
            this.button40.Location = new System.Drawing.Point(380, 178);
            this.button40.Name = "button40";
            this.button40.Size = new System.Drawing.Size(188, 38);
            this.button40.TabIndex = 136;
            this.button40.Text = "Statik Hak Tablosu";
            this.button40.UseVisualStyleBackColor = true;
            this.button40.Click += new System.EventHandler(this.button40_Click);
            // 
            // button36
            // 
            this.button36.Location = new System.Drawing.Point(380, 130);
            this.button36.Name = "button36";
            this.button36.Size = new System.Drawing.Size(188, 42);
            this.button36.TabIndex = 135;
            this.button36.Text = "Personel Komut Listesi";
            this.button36.UseVisualStyleBackColor = true;
            this.button36.Click += new System.EventHandler(this.button36_Click);
            // 
            // btnKontorFiyatListesi
            // 
            this.btnKontorFiyatListesi.Location = new System.Drawing.Point(380, 90);
            this.btnKontorFiyatListesi.Name = "btnKontorFiyatListesi";
            this.btnKontorFiyatListesi.Size = new System.Drawing.Size(188, 32);
            this.btnKontorFiyatListesi.TabIndex = 17;
            this.btnKontorFiyatListesi.Text = "Kontör Fiyat Liste Tablosu";
            this.btnKontorFiyatListesi.UseVisualStyleBackColor = true;
            this.btnKontorFiyatListesi.Click += new System.EventHandler(this.btnKontorFiyatListesi_Click);
            // 
            // button31
            // 
            this.button31.Location = new System.Drawing.Point(380, 52);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(188, 32);
            this.button31.TabIndex = 16;
            this.button31.Text = "Yemek Hak Tablosu";
            this.button31.UseVisualStyleBackColor = true;
            this.button31.Click += new System.EventHandler(this.button31_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(380, 14);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(188, 32);
            this.button12.TabIndex = 15;
            this.button12.Text = "Yemek Öğün Tablosu";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // groupBox22
            // 
            this.groupBox22.Controls.Add(this.cmbOgunDisindaOkuyucuNeYapsin);
            this.groupBox22.Controls.Add(this.checkBox1);
            this.groupBox22.Controls.Add(this.button33);
            this.groupBox22.Controls.Add(this.btnYemekhaneAyariGonder);
            this.groupBox22.Controls.Add(this.btnYemekhaneAyarlariGetir);
            this.groupBox22.Controls.Add(this.txtYemekhaneYenidenOkumaZamanAralik);
            this.groupBox22.Controls.Add(this.txtYemekhaneYenidenOkumaFiyatListesi);
            this.groupBox22.Controls.Add(this.txtYemekhaneYenidenKartOkumaSayi);
            this.groupBox22.Controls.Add(this.txtYemekhaneIstasyon);
            this.groupBox22.Controls.Add(this.txtYemekhaneKartSektor);
            this.groupBox22.Controls.Add(this.txtYemekhaneSeciliFiyatListesi);
            this.groupBox22.Controls.Add(this.label195);
            this.groupBox22.Controls.Add(this.label159);
            this.groupBox22.Controls.Add(this.label158);
            this.groupBox22.Controls.Add(this.label157);
            this.groupBox22.Controls.Add(this.label156);
            this.groupBox22.Controls.Add(this.label155);
            this.groupBox22.Controls.Add(this.label154);
            this.groupBox22.Controls.Add(this.label153);
            this.groupBox22.Controls.Add(this.txtYemekhaneUygulamaTipi);
            this.groupBox22.Location = new System.Drawing.Point(6, 6);
            this.groupBox22.Name = "groupBox22";
            this.groupBox22.Size = new System.Drawing.Size(356, 346);
            this.groupBox22.TabIndex = 0;
            this.groupBox22.TabStop = false;
            this.groupBox22.Text = "Ayarlar";
            // 
            // cmbOgunDisindaOkuyucuNeYapsin
            // 
            this.cmbOgunDisindaOkuyucuNeYapsin.FormattingEnabled = true;
            this.cmbOgunDisindaOkuyucuNeYapsin.Items.AddRange(new object[] {
            "Kart Okumasın",
            "Kart Okusun Öğün dışı Desin",
            "Kart Okusun Access geçişine izin versin"});
            this.cmbOgunDisindaOkuyucuNeYapsin.Location = new System.Drawing.Point(169, 237);
            this.cmbOgunDisindaOkuyucuNeYapsin.Name = "cmbOgunDisindaOkuyucuNeYapsin";
            this.cmbOgunDisindaOkuyucuNeYapsin.Size = new System.Drawing.Size(121, 21);
            this.cmbOgunDisindaOkuyucuNeYapsin.TabIndex = 18;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(23, 314);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(97, 17);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.Text = "Yeniden Başlat";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button33
            // 
            this.button33.Location = new System.Drawing.Point(126, 304);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(224, 33);
            this.button33.TabIndex = 16;
            this.button33.Text = "Uygulama Ayarlarını Fabrika ayarlarına getir";
            this.button33.UseVisualStyleBackColor = true;
            // 
            // btnYemekhaneAyariGonder
            // 
            this.btnYemekhaneAyariGonder.Location = new System.Drawing.Point(258, 275);
            this.btnYemekhaneAyariGonder.Name = "btnYemekhaneAyariGonder";
            this.btnYemekhaneAyariGonder.Size = new System.Drawing.Size(90, 23);
            this.btnYemekhaneAyariGonder.TabIndex = 15;
            this.btnYemekhaneAyariGonder.Text = "Gönder";
            this.btnYemekhaneAyariGonder.UseVisualStyleBackColor = true;
            this.btnYemekhaneAyariGonder.Click += new System.EventHandler(this.btnYemekhaneAyariGonder_Click);
            // 
            // btnYemekhaneAyarlariGetir
            // 
            this.btnYemekhaneAyarlariGetir.Location = new System.Drawing.Point(169, 275);
            this.btnYemekhaneAyarlariGetir.Name = "btnYemekhaneAyarlariGetir";
            this.btnYemekhaneAyarlariGetir.Size = new System.Drawing.Size(83, 23);
            this.btnYemekhaneAyarlariGetir.TabIndex = 14;
            this.btnYemekhaneAyarlariGetir.Text = "Getir";
            this.btnYemekhaneAyarlariGetir.UseVisualStyleBackColor = true;
            this.btnYemekhaneAyarlariGetir.Click += new System.EventHandler(this.btnYemekhaneAyarlariGetir_Click);
            // 
            // txtYemekhaneYenidenOkumaZamanAralik
            // 
            this.txtYemekhaneYenidenOkumaZamanAralik.Location = new System.Drawing.Point(169, 210);
            this.txtYemekhaneYenidenOkumaZamanAralik.Name = "txtYemekhaneYenidenOkumaZamanAralik";
            this.txtYemekhaneYenidenOkumaZamanAralik.Size = new System.Drawing.Size(120, 20);
            this.txtYemekhaneYenidenOkumaZamanAralik.TabIndex = 13;
            // 
            // txtYemekhaneYenidenOkumaFiyatListesi
            // 
            this.txtYemekhaneYenidenOkumaFiyatListesi.Location = new System.Drawing.Point(169, 178);
            this.txtYemekhaneYenidenOkumaFiyatListesi.Name = "txtYemekhaneYenidenOkumaFiyatListesi";
            this.txtYemekhaneYenidenOkumaFiyatListesi.Size = new System.Drawing.Size(120, 20);
            this.txtYemekhaneYenidenOkumaFiyatListesi.TabIndex = 12;
            // 
            // txtYemekhaneYenidenKartOkumaSayi
            // 
            this.txtYemekhaneYenidenKartOkumaSayi.Location = new System.Drawing.Point(169, 146);
            this.txtYemekhaneYenidenKartOkumaSayi.Name = "txtYemekhaneYenidenKartOkumaSayi";
            this.txtYemekhaneYenidenKartOkumaSayi.Size = new System.Drawing.Size(120, 20);
            this.txtYemekhaneYenidenKartOkumaSayi.TabIndex = 11;
            // 
            // txtYemekhaneIstasyon
            // 
            this.txtYemekhaneIstasyon.Location = new System.Drawing.Point(169, 112);
            this.txtYemekhaneIstasyon.Name = "txtYemekhaneIstasyon";
            this.txtYemekhaneIstasyon.Size = new System.Drawing.Size(120, 20);
            this.txtYemekhaneIstasyon.TabIndex = 10;
            // 
            // txtYemekhaneKartSektor
            // 
            this.txtYemekhaneKartSektor.Location = new System.Drawing.Point(169, 81);
            this.txtYemekhaneKartSektor.Name = "txtYemekhaneKartSektor";
            this.txtYemekhaneKartSektor.Size = new System.Drawing.Size(120, 20);
            this.txtYemekhaneKartSektor.TabIndex = 9;
            // 
            // txtYemekhaneSeciliFiyatListesi
            // 
            this.txtYemekhaneSeciliFiyatListesi.Location = new System.Drawing.Point(169, 50);
            this.txtYemekhaneSeciliFiyatListesi.Name = "txtYemekhaneSeciliFiyatListesi";
            this.txtYemekhaneSeciliFiyatListesi.Size = new System.Drawing.Size(120, 20);
            this.txtYemekhaneSeciliFiyatListesi.TabIndex = 8;
            // 
            // label195
            // 
            this.label195.AutoSize = true;
            this.label195.Location = new System.Drawing.Point(6, 241);
            this.label195.Name = "label195";
            this.label195.Size = new System.Drawing.Size(166, 13);
            this.label195.TabIndex = 7;
            this.label195.Text = "Öğün Dışında Okuyu Ne Yapsın : ";
            // 
            // label159
            // 
            this.label159.AutoSize = true;
            this.label159.Location = new System.Drawing.Point(6, 212);
            this.label159.Name = "label159";
            this.label159.Size = new System.Drawing.Size(157, 13);
            this.label159.TabIndex = 7;
            this.label159.Text = "Yeniden Okuma Zaman Aralık : ";
            // 
            // label158
            // 
            this.label158.AutoSize = true;
            this.label158.Location = new System.Drawing.Point(6, 183);
            this.label158.Name = "label158";
            this.label158.Size = new System.Drawing.Size(149, 13);
            this.label158.TabIndex = 6;
            this.label158.Text = "Yeniden Okuma Fiyat Listesi : ";
            // 
            // label157
            // 
            this.label157.AutoSize = true;
            this.label157.Location = new System.Drawing.Point(6, 153);
            this.label157.Name = "label157";
            this.label157.Size = new System.Drawing.Size(137, 13);
            this.label157.TabIndex = 5;
            this.label157.Text = "Yeniden Kart Okuma Sayı : ";
            // 
            // label156
            // 
            this.label156.AutoSize = true;
            this.label156.Location = new System.Drawing.Point(6, 119);
            this.label156.Name = "label156";
            this.label156.Size = new System.Drawing.Size(55, 13);
            this.label156.TabIndex = 4;
            this.label156.Text = "İstasyon : ";
            // 
            // label155
            // 
            this.label155.AutoSize = true;
            this.label155.Location = new System.Drawing.Point(6, 88);
            this.label155.Name = "label155";
            this.label155.Size = new System.Drawing.Size(86, 13);
            this.label155.TabIndex = 3;
            this.label155.Text = "Kart Sektör No : ";
            // 
            // label154
            // 
            this.label154.AutoSize = true;
            this.label154.Location = new System.Drawing.Point(6, 58);
            this.label154.Name = "label154";
            this.label154.Size = new System.Drawing.Size(98, 13);
            this.label154.TabIndex = 2;
            this.label154.Text = "Seçili Fiyat Listesi : ";
            // 
            // label153
            // 
            this.label153.AutoSize = true;
            this.label153.Location = new System.Drawing.Point(6, 28);
            this.label153.Name = "label153";
            this.label153.Size = new System.Drawing.Size(83, 13);
            this.label153.TabIndex = 1;
            this.label153.Text = "Uygulama Tipi : ";
            // 
            // txtYemekhaneUygulamaTipi
            // 
            this.txtYemekhaneUygulamaTipi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtYemekhaneUygulamaTipi.FormattingEnabled = true;
            this.txtYemekhaneUygulamaTipi.Items.AddRange(new object[] {
            "Sadece Hak",
            "Hak + Kontör",
            "Kontör + Whitelist",
            "Kontör Karttan"});
            this.txtYemekhaneUygulamaTipi.Location = new System.Drawing.Point(169, 20);
            this.txtYemekhaneUygulamaTipi.Name = "txtYemekhaneUygulamaTipi";
            this.txtYemekhaneUygulamaTipi.Size = new System.Drawing.Size(121, 21);
            this.txtYemekhaneUygulamaTipi.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.label182);
            this.tabPage5.Controls.Add(this.textBox1);
            this.tabPage5.Controls.Add(this.lblMesaj);
            this.tabPage5.Controls.Add(this.button32);
            this.tabPage5.Controls.Add(this.numericUpDown2);
            this.tabPage5.Controls.Add(this.numericUpDown3);
            this.tabPage5.Controls.Add(this.label183);
            this.tabPage5.Controls.Add(this.label184);
            this.tabPage5.Controls.Add(this.button34);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1108, 629);
            this.tabPage5.TabIndex = 11;
            this.tabPage5.Text = "Mifare Kart Yazma Okuma";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // label182
            // 
            this.label182.AutoSize = true;
            this.label182.Location = new System.Drawing.Point(17, 75);
            this.label182.Name = "label182";
            this.label182.Size = new System.Drawing.Size(33, 13);
            this.label182.TabIndex = 21;
            this.label182.Text = "veri : ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(97, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 20);
            this.textBox1.TabIndex = 20;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblMesaj
            // 
            this.lblMesaj.AutoSize = true;
            this.lblMesaj.Location = new System.Drawing.Point(94, 102);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(42, 13);
            this.lblMesaj.TabIndex = 19;
            this.lblMesaj.Text = "XXXXX";
            // 
            // button32
            // 
            this.button32.Location = new System.Drawing.Point(353, 20);
            this.button32.Name = "button32";
            this.button32.Size = new System.Drawing.Size(146, 68);
            this.button32.TabIndex = 18;
            this.button32.Text = "Yaz";
            this.button32.UseVisualStyleBackColor = true;
            this.button32.Click += new System.EventHandler(this.button32_Click);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(97, 44);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown2.TabIndex = 16;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(97, 18);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown3.TabIndex = 17;
            // 
            // label183
            // 
            this.label183.AutoSize = true;
            this.label183.Location = new System.Drawing.Point(17, 48);
            this.label183.Name = "label183";
            this.label183.Size = new System.Drawing.Size(39, 13);
            this.label183.TabIndex = 15;
            this.label183.Text = "block :";
            // 
            // label184
            // 
            this.label184.AutoSize = true;
            this.label184.Location = new System.Drawing.Point(17, 23);
            this.label184.Name = "label184";
            this.label184.Size = new System.Drawing.Size(45, 13);
            this.label184.TabIndex = 14;
            this.label184.Text = "sektör : ";
            // 
            // button34
            // 
            this.button34.Location = new System.Drawing.Point(228, 20);
            this.button34.Name = "button34";
            this.button34.Size = new System.Drawing.Size(119, 70);
            this.button34.TabIndex = 13;
            this.button34.Text = "Oku";
            this.button34.UseVisualStyleBackColor = true;
            this.button34.Click += new System.EventHandler(this.button34_Click);
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.lblTanimliBlackListSayisi);
            this.tabPage6.Controls.Add(this.btnTanimliBlackListKullanicilariSil);
            this.tabPage6.Controls.Add(this.BtnBlackListPersonelBul);
            this.tabPage6.Controls.Add(this.BtnBlackListPersonelSil);
            this.tabPage6.Controls.Add(this.BtnBlackListPersonelDegistir);
            this.tabPage6.Controls.Add(this.BtnBlackListPersonelSayisi);
            this.tabPage6.Controls.Add(this.BtnBlackListPersonelEkle);
            this.tabPage6.Controls.Add(this.nmrBlackListNo);
            this.tabPage6.Controls.Add(this.label39);
            this.tabPage6.Controls.Add(this.label36);
            this.tabPage6.Controls.Add(this.edtBlackListAd);
            this.tabPage6.Controls.Add(this.label38);
            this.tabPage6.Controls.Add(this.edtBlackListKartId);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(1108, 629);
            this.tabPage6.TabIndex = 12;
            this.tabPage6.Text = "Black List";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // lblTanimliBlackListSayisi
            // 
            this.lblTanimliBlackListSayisi.AutoSize = true;
            this.lblTanimliBlackListSayisi.Location = new System.Drawing.Point(356, 166);
            this.lblTanimliBlackListSayisi.Name = "lblTanimliBlackListSayisi";
            this.lblTanimliBlackListSayisi.Size = new System.Drawing.Size(19, 13);
            this.lblTanimliBlackListSayisi.TabIndex = 100;
            this.lblTanimliBlackListSayisi.Text = "....";
            // 
            // btnTanimliBlackListKullanicilariSil
            // 
            this.btnTanimliBlackListKullanicilariSil.Location = new System.Drawing.Point(477, 126);
            this.btnTanimliBlackListKullanicilariSil.Name = "btnTanimliBlackListKullanicilariSil";
            this.btnTanimliBlackListKullanicilariSil.Size = new System.Drawing.Size(151, 33);
            this.btnTanimliBlackListKullanicilariSil.TabIndex = 99;
            this.btnTanimliBlackListKullanicilariSil.Text = "Tanımlı Tüm Kartları Sil";
            this.btnTanimliBlackListKullanicilariSil.UseVisualStyleBackColor = true;
            this.btnTanimliBlackListKullanicilariSil.Click += new System.EventHandler(this.btnTanimliBlackListKullanicilariSil_Click);
            // 
            // BtnBlackListPersonelBul
            // 
            this.BtnBlackListPersonelBul.Location = new System.Drawing.Point(275, 126);
            this.BtnBlackListPersonelBul.Name = "BtnBlackListPersonelBul";
            this.BtnBlackListPersonelBul.Size = new System.Drawing.Size(77, 33);
            this.BtnBlackListPersonelBul.TabIndex = 98;
            this.BtnBlackListPersonelBul.Text = "Bul";
            this.BtnBlackListPersonelBul.UseVisualStyleBackColor = true;
            this.BtnBlackListPersonelBul.Click += new System.EventHandler(this.BtnBlackListPersonelBul_Click);
            // 
            // BtnBlackListPersonelSil
            // 
            this.BtnBlackListPersonelSil.Location = new System.Drawing.Point(194, 126);
            this.BtnBlackListPersonelSil.Name = "BtnBlackListPersonelSil";
            this.BtnBlackListPersonelSil.Size = new System.Drawing.Size(77, 33);
            this.BtnBlackListPersonelSil.TabIndex = 98;
            this.BtnBlackListPersonelSil.Text = "Sil";
            this.BtnBlackListPersonelSil.UseVisualStyleBackColor = true;
            this.BtnBlackListPersonelSil.Click += new System.EventHandler(this.BtnBlackListPersonelSil_Click);
            // 
            // BtnBlackListPersonelDegistir
            // 
            this.BtnBlackListPersonelDegistir.Location = new System.Drawing.Point(113, 126);
            this.BtnBlackListPersonelDegistir.Name = "BtnBlackListPersonelDegistir";
            this.BtnBlackListPersonelDegistir.Size = new System.Drawing.Size(77, 33);
            this.BtnBlackListPersonelDegistir.TabIndex = 98;
            this.BtnBlackListPersonelDegistir.Text = "Değiştir";
            this.BtnBlackListPersonelDegistir.UseVisualStyleBackColor = true;
            this.BtnBlackListPersonelDegistir.Click += new System.EventHandler(this.BtnBlackListPersonelDegistir_Click);
            // 
            // BtnBlackListPersonelSayisi
            // 
            this.BtnBlackListPersonelSayisi.Location = new System.Drawing.Point(356, 126);
            this.BtnBlackListPersonelSayisi.Name = "BtnBlackListPersonelSayisi";
            this.BtnBlackListPersonelSayisi.Size = new System.Drawing.Size(116, 33);
            this.BtnBlackListPersonelSayisi.TabIndex = 98;
            this.BtnBlackListPersonelSayisi.Text = "Tanımlı Kart Sayısı";
            this.BtnBlackListPersonelSayisi.UseVisualStyleBackColor = true;
            this.BtnBlackListPersonelSayisi.Click += new System.EventHandler(this.BtnBlackListPersonelSayisi_Click);
            // 
            // BtnBlackListPersonelEkle
            // 
            this.BtnBlackListPersonelEkle.Location = new System.Drawing.Point(25, 126);
            this.BtnBlackListPersonelEkle.Name = "BtnBlackListPersonelEkle";
            this.BtnBlackListPersonelEkle.Size = new System.Drawing.Size(77, 33);
            this.BtnBlackListPersonelEkle.TabIndex = 98;
            this.BtnBlackListPersonelEkle.Text = "Ekle";
            this.BtnBlackListPersonelEkle.UseVisualStyleBackColor = true;
            this.BtnBlackListPersonelEkle.Click += new System.EventHandler(this.BtnBlackListPersonelEkle_Click);
            // 
            // nmrBlackListNo
            // 
            this.nmrBlackListNo.Location = new System.Drawing.Point(140, 91);
            this.nmrBlackListNo.Name = "nmrBlackListNo";
            this.nmrBlackListNo.Size = new System.Drawing.Size(129, 20);
            this.nmrBlackListNo.TabIndex = 97;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(22, 98);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(112, 13);
            this.label39.TabIndex = 96;
            this.label39.Text = "Black List Komut No : ";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(22, 67);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(20, 13);
            this.label36.TabIndex = 96;
            this.label36.Text = "Ad";
            // 
            // edtBlackListAd
            // 
            this.edtBlackListAd.Location = new System.Drawing.Point(140, 64);
            this.edtBlackListAd.MaxLength = 18;
            this.edtBlackListAd.Name = "edtBlackListAd";
            this.edtBlackListAd.Size = new System.Drawing.Size(129, 20);
            this.edtBlackListAd.TabIndex = 95;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(22, 42);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(18, 13);
            this.label38.TabIndex = 94;
            this.label38.Text = "ID";
            // 
            // edtBlackListKartId
            // 
            this.edtBlackListKartId.Location = new System.Drawing.Point(140, 39);
            this.edtBlackListKartId.MaxLength = 14;
            this.edtBlackListKartId.Name = "edtBlackListKartId";
            this.edtBlackListKartId.Size = new System.Drawing.Size(129, 20);
            this.edtBlackListKartId.TabIndex = 93;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.btnNodeGetir);
            this.tabPage7.Controls.Add(this.btnNodeGonder);
            this.tabPage7.Controls.Add(this.txtValue);
            this.tabPage7.Controls.Add(this.nmrParent);
            this.tabPage7.Controls.Add(this.nmrRight);
            this.tabPage7.Controls.Add(this.nmrLeft);
            this.tabPage7.Controls.Add(this.nmrColor);
            this.tabPage7.Controls.Add(this.nmrAdres);
            this.tabPage7.Controls.Add(this.label194);
            this.tabPage7.Controls.Add(this.label193);
            this.tabPage7.Controls.Add(this.label43);
            this.tabPage7.Controls.Add(this.label42);
            this.tabPage7.Controls.Add(this.label41);
            this.tabPage7.Controls.Add(this.label40);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(1108, 629);
            this.tabPage7.TabIndex = 13;
            this.tabPage7.Text = "Get / Set Node";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // btnNodeGetir
            // 
            this.btnNodeGetir.Location = new System.Drawing.Point(228, 51);
            this.btnNodeGetir.Name = "btnNodeGetir";
            this.btnNodeGetir.Size = new System.Drawing.Size(75, 23);
            this.btnNodeGetir.TabIndex = 3;
            this.btnNodeGetir.Text = "Getir";
            this.btnNodeGetir.UseVisualStyleBackColor = true;
            this.btnNodeGetir.Click += new System.EventHandler(this.btnNodeGetir_Click);
            // 
            // btnNodeGonder
            // 
            this.btnNodeGonder.Location = new System.Drawing.Point(228, 20);
            this.btnNodeGonder.Name = "btnNodeGonder";
            this.btnNodeGonder.Size = new System.Drawing.Size(75, 23);
            this.btnNodeGonder.TabIndex = 3;
            this.btnNodeGonder.Text = "Gönder";
            this.btnNodeGonder.UseVisualStyleBackColor = true;
            this.btnNodeGonder.Click += new System.EventHandler(this.btnNodeGonder_Click);
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(75, 51);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(100, 20);
            this.txtValue.TabIndex = 2;
            // 
            // nmrParent
            // 
            this.nmrParent.Location = new System.Drawing.Point(75, 167);
            this.nmrParent.Name = "nmrParent";
            this.nmrParent.Size = new System.Drawing.Size(120, 20);
            this.nmrParent.TabIndex = 1;
            // 
            // nmrRight
            // 
            this.nmrRight.Location = new System.Drawing.Point(75, 138);
            this.nmrRight.Name = "nmrRight";
            this.nmrRight.Size = new System.Drawing.Size(120, 20);
            this.nmrRight.TabIndex = 1;
            // 
            // nmrLeft
            // 
            this.nmrLeft.Location = new System.Drawing.Point(75, 108);
            this.nmrLeft.Name = "nmrLeft";
            this.nmrLeft.Size = new System.Drawing.Size(120, 20);
            this.nmrLeft.TabIndex = 1;
            // 
            // nmrColor
            // 
            this.nmrColor.Location = new System.Drawing.Point(75, 78);
            this.nmrColor.Name = "nmrColor";
            this.nmrColor.Size = new System.Drawing.Size(120, 20);
            this.nmrColor.TabIndex = 1;
            // 
            // nmrAdres
            // 
            this.nmrAdres.Location = new System.Drawing.Point(75, 20);
            this.nmrAdres.Name = "nmrAdres";
            this.nmrAdres.Size = new System.Drawing.Size(120, 20);
            this.nmrAdres.TabIndex = 1;
            // 
            // label194
            // 
            this.label194.AutoSize = true;
            this.label194.Location = new System.Drawing.Point(9, 171);
            this.label194.Name = "label194";
            this.label194.Size = new System.Drawing.Size(44, 13);
            this.label194.TabIndex = 0;
            this.label194.Text = "Parent :";
            // 
            // label193
            // 
            this.label193.AutoSize = true;
            this.label193.Location = new System.Drawing.Point(9, 145);
            this.label193.Name = "label193";
            this.label193.Size = new System.Drawing.Size(41, 13);
            this.label193.TabIndex = 0;
            this.label193.Text = "Right : ";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(9, 115);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(34, 13);
            this.label43.TabIndex = 0;
            this.label43.Text = "Left : ";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(9, 85);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(40, 13);
            this.label42.TabIndex = 0;
            this.label42.Text = "Color : ";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(9, 56);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(43, 13);
            this.label41.TabIndex = 0;
            this.label41.Text = "Value : ";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(9, 28);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(43, 13);
            this.label40.TabIndex = 0;
            this.label40.Text = "Adres : ";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label31);
            this.panel3.Controls.Add(this.txtUygulamaTipi);
            this.panel3.Controls.Add(this.btnDisConnect);
            this.panel3.Controls.Add(this.cbAutoRxEnabled);
            this.panel3.Controls.Add(this.cbAutoConnect);
            this.panel3.Controls.Add(this.btnConnect);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.cbDfSize);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.edtCmtRetry);
            this.panel3.Controls.Add(this.edtDeviceKey);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.edtPortNo);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.edtIp);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.edtTimeOut);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.cbProtocol);
            this.panel3.Controls.Add(this.label24);
            this.panel3.Controls.Add(this.cbReaderType);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1116, 86);
            this.panel3.TabIndex = 3;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(458, 10);
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
            this.txtUygulamaTipi.Location = new System.Drawing.Point(516, 6);
            this.txtUygulamaTipi.Name = "txtUygulamaTipi";
            this.txtUygulamaTipi.Size = new System.Drawing.Size(90, 21);
            this.txtUygulamaTipi.TabIndex = 99;
            // 
            // btnDisConnect
            // 
            this.btnDisConnect.Enabled = false;
            this.btnDisConnect.Location = new System.Drawing.Point(612, 30);
            this.btnDisConnect.Name = "btnDisConnect";
            this.btnDisConnect.Size = new System.Drawing.Size(128, 23);
            this.btnDisConnect.TabIndex = 98;
            this.btnDisConnect.Text = "Bağlantı Kes";
            this.btnDisConnect.UseVisualStyleBackColor = true;
            this.btnDisConnect.Click += new System.EventHandler(this.btnDisConnect_Click);
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
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(515, 30);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(91, 23);
            this.btnConnect.TabIndex = 95;
            this.btnConnect.Text = "Bağlan";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(632, 9);
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
            this.cbDfSize.Location = new System.Drawing.Point(682, 6);
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
            this.edtDeviceKey.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
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
            this.edtPortNo.Location = new System.Drawing.Point(372, 8);
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
            this.label6.Location = new System.Drawing.Point(340, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 87;
            this.label6.Text = "Port";
            // 
            // edtIp
            // 
            this.edtIp.Location = new System.Drawing.Point(232, 7);
            this.edtIp.Name = "edtIp";
            this.edtIp.Size = new System.Drawing.Size(93, 20);
            this.edtIp.TabIndex = 86;
            this.edtIp.Text = "192.168.0.200";
            this.edtIp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.edtIp_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 85;
            this.label1.Text = "Ip Adresi";
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
            this.cbReaderType.SelectedIndexChanged += new System.EventHandler(this.cbReaderType_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(994, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(362, 741);
            this.panel2.TabIndex = 3;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(362, 741);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel4);
            this.tabPage1.Controls.Add(this.appLog);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(354, 715);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Uygulama Logları";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnTemizle);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(348, 39);
            this.panel4.TabIndex = 1;
            // 
            // btnTemizle
            // 
            this.btnTemizle.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnTemizle.Location = new System.Drawing.Point(241, 0);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(107, 39);
            this.btnTemizle.TabIndex = 0;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // appLog
            // 
            this.appLog.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.appLog.Location = new System.Drawing.Point(3, 186);
            this.appLog.Name = "appLog";
            this.appLog.Size = new System.Drawing.Size(348, 526);
            this.appLog.TabIndex = 0;
            this.appLog.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.udPlog);
            this.tabPage2.Controls.Add(this.groupBox24);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(354, 715);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cihaz UDP Logları";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // udPlog
            // 
            this.udPlog.Controls.Add(this.udpLogText);
            this.udPlog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.udPlog.Location = new System.Drawing.Point(3, 53);
            this.udPlog.Name = "udPlog";
            this.udPlog.Size = new System.Drawing.Size(348, 659);
            this.udPlog.TabIndex = 1;
            this.udPlog.TabStop = false;
            // 
            // udpLogText
            // 
            this.udpLogText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.udpLogText.Location = new System.Drawing.Point(3, 16);
            this.udpLogText.Multiline = true;
            this.udpLogText.Name = "udpLogText";
            this.udpLogText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.udpLogText.Size = new System.Drawing.Size(342, 640);
            this.udpLogText.TabIndex = 0;
            // 
            // groupBox24
            // 
            this.groupBox24.Controls.Add(this.txtUdpPortNumber);
            this.groupBox24.Controls.Add(this.label161);
            this.groupBox24.Controls.Add(this.btnUdpTemizle);
            this.groupBox24.Controls.Add(this.btnUDPbaslat);
            this.groupBox24.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox24.Location = new System.Drawing.Point(3, 3);
            this.groupBox24.Name = "groupBox24";
            this.groupBox24.Size = new System.Drawing.Size(348, 50);
            this.groupBox24.TabIndex = 0;
            this.groupBox24.TabStop = false;
            // 
            // txtUdpPortNumber
            // 
            this.txtUdpPortNumber.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtUdpPortNumber.Location = new System.Drawing.Point(38, 16);
            this.txtUdpPortNumber.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.txtUdpPortNumber.Name = "txtUdpPortNumber";
            this.txtUdpPortNumber.Size = new System.Drawing.Size(81, 20);
            this.txtUdpPortNumber.TabIndex = 3;
            this.txtUdpPortNumber.Value = new decimal(new int[] {
            514,
            0,
            0,
            0});
            // 
            // label161
            // 
            this.label161.AutoSize = true;
            this.label161.Dock = System.Windows.Forms.DockStyle.Left;
            this.label161.Location = new System.Drawing.Point(3, 16);
            this.label161.Name = "label161";
            this.label161.Size = new System.Drawing.Size(35, 13);
            this.label161.TabIndex = 2;
            this.label161.Text = "Port : ";
            // 
            // btnUdpTemizle
            // 
            this.btnUdpTemizle.Location = new System.Drawing.Point(252, 11);
            this.btnUdpTemizle.Name = "btnUdpTemizle";
            this.btnUdpTemizle.Size = new System.Drawing.Size(90, 31);
            this.btnUdpTemizle.TabIndex = 1;
            this.btnUdpTemizle.Text = "Temizle";
            this.btnUdpTemizle.UseVisualStyleBackColor = true;
            this.btnUdpTemizle.Click += new System.EventHandler(this.btnUdpTemizle_Click);
            // 
            // btnUDPbaslat
            // 
            this.btnUDPbaslat.Location = new System.Drawing.Point(125, 11);
            this.btnUDPbaslat.Name = "btnUDPbaslat";
            this.btnUDPbaslat.Size = new System.Drawing.Size(121, 31);
            this.btnUDPbaslat.TabIndex = 0;
            this.btnUDPbaslat.Text = "Başlat";
            this.btnUDPbaslat.UseVisualStyleBackColor = true;
            this.btnUDPbaslat.Click += new System.EventHandler(this.btnUDPbaslat_Click);
            // 
            // dtTimer
            // 
            this.dtTimer.Interval = 1000;
            this.dtTimer.Tick += new System.EventHandler(this.dtTimer_Tick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox27
            // 
            this.groupBox27.Controls.Add(this.btnGetStatusMode);
            this.groupBox27.Controls.Add(this.btnSendStatusMode);
            this.groupBox27.Controls.Add(this.edtStatusModeType);
            this.groupBox27.Controls.Add(this.edtStatusMode);
            this.groupBox27.Controls.Add(this.label197);
            this.groupBox27.Controls.Add(this.label196);
            this.groupBox27.Location = new System.Drawing.Point(10, 499);
            this.groupBox27.Name = "groupBox27";
            this.groupBox27.Size = new System.Drawing.Size(456, 100);
            this.groupBox27.TabIndex = 7;
            this.groupBox27.TabStop = false;
            this.groupBox27.Text = "Durum Modları";
            // 
            // label196
            // 
            this.label196.AutoSize = true;
            this.label196.Location = new System.Drawing.Point(17, 29);
            this.label196.Name = "label196";
            this.label196.Size = new System.Drawing.Size(76, 13);
            this.label196.TabIndex = 0;
            this.label196.Text = "Status Mode : ";
            // 
            // label197
            // 
            this.label197.AutoSize = true;
            this.label197.Location = new System.Drawing.Point(17, 57);
            this.label197.Name = "label197";
            this.label197.Size = new System.Drawing.Size(70, 13);
            this.label197.TabIndex = 0;
            this.label197.Text = "Mode Type : ";
            // 
            // edtStatusMode
            // 
            this.edtStatusMode.Location = new System.Drawing.Point(103, 24);
            this.edtStatusMode.Name = "edtStatusMode";
            this.edtStatusMode.Size = new System.Drawing.Size(60, 20);
            this.edtStatusMode.TabIndex = 1;
            // 
            // edtStatusModeType
            // 
            this.edtStatusModeType.Location = new System.Drawing.Point(103, 55);
            this.edtStatusModeType.Name = "edtStatusModeType";
            this.edtStatusModeType.Size = new System.Drawing.Size(60, 20);
            this.edtStatusModeType.TabIndex = 1;
            // 
            // btnSendStatusMode
            // 
            this.btnSendStatusMode.Location = new System.Drawing.Point(170, 22);
            this.btnSendStatusMode.Name = "btnSendStatusMode";
            this.btnSendStatusMode.Size = new System.Drawing.Size(75, 23);
            this.btnSendStatusMode.TabIndex = 2;
            this.btnSendStatusMode.Text = "Gönder";
            this.btnSendStatusMode.UseVisualStyleBackColor = true;
            this.btnSendStatusMode.Click += new System.EventHandler(this.btnSendStatusMode_Click);
            // 
            // btnGetStatusMode
            // 
            this.btnGetStatusMode.Location = new System.Drawing.Point(169, 53);
            this.btnGetStatusMode.Name = "btnGetStatusMode";
            this.btnGetStatusMode.Size = new System.Drawing.Size(75, 23);
            this.btnGetStatusMode.TabIndex = 2;
            this.btnGetStatusMode.Text = "Getir";
            this.btnGetStatusMode.UseVisualStyleBackColor = true;
            this.btnGetStatusMode.Click += new System.EventHandler(this.btnGetStatusMode_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 741);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmMain";
            this.Text = "Perio TCP Reader (PDKS - EKS fw.) Demo 3.0";
            this.Activated += new System.EventHandler(this.frmMain_Activated);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            this.tabCihazGenelBilgileri.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.tbpDeviceGeneralSettings.ResumeLayout(false);
            this.groupBox21.ResumeLayout(false);
            this.groupBox21.PerformLayout();
            this.grSerialNumber.ResumeLayout(false);
            this.grSerialNumber.PerformLayout();
            this.grDeviceWorkMode.ResumeLayout(false);
            this.grDeviceWorkMode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edtOnlineTimeOut)).EndInit();
            this.grDeviceGeneralSettings.ResumeLayout(false);
            this.grDeviceGeneralSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrKartLoginBeklemeSuresi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtAyniKartiOkumaAraligi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtArdasikKartOkumaAraligi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtKartOkumaSuresi)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edtRenkYogunlugu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtArkaPlanIsigi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtCihazNo)).EndInit();
            this.gbDeviceİnfo.ResumeLayout(false);
            this.gbDeviceİnfo.PerformLayout();
            this.grDeviceOperation.ResumeLayout(false);
            this.grDeviceOperation.PerformLayout();
            this.grDeviceStatus.ResumeLayout(false);
            this.grDeviceStatus.PerformLayout();
            this.grDateTime.ResumeLayout(false);
            this.grHeadTail.ResumeLayout(false);
            this.grHeadTail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edtTail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtHead)).EndInit();
            this.tsCominicationSettings.ResumeLayout(false);
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edtHaberlesmeAyarlariTCPclientAyarlariPortNumarasi)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edtUDPayarlariPortNumarasi)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtServerEchoZamanAsimi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtHaberlesmeAyarlariPortNumarasi)).EndInit();
            this.tsMfrKeyTable.ResumeLayout(false);
            this.tsLCDMessages.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.groupBox25.ResumeLayout(false);
            this.groupBox25.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtInputBoxMesajGonderKlavyeTipi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInputBoxMesajGonderBuzzerSure1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInputBoxMesajGonderRoleSure2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInputBoxMesajGonderRoleSure1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInputBoxMesajGonderEkranSure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInputBoxMesajGonderIkinciSatirZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInputBoxMesajGonderIkinciSatirX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInputBoxMesajGonderBirinciSatirZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInputBoxMesajGonderBirinciSatirx)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ekranMesajiOnlieSatir5y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ekranMesajiOnlieSatir5x)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ekranMesajiOnlieSatir4y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ekranMesajiOnlieSatir4x)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ekranMesajiOnlieSatir3y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ekranMesajiOnlieSatir3x)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ekranMesajiOnlieSatir2y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ekranMesajiOnlieSatir2x)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ekranMesajiOnlieSatir1y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ekranMesajiOnlieSatir1x)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEkranMesajlariBuzzerSuresi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEkranMesajlariRoleSuresi2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEkranMesajlariRoleSuresi1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEkranMesajlariEkranSure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEkranMesajiSatirSayisi)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ekranMesajiOfflineSatir5z)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ekranMesajiOfflineSatir5x)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ekranMesajiOfflineSatir4z)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ekranMesajiOfflineSatir4x)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ekranMesajiOfflineSatir3z)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ekranMesajiOfflineSatir3x)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ekranMesajiOfflineSatir2z)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ekranMesajiOfflineSatir2x)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ekranMesajiOfflineSatir1z)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ekranMesajiOfflineSatir1x)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ekranMesajiOfflineBuzzerSuresi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ekranMesajiOfflineRoleSuresi2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ekranMesajiOfflineRoleSuresi1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ekranMesajiOfflineEkranSuresi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEkranMesajiSatirSayisiOffline)).EndInit();
            this.tsAccessSettings.ResumeLayout(false);
            this.tsAccessSettings.PerformLayout();
            this.groupBox17.ResumeLayout(false);
            this.groupBox17.PerformLayout();
            this.groupBox16.ResumeLayout(false);
            this.groupBox16.PerformLayout();
            this.groupBox15.ResumeLayout(false);
            this.groupBox15.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.digerEKSAyarlariEKSverisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.digerEKSAyarlariKisiVerisi)).EndInit();
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edtAntiPassBackArdisikGecisAraligi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtUygulamaAyarlariGuvenlikBolgeNo)).EndInit();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edtUygulamaayarlariGecisSuresi)).EndInit();
            this.tsAddWhitelist.ResumeLayout(false);
            this.tsAddWhitelist.PerformLayout();
            this.groupBox26.ResumeLayout(false);
            this.groupBox26.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrNeedCmdControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrToplamAylikHak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrToplamHaftalikHak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAyarListeNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sePassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seAccMask1)).EndInit();
            this.tsInOutValues.ResumeLayout(false);
            this.tsInOutValues.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown63)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edtHowManyRead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStartRead)).EndInit();
            this.tbpHgsGenelAyarlar.ResumeLayout(false);
            this.tbpHgsGenelAyarlar.PerformLayout();
            this.groupBox20.ResumeLayout(false);
            this.groupBox20.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDaireAracHakkiOtoparkHakki)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDaireAracHakkiOtoparkHakkiDaire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHgsGenelAyarlarArac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHgsGenelAyarlarDaireHak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHgsGenelAyarlarDaire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHgsGenelAyarlarPazar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHgsGenelAyarlarCumartesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHgsGenelAyarlarCuma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHgsGenelAyarlarPersembe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHgsGenelAyarlarCarsamb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHgsGenelAyarlarSali)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHgsGenelAyarlarPazartesi)).EndInit();
            this.groupBox18.ResumeLayout(false);
            this.groupBox18.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHgsGenelAyarlarAppType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHgsGenelAyarlarArdisikGecisSuresi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHgsGenelAyarlarAracDaireSayisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHgsGenelAyarlarAntenKtanima)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHgsGenelAyarlarAntenGuc2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHgsGenelAyarlarAntenGuc1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHgsGenelAyarlarDiziArdisikKontrol2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHgsGenelAyarlarDiziArdisikKontrol1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHgsGenelAyarlarTransistorCikisi2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHgsGenelAyarlarTransistorCikisi1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHgsGenelAyarlarTagId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHgsGenelAyarlarKartBaslangici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHgsGenelAyarlarSeriPaketBoyutu)).EndInit();
            this.tbpCihazdanBilgiTransfer.ResumeLayout(false);
            this.groupBox19.ResumeLayout(false);
            this.groupBox19.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSayi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBaslangic)).EndInit();
            this.tbpYmk.ResumeLayout(false);
            this.groupBox22.ResumeLayout(false);
            this.groupBox22.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtYemekhaneYenidenOkumaZamanAralik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYemekhaneYenidenOkumaFiyatListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYemekhaneYenidenKartOkumaSayi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYemekhaneIstasyon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYemekhaneKartSektor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYemekhaneSeciliFiyatListesi)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrBlackListNo)).EndInit();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrParent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAdres)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edtCmtRetry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtPortNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtTimeOut)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.udPlog.ResumeLayout(false);
            this.udPlog.PerformLayout();
            this.groupBox24.ResumeLayout(false);
            this.groupBox24.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUdpPortNumber)).EndInit();
            this.groupBox27.ResumeLayout(false);
            this.groupBox27.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edtStatusMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStatusModeType)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbDfSize;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown edtCmtRetry;
        private System.Windows.Forms.TextBox edtDeviceKey;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown edtPortNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox edtIp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown edtTimeOut;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbProtocol;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.ComboBox cbReaderType;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDisConnect;
        private System.Windows.Forms.CheckBox cbAutoRxEnabled;
        private System.Windows.Forms.CheckBox cbAutoConnect;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TabControl tabCihazGenelBilgileri;
        private System.Windows.Forms.TabPage tbpDeviceGeneralSettings;
        private System.Windows.Forms.TabPage tsCominicationSettings;
        private System.Windows.Forms.GroupBox gbDeviceİnfo;
        private System.Windows.Forms.GroupBox grHeadTail;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.NumericUpDown edtTail;
        private System.Windows.Forms.NumericUpDown edtHead;
        private System.Windows.Forms.Button btnGetHead;
        private System.Windows.Forms.Label lblfwVersion;
        private System.Windows.Forms.Button btnfwVersion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSetHead;
        private System.Windows.Forms.GroupBox grDateTime;
        private System.Windows.Forms.Button btnSetDateTime;
        private System.Windows.Forms.DateTimePicker edtDateTime;
        private System.Windows.Forms.Timer dtTimer;
        private System.Windows.Forms.GroupBox grDeviceStatus;
        private System.Windows.Forms.Button btnSetDeviceStatus;
        private System.Windows.Forms.Button btnGetDeviceStatus;
        private System.Windows.Forms.RadioButton rbDeviceDisabled;
        private System.Windows.Forms.RadioButton rbDeviceEnabled;
        private System.Windows.Forms.GroupBox grDeviceOperation;
        private System.Windows.Forms.CheckBox cdSaveIPAddr;
        private System.Windows.Forms.Button btnSetDeviceFactoryDefaults;
        private System.Windows.Forms.Button btnReboot;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RichTextBox appLog;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox grDeviceWorkMode;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbOnlineEnabledOffline;
        private System.Windows.Forms.Button btnSetWorkMode;
        private System.Windows.Forms.Button btnGetWorkMode;
        private System.Windows.Forms.NumericUpDown edtOnlineTimeOut;
        private System.Windows.Forms.RadioButton rbOnlineUDP;
        private System.Windows.Forms.RadioButton rbOnlineTCP;
        private System.Windows.Forms.RadioButton rbOfflineCardBlackList;
        private System.Windows.Forms.RadioButton rbOfflineWhiteList;
        private System.Windows.Forms.GroupBox grDeviceGeneralSettings;
        private System.Windows.Forms.TabPage tsMfrKeyTable;
        private System.Windows.Forms.TabPage tsLCDMessages;
        private System.Windows.Forms.TabPage tsAccessSettings;
        private System.Windows.Forms.TabPage tsAddWhitelist;
        private System.Windows.Forms.TabPage tsInOutValues;
        private System.Windows.Forms.GroupBox grSerialNumber;
        private System.Windows.Forms.Button btnSetSerialNumber;
        private System.Windows.Forms.Button btnGetSerialNumber;
        private System.Windows.Forms.TextBox edtSerialNumber;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.NumericUpDown seAccMask1;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TextBox edtName;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox edtCardID;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.NumericUpDown sePassword;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.NumericUpDown seCode;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.DateTimePicker edtEndDate;
        private System.Windows.Forms.CheckBox cbAccessEnabled;
        private System.Windows.Forms.Button btnAddWhiteList;
        private System.Windows.Forms.CheckBox cbAccessCardEnabled;
        private System.Windows.Forms.CheckBox cbATCEnabled;
        private System.Windows.Forms.CheckBox cbAPBEnabled;
        private System.Windows.Forms.Label lblTanimliKisi;
        private System.Windows.Forms.Button btnClearWhiteList;
        private System.Windows.Forms.Button btnCardIDCnt;
        private System.Windows.Forms.Button btnGetWhiteList;
        private System.Windows.Forms.Button btnDeleteWhiteList;
        private System.Windows.Forms.Button btnEditWhiteList;
        private System.Windows.Forms.Label lblIndexNo;
        private System.Windows.Forms.RichTextBox richTextBoxRecs;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.NumericUpDown edtHowManyRead;
        private System.Windows.Forms.NumericUpDown edtStartRead;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Button btnTransferRecs;
        private System.Windows.Forms.Button btnReadRecs;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.TextBox edtFilePath;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.NumericUpDown edtRenkYogunlugu;
        private System.Windows.Forms.NumericUpDown edtArkaPlanIsigi;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.TextBox edtIkinciSatir;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.TextBox edtBirinciSatir;
        private System.Windows.Forms.NumericUpDown edtCihazNo;
        private System.Windows.Forms.DateTimePicker edtGunlukYenidenBaslatmaZamani;
        private System.Windows.Forms.CheckBox chkGunlukYenidenBaslatma;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton radioTransistorCikisi2NormalClosed;
        private System.Windows.Forms.RadioButton radioTransistorCikisi2NormalOpen;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioTransistorCikisi1NormalClosed;
        private System.Windows.Forms.RadioButton radioTransistorCikisi1NormalOpen;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton chkVarsayilanLogo;
        private System.Windows.Forms.RadioButton chkVarsayilanMesaj;
        private System.Windows.Forms.Button btnGonder;
        private System.Windows.Forms.Button btnGetir;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.NumericUpDown edtAyniKartiOkumaAraligi;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.NumericUpDown edtArdasikKartOkumaAraligi;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.NumericUpDown edtKartOkumaSuresi;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox edtHaberlesmeAyarlariServerIpAdress;
        private System.Windows.Forms.NumericUpDown edtHaberlesmeAyarlariPortNumarasi;
        private System.Windows.Forms.TextBox edtHaberlesmeIkinciDnsSunucu;
        private System.Windows.Forms.TextBox edtHaberlesmeBirinciDnsSunucu;
        private System.Windows.Forms.TextBox edtHaberlesmeAyarlariVarsayilanAgGecidi;
        private System.Windows.Forms.TextBox edtHaberlesmeAltAgMaskesi;
        private System.Windows.Forms.TextBox edtHaberlesmeIpAdresi;
        private System.Windows.Forms.ComboBox edtHaberlesmeAyarlariProtokol;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.CheckBox chkHaberlesmeAyarlariDHCPAktif;
        private System.Windows.Forms.CheckBox chkHaberlesmeAyarlariSadeceServerIleHaberles;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.NumericUpDown edtUDPayarlariPortNumarasi;
        private System.Windows.Forms.TextBox edtUDPayarlariIpAdresi;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.CheckBox chkUDPayarlariUDPLogAktif;
        private System.Windows.Forms.CheckBox chkUDPayarlariUDPAktif;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txtWebAraYuzuSifresi;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtMacAdresi;
        private System.Windows.Forms.Button btnMacAdresiGonder;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox textBox23;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.NumericUpDown edtHaberlesmeAyarlariTCPclientAyarlariPortNumarasi;
        private System.Windows.Forms.TextBox edtHaberlesmeAyarlariTCPclientAyarlariIpAdresi;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.CheckBox chkYenidenBaslat;
        private System.Windows.Forms.GroupBox groupBox17;
        private System.Windows.Forms.GroupBox groupBox16;
        private System.Windows.Forms.GroupBox groupBox15;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.RadioButton chkZilCaldirmaTransistorCikisi1;
        private System.Windows.Forms.RadioButton chkZilCaldirmaTransistorCikisi2;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.Button button29;
        private System.Windows.Forms.Button button30;
        private System.Windows.Forms.TextBox edtZilCaldirma2Satir;
        private System.Windows.Forms.TextBox edtZilCaldirma1Satir;
        private System.Windows.Forms.Label label113;
        private System.Windows.Forms.Label label114;
        private System.Windows.Forms.Label label115;
        private System.Windows.Forms.CheckBox chkZilCaldirmaEtkin;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.TextBox chkOkuyucuHizmetDisiAyarlariHizmet2Satir;
        private System.Windows.Forms.TextBox chkOkuyucuHizmetDisiAyarlariHizmet1Satir;
        private System.Windows.Forms.Label label111;
        private System.Windows.Forms.Label label112;
        private System.Windows.Forms.Label label110;
        private System.Windows.Forms.CheckBox chkOkuyucuHizmetDisiAyarlariHizmetDisiEtkin;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.NumericUpDown digerEKSAyarlariEKSverisi;
        private System.Windows.Forms.Label label109;
        private System.Windows.Forms.NumericUpDown digerEKSAyarlariKisiVerisi;
        private System.Windows.Forms.Label label108;
        private System.Windows.Forms.Label label107;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.NumericUpDown edtAntiPassBackArdisikGecisAraligi;
        private System.Windows.Forms.NumericUpDown edtUygulamaAyarlariGuvenlikBolgeNo;
        private System.Windows.Forms.ComboBox edtUygulamaAyarlariAPBtipi;
        private System.Windows.Forms.RadioButton radioUygulamaAyarlariAntiPassBackGiris;
        private System.Windows.Forms.RadioButton radioUygulamaAyarlariAntiPassBackCikis;
        private System.Windows.Forms.Label labeGecisAraligi;
        private System.Windows.Forms.Label labelGuvenlikBolgeNo;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.NumericUpDown edtUygulamaayarlariGecisSuresi;
        private System.Windows.Forms.Label labelGecisSuresi;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.ComboBox edtUygulamaAyariGirisTipi;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.ComboBox edtGenelAyarlarSifreGecisTipi;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.ComboBox edtGenelAyarlarGecisTipi;
        private System.Windows.Forms.RadioButton chkOkuyucuHizmetDisiAyarlariTransistorCikisi2;
        private System.Windows.Forms.RadioButton chkOkuyucuHizmetDisiAyarlariTransistorCikisi1;
        private System.Windows.Forms.RadioButton chkOkuyucuHizmetDisiAyarlariTransistorCikisiDegisiklikYok;
        private System.Windows.Forms.Label label116;
        private System.Windows.Forms.TabPage tbpHgsGenelAyarlar;
        private System.Windows.Forms.GroupBox groupBox18;
        private System.Windows.Forms.Button btnHgsGenelAyarlariGonder;
        private System.Windows.Forms.Button btnHgsGenelAyarlariGetir;
        private System.Windows.Forms.Label label129;
        private System.Windows.Forms.Label label128;
        private System.Windows.Forms.Label label127;
        private System.Windows.Forms.Label label126;
        private System.Windows.Forms.Label label125;
        private System.Windows.Forms.CheckBox txtHgsGenelAyarlarZamanKisitEtkin;
        private System.Windows.Forms.Label label124;
        private System.Windows.Forms.Label label123;
        private System.Windows.Forms.Label label122;
        private System.Windows.Forms.Label label121;
        private System.Windows.Forms.Label label120;
        private System.Windows.Forms.Label label119;
        private System.Windows.Forms.Label label118;
        private System.Windows.Forms.Label label117;
        private System.Windows.Forms.TabPage tbpCihazdanBilgiTransfer;
        private System.Windows.Forms.NumericUpDown txtHgsGenelAyarlarArdisikGecisSuresi;
        private System.Windows.Forms.NumericUpDown txtHgsGenelAyarlarAracDaireSayisi;
        private System.Windows.Forms.NumericUpDown txtHgsGenelAyarlarAntenKtanima;
        private System.Windows.Forms.NumericUpDown txtHgsGenelAyarlarAntenGuc2;
        private System.Windows.Forms.NumericUpDown txtHgsGenelAyarlarAntenGuc1;
        private System.Windows.Forms.NumericUpDown txtHgsGenelAyarlarDiziArdisikKontrol2;
        private System.Windows.Forms.NumericUpDown txtHgsGenelAyarlarDiziArdisikKontrol1;
        private System.Windows.Forms.ComboBox txtHgsGenelAyarlarProgramModu;
        private System.Windows.Forms.NumericUpDown txtHgsGenelAyarlarTransistorCikisi2;
        private System.Windows.Forms.NumericUpDown txtHgsGenelAyarlarTransistorCikisi1;
        private System.Windows.Forms.NumericUpDown txtHgsGenelAyarlarTagId;
        private System.Windows.Forms.NumericUpDown txtHgsGenelAyarlarKartBaslangici;
        private System.Windows.Forms.NumericUpDown txtHgsGenelAyarlarSeriPaketBoyutu;
        private System.Windows.Forms.DateTimePicker txtHgsGenelAyarlarKartinSonKullanmaTarihi;
        private System.Windows.Forms.Label label145;
        private System.Windows.Forms.Label label144;
        private System.Windows.Forms.Label label143;
        private System.Windows.Forms.Label label142;
        private System.Windows.Forms.Label label141;
        private System.Windows.Forms.Label label140;
        private System.Windows.Forms.Label label139;
        private System.Windows.Forms.NumericUpDown txtHgsGenelAyarlarArac;
        private System.Windows.Forms.NumericUpDown txtHgsGenelAyarlarDaireHak;
        private System.Windows.Forms.NumericUpDown txtHgsGenelAyarlarDaire;
        private System.Windows.Forms.Label lblHGSIndexNo;
        private System.Windows.Forms.TextBox txtHgsGenelAyarlarKartHGSAdi;
        private System.Windows.Forms.TextBox txtHgsGenelAyarlarKartId;
        private System.Windows.Forms.Button button38;
        private System.Windows.Forms.Label labelHgsTanimliKisiSayisi;
        private System.Windows.Forms.Button button37;
        private System.Windows.Forms.Button btnHgsBul;
        private System.Windows.Forms.Button btnHgsDegistir;
        private System.Windows.Forms.Button btnHgsSil;
        private System.Windows.Forms.Button btnHgsEkle;
        private System.Windows.Forms.CheckBox txtHgsGenelAyarlarKisitKontroluOlsunMu;
        private System.Windows.Forms.CheckBox txtHgsGenelAyarlarAntiPassBackKontroluOlsunMu;
        private System.Windows.Forms.CheckBox txtHgsGenelAyarlarKisiCihazdaAktifMi;
        private System.Windows.Forms.Label label136;
        private System.Windows.Forms.NumericUpDown txtHgsGenelAyarlarPazar;
        private System.Windows.Forms.NumericUpDown txtHgsGenelAyarlarCumartesi;
        private System.Windows.Forms.NumericUpDown txtHgsGenelAyarlarCuma;
        private System.Windows.Forms.NumericUpDown txtHgsGenelAyarlarPersembe;
        private System.Windows.Forms.NumericUpDown txtHgsGenelAyarlarCarsamb;
        private System.Windows.Forms.NumericUpDown txtHgsGenelAyarlarSali;
        private System.Windows.Forms.NumericUpDown txtHgsGenelAyarlarPazartesi;
        private System.Windows.Forms.Label label135;
        private System.Windows.Forms.Label label134;
        private System.Windows.Forms.Label label133;
        private System.Windows.Forms.Label label132;
        private System.Windows.Forms.Label label131;
        private System.Windows.Forms.Label label130;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.GroupBox groupBox19;
        private System.Windows.Forms.Label label146;
        private System.Windows.Forms.TextBox textBox32;
        private System.Windows.Forms.Button button39;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnHgsVerileriTransferEt;
        private System.Windows.Forms.Button btnHgsCihazdangelenBilgileriOku;
        private System.Windows.Forms.Label label148;
        private System.Windows.Forms.NumericUpDown txtSayi;
        private System.Windows.Forms.Label label147;
        private System.Windows.Forms.NumericUpDown txtBaslangic;
        private System.Windows.Forms.Label label151;
        private System.Windows.Forms.NumericUpDown numericUpDown63;
        private System.Windows.Forms.Label label150;
        private System.Windows.Forms.Button button42;
        private System.Windows.Forms.CheckBox edtGenelAyarlarZamanKisitTablosuEtkin;
        private System.Windows.Forms.Button button43;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.ComboBox txtUygulamaTipi;
        private System.Windows.Forms.Button btnMacAdresiGetir;
        private System.Windows.Forms.GroupBox groupBox20;
        private System.Windows.Forms.Button btnDaireAracHakkiGonder;
        private System.Windows.Forms.Button btnDaireAracHakkiGetir;
        private System.Windows.Forms.NumericUpDown txtDaireAracHakkiOtoparkHakki;
        private System.Windows.Forms.Label label106;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.NumericUpDown txtDaireAracHakkiOtoparkHakkiDaire;
        private System.Windows.Forms.Button btnDaireBul;
        private System.Windows.Forms.Button btnDaireSil;
        private System.Windows.Forms.NumericUpDown txtHgsGenelAyarlarAppType;
        private System.Windows.Forms.Label label137;
        private System.Windows.Forms.GroupBox groupBox21;
        private System.Windows.Forms.Button btnSeriPortGonder;
        private System.Windows.Forms.Button btnSeriPortGetir;
        private System.Windows.Forms.Button btnSeriPortTest;
        private System.Windows.Forms.ComboBox txtSeri1BaudRate;
        private System.Windows.Forms.ComboBox txtSeri0BaudRate;
        private System.Windows.Forms.Label label152;
        private System.Windows.Forms.Label label138;
        private System.Windows.Forms.TabPage tbpYmk;
        private System.Windows.Forms.GroupBox groupBox22;
        private System.Windows.Forms.Button btnYemekhaneAyariGonder;
        private System.Windows.Forms.Button btnYemekhaneAyarlariGetir;
        private System.Windows.Forms.NumericUpDown txtYemekhaneYenidenOkumaZamanAralik;
        private System.Windows.Forms.NumericUpDown txtYemekhaneYenidenOkumaFiyatListesi;
        private System.Windows.Forms.NumericUpDown txtYemekhaneYenidenKartOkumaSayi;
        private System.Windows.Forms.NumericUpDown txtYemekhaneIstasyon;
        private System.Windows.Forms.NumericUpDown txtYemekhaneKartSektor;
        private System.Windows.Forms.NumericUpDown txtYemekhaneSeciliFiyatListesi;
        private System.Windows.Forms.Label label159;
        private System.Windows.Forms.Label label158;
        private System.Windows.Forms.Label label157;
        private System.Windows.Forms.Label label156;
        private System.Windows.Forms.Label label155;
        private System.Windows.Forms.Label label154;
        private System.Windows.Forms.Label label153;
        private System.Windows.Forms.ComboBox txtYemekhaneUygulamaTipi;
        private System.Windows.Forms.Button btnKontorFiyatListesi;
        private System.Windows.Forms.Button button31;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button33;
        private System.Windows.Forms.Button btnHaftaninGunIsimleri;
        private System.Windows.Forms.NumericUpDown txtServerEchoZamanAsimi;
        private System.Windows.Forms.Label label160;
        private System.Windows.Forms.GroupBox groupBox23;
        private System.Windows.Forms.GroupBox groupBox24;
        private System.Windows.Forms.NumericUpDown txtUdpPortNumber;
        private System.Windows.Forms.Label label161;
        private System.Windows.Forms.Button btnUdpTemizle;
        private System.Windows.Forms.Button btnUDPbaslat;
        public System.Windows.Forms.GroupBox udPlog;
        public System.Windows.Forms.TextBox udpLogText;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.ComboBox cbSerialAppType;
        private System.Windows.Forms.Label label162;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label83;
        private System.Windows.Forms.Label label82;
        private System.Windows.Forms.Label label81;
        private System.Windows.Forms.Label label80;
        private System.Windows.Forms.NumericUpDown ekranMesajiOnlieSatir5y;
        private System.Windows.Forms.NumericUpDown ekranMesajiOnlieSatir5x;
        private System.Windows.Forms.NumericUpDown ekranMesajiOnlieSatir4y;
        private System.Windows.Forms.NumericUpDown ekranMesajiOnlieSatir4x;
        private System.Windows.Forms.NumericUpDown ekranMesajiOnlieSatir3y;
        private System.Windows.Forms.NumericUpDown ekranMesajiOnlieSatir3x;
        private System.Windows.Forms.NumericUpDown ekranMesajiOnlieSatir2y;
        private System.Windows.Forms.NumericUpDown ekranMesajiOnlieSatir2x;
        private System.Windows.Forms.NumericUpDown ekranMesajiOnlieSatir1y;
        private System.Windows.Forms.NumericUpDown ekranMesajiOnlieSatir1x;
        private System.Windows.Forms.Button btnHaberlesmeAyariGonder;
        private System.Windows.Forms.CheckBox chkedtEkranMesajlariBlink;
        private System.Windows.Forms.NumericUpDown edtEkranMesajlariBuzzerSuresi;
        private System.Windows.Forms.NumericUpDown edtEkranMesajlariRoleSuresi2;
        private System.Windows.Forms.NumericUpDown edtEkranMesajlariRoleSuresi1;
        private System.Windows.Forms.NumericUpDown edtEkranMesajlariEkranSure;
        private System.Windows.Forms.ComboBox edtEkranMesajlariFontTipi;
        private System.Windows.Forms.NumericUpDown edtEkranMesajiSatirSayisi;
        private System.Windows.Forms.TextBox edtEkranMesajlariAltBaslik;
        private System.Windows.Forms.ComboBox edtEkranMesajlariAltBaslikTipi;
        private System.Windows.Forms.TextBox ekranMesajiOnlieSatir5;
        private System.Windows.Forms.TextBox ekranMesajiOnlieSatir4;
        private System.Windows.Forms.TextBox ekranMesajiOnlieSatir3;
        private System.Windows.Forms.TextBox ekranMesajiOnlieSatir2;
        private System.Windows.Forms.TextBox ekranMesajiOnlieSatir1;
        private System.Windows.Forms.TextBox edtEkranMesajlariUstBaslik;
        private System.Windows.Forms.Label label79;
        private System.Windows.Forms.Label label78;
        private System.Windows.Forms.Label label77;
        private System.Windows.Forms.Label label76;
        private System.Windows.Forms.Label label75;
        private System.Windows.Forms.Label label74;
        private System.Windows.Forms.Label label73;
        private System.Windows.Forms.Label label72;
        private System.Windows.Forms.Label label71;
        private System.Windows.Forms.Label label70;
        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.Label label67;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.ComboBox edtEkranMesajlariUstBaslikTipi;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label149;
        private System.Windows.Forms.ComboBox edtCihazMesajTipiOffline;
        private System.Windows.Forms.Label label84;
        private System.Windows.Forms.Label label85;
        private System.Windows.Forms.Label label86;
        private System.Windows.Forms.Label label87;
        private System.Windows.Forms.NumericUpDown ekranMesajiOfflineSatir5z;
        private System.Windows.Forms.NumericUpDown ekranMesajiOfflineSatir5x;
        private System.Windows.Forms.NumericUpDown ekranMesajiOfflineSatir4z;
        private System.Windows.Forms.NumericUpDown ekranMesajiOfflineSatir4x;
        private System.Windows.Forms.NumericUpDown ekranMesajiOfflineSatir3z;
        private System.Windows.Forms.NumericUpDown ekranMesajiOfflineSatir3x;
        private System.Windows.Forms.NumericUpDown ekranMesajiOfflineSatir2z;
        private System.Windows.Forms.NumericUpDown ekranMesajiOfflineSatir2x;
        private System.Windows.Forms.NumericUpDown ekranMesajiOfflineSatir1z;
        private System.Windows.Forms.NumericUpDown ekranMesajiOfflineSatir1x;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox chkekranMesajiOfflineBlink;
        private System.Windows.Forms.NumericUpDown ekranMesajiOfflineBuzzerSuresi;
        private System.Windows.Forms.NumericUpDown ekranMesajiOfflineRoleSuresi2;
        private System.Windows.Forms.NumericUpDown ekranMesajiOfflineRoleSuresi1;
        private System.Windows.Forms.NumericUpDown ekranMesajiOfflineEkranSuresi;
        private System.Windows.Forms.ComboBox ekranMesajiOfflinealtBaslikFontTipi;
        private System.Windows.Forms.NumericUpDown edtEkranMesajiSatirSayisiOffline;
        private System.Windows.Forms.TextBox ekranMesajiOfflinealtBaslik;
        private System.Windows.Forms.ComboBox ekranMesajiOfflinealtBaslikTipi;
        private System.Windows.Forms.TextBox ekranMesajiOfflineSatir5;
        private System.Windows.Forms.TextBox ekranMesajiOfflineSatir4;
        private System.Windows.Forms.TextBox ekranMesajiOfflineSatir3;
        private System.Windows.Forms.TextBox ekranMesajiOfflineSatir2;
        private System.Windows.Forms.TextBox ekranMesajiOfflineSatir1;
        private System.Windows.Forms.TextBox edtCihazMesajUstBaslikOffline;
        private System.Windows.Forms.Label label88;
        private System.Windows.Forms.Label label89;
        private System.Windows.Forms.Label label90;
        private System.Windows.Forms.Label label91;
        private System.Windows.Forms.Label label92;
        private System.Windows.Forms.Label label93;
        private System.Windows.Forms.Label label94;
        private System.Windows.Forms.Label label95;
        private System.Windows.Forms.Label label96;
        private System.Windows.Forms.Label label97;
        private System.Windows.Forms.Label label98;
        private System.Windows.Forms.Label label99;
        private System.Windows.Forms.Label label100;
        private System.Windows.Forms.Label label101;
        private System.Windows.Forms.Label label102;
        private System.Windows.Forms.Label label103;
        private System.Windows.Forms.Label label104;
        private System.Windows.Forms.Label label105;
        private System.Windows.Forms.ComboBox edtCihazMesajUstBaslikTipiOffline;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox25;
        private System.Windows.Forms.Button btnInputBoxMesajGonder;
        private System.Windows.Forms.CheckBox txtInputBoxMesajGonderIsBlink;
        private System.Windows.Forms.Label label177;
        private System.Windows.Forms.Label label175;
        private System.Windows.Forms.NumericUpDown txtInputBoxMesajGonderBuzzerSure1;
        private System.Windows.Forms.Label label176;
        private System.Windows.Forms.Label label171;
        private System.Windows.Forms.Label label172;
        private System.Windows.Forms.NumericUpDown txtInputBoxMesajGonderRoleSure2;
        private System.Windows.Forms.NumericUpDown txtInputBoxMesajGonderRoleSure1;
        private System.Windows.Forms.Label label173;
        private System.Windows.Forms.Label label174;
        private System.Windows.Forms.Label label169;
        private System.Windows.Forms.NumericUpDown txtInputBoxMesajGonderEkranSure;
        private System.Windows.Forms.Label label170;
        private System.Windows.Forms.NumericUpDown txtInputBoxMesajGonderIkinciSatirZ;
        private System.Windows.Forms.NumericUpDown txtInputBoxMesajGonderIkinciSatirX;
        private System.Windows.Forms.TextBox txtInputBoxMesajGonderIkinciSatir;
        private System.Windows.Forms.Label label168;
        private System.Windows.Forms.NumericUpDown txtInputBoxMesajGonderBirinciSatirZ;
        private System.Windows.Forms.NumericUpDown txtInputBoxMesajGonderBirinciSatirx;
        private System.Windows.Forms.TextBox txtInputBoxMesajGonderBirinciSatir;
        private System.Windows.Forms.Label label167;
        private System.Windows.Forms.Label label165;
        private System.Windows.Forms.Label label166;
        private System.Windows.Forms.TextBox txtInputBoxMesajGonderBaslik;
        private System.Windows.Forms.Label label164;
        private System.Windows.Forms.Label label163;
        private System.Windows.Forms.ComboBox txtInputBoxMesajGonderUstBaslikTipi;
        private System.Windows.Forms.Label label179;
        private System.Windows.Forms.Label label178;
        private System.Windows.Forms.NumericUpDown txtInputBoxMesajGonderKlavyeTipi;
        private System.Windows.Forms.Label label181;
        private System.Windows.Forms.Label label180;
        private System.Windows.Forms.ListBox richTextRec2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnTopluAktarim;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label label182;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblMesaj;
        private System.Windows.Forms.Button button32;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label label183;
        private System.Windows.Forms.Label label184;
        private System.Windows.Forms.Button button34;
        private System.Windows.Forms.Label label185;
        private System.Windows.Forms.ComboBox cmbFontTipi;
        private System.Windows.Forms.NumericUpDown nmrKartLoginBeklemeSuresi;
        private System.Windows.Forms.Label label186;
        private System.Windows.Forms.ComboBox cmbOnlineKartModu;
        private System.Windows.Forms.Label label187;
        private System.Windows.Forms.CheckBox chkAcilDurumlardaGecizIzni;
        private System.Windows.Forms.CheckBox chkKartOfflinedaOnlineCalissin;
        private System.Windows.Forms.Label label188;
        private System.Windows.Forms.DateTimePicker dtDogumTarihi;
        private System.Windows.Forms.GroupBox groupBox26;
        private System.Windows.Forms.NumericUpDown nmrNeedCmdControl;
        private System.Windows.Forms.NumericUpDown nmrToplamAylikHak;
        private System.Windows.Forms.NumericUpDown nmrToplamHaftalikHak;
        private System.Windows.Forms.NumericUpDown nmrAyarListeNo;
        private System.Windows.Forms.Label label192;
        private System.Windows.Forms.Label label191;
        private System.Windows.Forms.Label label190;
        private System.Windows.Forms.Label label189;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Button BtnBlackListPersonelBul;
        private System.Windows.Forms.Button BtnBlackListPersonelSil;
        private System.Windows.Forms.Button BtnBlackListPersonelDegistir;
        private System.Windows.Forms.Button BtnBlackListPersonelSayisi;
        private System.Windows.Forms.Button BtnBlackListPersonelEkle;
        private System.Windows.Forms.NumericUpDown nmrBlackListNo;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.TextBox edtBlackListAd;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.TextBox edtBlackListKartId;
        private System.Windows.Forms.Button btnTanimliBlackListKullanicilariSil;
        private System.Windows.Forms.Label lblTanimliBlackListSayisi;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.NumericUpDown nmrParent;
        private System.Windows.Forms.NumericUpDown nmrRight;
        private System.Windows.Forms.NumericUpDown nmrLeft;
        private System.Windows.Forms.NumericUpDown nmrColor;
        private System.Windows.Forms.NumericUpDown nmrAdres;
        private System.Windows.Forms.Label label194;
        private System.Windows.Forms.Label label193;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Button btnNodeGetir;
        private System.Windows.Forms.Button btnNodeGonder;
        private System.Windows.Forms.Button button35;
        private System.Windows.Forms.Button button36;
        private System.Windows.Forms.Button button44;
        private System.Windows.Forms.Button button41;
        private System.Windows.Forms.Button button40;
        private System.Windows.Forms.Button button45;
        private System.Windows.Forms.ComboBox cmbOgunDisindaOkuyucuNeYapsin;
        private System.Windows.Forms.Label label195;
        private System.Windows.Forms.Label lblInputDuration;
        private System.Windows.Forms.ComboBox cbPersTZMode;
        private System.Windows.Forms.Button btnPersTZMode;
        private System.Windows.Forms.GroupBox groupBox27;
        private System.Windows.Forms.Button btnGetStatusMode;
        private System.Windows.Forms.Button btnSendStatusMode;
        private System.Windows.Forms.NumericUpDown edtStatusModeType;
        private System.Windows.Forms.NumericUpDown edtStatusMode;
        private System.Windows.Forms.Label label197;
        private System.Windows.Forms.Label label196;
    }
}


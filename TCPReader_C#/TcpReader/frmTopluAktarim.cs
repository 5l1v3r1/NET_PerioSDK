using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using PerioTcpRdrBase;
using PerioTCPRdr;
using System.Collections;
using System.Net.Sockets;
using System.Net;

namespace TCPReader
{
    public partial class frmTopluAktarim : Form
    {
        public frmTopluAktarim()
        {
            InitializeComponent();
        }

        PerioTCPRdrComp[] rdr;


        public Thread thrBaglan;


        public void thrYap()
        {
            thrBaglan = new Thread(new ThreadStart(start));
            thrBaglan.Start();
        }

        public void start()
        {
            for (int i = 0; i < rdr.Length; i++)
            {
                switch ( cbReaderType.SelectedIndex )
                {
                    case 0: rdr[i].ReaderType = TReaderType.rdr63M_V3 ; break;
                    case 1: rdr[i].ReaderType = TReaderType.rdr63M_V5 ; break;
                    case 2: rdr[i].ReaderType = TReaderType.rdr26M ; break;
                }

                switch (cbProtocol.SelectedIndex)
                {
                    case 0: rdr[i].pProtocolType = TProtocolType.PR0; break;
                    case 1: rdr[i].pProtocolType = TProtocolType.PR1; break;
                    case 2: rdr[i].pProtocolType = TProtocolType.PR2; break;
                    case 3: rdr[i].pProtocolType = TProtocolType.PR3; break;
                }

                switch (cbDfSize.SelectedIndex)
                {
                    case 0: rdr[i].DFType = TDFType.df4MB; break;
                    case 1: rdr[i].DFType = TDFType.df8MB; break;
                }

                switch (txtUygulamaTipi.SelectedIndex)
                {
                    case 0: { rdr[i].fwAppType = TfwAppType.fwHGS; break; };
                    case 1: { rdr[i].fwAppType = TfwAppType.fwPDKS; break; };
                    case 2: { rdr[i].fwAppType = TfwAppType.fwYMK; break; };
                    default:
                    break;
                }

                foreach (Control item in pnlListe.Controls)
                {
                    if (item is TextBox)
                    {
                        if (item.Name == "txtIp_"+i.ToString())
                        {
                            rdr[i].IP = item.Text;            
                        }
                    }
                }

                rdr[i].Port = (int)edtPortNo.Value;
                rdr[i].TimeOut = (int)edtTimeOut.Value;
                rdr[i].DeviceLoginKey = edtDeviceKey.Text;
                rdr[i].CommandRetry = (int)edtCmtRetry.Value;
                rdr[i].AutoConnect = cbAutoConnect.Checked;
                rdr[i].AutoRxEnabled = cbAutoRxEnabled.Checked;

                switch (txtUygulamaTipi.SelectedIndex)
                {
                    case 0: rdr[i].fwAppType = TfwAppType.fwPDKS; break;
                    case 1: rdr[i].fwAppType = TfwAppType.fwHGS; break;
                    case 2: rdr[i].fwAppType = TfwAppType.fwYMK; break;

                    default:
                        break;
                }
                rdr[i].OnlineReConnectTimeOut = 5000;

                try
                {
                    addLog("Ip Adresi :" + rdr[i].IP + " bağlanmaya çalışılıyor...");
                    rdr[i].Connect();
                }
                finally
                {
                    if (!rdr[i].Connected)
                    {
                        addLog("Ip Adresi :" + rdr[i].IP + " bağlantı sağlanamadı.");
                    }
                    else
                    {
                        addLog("Ip Adresi :" + rdr[i].IP + " bağlantı sağlandı.");
                    }
                
                    
                }

                



            }

        }

        void addLog(string lg)
        {

            txtLog.AppendText(lg + "\n");
        
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (rdr !=null)
            {
                if (rdr.Length > 0)
                    Array.Resize(ref rdr, 0);
                
            }

            pnlListe.Controls.Clear();
            

            TextBox txtIp;
            Label lblIp;

            if (numericUpDown1.Value > 0)
            {
                rdr = new PerioTCPRdrComp[(int)numericUpDown1.Value];

                for (int i = 0; i < rdr.Length; i++)
                {
                    rdr[i] = new PerioTCPRdrComp();

                    lblIp = new Label();
                    lblIp.Left = 5;
                    lblIp.Text = (i+1).ToString() + ". cihaz için IP : ";
                    lblIp.Top = 25 * i;

                    txtIp = new TextBox();
                    txtIp.Name = "txtIp_" + i.ToString();
                    txtIp.Width = 100;
                    txtIp.Left = lblIp.Width + 10 ;
                    txtIp.Top = 25 * i;
                    pnlListe.Controls.Add(lblIp);
                    pnlListe.Controls.Add(txtIp);
                }
            }
            else
                MessageBox.Show("Lütfen kaç cihaz oluşturmak istediğinizi belirtiniz.");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int txtCount=0;

            if (pnlListe.Controls.Count > 0)
            {

                if (rdr != null)
                {

                    foreach (Control item in pnlListe.Controls)
                    {
                        if (item is TextBox)
                        {
                            TextBox ipTxt = item as TextBox;

                            if (ipTxt.Text =="" )
                            {
                                txtCount++;
                            }

                        }
                    }

                }

            }

            if (txtCount > 0)
            {
                MessageBox.Show(txtCount.ToString() + " adet ip adresi girilmemiş." );
            }
            else
            {
                thrYap();
            }

            

        }

        private void frmTopluAktarim_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }


        Thread aktar;

        public void thrAktar()
        {
            aktar = new Thread(new ThreadStart(thrSimdiAktar));
            aktar.Start();
        }

        private string randomString()
        {
            //C4E3B82E000000
            string result = "";
            Random rnd = new Random();
            result = rnd.Next(100000, 999999).ToString();
            System.Threading.Thread.Sleep(1000);
            result = "C4E3B82E" + result;
            return result;
        }

        public void thrSimdiAktar()
        {
            for (int i = 0; i < rdr.Length; i++)
            {

                if (rdr[i].Connected)
                {
                    for (int k = 0; k < (int)nmrKayit.Value; k++)
                    {
                        int iErr;
                        uint InxNm;
                        string CardID;
                        CardID = randomString();

                        if (rdr[i].IsHex(CardID) && (CardID.Length == 14))
                        {

                            TPerson Person = new TPerson();
                            Person.CardID = CardID;
                            Person.Name = CardID;
                            Person.Code = (uint)k;
                            Person.Password = (ushort)0;
                            Person.AccessDevice = true;
                            Person.APBEnabled = true;
                            Person.AccessCardEnabled = false;
                            iErr = rdr[i].AddWhitelist(Person, out InxNm);

                            switch (iErr)
                            {
                                case 0:
                                    addLog(i.ToString() +  ". cihaza ["+ rdr[i].IP.ToString() +"] Kişi eklendi.");
                                    break;
                                case 1:
                                    addLog(i.ToString() +  ". cihaza ["+ rdr[i].IP.ToString() +"] Daha önce eklenmiş.");
                                    break;
                                case 20:
                                    addLog(i.ToString() + ". cihaza [" + rdr[i].IP.ToString() + "] Şifre kapasitesi aşıldı.");
                                    break;
                                case 51:
                                    addLog(i.ToString() + ". cihaza [" + rdr[i].IP.ToString() + "] Bu Kart ID daha önce tanımlanmış.");
                                    break;
                                case 52:
                                    addLog(i.ToString() + ". cihaza [" + rdr[i].IP.ToString() + "] Bu şifre daha önce tanımlanmış.");
                                    break;
                                default:
                                    addLog(i.ToString() + ". cihaza [" + rdr[i].IP.ToString() + "] Hata iErr : " + iErr.ToString());
                                    break;
                            }

                        }


                    }
                }
                else
                {
                    addLog(i.ToString()+ " . cihaza bağlantı yok. Tekrar deneyecek.");
                }

               
            
            }

            
           

            for (int l = 0; l < rdr.Length; l++)
            {
                rdr[l].DisConnect();

                if (!rdr[l].Connected)
                {
                    addLog(l.ToString()+ " . Bağlantı başarıyla kesildi.");
                }
            }
            addLog("Sonlandı.");
            MessageBox.Show("İşlem tamamlandı.");

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            thrAktar();
        }

        private void frmTopluAktarim_FormClosed(object sender, FormClosedEventArgs e)
        {

            for (int i = 0; i < rdr.Length; i++)
            {
                rdr[i].DisConnect();
            }

            if (thrBaglan.ThreadState != ThreadState.Suspended)
            {
                thrBaglan.Abort();
            }

            if (aktar.ThreadState != ThreadState.Suspended)
            {
                aktar.Abort();
            }


            
        }

    }
}

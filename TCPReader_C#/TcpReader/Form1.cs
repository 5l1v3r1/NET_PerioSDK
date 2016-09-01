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
using hexToDecimal;



namespace TCPReader
{
    public struct TMsg
    {
        public ushort MsgID;
        public string MsgName;
    }    
   
    public partial class frmMain : Form
    {
        public static PerioTCPRdrComp rdr;
       
        TMsg[] OffflineMsg = new TMsg[78];
  
         public frmMain()
        {
            InitializeComponent();
        }

         Boolean ReadDataBlock;
         TInputConfirmationType ConfirmationType;

         HexToDecimal ht = new HexToDecimal();

        private void frmMain_Load(object sender, EventArgs e)
        {
            rdr = new PerioTCPRdrComp();
            rdr.OnRxCardID += new RxCardID(rdrOnRxCardID);
            rdr.OnRxTurnstileTurn += new RxTurnstileTurn(rdrOnTurnstileTurn);
            rdr.OnRxSerialReadStr += new RxSerialReadStr(rdrOnRxSerialStr);
            rdr.OnRxDoorOpenAlarm += new RxDoorOpenAlarm(rdrOnRxDoorOpenAlarm);
            rdr.OnRxTagRead += new RxTagRead(rdrOnTagRead);
            rdr.OnPasswordRead += new RxPasswordRead(rdrOnPasswordRead);
            rdr.OnRxInputText += new RxInputText(rdrOnInputText);
            rdr.OnConnected += new DeviceConnected(rdrOnConnected);
            rdr.OnDisConnected += new DeviceDisConnected(rdrOnDisConnected);
            dtTimer.Enabled = true;
            txtUygulamaTipi.SelectedIndex = 0;
            ReadDataBlock = false;

            CheckForIllegalCrossThreadCalls = false;

        }

        void SendUdpDataToLog(string str)
        {
            MethodInvoker method = delegate
            {
                udpLogText.AppendText(str);

            };

            if (InvokeRequired)
                BeginInvoke(method);
            else method.Invoke();

        }

        private void StartListener(int portNumber)
        {
            bool bitti = false;
            
            UdpClient listener = new UdpClient(portNumber);
            IPEndPoint groupEP = new IPEndPoint(IPAddress.Any, portNumber);
            try
            {
                while (!bitti)
                {
                    byte[] bytes = listener.Receive(ref groupEP);
                    SendUdpDataToLog("Received broadcast from {0} :\n {1}\n" + groupEP.ToString() + Encoding.ASCII.GetString(bytes, 0, bytes.Length));
                }
            }
            catch (Exception e)
            {
                udpLogText.AppendText("Hata oluştu : " + e.ToString());
            }
            finally
            {
                listener.Close();
            }
        }


        void rdrOnRxDoorOpenAlarm(object source, RxDoorOpenAlarmArgs e)
        {
            MethodInvoker method = delegate
            {
                if (e.DoorOpen)
                {
                    AddLog("Kapı Açık Kaldı. ");
                }
                else {

                    AddLog("Kapı kapandı. Açık kalan süre [" + Convert.ToString(e.OpenTime) + "]." );
                }
            };

            if (InvokeRequired)
                BeginInvoke(method);
            else method.Invoke();


        }

     
        void rdrOnRxCardID(object source, RxCardIDArgs e)
        {

            byte[] DataValue = new byte[16];
            String str;

            PerioTCPRdrComp s = source as PerioTCPRdrComp;

            lblMesaj.Text = "Kart kondu";

            MethodInvoker method = delegate
            {
                AddLog("Okunulan Kart ID [" + e.CardID + "]." + " IP: " + s.IP +" device Id: " + s.DeviceID + " device name: " + s.DeviceName);

               /* if (e.CardID == "1967327B000000")
                    rdr.SetBeepRelayAndSecreenMessage(0, 0, "gecerli kart", "gecerli kart", "tunc gulec", "", "", "", "", 5, 15, 0, 5, 35, 0, (byte)ekranMesajiOnlieSatir3x.Value, (byte)ekranMesajiOnlieSatir3y.Value, 0, (byte)ekranMesajiOnlieSatir4x.Value, (byte)ekranMesajiOnlieSatir4y.Value, 0, (byte)ekranMesajiOnlieSatir5x.Value, (byte)ekranMesajiOnlieSatir5x.Value, 0, 2, 2, 20, 2000, 2000, 2000, true);
                else
                    rdr.SetBeepRelayAndSecreenMessage(0, 0, "gecersiz kart", "gecersiz kart", e.CardID.ToString(), "", "", "", "", 5, 15, 0, 5, 35, 0, (byte)ekranMesajiOnlieSatir3x.Value, (byte)ekranMesajiOnlieSatir3y.Value, 0, (byte)ekranMesajiOnlieSatir4x.Value, (byte)ekranMesajiOnlieSatir4y.Value, 0, (byte)ekranMesajiOnlieSatir5x.Value, (byte)ekranMesajiOnlieSatir5x.Value, 0, 2, 2, 20, 0, 0, 2000, false);
                    */

                if (ReadDataBlock)
                {
                    if (rdr.ReadCardBlockData(5, 1, TKeyType.ktKeyA, out DataValue))
                    {
                    str = "";

                    for (int i = 0; i < 16; i++)
                    {
                        if (str == "")
                        {
                            str = Convert.ToString(DataValue[i]);
                        }
                        else
                        {
                            str += "-" + Convert.ToInt32(DataValue[i]);
                        }
                    }

                    AddLog("Okunulan değer [" + str + "]");

                        // veritabanı bağlantı kodları bu alana yazılmalı
                    

                    for (int i = 0; i < 16; i++)
                    {
                        DataValue[i] = (byte)(i + 2);
                    }


                    if (rdr.WriteCardBlockData(5,1, TKeyType.ktKeyA, DataValue))
                    {
                        AddLog("Data yazıldı.");
                    }

                 }

                }


                //MessageBox.Show(ht.ConvertHexToDecimal(e.CardID).ToString());

                
                if (ReadDataBlock)
                {

                    if (rdr.ReadCardBlockData(5, 1, TKeyType.ktKeyA, out DataValue))
                    {
                        str = "";

                        for (int i = 0; i < 16; i++)
                        {
                            if (str == "")
                            {
                                str = Convert.ToString(DataValue[i]);
                            }
                            else
                            {
                                str += "-" + Convert.ToString(DataValue[i]);
                            }


                        }

                        AddLog("Okunulan değer 2 [" + str + "]");
                    }


                }



            };
            if (InvokeRequired)
                BeginInvoke(method);
            else
                method.Invoke();
        }


        void rdrOnTagRead(object source, RxTagReadArgs e)
        {
            MethodInvoker method = delegate
            {
                
                AddLog("Okunulan Tag ID [" + e.TagId + " - IO : " + Convert.ToString(e.IO) + "].");
                rdr.SetBeepRelayAndSecreenMessage(0, 0, "", e.TagId.ToString(), e.TagId.ToString(), "", "", "", "", 5, 15, 0, 5, 35, 0, (byte)ekranMesajiOnlieSatir3x.Value, (byte)ekranMesajiOnlieSatir3y.Value, 0, (byte)ekranMesajiOnlieSatir4x.Value, (byte)ekranMesajiOnlieSatir4y.Value, 0, (byte)ekranMesajiOnlieSatir5x.Value, (byte)ekranMesajiOnlieSatir5x.Value, 0, 2, 2, 5, 5, 0, 10, false);

                //hgs için veritabanı

            };


            if (InvokeRequired)
            {
                BeginInvoke(method);
            }
            else { method.Invoke(); }
        }


        void rdrOnPasswordRead(object source, RxPasswordReadArgs e)
        {

            MethodInvoker method = delegate
            {
                AddLog("Girilen şifre tipi : [" + Convert.ToString(e.PassType) + "] şifre : [" + Convert.ToString(e.Password) + "] personel kodu: [" + Convert.ToString(e.Code) + "]");
                rdr.SetBeepRelayAndSecreenMessage(0, 0, "", "Online Şifre", "Şifre", "", "", "", "", 5, 15, 0, 5, 35, 0, (byte)ekranMesajiOnlieSatir3x.Value, (byte)ekranMesajiOnlieSatir3y.Value, 0, (byte)ekranMesajiOnlieSatir4x.Value, (byte)ekranMesajiOnlieSatir4y.Value, 0, (byte)ekranMesajiOnlieSatir5x.Value, (byte)ekranMesajiOnlieSatir5x.Value, 0, 2, 2, 5, 5, 0, 10, false);
            };

            if (InvokeRequired)
            {
                BeginInvoke(method);
            }
            else { method.Invoke(); }
        
        }


        void rdrOnInputText(object source, RxInputTextArgs e)
        {

            MethodInvoker method = delegate
            {

                if (e.ConfirmationType == TInputConfirmationType.ctOk)
                {
                    AddLog("Onay Tipi : [OK] - InputText [" + e.InputText + "]");
                    rdr.SetBeepRelayAndSecreenMessage(0, 0, "", "İşlem ", "Tamam", "", "", "", "",5, 15, 0, 5, 35, 0, (byte)ekranMesajiOnlieSatir3x.Value, (byte)ekranMesajiOnlieSatir3y.Value, 0, (byte)ekranMesajiOnlieSatir4x.Value, (byte)ekranMesajiOnlieSatir4y.Value, 0, (byte)ekranMesajiOnlieSatir5x.Value, (byte)ekranMesajiOnlieSatir5y.Value, 0, 2, 2, 5, 5, 0, 10, false);
                    
                }
                else
                {

                    AddLog("Onay Tipi : [CANCEL] - InputText [" + e.InputText + "]");
                }
            };

            if (InvokeRequired)
            {
                BeginInvoke(method);
            }
            else { method.Invoke(); }

        }



        void rdrOnRxSerialStr(object source, RxSerialReadStrArgs e)
        {
            MethodInvoker method = delegate
            {
                AddLog("Okunulan Data [" + e.Data +" - SerialPortNo : "+Convert.ToString(e.SerialPortNo)+"].");
            };
            if (InvokeRequired)
                BeginInvoke(method);
            else
                method.Invoke();
        }

        void rdrOnTurnstileTurn(object source, RxTurnstileTurnArgs e)
        {
            MethodInvoker method = delegate
            {
                if (e.Success)
                    AddLog("Turnike Dönüş başarılı Kart ID [" + e.CardID + "].");
                else
                    AddLog("Turnike Dönüş başarısız Kart ID [" + e.CardID + "].");

            };
            if (InvokeRequired)
                BeginInvoke(method);
            else
                method.Invoke();
        }


        void rdrOnConnected(object source)
        {
            MethodInvoker method = delegate
            {
                AddLog("Bağlantı Kuruldu. ");
            };

            if (InvokeRequired)
                BeginInvoke(method);
            else method.Invoke();
        }

        void rdrOnDisConnected(object source)
        {
            MethodInvoker method = delegate
            {
                AddLog("Bağlantı Kesild. ");
            };

            if (InvokeRequired)
                BeginInvoke(method);
            else method.Invoke();
        }

        public void AddLog(string str,Boolean SM = false)
        {
            string log;
            log = appLog.Text;

           
            string ss, dd, sa, msc = "";
            ss = Convert.ToString(DateTime.Now.Hour);
            dd = Convert.ToString(DateTime.Now.Minute);
            sa = Convert.ToString(DateTime.Now.Second);
            msc = Convert.ToString(DateTime.Now.Millisecond);

            if (Convert.ToString(DateTime.Now.Hour).Length < 2)
             ss = "0" + Convert.ToString(DateTime.Now.Hour); 
            

            if (Convert.ToString(DateTime.Now.Minute).Length < 2)
             dd = "0" + Convert.ToString(DateTime.Now.Minute); 
            

            if (Convert.ToString(DateTime.Now.Second).Length < 2)
              sa = "0" + Convert.ToString(DateTime.Now.Second);

            if (Convert.ToString(DateTime.Now.Millisecond).Length < 2)
              msc = "0" + Convert.ToString(DateTime.Now.Millisecond); 

            
            //appLog.Text = DateTime.Now.ToShortTimeString() + ":" + DateTime.Now.Second.ToString() + " > " + str + "\n" + log;
            appLog.Text = ss +":" + dd +":" + sa+ " : " + msc + " > " + str +"\n" + log ;
            if (SM)
                MessageBox.Show(str);
        }


        void OfflineMsgLoad()
        {
            int Msgcnt;
            if (rdr.fwAppType == TfwAppType.fwPDKS )
            {
                      Msgcnt = 40;
                      edtCihazMesajTipiOffline.Items.Clear();
                      OffflineMsg[0].MsgID = 1;
                      OffflineMsg[0].MsgName = "Cihaz Açılış Ekranı [1]";
                      OffflineMsg[1].MsgID = 2;
                      OffflineMsg[1].MsgName = "Cihaz Açılış Ekranı [2]";
                      OffflineMsg[2].MsgID = 4;
                      OffflineMsg[2].MsgName = "Sifre Giris Ekrani";
                      OffflineMsg[3].MsgID = 5;
                      OffflineMsg[3].MsgName = "Gecersiz Sifre Ekrani";
                      OffflineMsg[4].MsgID = 6;
                      OffflineMsg[4].MsgName = "Yanlis Sifre Ekrani";
                      OffflineMsg[5].MsgID = 7;
                      OffflineMsg[5].MsgName = "Önce Şifre Girmelisiniz Ekranı";
                      OffflineMsg[6].MsgID = 8;
                      OffflineMsg[6].MsgName = "Sifreden Sonra kart1n1z1 okutun Ekrani";
                      OffflineMsg[7].MsgID = 50;
                      OffflineMsg[7].MsgName = "Tanımsız Kart Ekranı";
                      OffflineMsg[8].MsgID = 51;
                      OffflineMsg[8].MsgName = "Başarılı Geçiş Ekranı";
                      OffflineMsg[9].MsgID = 52;
                      OffflineMsg[9].MsgName = "Yetkisiz Terminal Ekranı";
                      OffflineMsg[10].MsgID = 53;
                      OffflineMsg[10].MsgName = "Kart Sifre Uyumsuzlugu Ekrani";
                      OffflineMsg[11].MsgID = 54;
                      OffflineMsg[11].MsgName = "Kart Gecerlilik suresi bitmis Ekrani";
                      OffflineMsg[12].MsgID = 55;
                      OffflineMsg[12].MsgName = "Zaman K1s1t tablosu hata Ekrani";
                      OffflineMsg[13].MsgID = 56;
                      OffflineMsg[13].MsgName = "Butonla Kap1 Acildiginde Ekrani";
                      OffflineMsg[14].MsgID = 57;
                      OffflineMsg[14].MsgName = "Anti Passback Ihlali Ekrani";
                      OffflineMsg[15].MsgID = 58;
                      OffflineMsg[15].MsgName = "Ardisik gecis hatasi Ekrani";
                      OffflineMsg[16].MsgID = 59;
                      OffflineMsg[16].MsgName = "KArt Login Olunamad1 Ekrani";
                      OffflineMsg[17].MsgID = 60;
                      OffflineMsg[17].MsgName = "Kart Okunamadi Ekrani";
                      OffflineMsg[18].MsgID = 61;
                      OffflineMsg[18].MsgName = "Kart Yazilamadi Ekrani";
                      OffflineMsg[19].MsgID = 62;
                      OffflineMsg[19].MsgName = "Yanlis Sifre Ekrani";
                      OffflineMsg[20].MsgID = 63;
                      OffflineMsg[20].MsgName = "Online Server Baglanti Hatasi Ekrani";
                      OffflineMsg[21].MsgID = 64;
                      OffflineMsg[21].MsgName = "Kapı açık kaldı.";
                      OffflineMsg[22].MsgID = 65;
                      OffflineMsg[22].MsgName = "Full yemek hakkı ile geçiş.";
                      OffflineMsg[23].MsgID = 66;
                      OffflineMsg[23].MsgName = "Öğün yemek hakkı doldu.";
                      OffflineMsg[24].MsgID = 67;
                      OffflineMsg[24].MsgName = "Gün yemek hakkı doldu.";
                      OffflineMsg[25].MsgID = 68;
                      OffflineMsg[25].MsgName = "Yetersiz bakiye.";
                      OffflineMsg[26].MsgID = 69;
                      OffflineMsg[26].MsgName = "Öğün dışı.";
                      OffflineMsg[27].MsgID = 70;
                      OffflineMsg[27].MsgName = "Cihaz Bilgi Ekranı";
                      OffflineMsg[28].MsgID = 71;
                      OffflineMsg[28].MsgName = "İnput Box";
                      OffflineMsg[29].MsgID = 72;
                      OffflineMsg[29].MsgName = "Black List Uyarısı";
                      OffflineMsg[30].MsgID = 73;
                      OffflineMsg[30].MsgName = "Sadece Kontör başarılı geçiş";
                      OffflineMsg[31].MsgID = 74;
                      OffflineMsg[31].MsgName = "Sadece Haklı başarılı geçiş";
                      OffflineMsg[32].MsgID = 75;
                      OffflineMsg[32].MsgName = "Hak + Kontor başarılı geçiş";
                      OffflineMsg[33].MsgID = 76;
                      OffflineMsg[33].MsgName = "Hak bittikten sora kontöre geçerek başarılı geçiş";
                      OffflineMsg[34].MsgID = 77;
                      OffflineMsg[34].MsgName = "Hafta Yemek Hakkı dolu";
                      OffflineMsg[35].MsgID = 78;
                      OffflineMsg[35].MsgName = "Ay Yemek Hakkı dolu";
                      OffflineMsg[36].MsgID = 79;
                      OffflineMsg[36].MsgName = "Yuklenen + düşülen Kontur miktarı toplamı kontor den küçük";
                      OffflineMsg[37].MsgID = 80;
                      OffflineMsg[37].MsgName = "Kartınızı Çekmeyiniz.";
                      OffflineMsg[38].MsgID = 81;
                      OffflineMsg[38].MsgName = "Kart Bakiyesi düzeltildi.";
                      OffflineMsg[39].MsgID = 82;
                      OffflineMsg[39].MsgName = "Kart Bakiyesi düzeltme hatalı.";
                      edtCihazMesajTipiOffline.Items.Clear();

                      for (int i = 0; i < Msgcnt; i++)
                      {
                      edtCihazMesajTipiOffline.Items.Add(OffflineMsg[i].MsgName);
                      }
                
            }
            else if (rdr.fwAppType == TfwAppType.fwHGS)
            {

                edtCihazMesajTipiOffline.Items.Clear();
                OffflineMsg[0].MsgID = 1;
                OffflineMsg[0].MsgName = "Açılış Ekranı [1]";
                OffflineMsg[1].MsgID = 2;
                OffflineMsg[1].MsgName = "Açılış Ekranı [2]";
                OffflineMsg[2].MsgID = 7;
                OffflineMsg[2].MsgName = "Kart Okuma Ekranı";
                OffflineMsg[3].MsgID = 11;
                OffflineMsg[3].MsgName = "Geçersiz Kart Ekranı";
                OffflineMsg[4].MsgID = 12;
                OffflineMsg[4].MsgName = "Kart Okuma Hatası Ekranı";
                OffflineMsg[5].MsgID = 8;
                OffflineMsg[5].MsgName = "Şifre Giriş Ekranı";
                OffflineMsg[6].MsgID = 9;
                OffflineMsg[6].MsgName = "Geçersiz Şifre Ekranı";
                OffflineMsg[7].MsgID = 10;
                OffflineMsg[7].MsgName = "Yanlış Şifre Ekranı";
                OffflineMsg[8].MsgID = 100;
                OffflineMsg[8].MsgName = "Ana Menü";
                OffflineMsg[9].MsgID = 101;
                OffflineMsg[9].MsgName = "Cihaz Ayarları Menüsü";
                OffflineMsg[10].MsgID = 110;
                OffflineMsg[10].MsgName = "Tarih Saat Ayarı Ekranı";
                OffflineMsg[11].MsgID = 13;
                OffflineMsg[11].MsgName = "Tarih saat Değiştirildi Ekranı";
                OffflineMsg[12].MsgID = 14;
                OffflineMsg[12].MsgName = "Geçersiz Tarihsaat Ekranı";
                OffflineMsg[13].MsgID = 111;
                OffflineMsg[13].MsgName = "Ağ Ayarı Ekranı";
                OffflineMsg[14].MsgID = 112;
                OffflineMsg[14].MsgName = "Cihaz Aktif/Pasif Ekranı";
                OffflineMsg[15].MsgID = 15;
                OffflineMsg[15].MsgName = "Cihaz Aktif Duruma Geldi";
                OffflineMsg[16].MsgID = 16;
                OffflineMsg[16].MsgName = "Cihaz Pasif Duruma Geldi";
                OffflineMsg[17].MsgID = 113;
                OffflineMsg[17].MsgName = "Gelen Paket Ayarı";
                OffflineMsg[18].MsgID = 17;
                OffflineMsg[18].MsgName = "Gelen Paket Ayarları Kaydedildi Ekranı";
                OffflineMsg[19].MsgID = 114;
                OffflineMsg[19].MsgName = "Röle Çıkış Ayarı Ekranı";
                OffflineMsg[20].MsgID = 18;
                OffflineMsg[20].MsgName = "Role Çıkış Süresi Değiştirildi Ekranı";
                OffflineMsg[21].MsgID = 102;
                OffflineMsg[21].MsgName = "Çalışma Ayarları";
                OffflineMsg[22].MsgID = 102;
                OffflineMsg[22].MsgName = "Çalışma Modu Ayarları";
                OffflineMsg[23].MsgID = 19;
                OffflineMsg[23].MsgName = "Çalışma Modu Değiştirildi Ekranı";
                OffflineMsg[24].MsgID = 121;
                OffflineMsg[24].MsgName = "Şifre Değiştirme ekranı";
                OffflineMsg[25].MsgID = 22;
                OffflineMsg[25].MsgName = "Geçersiz Şifre Ekranı";
                OffflineMsg[26].MsgID = 23;
                OffflineMsg[26].MsgName = "Şifre Uyşmazlığı Ekranı";
                OffflineMsg[27].MsgID = 24;
                OffflineMsg[27].MsgName = "Lütfen Kartınızı Okutunuz Ekranı";
                OffflineMsg[28].MsgID = 26;
                OffflineMsg[28].MsgName = "Kart Yazma Hatası Ekranı";
                OffflineMsg[29].MsgID = 25;
                OffflineMsg[29].MsgName = "Şifreniz Kaydedildi";
                OffflineMsg[30].MsgID = 122;
                OffflineMsg[30].MsgName = "Ardışık Tag Okuma Ayar Ekranı";
                OffflineMsg[31].MsgID = 21;
                OffflineMsg[31].MsgName = "Ardışık Okuma Ayarları Değiştirildi Ekranı";
                OffflineMsg[32].MsgID = 123;
                OffflineMsg[32].MsgName = "Zaman Kısıt Tablosu Ekranı";

                OffflineMsg[33].MsgID = 27;
                OffflineMsg[33].MsgName = "Zaman Kısıt Tablosu Değiştirildi Ekranı";

                OffflineMsg[34].MsgID = 124;
                OffflineMsg[34].MsgName = "Anten Güç Ayarı Ekranı";
                OffflineMsg[35].MsgID = 38;
                OffflineMsg[35].MsgName = "Anten Güç Ayarları Kaydedildi Ekranı";
                OffflineMsg[36].MsgID = 103;
                OffflineMsg[36].MsgName = "Tag İşlemleri Ekranı";
                OffflineMsg[37].MsgID = 130;
                OffflineMsg[37].MsgName = "Tag Ekleme Ekranı [1]";
                OffflineMsg[38].MsgID = 145;
                OffflineMsg[38].MsgName = "Tag Ekleme Ekranı [2]";
                OffflineMsg[39].MsgID = 39;
                OffflineMsg[39].MsgName = "Bu Daire İçin Limiti Aştınız Ekranı";
                OffflineMsg[40].MsgID = 28;
                OffflineMsg[40].MsgName = "Lütfen Tagı Okutunuz Ekranı";
                OffflineMsg[41].MsgID = 29;
                OffflineMsg[41].MsgName = "Bu Tag Cihazda Tanımlı Öncelikle Silmeniz Gerekli";
                OffflineMsg[42].MsgID = 30;
                OffflineMsg[42].MsgName = "Tagınız Kaydedildi";
                OffflineMsg[43].MsgID = 131;
                OffflineMsg[43].MsgName = "Tag Silme Ekranı";
                OffflineMsg[44].MsgID = 32;
                OffflineMsg[44].MsgName = "Tag Bulunamadı Ekranı";
                OffflineMsg[45].MsgID = 31;
                OffflineMsg[45].MsgName = "Tag Silindi Ekranı";
                OffflineMsg[46].MsgID = 132;
                OffflineMsg[46].MsgName = "Tag Aktif Pasif Ekranı [1]";
                OffflineMsg[47].MsgID = 40;
                OffflineMsg[47].MsgName = "Tag Bulunamadı Ekranı";

                OffflineMsg[48].MsgID = 33;
                OffflineMsg[48].MsgName = "Tag Aktif Pasif Ekranı [2]";

                OffflineMsg[49].MsgID = 34;
                OffflineMsg[49].MsgName = "Tag Aktif Duruma Ayarlandı Ekranı";
                OffflineMsg[50].MsgID = 35;
                OffflineMsg[50].MsgName = "Tag Pasif Duruma Ayarlandı Ekranı";
                OffflineMsg[51].MsgID = 133;
                OffflineMsg[51].MsgName = "Hızlı Tag ekleme Ekranı";
                OffflineMsg[52].MsgID = 42;
                OffflineMsg[52].MsgName = "Lütfen Tagı Okutunuz Ekranı";
                OffflineMsg[53].MsgID = 43;
                OffflineMsg[53].MsgName = "Bu Tag Cihazda Tanımlı Öncelikle Silmeniz Gerekli";
                OffflineMsg[54].MsgID = 44;
                OffflineMsg[54].MsgName = "Tagınız Kaydedildi";
                OffflineMsg[55].MsgID = 134;
                OffflineMsg[55].MsgName = "Hızlı Tag Silme Ekranı";
                OffflineMsg[56].MsgID = 135;
                OffflineMsg[56].MsgName = "Bu Dairenin Tüm Tagları Silindi Ekranı";
                OffflineMsg[57].MsgID = 104;
                OffflineMsg[57].MsgName = "Raporlar Ekranı";
                OffflineMsg[58].MsgID = 140;
                OffflineMsg[58].MsgName = "Tarih Bazında Rapor Ekranı";
                OffflineMsg[59].MsgID = 141;
                OffflineMsg[59].MsgName = "Daire Bazında Rapor Ekranı";
                OffflineMsg[60].MsgID = 142;
                OffflineMsg[60].MsgName = "Daire Durum Raporu Ekranı [1]";
                OffflineMsg[61].MsgID = 146;
                OffflineMsg[61].MsgName = "Daire Durum Raporu Ekranı [2]";
                OffflineMsg[62].MsgID = 143;
                OffflineMsg[62].MsgName = "İçeride Raporu Ekranı";
                OffflineMsg[63].MsgID = 105;
                OffflineMsg[63].MsgName = "Bakım Ekranı";
                OffflineMsg[64].MsgID = 150;
                OffflineMsg[64].MsgName = "Araç Sayısını Sıfırlama Ekranı";
                OffflineMsg[65].MsgID = 41;
                OffflineMsg[65].MsgName = "İşlem Tamamlandı Ekranı";
                OffflineMsg[66].MsgID = 151;
                OffflineMsg[66].MsgName = "Tüm Araçları Silme Ekranı";
                OffflineMsg[67].MsgID = 152;
                OffflineMsg[67].MsgName = "Daire Sayı Sıfırla Ekranı";
                OffflineMsg[68].MsgID = 155;
                OffflineMsg[68].MsgName = "Bu Dairenin İçerideki araç bilgileri Sıfırlandı Ekranı";
                OffflineMsg[69].MsgID = 156;
                OffflineMsg[69].MsgName = "Bu Aracın İçerideki Bilgileri Sıfırlandı Ekranı";
                OffflineMsg[70].MsgID = 153;
                OffflineMsg[70].MsgName = "Araç Sıfırlama Ekranı";
                OffflineMsg[71].MsgID = 80;
                OffflineMsg[71].MsgName = "Tanımsız Araç Ekranı";
                OffflineMsg[72].MsgID = 81;
                OffflineMsg[72].MsgName = "Başarılı Geçiş Ekranı";
                OffflineMsg[73].MsgID = 82;
                OffflineMsg[73].MsgName = "Geçiş Yetkiniz Yok Ekranı";
                OffflineMsg[74].MsgID = 83;
                OffflineMsg[74].MsgName = "Tag Geçerlilik Süresi Dolmuş Ekranı";
                OffflineMsg[75].MsgID = 84;
                OffflineMsg[75].MsgName = "Geçersiz Zamanaralığı Ekranı";
                OffflineMsg[76].MsgID = 85;
                OffflineMsg[76].MsgName = "Otopark Hakkınız Dolmuştur Ekranı";
                OffflineMsg[77].MsgID = 86;
                OffflineMsg[77].MsgName = "Önce Çıkış Yapmalısınız Ekranı";

                edtCihazMesajTipiOffline.Items.Clear();

                for (int i = 0; i < 78; i++)
                {
                    edtCihazMesajTipiOffline.Items.Add(OffflineMsg[i].MsgName);
                }
                

            }


        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            cbReaderType_SelectedIndexChanged(this, e);
            

            switch ( cbReaderType.SelectedIndex )
            {
                case 0: rdr.ReaderType = TReaderType.rdr63M_V3 ; break;
                case 1: rdr.ReaderType = TReaderType.rdr63M_V5 ; break;
                case 2: rdr.ReaderType = TReaderType.rdr26M ; break;
            }

            switch (cbProtocol.SelectedIndex)
            {
                case 0: rdr.pProtocolType = TProtocolType.PR0; break;
                case 1: rdr.pProtocolType = TProtocolType.PR1; break;
                case 2: rdr.pProtocolType = TProtocolType.PR2; break;
                case 3: rdr.pProtocolType = TProtocolType.PR3; break;
            }

            switch (cbDfSize.SelectedIndex)
            {
                case 0: rdr.DFType = TDFType.df4MB; break;
                case 1: rdr.DFType = TDFType.df8MB; break;
            }

            switch (txtUygulamaTipi.SelectedIndex)
            {
                case 0: { rdr.fwAppType = TfwAppType.fwHGS; break; };
                case 1: { rdr.fwAppType = TfwAppType.fwPDKS; break; };
                case 2: { rdr.fwAppType = TfwAppType.fwYMK; break; };
                    

                default:
                    break;
            }

            btnUDPbaslat.PerformClick();

            rdr.IP = edtIp.Text;
            rdr.Port = (int)edtPortNo.Value;
            rdr.TimeOut = (int)edtTimeOut.Value;
            rdr.DeviceLoginKey = edtDeviceKey.Text;
            rdr.CommandRetry = (int)edtCmtRetry.Value;
            rdr.AutoConnect = cbAutoConnect.Checked;
            rdr.AutoRxEnabled = cbAutoRxEnabled.Checked;

            switch (txtUygulamaTipi.SelectedIndex)
            {
                case 0: rdr.fwAppType = TfwAppType.fwPDKS; break;
                case 1: rdr.fwAppType = TfwAppType.fwHGS; break;
                case 2: rdr.fwAppType = TfwAppType.fwYMK; break;

                default:
                    break;
            }
            rdr.OnlineReConnectTimeOut = 5000;

            rdr.Connect();
            if (rdr.Connected)
            {
                AddLog("IP [" + rdr.IP + "] Bağlantı Kuruldu.");
                OfflineMsgLoad();
                btnfwVersion.PerformClick();
                btnGetHead.PerformClick();
                btnGetDeviceStatus.PerformClick();
                btnGetir.PerformClick();
                btnGetWorkMode.PerformClick();
                btnGetSerialNumber.PerformClick();
                btnSeriPortGetir.PerformClick();
                button22.PerformClick();
                button30.PerformClick();
                button24.PerformClick();
                button4_Click(this, e);
                button6_Click(this, e);
                button9_Click(this, e);
                btnMacAdresiGetir_Click(this, e);
                button43_Click(this, e);
                //btnSeriPortGetir.Click += new EventHandler(btnSeriPortGetir_Click);
                button18_Click(this, e);
                button27_Click(this, e);
                button22_Click(this, e);
                button30_Click(this, e);
                button24_Click(this, e);
                btnConnect.Enabled = false;
                btnDisConnect.Enabled = true;

                switch (rdr.fwAppType)
                {
                    case TfwAppType.fwPDKS:
                    case TfwAppType.fwYMK:
                        tbpYmk.Show();
                        tsAddWhitelist.Show();
                        tsInOutValues.Show();
                        tbpHgsGenelAyarlar.Hide();
                        tbpCihazdanBilgiTransfer.Hide();
                        break;
                    case TfwAppType.fwHGS:
                        tbpHgsGenelAyarlar.Show();
                        tbpCihazdanBilgiTransfer.Show();
                    break;
                    default:
                        break;
                }

                
            }
            else
            {
                AddLog("Ip Adresi :" + edtIp.Text + " bağlantı sağlanamadı.", true);
            }

        }

        private void btnDisConnect_Click(object sender, EventArgs e)
        {
            rdr.DisConnect();
            btnConnect.Enabled = true;
            btnDisConnect.Enabled = false;
        }

        private void btnfwVersion_Click(object sender, EventArgs e)
        {
            if (rdr.Connected)
                lblfwVersion.Text = rdr.GetFwVwersion();
            else
                AddLog("Cihaz Bağlantısı Yok.");
        }

        private void btnGetHead_Click(object sender, EventArgs e)
        {
            if (rdr.Connected)
            {
                uint Head;
                uint Tail;
                byte HeadTail;
                uint Capacity;
                Nullable<DateTime> deviceDate;
                Nullable<DateTime> doorOpenDt;
                Boolean doorOpen;

                if (rdr.GetRegularInfo(out deviceDate, out HeadTail, out Head, out Tail, out Capacity, out doorOpen, out doorOpenDt))
                {
                    edtHead.Value = Head;
                    edtTail.Value = Tail;
                    lblCapacity.Text = "Kapasite : " + Capacity.ToString();
                    AddLog("Head -Tail Bilgisi getirildi. Cihaz saati:" + deviceDate.ToString() );
                } 
                else 
                    AddLog("Head -Tail Bilgisi getirilemedi."); 
            }
            else
                AddLog("Cihaz Bağlantısı Yok.");
        }

        private void btnSetHead_Click(object sender, EventArgs e)
        {
            if (rdr.Connected)
            {
                if (rdr.SetHeadTail((int)edtHead.Value, (int)edtTail.Value))
                    AddLog("Head -Tail Bilgisi Gönderildi.");
                else
                    AddLog("Head -Tail Bilgisi Gönderilemedi.");
            }
            else
                AddLog("Cihaz Bağlantısı Yok.");
        }

        private void dtTimer_Tick(object sender, EventArgs e)
        {
            edtDateTime.Value = DateTime.Now;
        }

        private void btnSetDateTime_Click(object sender, EventArgs e)
        {
            
             
            if (rdr.Connected)
            {
                if (rdr.SetDateTime(edtDateTime.Value))
                    AddLog("Tarih saat bilgisi gönderildi.");
                else
                    AddLog("Tarih saat bilgisi gönderilemedi!");

            }
            else
                AddLog("Cihaz Bağlantısı Yok.");
        }

        private void btnGetDeviceStatus_Click(object sender, EventArgs e)
        {
            if (rdr.Connected)
            {
                if (rdr.GetDeviceStatus()) 
                    rbDeviceEnabled.Checked = true;
                else
                    rbDeviceDisabled.Checked = true;
                AddLog("Cihaz durumu getirildi.");
            }
            else
                AddLog("Cihaz Bağlantısı Yok.");
        }

        private void btnSetDeviceStatus_Click(object sender, EventArgs e)
        {

            if (rdr.Connected)
            {
                if (rdr.SetDeviceStatus(rbDeviceEnabled.Checked))
                    AddLog("Cihaz durumu gönderildi.");
                else
                    AddLog("Cihaz durumu gönderilemedi.");
            }
            else
                AddLog("Cihaz Bağlantısı Yok.");
        }

        private void btnReboot_Click(object sender, EventArgs e)
        {
            if (rdr.Connected)
            {
                rdr.Reboot();
                rdr.DisConnect();
                Thread.Sleep(300);
                rdr.Connect();
            }
            else
                AddLog("Cihaz Bağlantısı Yok.");
        }

        private void btnSetDeviceFactoryDefaults_Click(object sender, EventArgs e)
        {
            if (rdr.Connected)
            {
                if (cdSaveIPAddr.Checked)
                    rdr.SetDeviceFactoryDefault(false);
                else
                    rdr.SetDeviceFactoryDefault(true);
            }
            else
                AddLog("Cihaz Bağlantısı Yok.");
        }

        private void btnGetWorkMode_Click(object sender, EventArgs e)
        {
            TWorkModeSettings rSettings = new TWorkModeSettings();

            if (rdr.Connected)
            {
                if (rdr.GetDeviceWorkModeSettings(out rSettings))
                {
                    switch (rSettings.WorkingMode)
                    {
                        case TWorkingMode.wmOffline: rbOfflineWhiteList.Checked = true; break;
                        case TWorkingMode.wmOfflineCard: rbOfflineCardBlackList.Checked = true; break;
                        case TWorkingMode.wmTCPOnline: rbOnlineTCP.Checked = true; break;
                        case TWorkingMode.wmUDPOnline: rbOnlineUDP.Checked = true; break;
                    }

                    cbOnlineEnabledOffline.Checked = rSettings.OfflineModePermission;
                    edtOnlineTimeOut.Value = rSettings.ServerAnswerTimeOut;
                    this.cmbOnlineKartModu.SelectedIndex = (int)rSettings.OfflineOnlineMode;
                    AddLog("Cihaz çalışma modu getirildi.");
                }
                else
                    AddLog("Cihaz çalışma modu getirilemedi.");
            }
            else
                AddLog("Cihaz Bağlantısı Yok.");
        }

        private void btnSetWorkMode_Click(object sender, EventArgs e)
        {
            TWorkModeSettings rSettings = new TWorkModeSettings();

            if (rdr.Connected)
            {
                if (rbOfflineWhiteList.Checked)
                    rSettings.WorkingMode = TWorkingMode.wmOffline;
                else if (rbOfflineCardBlackList.Checked)
                    rSettings.WorkingMode = TWorkingMode.wmOfflineCard;
                else if (rbOnlineTCP.Checked)
                    rSettings.WorkingMode = TWorkingMode.wmTCPOnline;
                else
                    rSettings.WorkingMode = TWorkingMode.wmUDPOnline;
                rSettings.OfflineModePermission = cbOnlineEnabledOffline.Checked;
                rSettings.ServerAnswerTimeOut = (uint)edtOnlineTimeOut.Value;
                rSettings.OfflineOnlineMode = (TOnlineCardWorkMode)this.cmbOnlineKartModu.SelectedIndex;
                
                if (rdr.SetDeviceWorkModeSettings(rSettings))

                    AddLog("Cihaz çalışma modu gönderildi.");
                else
                    AddLog("Cihaz çalışma modu gönderilmedi.");
            }
            else
                AddLog("Cihaz Bağlantısı Yok.");

        }

        private void btnGetSerialNumber_Click(object sender, EventArgs e)
        {
            if (rdr.Connected)
            {
                edtSerialNumber.Text = rdr.GetSerialNumber();
                if (edtSerialNumber.Text != "XXX")
                    AddLog("Cihaz Seri Numarası getirildi.");
                else
                    AddLog("Cihaz Seri Numarası getirilemedi.");
            }
            else
                AddLog("Cihaz Bağlantısı Yok.");
        }

        private void btnSetSerialNumber_Click(object sender, EventArgs e)
        {
            if (rdr.Connected)
            {
                if (rdr.SetSerialNumber(edtSerialNumber.Text))  
                    AddLog("Cihaz Seri Numarası gönderildi.");
                else
                    AddLog("Cihaz Seri Numarası gönderilemedi.");
            }
            else
                AddLog("Cihaz Bağlantısı Yok.");
        }

        private void btnOnMsgGonder_Click(object sender, EventArgs e)
        {
            
        }

        private void btnClearWhiteList_Click(object sender, EventArgs e)
        {
            if (rdr.Connected)
            {
                rdr.ClearWhitelist();
            }
            else
                AddLog("Cihaz Bağlantısı Yok.");
        }

        private void btnAddWhiteList_Click(object sender, EventArgs e)
        {
            if (rdr.Connected)
            {
                int iErr;
                uint InxNm;
                string CardID;

                lblIndexNo.Text = "-1";
                CardID = edtCardID.Text;
                if (rdr.IsHex(CardID) && (CardID.Length == 14))
                {
                    TPerson Person = new TPerson();
                    int NameLen = edtName.Text.Length;
                    if (NameLen > 18)
                        NameLen = 18;

                    Person.CardID = CardID;
                    Person.Name = edtName.Text.Substring(0, NameLen);
                    Person.TimeZoneListNo = (byte)seAccMask1.Value;
                    Person.Code = (uint)seCode.Value;
                    Person.Password = (ushort)sePassword.Value;
                    Person.EndDate = edtEndDate.Value;
                    Person.AccessDevice = cbAccessEnabled.Checked;
                    Person.APBEnabled = cbAPBEnabled.Checked;
                    Person.TZEnabled = cbATCEnabled.Checked;
                    Person.AccessCardEnabled = cbAccessCardEnabled.Checked;
                    Person.IsOnlineCard = chkKartOfflinedaOnlineCalissin.Checked;
                    Person.PermitedInEmergency = chkAcilDurumlardaGecizIzni.Checked;
                    Person.MealSettingListNo = (byte)nmrAyarListeNo.Value;
                    Person.WeeklyTotalMealCount = (byte)nmrToplamHaftalikHak.Value;
                    Person.MonthlyTotalMealCount = (byte)nmrToplamAylikHak.Value;
                    Person.BlackListCmdNo = 0;
                    Person.NeedCmdControl = (byte)nmrNeedCmdControl.Value;
                    Person.BirthDate = dtDogumTarihi.Value;
                    iErr = rdr.AddWhitelist(Person,out InxNm);

                    switch (iErr)
                    {
                        case 0: 
                            AddLog("Kişi eklendi.");
                            lblIndexNo.Text = InxNm.ToString();
                           break;
                        case 1: 
                            AddLog("Daha önce eklenmiş.");
                            break;
                        case 20: 
                            AddLog("Şifre kapasitesi aşıldı.");
                            break;
                        case 51: 
                            AddLog("Bu Kart ID daha önce tanımlanmış.");                            
                            break;
                        case 52: 
                            AddLog("Bu şifre daha önce tanımlanmış.");                            
                            break;
                        default :
                            AddLog("Hata iErr : " + iErr.ToString());
                            break;
                    }
                }
                else
                    AddLog("Uygun Kart ID girilmemiş.");
            }
            else
                AddLog("Cihaz Bağlantısı Yok.");
        }

        private void btnEditWhiteList_Click(object sender, EventArgs e)
        {
            if (rdr.Connected)
            {
                int iErr;
                uint InxNm;
                string CardID;

                lblIndexNo.Text = "-1";
                CardID = edtCardID.Text;
                if (rdr.IsHex(CardID) && (CardID.Length == 14))
                {
                    TPerson Person = new TPerson();
                    int NameLen = edtName.Text.Length;
                    if (NameLen > 18)
                        NameLen = 18;

                    Person.CardID = CardID;
                    Person.Name = edtName.Text.Substring(0, NameLen);
                    Person.TimeZoneListNo = (byte)seAccMask1.Value;
                    Person.Code = (uint)seCode.Value;
                    Person.Password = (ushort)sePassword.Value;
                    Person.EndDate = edtEndDate.Value;
                    Person.AccessDevice = cbAccessEnabled.Checked;
                    Person.APBEnabled = cbAPBEnabled.Checked;
                    Person.TZEnabled = cbATCEnabled.Checked;
                    Person.AccessCardEnabled = cbAccessCardEnabled.Checked;
                    Person.IsOnlineCard = chkKartOfflinedaOnlineCalissin.Checked;
                    Person.PermitedInEmergency = chkAcilDurumlardaGecizIzni.Checked;
                    Person.MealSettingListNo = (byte)nmrAyarListeNo.Value;
                    Person.WeeklyTotalMealCount = (byte)nmrToplamHaftalikHak.Value;
                    Person.MonthlyTotalMealCount = (byte)nmrToplamAylikHak.Value;
                    Person.BlackListCmdNo = 0;
                    Person.NeedCmdControl = (byte)nmrNeedCmdControl.Value;
                    Person.BirthDate = dtDogumTarihi.Value;

                    iErr = rdr.EditWhitelistWithCardID(Person, out InxNm);

                    switch (iErr)
                    {
                        case 0:
                            AddLog("Kişi Değiştirildi.");
                            lblIndexNo.Text = InxNm.ToString();
                            break;
                        case 1:
                            AddLog("Daha önce eklenmiş.");
                            break;
                        case 20:
                            AddLog("Şifre kapasitesi aşıldı.");
                            break;
                        case 51:
                            AddLog("Bu Kart ID daha önce tanımlanmış.");
                            break;
                        case 52:
                            AddLog("Bu şifre daha önce tanımlanmış.");
                            break;
                        default:
                            AddLog("Hata iErr : " + iErr.ToString());
                            break;
                    }
                }
                else
                    AddLog("Uygun Kart ID girilmemiş.");
            }
            else
                AddLog("Cihaz Bağlantısı Yok.");
        }

        private void btnDeleteWhiteList_Click(object sender, EventArgs e)
        {
            if (rdr.Connected)
            {
                //int iErr;
                uint InxNm;
                string CardID;

                lblIndexNo.Text = "-1";
                CardID = edtCardID.Text;
                if (rdr.IsHex(CardID) && (CardID.Length == 14))
                {
                    if (rdr.DeleteWhitelistWithCardID(CardID, out InxNm) == 0)
                    {
                        AddLog("Kişi silindi.");
                        lblIndexNo.Text = InxNm.ToString();
                    }
                    else
                        AddLog("Kişi silinemedi.");
                }
                else
                    AddLog("Uygun Kart ID girilmemiş.");

            }
            else
                AddLog("Cihaz Bağlantısı Yok.");
        }

        private void btnGetWhiteList_Click(object sender, EventArgs e)
        {
            if (rdr.Connected)
            {
                int iErr;
                uint InxNm;
                string CardID;
                lblIndexNo.Text = "-1";
                CardID = edtCardID.Text;
                if (rdr.IsHex(CardID) && (CardID.Length == 14))
                {
                    TPerson Person = new TPerson();

                    iErr = rdr.GetWhitelistWithCardID(CardID,out Person,out InxNm);
                    if (iErr == 0)
                    {
                        edtName.Text = Person.Name.Trim();
                        seCode.Value = Person.Code;
                        seAccMask1.Value = Person.TimeZoneListNo;
                        sePassword.Value = Person.Password;
                        edtEndDate.Value = Person.EndDate;
                        cbAccessEnabled.Checked = Person.AccessDevice;
                        cbAPBEnabled.Checked = Person.APBEnabled;
                        cbATCEnabled.Checked = Person.TZEnabled;
                        cbAccessCardEnabled.Checked = Person.AccessCardEnabled;
                        chkKartOfflinedaOnlineCalissin.Checked = Person.IsOnlineCard;
                        chkAcilDurumlardaGecizIzni.Checked = Person.PermitedInEmergency;
                        nmrAyarListeNo.Value = Person.MealSettingListNo;
                        nmrToplamHaftalikHak.Value = Person.WeeklyTotalMealCount;
                        nmrToplamAylikHak.Value = Person.MonthlyTotalMealCount;
                        nmrBlackListNo.Value = Person.BlackListCmdNo;
                        nmrNeedCmdControl.Value = Person.NeedCmdControl;
                        dtDogumTarihi.Value = Person.BirthDate;
                        lblIndexNo.Text = InxNm.ToString();
                        AddLog("Kişi getirildi.");
                    }
                    else
                        AddLog("Kişi getirilemedi.(" + iErr.ToString() + ")");
                }
                else
                    AddLog("Uygun Kart ID girilmemiş.");
            }
            else
                AddLog("Cihaz Bağlantısı Yok.");
        }

        private void btnCardIDCnt_Click(object sender, EventArgs e)
        {
            if (rdr.Connected)
            {
                int cnt = rdr.GetWhitelistCardIDCount();
                if (cnt != -1)
                {
                    lblTanimliKisi.Text = "Tanımlı Kişi Sayısı : " + cnt.ToString();
                    lblTanimliBlackListSayisi.Text = cnt.ToString();
                        
                }
                else
                    lblTanimliKisi.Text = "Kişi sayısı getirilemedi.";

            }
            else
                AddLog("Cihaz Bağlantısı Yok.");
        }

        private void btnReadRecs_Click(object sender, EventArgs e)
        {
            if (rdr.Connected)
            {
                TAccessRecords tempRecs = new TAccessRecords();
                uint Start = (uint)edtStartRead.Value;
                uint HowMany = (uint)edtHowManyRead.Value;
                if (rdr.ReadRecords(Start,HowMany,out tempRecs))
                {
                    string str;
                    for (int i = 0; i < tempRecs.Count; i++)
                    {
                        str = "i : " + i.ToString() + " CardID : " + tempRecs.raDeviceRecs[i].CardID.ToString()
                            + " TimeDate : " + tempRecs.raDeviceRecs[i].TimeDate.ToString()
                            //+ " RFU[0] : " + tempRecs.raDeviceRecs[i].RFU[0].ToString()
                            //+ " RFU[1] : " + tempRecs.raDeviceRecs[i].RFU[1].ToString()
                            + " GcType : " + tempRecs.raDeviceRecs[i].GcType.ToString()
                            + " DoorNo : " + tempRecs.raDeviceRecs[i].DoorNo.ToString()
                            + " RecordType : " + tempRecs.raDeviceRecs[i].RecordType.ToString();
                        richTextBoxRecs.AppendText(str + "\u2028");
                    }
                   AddLog("Veriler okundu.");
                }
                else
                   AddLog("Veriler okunamadı!");
            }
            else
                AddLog("Cihaz Bağlantısı Yok.");        
        }

        private void btnTransferRecs_Click(object sender, EventArgs e)
        {
            if (rdr.Connected)
            {
                TAccessRecords tmpRecs = new TAccessRecords();
                if (rdr.TransferRecords(out tmpRecs))
                {
                    string str;
                    for (int i = 0; i < tmpRecs.Count; i++)
                    {
                        str = "i : " + i.ToString() + " CardID : " + tmpRecs.raDeviceRecs[i].CardID.ToString()
                            + " TimeDate : " + tmpRecs.raDeviceRecs[i].TimeDate.ToString()
                            + " DoorNo : " + tmpRecs.raDeviceRecs[i].DoorNo.ToString()
                            + " RecordType : " + tmpRecs.raDeviceRecs[i].RecordType.ToString();
                        richTextBoxRecs.AppendText(str + "\u2028");
                        //listView1.Items.Add( str );
                        AddLog("Veriler transfer edildi.");
                    }
                }
                else
                    AddLog("Veriler transfer edilemedi!");            
            }
            else
                AddLog("Cihaz Bağlantısı Yok.");        
        }

        private void frmMain_Activated(object sender, EventArgs e)
        {

            for (int i = 0; i < 6565; i++)
            {
                //edtCihazNo.te
            }

        }

        private void chkGunlukYenidenBaslatma_CheckedChanged(object sender, EventArgs e)
        {

            if (chkGunlukYenidenBaslatma.Checked == true) { edtGunlukYenidenBaslatmaZamani.Enabled = true; }
            else { edtGunlukYenidenBaslatmaZamani.Enabled = false; edtGunlukYenidenBaslatmaZamani.Text ="00:00:00"; }

        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
         TGeneralDeviceSettins rSettings;



         if (rdr.Connected == true)
         {
             if (rdr.GetDeviceGeneralSettings(out rSettings) == true  )
             {
                 edtCihazNo.Value = rSettings.DevNo ;


                 switch (rSettings.IdleScreenType )
                 {
                     case TIdleScreenType.stText: 
                         chkVarsayilanMesaj.Checked = true;
                         break;
                     case TIdleScreenType.stLogo:
                         chkVarsayilanLogo.Checked = true;
                         break;
                     default:
                         break;
                 }


                 //rSettings.DefaultScreenTxt1
                 //rSettings.Backlight
                 edtBirinciSatir.Text = rSettings.DefaultScreenTxt1;
                 edtIkinciSatir.Text = rSettings.DefaultScreenTxt2;
                 edtArkaPlanIsigi.Value = rSettings.Backlight;
                 edtRenkYogunlugu.Value = rSettings.Contrast;

                 switch (rSettings.TrOut1Type )
                 {
                     case TrOutType.NrOpen:
                         radioTransistorCikisi1NormalOpen.Checked = true;
                         break;
                     case TrOutType.NrClosed:
                         radioTransistorCikisi1NormalClosed.Checked = false;
                         break;
                     default:
                         break;
                 }


                 switch (rSettings.TrOut2Type )
                 {
                     case TrOutType.NrOpen:
                         radioTransistorCikisi2NormalOpen.Checked = true;
                         break;
                     case TrOutType.NrClosed:
                         radioTransistorCikisi2NormalClosed.Checked = true;
                         break;
                     default:
                         break;
                 }



                 chkGunlukYenidenBaslatma.Checked = rSettings.DailyRebootEnb;
                 edtGunlukYenidenBaslatmaZamani.Text = Convert.ToString(rSettings.RebootTime);
                 edtKartOkumaSuresi.Value = rSettings.CardReadBeepTime;
                 edtArdasikKartOkumaAraligi.Value = rSettings.CardReadTimeOut;
                 edtAyniKartiOkumaAraligi.Value = rSettings.VariableClearTimeout;
                 this.cmbFontTipi.SelectedIndex = rSettings.DefaultScreenFontType;
                 this.nmrKartLoginBeklemeSuresi.Value = rSettings.CardReadDelay;
                 AddLog("Cihazın genel bilgileri getirildi.");

             }


         }
         else {
             AddLog("Cihazla bağlantı yok !");
         
         }


        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            TGeneralDeviceSettins rSettings;

            if (rdr.Connected == true)
            {
                rSettings = new TGeneralDeviceSettins();

                //ushort devNo;
                //devNo = Convert.ToByte(edtCihazNo.Value);
                rSettings.DevNo = (ushort)(edtCihazNo.Value);


                if (chkVarsayilanMesaj.Checked == true)
                {rSettings.IdleScreenType = TIdleScreenType.stText;}
                else if ( chkVarsayilanLogo.Checked == true)
                {rSettings.IdleScreenType = TIdleScreenType.stLogo;}

                rSettings.DefaultScreenTxt1 = edtBirinciSatir.Text;
                rSettings.DefaultScreenTxt2 = edtIkinciSatir.Text;
                rSettings.Backlight = (ushort)edtArkaPlanIsigi.Value;
                rSettings.Contrast = (ushort)edtRenkYogunlugu.Value;

                if (radioTransistorCikisi1NormalOpen.Checked == true) { rSettings.TrOut1Type = TrOutType.NrOpen; } else { rSettings.TrOut1Type = TrOutType.NrClosed; }

                if (radioTransistorCikisi2NormalOpen.Checked == true) { rSettings.TrOut2Type = TrOutType.NrOpen; } else { rSettings.TrOut2Type = TrOutType.NrClosed; }

                if (chkGunlukYenidenBaslatma.Checked == true) { rSettings.DailyRebootEnb = true; } else { rSettings.DailyRebootEnb = false; }

                rSettings.RebootTime = edtGunlukYenidenBaslatmaZamani.Value;
                rSettings.CardReadBeepTime = (byte)edtKartOkumaSuresi.Value;
                rSettings.CardReadTimeOut = (ushort)edtArdasikKartOkumaAraligi.Value;
                rSettings.VariableClearTimeout = (ushort)edtArdasikKartOkumaAraligi.Value;
                rSettings.DefaultScreenFontType = (byte)cmbFontTipi.SelectedIndex;
                rSettings.CardReadDelay = (byte)nmrKartLoginBeklemeSuresi.Value;

                if (rdr.SetDeviceGeneralSettings(rSettings) == true)
                 AddLog("Bilgiler cihaza gönderildi.");
                else
                 AddLog("Bilgiler gönderilemedi.");
                

            }
            else { AddLog("Cihazla bağlantı sağlanamadı."); }

        }

        private void edtEkranMesajiSatirSayisi_ValueChanged(object sender, EventArgs e)
        {

            switch ((int)edtEkranMesajiSatirSayisi.Value)
            {
                case 1: 
                    { 
                      ekranMesajiOnlieSatir1.Enabled = true;
                      ekranMesajiOnlieSatir2.Text = "";
                      ekranMesajiOnlieSatir3.Text ="";
                      ekranMesajiOnlieSatir4.Text = "";
                      ekranMesajiOnlieSatir5.Text = "";
                      ekranMesajiOnlieSatir2.Enabled = false;
                      ekranMesajiOnlieSatir2x.Value = 0;
                      ekranMesajiOnlieSatir2y.Value = 0;
                      ekranMesajiOnlieSatir2x.Enabled = false;
                      ekranMesajiOnlieSatir2y.Enabled = false;
                      ekranMesajiOnlieSatir3.Enabled = false ;
                      ekranMesajiOnlieSatir3x.Value = 0;
                      ekranMesajiOnlieSatir3y.Value = 0;
                      ekranMesajiOnlieSatir3x.Enabled = false;
                      ekranMesajiOnlieSatir3y.Enabled = false;
                      ekranMesajiOnlieSatir4.Enabled = false ;
                      ekranMesajiOnlieSatir4x.Value = 0;
                      ekranMesajiOnlieSatir4y.Value = 0;
                      ekranMesajiOnlieSatir4x.Enabled = false;
                      ekranMesajiOnlieSatir4y.Enabled = false;
                      ekranMesajiOnlieSatir5.Enabled = false ;
                      ekranMesajiOnlieSatir5x.Value = 0;
                      ekranMesajiOnlieSatir5y.Value = 0;
                      ekranMesajiOnlieSatir5x.Enabled = false;
                      ekranMesajiOnlieSatir5y.Enabled = false;
                      break; 
                    }
                case 2:
                    {
                        ekranMesajiOnlieSatir1.Enabled = true;
                        ekranMesajiOnlieSatir2x.Value =5;
                        ekranMesajiOnlieSatir2y.Value = 30;
                        ekranMesajiOnlieSatir2.Enabled = true;
                        ekranMesajiOnlieSatir2x.Enabled = true ;
                        ekranMesajiOnlieSatir2y.Enabled = true ;
                        ekranMesajiOnlieSatir3.Enabled = false;
                        ekranMesajiOnlieSatir3x.Value = 0;
                        ekranMesajiOnlieSatir3y.Value = 0;
                        ekranMesajiOnlieSatir3x.Enabled = false;
                        ekranMesajiOnlieSatir3y.Enabled = false;
                        ekranMesajiOnlieSatir4.Enabled = false ;
                        ekranMesajiOnlieSatir4x.Value = 0;
                        ekranMesajiOnlieSatir4y.Value = 0;
                        ekranMesajiOnlieSatir4x.Enabled = false;
                        ekranMesajiOnlieSatir4y.Enabled = false;
                        ekranMesajiOnlieSatir5.Enabled = false;
                        ekranMesajiOnlieSatir5x.Value = 0;
                        ekranMesajiOnlieSatir5y.Value = 0;
                        ekranMesajiOnlieSatir5x.Enabled = false;
                        ekranMesajiOnlieSatir5y.Enabled = false;
                        ekranMesajiOnlieSatir3.Text = "";
                        ekranMesajiOnlieSatir4.Text = "";
                        ekranMesajiOnlieSatir5.Text = "";
                        break; 

                    }
                case 3:
                    {
                        
                        ekranMesajiOnlieSatir1.Enabled = true;
                        ekranMesajiOnlieSatir2.Enabled = true;
                        ekranMesajiOnlieSatir2x.Enabled = true;
                        ekranMesajiOnlieSatir2y.Enabled = true;
                        ekranMesajiOnlieSatir3x.Value = 5;
                        ekranMesajiOnlieSatir3y.Value = 45;
                        ekranMesajiOnlieSatir3.Enabled = true;
                        ekranMesajiOnlieSatir3x.Enabled = true;
                        ekranMesajiOnlieSatir3.Enabled = true;
                        ekranMesajiOnlieSatir3y.Enabled = true;
                        ekranMesajiOnlieSatir4.Enabled = false;
                        ekranMesajiOnlieSatir4x.Value = 0;
                        ekranMesajiOnlieSatir4y.Value = 0;
                        ekranMesajiOnlieSatir4x.Enabled = false;
                        ekranMesajiOnlieSatir4y.Enabled = false;
                        ekranMesajiOnlieSatir5.Enabled = false;
                        ekranMesajiOnlieSatir5x.Value = 0;
                        ekranMesajiOnlieSatir5y.Value = 0;
                        ekranMesajiOnlieSatir5x.Enabled = false;
                        ekranMesajiOnlieSatir5y.Enabled = false;
                        ekranMesajiOnlieSatir4.Text = "";
                        ekranMesajiOnlieSatir5.Text = "";
                        break; 
                    }

                case 4:
                    {
                        ekranMesajiOnlieSatir1.Enabled = true;
                        ekranMesajiOnlieSatir2.Enabled = true;
                        ekranMesajiOnlieSatir2x.Enabled = true;
                        ekranMesajiOnlieSatir2y.Enabled = true;
                        ekranMesajiOnlieSatir3.Enabled = true;
                        ekranMesajiOnlieSatir3x.Enabled = true;
                        ekranMesajiOnlieSatir3y.Enabled = true;
                        ekranMesajiOnlieSatir4x.Value = 5;
                        ekranMesajiOnlieSatir4y.Value = 60;
                        ekranMesajiOnlieSatir4.Enabled = true;
                        ekranMesajiOnlieSatir4x.Enabled = true ;
                        ekranMesajiOnlieSatir4y.Enabled = true;

                        ekranMesajiOnlieSatir5.Text = "";
                        ekranMesajiOnlieSatir5.Enabled = false;
                        ekranMesajiOnlieSatir5x.Value = 0;
                        ekranMesajiOnlieSatir5y.Value = 0;
                        ekranMesajiOnlieSatir5x.Enabled = false;
                        ekranMesajiOnlieSatir5y.Enabled = false;
                        
                        break; 
                    }

                case 5:
                    {
                        
                        ekranMesajiOnlieSatir1.Enabled = true;
                        ekranMesajiOnlieSatir2.Enabled = true;
                        ekranMesajiOnlieSatir2x.Enabled = true;
                        ekranMesajiOnlieSatir2y.Enabled = true;
                        ekranMesajiOnlieSatir3.Enabled = true;
                        ekranMesajiOnlieSatir3x.Enabled = true;
                        ekranMesajiOnlieSatir3y.Enabled = true;
                        ekranMesajiOnlieSatir4.Enabled = true;
                        ekranMesajiOnlieSatir4x.Enabled = true;
                        ekranMesajiOnlieSatir4y.Enabled = true;
                        ekranMesajiOnlieSatir5x.Value = 5;
                        ekranMesajiOnlieSatir5y.Value = 75;
                        ekranMesajiOnlieSatir5.Enabled = true;
                        ekranMesajiOnlieSatir5x.Enabled = true ;
                        ekranMesajiOnlieSatir5y.Enabled = true;
                        break;
                    }

                default:
                break;





            }

        }


        /*tab kontrol*/
        private void tabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {

            

        }

        private void edtEkranMesajiSatirSayisiOffline_ValueChanged(object sender, EventArgs e)
        {


            switch ((int)edtEkranMesajiSatirSayisiOffline.Value)
            {
                case 1:
                    {
                        ekranMesajiOfflineSatir1.Enabled = true;
                        ekranMesajiOfflineSatir2.Text = "";
                        ekranMesajiOfflineSatir3.Text = "";
                        ekranMesajiOfflineSatir4.Text = "";
                        ekranMesajiOfflineSatir5.Text = "";
                        ekranMesajiOfflineSatir2.Enabled = false;
                        ekranMesajiOfflineSatir2x.Value = 0;
                        ekranMesajiOfflineSatir2z.Value = 0;
                        ekranMesajiOfflineSatir2x.Enabled = false;
                        ekranMesajiOfflineSatir2z.Enabled = false;
                        ekranMesajiOfflineSatir3.Enabled = false;
                        ekranMesajiOfflineSatir3x.Value = 0;
                        ekranMesajiOfflineSatir3z.Value = 0;
                        ekranMesajiOfflineSatir3x.Enabled = false;
                        ekranMesajiOfflineSatir3z.Enabled = false;
                        ekranMesajiOfflineSatir4.Enabled = false;
                        ekranMesajiOfflineSatir4x.Value = 0;
                        ekranMesajiOfflineSatir4z.Value = 0;
                        ekranMesajiOfflineSatir4x.Enabled = false;
                        ekranMesajiOfflineSatir4z.Enabled = false;
                        ekranMesajiOfflineSatir5.Enabled = false;
                        ekranMesajiOfflineSatir5x.Value = 0;
                        ekranMesajiOfflineSatir5z.Value = 0;
                        ekranMesajiOfflineSatir5x.Enabled = false;
                        ekranMesajiOfflineSatir5z.Enabled = false;
                        break;
                    }
                case 2:
                    {
                        ekranMesajiOfflineSatir1.Enabled = true;
                        ekranMesajiOfflineSatir2x.Value = 5;
                        ekranMesajiOfflineSatir2z.Value = 30;
                        ekranMesajiOfflineSatir2.Enabled = true;
                        ekranMesajiOfflineSatir2x.Enabled = true;
                        ekranMesajiOfflineSatir2z.Enabled = true;
                        ekranMesajiOfflineSatir3.Enabled = false;
                        ekranMesajiOfflineSatir3x.Value = 0;
                        ekranMesajiOfflineSatir3z.Value = 0;
                        ekranMesajiOfflineSatir3x.Enabled = false;
                        ekranMesajiOfflineSatir3z.Enabled = false;
                        ekranMesajiOfflineSatir4.Enabled = false;
                        ekranMesajiOfflineSatir4x.Value = 0;
                        ekranMesajiOfflineSatir4z.Value = 0;
                        ekranMesajiOfflineSatir4x.Enabled = false;
                        ekranMesajiOfflineSatir4z.Enabled = false;
                        ekranMesajiOfflineSatir5.Enabled = false;
                        ekranMesajiOfflineSatir5x.Value = 0;
                        ekranMesajiOfflineSatir5z.Value = 0;
                        ekranMesajiOfflineSatir5x.Enabled = false;
                        ekranMesajiOfflineSatir5z.Enabled = false;
                        ekranMesajiOfflineSatir3.Text = "";
                        ekranMesajiOfflineSatir4.Text = "";
                        ekranMesajiOfflineSatir5.Text = "";
                        break;

                    }
                case 3:
                    {

                        ekranMesajiOfflineSatir1.Enabled = true;
                        ekranMesajiOfflineSatir2.Enabled = true;
                        ekranMesajiOfflineSatir2x.Enabled = true;
                        ekranMesajiOfflineSatir2z.Enabled = true;
                        ekranMesajiOfflineSatir3x.Value = 5;
                        ekranMesajiOfflineSatir3z.Value = 45;
                        ekranMesajiOfflineSatir3.Enabled = true;
                        ekranMesajiOfflineSatir3x.Enabled = true;
                        ekranMesajiOfflineSatir3.Enabled = true;
                        ekranMesajiOfflineSatir3z.Enabled = true;
                        ekranMesajiOfflineSatir4.Enabled = false;
                        ekranMesajiOfflineSatir4x.Value = 0;
                        ekranMesajiOfflineSatir4z.Value = 0;
                        ekranMesajiOfflineSatir4x.Enabled = false;
                        ekranMesajiOfflineSatir4.Enabled = false;
                        ekranMesajiOfflineSatir5.Enabled = false;
                        ekranMesajiOfflineSatir5x.Value = 0;
                        ekranMesajiOfflineSatir5z.Value = 0;
                        ekranMesajiOfflineSatir5x.Enabled = false;
                        ekranMesajiOfflineSatir5z.Enabled = false;
                        ekranMesajiOfflineSatir4.Text = "";
                        ekranMesajiOfflineSatir5.Text = "";
                        break;
                    }

                case 4:
                    {
                        ekranMesajiOfflineSatir1.Enabled = true;
                        ekranMesajiOfflineSatir2.Enabled = true;
                        ekranMesajiOfflineSatir2x.Enabled = true;
                        ekranMesajiOfflineSatir2z.Enabled = true;
                        ekranMesajiOfflineSatir3.Enabled = true;
                        ekranMesajiOfflineSatir3x.Enabled = true;
                        ekranMesajiOfflineSatir3z.Enabled = true;
                        ekranMesajiOfflineSatir4x.Value = 5;
                        ekranMesajiOfflineSatir4z.Value = 60;
                        ekranMesajiOfflineSatir4.Enabled = true;
                        ekranMesajiOfflineSatir4x.Enabled = true;
                        ekranMesajiOfflineSatir4z.Enabled = true;

                        ekranMesajiOfflineSatir5.Text = "";
                        ekranMesajiOfflineSatir5.Enabled = false;
                        ekranMesajiOfflineSatir5x.Value = 0;
                        ekranMesajiOfflineSatir5z.Value = 0;
                        ekranMesajiOfflineSatir5x.Enabled = false;
                        ekranMesajiOfflineSatir5z.Enabled = false;

                        break;
                    }

                case 5:
                    {

                        ekranMesajiOfflineSatir1.Enabled = true;
                        ekranMesajiOfflineSatir2.Enabled = true;
                        ekranMesajiOfflineSatir2x.Enabled = true;
                        ekranMesajiOfflineSatir2z.Enabled = true;
                        ekranMesajiOfflineSatir3.Enabled = true;
                        ekranMesajiOfflineSatir3x.Enabled = true;
                        ekranMesajiOfflineSatir3z.Enabled = true;
                        ekranMesajiOfflineSatir4.Enabled = true;
                        ekranMesajiOfflineSatir4x.Enabled = true;
                        ekranMesajiOfflineSatir4z.Enabled = true;
                        ekranMesajiOfflineSatir5x.Value = 5;
                        ekranMesajiOfflineSatir5z.Value = 75;
                        ekranMesajiOfflineSatir5.Enabled = true;
                        ekranMesajiOfflineSatir5x.Enabled = true;
                        ekranMesajiOfflineSatir5z.Enabled = true;
                        break;
                    }

                default:
                    break;





            }

        }

        private void edtGenelAyarlarGecisTipi_SelectedIndexChanged(object sender, EventArgs e)
        {

            

        }

        private void edtUygulamaAyariGirisTipi_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((int)edtUygulamaAyariGirisTipi.SelectedIndex)
            {

                case 0:
                    {
                        labelGecisSuresi.Visible = false;
                        edtUygulamaayarlariGecisSuresi.Visible = false;
                        break;
                    }

                case 1:
                    {
                        labelGecisSuresi.Text = "Buton Basma Süresi";
                        labelGecisSuresi.Visible = true ;
                        edtUygulamaayarlariGecisSuresi.Visible = true;
                        break;
                    }


                case 2:
                    {
                        labelGecisSuresi.Text = "Turnike dönüş bekleme Süresi";
                        labelGecisSuresi.Visible = true;
                        edtUygulamaayarlariGecisSuresi.Visible = true;
                        break;
                    }


                case 3:
                    {
                        labelGecisSuresi.Text = "Kapı açık kalma bekleme Süresi";
                        labelGecisSuresi.Visible = true;
                        edtUygulamaayarlariGecisSuresi.Visible = true;
                        break;
                    }


                default:
                    labelGecisSuresi.Visible = true;
                    edtUygulamaayarlariGecisSuresi.Visible = true;
                    break;
            }
        }

        private void edtUygulamaAyarlariAPBtipi_SelectedIndexChanged(object sender, EventArgs e)
        {


            switch ((int)edtUygulamaAyarlariAPBtipi.SelectedIndex)
            {


                case 0:
                    {
                        edtAntiPassBackArdisikGecisAraligi.Value = 0;
                        edtAntiPassBackArdisikGecisAraligi.Visible = false;
                        radioUygulamaAyarlariAntiPassBackGiris.Visible = false;
                        radioUygulamaAyarlariAntiPassBackCikis.Visible = false;
                        edtUygulamaAyarlariGuvenlikBolgeNo.Visible = false;
                        labelGuvenlikBolgeNo.Visible = false;
                        labeGecisAraligi.Visible = false;
                        break;
                    }


                case 1:
                    {
                        labelGuvenlikBolgeNo.Visible = true;
                        edtUygulamaAyarlariGuvenlikBolgeNo.Visible = true;
                        radioUygulamaAyarlariAntiPassBackGiris.Visible = true;
                        radioUygulamaAyarlariAntiPassBackCikis.Visible = true;
                        labelGuvenlikBolgeNo.Visible = true;
                        labeGecisAraligi.Visible = false ;
                        edtAntiPassBackArdisikGecisAraligi.Visible = false;
                        break;
                    }


                default :
                    {
                        labelGuvenlikBolgeNo.Visible = true;
                        edtUygulamaAyarlariGuvenlikBolgeNo.Visible = true;
                        radioUygulamaAyarlariAntiPassBackGiris.Visible = true;
                        radioUygulamaAyarlariAntiPassBackCikis.Visible = true;
                        labelGuvenlikBolgeNo.Visible = true;
                        labeGecisAraligi.Visible = true ;
                        edtAntiPassBackArdisikGecisAraligi.Visible = true;
                        break;
                    
                    }

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {

            TDeviceTCPSettings rSettings;
            if (rdr.Connected == true)
            {

                if (rdr.GetDeviceTCPSettings(out rSettings) == true)
                {

                    switch (rSettings.ProtocolType)
                    {
                        case TProtocolType.PR0:
                            edtHaberlesmeAyarlariProtokol.SelectedIndex = 0;
                            break;
                        case TProtocolType.PR1:
                            edtHaberlesmeAyarlariProtokol.SelectedIndex = 1;
                            break;
                        case TProtocolType.PR2:
                            edtHaberlesmeAyarlariProtokol.SelectedIndex = 2;
                            break;
                        case TProtocolType.PR3:
                            edtHaberlesmeAyarlariProtokol.SelectedIndex = 3;
                            break;
                        default:
                            break;
                    }

                    edtHaberlesmeIpAdresi.Text = rSettings.IPAdress;
                    edtHaberlesmeAltAgMaskesi.Text = rSettings.NetMask;
                    edtHaberlesmeAyarlariVarsayilanAgGecidi.Text = rSettings.DefGetway;
                    edtHaberlesmeBirinciDnsSunucu.Text = rSettings.PriDNS;
                    edtHaberlesmeIkinciDnsSunucu.Text = rSettings.SecDNS;
                    edtHaberlesmeAyarlariPortNumarasi.Value = rSettings.Port;
                    edtHaberlesmeAyarlariServerIpAdress.Text = rSettings.RemIpAdress;
                    if (rSettings.ConnectOnlyRemIpAdress == true) { chkHaberlesmeAyarlariSadeceServerIleHaberles.Checked = true; } else { chkHaberlesmeAyarlariSadeceServerIleHaberles.Checked = false; }
                    if (rSettings.DHCP == true) { chkHaberlesmeAyarlariDHCPAktif.Checked = true; } else { chkHaberlesmeAyarlariDHCPAktif.Checked = false; }
                    txtServerEchoZamanAsimi.Value = rSettings.ServerEchoTimeOut;
                    AddLog("Haberleşme bilgileri getirildi.");

                }
                else {
                    AddLog("Haberleşme bilgileri getirilemedi.");
                
                }

            }

            else {
                AddLog("Cihazla bağlantı yok.");
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            TTCPSettings rSettings;

            rSettings = new TTCPSettings();

            if (rdr.Connected == true)
            {

                switch (edtHaberlesmeAyarlariProtokol.SelectedIndex )
                {
                    case 0:
                        rSettings.ProtocolType = TProtocolType.PR0;
                        break;
                    case 1:
                        rSettings.ProtocolType = TProtocolType.PR1;
                        break;
                    case 2:
                        rSettings.ProtocolType = TProtocolType.PR2;
                        break;
                    case 3:
                        rSettings.ProtocolType = TProtocolType.PR3;
                        break;
                    default:
                    break;
                }


                rSettings.IPAdress = edtHaberlesmeIpAdresi.Text;
                rSettings.NetMask = edtHaberlesmeAltAgMaskesi.Text;
                rSettings.DefGetway = edtHaberlesmeAyarlariVarsayilanAgGecidi.Text;
                rSettings.PriDNS = edtHaberlesmeBirinciDnsSunucu.Text;
                rSettings.SecDNS = edtHaberlesmeIkinciDnsSunucu.Text;
                rSettings.Port = (ushort)edtHaberlesmeAyarlariPortNumarasi.Value;
                rSettings.RemIpAdress = edtHaberlesmeAyarlariServerIpAdress.Text;
                if (chkHaberlesmeAyarlariSadeceServerIleHaberles.Checked == true) { rSettings.ConnectOnlyRemIpAdress = true; } else { rSettings.ConnectOnlyRemIpAdress = false; }
                if (chkHaberlesmeAyarlariDHCPAktif.Checked == true) { rSettings.DHCP = true; } else { rSettings.DHCP = false; }

                if (rdr.SetDeviceTCPSettings(rSettings) == true )
                {
                    AddLog("TCP ayarları cihaza gönderildi.");
                } else 
                {
                    AddLog("TCP ayarları gönderilemedi.");
                }
                



            }
            else 
            {

                AddLog("Cihazla bağlantı yok");
            }


        }

        private void button6_Click(object sender, EventArgs e)
        {
            TUDPSettings rSettings;

            if (rdr.Connected == true)
            {


                try
                {

                    if (rdr.GetDeviceUDPSettings(out rSettings) == true)
                    {
                        edtUDPayarlariIpAdresi.Text = rSettings.RemUDPAdress;
                        edtUDPayarlariPortNumarasi.Value = rSettings.UDPPort;

                        if (rSettings.UDPIsActive == true) { chkUDPayarlariUDPAktif.Checked = true; } else { chkUDPayarlariUDPAktif.Checked = false; }
                        if (rSettings.UDPLogIsActive == true) { chkUDPayarlariUDPLogAktif.Checked = true; } else { chkUDPayarlariUDPLogAktif.Checked = false; }
                        AddLog("UDP ayarları getirildi.");

                    }
                    else {

                        AddLog("UDP ayarları getirilemedi.");
                    }

                }
                catch (Exception hata)
                {

                    AddLog("Hata meydana geldi. " + hata.Message);
                }

               
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            TUDPSettings rSettings;

            rSettings = new TUDPSettings();

            if (rdr.Connected == true)
            {

                rSettings.RemUDPAdress = edtUDPayarlariIpAdresi.Text;
                rSettings.UDPPort = (ushort)edtUDPayarlariPortNumarasi.Value;

                if (chkUDPayarlariUDPAktif.Checked == true) { rSettings.UDPIsActive = true; } else { rSettings.UDPIsActive = false; }
                if (chkUDPayarlariUDPLogAktif.Checked == true) { rSettings.UDPLogIsActive = true; } else { rSettings.UDPLogIsActive = false; }

                if (rdr.SetDeviceUDPSettings(rSettings) == true) { AddLog("UDP Ayarları gönderildi."); }
                else { AddLog("UDP ayarları gönderilemedi."); }

            }
            else { AddLog("Cihazla bağlantı sağlanamadı."); }


        }




        private void edtIp_KeyPress(object sender, KeyPressEventArgs e)
        {
            DialogResult onay;

            if (e.KeyChar == 13)
            {

                onay = MessageBox.Show("Bağlantı sağlansın mı ?", "Bağlantı onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (onay==DialogResult.Yes)
                {
                    btnConnect.PerformClick();    
                }
                
                
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            TClientTCPSettings rSettings;
            rSettings = new TClientTCPSettings();

            if (rdr.Connected == true)
            {
                if (rdr.GetDeviceClientTCPSettings(out rSettings) == true)
                {
                    edtHaberlesmeAyarlariTCPclientAyarlariIpAdresi.Text = rSettings.IPAdress;
                    edtHaberlesmeAyarlariTCPclientAyarlariPortNumarasi.Value = (ushort)rSettings.Port;
                    AddLog("TCP client ayarları getirildi.");
                }
                else {
                    AddLog("TCP client ayarları getirilemedi.");
                }



            }
            else { AddLog("Cihazla bağlantı sağlanamadı."); }


        }

        private void button8_Click(object sender, EventArgs e)
        {
            TClientTCPSettings rSettings;
            rSettings = new TClientTCPSettings();

            if (rdr.Connected == true)
            {

                rSettings.IPAdress = edtHaberlesmeAyarlariTCPclientAyarlariIpAdresi.Text;
                rSettings.Port = (ushort)edtHaberlesmeAyarlariTCPclientAyarlariPortNumarasi.Value;

                if (rdr.SetDeviceClientTCPSettings(rSettings) == true)
                {AddLog("TCP Client ayarları gönderildi.");}
                else { AddLog("TCP Client ayarları gönderilemedi.");}

            }
            else { AddLog("Cihazla bağlantı yok."); }
        }






    

        private void button18_Click(object sender, EventArgs e)
        {

            TAccessGeneralSettings rSettings;
            rSettings = new TAccessGeneralSettings();


            if (rdr.Connected == true)
            {

                if (rdr.GetAppGeneralSettings(out rSettings) == true)
                {
                    edtGenelAyarlarGecisTipi.SelectedIndex = rSettings.AccessMode.AccessType;
                    edtGenelAyarlarSifreGecisTipi.SelectedIndex = rSettings.AccessMode.PasswordType;
                    edtUygulamaAyariGirisTipi.SelectedIndex = rSettings.InputSettings.InputType;
                    edtUygulamaayarlariGecisSuresi.Value = rSettings.InputSettings.InputDurationTimeout;

                    if (rSettings.TimeAccessConstraintEnabled == true)
                        edtGenelAyarlarZamanKisitTablosuEtkin.Checked = true; 
                    else
                        edtGenelAyarlarZamanKisitTablosuEtkin.Checked = false;

                    cbPersTZMode.SelectedIndex = rSettings.PersonelTimeZoneMode;
                    AddLog("Uygulama genel bilgileri getirildi.");
                    cbPersTZMode_SelectedIndexChanged(this, e);
                }
                else
                    AddLog("Uygulama genel bilgileri getirilemedi."); 

            }
            else
                AddLog("Cihazla bağlantı yok.");            

        }

        private void button19_Click(object sender, EventArgs e)
        {

            TAccessGeneralSettings rSettings;
            rSettings = new TAccessGeneralSettings();


            if (rdr.Connected == true)
            {
                rSettings.AccessMode.AccessType = (byte)edtGenelAyarlarGecisTipi.SelectedIndex;
                rSettings.AccessMode.PasswordType =(byte)edtGenelAyarlarSifreGecisTipi.SelectedIndex;
                rSettings.InputSettings.InputDurationTimeout=(ushort)edtUygulamaayarlariGecisSuresi.Value;
                rSettings.InputSettings.InputType=(byte)edtUygulamaAyariGirisTipi.SelectedIndex;
                if (edtGenelAyarlarZamanKisitTablosuEtkin.Checked==true){rSettings.TimeAccessConstraintEnabled=true;} else {rSettings.TimeAccessConstraintEnabled=false;}
                rSettings.PersonelTimeZoneMode = (byte)cbPersTZMode.SelectedIndex;

                if (rdr.SetAppGeneralSettings(rSettings)==true){AddLog("Uygulama genel bilgileri cihaza gönderilid.");} else {AddLog("Uygulama bilgileri cihaza gönderilemedi.");}

            }
            else { AddLog("Cihazla bağlantı sağlanamadı."); }

        }

        private void button20_Click(object sender, EventArgs e)
        {

            frmZamanKisitTablosu newForm = new frmZamanKisitTablosu();
            newForm.ShowDialog();
 
        }

        private void button22_Click(object sender, EventArgs e)
        {

            TAPBSettings rSettings;
            rSettings = new TAPBSettings();

            if (frmMain.rdr.Connected == true)
            {

                if (rdr.GetAntiPassbackSettings(out rSettings) == true)
                {
                edtUygulamaAyarlariAPBtipi.SelectedIndex = rSettings.APBType;
                //cbAPBTypeChange(self);
                edtAntiPassBackArdisikGecisAraligi.Value = rSettings.SequentialTransitionTime;
                edtUygulamaAyarlariGuvenlikBolgeNo.Value = rSettings.SecurityZone;

                if (rSettings.ApbInOut == 0)
                { radioUygulamaAyarlariAntiPassBackGiris.Checked = true; }
                else { radioUygulamaAyarlariAntiPassBackCikis.Checked = false; }

                edtUygulamaAyarlariAPBtipi.SelectedIndexChanged += new EventHandler(edtUygulamaAyarlariAPBtipi_SelectedIndexChanged);

                    AddLog("APB Ayarları getirildi.");
                }
                else {
                    AddLog("APB Ayarları getirilemedi");
                }

            }
            else {
                AddLog("Cihazla bağlantı yok.");            
            }

        }

        private void button21_Click(object sender, EventArgs e)
        {

            TAPBSettings rSettings;
            rSettings = new TAPBSettings();


            if (frmMain.rdr.Connected == true)
            {

                rSettings.APBType = (byte)edtUygulamaAyarlariAPBtipi.SelectedIndex;
                rSettings.SequentialTransitionTime = (byte)edtAntiPassBackArdisikGecisAraligi.Value;
                rSettings.SecurityZone = (byte)edtUygulamaAyarlariGuvenlikBolgeNo.Value;

                if (radioUygulamaAyarlariAntiPassBackGiris.Checked == true)
                { rSettings.ApbInOut = 0; }
                else if (radioUygulamaAyarlariAntiPassBackCikis.Checked == true)
                { rSettings.ApbInOut = 1; }

                try
                {
                    if (rdr.SetAntiPassbackSettings(rSettings) == true)
                    {
                        AddLog("APB Ayarları gönderildi.");
                    }
                    else { 
                        AddLog("APB Ayarları gönderilemeddi.");
                    }
                }
                catch (Exception hata)
                {

                    AddLog("Bilgiler cihaza gönderilemedi." + hata.Message);
                }


            }
            else {
                AddLog("Cihazla bağlantı sağlanamadı.");
            }

        }

        private void button24_Click(object sender, EventArgs e)
        {


            TEksOtherSettings EksOtherSettings;
            EksOtherSettings = new TEksOtherSettings();


            if (rdr.Connected == true)
            {

                if (rdr.GetEksOtherSettings(out EksOtherSettings) == true)
                {
                    digerEKSAyarlariKisiVerisi.Value = EksOtherSettings.PersDataCardSector;
                    digerEKSAyarlariEKSverisi.Value = EksOtherSettings.AccessDataCardSector;
                    AddLog("Eks Diğer Bilgileri getirildi");
                }
                else { AddLog("Eks Diğer Bilgileri getirilemedi"); }

            }
            else {AddLog("Cihazla bağlantı yok");}


        }

        private void button23_Click(object sender, EventArgs e)
        {


            TEksOtherSettings EksOtherSettings;
            EksOtherSettings = new TEksOtherSettings();

            if (rdr.Connected == true)
            {
                EksOtherSettings.PersDataCardSector =(byte)digerEKSAyarlariKisiVerisi.Value;
                EksOtherSettings.AccessDataCardSector = (byte)digerEKSAyarlariEKSverisi.Value;


                if (rdr.SetEksOtherSettings(EksOtherSettings) == true)
                {
                    AddLog("Eks Diğer Bilgileri gönderildi.");
                }
                else {
                    AddLog("Eks Diğer Bilgileri gönderilemedi.");
                }

            }
            else {
                AddLog("Cihazla bağlantı yok.");
            }


        }

        private void button27_Click(object sender, EventArgs e)
        {


            TOutOfServiceSettings Settings;
            Settings = new TOutOfServiceSettings();


            if (rdr.Connected == true)
            {

                if (rdr.GetOutOfServiceSettings(out Settings) == true)
                {
                    
                    chkOkuyucuHizmetDisiAyarlariHizmetDisiEtkin.Checked = Settings.Enabled;
                    chkOkuyucuHizmetDisiAyarlariHizmet1Satir.Text = Settings.ScreenText1;
                    chkOkuyucuHizmetDisiAyarlariHizmet2Satir.Text = Settings.ScreenText2;

                    switch (Settings.OutType)
                    { 

                        case 0:
                        chkOkuyucuHizmetDisiAyarlariTransistorCikisiDegisiklikYok.Checked = true;
                        break;

                        case 1:
                        chkOkuyucuHizmetDisiAyarlariTransistorCikisi1.Checked = true;
                        break;

                        case 2:
                        chkOkuyucuHizmetDisiAyarlariTransistorCikisi2.Checked = true;
                        break;
                        
                        default:
                        break;
                    }

                }

            }
            else {
                AddLog("Cihazla bağlantı sağlanamadı.");
            }

        }

        private void button26_Click(object sender, EventArgs e)
        {

            TOutOfServiceSettings Settings;
            Settings = new TOutOfServiceSettings();

            if (rdr.Connected == true)
            {

                Settings.Enabled = chkOkuyucuHizmetDisiAyarlariHizmetDisiEtkin.Checked;
                Settings.ScreenText1 = chkOkuyucuHizmetDisiAyarlariHizmet1Satir.Text;
                Settings.ScreenText2 = chkOkuyucuHizmetDisiAyarlariHizmet2Satir.Text;

                if (chkOkuyucuHizmetDisiAyarlariTransistorCikisiDegisiklikYok.Checked==true)
                { Settings.OutType = 0; }
                else if (chkOkuyucuHizmetDisiAyarlariTransistorCikisi1.Checked == true)
                { Settings.OutType = 1;  }
                else if (chkOkuyucuHizmetDisiAyarlariTransistorCikisi2.Checked == true)
                { Settings.OutType = 2; }

                if (rdr.SetOutOfServiceSettings(Settings) == true)
                {
                    AddLog("Uygulama genel bilgileri gönderildi.");
                }
                else { AddLog("Uygulama genel bilgileri gönderilemedi."); }

            
            }
            else {
                AddLog("Cihazla bağlantı sağlanamadı.");
            
            }



        }

        private void button25_Click(object sender, EventArgs e)
        {

            frmHizmetDisiTablosu newForm = new frmHizmetDisiTablosu();
            newForm.ShowDialog();

        }

        private void button30_Click(object sender, EventArgs e)
        {
            TBellSettings Settings;
            Settings = new TBellSettings();

            if (rdr.Connected == true)
            {
                if (rdr.GetBellSettings(out Settings) == true)
                {
                    if (Settings.Enabled == true) { chkZilCaldirmaEtkin.Checked = true; } else { chkZilCaldirmaEtkin.Checked = false; }
                    edtZilCaldirma1Satir.Text = Settings.ScreenText1;
                    edtZilCaldirma2Satir.Text = Settings.ScreenText2;

                    switch (Settings.OutType)
                    {
                        case 1:
                            chkZilCaldirmaTransistorCikisi1.Checked = true;
                            break;
                        case 2:
                            chkZilCaldirmaTransistorCikisi2.Checked = true;
                            break;
                        default:
                        break;
                    }

                    AddLog("Zil çaldırma bilgileri getirildi.");
                }
            }
            else {

                AddLog("Cihazla bağlantı sağlanamadı.");
            }

        }

        private void button29_Click(object sender, EventArgs e)
        {
            TBellSettings Settings;
            Settings = new TBellSettings();

            if (rdr.Connected == true)
            {
                if (chkZilCaldirmaEtkin.Checked == true) { Settings.Enabled = true; } else { Settings.Enabled = false; }
                Settings.ScreenText1 = edtZilCaldirma1Satir.Text;
                Settings.ScreenText2 = edtZilCaldirma2Satir.Text;
                if (chkZilCaldirmaTransistorCikisi1.Checked == true) { Settings.OutType = 1; } else { Settings.OutType = 2; }

                if (rdr.SetBellSettings(Settings) == true) { AddLog("Zil çaldırma bilgileri gönderildi."); } else { AddLog("Zil çaldırma bilgileri gönderilemedi."); }


            }
            else {
                AddLog("Cihazla bağlantı sağlanamadı.");
            
            }




        }

        private void button17_Click(object sender, EventArgs e)
        {

            if (rdr.Connected == true)
            {

                if (chkYenidenBaslat.Checked==true) 
                {
                rdr.SetAppFactoryDefault(true);
                rdr.DisConnect();
                Thread.Sleep(1000);
                rdr.Connect();

                } 
                else {
                AddLog("Cihaz fabrika ayarlarına dönülemedi.");
                }

            }
            else {
                AddLog("Cihaza bağlantı sağlanamadı.");
            
            }


        }

        private void button38_Click(object sender, EventArgs e)
        {
            if (txtUygulamaTipi.Text != "HGS")
            {
                MessageBox.Show("Sadece HGS fw ile çalışır.");
            }
            else
            {
                if (rdr.Connected == true)
                {
                    rdr.ClearWhitelist();
                    rdr.DisConnect();
                    Thread.Sleep(1000);
                    rdr.Connect();
                }
                else {
                    AddLog("Cihazla bağlantı sağlanamadı.");
                }
            }

        }

        private void button37_Click(object sender, EventArgs e)
        {
            int cnt;

            if (rdr.Connected == true)
            {
                cnt = rdr.GetWhitelistCardIDCount();


                if (cnt != -1)
                {
                labelHgsTanimliKisiSayisi.Text ="Tanımlı kişi sayısı : "+ cnt.ToString();
                }
                else {
                    labelHgsTanimliKisiSayisi.Text = "Tanımlı kişi sayısı getirilemedi.";
                }


            }
            else {

                AddLog("Cihazla bağlantı yok !");
            }



        }

        private void button43_Click(object sender, EventArgs e)
        {
            string Sifre="";
            if (rdr.Connected == true)
            {
             Sifre=rdr.GetWebPassword();
            }
            else {
                AddLog("Cihazla bağlantı sağlanamadı.");
            }

            if (Sifre != "*")
            {
                AddLog("Web arayüz şifresi getirildi");
                txtWebAraYuzuSifresi.Text = Sifre;
            }
            else {
                AddLog("Web arayüz şifresi getirilemedi");
            }

            
        }

        private void button13_Click(object sender, EventArgs e)
        {

            Boolean isSet=false;

            if (rdr.Connected == true)
            {
               isSet=rdr.SetWebPassword(txtWebAraYuzuSifresi.Text);
            }
            else
            {
                AddLog("Cihazla bağlantı sağlanamadı.");
            }


            if (isSet == true)
            {
            MessageBox.Show("Web arayüz şifresi değiştirildi.");           
            }
            else {
            MessageBox.Show("Web arayüz şifresi değiştirilemedi.");           
            }

        }

       


        private void button28_Click(object sender, EventArgs e)
        {
            frmZilTablosu newForm = new frmZilTablosu();

            newForm.ShowDialog();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            
            TMfrKeyListStr KeyList = new TMfrKeyListStr();
            
            if (rdr.Connected == true)
            {

                if (rdr.GetMfrKeyList(out KeyList)==true)
                { 
                groupBox23.Controls.Clear();
                    for (int i = 0; i < 16; i++)
                    {

                        TextBox ntKeyA=new TextBox();
                        ntKeyA.Left = 10;
                        ntKeyA.Name = "keyA" + i.ToString();

                        if (i==0)
                        {
                            ntKeyA.Top = 30;
                        }
                        ntKeyA.Text = KeyList.Sector[i].KeyA.ToString();
                        ntKeyA.Top = groupBox23.Top + i * 25;

                        TextBox ntKeyB = new TextBox();
                        ntKeyB.Left = ntKeyA.Width + 30 ;
                        ntKeyB.Name = "keyB" + i.ToString();

                        if (i == 0)
                        {
                            ntKeyB.Top = 30;
                        }

                        ntKeyB.Text = KeyList.Sector[i].KeyB.ToString();
                        ntKeyB.Top = groupBox23.Top + i * 25;

                        groupBox23.Controls.Add(ntKeyA);
                        groupBox23.Controls.Add(ntKeyB);


                    }
                }

            }
            else {

                AddLog("Cihazla bağlantınız yok");
            }

        }

   

        private void btnHgsGenelAyarlariGetir_Click(object sender, EventArgs e)
        {
            THGS_Settings rSettings;
            rSettings = new THGS_Settings();


            if (txtUygulamaTipi.Text != "HGS")
            {
                MessageBox.Show("Sadece HGS fw ile çalışır.");
            }
            else {

                if (rdr.Connected == true)
                {
                    if (rdr.GetHGSSettings(out rSettings) == true)
                    {
                        txtHgsGenelAyarlarSeriPaketBoyutu.Value = rSettings.PaketBoyu;
                        txtHgsGenelAyarlarKartBaslangici.Value = rSettings.CardBaslangic;
                        txtHgsGenelAyarlarTagId.Value = rSettings.CardBoyu;
                        txtHgsGenelAyarlarTransistorCikisi1.Value = rSettings.TrCikisSure1;
                        txtHgsGenelAyarlarTransistorCikisi2.Value = rSettings.TrCikisSure2;
                        txtHgsGenelAyarlarProgramModu.SelectedIndex = rSettings.ProgramMode -1;
                        txtHgsGenelAyarlarDiziArdisikKontrol1.Value = rSettings.DiziEklemeSure1;
                        txtHgsGenelAyarlarDiziArdisikKontrol2.Value = rSettings.DiziEklemeSure2;

                        if (rSettings.ZamanKisitEnb == true)
                        { txtHgsGenelAyarlarZamanKisitEtkin.Checked = true; }
                        else { txtHgsGenelAyarlarZamanKisitEtkin.Checked = false; }

                        txtHgsGenelAyarlarAntenGuc1.Value = rSettings.AntenPower1;
                        txtHgsGenelAyarlarAntenGuc2.Value = rSettings.AntenPower2;
                        txtHgsGenelAyarlarAntenKtanima.Value = rSettings.AntenTanitim;
                        txtHgsGenelAyarlarAracDaireSayisi.Value = rSettings.DefMaksimumArac;
                        txtHgsGenelAyarlarArdisikGecisSuresi.Value = rSettings.DefAntiPassPack;
                        txtHgsGenelAyarlarAppType.Value = rSettings.AppType;

                        AddLog("Bilgiler getirildi.");

                    }
                    else {
                        AddLog("Bilgiler getirilemedi.");
                    
                    }
                }
                else { AddLog("Cihazla bağlantı yok !"); }
            
            }



        }

        private void btnHgsGenelAyarlariGonder_Click(object sender, EventArgs e)
        {

            THGS_Settings rSettings;
            rSettings = new THGS_Settings();

            if (txtUygulamaTipi.Text != "HGS")
            {
                MessageBox.Show("Sadece HGS fw ile çalışır.");
            }
            else {

                if (rdr.Connected == true)
                {

                    rSettings.PaketBoyu = (byte)txtHgsGenelAyarlarSeriPaketBoyutu.Value;
                    rSettings.CardBaslangic = (byte)txtHgsGenelAyarlarKartBaslangici.Value;
                    rSettings.CardBoyu = (byte)txtHgsGenelAyarlarTagId.Value;
                    rSettings.TrCikisSure1 = (byte)txtHgsGenelAyarlarTransistorCikisi1.Value;
                    rSettings.TrCikisSure2 = (byte)txtHgsGenelAyarlarTransistorCikisi2.Value ;
                    rSettings.ProgramMode =  (byte)(txtHgsGenelAyarlarProgramModu.SelectedIndex +1) ;
                    rSettings.DiziEklemeSure1 = (byte)txtHgsGenelAyarlarDiziArdisikKontrol1.Value;
                    rSettings.DiziEklemeSure2 = (byte)txtHgsGenelAyarlarDiziArdisikKontrol2.Value;

                    if (txtHgsGenelAyarlarZamanKisitEtkin.Checked == true)
                    { rSettings.ZamanKisitEnb =true; }
                    else { rSettings.ZamanKisitEnb = false; }


                    rSettings.AntenPower1 = (byte)txtHgsGenelAyarlarAntenGuc1.Value;
                    rSettings.AntenPower2 = (byte)txtHgsGenelAyarlarAntenGuc2.Value;
                    rSettings.AntenTanitim = (byte)txtHgsGenelAyarlarAntenKtanima.Value;
                    rSettings.DefMaksimumArac = (byte)txtHgsGenelAyarlarAracDaireSayisi.Value;
                    rSettings.DefAntiPassPack = (byte)txtHgsGenelAyarlarArdisikGecisSuresi.Value;
                    rSettings.AppType = (byte)txtHgsGenelAyarlarAppType.Value;
                    

                    if (rdr.SetHGSSettings(rSettings) == true)
	                    {
                        AddLog("Bilgiler gönderildi.");
	                    } else  
                        {AddLog("Bilgiler gönderilemedi.");}

                }
                else {
                    AddLog("Cihazla bağlantı sağlanamadı.");
                
                }

            }




        }

        private void btnMacAdresiGetir_Click(object sender, EventArgs e)
        {

            String strMACAddress;

            if (rdr.Connected == true)
            {
                strMACAddress = rdr.GetMACAddress();

                if (strMACAddress == "*")
                {
                    AddLog("Cihaz mac adresi getirilemedi.");
                }
                else {
                    txtMacAdresi.Text = strMACAddress;
                    AddLog("Cihaz mac adresi getirildi.");
                }

            }
            else { AddLog("Cihaza bağlantı yok");

            

            }


        }

        private void btnMacAdresiGonder_Click(object sender, EventArgs e)
        {

            if (rdr.Connected == true)
            {
                if (rdr.SetMACAddress(txtMacAdresi.Text))
                {
                    AddLog("Mac adresi gönderildi.");
                }
                else {
                    AddLog("Mac adresi gönderilemedi.");
                
                }


            }
            else {
                AddLog("Cihazla bağlantı yok.");
            
            }

        }

        private void btnDaireAracHakkiGetir_Click(object sender, EventArgs e)
        {
            byte hak=0;
            if (txtUygulamaTipi.Text != "HGS")
            {
                MessageBox.Show("Sadece HGS fw ile çalışır.");
                
            }
            else {

                if (rdr.Connected == true)
                {
                    if (rdr.GetHGSDaireParkHak((uint)txtDaireAracHakkiOtoparkHakkiDaire.Value,out hak)==true)
                    {
                        txtDaireAracHakkiOtoparkHakki.Value = hak;
                        AddLog("Hak bilgileri getirildi.");
                    }
                    else {

                        AddLog("Bilgiler getirilemedi.");
                    
                    }
                    
                    
                    

                }
                else {
                    AddLog("Cihazla bağlantı yok");
                
                }
            
            }

        }

        private void btnDaireAracHakkiGonder_Click(object sender, EventArgs e)
        {

            if (txtUygulamaTipi.Text != "HGS")
            {
                MessageBox.Show("Sadece HGS fw ile çalışır.");

            }
            else
            {

                if (rdr.Connected == true)
                {
                    if (rdr.SetHGSDaireParkHak((byte)txtDaireAracHakkiOtoparkHakkiDaire.Value, (uint)txtDaireAracHakkiOtoparkHakki.Value) == true)
                    {
                        AddLog("Bilgiler gönderildi.");
                    } 
                    else {
                        AddLog("Bilgiler gönderilemedi.");
                    
                    }
                }
                else
                {
                    AddLog("cihazla bağlantı yok");

                }
            }

        }

        private void btnHgsEkle_Click(object sender, EventArgs e)
        {
            
              int iErr;
              int InxNm;
              String CardID ;
              Boolean Devam;

              THGSArac Arac;
              Arac = new THGSArac();


              if (txtUygulamaTipi.Text == "HGS")
              {
                  //Devam = false;
                  CardID = txtHgsGenelAyarlarKartId.Text;
                  Devam = true;
                      //(Extensions.IsHex(Convert.ToChar(CardID))); 
                     
                      //(Length(CardID) = 16));

                  if (!Devam)
                  {
                      MessageBox.Show("Uygun tag id girilmemiş.");
                  }
                  if (Devam)
                  {
                      Arac.CardID = CardID;
                      Arac.Name = txtHgsGenelAyarlarKartHGSAdi.Text;
                      Arac.TimeAccessMask[0] = (byte)txtHgsGenelAyarlarPazartesi.Value;
                      Arac.TimeAccessMask[1] = (byte)txtHgsGenelAyarlarSali.Value;
                      Arac.TimeAccessMask[2] = (byte)txtHgsGenelAyarlarCarsamb.Value;
                      Arac.TimeAccessMask[3] = (byte)txtHgsGenelAyarlarPersembe.Value;
                      Arac.TimeAccessMask[4] = (byte)txtHgsGenelAyarlarCuma.Value;
                      Arac.TimeAccessMask[5] = (byte)txtHgsGenelAyarlarCumartesi.Value;
                      Arac.TimeAccessMask[6] = (byte)txtHgsGenelAyarlarPazar.Value;
                      Arac.Daire = (ushort)txtHgsGenelAyarlarDaire.Value;
                      Arac.AracNo = (byte)txtHgsGenelAyarlarArac.Value;
                      Arac.EndDate = Convert.ToDateTime(txtHgsGenelAyarlarKartinSonKullanmaTarihi.Text);
                      
                      if (txtHgsGenelAyarlarKisiCihazdaAktifMi.Checked == true)
                      { Arac.AccessDevice = true; }
                      else { Arac.AccessDevice = false; }

                      if (txtHgsGenelAyarlarAntiPassBackKontroluOlsunMu.Checked ==true)
                      {Arac.APBEnabled = true;} else
                      {Arac.APBEnabled = false;}

                      if (txtHgsGenelAyarlarKisitKontroluOlsunMu.Checked == true)
                      { Arac.ATCEnabled = true; }
                      else
                      { Arac.ATCEnabled = false; }

                      iErr = rdr.AddHGSWhitelist(Arac, out InxNm);

                      switch (iErr)
                      {
                          case 0:
                              AddLog("Araç eklendi.");
                              labelHgsTanimliKisiSayisi.Text = Convert.ToString(InxNm);
                              break;
                          case 26:
                              AddLog("Bu Daire- Araç daha önce tanımlanmış.");
                              break;
                          case 24:
                              AddLog("Tag ID var Daire yok.");
                              break;
                          case 25:
                              AddLog("Daire var Tag ID yok.");
                              break;
                          case 52:
                              AddLog("sonra");
                              break;
                          default:
                              AddLog("Araç eklenemedi." + iErr.ToString());
                          break;
                      }

                      
                  }

              }
              else
              {
                  AddLog("Sadece HGS fw ile çalışır.");
              }

        }

        private void btnHgsSil_Click(object sender, EventArgs e)
        {

        String CardID;
        int InxNm;

        if (txtUygulamaTipi.Text == "HGS")
        {
            labelHgsTanimliKisiSayisi.Text  = "-1";

            if (rdr.Connected == true)
            {
                CardID =txtHgsGenelAyarlarKartId.Text;

                
                    if (rdr.DeleteHGSWhitelistWithCardID(CardID, out InxNm) == 0)
                    {
                        AddLog("Araç kaydı silindi.");
                        lblHGSIndexNo.Text = Convert.ToString(InxNm);
                    }
                    else {
                        AddLog("Araç silinemedi.");
                    }
                
                


            }
            else {
                AddLog("cihazla bağlantı yok");            
            }

        }
        else {
            MessageBox.Show("Sadece HGS fw ile çalışır");
        }


        }

        private void btnHgsBul_Click(object sender, EventArgs e)
        {    
              THGSArac Arac ;
              int iErr;
              int i;
              int cnt;
              int InxNm;
              String CardID;

            if (txtUygulamaTipi.Text == "HGS")
            {
                if (rdr.Connected == true)
                {
                    CardID = txtHgsGenelAyarlarKartId.Text;

                    
                        iErr = rdr.GetHGSWhitelistWithCardID(CardID, out Arac, out InxNm);
                                 //GetHGSWhitelistWithCardID

                        if (iErr==0)
                        {   
                            txtHgsGenelAyarlarKartId.Text = CardID;
                            txtHgsGenelAyarlarKartHGSAdi.Text = Arac.Name;
                            txtHgsGenelAyarlarPazartesi.Value = Arac.TimeAccessMask[0];
                            txtHgsGenelAyarlarSali.Value = Arac.TimeAccessMask[1];
                            txtHgsGenelAyarlarCarsamb.Value = Arac.TimeAccessMask[2];
                            txtHgsGenelAyarlarPersembe.Value = Arac.TimeAccessMask[3];
                            txtHgsGenelAyarlarCuma.Value = Arac.TimeAccessMask[4];
                            txtHgsGenelAyarlarCumartesi.Value = Arac.TimeAccessMask[5];
                            txtHgsGenelAyarlarPazar.Value= Arac.TimeAccessMask[6];
                            txtHgsGenelAyarlarDaire.Value = Arac.Daire;
                            txtHgsGenelAyarlarArac.Value = Arac.AracNo;
                            txtHgsGenelAyarlarKartinSonKullanmaTarihi.Value = Arac.EndDate;

                            if (Arac.AccessDevice==true)
	                        {txtHgsGenelAyarlarKisiCihazdaAktifMi.Checked = true;} else 
                            {txtHgsGenelAyarlarKisiCihazdaAktifMi.Checked = false;}

                            if (Arac.APBEnabled == true)
	                        {txtHgsGenelAyarlarAntiPassBackKontroluOlsunMu.Checked = true;} else 
                            {txtHgsGenelAyarlarAntiPassBackKontroluOlsunMu.Checked = false;}
                            
                            if (Arac.ATCEnabled == true)
	                        {txtHgsGenelAyarlarKisitKontroluOlsunMu.Checked = true;} else 
                            {txtHgsGenelAyarlarKisitKontroluOlsunMu.Checked = false;}

                            lblHGSIndexNo.Text = Convert.ToString(InxNm);

                            AddLog("araç bilgileri getirildi");

                        }
                        else { AddLog("Araç kaydı bulunamadı"); }

                    
                    

                }
                else { AddLog("Cihazla bağlantı yok"); }
            }
            else {
                MessageBox.Show("Sadece HGS fw ile çalışır.");
            }

        }

        private void btnHgsDegistir_Click(object sender, EventArgs e)
        {
            THGSArac Arac;
            Arac = new THGSArac();

          int iErr, i, cnt, InxNm;
          String CardID ;

          if (txtUygulamaTipi.Text == "HGS")
          {

               lblIndexNo.Text = "-1";

               CardID = txtHgsGenelAyarlarKartId.Text;

              
                  Arac.CardID = CardID;
                  Arac.Name = txtHgsGenelAyarlarKartHGSAdi.Text;
                  Arac.TimeAccessMask[0] = Convert.ToByte(txtHgsGenelAyarlarPazartesi.Value);
                  Arac.TimeAccessMask[1] = Convert.ToByte(txtHgsGenelAyarlarSali.Value);
                  Arac.TimeAccessMask[2] = Convert.ToByte(txtHgsGenelAyarlarCarsamb.Value);
                  Arac.TimeAccessMask[3] = Convert.ToByte(txtHgsGenelAyarlarPersembe.Value);
                  Arac.TimeAccessMask[4] = Convert.ToByte(txtHgsGenelAyarlarCuma.Value);
                  Arac.TimeAccessMask[5] = Convert.ToByte(txtHgsGenelAyarlarCumartesi.Value);
                  Arac.TimeAccessMask[6] = Convert.ToByte(txtHgsGenelAyarlarPazar.Value);
                  Arac.Daire = Convert.ToByte(txtHgsGenelAyarlarDaire.Value);
                  Arac.AracNo = Convert.ToByte(txtHgsGenelAyarlarArac.Value);
                  Arac.EndDate = Convert.ToDateTime(txtHgsGenelAyarlarKartinSonKullanmaTarihi.Text);

                  if (txtHgsGenelAyarlarKisiCihazdaAktifMi.Checked == true)
                  { Arac.AccessDevice = true; }
                  else
                  { Arac.AccessDevice = false; }

                  if (txtHgsGenelAyarlarAntiPassBackKontroluOlsunMu.Checked == true)
                  { Arac.APBEnabled = true; }
                  else
                  { Arac.APBEnabled = false; }

                  if (txtHgsGenelAyarlarKisitKontroluOlsunMu.Checked == true)
                  { Arac.ATCEnabled = true; }
                  else
                  { Arac.ATCEnabled = false; }
                  
                  iErr =rdr.EditHGSWhitelistWithCardID(Arac, out InxNm);

                  switch (iErr)
                  {
                      case 0:
                          AddLog("Araç değiştirildi.");
                          lblHGSIndexNo.Text =Convert.ToString(InxNm);
                          break;
                      case 20:
                          AddLog("Araç kapasitesi aşıldı.");
                          break;
                      default:
                          break;
                  }
                  




          }
          else {
              MessageBox.Show("Sadece HGS fw ile çalışır.");
          }

        }

        private void btnHgsCihazdangelenBilgileriOku_Click(object sender, EventArgs e)
        {
            THGSRecords tempRecs = new THGSRecords();
            String strCardId;

            //TAccessRecords tempRecs = new TAccessRecords();


            if (txtUygulamaTipi.Text != "HGS")
            {
                MessageBox.Show("Bu uygulama sadece çalışma modu HGS alanında çalışır.");
            }
            else {

                if (rdr.Connected == true)
                {
                    richTextRec2.Items.Clear();

                    if (rdr.ReadHGSRecords((uint)txtBaslangic.Value, (uint)txtSayi.Value , out tempRecs) == 0)
                    {
                        richTextRec2.Items.Add("Başlangıç : " + Convert.ToDateTime(DateTime.Today) + " Başlangıç : " + Convert.ToInt32(txtBaslangic.Value) + " Sayı : " + Convert.ToInt32(txtSayi.Value));

                            for (int i = 0; i < tempRecs.Count; i++)
                            {
                             strCardId = tempRecs.raDeviceRecs[i].CardID;
                             richTextRec2.Items.Add("Card ID : " + strCardId + " Door No : " + Convert.ToString(tempRecs.raDeviceRecs[i].DoorNo) + " Rec. Type: " + Convert.ToString(tempRecs.raDeviceRecs[i].RecordType) + " Time Date: " + Convert.ToString(tempRecs.raDeviceRecs[i].TimeDate) );


                            }

                    }

                }
                else { AddLog("Cihazla bağlantı yok"); }


            
            }


            MessageBox.Show(richTextRec2.Items.Count.ToString());

        }

        private void btnHgsVerileriTransferEt_Click(object sender, EventArgs e)
        {
        THGSRecords tempRecs ;
        String strCardId;


            if (txtUygulamaTipi.Text != "HGS")
            {
                MessageBox.Show("Bu uygulama sadece çalışma modu HGS alanında çalışır.");
            }
            else
            {
                if (rdr.Connected == true)
                {
                    richTextRec2.Items.Clear();

                    if (rdr.TransferHGSRecords(out tempRecs)==0)
                    {

                        richTextRec2.Items.Add("Başlangıç : " + Convert.ToString(DateTime.Today) );

                        for (int i = 0; i <= tempRecs.Count ; i++)
                        {
                            strCardId = tempRecs.raDeviceRecs[i].CardID;
                            //richTextRec2_1.Text += Environment.NewLine;
                            richTextRec2.Items.Add("Card ID: " + strCardId + " Door no: " + Convert.ToString(tempRecs.raDeviceRecs[i].DoorNo) + " Record Type: " + Convert.ToString(tempRecs.raDeviceRecs[i].RecordType) + " Time Date : " + Convert.ToString(tempRecs.raDeviceRecs[i].TimeDate) + Environment.NewLine);
                        }

                    }

                }
                else { AddLog("Cihazla bağlantı yok."); }

            }

        }

        private void btnDaireSil_Click(object sender, EventArgs e)
        {
           int InxNm;


           if (txtUygulamaTipi.Text != "HGS")
           {
               MessageBox.Show("Bu uygulama sadece çalışma modu HGS alanında çalışır.");
           }
           else
           {
               if (rdr.Connected == true)
               {
                   if (txtHgsGenelAyarlarDaire.Value >= 0 && txtHgsGenelAyarlarArac.Value >=0)
                   {
                       if (rdr.DeleteHGSWhitelistWithDaireArac((ushort)txtHgsGenelAyarlarDaire.Value, (byte)txtHgsGenelAyarlarArac.Value, out InxNm) == 0)
                       {
                           AddLog("Araç silindi");
                       }
                       else { AddLog("Araç silinemedi."); }
                   }
               }
               else { AddLog("Cihazla bağlantı yok."); }


           }

        }

        private void btnDaireBul_Click(object sender, EventArgs e)
        {
            
            THGSArac Arac;
            int iErr, i, cnt, InxNm;
            String CardID;

            if (txtUygulamaTipi.Text != "HGS")
            {
                MessageBox.Show("Bu uygulama sadece çalışma modu HGS alanında çalışır.");
            }
            else
            {
                if (rdr.Connected == true)
                {
                    if (txtHgsGenelAyarlarDaire.Value >= 0 && txtHgsGenelAyarlarArac.Value >= 0)
                    {
                        iErr = rdr.GetHGSWhitelistWithDaireArac((ushort)txtHgsGenelAyarlarDaire.Value,(byte)txtHgsGenelAyarlarArac.Value, out Arac, out InxNm);

                        if (iErr == 0)
                        {
                            txtHgsGenelAyarlarKartId.Text = Arac.CardID;
                            txtHgsGenelAyarlarKartHGSAdi.Text = Arac.Name.Trim();
                            txtHgsGenelAyarlarPazartesi.Value = Arac.TimeAccessMask[0];
                            txtHgsGenelAyarlarSali.Value = Arac.TimeAccessMask[1];
                            txtHgsGenelAyarlarCarsamb.Value = Arac.TimeAccessMask[2];
                            txtHgsGenelAyarlarPersembe.Value = Arac.TimeAccessMask[3];
                            txtHgsGenelAyarlarCuma.Value = Arac.TimeAccessMask[4];
                            txtHgsGenelAyarlarCumartesi.Value = Arac.TimeAccessMask[5];
                            txtHgsGenelAyarlarPazar.Value = Arac.TimeAccessMask[6];
                            txtHgsGenelAyarlarDaireHak.Value = Arac.Daire;
                            txtHgsGenelAyarlarArac.Value = Arac.AracNo;
                            txtHgsGenelAyarlarKartinSonKullanmaTarihi.Value = Arac.EndDate;
                            
                            if (Arac.AccessDevice == true) {txtHgsGenelAyarlarKisiCihazdaAktifMi.Checked = true;} else {txtHgsGenelAyarlarKisiCihazdaAktifMi.Checked =false;}
                            if (Arac.APBEnabled == true ) {txtHgsGenelAyarlarAntiPassBackKontroluOlsunMu.Checked = true;} else {txtHgsGenelAyarlarAntiPassBackKontroluOlsunMu.Checked = false;}
                            if (Arac.ATCEnabled == true) {txtHgsGenelAyarlarKisitKontroluOlsunMu.Checked = true;} else {txtHgsGenelAyarlarKisitKontroluOlsunMu.Checked = false;}
                            lblHGSIndexNo.Text = Convert.ToString(InxNm);
                            AddLog("Araç getirildi.");
                        }
                        else {
                            AddLog("Araç bilgileri getirilemedi.");
                        }

                    }

                }
            }
        }

   




        private void btnSeriPortGetir_Click(object sender, EventArgs e)
        {

            byte s0, s1, SerailAppType;

            if (rdr.Connected == true)
            {
                if (rdr.GetSerialPortBaudrateSettings(out SerailAppType ,out s0, out s1))
                {
                    txtSeri0BaudRate.SelectedIndex = s0;
                    txtSeri1BaudRate.SelectedIndex = s1;

                    if (SerailAppType < 2)
                        cbSerialAppType.SelectedIndex = SerailAppType;    
                    else
                        cbSerialAppType.SelectedIndex = 0;    
                    

                    
                    //cbSerialAppType.SelectedIndex = SerailAppType;
                    AddLog("Ayarlar getirildi.");
                }
                else
                {
                    AddLog("Ayarlar getirilemedi");
                }




            }
            else {

                AddLog("Cihazla bağlantı yok");
            }

        }

        private void btnSeriPortGonder_Click(object sender, EventArgs e)
        {

            if (rdr.Connected == true)
            {
                if (rdr.SetSerialPortBaudrateSettings((byte)cbSerialAppType.SelectedIndex, (byte)txtSeri0BaudRate.SelectedIndex, (byte)txtSeri1BaudRate.SelectedIndex))
                {
                    AddLog("Bilgiler gönderildi");
                }
                else {

                    AddLog("Bilgiler gönderilemedi.");

                }
            }
            else
            {

                AddLog("Cihazla bağlantı yok");
            }

        }

        private void button12_Click(object sender, EventArgs e)
        {
            yemekOgunTablosu nf = new yemekOgunTablosu();
            nf.ShowDialog();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            yemekHakTablosu nf = new yemekHakTablosu();
            nf.ShowDialog();
        }

        private void btnHaftaninGunIsimleri_Click(object sender, EventArgs e)
        {
            frmHaftaninGunIsimleri newFrm = new frmHaftaninGunIsimleri();
            newFrm.ShowDialog();
            newFrm.Dispose();
        }

        private void btnYemekhaneAyarlariGetir_Click(object sender, EventArgs e)
        {
            TYmkSettings rSettings;
            rSettings = new TYmkSettings();

            if (rdr.Connected == true)
            {

                if (rdr.GetYmkSettings(out rSettings))
                {

                    txtYemekhaneUygulamaTipi.SelectedIndex = rSettings.AppType;
                    txtYemekhaneSeciliFiyatListesi.Value = rSettings.CurrPriceList;
                    txtYemekhaneKartSektor.Value = rSettings.YmkSectorNo;
                    txtYemekhaneIstasyon.Value = rSettings.YmkSectorNo;
                    txtYemekhaneYenidenKartOkumaSayi.Value = rSettings.ReReadCardCount;
                    txtYemekhaneYenidenOkumaFiyatListesi.Value = rSettings.ReReadPriceGroup;
                    txtYemekhaneYenidenOkumaZamanAralik.Value = rSettings.ReReadTimeOut;
                    AddLog("Yemek listedi getirildi.");
                }
                else {
                    AddLog("Yemek listesi getirilemedi");
                
                }

            }
            else {

                AddLog("Cihazla bağlantı yok");
            }

        }

        private void btnYemekhaneAyariGonder_Click(object sender, EventArgs e)
        {

            if (rdr.Connected == true)
            {
                TYmkSettings Settings = new TYmkSettings();

                  Settings.AppType =(byte)txtYemekhaneUygulamaTipi.SelectedIndex;
                  Settings.CurrPriceList = (byte)txtYemekhaneSeciliFiyatListesi.Value;
                  Settings.YmkSectorNo = (byte)txtYemekhaneKartSektor.Value;
                  Settings.PlantNo = (byte)txtYemekhaneIstasyon.Value;
                  Settings.ReReadCardCount = (byte)txtYemekhaneYenidenKartOkumaSayi.Value;
                  Settings.ReReadPriceGroup = (byte)txtYemekhaneYenidenOkumaFiyatListesi.Value;
                  Settings.ReReadTimeOut = (byte)txtYemekhaneYenidenOkumaZamanAralik.Value;


                  if (rdr.SetYmkSettings(Settings))
                  {
                      AddLog("Yemek listesi gönderildi.");
                  }
                  else {
                      AddLog("Yemek listesi gönderilemedi");
                  
                  }

            }
            else {
                AddLog("Cihazla bağlantı yok");
            
            }

        }

        
       

        private void btnUDPbaslat_Click(object sender, EventArgs e)
        {
            Thread tcpListener = new Thread(() => StartListener((int)txtUdpPortNumber.Value));
            
            if (tcpListener.ThreadState != ThreadState.Running)
            {
                tcpListener.Start();
            }


        }

        private void btnUdpTemizle_Click(object sender, EventArgs e)
        {
            udpLogText.Clear();
        }


        const string regExChar = "0123456789ABCDEF";

        bool invalidCharRegEx(string incomingString)
        {
            bool turner=false;
            string chr;
            for (int i = 0; i < incomingString.Length; i++)
            {
                chr = incomingString.Substring(i, 1);

                if (regExChar.IndexOf(chr) ==-1)
                {
                    turner = true;
                }
            }

            return turner;
        
        }


        void writeKeyList()
        {
            TMfrKeyListStr KeyList = new TMfrKeyListStr();

            if (rdr.Connected == true)
            {

                for (int i = 0; i < 16; i++)
                {

                    TextBox tbxA = groupBox23.Controls.Find("KeyA" + i.ToString(), false).FirstOrDefault() as TextBox;
                    TextBox tbxB = groupBox23.Controls.Find("KeyB" + i.ToString(), false).FirstOrDefault() as TextBox;
                    KeyList.Sector[i].KeyA = tbxA.Text;
                    KeyList.Sector[i].KeyB = tbxB.Text;

                }


                if (rdr.SetMfrKeyList(KeyList) == true)
                {
                    AddLog("Key listesi gönderildi.");
                }
                else {

                    AddLog("key listesi gönderilemedi.");
                
                }

            }
            else
            {

                AddLog("Cihazla bağlantınız yok.");
            }

        
        }

        private void button15_Click(object sender, EventArgs e)
        {

            foreach (Control item in groupBox23.Controls)
            {
                if (item is TextBox)
                {

                    if (invalidCharRegEx(item.Text))
                    {
                        MessageBox.Show("Focuslanan alanda geçersiz karakterler var.");
                        item.Focus();
                        break;
                    }
                    else {

                        writeKeyList();
                        break;
                    }

                }
            }

        }

        private void button16_Click(object sender, EventArgs e)
        {
            foreach (Control item in groupBox23.Controls)
            {

                if (item is TextBox)
                {
                    item.Text = "FFFFFFFFFFFF";
                }
                
            }



        }

        private void btnKontorFiyatListesi_Click(object sender, EventArgs e)
        {
            frmKontorFiyatListesi nf = new frmKontorFiyatListesi();
            nf.ShowDialog();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            appLog.Clear();
        }

        private void cbReaderType_SelectedIndexChanged(object sender, EventArgs e)
        {


            switch (cbReaderType.SelectedIndex)
            {

                case 2:
                    {
                        edtEkranMesajlariUstBaslikTipi.Enabled = true;
                        edtEkranMesajlariUstBaslik.Enabled = false;
                        ekranMesajiOnlieSatir1x.Enabled = false;
                        ekranMesajiOnlieSatir2x.Enabled = false;
                        ekranMesajiOnlieSatir3x.Enabled = false;
                        ekranMesajiOnlieSatir4x.Enabled = false;
                        ekranMesajiOnlieSatir5x.Enabled = false;
                        ekranMesajiOnlieSatir1y.Enabled = false;
                        ekranMesajiOnlieSatir2y.Enabled = false;
                        ekranMesajiOnlieSatir3y.Enabled = false;
                        ekranMesajiOnlieSatir4y.Enabled = false;
                        ekranMesajiOnlieSatir5y.Enabled = false;
                        ekranMesajiOnlieSatir3.Enabled = false;
                        ekranMesajiOnlieSatir4.Enabled = false;
                        ekranMesajiOnlieSatir5.Enabled = false;
                        edtEkranMesajlariAltBaslikTipi.Enabled = false;
                        edtEkranMesajlariAltBaslik.Enabled = false;
                        edtEkranMesajiSatirSayisi.Enabled = false;
                        edtEkranMesajlariFontTipi.Enabled = false;
                        edtEkranMesajlariRoleSuresi2.Enabled = false;
                        ekranMesajiOnlieSatir1.MaxLength = 16;
                        ekranMesajiOnlieSatir2.MaxLength = 16;
                        ekranMesajiOfflineSatir1.MaxLength = 16;
                        ekranMesajiOfflineSatir2.MaxLength = 16;

                        edtCihazMesajTipiOffline.Enabled = true;
                        edtCihazMesajUstBaslikTipiOffline.Enabled = false;
                        edtCihazMesajUstBaslikOffline.Enabled = false;
                        ekranMesajiOfflineSatir3.Enabled = false;
                        ekranMesajiOfflineSatir4.Enabled = false;
                        ekranMesajiOfflineSatir5.Enabled = false;
                        
                        ekranMesajiOfflineSatir1x.Enabled = false;
                        ekranMesajiOfflineSatir2x.Enabled = false;
                        ekranMesajiOfflineSatir3x.Enabled = false;
                        ekranMesajiOfflineSatir4x.Enabled = false;
                        ekranMesajiOfflineSatir5.Enabled = false;
                        
                        ekranMesajiOfflineSatir1z.Enabled = false;
                        ekranMesajiOfflineSatir2z.Enabled = false;
                        ekranMesajiOfflineSatir3z.Enabled = false;
                        ekranMesajiOfflineSatir4z.Enabled = false;
                        ekranMesajiOfflineSatir5z.Enabled = false;

                        ekranMesajiOfflinealtBaslikTipi.Enabled = false;
                        ekranMesajiOfflinealtBaslik.Enabled = false;
                        edtEkranMesajiSatirSayisiOffline.Enabled = false;
                        ekranMesajiOfflinealtBaslikFontTipi.Enabled = false;
                        ekranMesajiOfflineRoleSuresi2.Enabled = false;

                        break;
                    }
                default:

                        edtEkranMesajlariUstBaslikTipi.Enabled = true;
                        edtEkranMesajlariUstBaslik.Enabled = true;
                        ekranMesajiOnlieSatir1x.Enabled = true;
                        ekranMesajiOnlieSatir2x.Enabled = true;
                        ekranMesajiOnlieSatir3x.Enabled = true;
                        ekranMesajiOnlieSatir4x.Enabled = true;
                        ekranMesajiOnlieSatir5x.Enabled = true;
                        ekranMesajiOnlieSatir1y.Enabled = true;
                        ekranMesajiOnlieSatir2y.Enabled = true;
                        ekranMesajiOnlieSatir3y.Enabled = true;
                        ekranMesajiOnlieSatir4y.Enabled = true;
                        ekranMesajiOnlieSatir5y.Enabled = true;
                        ekranMesajiOnlieSatir3.Enabled = true;
                        ekranMesajiOnlieSatir4.Enabled = true;
                        ekranMesajiOnlieSatir5.Enabled = true;
                        edtEkranMesajlariAltBaslikTipi.Enabled = true;
                        edtEkranMesajlariAltBaslik.Enabled = true;
                        edtEkranMesajiSatirSayisi.Enabled = true;
                        edtEkranMesajlariFontTipi.Enabled = true;
                        edtEkranMesajlariRoleSuresi2.Enabled = true;
                        ekranMesajiOnlieSatir1.MaxLength = 20;
                        ekranMesajiOnlieSatir2.MaxLength = 20;

                        ekranMesajiOfflineSatir1.MaxLength = 20;
                        ekranMesajiOfflineSatir2.MaxLength = 20;

                        edtCihazMesajTipiOffline.Enabled = true;
                        edtCihazMesajUstBaslikTipiOffline.Enabled = true;
                        edtCihazMesajUstBaslikOffline.Enabled = true;
                        ekranMesajiOfflineSatir3.Enabled = true;
                        ekranMesajiOfflineSatir4.Enabled = true;
                        ekranMesajiOfflineSatir5.Enabled = true;

                        ekranMesajiOfflineSatir1x.Enabled = true;
                        ekranMesajiOfflineSatir2x.Enabled = true;
                        ekranMesajiOfflineSatir3x.Enabled = true;
                        ekranMesajiOfflineSatir4x.Enabled = true;
                        ekranMesajiOfflineSatir5x.Enabled = true;

                        ekranMesajiOfflineSatir1z.Enabled = true;
                        ekranMesajiOfflineSatir2z.Enabled = true;
                        ekranMesajiOfflineSatir3z.Enabled = true;
                        ekranMesajiOfflineSatir4z.Enabled = true;
                        ekranMesajiOfflineSatir5z.Enabled = true;

                        ekranMesajiOfflinealtBaslikTipi.Enabled = true;
                        ekranMesajiOfflinealtBaslik.Enabled = true;
                        edtEkranMesajiSatirSayisiOffline.Enabled = true;
                        ekranMesajiOfflinealtBaslikFontTipi.Enabled = true;
                        ekranMesajiOfflineRoleSuresi2.Enabled = true;

                        break;

            }

        }

        private void ekranMesajiOnlieSatir1_TextChanged(object sender, EventArgs e)
        {

            if (ekranMesajiOnlieSatir1.Text.Length >= 16)
            {
                ekranMesajiOnlieSatir1.Text = ekranMesajiOnlieSatir1.Text.Remove(16, 1);
                ekranMesajiOnlieSatir1.SelectionStart = ekranMesajiOnlieSatir1.Text.Length;
                ekranMesajiOnlieSatir1.SelectionLength = 0;
            } 

        }

        private void ekranMesajiOnlieSatir2_TextChanged(object sender, EventArgs e)
        {

            if (ekranMesajiOnlieSatir2.Text.Length >=16)
            {
                ekranMesajiOnlieSatir2.Text = ekranMesajiOnlieSatir2.Text.Remove(16, 1);
                ekranMesajiOnlieSatir2.SelectionStart = ekranMesajiOnlieSatir2.Text.Length;
                ekranMesajiOnlieSatir2.SelectionLength = 0;
            }

        }

        private void btnHaberlesmeAyariGonder_Click_1(object sender, EventArgs e)
        {

            TLcdScreen rSettings;
            rSettings = new TLcdScreen();
            Boolean onlineBlink = false;


            if (chkedtEkranMesajlariBlink.Checked == true) { onlineBlink = true; } else { onlineBlink = false; }

            if (rdr.Connected == true)
            {

                try
                {
                    if (rdr.ReaderType == TReaderType.rdr26M)
                    {
                        if (rdr.SetBeepRelayAndSecreenMessage(
                            ekranMesajiOnlieSatir1.Text,
                            ekranMesajiOnlieSatir2.Text,
                            (ushort)edtEkranMesajlariEkranSure.Value,
                            (ushort)edtEkranMesajlariRoleSuresi1.Value,
                            (ushort)edtEkranMesajlariBuzzerSuresi.Value,
                            onlineBlink))
                        {
                            AddLog("Bilgiler cihaza gönderildi.");

                        }
                    }
                    else
                    {


                        if (rdr.SetBeepRelayAndSecreenMessage(
                            edtEkranMesajlariUstBaslikTipi.SelectedIndex,
                            edtEkranMesajlariAltBaslikTipi.SelectedIndex,
                            edtEkranMesajlariUstBaslik.Text,
                            ekranMesajiOnlieSatir1.Text,
                            ekranMesajiOnlieSatir2.Text,
                            ekranMesajiOnlieSatir3.Text,
                            ekranMesajiOnlieSatir4.Text,
                            ekranMesajiOnlieSatir5.Text,
                            edtEkranMesajlariAltBaslik.Text,
                            (byte)ekranMesajiOnlieSatir1x.Value,
                            (byte)ekranMesajiOnlieSatir1y.Value,
                            0,
                            (byte)ekranMesajiOnlieSatir2x.Value,
                            (byte)ekranMesajiOnlieSatir2y.Value,
                            0,
                            (byte)ekranMesajiOnlieSatir3x.Value,
                            (byte)ekranMesajiOnlieSatir3y.Value,
                            0,
                            (byte)ekranMesajiOnlieSatir4x.Value,
                            (byte)ekranMesajiOnlieSatir4y.Value,
                            0,
                            (byte)ekranMesajiOnlieSatir5x.Value,
                            (byte)ekranMesajiOnlieSatir5y.Value,
                            0,
                            (byte)edtEkranMesajiSatirSayisi.Value,
                            (byte)edtEkranMesajlariFontTipi.SelectedIndex,
                            (ushort)edtEkranMesajlariEkranSure.Value,
                            (ushort)edtEkranMesajlariRoleSuresi1.Value,
                            (ushort)edtEkranMesajlariRoleSuresi2.Value,
                            (ushort)edtEkranMesajlariBuzzerSuresi.Value,
                            onlineBlink
                            ) == true)
                        {
                            AddLog("Bilgiler cihaza gönderildi.");
                        }


                    }





                }
                catch (Exception)
                {

                    AddLog("Bilgiler gönderilemedi.");
                }

            }
            else
            {

                AddLog("Cihazla bağlantı yok");
            }

        }

        private void edtCihazMesajTipiOffline_SelectedIndexChanged(object sender, EventArgs e)
        {
            TLcdScreen LcdScreenMsg;
            LcdScreenMsg = new TLcdScreen();
            int ID;

            ID = OffflineMsg[edtCihazMesajTipiOffline.SelectedIndex].MsgID;

            if (rdr.Connected == true)
            {

                if (rdr.GetLCDMessages(ID, out LcdScreenMsg) == true)
                {
                    //edtCihazMesajUstBaslikTipiOffline.SelectedIndex = LcdScreenMsg.HeaderType;
                    edtCihazMesajUstBaslikOffline.Text = LcdScreenMsg.Caption;
                    ekranMesajiOfflineSatir1.Text = LcdScreenMsg.Line[0].Text;
                    ekranMesajiOfflineSatir2.Text = LcdScreenMsg.Line[1].Text;
                    ekranMesajiOfflineSatir3.Text = LcdScreenMsg.Line[2].Text;
                    ekranMesajiOfflineSatir4.Text = LcdScreenMsg.Line[3].Text;
                    ekranMesajiOfflineSatir5.Text = LcdScreenMsg.Line[4].Text;

                    ekranMesajiOfflineSatir1x.Value = LcdScreenMsg.Line[0].X;
                    ekranMesajiOfflineSatir2x.Value = LcdScreenMsg.Line[1].X;
                    ekranMesajiOfflineSatir3x.Value = LcdScreenMsg.Line[2].X;
                    ekranMesajiOfflineSatir4x.Value = LcdScreenMsg.Line[3].X;
                    ekranMesajiOfflineSatir5x.Value = LcdScreenMsg.Line[4].X;


                    ekranMesajiOfflineSatir1z.Value = LcdScreenMsg.Line[0].Y;
                    ekranMesajiOfflineSatir2z.Value = LcdScreenMsg.Line[1].Y;
                    ekranMesajiOfflineSatir3z.Value = LcdScreenMsg.Line[2].Y;
                    ekranMesajiOfflineSatir4z.Value = LcdScreenMsg.Line[3].Y;
                    ekranMesajiOfflineSatir5z.Value = LcdScreenMsg.Line[4].Y;

                    ekranMesajiOfflinealtBaslikTipi.SelectedIndex = LcdScreenMsg.FooterType;
                    ekranMesajiOfflinealtBaslik.Text = LcdScreenMsg.Footer;
                    edtEkranMesajiSatirSayisiOffline.Value = LcdScreenMsg.LineCount;
                    ekranMesajiOfflinealtBaslikFontTipi.SelectedIndex = LcdScreenMsg.FontType;
                    ekranMesajiOfflineEkranSuresi.Value = LcdScreenMsg.ScreenDuration;
                    ekranMesajiOfflineRoleSuresi1.Value = LcdScreenMsg.RL_Time1;
                    ekranMesajiOfflineRoleSuresi2.Value = LcdScreenMsg.RL_Time2;
                    ekranMesajiOfflineBuzzerSuresi.Value = LcdScreenMsg.BZR_time;

                    if (LcdScreenMsg.IsBlink == true)
                    { chkekranMesajiOfflineBlink.Checked = true; }
                    else
                    { chkekranMesajiOfflineBlink.Checked = false; }


                    edtCihazMesajUstBaslikTipiOffline.SelectedIndexChanged += new EventHandler(edtCihazMesajTipiOffline_SelectedIndexChanged);
                    edtCihazMesajUstBaslikTipiOffline.SelectedIndexChanged += new EventHandler(edtCihazMesajUstBaslikTipiOffline_SelectedIndexChanged);
                    edtEkranMesajiSatirSayisiOffline.ValueChanged += new EventHandler(edtEkranMesajiSatirSayisiOffline_ValueChanged);



                    AddLog("Mesaj kayıtları getirildi.");
                }

            }
            else
            {
                AddLog("Cihazla bağlantı sağlanamadı.");
            }



            //MessageBox.Show(Convert.ToString(OffflineMsg[edtCihazMesajTipiOffline.SelectedIndex].MsgID));
            //MessageBox.Show(Convert.ToString(ID));
        }

        private void edtCihazMesajUstBaslikTipiOffline_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (edtCihazMesajUstBaslikTipiOffline.SelectedIndex)
            {

                case 0:
                    edtCihazMesajUstBaslikOffline.Clear();
                    edtCihazMesajUstBaslikOffline.Enabled = false;
                    break;
                case 1:
                    edtCihazMesajUstBaslikOffline.Clear();
                    edtCihazMesajUstBaslikOffline.Enabled = false;
                    break;
                case 2:
                    edtCihazMesajUstBaslikOffline.Enabled = false;
                    break;

                default:
                    break;
            }
        }

        private void ekranMesajiOfflinealtBaslikTipi_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ekranMesajiOfflinealtBaslikTipi.SelectedIndex)
            {

                case 0:
                    ekranMesajiOfflinealtBaslik.Clear();
                    ekranMesajiOfflinealtBaslik.Enabled = false;
                    break;

                case 1:
                    ekranMesajiOfflinealtBaslik.Enabled = true;
                    break;


                default:
                    break;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TLcdScreen LcdScreenMsg;
            LcdScreenMsg = new TLcdScreen();

            Boolean IsBlink;

            if (rdr.Connected == true)
            {

                if (chkekranMesajiOfflineBlink.Checked == true) { IsBlink = true; } else { IsBlink = false; }

                LcdScreenMsg.ID = (ushort)OffflineMsg[edtCihazMesajTipiOffline.SelectedIndex].MsgID;
                LcdScreenMsg.HeaderType = (byte)edtCihazMesajUstBaslikTipiOffline.SelectedIndex;
                LcdScreenMsg.Caption = (string)edtCihazMesajUstBaslikOffline.Text;

                LcdScreenMsg.Line[0].Text = ekranMesajiOfflineSatir1.Text;
                LcdScreenMsg.Line[1].Text = ekranMesajiOfflineSatir2.Text;
                LcdScreenMsg.Line[2].Text = ekranMesajiOfflineSatir3.Text;
                LcdScreenMsg.Line[3].Text = ekranMesajiOfflineSatir4.Text;
                LcdScreenMsg.Line[4].Text = ekranMesajiOfflineSatir5.Text;

                
                LcdScreenMsg.Line[1].X = (byte)ekranMesajiOfflineSatir2x.Value;
                LcdScreenMsg.Line[2].X = (byte)ekranMesajiOfflineSatir3x.Value;
                LcdScreenMsg.Line[3].X = (byte)ekranMesajiOfflineSatir4x.Value;
                LcdScreenMsg.Line[4].X = (byte)ekranMesajiOfflineSatir5x.Value;

                LcdScreenMsg.Line[0].Y = (byte)ekranMesajiOfflineSatir1z.Value;
                LcdScreenMsg.Line[1].Y = (byte)ekranMesajiOfflineSatir2z.Value;
                LcdScreenMsg.Line[2].Y = (byte)ekranMesajiOfflineSatir3z.Value;
                LcdScreenMsg.Line[3].Y = (byte)ekranMesajiOfflineSatir4z.Value;
                LcdScreenMsg.Line[4].Y = (byte)ekranMesajiOfflineSatir5z.Value;

                LcdScreenMsg.FooterType = (byte)ekranMesajiOfflinealtBaslikTipi.SelectedIndex;
                LcdScreenMsg.Footer = ekranMesajiOfflinealtBaslik.Text;
                LcdScreenMsg.LineCount = (byte)edtEkranMesajiSatirSayisiOffline.Value;
                LcdScreenMsg.FontType = (byte)ekranMesajiOfflinealtBaslikFontTipi.SelectedIndex;
                LcdScreenMsg.ScreenDuration = (ushort)ekranMesajiOfflineEkranSuresi.Value;
                LcdScreenMsg.RL_Time1 = (ushort)ekranMesajiOfflineRoleSuresi1.Value;
                LcdScreenMsg.RL_Time2 = (ushort)ekranMesajiOfflineRoleSuresi2.Value;
                LcdScreenMsg.BZR_time = (ushort)ekranMesajiOfflineBuzzerSuresi.Value;
                LcdScreenMsg.IsBlink = IsBlink;

                if (rdr.SetLCDMessages(LcdScreenMsg) == true)
                { AddLog("Bilgiler başarıyla gönderildi."); }
                else { AddLog("Bilgiler gönderilemedi"); }


            }
            else
            {

                AddLog("Cihazla bağlantı yok.");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (rdr.Connected == true)
            {
                if (rdr.SetLCDMessagesFactoryDefault() == true)
                {
                    AddLog("Cihaz sıfırlandı.");
                }
            }
            else
            {

                AddLog("Cihazla bağlantı yok.");
            }



            //rdr.SetLCDMessagesFactoryDefault
        }

        private void btnInputBoxMesajGonder_Click(object sender, EventArgs e)
        {
            if (rdr.Connected == true)
            {

                if (rdr.ReaderType == TReaderType.rdr26M )
                {
                    MessageBox.Show("63M için geçerlidir.");
                }
                else
                {

                    Boolean isBlink = false;

                    if (txtInputBoxMesajGonderIsBlink.Checked == true)
	                {
		                isBlink = true;
	                }

                    if (rdr.SetBeepRelayAndInboxMessage(txtInputBoxMesajGonderUstBaslikTipi.SelectedIndex, txtInputBoxMesajGonderBaslik.Text, txtInputBoxMesajGonderBirinciSatir.Text, txtInputBoxMesajGonderIkinciSatir.Text, (byte)txtInputBoxMesajGonderBirinciSatirx.Value, (byte)txtInputBoxMesajGonderBirinciSatirZ.Value, 0, (byte)txtInputBoxMesajGonderIkinciSatirX.Value, (byte)txtInputBoxMesajGonderIkinciSatirZ.Value, 0, (byte)txtInputBoxMesajGonderEkranSure.Value, (byte)txtInputBoxMesajGonderRoleSure1.Value, (byte)txtInputBoxMesajGonderRoleSure2.Value, (byte)txtInputBoxMesajGonderBuzzerSure1.Value, isBlink, (byte)txtInputBoxMesajGonderKlavyeTipi.Value))
                    {
                       AddLog("Bilgiler gönderildi.");   
                    } else 
                    {
                       AddLog("Bilgiler gönderilemedi.");
                    }


                }

            }
            else
            {

                MessageBox.Show("Cihazla bağlantınız yok.");

            }

        }

        private void btnSeriPortTest_Click(object sender, EventArgs e)
        {

        }

        private void edtEkranMesajlariAltBaslikTipi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (edtEkranMesajlariAltBaslikTipi.SelectedIndex == 0)
            {
                edtEkranMesajlariAltBaslik.Clear();
            }
        }

        private void button39_Click(object sender, EventArgs e)
        {

        }

        private void tbpHgsGenelAyarlar_Click(object sender, EventArgs e)
        {

        }

        private string randomString()
        {
            //C4E3B82E000000
            string result ="";
            Random rnd = new Random();
            result = rnd.Next(100000, 999999).ToString();
            System.Threading.Thread.Sleep(1000);
            result = "C4E3B82E" + result; 
            return result;
        }

        Thread thr;

        void aktarThe()
        {
            thr = new Thread(new ThreadStart(aktar));
            thr.Start();
        }

        void aktar()
        {
            for (int i = 0; i < (int)numericUpDown1.Value; i++)
            {
                edtCardID.Text = randomString();
                btnAddWhiteList.PerformClick();
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            aktarThe();
        }

        private void btnTopluAktarim_Click(object sender, EventArgs e)
        {
            frmTopluAktarim topluAktarim = new frmTopluAktarim();
            topluAktarim.ShowDialog();
        }

        private void button34_Click(object sender, EventArgs e)
        {

            byte[] DataValue = new byte[16];
            String str;

            byte sektorNo, blockNo;

            sektorNo = Convert.ToByte(numericUpDown1.Value);
            blockNo = Convert.ToByte(numericUpDown2.Value);

            if (rdr.ReadCardBlockData(sektorNo, blockNo, TKeyType.ktKeyA, out DataValue))
            {
                str = "";

                for (int i = 0; i < 16; i++)
                {
                    if (str == "")
                    {
                        str = Convert.ToString(DataValue[i]);
                    }
                    else
                    {
                        str += Convert.ToInt32(DataValue[i]);
                    }
                }

                textBox1.Text = str;
                lblMesaj.Text = "Okundu";
            }
            else
                lblMesaj.Text = "Okunamadı";
        }

        private void button32_Click(object sender, EventArgs e)
        {
            byte[] DataValue = new byte[16];

            byte sektorNo, blockNo;

            sektorNo = Convert.ToByte(numericUpDown1.Value);
            blockNo = Convert.ToByte(numericUpDown2.Value);

            for (int i = 0; i < 16; i++)
            {
                DataValue[i] = (byte)(Convert.ToInt32(textBox1.Text.Substring(i, 1)));
            }

            //for (int i = 0; i < 16; i++)
            //    DataValue[i] = (byte)(i + 2);

            if (rdr.WriteCardBlockData(sektorNo, blockNo, TKeyType.ktKeyA, DataValue)) //DataValue içeriği karta yazılması istenen bilgi.
                lblMesaj.Text = "Yazma başarılı";
            else
                lblMesaj.Text = "Yazma başarısız";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnBlackListPersonelEkle_Click(object sender, EventArgs e)
        {

            if (rdr.Connected)
            {
                int iErr;
                uint InxNm;
                string CardID;

                lblIndexNo.Text = "-1";
                CardID = edtCardID.Text;
                if (rdr.IsHex(CardID) && (CardID.Length == 14))
                {
                    TBlackList Person = new TBlackList();
                    int NameLen = edtName.Text.Length;
                    if (NameLen > 18)
                        NameLen = 18;

                    Person.CardID = CardID;
                    Person.Caption = edtBlackListAd.Text;
                    Person.BlackListCmdNo = (byte)nmrBlackListNo.Value;
                    

                    iErr = rdr.AddBlackList(Person, out InxNm);

                    switch (iErr)
                    {
                        case 0:
                            AddLog("Kişi eklendi.");
                            lblIndexNo.Text = InxNm.ToString();
                            break;
                        case 1:
                            AddLog("Daha önce eklenmiş.");
                            break;
                        case 20:
                            AddLog("Şifre kapasitesi aşıldı.");
                            break;
                        case 51:
                            AddLog("Bu Kart ID daha önce tanımlanmış.");
                            break;
                        case 52:
                            AddLog("Bu şifre daha önce tanımlanmış.");
                            break;
                        default:
                            AddLog("Hata iErr : " + iErr.ToString());
                            break;
                    }
                }
                else
                    AddLog("Uygun Kart ID girilmemiş.");
            }
            else
                AddLog("Cihaz Bağlantısı Yok.");

        }

        private void BtnBlackListPersonelDegistir_Click(object sender, EventArgs e)
        {

            if (rdr.Connected)
            {
                int iErr;
                uint InxNm;
                string CardID;

                lblIndexNo.Text = "-1";
                CardID = edtCardID.Text;
                if (rdr.IsHex(CardID) && (CardID.Length == 14))
                {
                    TBlackList Person = new TBlackList();
                    int NameLen = edtName.Text.Length;
                    if (NameLen > 18)
                        NameLen = 18;

                    Person.CardID = CardID;
                    Person.Caption = edtBlackListAd.Text;
                    Person.BlackListCmdNo = (byte)nmrBlackListNo.Value;


                    iErr = rdr.EditBlacklistWithCardID(Person, out InxNm);

                    switch (iErr)
                    {
                        case 0:
                            AddLog("Kişi Güncellendi.");
                            lblIndexNo.Text = InxNm.ToString();
                            break;
                        case 1:
                            AddLog("Daha önce eklenmiş.");
                            break;
                        case 20:
                            AddLog("Şifre kapasitesi aşıldı.");
                            break;
                        case 51:
                            AddLog("Bu Kart ID daha önce tanımlanmış.");
                            break;
                        case 52:
                            AddLog("Bu şifre daha önce tanımlanmış.");
                            break;
                        default:
                            AddLog("Hata iErr : " + iErr.ToString());
                            break;
                    }
                }
                else
                    AddLog("Uygun Kart ID girilmemiş.");
            }
            else
                AddLog("Cihaz Bağlantısı Yok.");


        }

        private void BtnBlackListPersonelSil_Click(object sender, EventArgs e)
        {


            if (rdr.Connected)
            {
                int iErr;
                uint InxNm;
                string CardID;

                CardID = edtCardID.Text;
                if (rdr.IsHex(CardID) && (CardID.Length == 14))
                {
                    int NameLen = edtName.Text.Length;
                    if (NameLen > 18)
                        NameLen = 18;

                    iErr = rdr.DeleteBlacklistWithCardID(CardID, out InxNm);
                    if (iErr == 0)
                        AddLog("kişi silindi.");
                    else
                        AddLog("Kişi silinemedi");
                }
                else
                    AddLog("Uygun Kart ID girilmemiş.");
            }
            else
                AddLog("Cihaz Bağlantısı Yok.");

        }

        private void BtnBlackListPersonelBul_Click(object sender, EventArgs e)
        {

            if (rdr.Connected)
            {
                TBlackList person = new TBlackList();
                int iErr;
                uint InxNm;
                string CardID;

                CardID = edtBlackListKartId.Text;
                if (rdr.IsHex(CardID) && (CardID.Length == 14))
                {
                    iErr = rdr.GetBlacklistWithCardID(CardID, out person, out InxNm);
                    if (iErr == 0)
                    {
                        edtBlackListAd.Text = person.Caption;
                        edtBlackListKartId.Text = person.CardID;
                        nmrBlackListNo.Value = person.BlackListCmdNo;
                    }
                    else
                        AddLog("Personel bulunamadı.");
                }

                else
                    AddLog("Uygun Kart ID girilmemiş.");
            }
            else
                AddLog("Cihaz Bağlantısı Yok.");
        }

        private void btnTanimliBlackListKullanicilariSil_Click(object sender, EventArgs e)
        {

            if (rdr.Connected)
            {
                if (rdr.ClearWhitelist())
                {
                    rdr.DisConnect();
                    Thread.Sleep(100);
                    rdr.Connect();
                }
            }
            else
                AddLog("Cihaz ile bağlanyı yok.");
        }

        private void BtnBlackListPersonelSayisi_Click(object sender, EventArgs e)
        {
            btnCardIDCnt.PerformClick();
        }

        private void btnNodeGonder_Click(object sender, EventArgs e)
        {
            if (rdr.Connected)
            {
                Ttree_Node node = new Ttree_Node();

                node.Adress = (uint)nmrAdres.Value;
                rdr.ToPrBytesFromHex(txtValue.Text , ref node.Value);
                node.Left = (uint)nmrColor.Left;
                node.Color = (byte)nmrColor.Value;
                node.Right = (uint)nmrRight.Value;
                node.Parent = (uint)nmrParent.Value;

                if (rdr.SetTreeNode(node))
                    AddLog("Başarılı");
                else
                    AddLog("Başarısız");

            }
            else
                AddLog("Cihaz ile bağlanyı yok.");

        }

        private void btnNodeGetir_Click(object sender, EventArgs e)
        {
            if (rdr.Connected)
            {
                Ttree_Node node = new Ttree_Node();

                if (rdr.GetTreeNode((uint)nmrAdres.Value, out node))
                {
                    nmrAdres.Value = (decimal)node.Adress;
                    txtValue.Text = rdr.prBytesToHex(node.Value, 0, 7);
                    nmrColor.Left = (int)node.Left;
                    nmrColor.Value = (int)node.Color;
                    nmrRight.Value = (int)node.Right;
                    nmrParent.Value = (int)node.Parent;
                    AddLog("Başarılı");
                }
                else
                    AddLog("Başarısız");

            }
            else
                AddLog("Cihaz ile bağlanyı yok.");
        }

        private void button35_Click(object sender, EventArgs e)
        {
            frmPersonCommand fpc = new frmPersonCommand();
            fpc.ShowDialog();
        }

        private void button36_Click(object sender, EventArgs e)
        {
            frmPersonCommand fpc = new frmPersonCommand();
            fpc.ShowDialog();
        }

        private void button40_Click(object sender, EventArgs e)
        {
            //yazılacak
        }

        private void button41_Click(object sender, EventArgs e)
        {
            //yazılacak
        }

        private void button44_Click(object sender, EventArgs e)
        {
            //yazılacak
        }

        private void button45_Click(object sender, EventArgs e)
        {
            //yazılacak
        }

        private void cbPersTZMode_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (cbPersTZMode.SelectedIndex)
            {
                case 0:
                    {
                        lblInputDuration.Visible = false;
                        edtUygulamaayarlariGecisSuresi.Visible = false;
                        break;
                    }

                case 1:
                    {
                        lblInputDuration.Text = "Buton Basma Süresi";
                        lblInputDuration.Visible = true;
                        edtUygulamaayarlariGecisSuresi.Visible = true;
                        break;
                    }

                case 2:
                    {
                        lblInputDuration.Text = "Turnike dönüş bekleme Süresi";
                        lblInputDuration.Visible = true;
                        edtUygulamaayarlariGecisSuresi.Visible = true;
                        break;
                    }

                case 3:
                    {
                        lblInputDuration.Text = "Kapı açık kalma bekleme Süresi";
                        lblInputDuration.Visible = true;
                        edtUygulamaayarlariGecisSuresi.Visible = true;
                        break;
                    }

                default:
                    break;
            }

        }

        private void btnPersTZMode_Click(object sender, EventArgs e)
        {

            frmPersonTZlist personTzList = new frmPersonTZlist(rdr);
            personTzList.ShowDialog();

        }

        private void btnSendStatusMode_Click(object sender, EventArgs e)
        {
            Byte StatusMode, StatusModeType ;

            if (rdr.fwAppType != TfwAppType.fwPDKS )
                MessageBox.Show("Sadece PDKS FW ile çalışır");
            else
            {
                if (rdr.Connected)
                {
                    StatusMode = (byte)edtStatusMode.Value;
                    StatusModeType = (byte)edtStatusModeType.Value;

                    if (rdr.SetStatusMode(StatusMode, StatusModeType))
                        AddLog("bilgiler gönderildi");
                    else
                        AddLog("Bilgiler gönderilemedi");


                }
                else
                    AddLog("Cihazla bağlantınız yok");
            }

        }

        private void btnGetStatusMode_Click(object sender, EventArgs e)
        {
            Byte StatusMode, StatusModeType;

            if (rdr.fwAppType != TfwAppType.fwPDKS)
                MessageBox.Show("Sadece PDKS FW ile çalışır");
            else
            {
                if (rdr.Connected)
                {
                    if (rdr.GetStatusMode(out StatusMode, out StatusModeType))
                    {
                        edtStatusMode.Value = StatusMode;
                        edtStatusModeType.Value = StatusModeType;
                        AddLog("Bilgiler getirildi");
                    }
                    else
                        AddLog("Bilgiler getirilemedi");
                }
                else
                    AddLog("Cihazla bağlantınız yok");
            }
        }
    }
}

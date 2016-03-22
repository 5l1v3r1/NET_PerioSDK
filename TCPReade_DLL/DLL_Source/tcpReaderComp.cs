using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PerioTCPRdr;
using PerioTcpRdrBase;

namespace tcpReaderComponent
{
    public partial class tcpReaderComp: UserControl
    {
        public bool IsConnected { get { return fIsConnected; }  }
        public bool AutoConnect { get { return fAutoConnect; } set { fAutoConnect = value; } }
        public bool AutoRxEnabled { get { return fAutoRxEnabled; } set { fAutoRxEnabled = value; } }
        public int CommandRetry { get { return fCommandRetry; } set { fCommandRetry = value; } }
        public TDFType DataFlashType { get { return fdataFlashType; } set { fdataFlashType = value; } }
        public string DeviceLoginKey { get { return fDeviceLoginKey; } set { fDeviceLoginKey = value; } }
        public TfwAppType FirmWareType { get { return fFirmWareType; } set { fFirmWareType = value; } }
        public int OnlineReConnectTimeOut { get { return fOnlineReConnectTimeOut; } set { fOnlineReConnectTimeOut = value; } }
        public int Port { get { return fPort; } set { fPort = value; } }
        public TReaderType ReaderType { get { return fReaderType; } set { fReaderType = value; } }
        public TProtocolType ProtocolType { get { return fProtocolType; } set { fProtocolType = value; } }
        public string ReaderIp { get { return fReaderIp; } set { fReaderIp = value; } }
        public ListBox LogObject { get { return fLogObject; } set { fLogObject = value; } }


        private bool fIsConnected;
        private bool fAutoConnect;
        private bool fAutoRxEnabled;
        private int fCommandRetry;
        private TDFType fdataFlashType;
        private string fDeviceLoginKey;
        private TfwAppType fFirmWareType;
        private int fOnlineReConnectTimeOut;
        private int fPort;
        private TReaderType fReaderType;
        private TProtocolType fProtocolType;
        private string fReaderIp;
        private ListBox fLogObject;
        //private bool fAfterConnect;

        private static PerioTCPRdrComp tReader;

        private Boolean ReadDataBlock;
        public tcpReaderComp()
        {
            InitializeComponent();
            tReader = new PerioTCPRdrComp();
            tReader.OnRxCardID += new RxCardID(rdrOnRxCardID);
            tReader.OnRxTurnstileTurn += new RxTurnstileTurn(rdrOnTurnstileTurn);
            tReader.OnRxSerialReadStr += new RxSerialReadStr(rdrOnRxSerialStr);
            tReader.OnRxDoorOpenAlarm += new RxDoorOpenAlarm(rdrOnRxDoorOpenAlarm);
            tReader.OnRxTagRead += new RxTagRead(rdrOnTagRead);
            tReader.OnPasswordRead += new RxPasswordRead(rdrOnPasswordRead);
            tReader.OnRxInputText += new RxInputText(rdrOnInputText);
            tReader.OnConnected += new DeviceConnected(rdrOnConnected);
            tReader.OnDisConnected += new DeviceDisConnected(rdrOnDisConnected);
            fIsConnected = true;
        }

        //public delegate void RxAfterConnect(object source, RxAfterConnectArgs e);
        //public class RxAfterConnectArgs : EventArgs
        //{
        //    private bool fConnected;
        //    public RxAfterConnectArgs()
        //    {
        //        fConnected = tReader.Connected;
        //    }
        //    public bool connected
        //    {
        //        get
        //        {
        //            return fConnected;
        //        }
        //    }
        //}

        void rdrOnDisConnected(object source)
        {
            MethodInvoker method = delegate
            {
                AddLog("Bağlantı Kesildi ");
                fIsConnected = false;
            };

            if (InvokeRequired)
                BeginInvoke(method);
            else method.Invoke();
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
        public void rdrOnTurnstileTurn(object source, RxTurnstileTurnArgs e)
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
        public void rdrOnRxSerialStr(object source, RxSerialReadStrArgs e)
        {
            MethodInvoker method = delegate
            {
                AddLog("Okunulan Data [" + e.Data + " - SerialPortNo : " + Convert.ToString(e.SerialPortNo) + "].");
            };
            if (InvokeRequired)
                BeginInvoke(method);
            else
                method.Invoke();
        }
        public void rdrOnInputText(object source, RxInputTextArgs e)
        {
            MethodInvoker method = delegate
            {
                if (e.ConfirmationType == TInputConfirmationType.ctOk)
                {
                    AddLog("Onay Tipi : [OK] - InputText [" + e.InputText + "]");
                    //tReader.SetBeepRelayAndSecreenMessage(0, 0, "", "İşlem ", "Tamam", "", "", "", "", 5, 15, 0, 5, 35, 0, (byte)ekranMesajiOnlieSatir3x.Value, (byte)ekranMesajiOnlieSatir3y.Value, 0, (byte)ekranMesajiOnlieSatir4x.Value, (byte)ekranMesajiOnlieSatir4y.Value, 0, (byte)ekranMesajiOnlieSatir5x.Value, (byte)ekranMesajiOnlieSatir5y.Value, 0, 2, 2, 5, 5, 0, 10, false);
                }
                else
                    AddLog("Onay Tipi : [CANCEL] - InputText [" + e.InputText + "]");
            };

            if (InvokeRequired)
                BeginInvoke(method);
            else method.Invoke();
        }

        public void rdrOnPasswordRead(object source, RxPasswordReadArgs e)
        {
            MethodInvoker method = delegate
            {
                AddLog("Girilen şifre tipi : [" + Convert.ToString(e.PassType) + "] şifre : [" + Convert.ToString(e.Password) + "] personel kodu: [" + Convert.ToString(e.Code) + "]");
                //tReader.SetBeepRelayAndSecreenMessage(0, 0, "", "Online Şifre", "Şifre", "", "", "", "", 5, 15, 0, 5, 35, 0, (byte)ekranMesajiOnlieSatir3x.Value, (byte)ekranMesajiOnlieSatir3y.Value, 0, (byte)ekranMesajiOnlieSatir4x.Value, (byte)ekranMesajiOnlieSatir4y.Value, 0, (byte)ekranMesajiOnlieSatir5x.Value, (byte)ekranMesajiOnlieSatir5x.Value, 0, 2, 2, 5, 5, 0, 10, false);
            };

            if (InvokeRequired)
                BeginInvoke(method);
            else  method.Invoke(); 

        }
        public void rdrOnRxDoorOpenAlarm(object source, RxDoorOpenAlarmArgs e)
        {
            MethodInvoker method = delegate
            {
                if (e.DoorOpen)
                    AddLog("Kapı Açık Kaldı. ");
                else
                    AddLog("Kapı kapandı. Açık kalan süre [" + Convert.ToString(e.OpenTime) + "].");
            };

            if (InvokeRequired)
                BeginInvoke(method);
            else method.Invoke();


        }

        public bool ReadCardBlockData(byte sector, byte block, TKeyType keyType, out string readValue)
        {
            bool result = false;
            readValue = "";
            byte[] DataValue = new byte[16];
            String str;
            if (tReader.ReadCardBlockData(sector, block, TKeyType.ktKeyA, out DataValue))
            {
                str = "";

                for (int i = 0; i < 16; i++)
                {
                    if (str == "")
                        str = Convert.ToString(DataValue[i]);
                    else
                        str += "-" + Convert.ToInt32(DataValue[i]);
                }

                AddLog("Okunulan değer [" + str + "]");
                readValue = str;
            }

            return result;
        }

        public bool WriteCardBlockData(byte sector, byte block, TKeyType keyType, byte[] DataValue )
        {
            bool result = false;
            if (tReader.WriteCardBlockData(sector, block, TKeyType.ktKeyA, DataValue))
            {
                AddLog("Data yazıldı.");
            }

            return result;

        }

        public void rdrOnRxCardID(object source, RxCardIDArgs e)
        {

            PerioTCPRdrComp s = source as PerioTCPRdrComp;
            AddLog("Kart kondu");
            MethodInvoker method = delegate
            {
                AddLog("Okunulan Kart ID [" + e.CardID + "]." + " IP: " + s.IP + " device Id: " + s.DeviceID + " device name: " + s.DeviceName);
                /*
                if (e.CardID == "1967327B000000")
                 tReader.SetBeepRelayAndSecreenMessage(0, 0, "gecerli kart", "gecerli kart", "tunc gulec", "", "", "", "", 5, 15, 0, 5, 35, 0, (byte)ekranMesajiOnlieSatir3x.Value, (byte)ekranMesajiOnlieSatir3y.Value, 0, (byte)ekranMesajiOnlieSatir4x.Value, (byte)ekranMesajiOnlieSatir4y.Value, 0, (byte)ekranMesajiOnlieSatir5x.Value, (byte)ekranMesajiOnlieSatir5x.Value, 0, 2, 2, 20, 2000, 2000, 2000, true);
                else
                 tReader.SetBeepRelayAndSecreenMessage(0, 0, "gecersiz kart", "gecersiz kart", e.CardID.ToString(), "", "", "", "", 5, 15, 0, 5, 35, 0, (byte)ekranMesajiOnlieSatir3x.Value, (byte)ekranMesajiOnlieSatir3y.Value, 0, (byte)ekranMesajiOnlieSatir4x.Value, (byte)ekranMesajiOnlieSatir4y.Value, 0, (byte)ekranMesajiOnlieSatir5x.Value, (byte)ekranMesajiOnlieSatir5x.Value, 0, 2, 2, 20, 0, 0, 2000, false);
                 */
            };

            if (InvokeRequired)
                BeginInvoke(method);
            else
                method.Invoke();
        }

        public void rdrOnTagRead(object source, RxTagReadArgs e)
        {
            MethodInvoker method = delegate
            {
                AddLog("Okunulan Tag ID [" + e.TagId + " - IO : " + Convert.ToString(e.IO) + "].");
                //tReader.SetBeepRelayAndSecreenMessage(0, 0, "", e.TagId.ToString(), e.TagId.ToString(), "", "", "", "", 5, 15, 0, 5, 35, 0, (byte)ekranMesajiOnlieSatir3x.Value, (byte)ekranMesajiOnlieSatir3y.Value, 0, (byte)ekranMesajiOnlieSatir4x.Value, (byte)ekranMesajiOnlieSatir4y.Value, 0, (byte)ekranMesajiOnlieSatir5x.Value, (byte)ekranMesajiOnlieSatir5x.Value, 0, 2, 2, 5, 5, 0, 10, false);
            };


            if (InvokeRequired)
                BeginInvoke(method);
            else method.Invoke(); 
        }


        private void AddLog(string str, Boolean SM = false)
        {
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

            fLogObject.Items.Add( ss + ":" + dd + ":" + sa + " : " + msc + " > " + str + "\n" );
           
        }

    }
}

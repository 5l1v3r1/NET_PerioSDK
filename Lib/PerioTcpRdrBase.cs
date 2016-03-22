using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Net.Sockets;
using System.Threading;
using System.Runtime.InteropServices;
using System.IO;
using System.Reflection;
using System.Net;
using PerioAES;



namespace PerioTcpRdrBase
{

    public class TErrors
    {
	    // Global errors
        public const int NO_ERROR               = 0;
        public const int TIMEOUT 			    = 10001;
		public const int EXCEPTION 			    = 10003;		
		public const int CANNOT_CONNECT 	    = 10004;
		public const int NOT_CONNECTED 		    = 10005;
		public const int CANCELED_BY_USER 	    = 10006;
		public const int CANNOT_SEND 		    = 10007;
		public const int NOT_CREATED_TCPCOMP    = 10008;
		public const int NOT_CREATED_TCP_SOCKET = 10009;
        public const int TCP_CLIENT_ERROR 		= 10160;
        // Protocol errors
        public const int DATA_IS_NOT_ENOUGH 	= 10130;   		
		public const int WRONG_STX 				= 10131;
		public const int WRONG_TCP_HEADER 		= 10132;
		public const int WRONG_SERIAL_HEADER 	= 10133; 
		public const int WRONG_CSUM 			= 10134;
		public const int WRONG_CRC 				= 10135;
		public const int WRONG_ETX 				= 10136;
		public const int NOT_EXPECTED_DATA 		= 10137;		
		public const int ACKNOWLEDGE_MISMATCH 	= 10138;
		public const int NOT_CMD_SUCCESS 		= 10139;
		public const int NOT_PREPARE_LOGINDATA 	= 10140;
		public const int NOT_LOGIN_DEVICE 		= 10141;
		public const int WRONG_SESSION_ID 		= 10142;
		public const int SESSION_ID_MISMATCH    = 10143;
		public const int WRONG_DATA_ONTX        = 10144;
		public const int WRONG_PARAMETER        = 10145;
		public const int NOT_ENCYRPTED          = 10151;
		public const int INVALID_IP_ADRESS      = 10152;
		public const int INVALID_COMN_KEY       = 10153;
        //CARD OPERATIONS
		public const int NO_CARD               = 10540;
		public const int FAULTY_KEY            = 10541;
		public const int FAULTY_CMD_KEYTYPE    = 10542;
		public const int FAIL                  = 10543;
		public const int WRITE_ERROR           = 10545;
		public const int WRONG_SECTOR_NUM      = 10550;
		public const int WRONG_BLOCK_NUM       = 10551;
		public const int WRONG_MASTERKEY_NUM   = 10552;
		public const int WRONG_FORM_NUM        = 10553;
		public const int ERR_CMD_FORM          = 10554;
		public const int UNKNOWN_FORM_NUM      = 10555;
		public const int CARD_IS_NOT_SELECTED  = 10556;
		public const int SECTOR_IS_NOT_LOGIN   = 10557;
		public const int WRONG_IO_NUM          = 10558;
		public const int WRONG_IO_STATE        = 10559;
		public const int WRONG_DEV_NUM         = 10560;
		public const int WRONG_BCKL_CNTR       = 10561;
		public const int NO_MORE_RECS          = 10562;
		public const int WL_WRONG_COUNT        = 10563;
		public const int WL_WRONG_START_POS    = 10564;
		public const int WL_NOTCONFIRMED_COUNT = 10565;
		public const int FU_NOFILE             = 10566;
		public const int FU_FILE_IS_EMPTY      = 10567;
    	public const int ERR_NODATA            = 10908;
    	public const int ERR_WRONGPAGESIZE     = 10909;
        public const int ERR_WRONHEXDATA       = 10910;
	}

	public enum TProtocolType { PR0, PR1, PR2, PR3 };
    public enum TReaderType { rdr26M, rdr63M_V3, rdr63M_V5 };
    public enum TDFType { df4MB, df8MB };

    public enum TWorkingMode {wmOffline,wmOfflineCard,wmTCPOnline,wmUDPOnline};
    public enum TOnlineCardWorkMode  {womTCPOnline = 0 ,womUDPOnline = 1,womTCPOnlineClientMode =2};
    public enum TrOutType {NrOpen,NrClosed};

    public enum TIdleScreenType {stText,stLogo};
    public enum TKeyType { ktKeyA, ktKeyB };
    public enum TInputConfirmationType {ctOk,ctCancel};


    public static class SocketExtensions
    {
        private const int BytesPerLong = 4; // 32 / 8
        private const int BitsPerByte = 8;

        /// <summary>
        /// Sets the keep-alive interval for the socket.
        /// </summary>
        /// <param name="socket">The socket.</param>
        /// <param name="time">Time between two keep alive "pings".</param>
        /// <param name="interval">Time between two keep alive "pings" when first one fails.</param>
        /// <returns>If the keep alive infos were succefully modified.</returns>
        public static bool SetKeepAlive(this Socket socket, ulong time, ulong interval)
        {
            try
            {
                // Array to hold input values.
                var input = new[]
            	{
            		(time == 0 || interval == 0) ? 0UL : 1UL, // on or off
					time,
					interval
				};

                // Pack input into byte struct.
                byte[] inValue = new byte[3 * BytesPerLong];
                for (int i = 0; i < input.Length; i++)
                {
                    inValue[i * BytesPerLong + 3] = (byte)(input[i] >> ((BytesPerLong - 1) * BitsPerByte) & 0xff);
                    inValue[i * BytesPerLong + 2] = (byte)(input[i] >> ((BytesPerLong - 2) * BitsPerByte) & 0xff);
                    inValue[i * BytesPerLong + 1] = (byte)(input[i] >> ((BytesPerLong - 3) * BitsPerByte) & 0xff);
                    inValue[i * BytesPerLong + 0] = (byte)(input[i] >> ((BytesPerLong - 4) * BitsPerByte) & 0xff);
                }

                // Create bytestruct for result (bytes pending on server socket).
                byte[] outValue = BitConverter.GetBytes(0);

                // Write SIO_VALS to Socket IOControl.
                socket.SetSocketOption(SocketOptionLevel.Tcp, SocketOptionName.KeepAlive, true);
                socket.IOControl(IOControlCode.KeepAliveValues, inValue, outValue);
            }
            catch (SocketException e)
            {
                Console.WriteLine("Failed to set keep-alive: {0} {1}", e.ErrorCode, e);
                return false;
            }

            return true;
        }
    }


    public class Ttree_Node
    {
        public uint Adress;
        public byte[] Value;
        public byte Color;
        public uint Left;
        public uint Right;
        public uint Parent;
        public Ttree_Node()
        {
            Value = new byte[7];
        }
    }


    public struct TWhiteListStatus
    {
        public uint PersCnt;
        public uint rb_ins_tree_root;
        public uint rb_Del_tree_root;
        public Ttree_Node InsNode;
        public Ttree_Node DelNode;

    }

    public struct TWorkModeSettings
    {
        public TWorkingMode WorkingMode;
        public Boolean OfflineModePermission;
        public uint ServerAnswerTimeOut;
        public TOnlineCardWorkMode OfflineOnlineMode;

    }



    public class TWeekDays
    {
        public string[] names;
        public TWeekDays()
        {
          names = new string[7];
          names[0] = "Pazartesi";
          names[1] = "Salý";
          names[2] = "Çarþamba";
          names[3] = "Perþembe";
          names[4] = "Cuma";
          names[5] = "Cumartesi";
          names[6] = "Pazar";
        }

    }




    public struct TBellSettings
    { 
    public Boolean Enabled;
    public string ScreenText1;
    public string ScreenText2;
    public Byte OutType;
    }


       
    public struct TOutOfServiceSettings
    {
       public Boolean Enabled;
       public string ScreenText1;
       public string ScreenText2;
       public Byte OutType;
    }



    public struct TEksOtherSettings
    {
        public byte PersDataCardSector;
        public byte AccessDataCardSector;
    }
    

    public struct TAPBSettings
    {
        public byte APBType;
        public byte SequentialTransitionTime;
        public byte SecurityZone;
        public byte ApbInOut;
    }

    public struct TOneTAC
    {
        public TimeSpan  StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
    }


    public class TTACDay 
    {
        public TOneTAC[] Part;
        public TTACDay ()
        {
            Part = new TOneTAC[8];
        }                
    }

    public class TTACList 
    {
        public TTACDay[] Day;
        public TTACList()
        {
            Day = new TTACDay[8];
            Day[0] = new TTACDay();
            Day[1] = new TTACDay();
            Day[2] = new TTACDay();
            Day[3] = new TTACDay();
            Day[4] = new TTACDay();
            Day[5] = new TTACDay();
            Day[6] = new TTACDay();
            Day[7] = new TTACDay();
        }
    }

    public class TFullTimeACList
    {
        public TTACList[] List = new TTACList[48];
    }

    public struct TOneOOS
    {
        public DateTime StartTime;
        public DateTime EndTime;
    }

    public class TDayOSS
    {
        public TOneOOS[] part;
        public TDayOSS()
        {
            part = new TOneOOS[4];
        }
    }

    public class TOSTable
    {
        public TDayOSS[] day;
        public TOSTable()
        {
            day = new TDayOSS[8];
            day[0] = new TDayOSS();
            day[1] = new TDayOSS();
            day[2] = new TDayOSS();
            day[3] = new TDayOSS();
            day[4] = new TDayOSS();
            day[5] = new TDayOSS();
            day[6] = new TDayOSS();
            day[7] = new TDayOSS();
        }
    }


    public struct TAccessMode
    {
        public byte AccessType;
        public byte PasswordType;
    }



    public class TMfrKey
    {
        public byte[] KeyA;
        public byte[] KeyB;

        public TMfrKey()
        {
            this.KeyA = new byte[16];
            this.KeyB = new byte[16];
        }
        
    }

    public class TMfrKeyList
    {
        public TMfrKey[] Sector;
        public TMfrKeyList()
        {
            this.Sector = new TMfrKey[16];
            for (int i = 0; i < 16; i++)
            {
                Sector[i] = new TMfrKey();
            }
        }
    }

    public struct TMfrKeyStr
    {
        public string KeyA;
        public string KeyB;
    }


    public class TMfrKeyListStr
    {
        public TMfrKeyStr[] Sector;
        public TMfrKeyListStr()
        {
            this.Sector = new TMfrKeyStr[16];        
        }
    }



    public struct TInputSettings
    {
        public byte InputType;
        public ushort InputDurationTimeout;
    }

    
    public struct TAccessGeneralSettings
    {
        public TInputSettings InputSettings;
        public TAccessMode AccessMode;
        public Boolean TimeAccessConstraintEnabled;
    }



    public struct TUDPSettings
    {
        public Boolean UDPIsActive;
        public Boolean UDPLogIsActive;
        public String RemUDPAdress;
        public ushort UDPPort;
    }

    public struct TGeneralDeviceSettins
    {
        public string DefaultScreenTxt1;
        public string DefaultScreenTxt2;
        public byte   CardReadBeepTime;
        public TrOutType TrOut1Type;
        public TrOutType TrOut2Type;
        public TIdleScreenType IdleScreenType;
        public Boolean DailyRebootEnb;
        public DateTime  RebootTime;
        public ushort DevNo;
        public ushort Backlight;
        public ushort Contrast;
        public ushort CardReadTimeOut;
        public ushort VariableClearTimeout;
        public byte DefaultScreenFontType;
        public byte CardReadDelay;


    }



    public struct TClientTCPSettings
    { 
      public String IPAdress;
      public ushort Port;
    }


    public struct TTCPSettings
    {
        public String IPAdress;
        public String DefGetway;
        public string NetMask;
        public string PriDNS;
        public string SecDNS;
        public ushort Port;
        public String RemIpAdress;
        public Boolean DHCP;
        public Boolean ConnectOnlyRemIpAdress;
        public TProtocolType ProtocolType;
    }
        

    public struct TDeviceTCPSettings
    {
        public String IPAdress;
        public String DefGetway;
        public string NetMask;
        public string PriDNS;
        public string SecDNS;
        public ushort Port;
        public String RemIpAdress;
        public Boolean DHCP;
        public Boolean ConnectOnlyRemIpAdress;
        public TProtocolType ProtocolType;
        public Byte ServerEchoTimeOut;
    }

    public struct TScreenLine
    {
        public string   Text;
        public byte Alligment;
        public byte X;
        public byte Y;
    }

 

    public class TLcdScreen
    {
        public ushort ID;
        public byte HeaderType ;   
        public String Caption;    
        public TScreenLine[] Line ;
        public byte FooterType;
        public String Footer;
        public ushort RL_Time1;
        public ushort RL_Time2;
        public ushort BZR_time;
        public Boolean IsBlink;
        public ushort ScreenDuration;
        public byte FontType;
        public byte LineCount;
        public ushort NextScreen;
        public byte KeyPadType;

        public TLcdScreen()
        {
            this.Line = new TScreenLine[5];
        }
    }


    public struct TBlackList
    {
       public string CardID ;
       public string Caption ;
       public byte BlackListCmdNo;
    }


    public class TPerson
    {
        public string   CardID;
        public string   Name;
        public byte   TimeZoneListNo;
        public uint     Code;
        public ushort   Password;
        public DateTime   EndDate;
        public Boolean  AccessDevice;
        public Boolean  APBEnabled;
        public Boolean TZEnabled;
        public Boolean  AccessCardEnabled;
        public Boolean IsOnlineCard;
        public byte MealSettingListNo;
        public byte WeeklyTotalMealCount;
        public byte MonthlyTotalMealCount;
        public byte BlackListCmdNo;
        public byte NeedCmdControl;
        public DateTime BirthDate;
        public Boolean PermitedInEmergency;
    }

    public struct TOneRecord
    {
        public string   CardID;
        public byte     DoorNo;
        public byte     RecordType;
        public byte     GcType;
        public DateTime TimeDate;
    }

    public struct TAccessRecords
    {
        public uint Count;
        public TOneRecord[] raDeviceRecs;
        

    }

    public struct TTCPBuffer
    {
        public byte[] uaBuff;   
        public int    u2Len;
        public byte   CmdNo ;
        public byte   SubCmdNo;
        public byte   Tx_Acknowledge;
        public byte   Tx_DataLen;
        public byte   Tx_SessionId;
        public byte   Tx_XORSessionId;
        public byte   Rx_Acknowledge;
        public int    Rx_DataLen;
        public byte   Rx_Return_Valuse;
        public byte   Rx_SessionId;
        public byte   Rx_XORSessionId;
        public uint   SelectTimeOut;
    }


    public delegate void RxCardID(object source, RxCardIDArgs e);
    public class RxCardIDArgs : EventArgs
    {
        private string fCardID;
        public RxCardIDArgs(string strCardID)
        {
            fCardID = strCardID;
        }
        public string CardID
        {
            get
            {
                return fCardID;
            }
        }
    }
    

    public delegate void RxInputText(object source, RxInputTextArgs e);
    public class RxInputTextArgs : EventArgs
    {
        private TInputConfirmationType FConfirmationType;
        private string FInputText;

        public RxInputTextArgs(TInputConfirmationType ConfirmationType, string InputText)
        {
            FConfirmationType = ConfirmationType;
            FInputText = InputText;
        }

        public TInputConfirmationType ConfirmationType { get { return FConfirmationType; } }
        public string InputText { get { return FInputText; } }

    }


    public delegate void RxTagRead(object source, RxTagReadArgs e);
    public class RxTagReadArgs : EventArgs
    {
        private byte fIO;
        private string fTagId;

        public RxTagReadArgs(byte IO, string TagId)
        {
            fTagId = TagId;
            fIO = IO;
        }

        public byte IO {get { return fIO; }}
        public string TagId { get { return fTagId; } }
    }


    public delegate void RxDoorOpenAlarm(object source, RxDoorOpenAlarmArgs e);
    public class RxDoorOpenAlarmArgs : EventArgs
    {
        private Boolean fDoorOpen;
        private uint fOpenTime;

        public RxDoorOpenAlarmArgs(Boolean DoorOpen, uint OpenTime)
        {
            fDoorOpen = DoorOpen;
            fOpenTime = OpenTime;
        }


        public Boolean DoorOpen { get { return fDoorOpen; } }
        public uint OpenTime { get { return fOpenTime; } }
    }


    public delegate void RxPasswordRead(object source , RxPasswordReadArgs e);
    public class RxPasswordReadArgs : EventArgs
    { 
        private byte fPassType;
        private ushort fPassword;
        private ushort fCode;

        public RxPasswordReadArgs(byte PassType, ushort Password, ushort Code)
        {
            fPassType = PassType;
            fPassword = Password;
            fCode = Code;
        }
        public byte PassType { get { return fPassType; } }
        public ushort Password { get { return fPassword; } }
        public ushort Code { get { return fCode; } }
    }

    
    public delegate void RxSerialReadStr(object source, RxSerialReadStrArgs e);
    public class RxSerialReadStrArgs : EventArgs
    {
        private string fData;
        private byte fSerialPortNo;
        public RxSerialReadStrArgs(byte bSerialPortNo, string strData)
        {
            fData = strData;
            fSerialPortNo = bSerialPortNo;
        }
        public string Data
        {
            get
            {
                return fData;
            }
        }
        public byte SerialPortNo
        {
            get
            {
                return fSerialPortNo;
            }
        }

    }

    public delegate void RxTurnstileTurn(object source, RxTurnstileTurnArgs e);
    public class RxTurnstileTurnArgs : EventArgs
    {
        private string  fCardID;
        private Boolean fSuccess;
        public RxTurnstileTurnArgs(Boolean bSuccess, string strCardID)
        {
            fSuccess = bSuccess; 
            fCardID = strCardID;
        }
        public string CardID
        {
            get
            {
                return fCardID;
            }
        }
        public Boolean Success
        {
            get
            {
                return fSuccess;
            }
        }
    }

    public delegate void DeviceConnected(object source);

    public delegate void DeviceDisConnected(object source);

    public partial class TcpRdrBase : Component
    {
	    private Socket      tcpSocket; // TcpClient Component      
        private DateTime    NextDeviceConnTime;
        private int fOnlineReConnectTimeOut;
        Thread      fCheckOnlineThread;
        // Sonra     fCheckOnlineThread : TCheckOnlineThread; // Online Modda Receive Kontrolü bu thread de yapýlýr
		private TReaderType     fReaderType; // Reader Tipi (63MV2,63MV5,26M)
		private TProtocolType   fProtocolType;//Haberþeþme Protokol seçimi
		private TDFType         fDFType;        //Dataflash Tipi (4MB,8MB)
		public ushort          fDFPageSize;    //Dataflash Tipine göre dataflash boyu
		private string          fIP;           // Cihaz IP Adresi
		private int             fPort;         // Cihaz Port No
		private int             fTimeOut;     // Cihaza PC haberleþme zaman aþýmý süresü (ms)
		private int             fDeviceID;    // Cihaz ID
		private string          fDeviceName;  // Cihaz Adý veya Kodu
        private byte[]          fEncDeviceLoginKey;  //Cihaz Baðlantý Þifresi
		private string          fDeviceLoginKey; //Cihaz Baðlantý Þifresi
        //Sonra private ushort          fSessionID; //Baðlantý session ID
		private bool            fAutoConnect; // Baðlantý koptuðunda otomatik b aðlan
		private int             fDefcmdRetry; // Komut baþarýsýz olmuþ ise tekrar sayýsý
		private bool            fAutoRxEnabled; // Online mod için TCP den cihazý dinleme
		private uint            fDefSelectTimeout;    // Receive Sýrasýnda varsayýlan bekleme süresi (ms)
                                                                // Komut türüne göre deðiþkenlik gösterebilir diye bekleme süresini bu deðiþken ile set ediyoruz.
		private bool            fConnected; // Cihaz ile baðlýmý
        private bool            ftryReConnect; // Cihaz ile baðlýmý
		private bool            fLogined;   //Login Oldumu
		//Sonra private bool            fAbort; // Ýþlemi Sonlandýrmak için
		private bool            fOnCmd; // Þu an cihazla bir iþlem yürütüyor mu (fOnCmd True ise cihazdan online iþlemlerini iþlem bitene kadar yapamaz.)
        private TTCPBuffer      TxBuffer; // TCP Client ile gönderielecek paket
        private TTCPBuffer      RxBuffer; // TCP Client dan gelen paket
        private int 			fTx_Protocol_Len;
        private int 			fTx_TCP_Header_Pos;
        private int 			fTx_TCP_Len_Pos;
        private int 			fTx_Serial_Header_Pos;
        private int 			fTx_Serial_Len_Pos;
        //Sonra private int 			fTx_SessionID_Pos;
        private int 			fTx_Command_Pos;
        private int 			fTx_SubCommand_Pos;
        private int 			fTx_Data_Start_Pos;
        private int 			fRx_Protocol_Len;
        private int 			fRx_TCP_Header_Pos;
        private int 			fRx_TCP_Len_Pos;
        private int 			fRx_Serial_Header_Pos;
        private int 			fRx_Serial_Len_Pos;
        //Sonra private int 			fRx_SessionID_Pos;
        private int 			fRx_Acknowledge_Pos;
        private int 			fRx_Return_Value_Pos;
        //Sonra private int 			fRx_Command_Pos;
        //Sonra private int 			fRx_SubCommand_Pos;
        private int 		    fRx_Data_Start_Pos;
        private int             fOnlineThreadSleepTime;

        //private Thread          fCheckOnlineThread;
        public event RxCardID   OnRxCardID;
        public event RxTurnstileTurn OnRxTurnstileTurn;
        public event RxSerialReadStr OnRxSerialReadStr;
        public event RxTagRead OnRxTagRead;
        public event RxDoorOpenAlarm OnRxDoorOpenAlarm;
        public event RxPasswordRead OnPasswordRead;
        public event RxInputText OnRxInputText;
        public event DeviceConnected OnConnected;
        public event DeviceDisConnected OnDisConnected;

        protected ushort ByteCrc(byte usByte,ushort usAcc)
        {
            int i = 0;
            ushort bytflag = 0;
            usAcc ^= usByte;            //    ^=   :  XOR
            for (i = 0; i < 8; i++)
            {
                bytflag = (ushort)(usAcc & 0x0001);
                usAcc >>= 1;           //    >>    :  SHIFT RIGHT
                if (bytflag > 0)
                    usAcc ^= 0xA001;   //     ^=   :  XOR
            }
            return usAcc;
        }

        protected void ResetTxBuffer()
        {
			TxBuffer.u2Len = 0;
			TxBuffer.CmdNo = 0;
			TxBuffer.SubCmdNo = 0;
			TxBuffer.Tx_Acknowledge = 0;
			TxBuffer.Tx_DataLen = 0;
			TxBuffer.Tx_SessionId = 0;
			TxBuffer.Tx_XORSessionId = 0;
			TxBuffer.Rx_Acknowledge = 0;
			TxBuffer.Rx_DataLen = 0;
			TxBuffer.Rx_Return_Valuse = 0;
			TxBuffer.Rx_SessionId = 0;
			TxBuffer.Rx_XORSessionId = 0;
			TxBuffer.SelectTimeOut = 0;
            for (int i = 0; i < 512; i++)
            {
                TxBuffer.uaBuff[i] = 0;
            }
        }

        protected void ResetRxBuffer()
        {
			RxBuffer.u2Len = 0;
			RxBuffer.CmdNo = 0;
			RxBuffer.SubCmdNo = 0;
			RxBuffer.Tx_Acknowledge = 0;
			RxBuffer.Tx_DataLen = 0;
			RxBuffer.Tx_SessionId = 0;
			RxBuffer.Tx_XORSessionId = 0;
			RxBuffer.Rx_Acknowledge = 0;
			RxBuffer.Rx_DataLen = 0;
			RxBuffer.Rx_Return_Valuse = 0;
			RxBuffer.Rx_SessionId = 0;
			RxBuffer.Rx_XORSessionId = 0;
			RxBuffer.SelectTimeOut = 0;
            for (int i = 0; i < 512; i++)
            {
                RxBuffer.uaBuff[i] = 0;
            }
		}

        protected int SetProtocolPR0()
        {
            int iErr = 0;
            try
            {
			   //Sonra Yazýlacak
			   iErr = 109999;
            }
            catch (Exception e)
            {
				SaveLogFile(MethodBase.GetCurrentMethod(),e);
            }
            return iErr; 		
		}
		
        protected int SetProtocolPR1()
        {
            int iErr = 0;
            ushort uSerialCrc, uTCPCCrc;
            try
            {


                TxBuffer.u2Len = TxBuffer.Tx_DataLen + fTx_Protocol_Len;
                TxBuffer.uaBuff[fTx_TCP_Header_Pos] = 0xAA;
                TxBuffer.uaBuff[fTx_TCP_Header_Pos + 1] = 0xCC;
                TxBuffer.uaBuff[fTx_TCP_Len_Pos] = (byte)((TxBuffer.u2Len - 6) % 256);
                TxBuffer.uaBuff[fTx_TCP_Len_Pos + 1] = (byte)((TxBuffer.u2Len - 6) / 256);
                TxBuffer.uaBuff[fTx_Serial_Header_Pos] = 2;
                TxBuffer.uaBuff[fTx_Serial_Header_Pos + 1] = 0;
                TxBuffer.uaBuff[fTx_Serial_Len_Pos] = (byte)((TxBuffer.Tx_DataLen + 2) % 256);
                TxBuffer.uaBuff[fTx_Serial_Len_Pos + 1] = (byte)((TxBuffer.Tx_DataLen + 2) / 256);
                TxBuffer.uaBuff[fTx_Command_Pos] = TxBuffer.CmdNo;
                TxBuffer.uaBuff[fTx_SubCommand_Pos] = TxBuffer.SubCmdNo;

                // serial crc
                uSerialCrc = 0;
                for (int i = 0; i < TxBuffer.Tx_DataLen + 6; i++)
                    uSerialCrc = ByteCrc(TxBuffer.uaBuff[fTx_Serial_Header_Pos + i], uSerialCrc);

                TxBuffer.uaBuff[fTx_Data_Start_Pos + TxBuffer.Tx_DataLen] = (byte)(uSerialCrc % 256);
                TxBuffer.uaBuff[fTx_Data_Start_Pos + TxBuffer.Tx_DataLen + 1] = (byte)(uSerialCrc / 256);

                // tcp crc
                uTCPCCrc = 0;
                for (int i = 2; i < TxBuffer.u2Len - 2; i++)
                    uTCPCCrc = ByteCrc(TxBuffer.uaBuff[i], uTCPCCrc);

                TxBuffer.uaBuff[TxBuffer.u2Len - 2] = (byte)(uTCPCCrc % 256);
                TxBuffer.uaBuff[TxBuffer.u2Len - 1] = (byte)(uTCPCCrc / 256); 

            }
            catch (Exception e)
            {
				SaveLogFile(MethodBase.GetCurrentMethod(),e);
            }
            return iErr; 		
		}
        
		protected int SetProtocolPR2()
        {
            int iErr = 0;
			ushort uSerialCrc, uTCPCCrc;
            try
            {			
				TxBuffer.u2Len = TxBuffer.Tx_DataLen + fTx_Protocol_Len;
				TxBuffer.uaBuff[fTx_TCP_Header_Pos] = 0xAA;
				TxBuffer.uaBuff[fTx_TCP_Header_Pos + 1] = 0xDD;
				TxBuffer.uaBuff[fTx_TCP_Len_Pos] = (byte)((TxBuffer.u2Len - 6) % 256);
				TxBuffer.uaBuff[fTx_TCP_Len_Pos + 1] = (byte)((TxBuffer.u2Len - 6) / 256);
				TxBuffer.uaBuff[fTx_Serial_Header_Pos] = 2;
				TxBuffer.uaBuff[fTx_Serial_Header_Pos + 1] = 0;
				TxBuffer.uaBuff[fTx_Serial_Len_Pos] = (byte)((TxBuffer.Tx_DataLen + 2) % 256);
				TxBuffer.uaBuff[fTx_Serial_Len_Pos + 1] = (byte)((TxBuffer.Tx_DataLen + 2) / 256);
				TxBuffer.uaBuff[fTx_Command_Pos] = TxBuffer.CmdNo;
				TxBuffer.uaBuff[fTx_SubCommand_Pos] = TxBuffer.SubCmdNo;

				// serial crc
				uSerialCrc = 0;
				for (int i = 0; i < TxBuffer.Tx_DataLen + 6; i++)
					uSerialCrc = ByteCrc(TxBuffer.uaBuff[fTx_Serial_Header_Pos + i], uSerialCrc);
				
				TxBuffer.uaBuff[fTx_Data_Start_Pos + TxBuffer.Tx_DataLen] = (byte)(uSerialCrc % 256); 
                TxBuffer.uaBuff[fTx_Data_Start_Pos + TxBuffer.Tx_DataLen + 1] = (byte)(uSerialCrc / 256); 

				// tcp crc
				uTCPCCrc = 0;
                for (int i = 2; i < TxBuffer.u2Len - 2; i++)
                    uTCPCCrc = ByteCrc(TxBuffer.uaBuff[i], uTCPCCrc);
				
				TxBuffer.uaBuff[TxBuffer.u2Len - 2] = (byte)(uTCPCCrc % 256); 
				TxBuffer.uaBuff[TxBuffer.u2Len - 1] = (byte)(uTCPCCrc / 256); 
            }
            catch (Exception e)
            {
                SaveLogFile(MethodBase.GetCurrentMethod(), e);
 		        iErr = TErrors.EXCEPTION;
            }
            return iErr; 		
		}
		
        protected int SetProtocol()
        {
            int iErr = 0;
            try
            {
				switch (fProtocolType)
				{
                    case TProtocolType.PR0:			
						iErr = SetProtocolPR0();
					break;
                    case TProtocolType.PR1:
						iErr = SetProtocolPR1();
					break;
                    case TProtocolType.PR2:
					    iErr = SetProtocolPR2();
					break;	
				}
            }
            catch (Exception e)
            {
				iErr = TErrors.EXCEPTION;
                SaveLogFile(MethodBase.GetCurrentMethod(), e);
            }
            return iErr; 		
		}

        protected int CheckProtocolPR0()
        {
            int iErr = 0;
            try
            {
			   //Sonra Yazýlacak
			   iErr = 109999;
            }
            catch (Exception e)
            {
                SaveLogFile(MethodBase.GetCurrentMethod(), e);
				iErr = TErrors.EXCEPTION;
			}
            return iErr; 		
		}

        protected int CheckProtocolPR1()
        {
            int iErr = 0;
            try
            {
                ushort u2DataLen, uTCPCrc, SLen, uSerialCrc;

                if (RxBuffer.u2Len < 15)
                    iErr = TErrors.DATA_IS_NOT_ENOUGH;
                if (iErr != 0)
                    goto lend;

                if ((RxBuffer.uaBuff[fRx_TCP_Header_Pos] == 0xAA) && (RxBuffer.uaBuff[fRx_TCP_Header_Pos + 1] == 0xCC))
                    iErr = TErrors.NO_ERROR;
                else
                    iErr = TErrors.WRONG_TCP_HEADER;
                if (iErr != 0)
                    goto lend;

                u2DataLen = (ushort)(RxBuffer.uaBuff[fRx_TCP_Len_Pos] + RxBuffer.uaBuff[fRx_TCP_Len_Pos + 1] * 256);
                if (RxBuffer.u2Len < (u2DataLen + 6))
                    iErr = TErrors.DATA_IS_NOT_ENOUGH;
                if (iErr != 0)
                    goto lend;

                uTCPCrc = 0;
                for (int i = 0; i < 2 + u2DataLen; i++)
                    uTCPCrc = ByteCrc(RxBuffer.uaBuff[2 + i], uTCPCrc);

                if ((RxBuffer.uaBuff[4 + u2DataLen + 0] + RxBuffer.uaBuff[4 + u2DataLen + 1] * 256) != uTCPCrc)
                    iErr = TErrors.WRONG_CRC;
                if (iErr != 0)
                    goto lend;

                if (RxBuffer.uaBuff[fRx_Serial_Header_Pos] == 2)
                    iErr = TErrors.NO_ERROR;
                else
                    iErr = TErrors.WRONG_SERIAL_HEADER;
                if (iErr != 0)
                    goto lend;

                SLen = (ushort)(RxBuffer.uaBuff[fRx_Serial_Len_Pos] + RxBuffer.uaBuff[fRx_Serial_Len_Pos + 1] * 256);
                if (RxBuffer.u2Len < (SLen + 6 + 6))
                    iErr = TErrors.DATA_IS_NOT_ENOUGH;
                if (iErr != 0)
                    goto lend;

                uSerialCrc = 0;
                for (int i = 4; i < RxBuffer.u2Len - 4; i++)
                    uSerialCrc = ByteCrc(RxBuffer.uaBuff[i], uSerialCrc);

                if ((RxBuffer.uaBuff[RxBuffer.u2Len - 4] + RxBuffer.uaBuff[RxBuffer.u2Len - 3] * 256) != uSerialCrc)
                    iErr = TErrors.WRONG_CSUM;
                if (iErr != 0)
                    goto lend;
                iErr = TErrors.NO_ERROR;
            lend:
                uSerialCrc = 0;
            }
            catch (Exception e)
            {
                SaveLogFile(MethodBase.GetCurrentMethod(), e);
				iErr = TErrors.EXCEPTION;
            }
            return iErr; 		
		}
		
        protected int CheckProtocolPR2()
        {
            int iErr = 0;
            try
            {
			     ushort u2DataLen, uTCPCrc, SLen, uSerialCrc;
         
                if (RxBuffer.u2Len < 15) 
                  iErr = TErrors.DATA_IS_NOT_ENOUGH;
                if (iErr != 0) 
                  goto lend;

                if ( (RxBuffer.uaBuff[fRx_TCP_Header_Pos] == 0xAA) && (RxBuffer.uaBuff[fRx_TCP_Header_Pos + 1] == 0xDD) ) 
                  iErr = TErrors.NO_ERROR;
                else
                  iErr = TErrors.WRONG_TCP_HEADER;
                if (iErr != 0)
                  goto lend;

                u2DataLen = (ushort)(RxBuffer.uaBuff[fRx_TCP_Len_Pos] + RxBuffer.uaBuff[fRx_TCP_Len_Pos + 1] * 256);
                if (RxBuffer.u2Len < (u2DataLen + 6))
                  iErr = TErrors.DATA_IS_NOT_ENOUGH;
                if (iErr != 0)
                  goto lend;

                uTCPCrc = 0;
				for (int i = 0; i < 2 + u2DataLen;i++ ) 
					uTCPCrc = ByteCrc(RxBuffer.uaBuff[2 + i], uTCPCrc);
				  
                if ( (RxBuffer.uaBuff[4 + u2DataLen + 0] + RxBuffer.uaBuff[4 + u2DataLen + 1]* 256) != uTCPCrc )
                  iErr = TErrors.WRONG_CRC;
                if (iErr != 0) 
                  goto lend;

                if (RxBuffer.uaBuff[fRx_Serial_Header_Pos] == 2) 
                  iErr = TErrors.NO_ERROR;
                else
                  iErr = TErrors.WRONG_SERIAL_HEADER;
                if (iErr != 0) 
                  goto lend;

                SLen = (ushort)(RxBuffer.uaBuff[fRx_Serial_Len_Pos] + RxBuffer.uaBuff[fRx_Serial_Len_Pos + 1] * 256);
                if (RxBuffer.u2Len < (SLen + 6 + 6) )
                  iErr = TErrors.DATA_IS_NOT_ENOUGH;
                if (iErr != 0)
                  goto lend;

                uSerialCrc = 0;
				for (int i = 4; i < RxBuffer.u2Len - 4; i++)
					uSerialCrc = ByteCrc(RxBuffer.uaBuff[i], uSerialCrc);

                if ((RxBuffer.uaBuff[RxBuffer.u2Len - 4] + RxBuffer.uaBuff[RxBuffer.u2Len - 3] * 256) != uSerialCrc) 
                  iErr = TErrors.WRONG_CSUM;
                if (iErr != 0) 
                  goto lend;
                iErr = TErrors.NO_ERROR;
				lend : 
                  uSerialCrc = 0;
            }
            catch (Exception e)
            {
                iErr = TErrors.EXCEPTION;
                SaveLogFile(MethodBase.GetCurrentMethod(), e);
            }
            return iErr; 		
		}
		
        protected int CheckProtocol()
        {
            int iErr = 0;
            try
            {
				switch (fProtocolType)
				{
                    case TProtocolType.PR0:			
						iErr = CheckProtocolPR0();
					break;
                    case TProtocolType.PR1:
						iErr = CheckProtocolPR1();
					break;
                    case TProtocolType.PR2:
					    iErr = CheckProtocolPR2();
					break;	
				}
            }
            catch (Exception e)
            {
                iErr = TErrors.EXCEPTION;
                SaveLogFile(MethodBase.GetCurrentMethod(), e);
            }
            return iErr; 		
		}

        protected int Send()
        {
            int iErr = 0;
            try
            {
                iErr = CheckConnection();
                if (iErr == 0)
                {
                    
                    tcpSocket.SendBufferSize = TxBuffer.u2Len;
                    tcpSocket.Send(TxBuffer.uaBuff, TxBuffer.u2Len, 0);  
                    iErr = TErrors.NO_ERROR;                            
                }
            }
            catch (Exception e)
            {
                SaveLogFile(MethodBase.GetCurrentMethod(), e);
            }
            return iErr;
        }

        protected int Receive(uint OprStartTime)
        {
            int iErr = 0;
            bool bRxSession;
            int iRx,  TimeoutasParam;           

            try
            {
                bRxSession = true;
                TimeoutasParam = fTimeOut;
                DateTime TimeoutDt = DateTime.Now;
                TimeoutDt = TimeoutDt.AddMilliseconds(TimeoutasParam);
  
                iErr = CheckConnection();
                if (iErr == 0)
                {
                    byte[] ReadRxBuffer = new byte[512];
                    while (bRxSession)
                    {
                        Thread.Sleep(1);

                        iRx = tcpSocket.Available;

                        if (iRx > 0)
                        {
                            if ((iRx + RxBuffer.u2Len) > RxBuffer.uaBuff.Length)
                            {
                                iRx = RxBuffer.uaBuff.Length - RxBuffer.u2Len;
                            }

                            /// RECEIVE +++
                            iRx = tcpSocket.Receive(ReadRxBuffer);
                            /// RECEIVE ---
                            for (int i = 0; i < iRx; i++)
                                RxBuffer.uaBuff[RxBuffer.u2Len + i] = ReadRxBuffer[i];

                            RxBuffer.u2Len = RxBuffer.u2Len + iRx;
                        } //if (iRx > 0)

                        if (iRx > 0) 
                            iErr = CheckProtocol();
                        else
                            iErr = TErrors.DATA_IS_NOT_ENOUGH;

                        if (iErr == 0)
                        {
                            RxBuffer.Rx_Acknowledge = RxBuffer.uaBuff[fRx_Acknowledge_Pos];
                            RxBuffer.Rx_DataLen = (RxBuffer.u2Len - fRx_Protocol_Len);
                            RxBuffer.Rx_Return_Valuse = RxBuffer.uaBuff[fRx_Return_Value_Pos];

                            iErr = TErrors.NO_ERROR;
                            bRxSession = false;
                        }
                        else if (iErr == TErrors.DATA_IS_NOT_ENOUGH)
                            Thread.Sleep(1);
                        else
                            bRxSession = false;

                        if (bRxSession)
                        {
                            if (OprStartTime + TimeoutasParam <= lTimeToMs(DateTime.Now))
                            {
                                bRxSession = false;
                            }
                            //int tm = DateTime.Compare(TimeoutDt, DateTime.Now);
                            //if (tm < 0) bRxSession = false;
                        }
                    }                
                
                }
            }
            catch (Exception e)
            {
                SaveLogFile(MethodBase.GetCurrentMethod(), e);
            }
            return iErr;
        }

        private uint lTimeToMs(DateTime dt)
        {
            return  (uint)(dt.Hour * 60 * 60 * 1000) + (uint)(dt.Minute * 60 * 1000) + (uint)(dt.Second * 1000) + (uint)(dt.Millisecond);
        }

        protected int ExecuteCmd(int CmdNo, int SubCmdNo, int Acknowledge, int DataLen, byte[] SendData, out byte[] RecData, int SelectTimeOut = 0, int CmdRetry=0)
        {
            int iErr = 0, uRetry, lCmdRetry;
            bool CmdSuccess;
            byte[] TempBuffer = new byte[512];

            try
            {
                if (fConnected)
                {
                    fOnCmd = true;
                    ResetTxBuffer();
                    ResetRxBuffer();

                    if (CmdRetry != 0)
                        lCmdRetry = CmdRetry;
                    else
                        lCmdRetry = fDefcmdRetry;

                    TxBuffer.CmdNo = (byte)CmdNo;
                    TxBuffer.SubCmdNo = (byte)SubCmdNo;
                    TxBuffer.Tx_Acknowledge = (byte)Acknowledge;
                    TxBuffer.Tx_DataLen = (byte)DataLen;

                    for (int i = 0; i < TxBuffer.Tx_DataLen; i++)
                        TxBuffer.uaBuff[fTx_Data_Start_Pos + i] = SendData[i];


                    if (SelectTimeOut != 0)
                        TxBuffer.SelectTimeOut = (uint)SelectTimeOut;
                    else
                        TxBuffer.SelectTimeOut = fDefSelectTimeout;

                    uint StartTime = lTimeToMs(DateTime.Now);
                    CmdSuccess = false;
                    iErr = SetProtocol();

                    if (iErr == 0)
                    {
                        uRetry = 0;
                        do
                        {
                            iErr = Send();
                            if (iErr == 0)
                                iErr = Receive(StartTime);
                            if (iErr == 0)
                            {
                                if (Acknowledge == RxBuffer.Rx_Acknowledge)
                                {
                                    CmdSuccess = true;
                                    iErr = RxBuffer.Rx_Return_Valuse;
                                }
                                else
                                    iErr = TErrors.ACKNOWLEDGE_MISMATCH;
                            }
                            else
                                uRetry++;

                        }
                        while ((!CmdSuccess) && (uRetry < lCmdRetry));
                    }

                    if ((iErr == 0) && (RxBuffer.Rx_DataLen > 0))
                    {
                        for (int i = 0; i < RxBuffer.Rx_DataLen; i++)
                            TempBuffer[i] = RxBuffer.uaBuff[fRx_Data_Start_Pos + i];
                    }

                }
                else
                    iErr = TErrors.NOT_CONNECTED;
            }
            catch (Exception e)
            {
                iErr = TErrors.EXCEPTION;
                fOnCmd = false;
                SaveLogFile(MethodBase.GetCurrentMethod(), e);
            }
            finally
            {
                if (iErr == 0)
                {
                    NextDeviceConnTime = DateTime.Now;
                    NextDeviceConnTime = NextDeviceConnTime.AddMilliseconds(fOnlineReConnectTimeOut);
                }
                RecData = TempBuffer;
                fOnCmd = false; 
            }
            return iErr;
        }

        protected int LoginDevice()
        {
            int iErr = 0;
            try
            {
                switch (fProtocolType)
                {
                    case TProtocolType.PR0:
                        iErr = LoginDevicePR0();
                        break;
                    case TProtocolType.PR1:
                        iErr = LoginDevicePR1();
                        break;
                    case TProtocolType.PR2:
                        iErr = LoginDevicePR2();
                        break;
                }
            }
            catch (Exception e)
            {
                iErr = TErrors.EXCEPTION;
                SaveLogFile(MethodBase.GetCurrentMethod(), e);
            }
            return iErr;
        }

        protected int LoginDevicePR0()
        {
            int iErr = 0;
            try
            {
                // Sonra 
            }
            catch (Exception e)
            {
                iErr = TErrors.EXCEPTION;
                SaveLogFile(MethodBase.GetCurrentMethod(), e);
            }
            return iErr;
        }

        protected int LoginDevicePR1()
        {
            int iErr = 0;
            try
            {
                byte[] SendData = new byte[512];
                byte[] RecData = new byte[512];

                for (int i = 0; i < 16; i++)
                    SendData[i] = fEncDeviceLoginKey[i];

                iErr = ExecuteCmd(1, 1, 1, 16, SendData, out RecData, 100);

                fLogined = (iErr == 0);
                
            }
            catch (Exception e)
            {
                iErr = TErrors.EXCEPTION;
                SaveLogFile(MethodBase.GetCurrentMethod(), e);
            }
            return iErr;
        }

        protected int LoginDevicePR2()
        {
            int iErr = 0;
            try
            {
                byte[] SendData = new byte[512];
                byte[] RecData = new byte[512];

                for (int i = 0; i < 16; i++)
                    SendData[i] = fEncDeviceLoginKey[i];

                iErr = ExecuteCmd(1, // CmdNo
                        2, // SubCmdNo
                        1, // Acknowledge
                        16, // DataLen
                        SendData, out RecData, 100 // SelectTimeOut
                        );
                fLogined = (iErr == 0);
                
            }
            catch (Exception e)
            {
                iErr = TErrors.EXCEPTION;
                SaveLogFile(MethodBase.GetCurrentMethod(), e);
            }
            return iErr;
        }

        protected int DoConnect()
        {
            int iErr = 0;
            try
            {
                if (tcpSocket != null)
                {
                    tcpSocket.Dispose();
                    tcpSocket = null;
                }
				tcpSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                SocketExtensions.SetKeepAlive(tcpSocket, 1000, 3000);
                tcpSocket.Blocking = true;
                tcpSocket.Connect(fIP.Trim(), fPort);

                if (tcpSocket.Connected)
                {
				    fConnected = true;
                    ftryReConnect = true;
                    iErr = LoginDevice();
                }
                else
					iErr = TErrors.CANNOT_CONNECT;
                if (iErr == 0)
                {
                    if (fAutoRxEnabled)
                    {
                        if (fCheckOnlineThread == null)
                        {
                            fCheckOnlineThread = new Thread(new ThreadStart(OnlineThread));
                            fCheckOnlineThread.IsBackground = true;
                            fCheckOnlineThread.Priority = ThreadPriority.AboveNormal;
                            fCheckOnlineThread.Start();
                            
                        }
                        //else if (fCheckOnlineThread.ThreadState != ThreadState.Running)
                        //    fCheckOnlineThread.Resume(); 
                    }
                }
            }
            catch (Exception e)
            {
                iErr = TErrors.EXCEPTION;
                SaveLogFile(MethodBase.GetCurrentMethod(), e);
            }
            fConnected = ( iErr == 0 );
            if (OnConnected != null)
                if (fConnected)
                    OnConnected(this);
            return iErr; 				
		}

        protected int DoDisConnect(bool TryReConnect=false)
        {
            int iErr = 0;
            try
            {
                ftryReConnect = TryReConnect;
                iErr = TErrors.NO_ERROR;			
				if (tcpSocket != null)
				{
					tcpSocket.Disconnect(true); 
				    tcpSocket.Dispose();
                    if (OnDisConnected != null)
                        OnDisConnected(this);
				} 
            }
            catch (Exception e)
            {
                iErr = TErrors.EXCEPTION;
                SaveLogFile(MethodBase.GetCurrentMethod(), e);
            }
		    fConnected = false;			
            return iErr; 						
		}

        protected int ReConnect()
        {
            int iErr = 0;
            try
            {
                DoDisConnect(true);
            }
            catch (Exception e)
            {
                iErr = TErrors.EXCEPTION;
                SaveLogFile(MethodBase.GetCurrentMethod(), e);
            }
            try
            {
                iErr = DoConnect();
                if (iErr != 0)
                    iErr = DoConnect();
            }
            catch (Exception e)
            {
                iErr = TErrors.EXCEPTION;
                SaveLogFile(MethodBase.GetCurrentMethod(), e);
            }

            return iErr; 						
		}

        protected int CheckConnection()
        {
            int iErr = 0;
            try
            {
				if (tcpSocket != null)
				{
                    if (tcpSocket.Connected)
                        iErr = TErrors.NO_ERROR;
                    else
                        iErr = TErrors.NOT_CONNECTED;
				}
				else
					iErr = TErrors.NOT_CREATED_TCP_SOCKET;			
            }
            catch (Exception e)
            {
                iErr = TErrors.EXCEPTION;
                SaveLogFile(MethodBase.GetCurrentMethod(), e);
            }
            if ((iErr != 0) && fAutoConnect && ftryReConnect)
				iErr = ReConnect();
			fConnected = (iErr == 0);			
            return iErr; 						
		}

        protected int GetDeviceStatus() // CMD 2.24
        {
            int iErr = 0;
            byte[] SendData = new byte[512];
            byte[] RecData = new byte[512];
            try
            {

                iErr = ExecuteCmd(2, // CmdNo
                        24, // SubCmdNo
                        24, // Acknowledge
                        0, // DataLen
                        SendData, out RecData, 4000 // SelectTimeOut
                        );
                if (iErr != 0)
                {
                    iErr = ExecuteCmd(2, // CmdNo
                            24, // SubCmdNo
                            24, // Acknowledge
                            0, // DataLen
                            SendData, out RecData, 4000 // SelectTimeOut
                            );
                }
            }
            catch (Exception e)
            {
                iErr = TErrors.EXCEPTION;
                SaveLogFile(MethodBase.GetCurrentMethod(), e);
            }
            return iErr;
        }

        protected int CheckConnectionOnline()
        {
            int iErr = 0;
            try
            {
                if (tcpSocket != null)
                {
                    if (tcpSocket.Connected)
                    {
                        iErr = TErrors.NO_ERROR;
                        
                        if (NextDeviceConnTime < DateTime.Now)
                        {
                            NextDeviceConnTime = DateTime.Now;
                            NextDeviceConnTime = NextDeviceConnTime.AddMilliseconds(fOnlineReConnectTimeOut);
                            //SaveLogFile(MethodBase.GetCurrentMethod(), "Try Get Device Connection Status.");
                            try
                            {
                                iErr = GetDeviceStatus();
                            }
                            catch (Exception e)
                            {
                                iErr = TErrors.EXCEPTION;
                                SaveLogFile(MethodBase.GetCurrentMethod(), e);
                            }
                        }
                    }
                    else
                        iErr = TErrors.NOT_CONNECTED;
                }
                else
                    iErr = TErrors.NOT_CREATED_TCP_SOCKET;
            }
            catch (Exception e)
            {
                iErr = TErrors.EXCEPTION;
                SaveLogFile(MethodBase.GetCurrentMethod(), e);
            }

            if ((iErr != 0) && fAutoConnect && ftryReConnect)
                iErr = ReConnect();
            fConnected = (iErr == 0);
            return iErr;
        }

        private void OnlineThread()
        {           
            while (true)
            {
                CheckOnlineData();
                Thread.Sleep(fOnlineThreadSleepTime);
            }
        }

        private void CheckOnlineData()
        {
            if (!fOnCmd && fAutoRxEnabled && fConnected)
            {
                int iErr=0;
                int iRx;
                byte[] ReadRxBuffer = new byte[512];
                byte[] RecData = new byte[512];
                string CardID;
                string strData;
                byte SerialNo;
                Boolean TurnSucces;
                byte IO;
                String tagId;
                Boolean DoorOpen;
                uint OpenTime;
                byte PassType;
                ushort Password ;
                ushort Code;
                TInputConfirmationType InputConfType;
                String InputText;
                int position;

                try
                {
                    iErr = CheckConnectionOnline();
                    if (iErr == 0)
                    {
                        iRx = tcpSocket.Available;
                        if (iRx > 0)
                        {
                            /// RECEIVE ---
                            iRx = tcpSocket.Receive(ReadRxBuffer);
                            for (int i = 0; i < iRx; i++)
                                RxBuffer.uaBuff[i] = ReadRxBuffer[i];

                            RxBuffer.u2Len = iRx;
                            iErr = CheckProtocol();
                            if (iErr == 0) 
                            {
                                RxBuffer.Rx_Acknowledge = RxBuffer.uaBuff[fRx_Acknowledge_Pos];
                                RxBuffer.Rx_DataLen = RxBuffer.u2Len - fRx_Protocol_Len;
                                RxBuffer.Rx_Return_Valuse = RxBuffer.uaBuff[fRx_Return_Value_Pos];
                                // To Do protokol 0 için session ID
                                //RxBuffer.Rx_SessionId := RxBuffer.uaBuff[fRx_SessionID_Pos];
                                //RxBuffer.Rx_XORSessionId := RxBuffer.uaBuff[fRx_Return_Value_Pos];
                                if (RxBuffer.Rx_Acknowledge == 35)
                                {
                                    CardID = "";
                                    for (int i = 0; i < RxBuffer.Rx_DataLen; i++)
                                        RecData[i] = RxBuffer.uaBuff[ fRx_Data_Start_Pos + i];

                                    CardID = prBytesToHex(RecData,3,7);

                                    if (OnRxCardID != null)
                                    {
                                        OnRxCardID(this, new RxCardIDArgs(CardID));
                                    }
                                }
                                if (RxBuffer.Rx_Acknowledge == 55)
                                {
                                    CardID = "";
                                    for (int i = 0; i < RxBuffer.Rx_DataLen; i++)
                                        RecData[i] = RxBuffer.uaBuff[fRx_Data_Start_Pos + i];

                                    TurnSucces = prBytesToBoolean(RecData,0);
                                    CardID = prBytesToHex(RecData, 1, 7);

                                    if (OnRxTurnstileTurn != null)
                                    {
                                        OnRxTurnstileTurn(this, new RxTurnstileTurnArgs(TurnSucces, CardID));
                                    }
                                }

                                if (RxBuffer.Rx_Acknowledge == 56)
                                {
                                    for (int i = 0; i < RxBuffer.Rx_DataLen; i++)
                                    RecData[i] = RxBuffer.uaBuff[fRx_Data_Start_Pos + i];

                                    tagId = prBytesToHex(RecData, 3, 8);
                                    IO = RecData[11];

                                    if (OnRxTagRead !=null)
                                    {
                                        OnRxTagRead(this, new RxTagReadArgs(IO,tagId));   
                                    }

                                }

                                if (RxBuffer.Rx_Acknowledge == 57)
                                {
                                    for (int i = 0; i < RxBuffer.Rx_DataLen; i++)
                                        RecData[i] = RxBuffer.uaBuff[fRx_Data_Start_Pos + i];

                                    DoorOpen = prBytesToBoolean(RecData, 0);
                                    OpenTime = prBytesTouint(RecData,1);

                                    if (OnRxDoorOpenAlarm != null)
                                    {
                                        OnRxDoorOpenAlarm(this, new RxDoorOpenAlarmArgs(DoorOpen, OpenTime));
                                    }
 
                                }

                                if (RxBuffer.Rx_Acknowledge == 58)
                                {
                                    CardID = "";
                                    for (int i = 0; i < RxBuffer.Rx_DataLen; i++)
                                        RecData[i] = RxBuffer.uaBuff[fRx_Data_Start_Pos + i];

                                    SerialNo = RecData[0];
                                    strData = prByteToString(RecData, 1, RxBuffer.Rx_DataLen - 1);

                                    if (OnRxSerialReadStr != null)
                                    {
                                        OnRxSerialReadStr(this, new RxSerialReadStrArgs(SerialNo, strData));
                                    }
                                }

                                if (RxBuffer.Rx_Acknowledge == 59)
                                {
                                    
                                    for (int i = 0; i < RxBuffer.Rx_DataLen; i++)
                                        RecData[i] = RxBuffer.uaBuff[fRx_Data_Start_Pos + i];

                                    PassType = RecData[3];
                                    Password = prBytesToushort(RecData,4);
                                    Code = prBytesToushort(RecData,6);

                                    if (OnPasswordRead != null)
                                    {
                                        OnPasswordRead(this, new RxPasswordReadArgs(PassType, Password, Code));
                                    }
                                }

                                if (RxBuffer.Rx_Acknowledge == 43)
                                {
                                    for (int i = 0; i < RxBuffer.Rx_DataLen; i++)
                                        RecData[i] = RxBuffer.uaBuff[fRx_Data_Start_Pos + i];

                                    if (RecData[0] == 0 )
                                    {
                                        InputConfType = TInputConfirmationType.ctOk;
                                    } else
                                    {
                                        InputConfType = TInputConfirmationType.ctCancel;
                                    }

                                    InputText = prByteToString(RecData, 1, RxBuffer.Rx_DataLen - 1);
                                    position = InputText.IndexOf("-");

                                    if (position != 0 )
                                    {
                                        InputText = InputText.Substring(0, position);
                                    }

                                    if (OnRxInputText != null)
                                    {
                                        OnRxInputText(this, new RxInputTextArgs(InputConfType, InputText));
                                    }

                                }
                            }
                        } //iRx = tcpSocket.Available;
                    } //iErr = CheckConnection();
                }
                catch (Exception e)
                {
                    iErr = TErrors.EXCEPTION;
                    SaveLogFile(MethodBase.GetCurrentMethod(), e);
                }
            } else if (!fConnected)
               CheckConnectionOnline();
        }


        public bool isIP(string ipAdress)
        {
            IPAddress ip;
            bool valid = !string.IsNullOrEmpty(ipAdress) && IPAddress.TryParse(ipAdress, out ip);
            return valid;
        }


        public TcpRdrBase()
        {
            ReaderType = TReaderType.rdr63M_V3;
            pProtocolType = TProtocolType.PR2;
            DFType = TDFType.df4MB;
			fOnCmd = false;
            fDefcmdRetry = 3;
			fIP = "192.168.0.101";
            fOnlineReConnectTimeOut = 5000;
			fPort = 6565;
			fTimeOut = 2000;
			fDefSelectTimeout = 500;
			fEncDeviceLoginKey = new byte [16];

            TxBuffer = new TTCPBuffer(); 
            TxBuffer.uaBuff = new byte[512];
			
			RxBuffer = new TTCPBuffer(); 
            RxBuffer.uaBuff = new byte[512];

            fOnlineThreadSleepTime = 10;
        }

        public int OnlineReConnectTimeOut
        {
            set
            {
                fOnlineReConnectTimeOut = value;
            }
            get
            {
                return fOnlineReConnectTimeOut;
            }
        }    
    
        public TReaderType ReaderType
        {
            set
            {
                fReaderType = value;
            }
            get
            {
                return fReaderType;
            }
        }

        public int OnlineThreadSleepTime
        {
            set
            {
                fOnlineThreadSleepTime = value;
            }
            get
            {
                return fOnlineThreadSleepTime;
            }
        }

        public TProtocolType pProtocolType
        {
            set
            {
                fProtocolType = value;
				switch (fProtocolType)
				{
                    case TProtocolType.PR0:			
						fTx_Protocol_Len = 17;
						fTx_TCP_Header_Pos = 0; // TCP_Header 2 byte 0..1
						fTx_TCP_Len_Pos = 2; // TCP_Len 2 byte 2..3
						fTx_Serial_Header_Pos = 4; // TCP_Header 2 byte 4..5
						fTx_Serial_Len_Pos = 6; // TCP_Len 2 byte 6..7
						fTx_Command_Pos = 8;
						fTx_SubCommand_Pos = 9;
                        //Sonra fTx_SessionID_Pos = 10; // SeeeionID 2
						fTx_Data_Start_Pos = 11;	
						fRx_Protocol_Len = 19;
						fRx_TCP_Header_Pos = 0;
						fRx_TCP_Len_Pos = 2;
						fRx_Serial_Header_Pos = 4;
						fRx_Serial_Len_Pos = 6;
                        //Sonra fRx_Command_Pos = 8;
                        //Sonra fRx_SubCommand_Pos = 9;
                        //Sonra fRx_SessionID_Pos = 10;
						fRx_Acknowledge_Pos = 11;
						fRx_Return_Value_Pos = 12;
						fRx_Data_Start_Pos = 13;					
					break;
                    case TProtocolType.PR1:
						fTx_Protocol_Len = 14;
						fTx_TCP_Header_Pos = 0; // TCP_Header 2 byte 0..1
						fTx_TCP_Len_Pos = 2; // TCP_Len 2 byte 2..3
						fTx_Serial_Header_Pos = 4; // TCP_Header 2 byte 4..5
						fTx_Serial_Len_Pos = 6; // TCP_Len 2 byte 6..7
						fTx_Command_Pos = 8;
						fTx_SubCommand_Pos = 9;
						fTx_Data_Start_Pos = 10;
						fRx_Protocol_Len = 16;
						fRx_TCP_Header_Pos = 0;
						fRx_TCP_Len_Pos = 2;
						fRx_Serial_Header_Pos = 4;
						fRx_Serial_Len_Pos = 6;
                        //Sonra fRx_Command_Pos = 8;
                        //Sonra fRx_SubCommand_Pos = 9;
						fRx_Acknowledge_Pos = 10;
						fRx_Return_Value_Pos = 11;
						fRx_Data_Start_Pos = 12;
					break;
                    case TProtocolType.PR2:
						fTx_Protocol_Len = 14;
						fTx_TCP_Header_Pos = 0; // TCP_Header 2 byte 0..1
						fTx_TCP_Len_Pos = 2; // TCP_Len 2 byte 2..3
						fTx_Serial_Header_Pos = 4; // TCP_Header 2 byte 4..5
						fTx_Serial_Len_Pos = 6; // TCP_Len 2 byte 6..7
						fTx_Command_Pos = 8;
						fTx_SubCommand_Pos = 9;
						fTx_Data_Start_Pos = 10;
						fRx_Protocol_Len = 16;
						fRx_TCP_Header_Pos = 0;
						fRx_TCP_Len_Pos = 2;
						fRx_Serial_Header_Pos = 4;
						fRx_Serial_Len_Pos = 6;
                        //Sonra fRx_Command_Pos = 8;
                        //Sonra fRx_SubCommand_Pos = 9;
						fRx_Acknowledge_Pos = 10;
						fRx_Return_Value_Pos = 11;
						fRx_Data_Start_Pos = 12;					
					break;	
				}
            }
            get
            {
                return fProtocolType;
            }
        }		

        public TDFType DFType
        {
            set
            {
                fDFType = value;
				if (fDFType == TDFType.df8MB)
					fDFPageSize = 1056;
				else
					fDFPageSize = 528;		
            }
            get
            {
                return fDFType;
            }
        }

        public string IP
        {
            set
            {
                fIP = value;
            }
            get
            {
                return fIP;
            }
        }

        public int Port
        {
            set
            {
                fPort = value;
            }
            get
            {
                return fPort;
            }
        }
         
		public int TimeOut  
        {
            set
            {
                fTimeOut = value;
            }
            get
            {
                return fTimeOut;
            }
        }

		public uint ReadTimeOut  
        {
            set
            {
                fDefSelectTimeout = value;
            }
            get
            {
                return fDefSelectTimeout;
            }
        }

		public int DeviceID  
        {
            set
            {
                fDeviceID = value;
            }
            get
            {
                return fDeviceID;
            }
        }
		
		public string DeviceName  
        {
            set
            {
                fDeviceName = value;
            }
            get
            {
                return fDeviceName;
            }
        }

		public string DeviceLoginKey  
        {

            set
            {
                int iErr;
                byte[] KeyData= new byte[16];
                fDeviceLoginKey = value;
                fEncDeviceLoginKey = HexToByte(fDeviceLoginKey);
                fProtocolType = pProtocolType;
                AES encDenc = new AES();

                switch (fProtocolType)
                {
                    case TProtocolType.PR0:
                        if (ToPrBytesFromHex(fDeviceLoginKey, ref KeyData, 0, 32))
                            encDenc.EncryptDeviceKey(KeyData, out fEncDeviceLoginKey);
                        else iErr = TErrors.INVALID_COMN_KEY;
                        break;

                    case TProtocolType.PR1:
                        if (ToPrBytesFromHex(fDeviceLoginKey, ref KeyData, 0, 32))
                        encDenc.EncryptDeviceKey(KeyData, out fEncDeviceLoginKey);
                        else
                            iErr = TErrors.INVALID_COMN_KEY;
                        break;

                    case TProtocolType.PR2:
                        if (ToPrBytesFromHex(fDeviceLoginKey, ref KeyData, 0, 32))
                            for (int i = 0; i <= 15; i++)
                            fEncDeviceLoginKey[i] = KeyData[i];
                            else
                        iErr = TErrors.INVALID_COMN_KEY;
                        break;
                    case TProtocolType.PR3:
                        //sonra yaýlacak
                        break;
                    default:
                        break;
                }



				//Sonra burada encyiption iþlemleri yapýlacak
				//fEncDeviceLoginKey Stringden Byte Dizizine Dönüþtürecek
            }
            get
            {
                return fDeviceLoginKey;
            }
        }

		public int CommandRetry  
        {
            set
            {
                fDefcmdRetry = value;
            }
            get
            {
                return fDefcmdRetry;
            }
        }

		public bool AutoConnect  
        {
            set
            {
                fAutoConnect = value;
            }
            get
            {
                return fAutoConnect;
            }
        }

		public bool Connected  
        {
            set
            {
				CheckConnection();
				if (fConnected != value)
			    {
                    if (value)
						DoConnect();
					else
						DoDisConnect();				
				}
            }
            get
            {
                return fConnected;
            }
        }

		public bool AutoRxEnabled  
        {
            set
            {
                fAutoRxEnabled = value;
            }
            get
            {
                return fAutoRxEnabled;
            }
        }
		
		public void SaveLogFile(object method, Exception exception)
		{
            string location = System.IO.Path.GetDirectoryName(Environment.GetCommandLineArgs()[0]) + @"\Logs\";
			try
			{
				using (StreamWriter sw = new StreamWriter(new FileStream(location + @"log"+fIP+".log", FileMode.Append, FileAccess.Write, FileShare.ReadWrite)))
				{
					sw.WriteLine(String.Format("{0} ({1}) - Method: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToLongTimeString(), method.ToString()));
					sw.WriteLine(exception.ToString()); sw.WriteLine("");
				}
			}
			catch (IOException)
			{
                if (!File.Exists(location + @"log" + fIP + ".log"))
				{
                    File.Create(location + @"log" + fIP + ".log");
				}
			}
		}

		public void SaveLogFile(object method, string Msg)
		{
            string location = System.IO.Path.GetDirectoryName(Environment.GetCommandLineArgs()[0]) + @"\Logs\";
			try
			{
                using (StreamWriter sw = new StreamWriter(new FileStream(location + @"log" + fIP + ".log", FileMode.Append, FileAccess.Write, FileShare.ReadWrite)))
				{
                    sw.WriteLine(String.Format("{0} ({1}) - Method: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToLongTimeString(), method.ToString()));
					sw.WriteLine(Msg); sw.WriteLine("");
				}
			}
			catch (IOException)
			{
                if (!File.Exists(location + @"log" + fIP + ".log"))
				{
                    File.Create(location + @"log" + fIP + ".log");
				}
			}
		}

        public ushort prMin(ushort AValueOne,ushort AValueTwo)
        {
            if (AValueOne > AValueTwo)
               return AValueTwo;
            else 
                return AValueOne;
        }

        public int prMin(int AValueOne, int AValueTwo)
        {
            if (AValueOne > AValueTwo)
                return AValueTwo;
            else
                return AValueOne;
        }

        public uint prMin(uint AValueOne, uint AValueTwo)
        {
            if (AValueOne > AValueTwo)
                return AValueTwo;
            else
                return AValueOne;
        }

        public ushort prMax(ushort AValueOne,ushort AValueTwo)
        {
            if (AValueOne < AValueTwo)
                return AValueTwo;
            else 
                return AValueOne;
        }

        public int prMax(int AValueOne, int AValueTwo)
        {
            if (AValueOne < AValueTwo)
                return AValueTwo;
            else
                return AValueOne;
        }

        public uint prMax(uint AValueOne, uint AValueTwo)
        {
            if (AValueOne < AValueTwo)
                return AValueTwo;
            else
                return AValueOne;
        }

        public int prLength(String ABuffer,int ALength = -1, int AIndex = 1)
        {
            int LAvailable;
            LAvailable = prMax (ABuffer.Length-AIndex+1, 0);
            if (ALength < 0)
                return LAvailable;
            else 
                return  prMin(LAvailable, ALength);
        }

        public int prLength (byte[] ABuffer,int ALength = -1, int AIndex = 1)
        {
            int LAvailable;
            LAvailable = prMax(ABuffer.Length-AIndex, 0);
            if (ALength < 0 )
                return LAvailable;
            else 
                return prMin(LAvailable, ALength);
        }    

        public  bool IsHex(IEnumerable<char> hexString)
        {
            return hexString.Select(currentCharacter =>
                        (currentCharacter >= '0' && currentCharacter <= '9') ||
                        (currentCharacter >= 'a' && currentCharacter <= 'f') ||
                        (currentCharacter >= 'A' && currentCharacter <= 'F')).All(isHexCharacter => isHexCharacter);
        }

        public byte[] HexToByte(string msg)
        {
            msg = msg.Replace(" ", "");
            byte[] comBuffer = new byte[msg.Length / 2];
            for (int i = 0; i < msg.Length; i += 2)
                comBuffer[i / 2] = (byte)Convert.ToByte(msg.Substring(i, 2), 16);
            return comBuffer;
        }

        public string ByteToHex(byte comByte)
        {
            StringBuilder builder = new StringBuilder(3);
            builder.Append(Convert.ToString(comByte, 16).PadLeft(2, '0'));
            return builder.ToString().ToUpper();
        }

        public string prBytesToHex(byte[] AValue,int AStartIndex = 0,int ALength = 1)
        {
            string RetStr;
            RetStr = "";
            for (int i = 0; i < ALength; i++)
                RetStr = RetStr + ByteToHex(AValue[AStartIndex+i]); 

            return RetStr;
        }

        public DateTime prBytesToDateTimeEx(byte[] AValue,int AStartIndex = 0)
        {
            int AHour = AValue[AStartIndex];
            int AMinute = AValue[AStartIndex+1];
            int ASecond  = AValue[AStartIndex+2];
            int ADay = AValue[AStartIndex+3];
            int AMonth = AValue[AStartIndex+4];
            int AYear = AValue[AStartIndex+5];
            DateTime TimeDate = new DateTime(AYear+2000,AMonth,ADay,AHour,AMinute,ASecond);
            return TimeDate;
        }

        public string prBytesToIPv4Str(byte[] AValue,int AStartIndex = 0)
        {
           string Ipstr;

            Ipstr = Convert.ToString(AValue[AStartIndex]) +".";
            Ipstr = Ipstr + Convert.ToString(AValue[AStartIndex + 1]) + ".";
            Ipstr = Ipstr + Convert.ToString(AValue[AStartIndex + 2]) + ".";
            Ipstr = Ipstr + Convert.ToString(AValue[AStartIndex + 3]);
            return Ipstr;
        }

        public string prByteToString(byte[] strValue,int AStartIndex,int ALength = -1)
        {
            int len;
            char ch;
            string Str = "";

            len = prLength(strValue, ALength, AStartIndex);

            for (int i = 0; i < len; i++)
            {
                switch (strValue[i+AStartIndex])
                {
                    case 208:
                        Str = Str + 'Ð';
                        break;
                    case 240:
                        Str = Str + 'ð';
                        break;
                    case 221:
                        Str = Str + 'Ý';
                        break;
                    case 253:
                        Str = Str + 'ý';
                        break;
                    case 220:
                        Str = Str + 'Ü';
                        break;
                    case 252:
                        Str = Str + 'ü';
                        break;
                    case 199:
                        Str = Str + 'Ç';
                        break;
                    case 231:
                        Str = Str + 'ç';
                        break;
                    case 222:
                        Str = Str + 'Þ';
                        break;
                    case 254:
                        Str = Str + 'þ';
                        break;
                    case 214:
                        Str = Str + 'Ö';
                        break;
                    case 246:
                        Str = Str + 'ö';
                        break;
                    default:
                        ch = Convert.ToChar(strValue[i + AStartIndex]);
                        Str = Str + ch;
                        break;
                }
            }
            return Str;
        }

        public Boolean prBytesToBoolean(byte[] AValue, int AStartIndex = 0)
        {
            return (AValue[AStartIndex] == 1);
        }

        public uint prBytesTouint(byte[] AValue, int AStartIndex = 0)
        {
            byte[] tmpValue = new byte[4];
            Array.Copy(AValue, AStartIndex, tmpValue, 0, 4);
            return BitConverter.ToUInt32(tmpValue, 0);
        }

        public ushort prBytesToushort(byte[] AValue, int AStartIndex = 0)
        {
            byte[] tmpValue = new byte[2];
            Array.Copy(AValue, AStartIndex, tmpValue, 0, 2);
            return BitConverter.ToUInt16(tmpValue, 0);
        }

        public byte PerioOrd(Char S)
        {
                switch (S)
                {
                    case 'Ð':
                        return  208;
                        //break;
                    case 'ð':
                        return  240;
                        //break;
                    case 'Ý':
                        return  221;
                        //break;
                    case 'ý':
                        return  253;
                        //break;
                    case 'Ü':
                        return  220;
                        //break;
                    case 'ü':
                        return  252;
                        //break;
                    case 'Ç':
                        return  199;
                        //break;
                    case 'ç':
                        return  231;
                        //break;
                    case 'Þ':
                        return  222;
                        //break;
                    case 'þ':
                        return  254;
                        //break;
                    case 'Ö':
                        return  214;
                        //break;
                    case 'ö':
                        return  246;
                        //break;
                    default:
                        return  Convert.ToByte(S);
                        //break; 
                }

        }

        //ipvstring
        public Boolean ToPrBytesfromIPv4Str(string AValue, ref byte[] data, int AStartIndex)
        {
            Boolean IpMi;

            string[] dizi = AValue.Split('.');

            if (isIP(AValue) == true)
            {
                IpMi = true;

                for (int i = 0; i < dizi.Length; i++)
                {
                    data[AStartIndex+i] = Convert.ToByte(dizi[i]);
                }
              
            }
            else { IpMi = false; }

            return IpMi;

        }


        public void ToPrBytes(string AValue, ref byte[] Data, int AStartIndex = 0, int ALength = 0)
        {
            int BufLen;
            int strLen;
            int fark;
            try
            {       
                if (ALength != 0)
                    BufLen = ALength;
                else
                    BufLen = AValue.Length;

                strLen = AValue.Length;
                if (strLen > BufLen) strLen = BufLen;
                fark = BufLen - strLen;

                for (int i = 0; i < strLen; i++)
                    Data[AStartIndex +i] = PerioOrd(AValue[i]);

                for (int i = 0; i < fark; i++)
                    Data[AStartIndex +i + strLen] = 0;
            }
            catch (Exception e)
            {
                //iErr = TErrors.EXCEPTION;
                SaveLogFile(MethodBase.GetCurrentMethod(), e);
            }
        }
        public void ToPrBytes(ulong AValue, ref byte[] Data,int AStartIndex = 0, int ALength = 0)
        {
            byte[] byteArray = BitConverter.GetBytes(AValue);
            if (ALength != 0)
                Array.Copy(byteArray, 0, Data, AStartIndex, ALength);
            else
                Array.Copy(byteArray, 0, Data, AStartIndex, byteArray.Length);
        }
        public void ToPrBytes(ushort AValue, ref byte[] Data, int AStartIndex = 0, int ALength = 0)
        {
            byte[] byteArray = BitConverter.GetBytes(AValue);
            if (ALength != 0)
                Array.Copy(byteArray, 0, Data, AStartIndex, ALength);
            else
                Array.Copy(byteArray, 0, Data, AStartIndex, byteArray.Length);
        }
        public void ToPrBytes(int AValue, ref byte[] Data, int AStartIndex = 0, int ALength = 0)
        {
            byte[] byteArray = BitConverter.GetBytes(AValue);
            if (ALength != 0)
                Array.Copy(byteArray, 0, Data, AStartIndex, ALength);
            else
                Array.Copy(byteArray, 0, Data, AStartIndex, byteArray.Length);
        }
        public void ToPrBytes(uint AValue, ref byte[] Data, int AStartIndex = 0, int ALength = 0)
        {
            byte[] byteArray = BitConverter.GetBytes(AValue);
            if (ALength != 0)
                Array.Copy(byteArray, 0, Data, AStartIndex, ALength);
            else
                Array.Copy(byteArray, 0, Data, AStartIndex, byteArray.Length);
        }
        public void ToPrBytes(Boolean AValue, ref byte[] Data, int AStartIndex = 0, int ALength = 0)
        {
            if (AValue)
                Data[AStartIndex] = 1;
            else
                Data[AStartIndex] = 0;
        }
        public void ToPrBytes(byte AValue, ref byte[] Data, int AStartIndex = 0, int ALength = 0)
        {
              Data[AStartIndex] = AValue;
        }
        public void ToPrBytes(TimeSpan AValue, ref byte[] Data, int AStartIndex = 0, int ALength = 0)
        {
            if (ALength == 3)
            {
                Data[AStartIndex] = (byte)AValue.Hours;
                Data[AStartIndex+1] = (byte)AValue.Minutes;
                Data[AStartIndex+2] = (byte)AValue.Seconds;
            }
            else
            {
                Data[AStartIndex] = (byte)AValue.Hours;
                Data[AStartIndex+1] = (byte)AValue.Minutes;
            }
        }
        public void ToPrBytes(DateTime AValue, ref byte[] Data, int AStartIndex = 0, int ALength = 0)
        {
            
           Data[AStartIndex] = (byte)AValue.Day;
           Data[AStartIndex + 1] = (byte)AValue.Month;
           Data[AStartIndex + 2] = (byte)(AValue.Year - 2000);
            
        }



        public Boolean ToPrBytesFromHex(string AValue, ref byte[] Data, int AStartIndex = 0, int ALength = 0)
        {
            int len;
            int md;

            if (ALength == 0)
                len = AValue.Length;
            else
                len = ALength;

            md = len % 2;
            if (md ==0 )
            {
                if (IsHex(AValue))
                {
                    int hexlen = len/2;
                    byte[] byteArray = new byte[hexlen];
                    byteArray = HexToByte(AValue);
                    for (int i = 0; i < hexlen; i++)
                        Data[AStartIndex + i] = byteArray[i];
                    return true;
                }
                else
                    return false;
            }
            else
              return false;

       }
       

        public byte ToByte(Boolean AValue)
        {
            if (AValue)
                return 1;
            else
                return 0;
        }

        public byte ByteToBitArray(byte[] AValue)
        {
            byte BytVal,TempVal,ReadVal;
            
            BytVal = 0;
            for (int i = 0; i < 8; i++)
            {
                ReadVal = AValue[i];
                if (i==0)
                    TempVal = ReadVal;
                else
                    TempVal = (byte)(ReadVal << i);
    
                BytVal = (byte)(TempVal | BytVal);

            }
            return BytVal;
        }

        public ulong DateTimeToUnix(DateTime AValue)
        {
            var timeSpan = (AValue - new DateTime(1970, 1, 1, 0, 0, 0));
            return (ulong)timeSpan.TotalSeconds;
        }
        /*
        public bool ToPrBytesFromHex(string AValue,out byte[] Data,int AStartIndex = 0,int ALength =0 )
        {
            byte[] tmpData;

         
            tmpData = HexToByte(AValue);

            for (int i = 0; i < tmpData.Length; i++)
                Data[AStartIndex+i] = tmpData[i];

            if (IsHex(AValue))
                return true;
            else
               return false;            
        }
        */
	}

    public partial class TCustomTcpRdr : TcpRdrBase
    {


        public int tcpSetWeekDayNames(TWeekDays WeekDays)
        {

            int iErr = 0;
            byte[] SendData = new byte[512];
            byte[] RecData = new byte[512];

            try
            {
                for (int i = 0; i <= 6; i++)
            {
                ToPrBytes(WeekDays.names[i],ref SendData,i*12,12);
                iErr = ExecuteCmd(2, 32, 32, 84, SendData, out RecData);
            }
            }
            catch (Exception hata)
            {
                
                SaveLogFile(MethodBase.GetCurrentMethod(), hata);
                iErr = TErrors.EXCEPTION;
            }

            return iErr;
        
        }


        public int tcpGetWeekDayNames(out TWeekDays WeekDays)
        {
            int iErr = 0;
            byte[] SendData = new byte[512];
            byte[] RecData = new byte[512];

            TWeekDays tmpSettings = new TWeekDays();
            WeekDays = tmpSettings;

                       
            try
            {

                iErr = ExecuteCmd(2, 31, 31, 0, SendData, out RecData );

                if (iErr==0)
                {
                    for (int i = 0; i <= 6; i++)
                    {
                        WeekDays.names[i] = prByteToString(RecData,i*12,12);
                    }
                }


            }
            catch (Exception hata)
            {

                SaveLogFile(MethodBase.GetCurrentMethod(), hata);
                iErr = TErrors.EXCEPTION;
            }

            return iErr;

        }


        protected int tcpReadPageData(ushort PageNo, out string HexValue)
        {
            int iErr = 0, LoopCnt;
            byte[] SendData = new byte[512];
            byte[] RecData = new byte[512];
            string tmpDataStr;
            HexValue = "";
            try
            {
                LoopCnt = fDFPageSize / 176;

                for (int i = 0; i < LoopCnt-1; i++)
                {
                    ToPrBytes(PageNo,ref SendData,0);
                    SendData[2] = (byte)i ;

                    iErr = ExecuteCmd(2, 33, 33, 3, SendData, out RecData );

                    if (iErr==0)
                    {
                        tmpDataStr = prBytesToHex(RecData,0,176);
                    }
                    else { break; }

                    if (iErr == 0)
                    {
                        HexValue = tmpDataStr;
                    }
                }

                

            }
            catch (Exception hata)
            {
                SaveLogFile(MethodBase.GetCurrentMethod(), hata);
                iErr = TErrors.EXCEPTION;
            }

            return iErr;
        }


        protected int tcpWritePageData(ushort PageNo, string HexValue)
        {
            int iErr=0, StrLen, Start, LoopCnt;
            byte[] SendData = new byte[512];
            byte[] RecData = new byte[512];
            string tmpDataStr;

            if (IsHex(HexValue))
            {
                StrLen = HexValue.Length;

                if (StrLen == (fDFPageSize * 2)) 
                { 
                
                    LoopCnt =  StrLen / 352;

                    for (int i = 0; i < LoopCnt -1; i++)
                    {
                      tmpDataStr = "";
                      ToPrBytes(PageNo,ref SendData,0);
                      SendData[2] = (byte)i ;

                      if (i==0)
                      {
                          Start = 0;
                      }
                      else
                      {
                          Start = i*352 + 1;
                      }

                         tmpDataStr = HexValue.Substring(Start, 352);  //copy(HexValue,Start,352);
                         ToPrBytesFromHex(tmpDataStr,ref SendData,3);
                         iErr = ExecuteCmd(2,34,34,179, SendData, out RecData );

                         if (iErr != 0)
                         {
                             break;
                         }
              
                    }


                }
                else
                {
                    iErr = TErrors.ERR_WRONGPAGESIZE;
                }
            }
            else
            {
                iErr =  TErrors.ERR_WRONHEXDATA;
            }


            return iErr;


       }


        public int tcpSetMACAddress(String MacAddr)
        {
            int iErr = 0;
            byte[] SendData = new byte[512];
            byte[] RecData = new byte[512];
            MacAddr = "";

            try
            {
                ToPrBytesFromHex(MacAddr,ref SendData,0,0);
                iErr = ExecuteCmd(2, 9, 9, 6, SendData, out RecData );
            }
            catch (Exception hata)
            {

                SaveLogFile(MethodBase.GetCurrentMethod(), hata);
                iErr = TErrors.EXCEPTION;
            }

            return iErr;
        }


        public string GetMACAddress()
        {
            String MACAddressStr="";


            if (tcpGetMACAddress(out MACAddressStr) == 0)
            {
                return MACAddressStr;
            }
            else {

                return "*";
            }


            
        }


        protected  int tcpGetMACAddress(out String MacAddr)
        {

            int iErr = 0;
            byte[] SendData = new byte[512];
            byte[] RecData = new byte[512];
            MacAddr = "";

            try
            {
                iErr = ExecuteCmd(2, 8, 8, 0,  SendData, out RecData );

                if (iErr==0)
                {
                    MacAddr = prBytesToHex(RecData,0,6);
                }

            }
            catch (Exception hata)
            {

                SaveLogFile(MethodBase.GetCurrentMethod(), hata);
                iErr = TErrors.EXCEPTION;
            }

            return iErr;


        }






        public int tcpSetWebPassword(string WebPassword)
        {
            int iErr = 0;
            byte[] SendData = new byte[512];
            byte[] RecData = new byte[512];

            ToPrBytes(WebPassword,ref SendData, 0, 20);
            try
            {
                iErr = ExecuteCmd(2, 13, 13, 20, SendData, out RecData);
            }
            catch (Exception hata)
            {
                SaveLogFile(MethodBase.GetCurrentMethod(), hata);
                iErr = TErrors.EXCEPTION;
            }       
            return iErr;        
        }


        public int tcpGetWebPassword(out string WebPassword)
        {
            int iErr = 0;
            byte[] SendData = new byte[512];
            byte[] RecData = new byte[512];
            WebPassword = "";

            try
            {
                iErr = ExecuteCmd(2, 12, 12, 0, SendData, out RecData);
                if (iErr == 0)
                {
                    WebPassword = prByteToString(RecData, 0, 20);
                }

            }
            catch (Exception hata)
            {

                SaveLogFile(MethodBase.GetCurrentMethod(), hata);
                iErr = TErrors.EXCEPTION;
            }


            return iErr;

        
        }




        protected int tcpSetLCDMessagesFactoryDefault()
        { 
            int iErr = 0;
            byte[] SendData = new byte[512];
            byte[] RecData = new byte[512];


            try
            {
                iErr = ExecuteCmd(2, 36, 36, 0, SendData, out RecData );
            }
            catch (Exception hata)
            {
                SaveLogFile(MethodBase.GetCurrentMethod(), hata);
                iErr = TErrors.EXCEPTION;
            }


            return iErr;

        }

       


        protected int tcpGetLCDMessages(int ID ,out  TLcdScreen LcdScreenMsg)
        {
            int iErr = 0;
            byte[] SendData = new byte[512];
            byte[] RecData = new byte[512];

            TLcdScreen tmpSettings = new TLcdScreen();
            LcdScreenMsg = tmpSettings;

            ToPrBytes((int)ID, ref SendData, 0);

            try
            {
              iErr = ExecuteCmd(2, 26, 26, 2, SendData, out RecData);


              if (iErr==0)
              {
                  tmpSettings.ID = prBytesToushort(RecData, 0);
                  tmpSettings.HeaderType = RecData[2];
                  tmpSettings.Caption = prByteToString(RecData, 3, 21);
                  tmpSettings.Line[0].Text = prByteToString(RecData, 24, 21);
                  tmpSettings.Line[0].X = RecData[45];
                  tmpSettings.Line[0].Y = RecData[46];
                  tmpSettings.Line[0].Alligment = RecData[47];
                  tmpSettings.Line[1].Text = prByteToString(RecData, 48, 21);
                  tmpSettings.Line[1].X = RecData[69];
                  tmpSettings.Line[1].Y = RecData[70];
                  tmpSettings.Line[1].Alligment = RecData[71];
                  tmpSettings.Line[2].Text = prByteToString(RecData, 72, 21);
                  tmpSettings.Line[2].X = RecData[93];
                  tmpSettings.Line[2].Y = RecData[94];
                  tmpSettings.Line[2].Alligment = RecData[95];
                  tmpSettings.Line[3].Text = prByteToString(RecData, 96, 21);
                  tmpSettings.Line[3].X = RecData[117];
                  tmpSettings.Line[3].Y = RecData[118];
                  tmpSettings.Line[3].Alligment = RecData[119];
                  tmpSettings.Line[4].Text = prByteToString(RecData, 120, 21);
                  tmpSettings.Line[4].X = RecData[141];
                  tmpSettings.Line[4].Y = RecData[142];
                  tmpSettings.Line[4].Alligment = RecData[143];
                  tmpSettings.FooterType = RecData[144];
                  tmpSettings.Footer = prByteToString(RecData, 145, 21);
                  tmpSettings.RL_Time1 = prBytesToushort(RecData, 166);
                  tmpSettings.RL_Time2 = prBytesToushort(RecData, 168);
                  tmpSettings.BZR_time = prBytesToushort(RecData, 170);
                  tmpSettings.IsBlink = prBytesToBoolean(RecData, 172);
                  tmpSettings.ScreenDuration = prBytesToushort(RecData, 173);
                  tmpSettings.FontType = RecData[175];
                  tmpSettings.LineCount = RecData[176];

              LcdScreenMsg = tmpSettings;
              }

              
            }
            catch (Exception hata)
            {

                SaveLogFile(MethodBase.GetCurrentMethod(), hata);
                iErr = TErrors.EXCEPTION;
            }



            return iErr;
        }




        protected int tcpSetLCDMessages(TLcdScreen LcdScreenMsg)
        {

            int iErr = 0;
            byte[] SendData = new byte[512];
            byte[] RecData = new byte[512];

            try
            {
                ToPrBytes(LcdScreenMsg.ID, ref SendData, 0);
                SendData[2] = LcdScreenMsg.HeaderType;
                ToPrBytes(LcdScreenMsg.Caption, ref SendData, 3, 21);
                ToPrBytes(LcdScreenMsg.Line[0].Text,ref  SendData, 24, 21);
                SendData[45] = LcdScreenMsg.Line[0].X;
                SendData[46] = LcdScreenMsg.Line[0].Y;
                SendData[47] = LcdScreenMsg.Line[0].Alligment;
                ToPrBytes(LcdScreenMsg.Line[1].Text,ref  SendData, 48, 21);
                SendData[69] = LcdScreenMsg.Line[1].X;
                SendData[70] = LcdScreenMsg.Line[1].Y;
                SendData[71] = LcdScreenMsg.Line[1].Alligment;
                ToPrBytes(LcdScreenMsg.Line[2].Text,ref SendData, 72, 21);
                SendData[93] = LcdScreenMsg.Line[2].X;
                SendData[94] = LcdScreenMsg.Line[2].Y;
                SendData[95] = LcdScreenMsg.Line[2].Alligment;
                ToPrBytes(LcdScreenMsg.Line[3].Text, ref SendData, 96, 21);
                SendData[117] = LcdScreenMsg.Line[3].X;
                SendData[118] = LcdScreenMsg.Line[3].Y;
                SendData[119] = LcdScreenMsg.Line[3].Alligment;
                ToPrBytes(LcdScreenMsg.Line[4].Text,ref SendData, 120, 21);
                SendData[141] = LcdScreenMsg.Line[4].X;
                SendData[142] = LcdScreenMsg.Line[4].Y;
                SendData[143] = LcdScreenMsg.Line[4].Alligment;
                SendData[144] = LcdScreenMsg.FooterType;
                ToPrBytes(LcdScreenMsg.Footer,ref  SendData, 145, 21);
                ToPrBytes(LcdScreenMsg.RL_Time1,ref SendData,166);
                ToPrBytes(LcdScreenMsg.RL_Time2,ref SendData,168);
                ToPrBytes(LcdScreenMsg.BZR_time,ref SendData,170);
                ToPrBytes(LcdScreenMsg.IsBlink,ref SendData,172);
                ToPrBytes(LcdScreenMsg.ScreenDuration, ref SendData,173);
                SendData[175] = LcdScreenMsg.FontType;
                SendData[176] = LcdScreenMsg.LineCount;

                iErr = ExecuteCmd(2, 27, 27, 177, SendData, out RecData);

                
            }
            catch (Exception hata)
            {

                SaveLogFile(MethodBase.GetCurrentMethod(), hata);
                iErr = TErrors.EXCEPTION;
            }


            return iErr;

        }


        protected int tcpGetSerialPortBaudrateSettings(out byte SerailAppType , out byte Serial0, out byte Serial1)
        {
            int iErr = 0;
            byte[] SendData = new byte[512];
            byte[] RecData = new byte[512];
            Serial0 = 0;
            Serial1 = 0;
            SerailAppType = 0;
            try
            {
                 iErr = ExecuteCmd(2, 38, 38, 0, SendData, out  RecData);

                 if (iErr ==0)
                 {
                     Serial0 = RecData[0];
                     Serial1 = RecData[1];
                     SerailAppType = RecData[2];
                 }

            }
            catch (Exception hata)
            {
                
                SaveLogFile(MethodBase.GetCurrentMethod(), hata);
            }

            return iErr;
        
        }



        protected int tcpSetSerialPortBaudrateSettings(byte SerailAppType , byte Serial0, byte Serial1)
        {
            int iErr = 0;
            byte[] SendData = new byte[512];
            byte[] RecData = new byte[512];

            SendData[0] = Serial0;
            SendData[1] = Serial1;
            SendData[2] = SerailAppType;


            try
            {
                iErr = ExecuteCmd(2, 39, 39, 3, SendData, out  RecData);
            }
            catch (Exception hata)
            {
                
                SaveLogFile(MethodBase.GetCurrentMethod(), hata);
            }

            return iErr;

        }


        protected int tcpWriteCardBlockData(Byte SectorNo, Byte BlockNo, Byte KeyType, byte[] ValueBuff)
        {

            int iErr = 0;
            byte[] SendData = new byte[512];
            byte[] RecData = new byte[512];


            try
            {

                SendData[0] = (byte)(SectorNo*4+BlockNo);
                SendData[1] = KeyType;

                for (int i = 0; i < 16; i++)
                {
                    SendData[i+2] = ValueBuff[i];
                }

                iErr = ExecuteCmd(2, 41, 41, 18, SendData, out RecData );

            }
            catch (Exception hata)
            {
                
                SaveLogFile(MethodBase.GetCurrentMethod(), hata);
            }

            return iErr;

        }


        protected int tcpReadCardBlockData(Byte SectorNo, Byte BlockNo, Byte KeyType,  out byte[] ValueBuff)
        {

            int iErr = 0;
            byte[] SendData = new byte[512];
            byte[] RecData = new byte[512];

            ValueBuff = new byte[16];


            try
            {
                SendData[0] = (byte)(SectorNo * 4 + BlockNo);
                SendData[1] = KeyType;
                iErr = ExecuteCmd(2, 40, 40, 2,SendData, out RecData);

                if (iErr==0)
                {

                    for (int i = 0; i < 16; i++)
                    {
                        ValueBuff[i] = RecData[i];
                    }

                }
            }
            catch (Exception hata)
            {

                SaveLogFile(MethodBase.GetCurrentMethod(), hata);
            }


            return iErr;

        }

        
        protected int tcpSetDeviceClientTCPSettings(TClientTCPSettings rSettings)
        {
            int iErr = 0;
            byte[] SendData = new byte[512];
            byte[] RecData = new byte[512];


            try
            {

                if (!ToPrBytesfromIPv4Str(rSettings.IPAdress, ref SendData, 0) == true)
                {
                    iErr = TErrors.INVALID_IP_ADRESS;
                }
                else
                {
                    if (iErr == 0)
                    {
                        ToPrBytes(rSettings.Port, ref SendData, 4);
                        iErr = ExecuteCmd(2, 30, 30, 6, SendData, out  RecData);
                    }

                }

            }
            catch (Exception hata)
            {

                SaveLogFile(MethodBase.GetCurrentMethod(), hata);
            }




            return iErr;
        }






        protected int tcpGetDeviceClientTCPSettings(out TClientTCPSettings rSettings)
        {
            int iErr = 0;
            byte[] SendData = new byte[512];
            byte[] RecData = new byte[512];

            TClientTCPSettings tmpSettings = new TClientTCPSettings();
            rSettings = tmpSettings;

            try
            {
                iErr = ExecuteCmd(2, 29, 29, 0, SendData, out RecData);

                if (iErr == 0)
                {
                    rSettings.IPAdress = prBytesToIPv4Str(RecData, 0);
                    rSettings.Port = prBytesToushort(RecData, 4);
                }

            }
            catch (Exception hata)
            {

                SaveLogFile(MethodBase.GetCurrentMethod(), hata);
            }

            return iErr;

        }







        protected int tcpSetDeviceUDPSettings(TUDPSettings rSettings)
        {
            int iErr = 0;
            byte[] SendData = new byte[512];
            byte[] RecData = new byte[512];


            try
            {

                if (!ToPrBytesfromIPv4Str(rSettings.RemUDPAdress, ref SendData, 2) == true){iErr = TErrors.INVALID_IP_ADRESS;}
                else {

                    ToPrBytes(rSettings.UDPIsActive, ref SendData, 0);
                    ToPrBytes(rSettings.UDPLogIsActive, ref SendData, 1);
                    ToPrBytes(rSettings.UDPPort, ref SendData, 6);

                    iErr = ExecuteCmd(2, 7, 7, 10, SendData, out RecData);

                }

            }
            catch (Exception hata)
            {

                SaveLogFile(MethodBase.GetCurrentMethod(), hata);
                iErr = TErrors.EXCEPTION;
            }

            return iErr;

        }
    


   
        protected int tcpGetDeviceUDPSettings(out TUDPSettings rSettings)
        {
            int iErr = 0;
            byte[] SendData = new byte[512];
            byte[] RecData = new byte[512];

            TUDPSettings tmpSettings = new TUDPSettings();
            rSettings = tmpSettings;
            
            iErr = ExecuteCmd(2, 6, 6, 0, SendData, out RecData);

            try
            {

                if (iErr == 0)
                {
                    rSettings.UDPIsActive = prBytesToBoolean(RecData, 0);
                    rSettings.UDPLogIsActive = prBytesToBoolean(RecData, 1);
                    rSettings.RemUDPAdress = prBytesToIPv4Str(RecData, 2);
                    rSettings.UDPPort = prBytesToushort(RecData, 6);
                }

            }
            catch (Exception hata)
            {
                iErr = TErrors.EXCEPTION;
                SaveLogFile(MethodBase.GetCurrentMethod(), hata);
                
            }

           
            return iErr;

        }

        

        protected int tcpSetDeviceTCPSettings(TTCPSettings rSettings)
        {

            int iErr = 0;
            byte[] SendData = new byte[512];
            byte[] RecData = new byte[512];

            try
            {

                if (!ToPrBytesfromIPv4Str(rSettings.IPAdress,ref SendData,0)==true){ iErr = TErrors.INVALID_IP_ADRESS; }
                if (!ToPrBytesfromIPv4Str(rSettings.DefGetway, ref SendData, 4) == true) { iErr = TErrors.INVALID_IP_ADRESS; } 
                if (!ToPrBytesfromIPv4Str(rSettings.NetMask, ref SendData ,8)==true) {iErr = TErrors.INVALID_IP_ADRESS;}
                if (!ToPrBytesfromIPv4Str(rSettings.PriDNS, ref SendData, 12) == true) { iErr = TErrors.INVALID_IP_ADRESS;}
                if (!ToPrBytesfromIPv4Str(rSettings.SecDNS, ref SendData, 16) == true) { iErr = TErrors.INVALID_IP_ADRESS; }
                if (!ToPrBytesfromIPv4Str(rSettings.RemIpAdress, ref SendData, 22) == true) { iErr = TErrors.INVALID_IP_ADRESS; }


                if (iErr==0)
                {
                    ToPrBytes(rSettings.Port, ref SendData, 20);
                    ToPrBytes(rSettings.Port, ref SendData, 26);
                    ToPrBytes(rSettings.ConnectOnlyRemIpAdress, ref SendData, 27);

                    switch (rSettings.ProtocolType)
                    {
                        case TProtocolType.PR0:
                            SendData[28] = 0;
                            break;
                        case TProtocolType.PR1:
                            SendData[28] = 1;
                            break;
                        case TProtocolType.PR2:
                            SendData[28] = 2;
                            break;
                        case TProtocolType.PR3:
                            SendData[28] = 3;
                            break;
                        default:
                            break;
                    }

                    iErr = ExecuteCmd(2, 5, 5, 29, SendData, out RecData);
                   

                }

            }
            catch (Exception hata)
            {
                iErr = TErrors.EXCEPTION;
                SaveLogFile(MethodBase.GetCurrentMethod(), hata);
                
            }

            return iErr;

        
        }


        protected int tcpSetDeviceGeneralSettings(TGeneralDeviceSettins rSettings)
        {

            int iErr = 0;
            byte[] SendData = new byte[512];
            byte[] RecData = new byte[512];


            try
            {

                ToPrBytes(rSettings.DefaultScreenTxt1,ref SendData, 0,16);
                ToPrBytes(rSettings.DefaultScreenTxt2, ref SendData, 16,16);
                SendData[32] =  rSettings.CardReadBeepTime;

                if (rSettings.TrOut1Type == TrOutType.NrOpen)
                { SendData[33] = 0; }
                else { SendData[33] = 1; }

                if (rSettings.TrOut2Type == TrOutType.NrOpen)
                { SendData[34] = 0; }
                else { SendData[34] = 1; }

                switch (rSettings.IdleScreenType)
                {
                    case TIdleScreenType.stText:
                        SendData[35] = 0;
                        break;
                    case TIdleScreenType.stLogo:
                        SendData[35] = 1;
                        break;
                    default:
                        break;
                }


                ToPrBytes(rSettings.DailyRebootEnb, ref SendData, 36);
                SendData[37] = (byte)rSettings.RebootTime.Hour;
                SendData[38] = (byte)rSettings.RebootTime.Minute;
                ToPrBytes(rSettings.DevNo, ref SendData,39);
                ToPrBytes(rSettings.Backlight, ref SendData, 41);
                ToPrBytes(rSettings.Contrast, ref SendData, 43);
                ToPrBytes(rSettings.CardReadTimeOut, ref SendData, 45);
                ToPrBytes(rSettings.VariableClearTimeout, ref SendData, 47);
                ToPrBytes(rSettings.DefaultScreenFontType, ref SendData, 49);
                ToPrBytes(rSettings.CardReadDelay, ref SendData, 50);

                for (int i = 0; i < 10; i++)
                    SendData[i + 51] = 0;

                iErr = ExecuteCmd(2, // CmdNo
                                  3, // SubCmdNo
                                  3, // Acknowledge
                                  60, // DataLen
                                  SendData, out RecData, 100 // SelectTimeOut
                                  );
                }

            
            catch (Exception hata)
            {
                
                iErr = TErrors.EXCEPTION;
                SaveLogFile(MethodBase.GetCurrentMethod(), hata);
            }

            return iErr;
        }
        

        protected int tcpGetDeviceTCPSettings(out TDeviceTCPSettings rSettings)
        {
            int iErr = 0;
            byte[] SendData = new byte[512];
            byte[] RecData = new byte[512];


            TDeviceTCPSettings tmpSettings = new TDeviceTCPSettings();

            rSettings = tmpSettings;

           
            try
            {
                iErr = ExecuteCmd(2, // CmdNo
                        4, // SubCmdNo
                        4, // Acknowledge
                        0, // DataLen
                        SendData, out RecData, 100 // SelectTimeOut
                        );


                if (iErr ==0)
                {
                    tmpSettings.IPAdress = prBytesToIPv4Str(RecData, 0);
                    tmpSettings.DefGetway = prBytesToIPv4Str(RecData, 4);
                    tmpSettings.NetMask = prBytesToIPv4Str(RecData, 8);
                    tmpSettings.PriDNS = prBytesToIPv4Str(RecData, 12);
                    tmpSettings.SecDNS = prBytesToIPv4Str(RecData, 16);
                    tmpSettings.Port = prBytesToushort(RecData,20);
                    tmpSettings.RemIpAdress = prBytesToIPv4Str(RecData, 22);
                    tmpSettings.DHCP = prBytesToBoolean(RecData, 26);
                    tmpSettings.ConnectOnlyRemIpAdress = prBytesToBoolean(RecData, 27);
                    

                    switch (RecData[28])
                    {

                        case 0: { tmpSettings.ProtocolType = TProtocolType.PR0; break  ;}
                        case 1: { tmpSettings.ProtocolType = TProtocolType.PR1; break  ;}
                        case 2: { tmpSettings.ProtocolType = TProtocolType.PR2; break  ;}

                        default:
                        break;
                    }
                    tmpSettings.ServerEchoTimeOut = RecData[29];
                    rSettings = tmpSettings;
                }

            }
            catch (Exception hata)
            {
                iErr = TErrors.EXCEPTION;
                SaveLogFile(MethodBase.GetCurrentMethod(), hata );
            }

            return iErr;
        }
            

        protected int tcpGetDeviceGeneralSettings(out TGeneralDeviceSettins rSettings)
        {
            int iErr = 0;
            byte[] SendData = new byte[512];
            byte[] RecData = new byte[512];

            TGeneralDeviceSettins tmpSettings = new TGeneralDeviceSettins();
            rSettings = tmpSettings;

            try
            {

                iErr = ExecuteCmd(2, // CmdNo
                        2, // SubCmdNo
                        2, // Acknowledge
                        0, // DataLen
                        SendData, out RecData, 100 // SelectTimeOut
                        );
                if (iErr == 0)
                {
                    tmpSettings.DefaultScreenTxt1 = prByteToString(RecData,0,16);
                    tmpSettings.DefaultScreenTxt2 =prByteToString(RecData,16,16);
                    tmpSettings.CardReadBeepTime = RecData[32];
                    if (RecData[33] == 0) 
                      tmpSettings.TrOut1Type = TrOutType.NrOpen;
                    else
                      tmpSettings.TrOut1Type = TrOutType.NrClosed;
                    if (RecData[34] == 0) 
                      tmpSettings.TrOut2Type = TrOutType.NrOpen;
                    else
                      tmpSettings.TrOut2Type = TrOutType.NrClosed;
                    if (RecData[35] == 0 )
                      tmpSettings.IdleScreenType = TIdleScreenType.stText;
                    else
                      tmpSettings.IdleScreenType = TIdleScreenType.stLogo;
                    tmpSettings.DailyRebootEnb = prBytesToBoolean(RecData,36);
                    //tmpSettings.RebootTime := EncodeTime(RecData[37],RecData[38],0,0);

                    tmpSettings.RebootTime = new DateTime(2000, 1, 1, RecData[37], RecData[38], 0);

                    tmpSettings.DevNo = prBytesToushort(RecData,39);
                    tmpSettings.Backlight = prBytesToushort(RecData, 41);
                    tmpSettings.Contrast = prBytesToushort(RecData, 43);
                    tmpSettings.CardReadTimeOut = prBytesToushort(RecData, 45);
                    tmpSettings.VariableClearTimeout = prBytesToushort(RecData, 47);
                    tmpSettings.DefaultScreenFontType = RecData[49];
                    tmpSettings.CardReadDelay = RecData[50];
                    rSettings = tmpSettings;
                }
            }
            catch (Exception e)
            {
                iErr = TErrors.EXCEPTION;
                SaveLogFile(MethodBase.GetCurrentMethod(), e);
            }
            return iErr;

        }



        protected int tcpGetDeviceWorkModeSettings(out TWorkModeSettings rSettings) // CMD 2.10
        {
            int iErr = 0;
            byte[] SendData = new byte[512];
            byte[] RecData = new byte[512];

            TWorkModeSettings tmpSettings = new TWorkModeSettings();
            rSettings = tmpSettings;

            try
            {

                iErr = ExecuteCmd(2, // CmdNo
                        10, // SubCmdNo
                        10, // Acknowledge
                        0, // DataLen
                        SendData, out RecData, 100 // SelectTimeOut
                        );
                if (iErr == 0)
                {
                    switch (RecData[0])
                    {
                        case 0: tmpSettings.WorkingMode = TWorkingMode.wmOffline; break;
                        case 1: tmpSettings.WorkingMode = TWorkingMode.wmOfflineCard; break;
                        case 2: tmpSettings.WorkingMode = TWorkingMode.wmTCPOnline; break;
                        case 3: tmpSettings.WorkingMode = TWorkingMode.wmUDPOnline; break;
                    }

                    tmpSettings.OfflineModePermission = prBytesToBoolean(RecData, 1);
                    tmpSettings.ServerAnswerTimeOut = prBytesTouint(RecData, 2);
                    tmpSettings.OfflineOnlineMode = (TOnlineCardWorkMode)RecData[6];
                    //for I := 0 to 5 do rSettings.RFU[i] := RecData[i+6];
                    rSettings = tmpSettings;
                }
            }
            catch (Exception e)
            {
                iErr = TErrors.EXCEPTION;
                SaveLogFile(MethodBase.GetCurrentMethod(), e);
            }
            return iErr;
        }

        protected int tcpSetDeviceWorkModeSettings(TWorkModeSettings rSettings) // CMD 2.11
        {
            int iErr = 0;
            byte[] SendData = new byte[512];
            byte[] RecData = new byte[512];

            try
            {
                    switch (rSettings.WorkingMode)
                    {
                        case TWorkingMode.wmOffline: SendData[0] = 0; break;
                        case TWorkingMode.wmOfflineCard: SendData[0] = 1; break;
                        case TWorkingMode.wmTCPOnline: SendData[0] = 2; break;
                        case TWorkingMode.wmUDPOnline: SendData[0] = 3; break;
                    }
                    ToPrBytes(rSettings.OfflineModePermission,ref SendData,1);
                    ToPrBytes(rSettings.ServerAnswerTimeOut,ref SendData,2);
                    ToPrBytes((byte)rSettings.OfflineOnlineMode, ref SendData, 6);


                for (int i = 0; i < 6; i++)
                        SendData[i+6] = 0;

                iErr = ExecuteCmd(2, // CmdNo
                        11, // SubCmdNo
                        11, // Acknowledge
                        12, // DataLen
                        SendData, out RecData, 100 // SelectTimeOut
                        );
            }
            catch (Exception e)
            {
                iErr = TErrors.EXCEPTION;
                SaveLogFile(MethodBase.GetCurrentMethod(), e);
            }
            return iErr;
        }

        protected int tcpSetDeviceFactoryDefault(Boolean ResetIP) // CMD 2.14
        {
            int iErr = 0;
            byte[] SendData = new byte[512];
            byte[] RecData = new byte[512];
            
            try
            {
                if (ResetIP)
                    SendData[0] = 1;
                else
                    SendData[0] = 0;

                iErr = ExecuteCmd(2, // CmdNo
                        14, // SubCmdNo
                        14, // Acknowledge
                        1, // DataLen
                        SendData, out RecData, 100 // SelectTimeOut
                        );
            }
            catch (Exception e)
            {
                iErr = TErrors.EXCEPTION;
                SaveLogFile(MethodBase.GetCurrentMethod(), e);
            }
            return iErr;

        }

        protected int tcpGetSerialNumber(out byte[] SerialArr) // CMD 2.15
        {
            int iErr = 0;
            byte[] SendData = new byte[512];
            byte[] RecData = new byte[512];

            byte[] OutData = new byte[16];
            SerialArr = OutData;
            
            try
            {
                SerialArr = RecData;

                iErr = ExecuteCmd(2, // CmdNo
                        15, // SubCmdNo
                        15, // Acknowledge
                        0, // DataLen
                        SendData, out RecData, 100 // SelectTimeOut
                        );
                if (iErr == 0)
                {
                    for (int i = 0; i < 15; i++)
                        OutData[i] = RecData[i];
                }
                SerialArr = OutData;

            }
            catch (Exception e)
            {
                iErr = TErrors.EXCEPTION;
                SaveLogFile(MethodBase.GetCurrentMethod(), e);
            }
            return iErr;
        }

        protected int tcpSetSerialNumber(byte[] SerialArr) // CMD 2.16
        {
            int iErr = 0;
            byte[] SendData = new byte[512];
            byte[] RecData = new byte[512];

            try
            {
                for (int i = 0; i < 15; i++)
                   SendData[i] = SerialArr[i];

                iErr = ExecuteCmd(2, // CmdNo
                        16, // SubCmdNo
                        16, // Acknowledge
                        16, // DataLen
                        SendData, out RecData // SelectTimeOut
                        );
            }
            catch (Exception e)
            {
                iErr = TErrors.EXCEPTION;
                SaveLogFile(MethodBase.GetCurrentMethod(), e);
            }
            return iErr;
        }

        protected int tcpReboot()
        {
            int iErr = 0;
            byte[] SendData = new byte[512];
            byte[] RecData = new byte[512];

            try
            {
                iErr = ExecuteCmd(2, // CmdNo
                        17, // SubCmdNo
                        17, // Acknowledge
                        0, // DataLen
                        SendData, out RecData, 100 // SelectTimeOut
                        );
            }
            catch (Exception e)
            {
                iErr = TErrors.EXCEPTION;
                SaveLogFile(MethodBase.GetCurrentMethod(), e);
            }
            return iErr;
        }

        protected int tcpGetFwVwersion(out string fWVersion) // CMD 2.18
        {
            int iErr = 0;
            byte[] SendData = new byte[512];
            byte[] RecData = new byte[512];
            
            fWVersion = "";
            try
            {
                iErr = ExecuteCmd(2, // CmdNo
                        18, // SubCmdNo
                        18, // Acknowledge
                        0, // DataLen
                        SendData, out RecData, 100 // SelectTimeOut
                        );
                if (iErr == 0)
                {
                    fWVersion = prByteToString(RecData,0);
                }

            }
            catch (Exception e)
            {
                iErr = TErrors.EXCEPTION;
                SaveLogFile(MethodBase.GetCurrentMethod(), e);
            }
            return iErr;
        }

        protected int tcpSetDateTime(DateTime dt) // CMD 2.19
        {
            int iErr = 0;
            byte[] SendData = new byte[512];
            byte[] RecData = new byte[512];

            try
            {
                if (ReaderType == TReaderType.rdr63M_V5)
                {
                    ToPrBytes(DateTimeToUnix(dt), ref SendData, 0);
                }
                else
                {                    
                    SendData[0] = (byte)dt.Hour;
                    SendData[1] = (byte)dt.Minute;
                    SendData[2] = (byte)dt.Second;
                    SendData[3] = (byte)dt.Day;
                    SendData[4] = (byte)dt.Month;
                    SendData[5] = (byte)(dt.Year - 2000);

                }

                iErr = ExecuteCmd(2, // CmdNo
                        19, // SubCmdNo
                        19, // Acknowledge
                        6, // DataLen
                        SendData, out RecData, 100 // SelectTimeOut
                        );
            }
            catch (Exception e)
            {
                iErr = TErrors.EXCEPTION;
                SaveLogFile(MethodBase.GetCurrentMethod(), e);
            }
            return iErr;
        }


        protected int tcpSetMfrKeyList(TMfrKeyList KeyList)
        {
            int iErr = 0;
            byte[] SendData = new byte[512];
            byte[] RecData = new byte[512];
            byte[] KeyData = new byte[192];

            AES n = new AES();
                try
                {
                    for (int i = 0; i < 16; i++)
                    {
                        for (int j = 0; j < 6; j++)
                        {
                            KeyData[i*12+j] = KeyList.Sector[i].KeyA[j];
                            KeyData[i*12+j+6] = KeyList.Sector[i].KeyB[j];
                        }
                    }

                    iErr = n.EncryptMfrKeyData(KeyData, out SendData);

                    if (iErr==0)
                    {
                     iErr = ExecuteCmd(2,21, 21, 192, SendData, out RecData );
                    }

                }
                catch (Exception hata)
                {

                    iErr = TErrors.EXCEPTION;
                    SaveLogFile(MethodBase.GetCurrentMethod(), hata);
                }

                return iErr;

        }



        protected int tcpGetMfrKeyList(out TMfrKeyList KeyList)
        {
            int iErr = 0;
            byte[] SendData = new byte[512];
            byte[] RecData = new byte[512];
            byte[] KeyData = new byte[192];

            TMfrKeyList outBufreturn = new TMfrKeyList();
            KeyList = outBufreturn;

            AES sif=new AES();

            iErr = ExecuteCmd(2, 20, 20, 0, SendData, out RecData);

            if (iErr == 0)
            {

                if (sif.DecryptMfrKeyData(RecData, out KeyData) == 0)
                {

                    for (int i = 0; i <= 15; i++)
                    {

                        for (int j = 0; j <= 5; j++)
                        {

                            KeyList.Sector[i].KeyA[j] = KeyData[i * 12 + j];
                            KeyList.Sector[i].KeyB[j] = KeyData[i * 12 + j + 6];
                        }

                    }

                }

            }
            else iErr = -99;

            return iErr;

        }

        protected int tcpGetHeadTailCapacity(out int Head, out int Tail, out int Capacity) // CMD 2.22
        {
            int iErr = 0;
            byte[] SendData = new byte[512];
            byte[] RecData = new byte[512];

            Head = 0;
            Tail = 0;
            Capacity = 0;

            try
            {
                iErr = ExecuteCmd(2, // CmdNo
                        22, // SubCmdNo
                        22, // Acknowledge
                        0, // DataLen
                        SendData, out RecData, 100 // SelectTimeOut
                        );
                if (iErr == 0)
                {
                    Head = RecData[0] +
                        (RecData[1]*256) +
                        (RecData[2]*256*256);

                    Tail = RecData[3] +
                        (RecData[4]*256) +
                        (RecData[5]*256*256);

                    Capacity = RecData[6] +
                        (RecData[7]*256) +
                        (RecData[8]*256*256);
                }

            }
            catch (Exception e)
            {
                iErr = TErrors.EXCEPTION;
                SaveLogFile(MethodBase.GetCurrentMethod(), e);
            }
            return iErr;
        }

        protected int tcpSetHeadTail(int Head, int Tail) // CMD 2.23
        {
            int iErr = 0;
            byte[] SendData = new byte[512];
            byte[] RecData = new byte[512];

            try
            {
                SendData[0] = (byte)(Head          & 0xFF);
                SendData[1] = (byte)((Head >> 8)  & 0xFF);
                SendData[2] = (byte)((Head >> 16) & 0xFF);
                SendData[3] = (byte)(Tail         & 0xFF);
                SendData[4] = (byte)((Tail >> 8)   & 0xFF);
                SendData[5] = (byte)((Tail >> 16) & 0xFF);

                iErr = ExecuteCmd(2, // CmdNo
                        23, // SubCmdNo
                        23, // Acknowledge
                        6, // DataLen
                        SendData, out RecData, 100 // SelectTimeOut
                        );
            }
            catch (Exception e)
            {
                iErr = TErrors.EXCEPTION;
                SaveLogFile(MethodBase.GetCurrentMethod(), e);
            }
            return iErr;
        }

        protected int tcpGetDeviceStatus(out Boolean StatusEnb) // CMD 2.24
        {
            int iErr = 0;
            byte[] SendData = new byte[512];
            byte[] RecData = new byte[512];
            StatusEnb = false;
            try
            {
                
                iErr = ExecuteCmd(2, // CmdNo
                        24, // SubCmdNo
                        24, // Acknowledge
                        0, // DataLen
                        SendData, out RecData, 100 // SelectTimeOut
                        );
                if (iErr == 0)
                {
                    StatusEnb = prBytesToBoolean(RecData,0);
                }

            }
            catch (Exception e)
            {
                iErr = TErrors.EXCEPTION;
                SaveLogFile(MethodBase.GetCurrentMethod(), e);
            }
            return iErr;
        }

        protected int tcpSetDeviceStatus(Boolean StatusEnb) // CMD 2.25
        {
            int iErr = 0;
            byte[] SendData = new byte[512];
            byte[] RecData = new byte[512];

            try
            {
                ToPrBytes(StatusEnb,ref SendData, 0);

                iErr = ExecuteCmd(2, // CmdNo
                        25, // SubCmdNo
                        25, // Acknowledge
                        1, // DataLen
                        SendData, out RecData, 100 // SelectTimeOut
                        );
            }
            catch (Exception e)
            {
                iErr = TErrors.EXCEPTION;
                SaveLogFile(MethodBase.GetCurrentMethod(), e);
            }
            return iErr;
        }


        public int tcpSetBeepRelayAndInboxMessage(TLcdScreen LcdScreenMsg)
        {
            int iErr = 0;
            byte[] SendData = new byte[512];
            byte[] RecData = new byte[512];

            try
            {
                ToPrBytes(LcdScreenMsg.ID,ref SendData,0);
                SendData[2]  = LcdScreenMsg.HeaderType;
                ToPrBytes(LcdScreenMsg.Caption,ref SendData,3,21);
                ToPrBytes(LcdScreenMsg.Line[0].Text,ref SendData,24,21);
                SendData[45]  = LcdScreenMsg.Line[0].X;
                SendData[46]  = LcdScreenMsg.Line[0].Y;
                SendData[47]  = LcdScreenMsg.Line[0].Alligment;
                ToPrBytes(LcdScreenMsg.Line[1].Text,ref SendData,48,21);
                SendData[69]  = LcdScreenMsg.Line[1].X;
                SendData[70]  = LcdScreenMsg.Line[1].Y;
                SendData[71]  = LcdScreenMsg.Line[1].Alligment;
                ToPrBytes(LcdScreenMsg.Line[2].Text,ref SendData,72,21);
                SendData[93]  = LcdScreenMsg.Line[2].X;
                SendData[94]  = LcdScreenMsg.Line[2].Y;
                SendData[95]  = LcdScreenMsg.Line[2].Alligment;
                ToPrBytes(LcdScreenMsg.Line[3].Text,ref SendData,96,21);
                SendData[117]  = LcdScreenMsg.Line[3].X;
                SendData[118]  = LcdScreenMsg.Line[3].Y;
                SendData[119]  = LcdScreenMsg.Line[3].Alligment;
                ToPrBytes(LcdScreenMsg.Line[4].Text,ref SendData,120,21);
                SendData[141]  = LcdScreenMsg.Line[4].X;
                SendData[142]  = LcdScreenMsg.Line[4].Y;
                SendData[143]  = LcdScreenMsg.Line[4].Alligment;
                SendData[144]  = LcdScreenMsg.FooterType;
                ToPrBytes(LcdScreenMsg.Footer,ref SendData,145,21);
                ToPrBytes(LcdScreenMsg.RL_Time1,ref SendData, 166);
                ToPrBytes(LcdScreenMsg.RL_Time2, ref SendData, 168);
                ToPrBytes(LcdScreenMsg.BZR_time, ref SendData, 170);
                ToPrBytes(LcdScreenMsg.IsBlink, ref SendData, 172);
                ToPrBytes(LcdScreenMsg.ScreenDuration, ref SendData, 173);
                SendData[175]  = LcdScreenMsg.FontType;
                SendData[176]  = LcdScreenMsg.LineCount;
                ToPrBytes(LcdScreenMsg.NextScreen, ref SendData, 177);
                SendData[179] = LcdScreenMsg.KeyPadType;

                iErr  = ExecuteCmd(2, 42, 42, 180, SendData, out RecData , 1000, 1);
            }
            catch (Exception)
            {
                
                throw;
            }

            return iErr;


        }


        public int tcpSetBeepRelayAndSecreenMessage(TLcdScreen LcdScreenMsg) // CMD 2.28
        {
            int iErr = 0;
            byte[] SendData = new byte[512];
            byte[] RecData = new byte[512];

            try
            {
                ToPrBytes(LcdScreenMsg.ID, ref SendData,0);
                SendData[2] = LcdScreenMsg.HeaderType;
                ToPrBytes(LcdScreenMsg.Caption,ref SendData,3,21);
                ToPrBytes(LcdScreenMsg.Line[0].Text,ref SendData,24,21);
                SendData[45] = LcdScreenMsg.Line[0].X;
                SendData[46] = LcdScreenMsg.Line[0].Y;
                SendData[47] = LcdScreenMsg.Line[0].Alligment;
                ToPrBytes(LcdScreenMsg.Line[1].Text,ref SendData,48,21);
                SendData[69] = LcdScreenMsg.Line[1].X;
                SendData[70] = LcdScreenMsg.Line[1].Y;
                SendData[71] = LcdScreenMsg.Line[1].Alligment;
                ToPrBytes(LcdScreenMsg.Line[2].Text,ref SendData,72,21);
                SendData[93] = LcdScreenMsg.Line[2].X;
                SendData[94] = LcdScreenMsg.Line[2].Y;
                SendData[95] = LcdScreenMsg.Line[2].Alligment;
                ToPrBytes(LcdScreenMsg.Line[3].Text,ref SendData,96,21);
                SendData[117] = LcdScreenMsg.Line[3].X;
                SendData[118] = LcdScreenMsg.Line[3].Y;
                SendData[119] = LcdScreenMsg.Line[3].Alligment;
                ToPrBytes(LcdScreenMsg.Line[4].Text,ref SendData,120,21);
                SendData[141] = LcdScreenMsg.Line[4].X;
                SendData[142] = LcdScreenMsg.Line[4].Y;
                SendData[143] = LcdScreenMsg.Line[4].Alligment;
                SendData[144] = LcdScreenMsg.FooterType;
                ToPrBytes(LcdScreenMsg.Footer,ref SendData,145,21);
                ToPrBytes(LcdScreenMsg.RL_Time1,ref SendData,166);
                ToPrBytes(LcdScreenMsg.RL_Time2,ref SendData,168);
                ToPrBytes(LcdScreenMsg.BZR_time,ref SendData,170);
                ToPrBytes(LcdScreenMsg.IsBlink,ref SendData,172);
                ToPrBytes(LcdScreenMsg.ScreenDuration,ref SendData,173);
                SendData[175] = LcdScreenMsg.FontType;
                SendData[176] = LcdScreenMsg.LineCount;
                ToPrBytes(LcdScreenMsg.NextScreen,ref SendData,177);

                iErr = ExecuteCmd(2, // CmdNo
                        28, // SubCmdNo
                        28, // Acknowledge
                        179, // DataLen
                        SendData, out RecData, 1000 // SelectTimeOut
                        );
            }
            catch (Exception e)
            {
                iErr = TErrors.EXCEPTION;
                SaveLogFile(MethodBase.GetCurrentMethod(), e);
            }
            return iErr;

        }

        public Boolean Connect()
        {
            return (DoConnect() == 0);
        }
        public Boolean DisConnect()
        {
            return (DoDisConnect() == 0);
        }





        

      


        public Boolean SetWebPassword(string WebPassword)
        {
            return (tcpSetWebPassword(WebPassword) == 0);
        }

        

        public Boolean GetWebPassword(out string WebPassword)
        {
            return (tcpGetWebPassword(out WebPassword) == 0);
        }


        public string GetWebPassword()
        {
        string PassStr;

        if (tcpGetWebPassword(out PassStr) == 0)
           return PassStr;
        else
           return "*";
        }


        public Boolean SetLCDMessagesFactoryDefault()
        { 
        return (tcpSetLCDMessagesFactoryDefault() == 0);
        }        
    





        public Boolean GetLCDMessages(int ID, out TLcdScreen LcdScreenMsg)
        {
            return (tcpGetLCDMessages(ID, out LcdScreenMsg) == 0);
            
        }


        public Boolean SetLCDMessages(TLcdScreen LcdScreenMsg)
        {
            return (tcpSetLCDMessages(LcdScreenMsg) == 0);
        }

        public Boolean SetDeviceClientTCPSettings(TClientTCPSettings rSettings)
        {
            return (tcpSetDeviceClientTCPSettings(rSettings) == 0);
        }

        public Boolean GetDeviceClientTCPSettings(out TClientTCPSettings rSettings)
        {
            return (tcpGetDeviceClientTCPSettings(out rSettings) == 0);
        }


        public Boolean SetDeviceUDPSettings(TUDPSettings rSettings)
        {
            return (tcpSetDeviceUDPSettings(rSettings) == 0);
        }

        public Boolean GetDeviceUDPSettings(out TUDPSettings rSettings)
        {
            return (tcpGetDeviceUDPSettings(out rSettings) == 0);
        }
        

        public Boolean SetDeviceTCPSettings(TTCPSettings rSettings )
        {
            return (tcpSetDeviceTCPSettings(rSettings) == 0);  
        }


        public Boolean SetDeviceGeneralSettings(TGeneralDeviceSettins rSettings)
        {
            return (tcpSetDeviceGeneralSettings(rSettings) == 0);
        }

        public  Boolean GetDeviceGeneralSettings(out TGeneralDeviceSettins rSettings)
        {
            return (tcpGetDeviceGeneralSettings(out rSettings)==0);
        }


        public Boolean GetDeviceTCPSettings(out TDeviceTCPSettings rSettings)
        {
            return (tcpGetDeviceTCPSettings(out rSettings) == 0);
        }


        public Boolean ReadPageData(ushort PageNo, out string HexValue)
        {
            return (tcpReadPageData(PageNo, out HexValue)==0);
        }


        public Boolean WritePageData(ushort PageNo, string HexValue)
        {
            return (tcpWritePageData(PageNo, HexValue)==0);
        }


        public Boolean GetDeviceWorkModeSettings(out TWorkModeSettings rSettings)
        {
            return (tcpGetDeviceWorkModeSettings(out rSettings)==0);
        }

        public Boolean SetDeviceWorkModeSettings(TWorkModeSettings rSettings)
        {
            return (tcpSetDeviceWorkModeSettings(rSettings)==0);
        }

        public Boolean SetDeviceFactoryDefault(Boolean ResetIP)
        {
            return (tcpSetDeviceFactoryDefault(ResetIP)==0);
        }

        public string GetSerialNumber()
        {
           byte[] SerialArr = new byte[16];

           if (tcpGetSerialNumber(out SerialArr) == 0)
               return prByteToString(SerialArr,0);
           else
               return "XXX";
        }

        public Boolean GetSerialNumber(out byte[] SerialArr)
        {
            return (tcpGetSerialNumber(out SerialArr) == 0);
        }

        public Boolean SetSerialNumber(string SerialStr)
        {
            byte[] tmpData = new byte[16];
            ToPrBytes(SerialStr, ref tmpData, 0);
            return (tcpSetSerialNumber(tmpData) == 0);
        }

        public Boolean GetFwVwersion(out string fWVersion)
        {
            return  (tcpGetFwVwersion(out fWVersion)==0);
        }

        public void Reboot()
        {
            tcpReboot();
        }

        public string GetFwVwersion()
        {
            String VersStr;
            if (tcpGetFwVwersion(out VersStr)==0)
               return VersStr;
            else
                return "";
        }

        public Boolean SetDateTime(DateTime dt)
        {
            return (tcpSetDateTime(dt)==0);
        }



        public Boolean GetMfrKeyList(out TMfrKeyListStr KeyList)
        {
            
            TMfrKeyList tmpKeyList = new TMfrKeyList() ;
            TMfrKeyListStr tmpKeyListstr = new TMfrKeyListStr();
            KeyList = tmpKeyListstr;

            if (tcpGetMfrKeyList(out tmpKeyList) == 0)
            {
                string str = "";
                for (int i = 0; i < 16; i++)
                {
                    str = prBytesToHex(tmpKeyList.Sector[i].KeyA, 0, 6);
                    tmpKeyListstr.Sector[i].KeyA = str;
                    str = prBytesToHex(tmpKeyList.Sector[i].KeyB, 0, 6);
                    tmpKeyListstr.Sector[i].KeyB = str;
                }
                KeyList = tmpKeyListstr;
                return true;
            }
            else
             return false;
        }


        public Boolean SetMfrKeyList(TMfrKeyListStr KeyList)
        {
            TMfrKeyList tmpKeyList = new TMfrKeyList();

            for (int i = 0; i < 16; i++)
            {
              ToPrBytesFromHex(KeyList.Sector[i].KeyA, ref tmpKeyList.Sector[i].KeyA);
              ToPrBytesFromHex(KeyList.Sector[i].KeyB,ref tmpKeyList.Sector[i].KeyB);
            }

            return (tcpSetMfrKeyList(tmpKeyList)==0);        
        }


        /*SetMfrKeyList*/


        public Boolean GetHeadTailCapacity(out int Head,out int Tail,out int Capacity)
        {
            return (tcpGetHeadTailCapacity(out Head,out Tail,out Capacity)==0);            
        }

        public int GetHead()
        {
            int tmpHead;
            int tmpTail;
            int tmpCapacity;
  
            if (tcpGetHeadTailCapacity(out tmpHead,out tmpTail,out tmpCapacity) == 0) 
                return tmpHead;
            else
                return -1;
        }

        public int GetTail()
        {
            int tmpHead;
            int tmpTail;
            int tmpCapacity;
  
            if (tcpGetHeadTailCapacity(out tmpHead,out tmpTail,out tmpCapacity) == 0) 
                return tmpTail;
            else
                return -1;
        }

        public int GetCapacity()
        {
            int tmpHead;
            int tmpTail;
            int tmpCapacity;
  
            if (tcpGetHeadTailCapacity(out tmpHead,out tmpTail,out tmpCapacity) == 0) 
                return tmpCapacity;
            else
                return -1;
        }
        
        public Boolean SetHeadTail(int Head,int Tail)
        {
            return (tcpSetHeadTail(Head,Tail)==0);
        }

        public Boolean GetDeviceStatus()
        {
            Boolean enb;
            if (tcpGetDeviceStatus(out enb)==0)
                return enb;
            else
                return false;
        }

        public Boolean SetDeviceStatus(Boolean StatusEnb)
        {
            return (tcpSetDeviceStatus(StatusEnb)==0);
        }

        public Boolean SetBeepRelayAndSecreenMessage( int HeaderType,int FooterType,
                    String Caption,String Text1,String Text2,String Text3,String Text4,String Text5,String Footer,
                    Byte X1,Byte Y1,Byte Alligment1,Byte X2,Byte Y2,Byte Alligment2,
                    Byte X3,Byte Y3,Byte Alligment3,Byte X4,Byte Y4,Byte Alligment4,Byte X5,Byte Y5,Byte Alligment5,
                    Byte LineCount,Byte FontType,
                    ushort ScreenDuration,ushort RL_Time1,ushort RL_Time2,ushort BZR_time,Boolean IsBlink ) 
        {
            TLcdScreen LcdScreenMsg = new  TLcdScreen();
            LcdScreenMsg.ID = 0;
            LcdScreenMsg.HeaderType =(byte)HeaderType;   //1
            LcdScreenMsg.Caption = Caption;    //21
            LcdScreenMsg.Line[0].X = X1; //105   +15
            LcdScreenMsg.Line[0].Y = Y1;
            LcdScreenMsg.Line[0].Alligment = Alligment1;
            LcdScreenMsg.Line[0].Text = Text1;
            LcdScreenMsg.Line[1].X = X2; //105   +15
            LcdScreenMsg.Line[1].Y = Y2;
            LcdScreenMsg.Line[1].Alligment = Alligment2;
            LcdScreenMsg.Line[1].Text = Text2;
            LcdScreenMsg.Line[2].X = X3; //105   +15
            LcdScreenMsg.Line[2].Y = Y3;
            LcdScreenMsg.Line[2].Alligment = Alligment3;
            LcdScreenMsg.Line[2].Text = Text3;
            LcdScreenMsg.Line[3].X = X4; //105   +15
            LcdScreenMsg.Line[3].Y = Y4;
            LcdScreenMsg.Line[3].Alligment = Alligment4;
            LcdScreenMsg.Line[3].Text = Text4;
            LcdScreenMsg.Line[4].X = X5; //105   +15
            LcdScreenMsg.Line[4].Y = Y5;
            LcdScreenMsg.Line[4].Alligment = Alligment5;
            LcdScreenMsg.Line[4].Text = Text5;
            LcdScreenMsg.FooterType = (byte)FooterType;   //1
            LcdScreenMsg.Footer = Footer;    //21
            LcdScreenMsg.RL_Time1 = RL_Time1;    //2
            LcdScreenMsg.RL_Time2 = RL_Time2;    //2
            LcdScreenMsg.BZR_time = BZR_time;    //2
            LcdScreenMsg.IsBlink = IsBlink;  //1
            LcdScreenMsg.ScreenDuration = ScreenDuration; //2
            LcdScreenMsg.FontType = FontType;    //1
            LcdScreenMsg.LineCount = LineCount;    //1
            LcdScreenMsg.NextScreen = 3;

            return (tcpSetBeepRelayAndSecreenMessage(LcdScreenMsg) == 0);
        }


        public Boolean SetBeepRelayAndSecreenMessage(String Text1, String Text2, ushort ScreenDuration, ushort RL_Time1, ushort BZR_time, Boolean IsBlink)
        {
            TLcdScreen LcdScreenMsg = new TLcdScreen();
            LcdScreenMsg.ID = 0;
            LcdScreenMsg.HeaderType = 0;  
            LcdScreenMsg.Caption = "";    
            LcdScreenMsg.Line[0].X = 0;
            LcdScreenMsg.Line[0].Y = 0;
            LcdScreenMsg.Line[0].Alligment = 0;
            LcdScreenMsg.Line[0].Text = Text1;
            LcdScreenMsg.Line[1].X = 0; //105   +15
            LcdScreenMsg.Line[1].Y = 0;
            LcdScreenMsg.Line[1].Alligment = 0;
            LcdScreenMsg.Line[1].Text = Text2;
            LcdScreenMsg.Line[2].X = 0; //105   +15
            LcdScreenMsg.Line[2].Y = 0;
            LcdScreenMsg.Line[2].Alligment = 0;
            LcdScreenMsg.Line[2].Text = "";
            LcdScreenMsg.Line[3].X = 0; //105   +15
            LcdScreenMsg.Line[3].Y = 0;
            LcdScreenMsg.Line[3].Alligment = 0;
            LcdScreenMsg.Line[3].Text = "";
            LcdScreenMsg.Line[4].X = 0; //105   +15
            LcdScreenMsg.Line[4].Y = 0;
            LcdScreenMsg.Line[4].Alligment = 0;
            LcdScreenMsg.Line[4].Text = "";
            LcdScreenMsg.FooterType = 0;   //1
            LcdScreenMsg.Footer = "";    //21
            LcdScreenMsg.RL_Time1 = RL_Time1;    //2
            LcdScreenMsg.RL_Time2 = 0;    //2
            LcdScreenMsg.BZR_time = BZR_time;    //2
            LcdScreenMsg.IsBlink = IsBlink;  //1
            LcdScreenMsg.ScreenDuration = ScreenDuration; //2
            LcdScreenMsg.FontType = 0;    //1
            LcdScreenMsg.LineCount = 0;    //1
            LcdScreenMsg.NextScreen = 3;

            return (tcpSetBeepRelayAndSecreenMessage(LcdScreenMsg) == 0);
        }


        public Boolean SetBeepRelayAndInboxMessage(int HeaderType, string Caption, string Text1, string Text2, byte X1, byte Y1, byte Alligment1, byte X2, byte Y2, byte Alligment2, ushort ScreenDuration, ushort RL_Time1, ushort RL_Time2, ushort BZR_time, Boolean IsBlink, Byte KeyPadType)
        {

            TLcdScreen LcdScreenMsg = new TLcdScreen();

            try
            {
                LcdScreenMsg.ID = 71;
                LcdScreenMsg.HeaderType  = (byte)HeaderType;   //1
                LcdScreenMsg.Caption  = Caption;    //21
                LcdScreenMsg.Line[0].X  = X1; //105   +15
                LcdScreenMsg.Line[0].Y  = Y1;
                LcdScreenMsg.Line[0].Alligment  = Alligment1;
                LcdScreenMsg.Line[0].Text  = Text1;
                LcdScreenMsg.Line[1].X  = X2; //105   +15
                LcdScreenMsg.Line[1].Y  = Y2;
                LcdScreenMsg.Line[1].Alligment  = Alligment2;
                LcdScreenMsg.Line[1].Text  = Text2;
                LcdScreenMsg.Line[2].X  = 0; //105   +15
                LcdScreenMsg.Line[2].Y  = 0;
                LcdScreenMsg.Line[2].Alligment  = 0;
                LcdScreenMsg.Line[2].Text  = "";
                LcdScreenMsg.Line[3].X  = 0; //105   +15
                LcdScreenMsg.Line[3].Y  = 0;
                LcdScreenMsg.Line[3].Alligment  = 0;
                LcdScreenMsg.Line[3].Text  = "";
                LcdScreenMsg.Line[4].X  = 0; //105   +15
                LcdScreenMsg.Line[4].Y  = 0;
                LcdScreenMsg.Line[4].Alligment  = 0;
                LcdScreenMsg.Line[4].Text  = "";
                LcdScreenMsg.FooterType  = 1;   //1
                LcdScreenMsg.Footer  = "";    //21
                LcdScreenMsg.RL_Time1  = RL_Time1;    //2
                LcdScreenMsg.RL_Time2  = RL_Time2;    //2
                LcdScreenMsg.BZR_time  = BZR_time;    //2
                LcdScreenMsg.IsBlink  = IsBlink;  //1
                LcdScreenMsg.ScreenDuration  = ScreenDuration; //2
                LcdScreenMsg.FontType  = 0;    //1
                LcdScreenMsg.LineCount  = 3;    //1
                LcdScreenMsg.NextScreen  = 3;
                LcdScreenMsg.KeyPadType = KeyPadType;
            }
            catch (Exception)
            {
                
                throw;
            }

            return  (tcpSetBeepRelayAndInboxMessage(LcdScreenMsg)==0);
        }


        public Boolean SetMACAddress(String MacAddr)
        {
            return (tcpSetMACAddress(MacAddr) == 0);
        }


        public Boolean GetWeekDayNames(out TWeekDays WeekDays)
        {
            return (tcpGetWeekDayNames(out WeekDays) == 0);
        
        }


        public Boolean SetWeekDayNames(TWeekDays WeekDays)
        {
            return (tcpSetWeekDayNames(WeekDays) == 0);
        }


        public Boolean GetSerialPortBaudrateSettings(out byte SerailAppType, out byte Serial0, out byte Serial1)
        {
            return (tcpGetSerialPortBaudrateSettings(out SerailAppType , out Serial0, out Serial1) == 0);
        }

        public Boolean SetSerialPortBaudrateSettings(byte SerailAppType , byte Serial0, byte Serial1)
        {
            return (tcpSetSerialPortBaudrateSettings(SerailAppType, Serial0, Serial1) == 0);
        
        }

        public Boolean ReadCardBlockData(Byte SectorNo, Byte BlockNo, TKeyType KeyType, out byte[] ValueBuff)
        { 
            return (tcpReadCardBlockData(SectorNo,BlockNo,  (byte)KeyType , out ValueBuff) == 0);
        }

        public Boolean WriteCardBlockData(Byte SectorNo, Byte BlockNo, TKeyType KeyType, byte[] ValueBuff)
        {
            return (tcpWriteCardBlockData(SectorNo, BlockNo, (byte)KeyType, ValueBuff) == 0);
        }  



    }

}
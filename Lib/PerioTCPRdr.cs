using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Net.Sockets;
using System.Threading;
using System.Runtime.InteropServices;
using System.IO;
using System.Reflection;
using PerioTcpRdrBase;
using System.Text.RegularExpressions;



namespace PerioTCPRdr
{
   public enum TfwAppType{fwPDKS, fwHGS, fwYMK};
    

    public static class Extensions
    {
        public static bool IsHex(this char c)
        {
            return (new Regex("[A-Fa-f0-9]").IsMatch(c.ToString()));
        }
    }



    public class TPersTZ
    {
        public DateTime Day ;
        public TOneTAC[] Part;
        public byte TZListNo;
        public TPersTZ()
        {
            Part = new TOneTAC[8];
        }
    }


    public class TPersTZList
    {
        public TPersTZ[] List;
        public TPersTZList()
        {
            List = new TPersTZ[5];

            for (int i = 0; i < List.Length; i++)
            {
                List[i] = new TPersTZ();
            }

        }
    }

    public struct TOneHGSRecord
    {
       public string CardID;
       public byte DoorNo;
       public byte RecordType;
       public DateTime TimeDate;
    }


    public struct THGSRecords
    {
        public uint Count;
        public TOneHGSRecord[] raDeviceRecs;


        //public THGSRecords()
        //{ 
        //raDeviceRecs = new TOneHGSRecord[512];
        //}

    }

    public class THGSArac
    {
        public string CardID;
        public string Name;
        public byte[] TimeAccessMask;
        public ushort Daire;
        public byte DaireHak;
        public byte AracNo;
        public DateTime EndDate;
        public Boolean AccessDevice;
        public Boolean APBEnabled;
        public Boolean ATCEnabled;
        public Boolean AccessCardEnabled;

        public THGSArac()
        {
            TimeAccessMask = new byte[7];
        }
    }



    public class TOneMealPrice
    {
        public ushort[] Prices;
        public TOneMealPrice()
        {
            Prices = new ushort[8];
        }
    }


    public class TOneDayPrice
    {
        public TOneMealPrice[] Meals = new TOneMealPrice[8];

        public TOneDayPrice()
        {
           

            for (int i = 0; i < 8; i++)
            {
                Meals[i] = new TOneMealPrice(); 
            }

        }

    }

    public class TOneCommand
    {
        public byte CmdType;
        public int SessionID;
        public int Amount;
    }

    public class TPersonCommandList
    {
        public TOneCommand[] List;
        public byte TotalCommand;
        public TPersonCommandList()
        {
            this.List = new TOneCommand[15];
            for (int i = 0; i < List.Length; i++)
            {
                List[i] = new TOneCommand();
            }

        }
    }


    public class TPriceList
    {
        public string name;
        public TOneDayPrice[] Days = new TOneDayPrice[8];
        public TPriceList()
        {

            for (int i = 0; i < 7; i++)
            {
                Days[i] = new TOneDayPrice();
            }

        
        }
    }


    public class TYmkSettings
    { 
     public Byte AppType;
     public Byte CurrPriceList;
     public Byte YmkSectorNo;
     public Byte PlantNo;
     public Byte ReReadCardCount;
     public Byte ReReadPriceGroup;
     public Byte ReReadTimeOut;    
    }

    public struct TOneMeal
    { 
     public string Name;
     public DateTime StartTime;
     public Byte StartDBY;
     public DateTime EndTime;
     public Byte EndDBY;
     public Boolean Active;
    }


    public class TDayMealList
    {
        public TOneMeal[] list;
        public TDayMealList()
        {
            list = new TOneMeal[8];
        }
    }

    
    public class TMealTable
    {
       public TDayMealList[] days = new TDayMealList[7];
       public TMealTable()
       {
           
           for (int i = 0; i < 7; i++)
           {
              days[i] = new TDayMealList();
           }
       }
    }



    public class TDailyMealRigth
    {
     public byte[] MealRigths;
     public byte TotalDayRight;

         public TDailyMealRigth()
         {
             MealRigths = new byte[8];
         }

    }

    public class TWeaklyMealRigth
    {
        public byte TotalWeekRight;
        public TDailyMealRigth[] days = new TDailyMealRigth[7];
        public TWeaklyMealRigth()
        {

            for (int i = 0; i < 7; i++)
            {
                days[i] = new TDailyMealRigth();  
            }
       
        }
        
    }


    

    public struct THGS_Settings
    { 
    public byte PaketBoyu;
    public byte CardBaslangic;
    public byte CardBoyu;
    public byte TrCikisSure1;
    public byte TrCikisSure2;
    public byte ProgramMode;
    public byte DiziEklemeSure1;
    public byte DiziEklemeSure2;
    public Boolean ZamanKisitEnb;
    public byte AntenPower1;
    public byte AntenPower2;
    public byte AntenTanitim;
    public byte DefMaksimumArac;
    public byte DefAntiPassPack;
    public byte AppType;
    }


 

        public struct THolidayDate
        {
            public DateTime Date;
            public Byte OOSTableNo;
        }


        public class THolidays
        {
         public THolidayDate[] List;
         public THolidays()
         {
             List = new THolidayDate[29];
         }
        }


    public struct TOneBell
    {
    public DateTime StartTime;
    public byte  Duration;
    }

    public class TBellTable
    { 
    public TOneBell[] List;
       public TBellTable()
       {
       List = new TOneBell[23];
       }
    }



    public partial class PerioTCPRdrComp : TCustomTcpRdr
    {
        private TfwAppType ffwAppType;        
        

        public TfwAppType fwAppType
        {
            set
            {
                ffwAppType = value;
            }
            get
            {
                return ffwAppType;
            }
        }

        protected int tcpDeleteHGSWhitelistWithDaireArac(ushort DaireNo, byte AracNo, out int IndexNo)
        {
            IndexNo = 0;
            int iErr;
            //int OldCmdRetry;
            byte[] SendData = new byte[512];
            byte[] RecData = new byte[512];

            //OldCmdRetry = CommandRetry;
            //CommandRetry = 1;

            try
            {
                ToPrBytes(DaireNo, ref SendData, 0);
                SendData[2] = AracNo;
                SendData[3] = 0;
                iErr = ExecuteCmd(3, 48, 48, 4, SendData, out RecData, 2000, 1);

                if (iErr == 0)
                {
                    IndexNo = prBytesToushort(RecData, 0);
                }
            }
            catch (Exception hata)
            {

                SaveLogFile(MethodBase.GetCurrentMethod(), hata);
                iErr = TErrors.EXCEPTION;
            }


            return iErr;


        }

        protected int tcpSetMealTable(TMealTable rSettings)
        {

            int iErr = 0;
            byte[] SendData = new byte[512];
            byte[] RecData = new byte[512];


            try
            {
                for (int i = 0; i < 7; i++)
                {
                    SendData[0] = (byte)i;
                    for (int j = 0; j < 8; j++)
                    {
                        ToPrBytes(rSettings.days[i].list[j].Name, ref SendData, (j * 22) + 1, 15);
                        SendData[(j * 22) + 16] = (byte)rSettings.days[i].list[j].StartTime.Hour;
                        SendData[(j * 22) + 17] = (byte)rSettings.days[i].list[j].StartTime.Minute;
                        SendData[(j * 22) + 18] = rSettings.days[i].list[j].StartDBY;
                        SendData[(j * 22) + 19] = (byte)rSettings.days[i].list[j].EndTime.Hour;
                        SendData[(j * 22) + 20] = (byte)rSettings.days[i].list[j].EndTime.Minute;
                        SendData[(j * 22) + 21] = (byte)rSettings.days[i].list[j].EndDBY;
                        ToPrBytes(rSettings.days[i].list[j].Active, ref SendData, (j * 22) + 22);
                    }
                    iErr = ExecuteCmd(4, 4, 4, 177, SendData, out RecData);
                }




            }
            catch (Exception hata)
            {

                SaveLogFile(MethodBase.GetCurrentMethod(), hata);
                iErr = TErrors.EXCEPTION;
            }

            return iErr;

        }
        
        protected int tcpSetPriceListTable(Byte TableNo, TPriceList rSettings)
        {
            int iErr = 0;
            byte[] SendData = new byte[512];
            byte[] RecData = new byte[512];

            try
            {
                SendData[0] = TableNo;
                ToPrBytes(rSettings.name, ref SendData, 1, 20);
                iErr = ExecuteCmd(4, 10, 10, 21, SendData, out RecData);

                if (iErr == 0)
                {

                    for (int i = 0; i <= 6; i++)
                    {
                        SendData[0] = TableNo;
                        SendData[1] = (byte)i;

                        for (int j = 0; j <= 7; j++)
                        {

                            for (int k = 0; k <= 7; k++)
                            {

                                ToPrBytes(rSettings.Days[i].Meals[j].Prices[k], ref SendData, (j * 16) + (k * 2) + 2);
                            }

                        }
                        iErr = ExecuteCmd(4, 8, 8, 130, SendData, out RecData, 2000);
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


        protected int tcpSetYmkSettings(TYmkSettings rSettings)
        {

            int iErr = 0;
            byte[] SendData = new byte[512];
            byte[] RecData = new byte[512];

            try
            {
                SendData[0] = rSettings.AppType;
                SendData[1] = rSettings.CurrPriceList;
                SendData[2] = rSettings.YmkSectorNo;
                SendData[3] = rSettings.PlantNo;
                SendData[4] = rSettings.ReReadCardCount;
                SendData[5] = rSettings.ReReadPriceGroup;
                SendData[6] = rSettings.ReReadTimeOut;

                iErr = ExecuteCmd(4, 2, 2, 7, SendData, out RecData);

            }
            catch (Exception hata)
            {
                SaveLogFile(MethodBase.GetCurrentMethod(), hata);
                iErr = TErrors.EXCEPTION;
            }


            return iErr;

        }

        protected int tcpGetYmkSettings(out TYmkSettings rSettings)
        {

            int iErr = 0;
            byte[] SendData = new byte[512];
            byte[] RecData = new byte[512];

            TYmkSettings tmpSettings = new TYmkSettings();
            rSettings = tmpSettings;


            try
            {
                iErr = ExecuteCmd(4, 1, 1, 0, SendData, out RecData);

                if (iErr == 0)
                {
                    rSettings.AppType = RecData[0];
                    rSettings.CurrPriceList = RecData[1];
                    rSettings.YmkSectorNo = RecData[2];
                    rSettings.PlantNo = RecData[3];
                    rSettings.ReReadCardCount = RecData[4];
                    rSettings.ReReadPriceGroup = RecData[5];
                    rSettings.ReReadTimeOut = RecData[6];
                }

            }
            catch (Exception hata)
            {
                SaveLogFile(MethodBase.GetCurrentMethod(), hata);
                iErr = TErrors.EXCEPTION;
            }

            return iErr;
        }

        protected int tcpGetPersonCommands(string CardID, out TPersonCommandList CommandList)
        {

            int iErr = 0;
            byte[] SendData = new byte[512];
            byte[] RecData = new byte[512];
            TPersonCommandList personCommandList = new TPersonCommandList();
            try
            {
                ToPrBytesFromHex(CardID, ref SendData, 0, 14);
                iErr = ExecuteCmd(4, 20, 20, 7, SendData, out RecData);
                if (iErr == 0)
                {
                    for (int i = 0; i < 15; i++)
                    {
                        personCommandList.List[i].CmdType = RecData[(7 * i)];
                        personCommandList.List[i].SessionID = RecData[(7 * i) + 1] + RecData[(7 * i) + 2] * 256 + RecData[(7 * i) + 3] * 256 * 256;
                        personCommandList.List[i].Amount = RecData[(7 * i) + 5] + RecData[(7 * i) + 6] * 256;
                    }
                    personCommandList.TotalCommand = RecData[105];
                }
            }
            catch (Exception hata)
            {
                SaveLogFile(MethodBase.GetCurrentMethod(), hata);
                iErr = TErrors.EXCEPTION;
            }

            CommandList = personCommandList;
            return iErr;
        }


        protected int tcpSetPersonCommands(string CardID, TPersonCommandList personCommandList)
        {

            int iErr = 0;
            byte[] SendData = new byte[512];
            byte[] RecData = new byte[512];

            try
            {
                ToPrBytesFromHex(CardID, ref SendData, 0, 14);

                for (int i = 0; i < 14; i++)
                {
                    // SendData[2] = (byte)((TempStartFrom >> 16) & 0xFF);
                    SendData[7 + (7 * i)] = personCommandList.List[i].CmdType;
                    SendData[7 + (7 * i) + 1] = (byte)((personCommandList.List[i].SessionID) & 0xFF);
                    SendData[7 + (7 * i) + 2] = (byte)((personCommandList.List[i].SessionID >> 8) & 0xFF);
                    SendData[7 + (7 * i) + 3] = (byte)((personCommandList.List[i].SessionID >> 16) & 0xFF);
                    SendData[7 + (7 * i) + 4] = 0;
                    SendData[7 + (7 * i) + 5] = (byte)(personCommandList.List[i].Amount >> 0xFF);
                    SendData[7 + (7 * i) + 6] = (byte)((personCommandList.List[i].Amount >> 8) & 0xFF);
                }
                SendData[112] = personCommandList.TotalCommand;

                iErr = ExecuteCmd(4, 21, 21, 113, SendData, out RecData);
            }
            catch (Exception hata)
            {
                SaveLogFile(MethodBase.GetCurrentMethod(), hata);
                iErr = TErrors.EXCEPTION;
            }

            return iErr;
        }

        protected int tcpGetPriceListTable(Byte TableNo, out TPriceList rSettings)
        {

            int iErr = 0;
            byte[] SendData = new byte[512];
            byte[] RecData = new byte[512];

            TPriceList tmpSettings = new TPriceList();
            rSettings = tmpSettings;

            try
            {
                SendData[0] = TableNo;

                iErr = ExecuteCmd(4, 9, 9, 1, SendData, out RecData);


                if (iErr == 0)
                {
                    rSettings.name = prByteToString(RecData, 0, 20);

                    for (int i = 0; i < 7; i++)
                    {
                        SendData[0] = TableNo;
                        SendData[1] = (byte)i;

                        iErr = ExecuteCmd(4, 7, 7, 2, SendData, out RecData);

                        if (iErr == 0)
                        {

                            for (int j = 0; j < 8; j++)
                            {

                                for (int k = 0; k < 8; k++)
                                {
                                    rSettings.Days[i].Meals[j].Prices[k] = prBytesToushort(RecData, (j * 16) + (k * 2));
                                }
                            }

                        }

                    }
                }

            }
            catch (Exception hata)
            {

                SaveLogFile(MethodBase.GetCurrentMethod(), hata);
                iErr = TErrors.EXCEPTION;
            }
            rSettings = tmpSettings;
            return iErr;


        }


        protected int tcpSetMealRigthTable(Byte TableNo, TWeaklyMealRigth rSettings)
        {
            int iErr = 0;
            byte[] SendData = new byte[512];
            byte[] RecData = new byte[512];

            try
            {
                SendData[0] = TableNo;

                for (int i = 0; i < 7; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        SendData[(i * 9) + j + 1] = rSettings.days[i].MealRigths[j];
                        SendData[(i * 9) + 9] = rSettings.days[i].TotalDayRight;
                    }
                }

                SendData[64] = rSettings.TotalWeekRight;
                SendData[65] = 0;
                SendData[66] = 0;

                iErr = ExecuteCmd(4, 6, 6, 67, SendData, out RecData);

            }
            catch (Exception hata)
            {

                SaveLogFile(MethodBase.GetCurrentMethod(), hata);
                iErr = TErrors.EXCEPTION;
            }

            return iErr;

        }

        protected int tcpGetMealRigthTable(byte TableNo, out TWeaklyMealRigth rSettings)
        {
            int iErr = 0;
            byte[] SendData = new byte[512];
            byte[] RecData = new byte[512];

            TWeaklyMealRigth tmpSettings = new TWeaklyMealRigth();
            rSettings = tmpSettings;

            try
            {
                SendData[0] = TableNo;
                iErr = ExecuteCmd(4, 5, 5, 1, SendData, out RecData);

                if (iErr == 0)
                {

                    for (int i = 0; i < 7; i++)
                    {

                        for (int j = 0; j < 8; j++)
                        {
                            rSettings.days[i].MealRigths[j] = RecData[(i * 9) + j];
                            rSettings.days[i].TotalDayRight = RecData[(i * 9) + 8];
                        }

                    }
                    rSettings.TotalWeekRight = RecData[63];
                }

            }
            catch (Exception hata)
            {
                SaveLogFile(MethodBase.GetCurrentMethod(), hata);
                iErr = TErrors.EXCEPTION;
            }
            rSettings = tmpSettings;

            return iErr;

        }

        protected int tcpGetMealTable(out TMealTable rSettings)
        {
            int iErr = 0;
            int j;
            byte[] SendData = new byte[512];
            byte[] RecData = new byte[512];

            TMealTable tmpSettings = new TMealTable();
            rSettings = tmpSettings;

            try
            {
                for (int i = 0; i < 7; i++)
                {
                    SendData[0] = (byte)i;
                    iErr = ExecuteCmd(4, 3, 3, 1, SendData, out RecData);

                    if (iErr == 0)
                    {

                        for (j = 0; j < 8; j++)
                        {
                            tmpSettings.days[i].list[j].Name = prByteToString(RecData, (j * 22), 15);
                            tmpSettings.days[i].list[j].StartTime = new DateTime(2000, 1, 1, RecData[(j * 22) + 15], RecData[(j * 22) + 16], 0);
                            tmpSettings.days[i].list[j].StartDBY = RecData[(j * 22) + 17];
                            tmpSettings.days[i].list[j].EndTime = new DateTime(2000, 1, 1, RecData[(j * 22) + 18], RecData[(j * 22) + 19], 0);
                            tmpSettings.days[i].list[j].EndDBY = RecData[(j * 22) + 20];
                            tmpSettings.days[i].list[j].Active = prBytesToBoolean(RecData, ((j * 22) + 21));
                        }


                    }

                }
                rSettings = tmpSettings;

            }
            catch (Exception hata)
            {

                SaveLogFile(MethodBase.GetCurrentMethod(), hata);
                iErr = TErrors.EXCEPTION;
            }




            return iErr;

        }

        protected int tcpGetHGSWhitelistWithDaireArac(ushort DaireNo, Byte AracNo, out THGSArac rArac, out int IndexNo)
        {
            int iErr;
            byte[] SendData = new byte[512];
            byte[] RecData = new byte[512];

            THGSArac tmpSettings = new THGSArac();
            rArac = tmpSettings;

            IndexNo = 0;
            try
            {
                ToPrBytes(DaireNo, ref SendData, 0);
                SendData[2] = AracNo;
                SendData[3] = 0;
                iErr = ExecuteCmd(3, 46, 46, 4, SendData, out RecData, 2000, 3);


                if (iErr == 0)
                {

                    rArac.CardID = prBytesToHex(RecData, 0, 8);
                    rArac.Name = (prByteToString(RecData, 8, 18)).Trim();

                    for (int i = 26; i <= 32; i++)
                    {
                        rArac.TimeAccessMask[i - 26] = RecData[i];
                        rArac.Daire = prBytesToushort(RecData, 33);
                        rArac.AracNo = RecData[35];
                        rArac.EndDate = new DateTime(RecData[41] + 2000, RecData[40], RecData[39]);
                        rArac.AccessDevice = prBytesToBoolean(RecData, 42);
                        rArac.APBEnabled = prBytesToBoolean(RecData, 43);
                        rArac.ATCEnabled = prBytesToBoolean(RecData, 44);
                        rArac.AccessCardEnabled = prBytesToBoolean(RecData, 45);
                        IndexNo = prBytesToushort(RecData, 52);
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

        protected int tcpIsHGSDaireAracExistInWhitelist(ushort DaireNo, Byte AracNo, out int IndexNo)
        {

            int iErr;

            byte[] SendData = new byte[512];
            byte[] RecData = new byte[512];

            IndexNo = 0;
            try
            {

                ToPrBytes(DaireNo, ref SendData, 0);
                SendData[2] = (byte)AracNo;
                SendData[3] = 0;

                iErr = ExecuteCmd(3, 49, 49, 4, SendData, out RecData, 2000, 3);


                if (iErr == 0)
                {
                    IndexNo = prBytesToushort(RecData, 0);
                }

            }
            catch (Exception hata)
            {

                SaveLogFile(MethodBase.GetCurrentMethod(), hata);
                iErr = TErrors.EXCEPTION;
            }


            return iErr;

        }

        private int ConfirmRecsHGS(byte uTransferredCount)
        {
            int iErr = 0;
            byte[] SendData = new byte[512];
            byte[] RecData = new byte[512];

            try
            {
                SendData[0] = uTransferredCount;
                iErr = ExecuteCmd(3, // CmdNo
                    52, // SubCmdNo
                    52, // Acknowledge
                    1,  // DataLen
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

        protected int tcpTransferHGSRecords(out THGSRecords Recs) // CMD 3.30
        {
            int iErr = 0;
            byte[] SendData = new byte[512];
            byte[] RecData = new byte[512];

            int RecordSize = 17;
            uint TransferredCount = 0;
            //uint ReceivedCount = 0;
            int Head, Tail, Capacity;
            int CountToTransfer;
            int CountPerTime, StartFrom;
            byte TempCountPerTime;

            THGSRecords tempRecs = new THGSRecords();
            tempRecs.Count = 0;

            THGSRecords notConfRecs = new THGSRecords();
            notConfRecs.Count = 0;

            tempRecs.raDeviceRecs = new TOneHGSRecord[512];

            //SetLength(tempRecs.raDeviceRecs, 0);
            Array.Resize(ref tempRecs.raDeviceRecs, (byte)0);
            //SetLength(notConfRecs.raDeviceRecs, 0);
            Array.Resize(ref notConfRecs.raDeviceRecs, (byte)0);

            string CardId;
            Recs = tempRecs;

            try
            {
                iErr = tcpGetHeadTailCapacity(out Head, out Tail, out Capacity);
                if (iErr == 0)
                {
                    if (Head > Tail)
                        CountToTransfer = (Head - Tail);
                    else
                        CountToTransfer = (Capacity - Tail + Head);
                    CountPerTime = 12;
                    StartFrom = Tail;
                    do
                    {
                        if ((CountToTransfer - tempRecs.Count) >= CountPerTime)
                            TempCountPerTime = (byte)(CountPerTime);
                        else
                            TempCountPerTime = (byte)(CountToTransfer - tempRecs.Count);

                        SendData[0] = TempCountPerTime;
                        iErr = ExecuteCmd(3, // CmdNo
                            51, // SubCmdNo
                            51, // Acknowledge
                            1,  // DataLen
                            SendData, out RecData // SelectTimeOut
                            );

                        if (iErr == 0)
                        {
                            notConfRecs.Count = RecData[0];
                            Array.Resize(ref notConfRecs.raDeviceRecs, (byte)notConfRecs.Count);
                            for (int i = 0; i < notConfRecs.Count; i++)
                            {
                                // Card ID
                                CardId = "";
                                CardId = prBytesToHex(RecData, (RecordSize * i) + 1, 8);
                                notConfRecs.raDeviceRecs[i + TransferredCount].CardID = CardId; // exceptiona girdi
                                //notConfRecs.raDeviceRecs[0].CardID = CardId; // exceptiona girdi
                                // Door No
                                notConfRecs.raDeviceRecs[i + TransferredCount].DoorNo = RecData[(RecordSize * i) + 9];
                                // Record Type
                                notConfRecs.raDeviceRecs[i + TransferredCount].RecordType = RecData[(RecordSize * i) + 10];
                                // RFU
                                //notConfRecs.raDeviceRecs[i+TransferredCount].RFU[0] = RecData[(RecordSize*i)+10];
                                //notConfRecs.raDeviceRecs[i+TransferredCount].RFU[1] = RecData[(RecordSize*i)+11];
                                // Date Time
                                notConfRecs.raDeviceRecs[i + TransferredCount].TimeDate
                                    = prBytesToDateTimeEx(RecData, (RecordSize * i) + 12);
                            }

                            iErr = ConfirmRecsHGS((byte)notConfRecs.Count);

                            if (iErr == 0)
                            {
                                Array.Resize(ref tempRecs.raDeviceRecs, (int)(tempRecs.Count + notConfRecs.Count));
                                for (uint i = tempRecs.Count; i < (tempRecs.Count + notConfRecs.Count); i++)
                                    tempRecs.raDeviceRecs[i] = notConfRecs.raDeviceRecs[i - tempRecs.Count];
                                tempRecs.Count = tempRecs.Count + notConfRecs.Count;
                            }
                        }
                    } while ((CountToTransfer > tempRecs.Count) && (iErr == 0));
                }
                if (iErr == 0)
                    Recs = tempRecs;

            }
            catch (Exception e)
            {
                iErr = TErrors.EXCEPTION;
                SaveLogFile(MethodBase.GetCurrentMethod(), e);
            }
            return iErr;
        }


        protected int tcpGetHGSWhitelistWithCardID(String CardID, out THGSArac rArac, out int IndexNo)
        {
            int iErr = 0;
            byte[] SendData = new byte[512];
            byte[] RecData = new byte[512];

            IndexNo = 0;
            THGSArac tmpSettings = new THGSArac();
            rArac = tmpSettings;

            ToPrBytesFromHex(CardID, ref SendData, 0);
            iErr = ExecuteCmd(3, 42, 42, 8, SendData, out RecData);


            if (iErr == 0)
            {
                rArac.CardID = prBytesToHex(RecData, 0, 8);
                rArac.Name = prByteToString(RecData, 8, 18).Trim();
                for (int i = 26; i < 32; i++)
                {

                    rArac.TimeAccessMask[i - 26] = RecData[i];
                    rArac.Daire = prBytesToushort(RecData, 33);
                    rArac.AracNo = RecData[35];
                    rArac.EndDate = new DateTime(RecData[41] + 2000, RecData[40], RecData[39]); //EncodeDate(RecData[41]+2000,RecData[40],RecData[39]);
                    rArac.AccessDevice = prBytesToBoolean(RecData, 42);
                    rArac.APBEnabled = prBytesToBoolean(RecData, 43);
                    rArac.ATCEnabled = prBytesToBoolean(RecData, 44);
                    rArac.AccessCardEnabled = prBytesToBoolean(RecData, 45);
                    IndexNo = prBytesToushort(RecData, 52);
                }


            }

            return iErr;

        }


        protected int tcpReadHGSRecords(uint StartFrom, uint HowMany, out THGSRecords Recs)// // CMD 3.29
        {
            int iErr = 0;
            byte[] SendData = new byte[512];
            byte[] RecData = new byte[512];

            int RecordSize = 17;
            uint TransferredCount = 0;
            uint TempStartFrom = StartFrom;
            uint ReceivedCount;
            byte TempCountPerTime;
            THGSRecords tempRecs = new THGSRecords();
            tempRecs.Count = 0;
            tempRecs.raDeviceRecs = new TOneHGSRecord[HowMany];
            string CardId;


            Recs = tempRecs;
            try
            {

                do
                {
                    if ((HowMany - TransferredCount) >= 12)
                        TempCountPerTime = 12;
                    else
                        TempCountPerTime = (byte)(HowMany - TransferredCount);

                    SendData[0] = (byte)(TempStartFrom & 0xFF);
                    SendData[1] = (byte)((TempStartFrom >> 8) & 0xFF);
                    SendData[2] = (byte)((TempStartFrom >> 16) & 0xFF);
                    SendData[3] = TempCountPerTime;
                    iErr = ExecuteCmd(3, // CmdNo
                        50, // SubCmdNo
                        50, // Acknowledge
                        4,  // DataLen
                        SendData, out RecData // SelectTimeOut
                        );
                    if (iErr == 0)
                    {

                        ReceivedCount = RecData[0];
                        tempRecs.Count = tempRecs.Count + ReceivedCount;

                        //SetLength(tempRecs.raDeviceRecs,tempRecs.Count); Baþta Set ettik deðeri
                        for (int i = 0; i < ReceivedCount; i++)
                        {
                            CardId = "";
                            CardId = prBytesToHex(RecData, (RecordSize * i) + 1, 8);
                            tempRecs.raDeviceRecs[i + TransferredCount].CardID = CardId;
                            tempRecs.raDeviceRecs[i + TransferredCount].DoorNo = RecData[(RecordSize * i) + 9];
                            tempRecs.raDeviceRecs[i + TransferredCount].RecordType = RecData[(RecordSize * i) + 10];
                            //tempRecs.raDeviceRecs[i+TransferredCount].RFU[0]     = RecData[(RecordSize*i)+10];
                            //tempRecs.raDeviceRecs[i+TransferredCount].RFU[1]     = RecData[(RecordSize*i)+11];
                            tempRecs.raDeviceRecs[i + TransferredCount].TimeDate = prBytesToDateTimeEx(RecData, (RecordSize * i) + 12);
                        }
                        TransferredCount = TransferredCount + ReceivedCount;
                        TempStartFrom = (TempStartFrom + ReceivedCount);
                    }
                } while ((TransferredCount < HowMany) && (iErr == 0));
                if (iErr == 0)
                    Recs = tempRecs;
            }
            catch (Exception e)
            {
                iErr = TErrors.EXCEPTION;
                SaveLogFile(MethodBase.GetCurrentMethod(), e);
            }
            return iErr;
        }


        protected int tcpIsHGSCardIDExistInWhitelist(String CardID, ushort DaireNo, out THGSArac rArac, out int IndexNo)
        {
            int iErr = 0;
            byte[] SendData = new byte[512];
            byte[] RecData = new byte[512];

            IndexNo = 0;

            THGSArac tmpSettings = new THGSArac();
            rArac = tmpSettings;
            try
            {
                ToPrBytesFromHex(CardID, ref SendData, 0);

                iErr = ExecuteCmd(3, 42, 42, 8, SendData, out RecData);

                if (iErr == 0)
                {
                    rArac.CardID = prBytesToHex(RecData, 0, 8);
                    rArac.Name = prByteToString(RecData, 8, 18);
                    //for I := 26 to 32 do

                    for (int i = 26; i <= 32; i++)
                    { rArac.TimeAccessMask[i - 26] = RecData[i]; }

                    rArac.Daire = prBytesToushort(RecData, 33);
                    rArac.AracNo = RecData[35];
                    rArac.EndDate = new DateTime(RecData[41] + 2000, RecData[40], RecData[39]);
                    rArac.AccessDevice = prBytesToBoolean(RecData, 42);
                    rArac.APBEnabled = prBytesToBoolean(RecData, 43);
                    rArac.ATCEnabled = prBytesToBoolean(RecData, 44);
                    rArac.AccessCardEnabled = prBytesToBoolean(RecData, 45);
                    IndexNo = prBytesToushort(RecData, 52);
                }



            }
            catch (Exception hata)
            {
                SaveLogFile(MethodBase.GetCurrentMethod(), hata);
                iErr = TErrors.EXCEPTION;
            }

            return iErr;

        }

        protected int tcpSetPersonTZList(string CardID, TPersTZList PersTZList) // CMD 3.65
        {
            int iErr;
            int Day, Month, Year, sHour, sMin, eHour, eMin;
            byte[] SendData = new byte[512];
            byte[] RecData = new byte[512];
            
            ToPrBytesFromHex(CardID, ref SendData, 0, 14);
            try
            {

                for (int i = 0; i <= 4; i++)
                {
                    Day = PersTZList.List[i].Day.Day;
                    Month = PersTZList.List[i].Day.Month;
                    Year = PersTZList.List[i].Day.Year;
                    SendData[7 + 36 * i + 0] = (byte)Day;
                    SendData[7 + 36 * i + 1] = (byte)Month;
                    SendData[7 + 36 * i + 2] = (byte)(Year - 2000);
                    SendData[7 + 36 * i + 3] = PersTZList.List[i].TZListNo;


                    for (int j = 0; j < 8; j++)
                    {
                        //DecodeTime(PersTZList.List[i].Part[j].StartTime, sHour, sMin, Sec, MSec);
                        //DecodeTime(PersTZList.List[i].Part[j].EndTime, eHour, eMin, Sec, MSec);
                        sHour = PersTZList.List[i].Part[j].StartTime.Hours;
                        sMin = PersTZList.List[i].Part[j].StartTime.Minutes;
                        eHour = PersTZList.List[i].Part[j].EndTime.Hours;
                        eMin = PersTZList.List[i].Part[j].EndTime.Minutes;
                        SendData[7 + (36 * i + 4) + (j * 4) + 0] = (byte)sHour;
                        SendData[7 + (36 * i + 4) + (j * 4) + 1] = (byte)sMin;
                        SendData[7 + (36 * i + 4) + (j * 4) + 2] = (byte)eHour;
                        SendData[7 + (36 * i + 4) + (j * 4) + 3] = (byte)eMin;
                    }
                }

                iErr= ExecuteCmd(3, // CmdNo
                                 66, // SubCmdNo
                                 66, // Acknowledge
                                 187,  // DataLen
                                 SendData, out RecData // SelectTimeOut
                                 );

            }
            catch (Exception ex)
            {
                iErr = TErrors.EXCEPTION;
                SaveLogFile(MethodBase.GetCurrentMethod(), ex);
            }

            return iErr;
        }


        protected int tcpGetPersonTZList(string CardID, out TPersTZList PersTZList) // CMD 3.65
        {
            int iErr;
            int Day,Month,Year,sHour, sMin,eHour, eMin;
            byte[] SendData = new byte[512];
            byte[] RecData = new byte[512];
            TPersTZList oTPersTZList = new TPersTZList();
            ToPrBytesFromHex(CardID, ref SendData, 0,14);
            try
            {
                iErr = ExecuteCmd(3, 65, 65, 7, SendData, out RecData);

                for (int i = 0; i <= 4; i++)
                {
                    Day= RecData[36 * i + 0];
                    Month= RecData[36 * i + 1];
                    Year= (RecData[36 * i + 2] + 2000);
                    oTPersTZList.List[i].Day = new DateTime(Year, Month, Day); //EncodeDate(Year, Month, Day);
                    oTPersTZList.List[i].TZListNo = RecData[36 * i + 3];

                    for (int j = 0; j < 8; j++)
                    {
                        sHour= RecData[(36 * i + 4) + (j * 4) + 0];
                        sMin= RecData[(36 * i + 4) + (j * 4) + 1];

                        eHour= RecData[(36 * i + 4) + (j * 4) + 2];
                        eMin= RecData[(36 * i + 4) + (j * 4) + 3];

                        oTPersTZList.List[i].Part[j].StartTime = new TimeSpan(1,sHour, sMin, 0, 0);// EncodeTime(sHour, sMin, 0, 0);
                        oTPersTZList.List[i].Part[j].EndTime = new TimeSpan(1,eHour, eMin, 0);  //EncodeTime(eHour, eMin, 0, 0);
                    }
                }

            }
            catch (Exception ex)
            {
                iErr = TErrors.EXCEPTION;
                SaveLogFile(MethodBase.GetCurrentMethod(), ex);
            }
            PersTZList = oTPersTZList;
            return iErr;
        }

        protected int tcpIsHGSCardIDExistInWhitelist(String CardID, out int IndexNo)
        {
            int iErr = 0;
            byte[] SendData = new byte[512];
            byte[] RecData = new byte[512];
            IndexNo = 0;


            ToPrBytesFromHex(CardID, ref SendData, 0);

            try
            {
                iErr = ExecuteCmd(3, 45, 45, 8, SendData, out RecData, 2000, 3);

                if (iErr == 0)
                {
                    IndexNo = prBytesToushort(RecData, 0);
                }
            }
            catch (Exception hata)
            {
                SaveLogFile(MethodBase.GetCurrentMethod(), hata);
                iErr = TErrors.EXCEPTION;
            }

            return iErr;


        }


        protected int tcpDeleteHGSWhitelistWithCardID(String CardID, out int IndexNo)
        {
            int iErr = 0;
            //int OldCmdRetry=0;
            IndexNo = 0;
            byte[] SendData = new byte[512];
            byte[] RecData = new byte[512];

            try
            {

                ToPrBytesFromHex(CardID, ref SendData, 0);
                iErr = ExecuteCmd(3, 44, 44, 8, SendData, out RecData, 2000, 1);
                //OldCmdretry = CommandRetry;
                CommandRetry = 1;

                if (iErr == 0)
                {
                    IndexNo = prBytesToushort(RecData, 0);
                }

            }
            catch (Exception hata)
            {
                SaveLogFile(MethodBase.GetCurrentMethod(), hata);
                iErr = TErrors.EXCEPTION;
            }

            return iErr;

        }




        public int DeleteHGSWhitelistWithCardID(String CardID, out int IndexNum)
        {
            int iErr;
            int lclErr;
            IndexNum = 0;

            try
            {
                lclErr = Convert.ToInt16(IsCardIDExistHGSInWhitelistX(CardID, out IndexNum));

                switch (lclErr)
                {

                    case 0:
                        iErr = 12;
                        break;
                    case 51:
                        iErr = tcpDeleteHGSWhitelistWithCardID(CardID, out IndexNum);
                        break;

                    default:
                        iErr = lclErr;
                        break;
                }


            }
            catch (Exception hata)
            {
                SaveLogFile(MethodBase.GetCurrentMethod(), hata);
                iErr = TErrors.EXCEPTION;
            }


            return iErr;

        }


        public int DeleteHGSWhitelistWithCardID(String CardID)
        {
            int InxNum = 0;
            return (DeleteHGSWhitelistWithCardID(CardID, out InxNum));

        }


        public int tcpIsHGSCardIDDaireAracExistInWhitelist(String CardID, ushort DaireNo, byte AracNo, out int IndexNo)
        {

            int iErr;
            byte[] SendData = new byte[512];
            byte[] RecData = new byte[512];
            IndexNo = 0;

            try
            {
                ToPrBytesFromHex(CardID, ref SendData, 0);
                ToPrBytes(DaireNo, ref SendData, 8);
                SendData[10] = AracNo;
                SendData[11] = 0;
                iErr = ExecuteCmd(3, 47, 47, 12, SendData, out RecData, 2000, 3);

                if (iErr == 23)
                {
                    IndexNo = prBytesToushort(RecData, 0);
                }

            }
            catch (Exception hata)
            {
                SaveLogFile(MethodBase.GetCurrentMethod(), hata);
                iErr = TErrors.EXCEPTION;
            }

            return iErr;

        }

        protected int tcpEditHGSWhitelistWithCardID(THGSArac rArac, out int IndexNo)
        {
            int iErr = 0;
            byte[] SendData = new byte[512];
            byte[] RecData = new byte[512];
            IndexNo = 0;

            try
            {
                ToPrBytesFromHex(rArac.CardID, ref SendData, 0);
                ToPrBytes(rArac.Name, ref SendData, 8, 18);
                for (int i = 0; i <= 60; i++)
                {
                    SendData[i + 26] = Convert.ToByte(rArac.TimeAccessMask[i]);
                    ToPrBytes(rArac.Daire, ref SendData, 33);
                    SendData[35] = rArac.AracNo;
                    SendData[36] = 0;
                    SendData[37] = 0;
                    SendData[38] = 0;
                    ToPrBytes(Convert.ToString(rArac.EndDate), ref SendData, 39);
                    ToPrBytes(rArac.AccessDevice, ref SendData, 42);
                    ToPrBytes(rArac.APBEnabled, ref SendData, 43);
                    ToPrBytes(rArac.ATCEnabled, ref SendData, 44);
                    ToPrBytes(rArac.AccessCardEnabled, ref SendData, 45);
                }

                for (int j = 46; j <= 51; j++)
                {
                    SendData[j] = 0;
                }

                iErr = ExecuteCmd(3, 43, 43, 52, SendData, out RecData);

                if (iErr == 0)
                {
                    IndexNo = prBytesToushort(RecData, 0);
                }

            }
            catch (Exception hata)
            {
                SaveLogFile(MethodBase.GetCurrentMethod(), hata);
                iErr = TErrors.EXCEPTION;
            }


            return iErr;

        }

        protected int tcpAddHGSWhitelist(THGSArac rArac, out int IndexNo)
        {
            int iErr = 0;
            int OldCmdRetry, lclErr, CommandRetry = 0;
            byte[] SendData = new byte[512];
            byte[] RecData = new byte[512];
            IndexNo = 0;

            OldCmdRetry = CommandRetry;
            CommandRetry = 1;

            try
            {
                ToPrBytesFromHex(rArac.CardID, ref SendData, 0);
                ToPrBytes(rArac.Name, ref SendData, 8, 18);

                for (int i = 0; i < 6; i++)
                {
                    SendData[i + 26] = Convert.ToByte(rArac.TimeAccessMask[i]);
                }

                ToPrBytes(rArac.Daire, ref SendData, 33);
                SendData[35] = rArac.AracNo;
                SendData[36] = 0;
                SendData[37] = 0;
                SendData[38] = 0;
                ToPrBytes(Convert.ToString(rArac.EndDate), ref SendData, 39);
                ToPrBytes(rArac.AccessDevice, ref SendData, 42);
                ToPrBytes(rArac.APBEnabled, ref SendData, 43);
                ToPrBytes(rArac.ATCEnabled, ref SendData, 44);
                ToPrBytes(rArac.AccessCardEnabled, ref SendData, 45);

                for (int i = 46; i < 51; i++)
                {
                    SendData[i] = 0;
                }

                iErr = ExecuteCmd(3, 41, 41, 52, SendData, out RecData, 2000, 1);

                if (iErr == 0)
                {
                    IndexNo = prBytesToushort(RecData, 0);
                }

            }
            catch (Exception hata)
            {
                SaveLogFile(MethodBase.GetCurrentMethod(), hata);
                iErr = TErrors.EXCEPTION;
            }
            CommandRetry = OldCmdRetry;

            return iErr;

        }

        public int AddHGSWhitelist(THGSArac rArac, out int IndexNum, Boolean IfExistEdit = false)
        {
            int iErr, lclErr = 0;
            byte[] SendData = new byte[512];
            byte[] RecData = new byte[512];
            //IndexNum = 0;


            lclErr = IsHGSCardIDDaireAracExistInWhitelistX(Convert.ToString(rArac.CardID), (ushort)rArac.Daire, (byte)rArac.AracNo, out IndexNum);
            //IsHGSCardIDDaireAracExistInWhitelistX
            //IsHGSCardIDDaireAracExistInWhitelistX

            switch (lclErr)
            {
                case 23:
                    iErr = tcpAddHGSWhitelist(rArac, out IndexNum);
                    break;

                case 26:
                    iErr = lclErr;
                    iErr = EditHGSWhitelistWithCardID(rArac, out IndexNum);
                    break;

                default:
                    //iErr = tcpAddHGSWhitelist(rArac, out IndexNum);
                    iErr = lclErr;
                    break;
            }

            return iErr;
        }


        protected int tcpSetHGSDaireParkHak(String CardID, ushort DaireNo, Byte AracNo, out int IndexNo)
        {
            int iErr = 0;
            byte[] SendData = new byte[512];
            byte[] RecData = new byte[512];
            IndexNo = 0;
            CardID = "";
            DaireNo = 0;
            AracNo = 0;

            try
            {
                if (iErr == 0)
                {
                    ToPrBytesFromHex(CardID, ref SendData, 0);
                    ToPrBytes(DaireNo, ref SendData, 8);
                    SendData[10] = AracNo;
                    SendData[11] = 0;
                    iErr = ExecuteCmd(3, 47, 47, 12, SendData, out RecData, 2000, 3);

                }

            }
            catch (Exception hata)
            {
                SaveLogFile(MethodBase.GetCurrentMethod(), hata);
                iErr = TErrors.EXCEPTION;
            }


            return iErr;
        }




        protected int tcpSetHGSDaireParkHak(uint rDaire, Byte rHak)
        {
            int iErr = 0;
            byte[] SendData = new byte[512];
            byte[] RecData = new byte[512];


            try
            {
                ToPrBytes(rDaire, ref SendData, 0);
                ToPrBytes(rHak, ref SendData, 2);
                iErr = ExecuteCmd(3, 54, 54, 3, SendData, out RecData);


            }
            catch (Exception hata)
            {

                SaveLogFile(MethodBase.GetCurrentMethod(), hata);
                iErr = TErrors.EXCEPTION;
            }



            return iErr;



        }


        protected int tcpGetHGSDaireParkHak(uint rDaire, out Byte rHak)
        {
            int iErr = 0;
            byte[] SendData = new byte[512];
            byte[] RecData = new byte[512];

            rHak = 0;

            try
            {

                ToPrBytes(rDaire, ref SendData, 0);
                iErr = ExecuteCmd(3, 53, 53, 2, SendData, out RecData);


                if (iErr == 0)
                {
                    rHak = RecData[0];
                }

            }
            catch (Exception hata)
            {

                SaveLogFile(MethodBase.GetCurrentMethod(), hata);
                iErr = TErrors.EXCEPTION;
            }

            return iErr;


        }


        protected int tcpSetHGSSettings(THGS_Settings HGS_Settings)
        {
            int iErr = 0;
            byte[] SendData = new byte[512];
            byte[] RecData = new byte[512];

            try
            {

                SendData[0] = HGS_Settings.PaketBoyu;
                SendData[1] = HGS_Settings.CardBaslangic;
                SendData[2] = HGS_Settings.CardBoyu;
                SendData[3] = HGS_Settings.TrCikisSure1;
                SendData[4] = HGS_Settings.TrCikisSure2;
                SendData[5] = HGS_Settings.ProgramMode;
                SendData[6] = HGS_Settings.DiziEklemeSure1;
                SendData[7] = HGS_Settings.DiziEklemeSure2;
                ToPrBytes(HGS_Settings.ZamanKisitEnb, ref SendData, 8);
                SendData[9] = HGS_Settings.AntenPower1;
                SendData[10] = HGS_Settings.AntenPower2;
                SendData[11] = HGS_Settings.AntenTanitim;
                SendData[12] = HGS_Settings.DefMaksimumArac;
                SendData[13] = HGS_Settings.DefAntiPassPack;
                SendData[13] = HGS_Settings.AppType;


                iErr = ExecuteCmd(3, 40, 40, 15, SendData, out RecData);

            }
            catch (Exception hata)
            {
                SaveLogFile(MethodBase.GetCurrentMethod(), hata);
                iErr = TErrors.EXCEPTION;
            }

            return iErr;


        }



        protected int tcpGetHGSSettings(out THGS_Settings HGS_Settings)
        {
            int iErr = 0;
            byte[] SendData = new byte[512];
            byte[] RecData = new byte[512];


            THGS_Settings tmpSettings = new THGS_Settings();
            HGS_Settings = tmpSettings;

            try
            {
                iErr = ExecuteCmd(3, 39, 39, 0, SendData, out RecData);


                if (iErr == 0)
                {
                    HGS_Settings.PaketBoyu = RecData[0];
                    HGS_Settings.CardBaslangic = RecData[1];
                    HGS_Settings.CardBoyu = RecData[2];
                    HGS_Settings.TrCikisSure1 = RecData[3];
                    HGS_Settings.TrCikisSure2 = RecData[4];
                    HGS_Settings.ProgramMode = RecData[5];
                    HGS_Settings.DiziEklemeSure1 = RecData[6];
                    HGS_Settings.DiziEklemeSure2 = RecData[7];
                    HGS_Settings.ZamanKisitEnb = Convert.ToBoolean(RecData[8]);
                    HGS_Settings.AntenPower1 = RecData[9];
                    HGS_Settings.AntenPower2 = RecData[10];
                    HGS_Settings.AntenTanitim = RecData[11];
                    HGS_Settings.DefMaksimumArac = RecData[12];
                    HGS_Settings.DefAntiPassPack = RecData[13];
                    HGS_Settings.AppType = RecData[14];
                }

            }
            catch (Exception hata)
            {

                SaveLogFile(MethodBase.GetCurrentMethod(), hata);
                iErr = TErrors.EXCEPTION;
            }


            return iErr;

        }




        protected int tcpSetOutOfServiceHolidayList(THolidays Holidays)
        {
            int iErr = 0;
            byte[] SendData = new byte[512];
            byte[] RecData = new byte[512];

            for (int i = 0; i < 29; i++)
            {
                SendData[i * 4] = (byte)(Holidays.List[i].Date).Day;
                SendData[i * 4 + 1] = (byte)(Holidays.List[i].Date).Month;
                SendData[i * 4 + 2] = (byte)((Holidays.List[i].Date).Year - 2000);
                SendData[i * 4 + 3] = Holidays.List[i].OOSTableNo;
            }
            try
            {
                iErr = ExecuteCmd(3, 34, 34, 120, SendData, out RecData);
            }
            catch (Exception hata)
            {
                SaveLogFile(MethodBase.GetCurrentMethod(), hata);
                iErr = TErrors.EXCEPTION;
            }


            return iErr;

        }



        protected int tcpGetOutOfServiceHolidayList(out THolidays Holidays)
        {
            int iErr = 0;
            byte[] SendData = new byte[512];
            byte[] RecData = new byte[512];

            THolidays tmpSettings = new THolidays();
            Holidays = tmpSettings;

            try
            {
                iErr = ExecuteCmd(3, 33, 33, 0, SendData, out RecData);

                if (iErr == 0)
                {
                    for (int i = 0; i < 29; i++)
                    {
                        Holidays.List[i].Date = new DateTime(2000, 1, 1, RecData[i * 4 + 2] + 2000, RecData[i * 4 + 1], RecData[i * 4]);
                        Holidays.List[i].OOSTableNo = RecData[i * 4 + 3];
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


        protected int tcpGetRegularInfo(out DateTime deviceDate, out Byte headTail, out uint head, out uint tail, out uint Capacity)
        {
            int iErr = 0;
            byte[] SendData = new byte[512];
            byte[] RecData = new byte[512];

            deviceDate = DateTime.Today;
            headTail = 0;
            head = 0;
            tail = 0;
            Capacity = 0;
            try
            {
                iErr = ExecuteCmd(3, 17, 17, 0, SendData, out RecData);

                if (iErr == 0)
                {
                    deviceDate = new DateTime(RecData[5] + 2000, RecData[4], RecData[3], RecData[0], RecData[1], RecData[2], 0);
                    headTail = (byte)RecData[6];
                    head = (uint)RecData[7] + (uint)(RecData[8] * 256) + (uint)(RecData[9] * 256 * 256);
                    tail = (uint)RecData[10] + (uint)(RecData[11] * 256) + (uint)(RecData[12] * 256 * 256);
                    Capacity = (uint)RecData[13] + (uint)(RecData[14] * 256) + (uint)(RecData[15] * 256 * 256);
                }


            }
            catch (Exception hata)
            {
                SaveLogFile(MethodBase.GetCurrentMethod(), hata);
                iErr = TErrors.EXCEPTION;
            }


            return iErr;

        }



        protected int tcpSetBellTable(Byte DayNo, TBellTable BellTable)
        {
            int iErr = 0;
            byte[] SendData = new byte[512];
            byte[] RecData = new byte[512];
            SendData[0] = DayNo;

            for (int i = 0; i < 23; i++)
            {
                SendData[i * 3 + 1] = (byte)(BellTable.List[i].StartTime).Hour;
                SendData[i * 3 + 2] = (byte)(BellTable.List[i].StartTime).Minute;
                SendData[i * 3 + 3] = BellTable.List[i].Duration;
            }

            try
            {
                iErr = ExecuteCmd(3, 12, 12, 73, SendData, out RecData);
            }
            catch (Exception hata)
            {

                SaveLogFile(MethodBase.GetCurrentMethod(), hata);
                iErr = TErrors.EXCEPTION;
            }


            return iErr;



        }



        protected int tcpGetBellTable(Byte DayNo, out TBellTable BellTable)
        {

            int iErr = 0;
            byte[] SendData = new byte[512];
            byte[] RecData = new byte[512];

            TBellTable tmpSettings = new TBellTable();
            BellTable = tmpSettings;

            SendData[0] = DayNo;

            try
            {
                iErr = ExecuteCmd(3, 11, 11, 1, SendData, out RecData);

                if (iErr == 0)
                {
                    for (int i = 0; i < 23; i++)
                    {
                        BellTable.List[i].StartTime = new DateTime(2000, 1, 1, RecData[i * 3], RecData[i * 3 + 1], 0, 0);
                        BellTable.List[i].Duration = RecData[i * 3 + 2];
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



        protected int tcpSetEksOtherSettings(TEksOtherSettings EksOtherSettings)
        {
            int iErr = 0;
            byte[] SendData = new byte[512];
            byte[] RecData = new byte[512];


            try
            {

                SendData[0] = EksOtherSettings.PersDataCardSector;
                SendData[1] = EksOtherSettings.AccessDataCardSector;
                iErr = ExecuteCmd(3, 16, 16, 2, SendData, out RecData);


            }
            catch (Exception hata)
            {

                SaveLogFile(MethodBase.GetCurrentMethod(), hata);
                iErr = TErrors.EXCEPTION;
            }


            return iErr;

        }


        protected int tcpGetEksOtherSettings(out TEksOtherSettings EksOtherSettings)
        {

            int iErr = 0;
            byte[] SendData = new byte[512];
            byte[] RecData = new byte[512];


            TEksOtherSettings tmpSettings = new TEksOtherSettings();
            EksOtherSettings = tmpSettings;



            try
            {
                iErr = ExecuteCmd(3, 15, 15, 0, SendData, out RecData);


                if (iErr == 0)
                {
                    tmpSettings.PersDataCardSector = RecData[0];
                    tmpSettings.AccessDataCardSector = RecData[1];
                    EksOtherSettings = tmpSettings;
                }

            }
            catch (Exception hata)
            {

                SaveLogFile(MethodBase.GetCurrentMethod(), hata);
                iErr = TErrors.EXCEPTION;
            }



            return iErr;

        }

        protected int tcpSetTimeConstraintTables(Byte TableNo, TTACList TACList)
        {
            int iErr = 0;
            byte[] SendData = new byte[512];
            byte[] RecData = new byte[512];

            for (int i = 0; i < 8; i++)
            {
                SendData[0] = TableNo;
                SendData[1] = (byte)i;
                for (int j = 0; j < 8; j++)
                {
                    SendData[j * 4 + 2] = (byte)(TACList.Day[i].Part[j].StartTime).Hours;
                    SendData[j * 4 + 3] = (byte)(TACList.Day[i].Part[j].StartTime).Minutes;
                    SendData[j * 4 + 4] = (byte)(TACList.Day[i].Part[j].EndTime).Hours;
                    SendData[j * 4 + 5] = (byte)(TACList.Day[i].Part[j].EndTime).Minutes;
                }
            }


            try
            {

                iErr = ExecuteCmd(3, 14, 14, 34, SendData, out RecData);
            }
            catch (Exception hata)
            {

                SaveLogFile(MethodBase.GetCurrentMethod(), hata);
                iErr = TErrors.EXCEPTION;
            }



            return iErr;

        }


        protected int tcpGetTimeConstraintTables(Byte TableNo, out TTACList TACList)
        {
            int iErr = 0;
            byte[] SendData = new byte[512];
            byte[] RecData = new byte[512];

            TTACList tmpSettings = new TTACList();

            for (int day = 0; day < 8; day++)
            {
                SendData[0] = TableNo;
                SendData[1] = (byte)day;
                try
                {
                    iErr = ExecuteCmd(3, 13, 13, 2, SendData, out RecData);
                    if (iErr == 0)
                    {
                        for (int j = 0; j < 8; j++)
                        {
                            tmpSettings.Day[day].Part[j].StartTime = new TimeSpan(RecData[j * 4], RecData[j * 4 + 1], 0);
                            tmpSettings.Day[day].Part[j].EndTime = new TimeSpan(RecData[j * 4 + 2], RecData[j * 4 + 3], 0);
                        }
                    }
                }
                catch (Exception hata)
                {
                    SaveLogFile(MethodBase.GetCurrentMethod(), hata.Data + " " + hata.Message);
                    iErr = TErrors.EXCEPTION;
                }
            }
            TACList = tmpSettings;
            return iErr;
        }

        protected int tcpSetBellSettings(TBellSettings rSettings)
        {
            int iErr = 0;
            byte[] SendData = new byte[512];
            byte[] RecData = new byte[512];

            try
            {
                ToPrBytes(rSettings.Enabled, ref SendData, 0);
                ToPrBytes(rSettings.ScreenText1, ref SendData, 1, 16);
                ToPrBytes(rSettings.ScreenText2, ref SendData, 17, 16);
                SendData[33] = rSettings.OutType;
                iErr = ExecuteCmd(3, 10, 10, 34, SendData, out RecData);

            }
            catch (Exception hata)
            {

                SaveLogFile(MethodBase.GetCurrentMethod(), hata);
                iErr = TErrors.EXCEPTION;
            }

            return iErr;

        }

        protected int tcpGetBellSettings(out TBellSettings rSettings)
        {

            int iErr = 0;
            byte[] SendData = new byte[512];
            byte[] RecData = new byte[512];


            TBellSettings tmpSettings = new TBellSettings();
            rSettings = tmpSettings;


            try
            {
                iErr = ExecuteCmd(3, 9, 9, 0, SendData, out RecData);

                if (iErr == 0)
                {
                    rSettings.Enabled = prBytesToBoolean(RecData, 0);
                    rSettings.ScreenText1 = prByteToString(RecData, 1, 16);
                    rSettings.ScreenText2 = prByteToString(RecData, 17, 16);
                    rSettings.OutType = RecData[33];
                    tmpSettings = rSettings;
                }

            }
            catch (Exception hata)
            {

                SaveLogFile(MethodBase.GetCurrentMethod(), hata);
                iErr = TErrors.EXCEPTION;
            }


            return iErr;

        }


        protected int tcpSetOutOfServiceTable(TOSTable rTOSTable)
        {

            int iErr = 0;
            byte[] SendData = new byte[512];
            byte[] RecData = new byte[512];


            //TOSTable tmpSettings = new TOSTable();


            for (int i = 0; i < 6; i++)
            {

                for (int j = 0; j < 3; j++)
                {
                    SendData[i * 16 + j * 4] = (byte)(rTOSTable.day[i].part[j].StartTime).Hour;
                    SendData[i * 16 + j * 4 + 1] = (byte)(rTOSTable.day[i].part[j].StartTime).Minute;
                    SendData[i * 16 + j * 4 + 2] = (byte)(rTOSTable.day[i].part[j].EndTime).Hour;
                    SendData[i * 16 + j * 4 + 3] = (byte)(rTOSTable.day[i].part[j].EndTime).Minute;
                }


            }

            try
            {
                iErr = ExecuteCmd(3, 8, 8, 112, SendData, out RecData);
            }
            catch (Exception hata)
            {

                SaveLogFile(MethodBase.GetCurrentMethod(), hata);
                iErr = TErrors.EXCEPTION;
            }

            return iErr;

        }

        protected int tcpGetOutOfServiceTable(out TOSTable rTOSTable)
        {

            int iErr = 0;
            byte[] SendData = new byte[512];
            byte[] RecData = new byte[512];


            TOSTable tmpSettings = new TOSTable();
            //TDayOSS tmpSettings.day = new TDayOSS(); 
            rTOSTable = tmpSettings;


            iErr = ExecuteCmd(3, 7, 7, 0, SendData, out RecData);

            if (iErr == 0)
            {

                for (int i = 0; i <= 6; i++)
                {

                    for (int j = 0; j <= 3; j++)
                    {
                        tmpSettings.day[i].part[j].StartTime = new DateTime(2000, 1, 1, RecData[i * 16 + j * 4], RecData[i * 16 + j * 4 + 1], 0);
                        tmpSettings.day[i].part[j].EndTime = new DateTime(2000, 1, 1, RecData[i * 16 + j * 4 + 2], RecData[i * 16 + j * 4 + 3], 0, 0);


                    }

                }

                rTOSTable = tmpSettings;
            }



            return iErr;


        }

        protected int tcpSetOutOfServiceSettings(TOutOfServiceSettings rSettings)
        {

            int iErr = 0;
            byte[] SendData = new byte[512];
            byte[] RecData = new byte[512];


            try
            {
                ToPrBytes(rSettings.Enabled, ref SendData, 0);
                ToPrBytes(rSettings.ScreenText1, ref SendData, 1, 16);
                ToPrBytes(rSettings.ScreenText2, ref SendData, 17, 16);
                SendData[33] = rSettings.OutType;
                iErr = ExecuteCmd(3, 6, 6, 34, SendData, out RecData);
            }
            catch (Exception hata)
            {

                SaveLogFile(MethodBase.GetCurrentMethod(), hata);
                iErr = TErrors.EXCEPTION;
            }


            return iErr;
        }


        protected int tcpGetOutOfServiceSettings(out TOutOfServiceSettings rSettings)
        {

            int iErr = 0;
            byte[] SendData = new byte[512];
            byte[] RecData = new byte[512];

            TOutOfServiceSettings tmpSettings = new TOutOfServiceSettings();
            rSettings = tmpSettings;


            try
            {
                iErr = ExecuteCmd(3, 5, 5, 0, SendData, out RecData);

                if (iErr == 0)
                {
                    rSettings.Enabled = prBytesToBoolean(RecData, 0);
                    rSettings.ScreenText1 = prByteToString(RecData, 1, 16);
                    rSettings.ScreenText2 = prByteToString(RecData, 17, 16);
                    rSettings.OutType = RecData[33];
                    tmpSettings = rSettings;
                }

            }
            catch (Exception hata)
            {

                SaveLogFile(MethodBase.GetCurrentMethod(), hata);
                iErr = TErrors.EXCEPTION;
            }






            return iErr;
        }


        protected int tcpSetAntiPassbackSettings(TAPBSettings rSettings)
        {
            int iErr = 0;
            byte[] SendData = new byte[512];
            byte[] RecData = new byte[512];

            SendData[0] = rSettings.APBType;
            SendData[1] = rSettings.SequentialTransitionTime;
            SendData[2] = rSettings.SecurityZone;
            SendData[3] = rSettings.ApbInOut;

            try
            {
                iErr = ExecuteCmd(3, 4, 4, 4, SendData, out RecData);
            }
            catch (Exception hata)
            {

                SaveLogFile(MethodBase.GetCurrentMethod(), hata);
                iErr = TErrors.EXCEPTION;
            }



            return iErr;


        }

        protected int tcpGetAntiPassbackSettings(out TAPBSettings rSettings)
        {

            int iErr = 0;
            byte[] SendData = new byte[512];
            byte[] RecData = new byte[512];


            TAPBSettings tmpSettings = new TAPBSettings();
            rSettings = tmpSettings;

            try
            {
                iErr = ExecuteCmd(3, 3, 3, 0, SendData, out RecData);

                if (iErr == 0)
                {
                    tmpSettings.APBType = RecData[0];
                    tmpSettings.SequentialTransitionTime = RecData[1];
                    tmpSettings.SecurityZone = RecData[2];
                    tmpSettings.ApbInOut = RecData[3];
                    rSettings = tmpSettings;
                }


            }
            catch (Exception hata)
            {

                SaveLogFile(MethodBase.GetCurrentMethod(), hata);
                iErr = TErrors.EXCEPTION;
            }



            return iErr;
        }


        protected int tcpSetAppGeneralSettings(TAccessGeneralSettings rSettings)
        {
            int iErr = 0;
            byte[] SendData = new byte[512];
            byte[] RecData = new byte[512];

            try
            {
                SendData[0] = rSettings.InputSettings.InputType;
                ToPrBytes(rSettings.InputSettings.InputDurationTimeout, ref SendData, 1);
                SendData[3] = rSettings.AccessMode.AccessType;
                SendData[4] = rSettings.AccessMode.PasswordType;
                ToPrBytes(rSettings.TimeAccessConstraintEnabled, ref SendData, 5);
                SendData[6] = rSettings.PersonelTimeZoneMode;
                iErr = ExecuteCmd(3, 2, 2, 7, SendData, out RecData);

            }
            catch (Exception hata)
            {

                SaveLogFile(MethodBase.GetCurrentMethod(), hata);
                iErr = TErrors.EXCEPTION;
            }

            return iErr;


        }


        protected int tcpGetWhitelisStatus(out TWhiteListStatus WhiteListStatus)
        {
            int iErr = 0;
            byte[] SendData = new byte[512];
            byte[] RecData = new byte[512];
            TWhiteListStatus result = new TWhiteListStatus();

            try
            {

                iErr = ExecuteCmd(3, 37, 37, 0, SendData, out RecData);
                if (iErr == 0)
                {
                    result.PersCnt = prBytesTouint(RecData, 0);
                    result.rb_ins_tree_root = prBytesTouint(RecData, 4);
                    result.rb_Del_tree_root = prBytesTouint(RecData, 8);
                    result.InsNode.Adress = prBytesTouint(RecData, 12);
                    for (int i = 0; i < 7; i++)
                        result.InsNode.Value[i] = RecData[i + 16];
                    result.InsNode.Color = RecData[23];
                    result.InsNode.Left = prBytesTouint(RecData, 24);
                    result.InsNode.Right = prBytesTouint(RecData, 28);
                    result.InsNode.Parent = prBytesTouint(RecData, 32);
                    result.DelNode.Adress = prBytesTouint(RecData, 36);
                    for (int i = 0; i < 7; i++)
                        result.DelNode.Value[i] = RecData[i + 40];

                    result.DelNode.Color = RecData[47];
                    result.DelNode.Left = prBytesTouint(RecData, 48);
                    result.DelNode.Right = prBytesTouint(RecData, 52);
                    result.DelNode.Parent = prBytesTouint(RecData, 56);
                }

            }
            catch (Exception hata)
            {

                SaveLogFile(MethodBase.GetCurrentMethod(), hata);
                iErr = TErrors.EXCEPTION;
            }

            WhiteListStatus = result;
            return iErr;

        }


        protected int tcpSetWhitelisStatus(TWhiteListStatus WhiteListStatus)
        {
            int iErr = 0;
            byte[] SendData = new byte[512];
            byte[] RecData = new byte[512];

            try
            {
                ToPrBytes(WhiteListStatus.PersCnt, ref SendData, 0);
                ToPrBytes(WhiteListStatus.rb_ins_tree_root, ref SendData, 4);
                ToPrBytes(WhiteListStatus.rb_Del_tree_root, ref SendData, 8);
                ToPrBytes(WhiteListStatus.InsNode.Adress, ref SendData, 12);

                for (int i = 0; i < 7; i++)
                    SendData[i + 16] = WhiteListStatus.InsNode.Value[i];

                SendData[23] = WhiteListStatus.InsNode.Color;
                ToPrBytes(WhiteListStatus.InsNode.Left, ref SendData, 24);
                ToPrBytes(WhiteListStatus.InsNode.Right, ref SendData, 28);
                ToPrBytes(WhiteListStatus.InsNode.Parent, ref SendData, 32);
                ToPrBytes(WhiteListStatus.DelNode.Adress, ref SendData, 36);

                for (int i = 0; i < 7; i++)
                    SendData[i + 40] = WhiteListStatus.DelNode.Value[i];

                SendData[47] = WhiteListStatus.DelNode.Color;

                ToPrBytes(WhiteListStatus.DelNode.Left, ref SendData, 48);
                ToPrBytes(WhiteListStatus.DelNode.Right, ref SendData, 52);
                ToPrBytes(WhiteListStatus.DelNode.Parent, ref SendData, 56);
                iErr = ExecuteCmd(3, 38, 38, 60, SendData, out RecData);

            }
            catch (Exception hata)
            {

                SaveLogFile(MethodBase.GetCurrentMethod(), hata);
                iErr = TErrors.EXCEPTION;
            }


            return iErr;

        }

        protected int tcpGetTreeNode(uint Address, out Ttree_Node Node)
        {

            int iErr = 0;
            byte[] SendData = new byte[512];
            byte[] RecData = new byte[512];
            Ttree_Node rNode = new Ttree_Node();
            try
            {
                ToPrBytes(Address, ref SendData, 0);
                iErr = ExecuteCmd(3, 61, 61, 4, SendData, out RecData);

                if (iErr == 0)
                {
                    rNode.Adress = prBytesTouint(RecData, 0);
                    for (int i = 0; i < 7; i++)
                        rNode.Value[i] = RecData[i + 4];

                    rNode.Color = RecData[11];
                    rNode.Left = prBytesTouint(RecData, 12);
                    rNode.Right = prBytesTouint(RecData, 16);
                    rNode.Parent = prBytesTouint(RecData, 20);
                }

            }
            catch (Exception hata)
            {

                SaveLogFile(MethodBase.GetCurrentMethod(), hata);
                iErr = TErrors.EXCEPTION;
            }

            Node = rNode;
            return iErr;
        }


        protected int tcpSetTreeNode(Ttree_Node Node)
        {

            int iErr = 0;
            byte[] SendData = new byte[512];
            byte[] RecData = new byte[512];
            try
            {

                ToPrBytes(Node.Adress, ref SendData, 0);
                for (int i = 0; i < 7; i++)
                    SendData[i + 4] = Node.Value[i];

                SendData[11] = Node.Color;
                ToPrBytes(Node.Left, ref SendData, 12);
                ToPrBytes(Node.Right, ref SendData, 16);
                ToPrBytes(Node.Parent, ref SendData, 20);
                iErr = ExecuteCmd(3, 62, 62, 24, SendData, out RecData);
            }
            catch (Exception hata)
            {

                SaveLogFile(MethodBase.GetCurrentMethod(), hata);
                iErr = TErrors.EXCEPTION;
            }
            return iErr;
        }


        protected int tcpSetStatusMode(byte StatusMode, byte StatusModeType)
        {
            int iErr = 0;
            byte[] SendData = new byte[512];
            byte[] RecData = new byte[512];
            try
            {
                SendData[0] = StatusMode;
                SendData[1] = StatusModeType;
                iErr= ExecuteCmd(3, // CmdNo
                                 64, // SubCmdNo
                                 64, // Acknowledge
                                 2, // DataLen
                                 SendData, out RecData // SelectTimeOut
                                 );

            }
            catch (Exception hata)
            {
                SaveLogFile(MethodBase.GetCurrentMethod(), hata);
                iErr = TErrors.EXCEPTION;
            }

            return iErr;

        }
        protected int tcpGetStatusMode(out byte StatusMode, out byte StatusModeType)
        {
            int iErr = 0;
            byte[] SendData = new byte[512];
            byte[] RecData = new byte[512];
            StatusMode = 0;
            StatusModeType = 0;
            try
            {
                iErr= ExecuteCmd(3, // CmdNo
                                 63, // SubCmdNo
                                 63, // Acknowledge
                                 0, // DataLen
                                 SendData, out RecData // SelectTimeOut
                                 );

                if (iErr == 0)
                {
                    StatusMode= RecData[0];
                    StatusModeType= RecData[1];
                }

            }
            catch (Exception hata)
            {
                SaveLogFile(MethodBase.GetCurrentMethod(), hata);
                iErr = TErrors.EXCEPTION;
            }

            return iErr;

        }

        protected int tcpGetAppGeneralSettings(out TAccessGeneralSettings rSettings)
        {
            int iErr = 0;
            byte[] SendData = new byte[512];
            byte[] RecData = new byte[512];

            TAccessGeneralSettings tmpSettings = new TAccessGeneralSettings();
            rSettings = tmpSettings;


            try
            {
                iErr = ExecuteCmd(3, 1, 1, 0, SendData, out RecData);

                if (iErr == 0)
                {
                    rSettings.InputSettings.InputType = RecData[0];
                    rSettings.InputSettings.InputDurationTimeout = prBytesToushort(RecData, 1);
                    rSettings.AccessMode.AccessType = RecData[3];
                    rSettings.AccessMode.PasswordType = RecData[4];
                    rSettings.TimeAccessConstraintEnabled = prBytesToBoolean(RecData, 5);
                    rSettings.PersonelTimeZoneMode = RecData[6];
                }

            }
            catch (Exception hata)
            {
                SaveLogFile(MethodBase.GetCurrentMethod(), hata);
                iErr = TErrors.EXCEPTION;
            }

            return iErr;


        }



        protected int tcpSetAppFactoryDefault(Boolean Reboot)
        {
            int iErr = 0;
            byte[] SendData = new byte[512];
            byte[] RecData = new byte[512];


            try
            {

                if (Reboot == true)
                {
                    SendData[0] = 1;
                }
                else
                {
                    SendData[0] = 0;
                }

                iErr = ExecuteCmd(3, 36, 36, 1, SendData, out RecData, 1000, 1);

            }
            catch (Exception hata)
            {
                SaveLogFile(MethodBase.GetCurrentMethod(), hata);
                iErr = TErrors.EXCEPTION;
            }

            return iErr;
        }



        protected int tcpAddWhitelist(TPerson rPerson, out uint IndexNo) // CMD 3.18
        {
            int iErr = 0;
            byte[] SendData = new byte[512];
            byte[] RecData = new byte[512];
            IndexNo = 0;

            int OldCmdretry = CommandRetry;

            try
            {
                CommandRetry = 1;

                ToPrBytesFromHex(rPerson.CardID, ref SendData, 0);
                ToPrBytes(rPerson.Name, ref SendData, 7, 18);
                SendData[25] = rPerson.TimeZoneListNo;
                ToPrBytes(rPerson.Code, ref SendData, 26);
                ToPrBytes(rPerson.Password, ref SendData, 30);

                ToPrBytes(rPerson.EndDate, ref SendData, 32);

                ToPrBytes(rPerson.AccessDevice, ref SendData, 35);
                ToPrBytes(rPerson.APBEnabled, ref SendData, 36);
                ToPrBytes(rPerson.TZEnabled, ref SendData, 37);
                ToPrBytes(rPerson.AccessCardEnabled, ref SendData, 38);
                ToPrBytes(rPerson.IsOnlineCard, ref SendData, 39);
                ToPrBytes(rPerson.PermitedInEmergency, ref SendData, 40);
                ToPrBytes(rPerson.BirthDate, ref SendData, 41);
                ToPrBytes(rPerson.WeeklyTotalMealCount, ref SendData, 44);
                ToPrBytes(rPerson.MonthlyTotalMealCount, ref SendData, 45);
                ToPrBytes(rPerson.MealSettingListNo, ref SendData, 46);
                ToPrBytes(rPerson.BlackListCmdNo, ref SendData, 47);
                ToPrBytes(rPerson.NeedCmdControl, ref SendData, 48);
                for (int i = 49; i < 52; i++)
                    SendData[i] = 0;

                iErr = ExecuteCmd(3, // CmdNo
                        18, // SubCmdNo
                        18, // Acknowledge
                        52, // DataLen
                        SendData, out RecData, 100 // SelectTimeOut
                        );
                if (iErr == 0)
                {
                    IndexNo = prBytesTouint(RecData, 0);
                }

            }
            catch (Exception e)
            {
                iErr = TErrors.EXCEPTION;
                SaveLogFile(MethodBase.GetCurrentMethod(), e);
            }
            CommandRetry = OldCmdretry;
            return iErr;
        }

        protected int tcpGetWhitelistWithCardID(String CardID, out TPerson rPerson, out uint IndexNo)// CMD 3.19
        {
            int iErr = 0;
            byte[] SendData = new byte[512];
            byte[] RecData = new byte[512];
            IndexNo = 0;
            rPerson = new TPerson();

            try
            {
                ToPrBytesFromHex(CardID, ref SendData, 0);
                iErr = ExecuteCmd(3, // CmdNo
                        19, // SubCmdNo
                        19, // Acknowledge
                        7, // DataLen
                        SendData, out RecData);
                if (iErr == 0)
                {
                    rPerson.CardID = prBytesToHex(RecData, 0, 7);
                    rPerson.Name = prByteToString(RecData, 7, 18).Trim();
                    rPerson.TimeZoneListNo = RecData[25];
                    rPerson.Code = prBytesTouint(RecData, 26);
                    rPerson.Password = prBytesToushort(RecData, 30);
                    rPerson.EndDate = new DateTime((int)RecData[34] + 2000, (int)RecData[33], (int)RecData[32]);
                    rPerson.AccessDevice = prBytesToBoolean(RecData, 35);
                    rPerson.APBEnabled = prBytesToBoolean(RecData, 36);
                    rPerson.TZEnabled = prBytesToBoolean(RecData, 37);
                    rPerson.AccessCardEnabled = prBytesToBoolean(RecData, 38);
                    rPerson.IsOnlineCard = prBytesToBoolean(RecData, 39);
                    rPerson.PermitedInEmergency = prBytesToBoolean(RecData, 40);
                    rPerson.BirthDate = new DateTime((int)RecData[43] + 2000, (int)RecData[42], (int)RecData[41]);
                    rPerson.WeeklyTotalMealCount = RecData[44];
                    rPerson.MonthlyTotalMealCount = RecData[45];
                    rPerson.MealSettingListNo = RecData[46];
                    rPerson.BlackListCmdNo = RecData[47];
                    rPerson.NeedCmdControl = RecData[48];
                    IndexNo = prBytesTouint(RecData, 52);
                }
            }
            catch (Exception e)
            {
                iErr = TErrors.EXCEPTION;
                SaveLogFile(MethodBase.GetCurrentMethod(), e);
            }
            return iErr;
        }

        protected int tcpEditWhitelistWithCardID(TPerson rPerson, out uint IndexNo) // CMD 3.21
        {
            int iErr = 0;
            byte[] SendData = new byte[512];
            byte[] RecData = new byte[512];
            IndexNo = 0;

            try
            {

                ToPrBytesFromHex(rPerson.CardID, ref SendData, 0);
                ToPrBytes(rPerson.Name, ref SendData, 7, 18);
                SendData[25] = rPerson.TimeZoneListNo;
                ToPrBytes(rPerson.Code, ref SendData, 26);
                ToPrBytes(rPerson.Password, ref SendData, 30);
                ToPrBytes(rPerson.EndDate, ref SendData, 32);
                ToPrBytes(rPerson.AccessDevice, ref SendData, 35);
                ToPrBytes(rPerson.APBEnabled, ref SendData, 36);
                ToPrBytes(rPerson.TZEnabled, ref SendData, 37);
                ToPrBytes(rPerson.AccessCardEnabled, ref SendData, 38);
                ToPrBytes(rPerson.IsOnlineCard, ref SendData, 39);
                ToPrBytes(rPerson.PermitedInEmergency, ref SendData, 40);
                ToPrBytes(rPerson.BirthDate, ref SendData, 41);
                ToPrBytes(rPerson.WeeklyTotalMealCount, ref SendData, 44);
                ToPrBytes(rPerson.MonthlyTotalMealCount, ref SendData, 45);
                ToPrBytes(rPerson.MealSettingListNo, ref SendData, 46);
                ToPrBytes(rPerson.BlackListCmdNo, ref SendData, 47);
                ToPrBytes(rPerson.NeedCmdControl, ref SendData, 48);
                for (int i = 49; i < 52; i++)
                    SendData[i] = 0;

                iErr = ExecuteCmd(3, // CmdNo
                        21, // SubCmdNo
                        21, // Acknowledge
                        52, // DataLen
                        SendData, out RecData);
                if (iErr == 0)
                {
                    IndexNo = prBytesTouint(RecData, 0);
                }

            }
            catch (Exception e)
            {
                iErr = TErrors.EXCEPTION;
                SaveLogFile(MethodBase.GetCurrentMethod(), e);
            }
            return iErr;
        }

        protected int tcpDeleteWhitelistWithCardID(string CardID, out uint IndexNo)// CMD 3.23
        {
            int iErr = 0;
            byte[] SendData = new byte[512];
            byte[] RecData = new byte[512];
            IndexNo = 0;
            int OldCmdretry = CommandRetry;

            try
            {
                CommandRetry = 1;
                ToPrBytesFromHex(CardID, ref SendData, 0);
                iErr = ExecuteCmd(3, // CmdNo
                        23, // SubCmdNo
                        23, // Acknowledge
                        7, // DataLen
                        SendData, out RecData, 3000, 1);
                if (iErr == 0)
                {
                    IndexNo = prBytesTouint(RecData, 0);
                }
            }
            catch (Exception e)
            {
                iErr = TErrors.EXCEPTION;
                SaveLogFile(MethodBase.GetCurrentMethod(), e);
            }
            CommandRetry = OldCmdretry;
            return iErr;
        }

        protected int tcpGetWhitelistCardIDCount(out uint WhiteListCnt)// CMD 3.25
        {
            int iErr = 0;
            byte[] SendData = new byte[512];
            byte[] RecData = new byte[512];
            WhiteListCnt = 0;

            try
            {
                iErr = ExecuteCmd(3, // CmdNo
                        25, // SubCmdNo
                        25, // Acknowledge
                        0, // DataLen
                        SendData, out RecData, 100 // SelectTimeOut
                        );
                if (iErr == 0)
                    WhiteListCnt = prBytesTouint(RecData, 0);
            }
            catch (Exception e)
            {
                iErr = TErrors.EXCEPTION;
                SaveLogFile(MethodBase.GetCurrentMethod(), e);
            }
            return iErr;
        }

        protected int tcpIsCardIDExistInWhitelist(String CardID, out uint IndexNo)// CMD 3.27
        {
            int iErr = 0;
            byte[] SendData = new byte[512];
            byte[] RecData = new byte[512];
            IndexNo = 0;

            try
            {
                ToPrBytesFromHex(CardID, ref SendData, 0);

                iErr = ExecuteCmd(3, // CmdNo
                        27, // SubCmdNo
                        27, // Acknowledge
                        7, // DataLen
                        SendData, out RecData, 100 // SelectTimeOut
                        );
                if (iErr == 0)
                {
                    IndexNo = prBytesTouint(RecData, 0);
                }
            }
            catch (Exception e)
            {
                iErr = TErrors.EXCEPTION;
                SaveLogFile(MethodBase.GetCurrentMethod(), e);
            }
            return iErr;
        }

        protected int tcpReadRecords(uint StartFrom, uint HowMany, out TAccessRecords Recs)// // CMD 3.29
        {
            int iErr = 0;
            byte[] SendData = new byte[512];
            byte[] RecData = new byte[512];

            int RecordSize = 17;
            uint TransferredCount = 0;
            uint TempStartFrom = StartFrom;
            uint ReceivedCount;
            byte TempCountPerTime;
            TAccessRecords tempRecs = new TAccessRecords();
            tempRecs.Count = 0;
            tempRecs.raDeviceRecs = new TOneRecord[HowMany];
            string CardId;

            Recs = tempRecs;
            try
            {

                do
                {
                    if ((HowMany - TransferredCount) >= 12)
                        TempCountPerTime = 12;
                    else
                        TempCountPerTime = (byte)(HowMany - TransferredCount);

                    SendData[0] = (byte)(TempStartFrom & 0xFF);
                    SendData[1] = (byte)((TempStartFrom >> 8) & 0xFF);
                    SendData[2] = (byte)((TempStartFrom >> 16) & 0xFF);
                    SendData[3] = TempCountPerTime;
                    iErr = ExecuteCmd(3, // CmdNo
                        29, // SubCmdNo
                        29, // Acknowledge
                        4,  // DataLen
                        SendData, out RecData // SelectTimeOut
                        );
                    if (iErr == 0)
                    {

                        ReceivedCount = RecData[0];
                        tempRecs.Count = tempRecs.Count + ReceivedCount;

                        //SetLength(tempRecs.raDeviceRecs,tempRecs.Count); Baþta Set ettik deðeri
                        for (int i = 0; i < ReceivedCount; i++)
                        {
                            CardId = "";
                            CardId = prBytesToHex(RecData, (RecordSize * i) + 1, 7);
                            tempRecs.raDeviceRecs[i + TransferredCount].CardID = CardId;
                            tempRecs.raDeviceRecs[i + TransferredCount].DoorNo = RecData[(RecordSize * i) + 8];
                            tempRecs.raDeviceRecs[i + TransferredCount].RecordType = RecData[(RecordSize * i) + 9];
                            tempRecs.raDeviceRecs[i + TransferredCount].TimeDate = prBytesToDateTimeEx(RecData, (RecordSize * i) + 10);
                            //tempRecs.raDeviceRecs[i+TransferredCount].RFU[0]     = RecData[(RecordSize*i)+16];
                            //tempRecs.raDeviceRecs[i+TransferredCount].RFU[1]     = RecData[(RecordSize*i)+17];

                        }
                        TransferredCount = TransferredCount + ReceivedCount;
                        TempStartFrom = (TempStartFrom + ReceivedCount);
                    }
                } while ((TransferredCount < HowMany) && (iErr == 0));
                if (iErr == 0)
                    Recs = tempRecs;
            }
            catch (Exception e)
            {
                iErr = TErrors.EXCEPTION;
                SaveLogFile(MethodBase.GetCurrentMethod(), e);
            }
            return iErr;
        }

        private int ConfirmRecs(byte uTransferredCount)
        {
            int iErr = 0;
            byte[] SendData = new byte[512];
            byte[] RecData = new byte[512];

            try
            {
                SendData[0] = uTransferredCount;
                iErr = ExecuteCmd(3, // CmdNo
                    31, // SubCmdNo
                    31, // Acknowledge
                    1,  // DataLen
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

        protected int tcpTransferRecords(out TAccessRecords Recs) // CMD 3.30
        {
            int iErr = 0;
            byte[] SendData = new byte[512];
            byte[] RecData = new byte[512];

            int RecordSize = 17;
            uint TransferredCount = 0;
            //uint ReceivedCount = 0;
            int Head, Tail, Capacity;
            int CountToTransfer;
            int CountPerTime, StartFrom;
            byte TempCountPerTime;

            TAccessRecords tempRecs = new TAccessRecords();
            tempRecs.Count = 0;
            tempRecs.raDeviceRecs = new TOneRecord[0];
            TAccessRecords notConfRecs = new TAccessRecords();
            notConfRecs.Count = 0;
            notConfRecs.raDeviceRecs = new TOneRecord[0];
            string CardId;

            Recs = tempRecs;
            try
            {
                iErr = tcpGetHeadTailCapacity(out Head, out Tail, out Capacity);
                if (iErr == 0)
                {
                    if (Head > Tail)
                        CountToTransfer = (Head - Tail);
                    else
                        CountToTransfer = (Capacity - Tail + Head);
                    CountPerTime = 12;
                    StartFrom = Tail;
                    do
                    {
                        if ((CountToTransfer - tempRecs.Count) >= CountPerTime)
                            TempCountPerTime = (byte)(CountPerTime);
                        else
                            TempCountPerTime = (byte)(CountToTransfer - tempRecs.Count);

                        SendData[0] = TempCountPerTime;
                        iErr = ExecuteCmd(3, // CmdNo
                            30, // SubCmdNo
                            30, // Acknowledge
                            1,  // DataLen
                            SendData, out RecData // SelectTimeOut
                            );
                        if (iErr == 0)
                        {
                            notConfRecs.Count = RecData[0];
                            Array.Resize(ref notConfRecs.raDeviceRecs, (byte)notConfRecs.Count);
                            for (int i = 0; i < notConfRecs.Count; i++)
                            {
                                // Card ID
                                CardId = "";
                                CardId = prBytesToHex(RecData, (RecordSize * i) + 1, 7);
                                notConfRecs.raDeviceRecs[i + TransferredCount].CardID = CardId;
                                // Door No
                                notConfRecs.raDeviceRecs[i + TransferredCount].DoorNo = RecData[(RecordSize * i) + 8];
                                // Record Type
                                notConfRecs.raDeviceRecs[i + TransferredCount].RecordType = RecData[(RecordSize * i) + 9];
                                // RFU
                                // Date Time
                                notConfRecs.raDeviceRecs[i + TransferredCount].TimeDate
                                    = prBytesToDateTimeEx(RecData, (RecordSize * i) + 10);
                            }
                            iErr = ConfirmRecs((byte)notConfRecs.Count);
                            if (iErr == 0)
                            {
                                Array.Resize(ref tempRecs.raDeviceRecs, (int)(tempRecs.Count + notConfRecs.Count));
                                for (uint i = tempRecs.Count; i < (tempRecs.Count + notConfRecs.Count); i++)
                                    tempRecs.raDeviceRecs[i] = notConfRecs.raDeviceRecs[i - tempRecs.Count];
                                tempRecs.Count = tempRecs.Count + notConfRecs.Count;
                            }
                        }
                    } while ((CountToTransfer > tempRecs.Count) && (iErr == 0));
                }
                if (iErr == 0)
                    Recs = tempRecs;

            }
            catch (Exception e)
            {
                iErr = TErrors.EXCEPTION;
                SaveLogFile(MethodBase.GetCurrentMethod(), e);
            }
            return iErr;
        }

        protected int tcpClearWhitelist()// CMD 3.32
        {
            int iErr = 0;
            byte[] SendData = new byte[512];
            byte[] RecData = new byte[512];

            try
            {
                iErr = ExecuteCmd(3, // CmdNo
                        32, // SubCmdNo
                        32, // Acknowledge
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


        public int AddBlackList(TBlackList rBlackList, out uint IndexNum, Boolean IfExistEdit = false)
        {
            TPerson rPerson = new TPerson();
            int iErr = 0, lclErr = 0;
            IndexNum = 0;

            rPerson.CardID = rBlackList.CardID;
            rPerson.Name = rBlackList.Caption;
            rPerson.BlackListCmdNo = rBlackList.BlackListCmdNo;

            try
            {
                lclErr = IsCardIDExistInWhitelistX(rBlackList.CardID, out IndexNum);

                switch (lclErr)
                {
                    case 0:
                        iErr = tcpAddWhitelist(rPerson, out IndexNum);
                        //if (iErr <> 0) then
                        //    LogDebug('AddWhitelist(*)','Error  ('+IntToStr(iErr)+') ',0);
                        break;
                    case 51:
                        iErr = lclErr;
                        //LogDebug('AddWhitelist','CardID Exists <'+rPerson.CardID+'>  ',0);
                        if (IfExistEdit)
                            iErr = EditWhitelistWithCardID(rPerson, out IndexNum);
                        break;
                    default:
                        //LogDebug('AddWhitelist','Error  ('+IntToStr(lclErr)+') ',0);
                        iErr = lclErr;
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

        public int DeleteBlacklistWithCardID(string CardID, out uint IndexNum)
        {
            TPerson rPerson = new TPerson();
            int iErr = 0, lclErr = 0;
            IndexNum = 0;

            try
            {
                lclErr = IsCardIDExistInWhitelistX(CardID, out IndexNum);

                switch (lclErr)
                {
                    case 0:
                        if (iErr != 0)
                            SaveLogFile("DeleteWhitelistWithCardID", "Error : " + lclErr.ToString());
                        break;
                    case 51:
                        iErr = tcpDeleteWhitelistWithCardID(CardID, out IndexNum);
                        break;
                    default:
                        SaveLogFile("DeleteWhitelistWithCardID", "Error : " + lclErr.ToString());
                        iErr = lclErr;
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

        public int GetBlacklistWithCardID(string CardID, out TBlackList rBlackList, out uint IndexNum)
        {
            TBlackList rBlckListPerson = new TBlackList();
            TPerson rPerson = new TPerson();
            int iErr = 0;
            IndexNum = 0;

            try
            {
                iErr = tcpGetWhitelistWithCardID(CardID, out rPerson, out IndexNum);
                if (iErr == 0)
                {
                    rBlckListPerson.CardID = rPerson.CardID;
                    rBlckListPerson.Caption = rPerson.Name;
                    rBlckListPerson.BlackListCmdNo = rPerson.BlackListCmdNo;
                }
            }
            catch (Exception e)
            {
                iErr = TErrors.EXCEPTION;
                SaveLogFile(MethodBase.GetCurrentMethod(), e);
            }
            rBlackList = rBlckListPerson;
            return iErr;

        }

        public int EditBlacklistWithCardID(TBlackList rBlackList, out uint IndexNum)
        {
            TPerson rPerson = new TPerson();
            int iErr = 0;
            IndexNum = 0;

            rPerson.CardID = rBlackList.CardID;
            rPerson.Name = rBlackList.Caption;
            rPerson.BlackListCmdNo = rBlackList.BlackListCmdNo;

            try
            {

                iErr = tcpEditWhitelistWithCardID(rPerson, out IndexNum);
            }
            catch (Exception e)
            {
                iErr = TErrors.EXCEPTION;
                SaveLogFile(MethodBase.GetCurrentMethod(), e);
            }
            return iErr;

        }


        public int AddWhitelist(TPerson rPerson, Boolean IfExistEdit = false)
        {
            uint InxNm;
            return AddWhitelist(rPerson, out InxNm, IfExistEdit);
        }

        public int AddWhitelist(TPerson rPerson, out uint IndexNum, Boolean IfExistEdit = false)
        {
            int iErr = 0, lclErr = 0;
            IndexNum = 0;
            try
            {
                lclErr = IsCardIDExistInWhitelistX(rPerson.CardID, out IndexNum);

                switch (lclErr)
                {
                    case 0:
                        iErr = tcpAddWhitelist(rPerson, out IndexNum);
                        //if (iErr <> 0) then
                        //    LogDebug('AddWhitelist(*)','Error  ('+IntToStr(iErr)+') ',0);
                        break;
                    case 51:
                        iErr = lclErr;
                        //LogDebug('AddWhitelist','CardID Exists <'+rPerson.CardID+'>  ',0);
                        if (IfExistEdit)
                            iErr = EditWhitelistWithCardID(rPerson, out IndexNum);
                        break;
                    default:
                        //LogDebug('AddWhitelist','Error  ('+IntToStr(lclErr)+') ',0);
                        iErr = lclErr;
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

        public int GetWhitelistWithCardID(string CardID, out TPerson rPerson)
        {
            uint InxNm;
            return tcpGetWhitelistWithCardID(CardID, out rPerson, out InxNm);
        }

        public int GetWhitelistWithCardID(string CardID, out TPerson rPerson, out uint IndexNum)
        {
            return tcpGetWhitelistWithCardID(CardID, out rPerson, out IndexNum);
        }

        public int EditWhitelistWithCardID(TPerson rPerson)
        {
            uint InxNm;
            return tcpEditWhitelistWithCardID(rPerson, out InxNm);
        }

        public int EditWhitelistWithCardID(TPerson rPerson, out uint IndexNum)
        {
            return tcpEditWhitelistWithCardID(rPerson, out IndexNum);
        }

        public int DeleteWhitelistWithCardID(string CardID)
        {
            uint InxNm;
            return DeleteWhitelistWithCardID(CardID, out InxNm);
        }

        public int DeleteWhitelistWithCardID(string CardID, out uint IndexNum)
        {
            int iErr = 0, lclErr = 0;
            IndexNum = 0;
            try
            {
                lclErr = IsCardIDExistInWhitelistX(CardID, out IndexNum);

                switch (lclErr)
                {
                    case 0:
                        iErr = 12;
                        //if (iErr <> 0) then
                        //    LogDebug('DeleteWhitelistWithCardID','Error  ('+IntToStr(lclErr)+') ',0);
                        break;
                    case 51:
                        iErr = tcpDeleteWhitelistWithCardID(CardID, out IndexNum);
                        //if (iErr <> 0) then
                        //    LogDebug('DeleteWhitelistWithCardID','Error  ('+IntToStr(iErr)+') ',0);
                        break;
                    default:
                        //LogDebug('DeleteWhitelistWithCardID','Error  ('+IntToStr(lclErr)+') ',0);
                        iErr = lclErr;
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

        public Boolean IsCardIDExistInWhitelist(string CardID)
        {
            uint InxNm;
            return (tcpIsCardIDExistInWhitelist(CardID, out InxNm) == 0);
        }

        public Boolean IsCardIDExistInWhitelist(string CardID, out uint IndexNum)
        {
            return (tcpIsCardIDExistInWhitelist(CardID, out IndexNum) == 0);
        }

        public int IsCardIDExistInWhitelistX(string CardID)
        {
            uint InxNm;
            return tcpIsCardIDExistInWhitelist(CardID, out InxNm);
        }

        public int IsCardIDExistInWhitelistX(string CardID, out uint IndexNum)
        {
            return tcpIsCardIDExistInWhitelist(CardID, out IndexNum);
        }

        public int GetWhitelistCardIDCount()
        {
            uint Cnt;
            if (tcpGetWhitelistCardIDCount(out Cnt) == 0)
                return (int)Cnt;
            else
                return -1;
        }

        public Boolean ReadRecords(uint StartFrom, uint HowMany, out TAccessRecords Recs)// // CMD 3.29
        {
            return (tcpReadRecords(StartFrom, HowMany, out Recs) == 0);
        }

        public Boolean TransferRecords(out TAccessRecords Recs)// // CMD 3.29
        {
            return (tcpTransferRecords(out Recs) == 0);
        }

        public Boolean ClearWhitelist()
        {
            return (tcpClearWhitelist() == 0);
        }

        public Boolean SetAppFactoryDefault(Boolean Reboot)
        {
            return (tcpSetAppFactoryDefault(Reboot) == 0);
        }

        public Boolean GetWhitelisStatus(out TWhiteListStatus WhiteListStatus)
        {
            return (tcpGetWhitelisStatus(out WhiteListStatus) == 0);
        }

        public Boolean SetWhitelisStatus(TWhiteListStatus WhiteListStatus)
        {
            return (tcpSetWhitelisStatus(WhiteListStatus) == 0);
        }

        public Boolean GetTreeNode(uint Address, out Ttree_Node Node)
        {
            return (tcpGetTreeNode(Address, out Node) == 0);
        }

        public Boolean SetTreeNode(Ttree_Node Node)
        {
            return (tcpSetTreeNode(Node) == 0);
        }

        public Boolean SetStatusMode(byte StatusMode, byte StatusModeType)
        {
            //return (tcpGetStatusMode(out StatusMode, out StatusModeType) == 0);
            return (tcpSetStatusMode(StatusMode, StatusModeType) == 0);
        }

        public Boolean GetStatusMode(out byte StatusMode, out byte StatusModeType)
        {
            return (tcpGetStatusMode(out StatusMode, out StatusModeType) == 0);            
        }

        public Boolean GetAppGeneralSettings(out TAccessGeneralSettings rSettings)
        {
            return (tcpGetAppGeneralSettings(out rSettings) == 0);
        }

        public Boolean SetAppGeneralSettings(TAccessGeneralSettings rSettings)
        {
            return (tcpSetAppGeneralSettings(rSettings) == 0);
        }

        public Boolean GetAntiPassbackSettings(out TAPBSettings rSettings)
        {
            return (tcpGetAntiPassbackSettings(out rSettings) == 0);
        }

        public Boolean SetAntiPassbackSettings(TAPBSettings rSettings)
        {
            return (tcpSetAntiPassbackSettings(rSettings) == 0);
        }

        public Boolean GetOutOfServiceSettings(out TOutOfServiceSettings rSettings)
        {
            return (tcpGetOutOfServiceSettings(out rSettings) == 0);
        }

        public Boolean SetOutOfServiceSettings(TOutOfServiceSettings rSettings)
        {
            return (tcpSetOutOfServiceSettings(rSettings) == 0);
        }

        public Boolean GetOutOfServiceTable(out TOSTable rTOSTable)
        {
            return (tcpGetOutOfServiceTable(out rTOSTable) == 0);
        }

        public Boolean SetOutOfServiceTable(TOSTable rTOSTable)
        {
            return (tcpSetOutOfServiceTable(rTOSTable) == 0);
        }

        public Boolean GetBellSettings(out TBellSettings rSettings)
        {
            return (tcpGetBellSettings(out rSettings) == 0);
        }

        public Boolean SetBellSettings(TBellSettings rSettings)
        {
            return (tcpSetBellSettings(rSettings) == 0);
        }

        public Boolean GetTimeConstraintTables(byte TableNo, out TTACList TACList)
        {
            return (tcpGetTimeConstraintTables(TableNo, out TACList) == 0);
        }

        public Boolean SetTimeConstraintTables(byte TableNo, TTACList TACList)
        {
            return (tcpSetTimeConstraintTables(TableNo, TACList) == 0);
        }

        public Boolean GetEksOtherSettings(out TEksOtherSettings EksOtherSettings)
        {
            return (tcpGetEksOtherSettings(out EksOtherSettings) == 0);
        }

        public Boolean SetEksOtherSettings(TEksOtherSettings EksOtherSettings)
        {
            return (tcpSetEksOtherSettings(EksOtherSettings) == 0);
        }

        public Boolean GetBellTable(Byte DayNo, out TBellTable BellTable)
        {
            return (tcpGetBellTable(DayNo, out BellTable) == 0);
        }

        public Boolean SetBellTable(Byte DayNo, TBellTable BellTable)
        {
            return (tcpSetBellTable(DayNo, BellTable) == 0);
        }


        public Boolean GetOutOfServiceHolidayList(out THolidays Holidays)
        {
            return (tcpGetOutOfServiceHolidayList(out Holidays) == 0);
        }


        public Boolean SetOutOfServiceHolidayList(THolidays Holidays)
        {
            return (tcpSetOutOfServiceHolidayList(Holidays) == 0);
        }


        public Boolean GetHGSSettings(out THGS_Settings HGS_Settings)
        {
            return (tcpGetHGSSettings(out HGS_Settings) == 0);
        }


        public Boolean SetHGSSettings(THGS_Settings HGS_Settings)
        {
            return (tcpSetHGSSettings(HGS_Settings) == 0);

        }

        public Boolean GetHGSDaireParkHak(uint rDaire, out Byte rHak)
        {
            return (tcpGetHGSDaireParkHak(rDaire, out rHak) == 0);
        }

        public Boolean SetHGSDaireParkHak(Byte rHak, uint rDaire)
        {
            return (tcpSetHGSDaireParkHak(rDaire, rHak) == 0);

        }

        public Boolean SetPersonTZList(string CardID, TPersTZList PersTZList)
        {
            //Result := (tcpGetPersonTZList(CardID, PersTZList)=0);
            //return (tcpGetPersonTZList(CardID, out PersTZList) == 0);
            return (tcpSetPersonTZList(CardID, PersTZList) == 0);
        }


        public Boolean GetPersonTZList(string CardID, out TPersTZList PersTZList  ) 
        {
            //Result := (tcpGetPersonTZList(CardID, PersTZList)=0);
            return (tcpGetPersonTZList(CardID, out PersTZList) == 0);
        }
        


        public int IsCardIDExistHGSInWhitelistX(String CardID)
        {
            int IndexNum = 0;
            return (tcpIsHGSCardIDExistInWhitelist(CardID, out IndexNum));
        }

        public int IsCardIDExistHGSInWhitelistX(String CardID, out int IndexNum)
        {
            return (tcpIsHGSCardIDExistInWhitelist(CardID, out IndexNum));
        }         


        public int IsHGSCardIDDaireAracExistInWhitelistX( String CardID , ushort DaireNo  , byte AracNo )
        {
            int InxNum;
            return (tcpIsHGSCardIDDaireAracExistInWhitelist(CardID, DaireNo, AracNo, out InxNum));
        }         

        public int IsHGSCardIDDaireAracExistInWhitelistX(String CardID, ushort DaireNo, Byte AracNo, out int IndexNum)
        {
            return (tcpIsHGSCardIDDaireAracExistInWhitelist(CardID, DaireNo, AracNo, out IndexNum));
        }



        public int EditHGSWhitelistWithCardID(THGSArac rArac , out int IndexNum)
        {
            return (tcpEditHGSWhitelistWithCardID(rArac, out IndexNum));
        }


        public int GetHGSWhitelistWithCardID(String CardID , out THGSArac rArac, out int IndexNum )
        {
            //  Result := tcpGetHGSWhitelistWithCardID(CardID,rArac,IndexNum) ;
            return (tcpGetHGSWhitelistWithCardID(CardID , out rArac, out IndexNum));
        }


        public int ReadHGSRecords(uint StartFrom, uint HowMany, out THGSRecords Recs)
        {
            return (tcpReadHGSRecords(StartFrom, HowMany, out Recs));
        }

        public int TransferHGSRecords(out THGSRecords Recs)
        {
            return (tcpTransferHGSRecords(out Recs));
        }


        public int IsHGSDaireAracExistInWhitelistX(ushort DaireNo, Byte AracNo, out int IndexNo)
        { 
        return (tcpIsHGSDaireAracExistInWhitelist(DaireNo, AracNo, out IndexNo));
        }

        public int GetHGSWhitelistWithDaireArac( ushort DaireNo,  Byte AracNo , out THGSArac rArac , out int IndexNum )
        {
            return (tcpGetHGSWhitelistWithDaireArac(DaireNo,  AracNo, out rArac , out IndexNum));
        }


        public Boolean GetMealTable(out TMealTable rSettings)
        {
            return (tcpGetMealTable(out rSettings)==0);
        }


        public Boolean SetMealTable(TMealTable rSettings)
        {
            return (tcpSetMealTable(rSettings) == 0);
        }


        public Boolean GetMealRigthTable(Byte TableNo, out TWeaklyMealRigth rSettings)
        {
            return (tcpGetMealRigthTable(TableNo, out rSettings) == 0);
        }

        public Boolean SetMealRigthTable(Byte TableNo , TWeaklyMealRigth rSettings)
        {
            return (tcpSetMealRigthTable(TableNo, rSettings) == 0);
        }


        public Boolean GetPriceListTable(Byte TableNo , out TPriceList rSettings)
        {
            return (tcpGetPriceListTable(TableNo, out rSettings) == 0);
        }


        public Boolean SetPriceListTable(Byte TableNo, TPriceList rSettings)
        {
            return (tcpSetPriceListTable(TableNo, rSettings)==0);
        }

        public Boolean GetPersonCommands(string CardID , out TPersonCommandList CommandList )
        {
            return (tcpGetPersonCommands(CardID, out CommandList) == 0);
        }

        public Boolean SetPersonCommands(string CardID, TPersonCommandList CommandList)
        {
            return (tcpSetPersonCommands(CardID, CommandList) == 0);
        }

        public Boolean GetYmkSettings(out TYmkSettings rSettings)
        {
            return (tcpGetYmkSettings(out rSettings) == 0);
        }

        public Boolean SetYmkSettings(TYmkSettings rSettings)
        {
            return (tcpSetYmkSettings(rSettings) == 0);
        }

        
        public int DeleteHGSWhitelistWithDaireArac( ushort DaireNo ,  Byte AracNo, out int IndexNo)
        {
            int iErr, lclErr;
        
            lclErr = IsHGSDaireAracExistInWhitelistX(DaireNo,AracNo, out IndexNo);


            switch (lclErr)
            {   

                case 0:
                iErr = 12;
                break;
                case 51:
                iErr = tcpDeleteHGSWhitelistWithDaireArac(DaireNo,AracNo, out IndexNo);
                
                break;

                default:
                iErr = lclErr;
                break;
            }

            return iErr;

        }
     

    }
}
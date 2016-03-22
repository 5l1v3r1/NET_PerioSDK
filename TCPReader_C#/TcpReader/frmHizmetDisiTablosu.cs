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

namespace TCPReader
{
    public partial class frmHizmetDisiTablosu : Form
    {
        public frmHizmetDisiTablosu()
        {
            InitializeComponent();
        }


        string minTimeToStr(DateTime veri)
        {

            string res="";
            string hour;
            string minute;

           hour=Convert.ToString(veri.Hour);
           minute=Convert.ToString(veri.Minute);

           if (hour.Length <2)
           {hour="0" + hour ;}

           if (minute.Length <2)
           {minute = "0" + minute;}

           res = hour + ":" + minute;

           return res;

        }



        private void btnGetir_Click(object sender, EventArgs e)
        {

            TOSTable OSTable = new TOSTable();


            if (frmMain.rdr.Connected == true)
            {

                if (frmMain.rdr.GetOutOfServiceTable(out OSTable) == true)
                {

                    for (int i = 0; i <= 6; i++)
                    {

                        for (int j = 0; j <= 3; j++)
                        {



                            switch (i)
                            {
                                case
                                0:
                                
                                     switch (j)
                                     {  case 0:
                                        hizmetDisiTablosuBas1_1.Text = Convert.ToString(minTimeToStr(OSTable.day[i].part[j].StartTime)).Replace("01.01.2000 ", "");
                                        hizmetDisiTablosuBit1_1.Text = Convert.ToString(minTimeToStr(OSTable.day[i].part[j].EndTime)).Replace("01.01.2000 ", "");
                                        break;
                                        case 1:
                                        hizmetDisiTablosuBas2_1.Text = Convert.ToString(minTimeToStr(OSTable.day[i].part[j].StartTime)).Replace("01.01.2000 ", "");
                                        hizmetDisiTablosuBit2_1.Text = Convert.ToString(minTimeToStr(OSTable.day[i].part[j].EndTime)).Replace("01.01.2000 ", "");
                                        break;
                                        case 2:
                                        hizmetDisiTablosuBas3_1.Text = Convert.ToString(minTimeToStr(OSTable.day[i].part[j].StartTime)).Replace("01.01.2000 ", "");
                                        hizmetDisiTablosuBit3_1.Text = Convert.ToString(minTimeToStr(OSTable.day[i].part[j].EndTime)).Replace("01.01.2000 ", "");
                                        break;
                                        case 3:
                                        hizmetDisiTablosuBas4_1.Text = Convert.ToString(minTimeToStr(OSTable.day[i].part[j].StartTime)).Replace("01.01.2000 ", "");
                                        hizmetDisiTablosuBit4_1.Text = Convert.ToString(minTimeToStr(OSTable.day[i].part[j].EndTime)).Replace("01.01.2000 ", "");
                                        break;
		                                default:
                                        break;
	                                 }

                                    break;
                                case
                                1:

                                    switch (j)
                                    {
                                        case 0:
                                            hizmetDisiTablosuBas1_2.Text = Convert.ToString(minTimeToStr(OSTable.day[i].part[j].StartTime)).Replace("01.01.2000 ", "");
                                            hizmetDisiTablosuBit1_2.Text = Convert.ToString(minTimeToStr(OSTable.day[i].part[j].EndTime)).Replace("01.01.2000 ", "");
                                            break;
                                        case 1:
                                            hizmetDisiTablosuBas2_2.Text = Convert.ToString(minTimeToStr(OSTable.day[i].part[j].StartTime)).Replace("01.01.2000 ", "");
                                            hizmetDisiTablosuBit2_2.Text = Convert.ToString(minTimeToStr(OSTable.day[i].part[j].EndTime)).Replace("01.01.2000 ", "");
                                            break;
                                        case 2:
                                            hizmetDisiTablosuBas3_2.Text = Convert.ToString(minTimeToStr(OSTable.day[i].part[j].StartTime)).Replace("01.01.2000 ", "");
                                            hizmetDisiTablosuBit3_2.Text = Convert.ToString(minTimeToStr(OSTable.day[i].part[j].EndTime)).Replace("01.01.2000 ", "");
                                            break;
                                        case 3:
                                            hizmetDisiTablosuBas4_2.Text = Convert.ToString(minTimeToStr(OSTable.day[i].part[j].StartTime)).Replace("01.01.2000 ", "");
                                            hizmetDisiTablosuBit4_2.Text = Convert.ToString(minTimeToStr(OSTable.day[i].part[j].EndTime)).Replace("01.01.2000 ", "");
                                            break;
                                        default:
                                            break;
                                    }
                                    

                                    break;
                                case
                                2:

                                    switch (j)
                                    {
                                        case 0:
                                            hizmetDisiTablosuBas1_3.Text = Convert.ToString(minTimeToStr(OSTable.day[i].part[j].StartTime)).Replace("01.01.2000 ", "");
                                            hizmetDisiTablosuBit1_3.Text = Convert.ToString(minTimeToStr(OSTable.day[i].part[j].EndTime)).Replace("01.01.2000 ", "");
                                            break;
                                        case 1:
                                            hizmetDisiTablosuBas2_3.Text = Convert.ToString(minTimeToStr(OSTable.day[i].part[j].StartTime)).Replace("01.01.2000 ", "");
                                            hizmetDisiTablosuBit2_3.Text = Convert.ToString(minTimeToStr(OSTable.day[i].part[j].EndTime)).Replace("01.01.2000 ", "");
                                            break;
                                        case 2:
                                            hizmetDisiTablosuBas3_3.Text = Convert.ToString(minTimeToStr(OSTable.day[i].part[j].StartTime)).Replace("01.01.2000 ", "");
                                            hizmetDisiTablosuBit3_3.Text = Convert.ToString(minTimeToStr(OSTable.day[i].part[j].EndTime)).Replace("01.01.2000 ", "");
                                            break;
                                        case 3:
                                            hizmetDisiTablosuBas4_3.Text = Convert.ToString(minTimeToStr(OSTable.day[i].part[j].StartTime)).Replace("01.01.2000 ", "");
                                            hizmetDisiTablosuBit4_3.Text = Convert.ToString(minTimeToStr(OSTable.day[i].part[j].EndTime)).Replace("01.01.2000 ", "");
                                            break;
                                        default:
                                            break;
                                    }


                                    break;
                                case
                                3:

                                    switch (j)
                                    {
                                        case 0:
                                            hizmetDisiTablosuBas1_4.Text = Convert.ToString(minTimeToStr(OSTable.day[i].part[j].StartTime)).Replace("01.01.2000 ", "");
                                            hizmetDisiTablosuBit1_4.Text = Convert.ToString(minTimeToStr(OSTable.day[i].part[j].EndTime)).Replace("01.01.2000 ", "");
                                            break;
                                        case 1:
                                            hizmetDisiTablosuBas2_4.Text = Convert.ToString(minTimeToStr(OSTable.day[i].part[j].StartTime)).Replace("01.01.2000 ", "");
                                            hizmetDisiTablosuBit2_4.Text = Convert.ToString(minTimeToStr(OSTable.day[i].part[j].EndTime)).Replace("01.01.2000 ", "");
                                            break;
                                        case 2:
                                            hizmetDisiTablosuBas3_4.Text = Convert.ToString(minTimeToStr(OSTable.day[i].part[j].StartTime)).Replace("01.01.2000 ", "");
                                            hizmetDisiTablosuBit3_4.Text = Convert.ToString(minTimeToStr(OSTable.day[i].part[j].EndTime)).Replace("01.01.2000 ", "");
                                            break;
                                        case 3:
                                            hizmetDisiTablosuBas4_4.Text = Convert.ToString(minTimeToStr(OSTable.day[i].part[j].StartTime)).Replace("01.01.2000 ", "");
                                            hizmetDisiTablosuBit4_4.Text = Convert.ToString(minTimeToStr(OSTable.day[i].part[j].EndTime)).Replace("01.01.2000 ", "");
                                            break;
                                        default:
                                            break;
                                    }


                                    break;
                                case
                                4:

                                    switch (j)
                                    {
                                        case 0:
                                            hizmetDisiTablosuBas1_5.Text = Convert.ToString(minTimeToStr(OSTable.day[i].part[j].StartTime)).Replace("01.01.2000 ", "");
                                            hizmetDisiTablosuBit1_5.Text = Convert.ToString(minTimeToStr(OSTable.day[i].part[j].EndTime)).Replace("01.01.2000 ", "");
                                            break;
                                        case 1:
                                            hizmetDisiTablosuBas2_5.Text = Convert.ToString(minTimeToStr(OSTable.day[i].part[j].StartTime)).Replace("01.01.2000 ", "");
                                            hizmetDisiTablosuBit2_5.Text = Convert.ToString(minTimeToStr(OSTable.day[i].part[j].EndTime)).Replace("01.01.2000 ", "");
                                            break;
                                        case 2:
                                            hizmetDisiTablosuBas3_5.Text = Convert.ToString(minTimeToStr(OSTable.day[i].part[j].StartTime)).Replace("01.01.2000 ", "");
                                            hizmetDisiTablosuBit3_5.Text = Convert.ToString(minTimeToStr(OSTable.day[i].part[j].EndTime)).Replace("01.01.2000 ", "");
                                            break;
                                        case 3:
                                            hizmetDisiTablosuBas4_5.Text = Convert.ToString(minTimeToStr(OSTable.day[i].part[j].StartTime)).Replace("01.01.2000 ", "");
                                            hizmetDisiTablosuBit4_5.Text = Convert.ToString(minTimeToStr(OSTable.day[i].part[j].EndTime)).Replace("01.01.2000 ", "");
                                            break;
                                        default:
                                            break;
                                    }

                                    break;
                                case
                                5:

                                    switch (j)
                                    {
                                        case 0:
                                            hizmetDisiTablosuBas1_6.Text = Convert.ToString(minTimeToStr(OSTable.day[i].part[j].StartTime)).Replace("01.01.2000 ", "");
                                            hizmetDisiTablosuBit1_6.Text = Convert.ToString(minTimeToStr(OSTable.day[i].part[j].EndTime)).Replace("01.01.2000 ", "");
                                            break;
                                        case 1:
                                            hizmetDisiTablosuBas2_6.Text = Convert.ToString(minTimeToStr(OSTable.day[i].part[j].StartTime)).Replace("01.01.2000 ", "");
                                            hizmetDisiTablosuBit2_6.Text = Convert.ToString(minTimeToStr(OSTable.day[i].part[j].EndTime)).Replace("01.01.2000 ", "");
                                            break;
                                        case 2:
                                            hizmetDisiTablosuBas3_6.Text = Convert.ToString(minTimeToStr(OSTable.day[i].part[j].StartTime)).Replace("01.01.2000 ", "");
                                            hizmetDisiTablosuBit3_6.Text = Convert.ToString(minTimeToStr(OSTable.day[i].part[j].EndTime)).Replace("01.01.2000 ", "");
                                            break;
                                        case 3:
                                            hizmetDisiTablosuBas4_6.Text = Convert.ToString(minTimeToStr(OSTable.day[i].part[j].StartTime)).Replace("01.01.2000 ", "");
                                            hizmetDisiTablosuBit4_6.Text = Convert.ToString(minTimeToStr(OSTable.day[i].part[j].EndTime)).Replace("01.01.2000 ", "");
                                            break;
                                        default:
                                            break;
                                    }

                                    break;
                                case
                                6:

                                    switch (j)
                                    {
                                        case 0:
                                            hizmetDisiTablosuBas1_7.Text = Convert.ToString(minTimeToStr(OSTable.day[i].part[j].StartTime)).Replace("01.01.2000 ", "");
                                            hizmetDisiTablosuBit1_7.Text = Convert.ToString(minTimeToStr(OSTable.day[i].part[j].EndTime)).Replace("01.01.2000 ", "");
                                            break;
                                        case 1:
                                            hizmetDisiTablosuBas2_7.Text = Convert.ToString(minTimeToStr(OSTable.day[i].part[j].StartTime)).Replace("01.01.2000 ", "");
                                            hizmetDisiTablosuBit2_7.Text = Convert.ToString(minTimeToStr(OSTable.day[i].part[j].EndTime)).Replace("01.01.2000 ", "");
                                            break;
                                        case 2:
                                            hizmetDisiTablosuBas3_7.Text = Convert.ToString(minTimeToStr(OSTable.day[i].part[j].StartTime)).Replace("01.01.2000 ", "");
                                            hizmetDisiTablosuBit3_7.Text = Convert.ToString(minTimeToStr(OSTable.day[i].part[j].EndTime)).Replace("01.01.2000 ", "");
                                            break;
                                        case 3:
                                            hizmetDisiTablosuBas4_7.Text = Convert.ToString(minTimeToStr(OSTable.day[i].part[j].StartTime)).Replace("01.01.2000 ", "");
                                            hizmetDisiTablosuBit4_7.Text = Convert.ToString(minTimeToStr(OSTable.day[i].part[j].EndTime)).Replace("01.01.2000 ", "");
                                            break;
                                        default:
                                            break;
                                    }


                                    break;
                                default:
                                    break;
                            }




                        }


                    }

                }

            }
            else
            {
                MessageBox.Show("Cihazla bağlantı yok.");



            }
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {

            TOSTable OSTable = new TOSTable();

            if (frmMain.rdr.Connected == true)
            {

                for (int i = 0; i < 6; i++)
                {

                    for (int j = 0; j < 3; j++)
                    {
                        //OSTable.day[i].part[j].StartTime = "";
                        //OSTable.day[i].part[j].EndTime = "";



                        switch (i)
                        {

                           case 0:

                                switch (j)
	                            {
                                    case 0:
                                        OSTable.day[i].part[j].StartTime = new DateTime(2000, 1, 1, Convert.ToDateTime(hizmetDisiTablosuBas1_1.Text).Hour, Convert.ToDateTime(hizmetDisiTablosuBas1_1.Text).Minute, Convert.ToDateTime(hizmetDisiTablosuBas1_1.Text).Second);
                                        OSTable.day[i].part[j].EndTime = new DateTime(2000, 1, 1, Convert.ToDateTime(hizmetDisiTablosuBit1_1.Text).Hour, Convert.ToDateTime(hizmetDisiTablosuBit1_1.Text).Minute, Convert.ToDateTime(hizmetDisiTablosuBit1_1.Text).Second);
                                        break;
                                    case 1:
                                        OSTable.day[i].part[j].StartTime = new DateTime(2000, 1, 1, Convert.ToDateTime(hizmetDisiTablosuBas2_1.Text).Hour, Convert.ToDateTime(hizmetDisiTablosuBas2_1.Text).Minute, Convert.ToDateTime(hizmetDisiTablosuBas2_1.Text).Second);
                                        OSTable.day[i].part[j].EndTime = new DateTime(2000, 1, 1, Convert.ToDateTime(hizmetDisiTablosuBit2_1.Text).Hour, Convert.ToDateTime(hizmetDisiTablosuBit2_1.Text).Minute, Convert.ToDateTime(hizmetDisiTablosuBit2_1.Text).Second);
                                        break;
                                    case 2:
                                        OSTable.day[i].part[j].StartTime = new DateTime(2000, 1, 1, Convert.ToDateTime(hizmetDisiTablosuBas3_1.Text).Hour, Convert.ToDateTime(hizmetDisiTablosuBas3_1.Text).Minute, Convert.ToDateTime(hizmetDisiTablosuBas3_1.Text).Second);
                                        OSTable.day[i].part[j].EndTime = new DateTime(2000, 1, 1, Convert.ToDateTime(hizmetDisiTablosuBit3_1.Text).Hour, Convert.ToDateTime(hizmetDisiTablosuBit3_1.Text).Minute, Convert.ToDateTime(hizmetDisiTablosuBit3_1.Text).Second);
                                        break;
                                    case 3:
                                        OSTable.day[i].part[j].StartTime = new DateTime(2000, 1, 1, Convert.ToDateTime(hizmetDisiTablosuBas4_1.Text).Hour, Convert.ToDateTime(hizmetDisiTablosuBas4_1.Text).Minute, Convert.ToDateTime(hizmetDisiTablosuBas4_1.Text).Second);
                                        OSTable.day[i].part[j].EndTime = new DateTime(2000, 1, 1, Convert.ToDateTime(hizmetDisiTablosuBit4_1.Text).Hour, Convert.ToDateTime(hizmetDisiTablosuBit4_1.Text).Minute, Convert.ToDateTime(hizmetDisiTablosuBit4_1.Text).Second);
                                        break;

		                            default:
                                        break;
	                            }
                                    break;


                                    case 1:

                                    switch (j)
                                    {
                                        case 0:
                                            OSTable.day[i].part[j].StartTime = new DateTime(2000, 1, 1, Convert.ToDateTime(hizmetDisiTablosuBas1_2.Text).Hour, Convert.ToDateTime(hizmetDisiTablosuBas1_2.Text).Minute, Convert.ToDateTime(hizmetDisiTablosuBas1_2.Text).Second);
                                            OSTable.day[i].part[j].EndTime = new DateTime(2000, 1, 1, Convert.ToDateTime(hizmetDisiTablosuBit1_2.Text).Hour, Convert.ToDateTime(hizmetDisiTablosuBit1_2.Text).Minute, Convert.ToDateTime(hizmetDisiTablosuBit1_2.Text).Second);
                                            break;
                                        case 1:
                                            OSTable.day[i].part[j].StartTime = new DateTime(2000, 1, 1, Convert.ToDateTime(hizmetDisiTablosuBas2_2.Text).Hour, Convert.ToDateTime(hizmetDisiTablosuBas2_2.Text).Minute, Convert.ToDateTime(hizmetDisiTablosuBas2_2.Text).Second);
                                            OSTable.day[i].part[j].EndTime = new DateTime(2000, 1, 1, Convert.ToDateTime(hizmetDisiTablosuBit2_2.Text).Hour, Convert.ToDateTime(hizmetDisiTablosuBit2_2.Text).Minute, Convert.ToDateTime(hizmetDisiTablosuBit2_2.Text).Second);
                                            break;
                                        case 2:
                                            OSTable.day[i].part[j].StartTime = new DateTime(2000, 1, 1, Convert.ToDateTime(hizmetDisiTablosuBas3_2.Text).Hour, Convert.ToDateTime(hizmetDisiTablosuBas3_2.Text).Minute, Convert.ToDateTime(hizmetDisiTablosuBas3_2.Text).Second);
                                            OSTable.day[i].part[j].EndTime = new DateTime(2000, 1, 1, Convert.ToDateTime(hizmetDisiTablosuBit3_2.Text).Hour, Convert.ToDateTime(hizmetDisiTablosuBit3_2.Text).Minute, Convert.ToDateTime(hizmetDisiTablosuBit3_2.Text).Second);
                                            break;
                                        case 3:
                                            OSTable.day[i].part[j].StartTime = new DateTime(2000, 1, 1, Convert.ToDateTime(hizmetDisiTablosuBas4_2.Text).Hour, Convert.ToDateTime(hizmetDisiTablosuBas4_2.Text).Minute, Convert.ToDateTime(hizmetDisiTablosuBas4_2.Text).Second);
                                            OSTable.day[i].part[j].EndTime = new DateTime(2000, 1, 1, Convert.ToDateTime(hizmetDisiTablosuBit4_2.Text).Hour, Convert.ToDateTime(hizmetDisiTablosuBit4_2.Text).Minute, Convert.ToDateTime(hizmetDisiTablosuBit4_2.Text).Second);
                                            break;

                                        default:
                                            break;
                                    }

                                    break;
                                
                                    
                            
                            
                                    case 2:

                                    switch (j)
                                    {
                                        case 0:
                                            OSTable.day[i].part[j].StartTime = new DateTime(2000, 1, 1, Convert.ToDateTime(hizmetDisiTablosuBas1_3.Text).Hour, Convert.ToDateTime(hizmetDisiTablosuBas1_3.Text).Minute, Convert.ToDateTime(hizmetDisiTablosuBas1_3.Text).Second);
                                            OSTable.day[i].part[j].EndTime = new DateTime(2000, 1, 1, Convert.ToDateTime(hizmetDisiTablosuBit1_3.Text).Hour, Convert.ToDateTime(hizmetDisiTablosuBit1_3.Text).Minute, Convert.ToDateTime(hizmetDisiTablosuBit1_3.Text).Second);
                                            break;
                                        case 1:
                                            OSTable.day[i].part[j].StartTime = new DateTime(2000, 1, 1, Convert.ToDateTime(hizmetDisiTablosuBas2_3.Text).Hour, Convert.ToDateTime(hizmetDisiTablosuBas2_3.Text).Minute, Convert.ToDateTime(hizmetDisiTablosuBas2_3.Text).Second);
                                            OSTable.day[i].part[j].EndTime = new DateTime(2000, 1, 1, Convert.ToDateTime(hizmetDisiTablosuBit2_3.Text).Hour, Convert.ToDateTime(hizmetDisiTablosuBit2_3.Text).Minute, Convert.ToDateTime(hizmetDisiTablosuBit2_3.Text).Second);
                                            break;
                                        case 2:
                                            OSTable.day[i].part[j].StartTime = new DateTime(2000, 1, 1, Convert.ToDateTime(hizmetDisiTablosuBas3_3.Text).Hour, Convert.ToDateTime(hizmetDisiTablosuBas3_3.Text).Minute, Convert.ToDateTime(hizmetDisiTablosuBas3_3.Text).Second);
                                            OSTable.day[i].part[j].EndTime = new DateTime(2000, 1, 1, Convert.ToDateTime(hizmetDisiTablosuBit3_3.Text).Hour, Convert.ToDateTime(hizmetDisiTablosuBit3_3.Text).Minute, Convert.ToDateTime(hizmetDisiTablosuBit3_3.Text).Second);
                                            break;
                                        case 3:
                                            OSTable.day[i].part[j].StartTime = new DateTime(2000, 1, 1, Convert.ToDateTime(hizmetDisiTablosuBas4_3.Text).Hour, Convert.ToDateTime(hizmetDisiTablosuBas4_3.Text).Minute, Convert.ToDateTime(hizmetDisiTablosuBas4_3.Text).Second);
                                            OSTable.day[i].part[j].EndTime = new DateTime(2000, 1, 1, Convert.ToDateTime(hizmetDisiTablosuBit4_3.Text).Hour, Convert.ToDateTime(hizmetDisiTablosuBit4_3.Text).Minute, Convert.ToDateTime(hizmetDisiTablosuBit4_3.Text).Second);
                                            break;

                                        default:
                                            break;
                                    }


                                    break;
                                    
                            
                                    case 3:

                                    switch (j)
                                    {
                                        case 0:
                                            OSTable.day[i].part[j].StartTime = new DateTime(2000, 1, 1, Convert.ToDateTime(hizmetDisiTablosuBas1_4.Text).Hour, Convert.ToDateTime(hizmetDisiTablosuBas1_4.Text).Minute, Convert.ToDateTime(hizmetDisiTablosuBas1_4.Text).Second);
                                            OSTable.day[i].part[j].EndTime = new DateTime(2000, 1, 1, Convert.ToDateTime(hizmetDisiTablosuBit1_4.Text).Hour, Convert.ToDateTime(hizmetDisiTablosuBit1_4.Text).Minute, Convert.ToDateTime(hizmetDisiTablosuBit1_4.Text).Second);
                                            break;
                                        case 1:
                                            OSTable.day[i].part[j].StartTime = new DateTime(2000, 1, 1, Convert.ToDateTime(hizmetDisiTablosuBas2_4.Text).Hour, Convert.ToDateTime(hizmetDisiTablosuBas2_4.Text).Minute, Convert.ToDateTime(hizmetDisiTablosuBas2_4.Text).Second);
                                            OSTable.day[i].part[j].EndTime = new DateTime(2000, 1, 1, Convert.ToDateTime(hizmetDisiTablosuBit2_4.Text).Hour, Convert.ToDateTime(hizmetDisiTablosuBit2_4.Text).Minute, Convert.ToDateTime(hizmetDisiTablosuBit2_4.Text).Second);
                                            break;
                                        case 2:
                                            OSTable.day[i].part[j].StartTime = new DateTime(2000, 1, 1, Convert.ToDateTime(hizmetDisiTablosuBas3_4.Text).Hour, Convert.ToDateTime(hizmetDisiTablosuBas3_4.Text).Minute, Convert.ToDateTime(hizmetDisiTablosuBas3_4.Text).Second);
                                            OSTable.day[i].part[j].EndTime = new DateTime(2000, 1, 1, Convert.ToDateTime(hizmetDisiTablosuBit3_4.Text).Hour, Convert.ToDateTime(hizmetDisiTablosuBit3_4.Text).Minute, Convert.ToDateTime(hizmetDisiTablosuBit3_4.Text).Second);
                                            break;
                                        case 3:
                                            OSTable.day[i].part[j].StartTime = new DateTime(2000, 1, 1, Convert.ToDateTime(hizmetDisiTablosuBas4_4.Text).Hour, Convert.ToDateTime(hizmetDisiTablosuBas4_4.Text).Minute, Convert.ToDateTime(hizmetDisiTablosuBas4_4.Text).Second);
                                            OSTable.day[i].part[j].EndTime = new DateTime(2000, 1, 1, Convert.ToDateTime(hizmetDisiTablosuBit4_4.Text).Hour, Convert.ToDateTime(hizmetDisiTablosuBit4_4.Text).Minute, Convert.ToDateTime(hizmetDisiTablosuBit4_4.Text).Second);
                                            break;

                                        default:
                                            break;
                                    }

                                    break;
                                    
                            
                            
                                    case 4:

                                    switch (j)
                                    {
                                        case 0:
                                            OSTable.day[i].part[j].StartTime = new DateTime(2000, 1, 1, Convert.ToDateTime(hizmetDisiTablosuBas1_5.Text).Hour, Convert.ToDateTime(hizmetDisiTablosuBas1_5.Text).Minute, Convert.ToDateTime(hizmetDisiTablosuBas1_5.Text).Second);
                                            OSTable.day[i].part[j].EndTime = new DateTime(2000, 1, 1, Convert.ToDateTime(hizmetDisiTablosuBit1_5.Text).Hour, Convert.ToDateTime(hizmetDisiTablosuBit1_5.Text).Minute, Convert.ToDateTime(hizmetDisiTablosuBit1_5.Text).Second);
                                            break;
                                        case 1:
                                            OSTable.day[i].part[j].StartTime = new DateTime(2000, 1, 1, Convert.ToDateTime(hizmetDisiTablosuBas2_5.Text).Hour, Convert.ToDateTime(hizmetDisiTablosuBas2_5.Text).Minute, Convert.ToDateTime(hizmetDisiTablosuBas2_5.Text).Second);
                                            OSTable.day[i].part[j].EndTime = new DateTime(2000, 1, 1, Convert.ToDateTime(hizmetDisiTablosuBit2_5.Text).Hour, Convert.ToDateTime(hizmetDisiTablosuBit2_5.Text).Minute, Convert.ToDateTime(hizmetDisiTablosuBit2_5.Text).Second);
                                            break;
                                        case 2:
                                            OSTable.day[i].part[j].StartTime = new DateTime(2000, 1, 1, Convert.ToDateTime(hizmetDisiTablosuBas3_5.Text).Hour, Convert.ToDateTime(hizmetDisiTablosuBas3_5.Text).Minute, Convert.ToDateTime(hizmetDisiTablosuBas3_5.Text).Second);
                                            OSTable.day[i].part[j].EndTime = new DateTime(2000, 1, 1, Convert.ToDateTime(hizmetDisiTablosuBit3_5.Text).Hour, Convert.ToDateTime(hizmetDisiTablosuBit3_5.Text).Minute, Convert.ToDateTime(hizmetDisiTablosuBit3_5.Text).Second);
                                            break;
                                        case 3:
                                            OSTable.day[i].part[j].StartTime = new DateTime(2000, 1, 1, Convert.ToDateTime(hizmetDisiTablosuBas4_5.Text).Hour, Convert.ToDateTime(hizmetDisiTablosuBas4_5.Text).Minute, Convert.ToDateTime(hizmetDisiTablosuBas4_5.Text).Second);
                                            OSTable.day[i].part[j].EndTime = new DateTime(2000, 1, 1, Convert.ToDateTime(hizmetDisiTablosuBit4_5.Text).Hour, Convert.ToDateTime(hizmetDisiTablosuBit4_5.Text).Minute, Convert.ToDateTime(hizmetDisiTablosuBit4_5.Text).Second);
                                            break;

                                        default:
                                            break;
                                    }
                                    break;
                                    
                            
                                    case 5:

                                    switch (j)
                                    {
                                        case 0:
                                            OSTable.day[i].part[j].StartTime = new DateTime(2000, 1, 1, Convert.ToDateTime(hizmetDisiTablosuBas1_6.Text).Hour, Convert.ToDateTime(hizmetDisiTablosuBas1_6.Text).Minute, Convert.ToDateTime(hizmetDisiTablosuBas1_6.Text).Second);
                                            OSTable.day[i].part[j].EndTime = new DateTime(2000, 1, 1, Convert.ToDateTime(hizmetDisiTablosuBit1_6.Text).Hour, Convert.ToDateTime(hizmetDisiTablosuBit1_6.Text).Minute, Convert.ToDateTime(hizmetDisiTablosuBit1_6.Text).Second);
                                            break;
                                        case 1:
                                            OSTable.day[i].part[j].StartTime = new DateTime(2000, 1, 1, Convert.ToDateTime(hizmetDisiTablosuBas2_6.Text).Hour, Convert.ToDateTime(hizmetDisiTablosuBas2_6.Text).Minute, Convert.ToDateTime(hizmetDisiTablosuBas2_6.Text).Second);
                                            OSTable.day[i].part[j].EndTime = new DateTime(2000, 1, 1, Convert.ToDateTime(hizmetDisiTablosuBit2_6.Text).Hour, Convert.ToDateTime(hizmetDisiTablosuBit2_6.Text).Minute, Convert.ToDateTime(hizmetDisiTablosuBit2_6.Text).Second);
                                            break;
                                        case 2:
                                            OSTable.day[i].part[j].StartTime = new DateTime(2000, 1, 1, Convert.ToDateTime(hizmetDisiTablosuBas3_6.Text).Hour, Convert.ToDateTime(hizmetDisiTablosuBas3_6.Text).Minute, Convert.ToDateTime(hizmetDisiTablosuBas3_6.Text).Second);
                                            OSTable.day[i].part[j].EndTime = new DateTime(2000, 1, 1, Convert.ToDateTime(hizmetDisiTablosuBit3_6.Text).Hour, Convert.ToDateTime(hizmetDisiTablosuBit3_6.Text).Minute, Convert.ToDateTime(hizmetDisiTablosuBit3_6.Text).Second);
                                            break;
                                        case 3:
                                            OSTable.day[i].part[j].StartTime = new DateTime(2000, 1, 1, Convert.ToDateTime(hizmetDisiTablosuBas4_6.Text).Hour, Convert.ToDateTime(hizmetDisiTablosuBas4_6.Text).Minute, Convert.ToDateTime(hizmetDisiTablosuBas4_6.Text).Second);
                                            OSTable.day[i].part[j].EndTime = new DateTime(2000, 1, 1, Convert.ToDateTime(hizmetDisiTablosuBit4_6.Text).Hour, Convert.ToDateTime(hizmetDisiTablosuBit4_6.Text).Minute, Convert.ToDateTime(hizmetDisiTablosuBit4_6.Text).Second);
                                            break;

                                        default:
                                            break;
                                    }
                                    break;
                                  
                            
                                    case 6:

                                    switch (j)
                                    {
                                        case 0:
                                            OSTable.day[i].part[j].StartTime = new DateTime(2000, 1, 1, Convert.ToDateTime(hizmetDisiTablosuBas1_7.Text).Hour, Convert.ToDateTime(hizmetDisiTablosuBas1_7.Text).Minute, Convert.ToDateTime(hizmetDisiTablosuBas1_7.Text).Second);
                                            OSTable.day[i].part[j].EndTime = new DateTime(2000, 1, 1, Convert.ToDateTime(hizmetDisiTablosuBit1_7.Text).Hour, Convert.ToDateTime(hizmetDisiTablosuBit1_7.Text).Minute, Convert.ToDateTime(hizmetDisiTablosuBit1_7.Text).Second);
                                            break;
                                        case 1:
                                            OSTable.day[i].part[j].StartTime = new DateTime(2000, 1, 1, Convert.ToDateTime(hizmetDisiTablosuBas2_7.Text).Hour, Convert.ToDateTime(hizmetDisiTablosuBas2_7.Text).Minute, Convert.ToDateTime(hizmetDisiTablosuBas2_7.Text).Second);
                                            OSTable.day[i].part[j].EndTime = new DateTime(2000, 1, 1, Convert.ToDateTime(hizmetDisiTablosuBit2_7.Text).Hour, Convert.ToDateTime(hizmetDisiTablosuBit2_7.Text).Minute, Convert.ToDateTime(hizmetDisiTablosuBit2_7.Text).Second);
                                            break;
                                        case 2:
                                            OSTable.day[i].part[j].StartTime = new DateTime(2000, 1, 1, Convert.ToDateTime(hizmetDisiTablosuBas3_7.Text).Hour, Convert.ToDateTime(hizmetDisiTablosuBas3_7.Text).Minute, Convert.ToDateTime(hizmetDisiTablosuBas3_7.Text).Second);
                                            OSTable.day[i].part[j].EndTime = new DateTime(2000, 1, 1, Convert.ToDateTime(hizmetDisiTablosuBit3_7.Text).Hour, Convert.ToDateTime(hizmetDisiTablosuBit3_7.Text).Minute, Convert.ToDateTime(hizmetDisiTablosuBit3_7.Text).Second);
                                            break;
                                        case 3:
                                            OSTable.day[i].part[j].StartTime = new DateTime(2000, 1, 1, Convert.ToDateTime(hizmetDisiTablosuBas4_7.Text).Hour, Convert.ToDateTime(hizmetDisiTablosuBas4_7.Text).Minute, Convert.ToDateTime(hizmetDisiTablosuBas4_7.Text).Second);
                                            OSTable.day[i].part[j].EndTime = new DateTime(2000, 1, 1, Convert.ToDateTime(hizmetDisiTablosuBit4_7.Text).Hour, Convert.ToDateTime(hizmetDisiTablosuBit4_7.Text).Minute, Convert.ToDateTime(hizmetDisiTablosuBit4_7.Text).Second);
                                            break;

                                        default:
                                            break;
                                    }
                                    break;
                                    
                            
                            
                                  

                            default:
                            break;
                        }




                    }

                    
                }


                if (frmMain.rdr.SetOutOfServiceTable(OSTable) == true)
                {
                    MessageBox.Show("Bilgiler cihaza gönderildi.");
                }
                else {

                    MessageBox.Show("Cihaza bilgiler gönderilemedi.");
                }


            }

                    
            else {

                MessageBox.Show("Cihazla bağlantı yok.");
            }

        }

        private void btnTatilListesiGetir_Click(object sender, EventArgs e)
        {

            THolidays Holidays;
          

            if (frmMain.rdr.Connected == true)
            {
                if (frmMain.rdr.GetOutOfServiceHolidayList(out Holidays) == true)
                {
                    for (int i = 0; i <=29 ; i++)
                    {
                        switch (i)
                        {

                            case 0:
                                tatilListesiTatil1.Value = Holidays.List[i].Date;
                                tatilListesiTNo1.Text =Convert.ToString(Holidays.List[i].OOSTableNo);
                                break;
                            case 1:
                                tatilListesiTatil2.Value = Holidays.List[i].Date;
                                tatilListesiTNo2.Text =Convert.ToString(Holidays.List[i].OOSTableNo);
                                break;
                            case 2:
                                tatilListesiTatil3.Value = Holidays.List[i].Date;
                                tatilListesiTNo3.Text =Convert.ToString(Holidays.List[i].OOSTableNo);
                                break;
                            case 3:
                                tatilListesiTatil4.Value = Holidays.List[i].Date;
                                tatilListesiTNo4.Text =Convert.ToString(Holidays.List[i].OOSTableNo);
                                break;
                            case 4:
                                tatilListesiTatil5.Value = Holidays.List[i].Date;
                                tatilListesiTNo5.Text =Convert.ToString(Holidays.List[i].OOSTableNo);
                                break;
                            case 5:
                                tatilListesiTatil6.Value = Holidays.List[i].Date;
                                tatilListesiTNo6.Text =Convert.ToString(Holidays.List[i].OOSTableNo);
                                break;
                            case 6:
                                tatilListesiTatil7.Value = Holidays.List[i].Date;
                                tatilListesiTNo7.Text =Convert.ToString(Holidays.List[i].OOSTableNo);
                                break;
                            case 7:
                                tatilListesiTatil8.Value = Holidays.List[i].Date;
                                tatilListesiTNo8.Text =Convert.ToString(Holidays.List[i].OOSTableNo);
                                break;
                            case 8:
                                tatilListesiTatil9.Value = Holidays.List[i].Date;
                                tatilListesiTNo9.Text =Convert.ToString(Holidays.List[i].OOSTableNo);
                                break;
                            case 9:
                                tatilListesiTatil10.Value = Holidays.List[i].Date;
                                tatilListesiTNo10.Text =Convert.ToString(Holidays.List[i].OOSTableNo);
                                break;
                            case 10:
                                tatilListesiTatil11.Value = Holidays.List[i].Date;
                                tatilListesiTNo11.Text =Convert.ToString(Holidays.List[i].OOSTableNo);
                                break;
                            case 11:
                                tatilListesiTatil12.Value = Holidays.List[i].Date;
                                tatilListesiTNo12.Text =Convert.ToString(Holidays.List[i].OOSTableNo);
                                break;
                            case 12:
                                tatilListesiTatil13.Value = Holidays.List[i].Date;
                                tatilListesiTNo13.Text =Convert.ToString(Holidays.List[i].OOSTableNo);
                                break;
                            case 13:
                                tatilListesiTatil14.Value = Holidays.List[i].Date;
                                tatilListesiTNo14.Text =Convert.ToString(Holidays.List[i].OOSTableNo);
                                break;
                            case 14:
                                tatilListesiTatil15.Value = Holidays.List[i].Date;
                                tatilListesiTNo15.Text =Convert.ToString(Holidays.List[i].OOSTableNo);
                                break;
                            case 15:
                                tatilListesiTatil16.Value = Holidays.List[i].Date;
                                tatilListesiTNo16.Text =Convert.ToString(Holidays.List[i].OOSTableNo);
                                break;
                            case 16:
                                tatilListesiTatil17.Value = Holidays.List[i].Date;
                                tatilListesiTNo17.Text =Convert.ToString(Holidays.List[i].OOSTableNo);
                                break;
                            case 17:
                                tatilListesiTatil18.Value = Holidays.List[i].Date;
                                tatilListesiTNo18.Text =Convert.ToString(Holidays.List[i].OOSTableNo);
                                break;
                            case 18:
                                tatilListesiTatil19.Value = Holidays.List[i].Date;
                                tatilListesiTNo19.Text =Convert.ToString(Holidays.List[i].OOSTableNo);
                                break;
                            case 19:
                                tatilListesiTatil20.Value = Holidays.List[i].Date;
                                tatilListesiTNo20.Text =Convert.ToString(Holidays.List[i].OOSTableNo);
                                break;
                            case 20:
                                tatilListesiTatil21.Value = Holidays.List[i].Date;
                                tatilListesiTNo21.Text =Convert.ToString(Holidays.List[i].OOSTableNo);
                                break;
                            case 21:
                                tatilListesiTatil22.Value = Holidays.List[i].Date;
                                tatilListesiTNo22.Text =Convert.ToString(Holidays.List[i].OOSTableNo);
                                break;
                            case 22:
                                tatilListesiTatil23.Value = Holidays.List[i].Date;
                                tatilListesiTNo23.Text =Convert.ToString(Holidays.List[i].OOSTableNo);
                                break;
                            case 23:
                                tatilListesiTatil24.Value = Holidays.List[i].Date;
                                tatilListesiTNo24.Text =Convert.ToString(Holidays.List[i].OOSTableNo);
                                break;
                            case 24:
                                tatilListesiTatil25.Value = Holidays.List[i].Date;
                                tatilListesiTNo25.Text =Convert.ToString(Holidays.List[i].OOSTableNo);
                                break;
                            case 25:
                                tatilListesiTatil26.Value = Holidays.List[i].Date;
                                tatilListesiTNo26.Text =Convert.ToString(Holidays.List[i].OOSTableNo);
                                break;
                            case 26:
                                tatilListesiTatil27.Value = Holidays.List[i].Date;
                                tatilListesiTNo27.Text =Convert.ToString(Holidays.List[i].OOSTableNo);
                                break;
                            case 27:
                                tatilListesiTatil28.Value = Holidays.List[i].Date;
                                tatilListesiTNo28.Text =Convert.ToString(Holidays.List[i].OOSTableNo);
                                break;
                            case 28:
                                tatilListesiTatil29.Value = Holidays.List[i].Date;
                                tatilListesiTNo29.Text =Convert.ToString(Holidays.List[i].OOSTableNo);
                                break;
                            case 29:
                                tatilListesiTatil30.Value = Holidays.List[i].Date;
                                tatilListesiTNo30.Text =Convert.ToString(Holidays.List[i].OOSTableNo);
                                break;
                            
                            default:
                            break;
                        }
                    }

                    MessageBox.Show("Bilgiler getirildi.");

                }
                else {
                    MessageBox.Show("Bilgiler getirilemedi.");
                
                }


            }
            else {
                MessageBox.Show("Cihazla bağlantı yok");
            
            }



        }

        private void btnTatilListesiGonder_Click(object sender, EventArgs e)
        {
                
            THolidays Holidays;

            Holidays = new THolidays();

        

            if (frmMain.rdr.Connected == true)
            {
                for (int i = 0; i <= 29; i++)
                {
                    switch (i)
                    {

                        case 0:
                            Holidays.List[i].Date = tatilListesiTatil1.Value;
                            Holidays.List[i].OOSTableNo = Convert.ToByte( tatilListesiTNo1.Text);
                            break;
                        case 1:
                            Holidays.List[i].Date = tatilListesiTatil2.Value;
                            Holidays.List[i].OOSTableNo = Convert.ToByte( tatilListesiTNo2.Text);
                            break;
                        case 2:
                            Holidays.List[i].Date = tatilListesiTatil3.Value;
                            Holidays.List[i].OOSTableNo = Convert.ToByte( tatilListesiTNo3.Text);
                            break;
                        case 3:
                            Holidays.List[i].Date = tatilListesiTatil4.Value;
                            Holidays.List[i].OOSTableNo = Convert.ToByte( tatilListesiTNo4.Text);
                            break;
                        case 4:
                            Holidays.List[i].Date = tatilListesiTatil5.Value;
                            Holidays.List[i].OOSTableNo = Convert.ToByte( tatilListesiTNo5.Text);
                            break;
                        case 5:
                            Holidays.List[i].Date = tatilListesiTatil6.Value;
                            Holidays.List[i].OOSTableNo = Convert.ToByte( tatilListesiTNo6.Text);
                            break;
                        case 6:
                            Holidays.List[i].Date = tatilListesiTatil7.Value;
                            Holidays.List[i].OOSTableNo = Convert.ToByte( tatilListesiTNo7.Text);
                            break;
                        case 7:
                            Holidays.List[i].Date = tatilListesiTatil8.Value;
                            Holidays.List[i].OOSTableNo = Convert.ToByte( tatilListesiTNo8.Text);
                            break;
                        case 8:
                            Holidays.List[i].Date = tatilListesiTatil9.Value;
                            Holidays.List[i].OOSTableNo = Convert.ToByte( tatilListesiTNo9.Text);
                            break;
                        case 9:
                            Holidays.List[i].Date = tatilListesiTatil10.Value;
                            Holidays.List[i].OOSTableNo = Convert.ToByte( tatilListesiTNo10.Text);
                            break;
                        case 10:
                            Holidays.List[i].Date = tatilListesiTatil11.Value;
                            Holidays.List[i].OOSTableNo = Convert.ToByte( tatilListesiTNo11.Text);
                            break;
                        case 11:
                            Holidays.List[i].Date = tatilListesiTatil12.Value;
                            Holidays.List[i].OOSTableNo = Convert.ToByte( tatilListesiTNo12.Text);
                            break;
                        case 12:
                            Holidays.List[i].Date = tatilListesiTatil13.Value;
                            Holidays.List[i].OOSTableNo = Convert.ToByte( tatilListesiTNo13.Text);
                            break;
                        case 13:
                            Holidays.List[i].Date = tatilListesiTatil14.Value;
                            Holidays.List[i].OOSTableNo = Convert.ToByte( tatilListesiTNo14.Text);
                            break;
                        case 14:
                            Holidays.List[i].Date = tatilListesiTatil15.Value;
                            Holidays.List[i].OOSTableNo = Convert.ToByte( tatilListesiTNo15.Text);
                            break;
                        case 15:
                            Holidays.List[i].Date = tatilListesiTatil16.Value;
                            Holidays.List[i].OOSTableNo = Convert.ToByte( tatilListesiTNo16.Text);
                            break;
                        case 16:
                            Holidays.List[i].Date = tatilListesiTatil17.Value;
                            Holidays.List[i].OOSTableNo = Convert.ToByte( tatilListesiTNo17.Text);
                            break;
                        case 17:
                            Holidays.List[i].Date = tatilListesiTatil18.Value;
                            Holidays.List[i].OOSTableNo = Convert.ToByte( tatilListesiTNo18.Text);
                            break;
                        case 18:
                            Holidays.List[i].Date = tatilListesiTatil19.Value;
                            Holidays.List[i].OOSTableNo = Convert.ToByte( tatilListesiTNo19.Text);
                            break;
                        case 19:
                            Holidays.List[i].Date = tatilListesiTatil20.Value;
                            Holidays.List[i].OOSTableNo = Convert.ToByte( tatilListesiTNo20.Text);
                            break;
                        case 20:
                            Holidays.List[i].Date = tatilListesiTatil21.Value;
                            Holidays.List[i].OOSTableNo = Convert.ToByte( tatilListesiTNo21.Text);
                            break;
                        case 21:
                            Holidays.List[i].Date = tatilListesiTatil22.Value;
                            Holidays.List[i].OOSTableNo = Convert.ToByte( tatilListesiTNo22.Text);
                            break;
                        case 22:
                            Holidays.List[i].Date = tatilListesiTatil23.Value;
                            Holidays.List[i].OOSTableNo = Convert.ToByte( tatilListesiTNo23.Text);
                            break;
                        case 23:
                            Holidays.List[i].Date = tatilListesiTatil24.Value;
                            Holidays.List[i].OOSTableNo = Convert.ToByte( tatilListesiTNo24.Text);
                            break;
                        case 24:
                            Holidays.List[i].Date = tatilListesiTatil25.Value;
                            Holidays.List[i].OOSTableNo = Convert.ToByte( tatilListesiTNo25.Text);
                            break;
                        case 25:
                            Holidays.List[i].Date = tatilListesiTatil26.Value;
                            Holidays.List[i].OOSTableNo = Convert.ToByte( tatilListesiTNo26.Text);
                            break;
                        case 26:
                            Holidays.List[i].Date = tatilListesiTatil27.Value;
                            Holidays.List[i].OOSTableNo = Convert.ToByte( tatilListesiTNo27.Text);
                            break;
                        case 27:
                            Holidays.List[i].Date = tatilListesiTatil28.Value;
                            Holidays.List[i].OOSTableNo = Convert.ToByte( tatilListesiTNo28.Text);
                            break;
                        case 28:
                            Holidays.List[i].Date = tatilListesiTatil29.Value;
                            Holidays.List[i].OOSTableNo = Convert.ToByte( tatilListesiTNo29.Text);
                            break;
                        case 29:
                            Holidays.List[i].Date = tatilListesiTatil30.Value;
                            Holidays.List[i].OOSTableNo = Convert.ToByte( tatilListesiTNo30.Text);
                            break;

                        default:
                            break;
                    }


                    if (frmMain.rdr.SetOutOfServiceHolidayList(Holidays) == true)
                    {
                        MessageBox.Show("Bilgiler gönderildi.");
                    }
                    else {
                        MessageBox.Show("Bilgiler gönderilemedi.");
                    
                    }
                }

            }
            else {
                MessageBox.Show("Cihazla bağlntı yok");        
            }


        }





    }
}

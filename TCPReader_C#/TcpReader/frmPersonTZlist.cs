using PerioTCPRdr;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TCPReader
{
    public partial class frmPersonTZlist : Form
    {
        PerioTCPRdrComp rdr = new PerioTCPRdrComp();

        public frmPersonTZlist(PerioTCPRdrComp iRdr)
        {
            rdr = iRdr;
            InitializeComponent();
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            if (!rdr.Connected)
                listBox1.Items.Add("Cihazla bağlantınız yok");
            else
            {
                TPersTZList PersTZList = new TPersTZList(); ;
                if (rdr.GetPersonTZList(txtKartId.Text,out PersTZList))
                {
                    for (int i = 0; i <=4 ; i++)
                    {
                        Control[] eDay = this.Controls.Find("edtDay"+(i+1).ToString(), true);
                        if (eDay != null)
                        {
                            //((DateTimePicker)eDay).Value = PersTZList[i]
                            DateTimePicker edtDay = eDay[0] as DateTimePicker;
                            edtDay.Value = PersTZList.List[i].Day;
                        }

                        Control[] eTZNo = this.Controls.Find("edtTZNo" + (i + 1).ToString(), true);
                        if (eTZNo != null)
                        {
                            //((DateTimePicker)eDay).Value = PersTZList[i]
                            NumericUpDown edtTZNo = eTZNo[0] as NumericUpDown;
                            edtTZNo.Value = (decimal)PersTZList.List[i].TZListNo;
                        }


                        for (int k = 0; k < 8; k++)
                        {
                            Control[] edSHour = this.Controls.Find("edtSHour" + (i + 1).ToString() + "_" + (k + 1).ToString(), true);
                            Control[] edEHour = this.Controls.Find("edtEHour" + (i + 1).ToString() + "_" + (k + 1).ToString(), true);

                            if (edSHour != null)
                            {
                                //((DateTimePicker)eDay).Value = PersTZList[i]
                                DateTimePicker edtSHour = edSHour[0] as DateTimePicker;
                                edtSHour.Value = new DateTime(2000,1,1, PersTZList.List[i].Part[k].StartTime.Hours, PersTZList.List[i].Part[k].StartTime.Minutes, PersTZList.List[i].Part[k].StartTime.Seconds) ;
                                //edtSHour.Value = PersTZList.List[i].Part[k].StartTime;
                            }

                            if (edEHour != null)
                            {
                                //((DateTimePicker)eDay).Value = PersTZList[i]
                                DateTimePicker edtEHour = edEHour[0] as DateTimePicker;
                                edtEHour.Value = new DateTime(2000,1,1, PersTZList.List[i].Part[k].EndTime.Hours, PersTZList.List[i].Part[k].EndTime.Minutes, PersTZList.List[i].Part[k].EndTime.Seconds) ;
                                //edtEHour.Value = PersTZList.List[i].Part[k].EndTime;
                            }


                        }

                    }
                }
                else
                {
                    listBox1.Items.Add("veriler getirildi");
                }

            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            TPersTZList PersTZList = new TPersTZList();
            if (!rdr.Connected)
                listBox1.Items.Add("Cihazla bağlantınız yok");
            else
            {
                for (int i = 0; i <= 4; i++)
                {
                    Control[] eDay = this.Controls.Find("edtDay" + (i + 1).ToString(), true);
                    if (eDay != null)
                    {
                        DateTimePicker edtDay = eDay[0] as DateTimePicker;
                        PersTZList.List[i].Day = edtDay.Value;                        
                    }

                    Control[] eTZNo = this.Controls.Find("edtTZNo" + (i + 1).ToString(), true);
                    if (eTZNo != null)
                    {
                        //((DateTimePicker)eDay).Value = PersTZList[i]
                        NumericUpDown edtTZNo = eTZNo[0] as NumericUpDown;
                        PersTZList.List[i].TZListNo = (byte)edtTZNo.Value;
                    }


                    for (int k = 0; k < 8; k++)
                    {
                        Control[] edSHour = this.Controls.Find("edtSHour" + (i + 1).ToString() + "_" + (k + 1).ToString(), true);
                        Control[] edEHour = this.Controls.Find("edtEHour" + (i + 1).ToString() + "_" + (k + 1).ToString(), true);

                        if (edSHour != null)
                        {
                            DateTimePicker edtSHour = edSHour[0] as DateTimePicker;
                            //edtSHour.Value = new DateTime(2000, 1, 1, PersTZList.List[i].Part[k].StartTime.Hours, PersTZList.List[i].Part[k].StartTime.Minutes, PersTZList.List[i].Part[k].StartTime.Seconds);
                            PersTZList.List[i].Part[k].StartTime = new TimeSpan(edtSHour.Value.Hour, edtSHour.Value.Minute, edtSHour.Value.Second);
                        }

                        if (edEHour != null)
                        {
                            DateTimePicker edtEHour = edEHour[0] as DateTimePicker;
                            //edtEHour.Value = new DateTime(2000, 1, 1, PersTZList.List[i].Part[k].EndTime.Hours, PersTZList.List[i].Part[k].EndTime.Minutes, PersTZList.List[i].Part[k].EndTime.Seconds);
                            PersTZList.List[i].Part[k].EndTime = new TimeSpan(edtEHour.Value.Hour, edtEHour.Value.Minute, edtEHour.Value.Second);

                        }


                    }

                }

                if (rdr.SetPersonTZList(txtKartId.Text, PersTZList))
                    listBox1.Items.Add("Bilgiler gönderildi");
                else
                {
                    listBox1.Items.Add("Bilgiler gönderilemedi");
                }
                

            }
        }
    }
}

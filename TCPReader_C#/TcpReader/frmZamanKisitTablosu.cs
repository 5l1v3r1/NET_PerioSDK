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
using TCPReader;
using TCPReader.Properties;
using System.Configuration.Assemblies;



namespace TCPReader
{

    
    public partial class frmZamanKisitTablosu : Form
    {
        public frmZamanKisitTablosu()
        {
            InitializeComponent();
        }


        public static string timetoStr(DateTime inComingTime)
        {
            string returned="";
            int second;
            int hour;
            int minute;
            string strSecond;
            string strHour;
            string strMinute;

            hour = inComingTime.Hour;
            second = inComingTime.Second;
            minute = inComingTime.Minute;

            if (Convert.ToString(hour).Length < 2) { strHour = "0" + Convert.ToString(hour); } else { strHour = Convert.ToString(hour); }
            if (Convert.ToString(minute).Length < 2) { strMinute = "0" + Convert.ToString(minute); } else { strMinute = Convert.ToString(minute); }
            if (Convert.ToString(second).Length < 2) { strSecond = "0" + Convert.ToString(second); } else { strSecond = Convert.ToString(second); }


            returned = strHour + ":" + strMinute;

            return returned;
        }


        void rAddLog(string str)
        {
            //logText.AppendText(str);
        }


        private void button2_Click(object sender, EventArgs e)
        {

            TTACList TACList;
            TACList = new TTACList();


            if (frmMain.rdr.Connected == true)
            {

                try
                {
                    if (frmMain.rdr.GetTimeConstraintTables((byte)edtTabloAdi.Value, out TACList) == true)
                    {
                        dataGridView1.Rows.Clear();
                        dataGridView1.Columns.Clear();
                        dataGridView1.RowCount = 8;
                        dataGridView1.ColumnCount = 16;
                        for (int i = 0; i < 8; i++)
                        {
                            for (int j = 0; j < 8; j++)
                            {

                               dataGridView1.Rows[i].Cells[(j*2)].Value = TACList.Day[i].Part[j].StartTime;
                               dataGridView1.Rows[i].Cells[(j*2)+1].Value = TACList.Day[i].Part[j].EndTime;
                            }

                        }

                    }

                }
                catch (Exception hata)
                {

                    rAddLog("Bilgiler getirilemedi"+  hata.Message);
                }


            }
            else {
                rAddLog("Cihazla bağlantı kurulamadı.");
            }

            


        }

        private void button1_Click(object sender, EventArgs e)
        {

            TTACList TACList;
            TACList = new TTACList();

            if (frmMain.rdr.Connected == true)
            {
                    
              try
              {
                    for (int i = 0; i < 8; i++)
                    {
                        for (int j = 0; j < 8; j++)
                        {
                            TACList.Day[i].Part[j].StartTime = (TimeSpan)dataGridView1.Rows[i].Cells[(j * 2)].Value;
                            TACList.Day[i].Part[j].EndTime = (TimeSpan)dataGridView1.Rows[i].Cells[(j * 2) + 1].Value;
                        }
                    }

                    if (frmMain.rdr.SetTimeConstraintTables((byte)edtTabloAdi.Value, TACList) == true)
                        MessageBox.Show("Gönderildi");
                    else
                        MessageBox.Show("Gönderilemedi");
              }
              catch (Exception hata)
              {

                  rAddLog("Zaman Kısıt Tablosu gönderilemedi." + hata.Message);
              }

              
                


            }
            else {rAddLog("Cihazla bağlantı kurulamadı.");}



        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }
    }
}

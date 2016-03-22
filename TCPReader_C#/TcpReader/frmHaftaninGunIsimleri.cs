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
    public partial class frmHaftaninGunIsimleri : Form
    {
        public frmHaftaninGunIsimleri()
        {
            InitializeComponent();
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {


            TWeekDays WeekDays;
            WeekDays = new TWeekDays();

            if (frmMain.rdr.Connected == true)
            {

                if (frmMain.rdr.GetWeekDayNames(out WeekDays) == true)
                {
                    for (int i = 0; i <= 6; i++)
                    {
                        switch (i)
                        {
                            case 0:
                                pzrGunIsmi.Text = WeekDays.names[0];
                            break;

                            case 1:
                               pztGunIsmi.Text = WeekDays.names[1];                              
                            break;

                            case 2:
                              saliGunIsmi.Text = WeekDays.names[2];  
                            break;

                            case 3:
                              carsGunIsmi.Text = WeekDays.names[3];
                            break;

                            case 4:
                            persGunIsmi.Text = WeekDays.names[4];
                            break;

                            case 5:
                            cumGunIsmi.Text = WeekDays.names[5];  
                            break;
                            
                            case 6:
                            ctsGunIsmi.Text = WeekDays.names[6];   
                            break;

                            default:
                                break;
                        }
                    }
                }
                else {

                    MessageBox.Show("Haftanın gün isilmeri getirilemedi.");
                }


            }
            else { MessageBox.Show("Cihazla bağlantı yok."); }


        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            TWeekDays WeekDays;
           WeekDays = new TWeekDays();
            if (frmMain.rdr.Connected == true)
            {

                for (int i = 0; i <= 6; i++)
                {
                    switch (i)
                    {

                        case 0:
                            WeekDays.names[0] = pzrGunIsmi.Text;
                        break;

                        case 1:
                        WeekDays.names[1] = pztGunIsmi.Text;
                        break;

                        case 2:
                        WeekDays.names[2] = saliGunIsmi.Text;
                        break;

                        case 3:
                        WeekDays.names[3] = carsGunIsmi.Text;
                        break;

                        case 4:
                        WeekDays.names[4] = persGunIsmi.Text;
                        break;

                        case 5:
                        WeekDays.names[5] = cumGunIsmi.Text;
                        break;

                        case 6:
                        WeekDays.names[6] = ctsGunIsmi.Text;
                        break;

                        default:
                        break;
                    }
                }

                if (frmMain.rdr.SetWeekDayNames(WeekDays))
                {
                    MessageBox.Show("Bilgiler gönderildi.");
                }
                else { MessageBox.Show("Bilgiler gönderilemedi."); } 

            }
            else { MessageBox.Show("Cihaza bağlantınız yok."); }





        }
    }
}

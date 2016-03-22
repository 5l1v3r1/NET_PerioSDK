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
    public partial class frmZilTablosu : Form
    {
        public frmZilTablosu()
        {
            InitializeComponent();
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {

            TBellTable BellTable;
                    
            if (frmMain.rdr.Connected == true)
            {
                if (frmMain.rdr.GetBellTable((byte)txtGun.Value, out BellTable) == true)
                {
                    for (int i = 0; i <= 23; i++)
                    {

                        switch (i)
                        {
                            case 0:
                                txtSaat1.Text = Convert.ToString(BellTable.List[i].StartTime).Replace("01.01.2000 ","");
                                break;
                            case 1:
                                txtSaat2.Text = Convert.ToString(BellTable.List[i].StartTime).Replace("01.01.2000 ", "");
                                break;
                            case 2:
                                txtSaat3.Text = Convert.ToString(BellTable.List[i].StartTime).Replace("01.01.2000 ", "");
                                break;
                            case 3:
                                txtSaat4.Text = Convert.ToString(BellTable.List[i].StartTime).Replace("01.01.2000 ", "");
                                break;
                            case 4:
                                txtSaat5.Text = Convert.ToString(BellTable.List[i].StartTime).Replace("01.01.2000 ", "");
                                break;
                            case 5:
                                txtSaat6.Text = Convert.ToString(BellTable.List[i].StartTime).Replace("01.01.2000 ", "");
                                break;
                            case 6:
                                txtSaat7.Text = Convert.ToString(BellTable.List[i].StartTime).Replace("01.01.2000 ", "");
                                break;
                            case 7:
                                txtSaat8.Text = Convert.ToString(BellTable.List[i].StartTime).Replace("01.01.2000 ", "");
                                break;
                            case 8:
                                txtSaat9.Text = Convert.ToString(BellTable.List[i].StartTime).Replace("01.01.2000 ", "");
                                break;
                            case 9:
                                txtSaat10.Text = Convert.ToString(BellTable.List[i].StartTime).Replace("01.01.2000 ", "");
                                break;
                            case 10:
                                txtSaat11.Text = Convert.ToString(BellTable.List[i].StartTime).Replace("01.01.2000 ", "");
                                break;
                            case 11:
                                txtSaat12.Text = Convert.ToString(BellTable.List[i].StartTime).Replace("01.01.2000 ", "");
                                break;
                            case 12:
                                txtSaat13.Text = Convert.ToString(BellTable.List[i].StartTime).Replace("01.01.2000 ", "");
                                break;
                            case 13:
                                txtSaat14.Text = Convert.ToString(BellTable.List[i].StartTime).Replace("01.01.2000 ", "");
                                break;
                            case 14:
                                txtSaat15.Text = Convert.ToString(BellTable.List[i].StartTime).Replace("01.01.2000 ", "");
                                break;
                            case 15:
                                txtSaat16.Text = Convert.ToString(BellTable.List[i].StartTime).Replace("01.01.2000 ", "");
                                break;
                            case 16:
                                txtSaat17.Text = Convert.ToString(BellTable.List[i].StartTime).Replace("01.01.2000 ", "");
                                break;
                            case 17:
                                txtSaat18.Text = Convert.ToString(BellTable.List[i].StartTime).Replace("01.01.2000 ", "");
                                break;
                            case 18:
                                txtSaat19.Text = Convert.ToString(BellTable.List[i].StartTime).Replace("01.01.2000 ", "");
                                break;
                            case 19:
                                txtSaat20.Text = Convert.ToString(BellTable.List[i].StartTime).Replace("01.01.2000 ", "");
                                break;
                            case 20:
                                txtSaat21.Text = Convert.ToString(BellTable.List[i].StartTime).Replace("01.01.2000 ", "");
                                break;
                            case 21:
                                txtSaat22.Text = Convert.ToString(BellTable.List[i].StartTime).Replace("01.01.2000 ", "");
                                break;
                            case 22:
                                txtSaat23.Text = Convert.ToString(BellTable.List[i].StartTime).Replace("01.01.2000 ", "");
                                break;
                            case 23:
                                txtSaat24.Text = Convert.ToString(BellTable.List[i].StartTime).Replace("01.01.2000 ", "");
                                break;
                            default:
                                break;
                        }

                    }
                    MessageBox.Show("Zil tablosu getirildi.");
                }
                else { MessageBox.Show("Zil tablosu getirilemedi."); }
            }
            else {
                MessageBox.Show("Cihazla bağlantı sağlanamadı.");
            }

        }

        private void btnGonder_Click(object sender, EventArgs e)
        {

            TBellTable BellTable;
            BellTable = new TBellTable();


            if (frmMain.rdr.Connected == true)
            {
                for (int i = 0; i <= 23; i++)
                {
                        switch (i)
	                    {
                            case 0:
                                BellTable.List[i].StartTime = Convert.ToDateTime(txtSaat1.Text);
                                BellTable.List[i].Duration =  Convert.ToByte(txtSure1.Text);
                                break;
                            case 1:
                                BellTable.List[i].StartTime = Convert.ToDateTime(txtSaat2.Text);
                                BellTable.List[i].Duration =  Convert.ToByte(txtSure2.Text);
                                break;
                            case 2:
                                BellTable.List[i].StartTime = Convert.ToDateTime(txtSaat3.Text);
                                BellTable.List[i].Duration =  Convert.ToByte(txtSure3.Text);
                                break;
                            case 3:
                                BellTable.List[i].StartTime = Convert.ToDateTime(txtSaat4.Text);
                                BellTable.List[i].Duration =  Convert.ToByte(txtSure4.Text);
                                break;
                            case 4:
                                BellTable.List[i].StartTime = Convert.ToDateTime(txtSaat5.Text);
                                BellTable.List[i].Duration =  Convert.ToByte(txtSure5.Text);
                                break;
                            case 5:
                                BellTable.List[i].StartTime = Convert.ToDateTime(txtSaat6.Text);
                                BellTable.List[i].Duration =  Convert.ToByte(txtSure6.Text);
                                break;
                            case 6:
                                BellTable.List[i].StartTime = Convert.ToDateTime(txtSaat7.Text);
                                BellTable.List[i].Duration =  Convert.ToByte(txtSure7.Text);
                                break;
                            case 7:
                                BellTable.List[i].StartTime = Convert.ToDateTime(txtSaat8.Text);
                                BellTable.List[i].Duration =  Convert.ToByte(txtSure8.Text);
                                break;
                            case 8:
                                BellTable.List[i].StartTime = Convert.ToDateTime(txtSaat9.Text);
                                BellTable.List[i].Duration =  Convert.ToByte(txtSure9.Text);
                                break;
                            case 9:
                                BellTable.List[i].StartTime = Convert.ToDateTime(txtSaat10.Text);
                                BellTable.List[i].Duration =  Convert.ToByte(txtSure10.Text);
                                break;
                            case 10:
                                BellTable.List[i].StartTime = Convert.ToDateTime(txtSaat11.Text);
                                BellTable.List[i].Duration =  Convert.ToByte(txtSure11.Text);
                                break;
                            case 11:
                                BellTable.List[i].StartTime = Convert.ToDateTime(txtSaat12.Text);
                                BellTable.List[i].Duration =  Convert.ToByte(txtSure12.Text);
                                break;
                            case 12:
                                BellTable.List[i].StartTime = Convert.ToDateTime(txtSaat13.Text);
                                BellTable.List[i].Duration =  Convert.ToByte(txtSure13.Text);
                                break;
                            case 13:
                                BellTable.List[i].StartTime = Convert.ToDateTime(txtSaat14.Text);
                                BellTable.List[i].Duration =  Convert.ToByte(txtSure14.Text);
                                break;
                            case 14:
                                BellTable.List[i].StartTime = Convert.ToDateTime(txtSaat15.Text);
                                BellTable.List[i].Duration =  Convert.ToByte(txtSure15.Text);
                                break;
                            case 15:
                                BellTable.List[i].StartTime = Convert.ToDateTime(txtSaat16.Text);
                                BellTable.List[i].Duration =  Convert.ToByte(txtSure16.Text);
                                break;
                            case 16:
                                BellTable.List[i].StartTime = Convert.ToDateTime(txtSaat17.Text);
                                BellTable.List[i].Duration =  Convert.ToByte(txtSure17.Text);
                                break;
                            case 17:
                                BellTable.List[i].StartTime = Convert.ToDateTime(txtSaat18.Text);
                                BellTable.List[i].Duration =  Convert.ToByte(txtSure18.Text);
                                break;
                            case 18:
                                BellTable.List[i].StartTime = Convert.ToDateTime(txtSaat19.Text);
                                BellTable.List[i].Duration =  Convert.ToByte(txtSure19.Text);
                                break;
                            case 19:
                                BellTable.List[i].StartTime = Convert.ToDateTime(txtSaat20.Text);
                                BellTable.List[i].Duration =  Convert.ToByte(txtSure20.Text);
                                break;
                            case 20:
                                BellTable.List[i].StartTime = Convert.ToDateTime(txtSaat21.Text);
                                BellTable.List[i].Duration =  Convert.ToByte(txtSure21.Text);
                                break;
                            case 21:
                                BellTable.List[i].StartTime = Convert.ToDateTime(txtSaat22.Text);
                                BellTable.List[i].Duration =  Convert.ToByte(txtSure22.Text);
                                break;
                            case 22:
                                BellTable.List[i].StartTime = Convert.ToDateTime(txtSaat23.Text);
                                BellTable.List[i].Duration =  Convert.ToByte(txtSure23.Text);
                                break;
                            case 23:
                                BellTable.List[i].StartTime = Convert.ToDateTime(txtSaat24.Text);
                                BellTable.List[i].Duration =  Convert.ToByte(txtSure24.Text);
                                break;
		                    default:
                                break;
	                    }

                        if (frmMain.rdr.SetBellTable((byte)txtGun.Value, BellTable) == true)
                        {
                            MessageBox.Show("Zil tablosu gönderildi.");
                        }
                        else { MessageBox.Show("Zil tablosu gönderilemedi."); }

                        

                }

            }
            else { MessageBox.Show("Cihazla bağlantı yok."); }

        }




    }
}

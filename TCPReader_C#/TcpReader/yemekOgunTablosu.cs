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
    public partial class yemekOgunTablosu : Form
    {
        public yemekOgunTablosu()
        {
            InitializeComponent();
        }

        PerioTCPRdr.TMealTable gMealTable = new PerioTCPRdr.TMealTable();
        //PerioTCPRdr.TMealTable gMealTable;


        private void yemekOgunTablosu_Load(object sender, EventArgs e)
        {
            txtGun.SelectedIndex = 0;
        }



   

        void yaz(int Day, PerioTCPRdr.TMealTable MealTable)
        {
            
            if (frmMain.rdr.Connected == true)
            {

                for (int i = 0; i < 8; i++)
                {
            
                    TextBox txtOgunAdi = panel1.Controls.Find("txtOgunAdi" + i.ToString(), true).FirstOrDefault() as TextBox;
                    TextBox txtBaslangicSaati = panel1.Controls.Find("txtBaslangicSaati" + i.ToString(), false).FirstOrDefault() as TextBox;
                    ComboBox txtDunBugunYarin = panel1.Controls.Find("txtDunBugunYarin" + i.ToString(), false).FirstOrDefault() as ComboBox;
                    TextBox txtBitisSaati = panel1.Controls.Find("txtBitisSaati" + i.ToString(), false).FirstOrDefault() as TextBox;
                    ComboBox txtDunBugunYarin1 = panel1.Controls.Find("txtDunBugunYarin1" + i.ToString(), false).FirstOrDefault() as ComboBox;
                    CheckBox txtAktif = panel1.Controls.Find("txtAktif" + i.ToString(), false).FirstOrDefault() as CheckBox;
                    MealTable.days[Day].list[i].Name = txtOgunAdi.Text;
                    MealTable.days[Day].list[i].StartTime = new DateTime(2000, 1, 1, Convert.ToDateTime(txtBaslangicSaati.Text).Hour, Convert.ToDateTime(txtBaslangicSaati.Text).Minute, 0);
                    MealTable.days[Day].list[i].StartDBY = (byte)txtDunBugunYarin.SelectedIndex;
                    MealTable.days[Day].list[i].EndTime = new DateTime(2000, 1, 1, Convert.ToDateTime(txtBitisSaati.Text).Hour, Convert.ToDateTime(txtBitisSaati.Text).Minute, 0);
                    MealTable.days[Day].list[i].EndDBY = (byte)txtDunBugunYarin1.SelectedIndex;
                    if (txtAktif.Checked == true)
                        MealTable.days[Day].list[i].Active = true;
                    else
                        MealTable.days[Day].list[i].Active = false;
                }

            }
            else { MessageBox.Show("Cihazla bağlantınız yok."); }

        }

        void formaDiz(int day, PerioTCPRdr.TMealTable MealTable)
        {

            for (int i = 0; i < 8; i++)
            {
                TextBox list1 = new TextBox();
                TextBox list2 = new TextBox();
                ComboBox list3 = new ComboBox();
                TextBox list4 = new TextBox();
                ComboBox list5 = new ComboBox();
                CheckBox list6 = new CheckBox();
               
                Label ogunLabel = new Label();

                ogunLabel.Name = "ogunLbl" + i.ToString();
                ogunLabel.Left = 15;
                ogunLabel.AutoSize = true;
                ogunLabel.Top = i * 30;
                ogunLabel.Text = i.ToString() + ". Öğün";

                list1.Name = "txtOgunAdi" + i.ToString();
                list1.Width = 100;
                list1.Left = ogunLabel.Width + 10;
                list1.Top = i * 30;
                list1.Text = MealTable.days[day].list[i].Name;

                list2.Name = "txtBaslangicSaati" + i.ToString();
                list2.Width = 50;
                list2.Left = ogunLabel.Width + list1.Width + 20;
                list2.Top = i * 30;
                list2.Text = MealTable.days[day].list[i].StartTime.ToString().Replace("01.01.2000", "").Trim().Remove(5, 3) ;

                //0 1 2 dün bugün yarın
                list3.Name = "txtDunBugunYarin" + i.ToString();
                list3.Width = 50;
                list3.Left = ogunLabel.Width + list1.Width + list2.Width + 30;
                list3.Top = i * 30;
                list3.Items.Add("Dün");
                list3.Items.Add("Bugün");
                list3.Items.Add("Yarın");
                list3.SelectedIndex = MealTable.days[day].list[i].StartDBY ;

                list4.Name = "txtBitisSaati" + i.ToString();
                list4.Width = 35;
                list4.Left = ogunLabel.Width + list1.Width + list2.Width + list3.Width + 40;
                list4.Top = i * 30;
                list4.Text = MealTable.days[day].list[i].EndTime.ToString().Replace("01.01.2000", "").Trim().Remove(5, 3);

                list5.Name = "txtDunBugunYarin1" + i.ToString();
                list5.Width = 50;
                list5.Left = ogunLabel.Width + list1.Width + list2.Width + list3.Width + list4.Width + 50;
                list5.Top = i * 30;
                list5.Items.Add("Dün");
                list5.Items.Add("Bugün");
                list5.Items.Add("Yarın");
                list5.SelectedIndex = MealTable.days[day].list[i].EndDBY;

                list6.Name = "txtAktif" + i.ToString();
                list6.AutoSize = true;
                //list6.Width = 35;
                list6.Left = ogunLabel.Width + list1.Width + list2.Width + list3.Width + list4.Width + list5.Width + 60;
                list6.Top = i * 30;
                list6.Text = "Aktif / Pasif";

                if (MealTable.days[day].list[i].Active)
                    list6.Checked = true;
                else
                    list6.Checked = false;

                panel1.Controls.Add(ogunLabel);
                panel1.Controls.Add(list1);
                panel1.Controls.Add(list2);
                panel1.Controls.Add(list3);
                panel1.Controls.Add(list4);
                panel1.Controls.Add(list5);
                panel1.Controls.Add(list6);

            }
        
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();

            if (frmMain.rdr.Connected == true)
            {

                if (frmMain.rdr.GetMealTable(out gMealTable))
                {

                    formaDiz(txtGun.SelectedIndex, gMealTable);
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





        private void btnGonder_Click(object sender, EventArgs e)
        {
            if (frmMain.rdr.Connected == true)
            {

                yaz(txtGun.SelectedIndex, gMealTable);

                if (frmMain.rdr.SetMealTable(gMealTable))
                {
                    MessageBox.Show("Bilgiler gönderildi.");
                }
                else {
                    MessageBox.Show("Bilgiler gönderilemedi");
                }
            }
            else {
                MessageBox.Show("Cihazla bağlantı yok.");
            
            }
             
        }

    


        
    }
}

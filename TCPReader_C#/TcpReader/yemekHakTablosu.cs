using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PerioTcpRdrBase;
using PerioTCPRdr;

namespace TCPReader
{
    public partial class yemekHakTablosu : Form
    {
        public yemekHakTablosu()
        {
            InitializeComponent();
        }





        void isle()
        {
            
            TWeaklyMealRigth table = new TWeaklyMealRigth();

            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            if (frmMain.rdr.GetMealRigthTable((byte)numericUpDown1.Value, out table))
            {
                for (int a = 0; a <= 9; a++)
                {

                    if (a==0)
                    {
                        dataGridView1.Columns.Add("Toplam", "Gün");
                    }
                    else if (a == 9)
                    {
                        dataGridView1.Columns.Add("Toplam", "Toplam Öğün");
                    }
                    else {
                        dataGridView1.Columns.Add("Toplam", a.ToString() + ". Öğün");   
                    }

                }


                for (int k = 0; k < 7; k++)
                {
                    dataGridView1.Rows[k].ReadOnly = true;
                    dataGridView1.Rows[k].Resizable = DataGridViewTriState.False;
                    dataGridView1.Rows[k].Selected = false;


                    switch (k)
                    {
                        case 0:
                            dataGridView1.Rows.Add("Pazartesi");
                            
                            break;
                        case 1:
                            dataGridView1.Rows.Add("Salı");
                            break;
                        case 2:
                            dataGridView1.Rows.Add("Çarşamba");
                            break;
                        case 3:
                            dataGridView1.Rows.Add("Perşembe");
                            break;
                        case 4:
                            dataGridView1.Rows.Add("Cuma");
                            break;
                        case 5:
                            dataGridView1.Rows.Add("Cumartesi");
                            break;
                        case 6:
                            dataGridView1.Rows.Add("Pazar");
                            break;

                        default:
                            break;
                    }

                } // başlıklar dizildi.

                try
                {
                    for (int k = 0; k < 7; k++)
                    {
                        for (int i = 0; i < 8; i++)
                        {

                            TextBox nt = new TextBox();
                            nt.Left = i * nt.Width;
                            nt.Name = "nt" + i.ToString();
                            panel1.Controls.Add(nt);
                            dataGridView1.Rows[k].Cells[i+1].Value = table.days[k].MealRigths[i];
                        }
                        dataGridView1.Rows[k].Cells[9].Value = table.days[k].TotalDayRight;
                        
                    }
                }
                catch (Exception)
                {
                    
                    throw;
                }

                

            }
            else {

                MessageBox.Show("Bilgiler getirilemedi.");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (frmMain.rdr.Connected == true)
            {
            isle();
            }
            else {
                MessageBox.Show("Cihazla bağlantı  yok");                
            
            }


            


        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            isle();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            TWeaklyMealRigth table = new TWeaklyMealRigth();

            if (frmMain.rdr.Connected == true)
            {

                for (int k = 0; k < 7; k++)
                {
                    for (int i = 0; i < 8; i++)
                    {
                        table.days[k].MealRigths[i] = (byte)dataGridView1.Rows[k].Cells[i + 1].Value;
                         // MessageBox.Show(Convert.ToString(dataGridView1.Rows[k].Cells[i+1].Value));
                        //  MessageBox.Show(dataGridView1.Rows[k].Cells[i + 1].Value.ToString());
                    }
                        table.days[k].TotalDayRight = (byte)dataGridView1.Rows[k].Cells[9].Value;
                         
                }

                if (frmMain.rdr.SetMealRigthTable((byte)numericUpDown1.Value, table))
                {
                    MessageBox.Show("Bilgiler gönderildi.");
                }
                else
                {
                    MessageBox.Show("Bilgileriniz gönderilmedi.");
                }

            }
            else {

                MessageBox.Show("Cihazla bağlantınız yok.");
            }



        }
    }
}

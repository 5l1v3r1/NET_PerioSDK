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
    public partial class frmKontorFiyatListesi : Form
    {
        public frmKontorFiyatListesi()
        {
            InitializeComponent();
        }

        PerioTCPRdr.TPriceList gPriceList = new PerioTCPRdr.TPriceList();

        private void frmKontorFiyatListesi_Activated(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            gridOlustur();
        }


        void gridOlustur()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            for (int i = 0; i < 8; i++)
            {
                if (i==0)
                {
                dataGridView1.Columns.Add("","Öğün");
                }

                dataGridView1.Columns.Add("",i.ToString() + ". Fiyat");
                dataGridView1.Rows.Add(i.ToString() + ". Öğün");
                dataGridView1.Rows[i].Resizable = DataGridViewTriState.False;
            }
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            if (frmMain.rdr.Connected == true)
            {
                if (frmMain.rdr.GetPriceListTable((byte)numericUpDown1.Value, out gPriceList))
                {
                    for (int k = 0; k < 8; k++)
                    {
                        for (int i = 0; i < 8; i++)
                        {
                            dataGridView1.Rows[k].Cells[i + 1].Value = gPriceList.Days[comboBox1.SelectedIndex].Meals[k].Prices[i];
                        }
                    }
                }

                txtListeAdi.Text = gPriceList.name.ToString();
            }
            else {
                MessageBox.Show("Cihazla bağlantı yok");
            }
        }

        const string gecerliStrings = "0123456789";

        Boolean gecerlimi(string inComingStr)
        {
            Boolean don = true;
            string chr;
            for (int i = 0; i < inComingStr.Length; i++)
            {
                chr = inComingStr.Substring(i, 1);
                if (gecerliStrings.IndexOf(chr) == -1)
                {
                    don = false;
                }
            }
            return don;
        }



        void gonder()
        {
            gPriceList.name = txtListeAdi.Text.Trim();

                for (int k = 0; k < 8; k++)
                {
                    for (int i = 0; i < 8; i++)
                    {
                            if (!gecerlimi(dataGridView1.Rows[k].Cells[i + 1].Value.ToString()))
	                        {
		                        MessageBox.Show("Bilgiler içersinde geçersiz karakter(ler) var.");
                                break;
	                        } 
                            else 
                            {
                            gPriceList.Days[comboBox1.SelectedIndex].Meals[k].Prices[i] = (ushort)dataGridView1.Rows[k].Cells[i + 1].Value;
                            }
                    }
                }

                    if (frmMain.rdr.SetPriceListTable((byte)comboBox1.SelectedIndex, gPriceList))
                    {
                    btnGetir.PerformClick();
                    MessageBox.Show("Bilgiler gönderildi.");
                    } 
                    else
                    {
                    MessageBox.Show("Bilgiler gönderilemedi.");
                    }
        }


        private void btnGonder_Click(object sender, EventArgs e)
        {
            if (frmMain.rdr.Connected == true)
            {
                gonder();
            }
            else
            {
                MessageBox.Show("Cihazla bağlantınız yok.");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

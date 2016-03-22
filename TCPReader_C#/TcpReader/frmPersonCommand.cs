using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PerioTCPRdr;
namespace TCPReader
{
    public partial class frmPersonCommand : Form
    {
        public frmPersonCommand()
        {
            InitializeComponent();
            dataGridView1.RowCount = 15;
            dataGridView1.ColumnCount = 3;
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            if (frmMain.rdr.Connected == true)
            {

                TPersonCommandList commandList = new TPersonCommandList();
                if (frmMain.rdr.GetPersonCommands(txtKartId.Text, out commandList))
                {


                    for (int i = 0; i < 15; i++)
                    {
                        dataGridView1.Rows[i].Cells[i+1].Value = i.ToString();
                        dataGridView1.Rows[i].Cells[i + 2].Value = commandList.List[i].CmdType.ToString();
                        dataGridView1.Rows[i].Cells[i + 3].Value = commandList.List[i].SessionID.ToString();
                        dataGridView1.Rows[i].Cells[i + 4].Value = commandList.List[i].Amount.ToString();
                    }

                    MessageBox.Show("Bilgiler getirildi.");
                }
                else
                   MessageBox.Show("Bilgiler getirilemedi.");

            }
            else
                MessageBox.Show("Cihazla bağlantı yok");
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {

            if (frmMain.rdr.Connected == true)
            {
              TPersonCommandList commandList = new TPersonCommandList();
              for (int i = 0; i < 15; i++)
              {
                  commandList.List[i].CmdType = Convert.ToByte(dataGridView1.Rows[i].Cells[i + 2].Value);
                  commandList.List[i].SessionID = Convert.ToInt32(dataGridView1.Rows[i].Cells[i + 3].Value);
                  commandList.List[i].Amount = Convert.ToInt32(dataGridView1.Rows[i].Cells[i + 4].Value);
              }

              if (frmMain.rdr.SetPersonCommands(txtKartId.Text, commandList))
                    MessageBox.Show("Bilgiler gönderildi.");
              else
                    MessageBox.Show("Bilgiler gönderilemedi.");
            }
            else
                MessageBox.Show("Cihazla bağlantı yok");

        }
    }
}

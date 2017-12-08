using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IH31_CP_Projects
{
    public partial class AuctionStatement : Form
    {
        AuctionKanri auction = new AuctionKanri();
        DataTable dt = new DataTable();

        public AuctionStatement()
        {
            InitializeComponent();
            Datetime.CustomFormat = "yyyy-MM-dd";

        }

        private void BtSearch_Click(object sender, EventArgs e)
        {
            
            AuctionKanri auction = new AuctionKanri();
            DvAuction.Rows.Clear();
           
            dt = auction.auctionSelect(CbAuctionName.Text,Datetime.Text);
            DvAuction.AllowUserToAddRows = false;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                 DvAuction.Rows.Add();
                 DvAuction.Rows[i].Cells[0].Value = dt.Rows[i][0];
                 DvAuction.Rows[i].Cells[1].Value = dt.Rows[i][1];
                 DvAuction.Rows[i].Cells[2].Value = dt.Rows[i][2];
                 DvAuction.Rows[i].Cells[3].Value = dt.Rows[i][3];
                 DvAuction.Rows[i].Cells[4].Value = dt.Rows[i][4];
                 DvAuction.Rows[i].Cells[5].Value = dt.Rows[i][5];
                 DvAuction.Rows[i].Cells[6].Value = dt.Rows[i][6];
                 DvAuction.Rows[i].Cells[7].Value = dt.Rows[i][7];
                 DvAuction.Rows[i].Cells[8].Value = " ";
                 DvAuction.Rows[i].Cells[9].Value = " ";
                 DvAuction.Rows[i].Cells[10].Value = " ";
            }
        }

        private void BtSubmit_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (!DvAuction.Rows[i].Cells[8].Value.Equals(" "))
                {
                    if (DvAuction.Rows[i].Cells[7].Value.ToString() == "買")
                    {
                        auction.saleInsert(CbAuctionName.Text, Convert.ToInt32(DvAuction.Rows[i].Cells[8].Value), Convert.ToInt32(DvAuction.Rows[i].Cells[9].Value), Convert.ToInt32(DvAuction.Rows[i].Cells[10].Value));
                    }
                    else
                    {
                        auction.saleInsert(CbAuctionName.Text, Convert.ToInt32(DvAuction.Rows[i].Cells[8].Value)*-1, Convert.ToInt32(DvAuction.Rows[i].Cells[9].Value), Convert.ToInt32(DvAuction.Rows[i].Cells[10].Value));
                    }
                   
                    auction.rcedetailSaleIdUpdate(dt.Rows[i][0].ToString(),  Convert.ToInt32(dt.Rows[i][1]), dt.Rows[i][7].ToString());
                }
            }
            DialogResult Res;
            Res = MessageBox.Show("処理が完了しました", "確認", MessageBoxButtons.OK);
            if (Res == DialogResult.OK)
            {
                this.Close();
            }
        }
        


    }
}

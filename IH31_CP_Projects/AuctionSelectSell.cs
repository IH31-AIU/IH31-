using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace IH31_CP_Projects
{
    public partial class AuctionSelectSell : Form
    {
        public AuctionSelectSell()
        {
            InitializeComponent();
            DataGridViewComboBoxColumn auctionCom = new DataGridViewComboBoxColumn();
            DataGridViewTextBoxColumn dateCom = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn numCom = new DataGridViewTextBoxColumn();
            
            Auction auction = new Auction();
            string[] auctionName = auction.auctionNameGet();
            for (int i = 0; i < auctionName.Length; i++)
            {
                auctionCom.Items.Add(auctionName[i]);
            }
            dvAuction.Columns.Insert(0, auctionCom);
            dvAuction.Columns.Insert(1, numCom);
            dvAuction.Columns.Insert(2, dateCom);

            auctionCom.HeaderText = "オークション会場";
            auctionCom.DataPropertyName = "auction";
            auctionCom.Name = "auction";

            dateCom.HeaderText = "オークション日";
            dateCom.DataPropertyName = "auction_date";
            dateCom.Name = "auction_date";
            numCom.HeaderText = "出品番号";
            numCom.DataPropertyName = "auction_no";
            numCom.Name = "auction_no";
            string id = "1";
            Received received = new Received();
            MySqlDataAdapter da = received.orderDetail(id);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dvAuction.DataSource = dt;
            dvAuction.AllowUserToAddRows = false;
        }


        private void dvAuction_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int column = e.ColumnIndex;
            int row = e.RowIndex;
            try
            {
                if (dvAuction[0, row] != null && dvAuction[3, row] != null)
                {
                    string auction = dvAuction["auction", row].Value.ToString();
                    string no = dvAuction["auction_no", row].Value.ToString();
                    string date = dvAuction["auction_date",row].Value.ToString();
                    string id = dvAuction["rce_order_id", row].Value.ToString();
                    string detail = dvAuction["rce_order_detail_id", row].Value.ToString();
                    if (auction != "" && date != "")
                    {
                        Received receive = new Received();
                        receive.updateOrder(no,date,auction,id,detail);   
                    }
                }
            }
            catch(Exception ex)
            {
                Console.Write(ex);
            }
        }

        private void all_CheckedChanged(object sender, EventArgs e)
        {
            string id = "1";
            Received received = new Received();
            MySqlDataAdapter da = received.orderDetail(id);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dvAuction.DataSource = dt;
        }

        private void K_CheckedChanged(object sender, EventArgs e)
        {
            string id = "1";
            string flg = "K";
            Received received = new Received();
            MySqlDataAdapter da = received.orderDetailWhere(id,flg);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dvAuction.DataSource = dt;
        }

        private void U_CheckedChanged(object sender, EventArgs e)
        {
            string flg = "U";
            string id = "1";
            Received received = new Received();
            MySqlDataAdapter da = received.orderDetailWhere(id,flg);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dvAuction.DataSource = dt;
        }
    }
}

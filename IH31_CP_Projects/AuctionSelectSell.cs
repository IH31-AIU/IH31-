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
            DataGridViewTextBoxColumn quote_id = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn quote_detail_id = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn model_year = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn car_name = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn model = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn grade = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn remarks = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn quote_price = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn sales_id = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn purchase_order_id = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn listing_slip_id = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn buy_progress_flg = new DataGridViewTextBoxColumn();

            quote_id.DataPropertyName = "rce_order_id";
            quote_id.Name = "rce_order_id";

            quote_detail_id.DataPropertyName = "rce_order_detail_id";
            quote_detail_id.Name = "rce_order_detail_id";

            model_year.DataPropertyName = "model_year";
            model_year.Name = "model_year";

            car_name.DataPropertyName = "car_name";
            model.DataPropertyName = "model";
            grade.DataPropertyName = "grade";
            remarks.DataPropertyName = "remarks";
            quote_price.DataPropertyName = "quote_price";
            sales_id.DataPropertyName = "sales_id";
            purchase_order_id.DataPropertyName = "purchase_order_id";
            listing_slip_id.DataPropertyName = "listing_slip_id";
            buy_progress_flg.DataPropertyName = "buy_progress_flag";

            quote_price.HeaderText = "見積もり金額";
            remarks.HeaderText = "メモ";
            grade.HeaderText = "グレード";
            model.HeaderText = "モデル";
            car_name.HeaderText = "車名";
            model_year.HeaderText = "型年";
            quote_detail_id.HeaderText = "見積詳細ID";
            quote_id.HeaderText = "見積ID";
            sales_id.HeaderText = "売上ID";
            purchase_order_id.HeaderText = "発注書ID";
            listing_slip_id.HeaderText = "出品ID";
            buy_progress_flg.HeaderText = "購入状態";

            Auction auction = new Auction();
            string[] auctionName = auction.auctionNameGet();
            for (int i = 0; i < auctionName.Length; i++)
            {
                auctionCom.Items.Add(auctionName[i]);
            }
            dvAuction.Columns.Insert(0, auctionCom);
            dvAuction.Columns.Insert(1, numCom);
            dvAuction.Columns.Insert(2, dateCom);
            dvAuction.Columns.Insert(3, quote_id);
            dvAuction.Columns.Insert(4, quote_detail_id);
            dvAuction.Columns.Insert(5, quote_price);
            dvAuction.Columns.Insert(6, car_name);
            dvAuction.Columns.Insert(7, grade);
            dvAuction.Columns.Insert(8, model);
            dvAuction.Columns.Insert(9, model_year);
            dvAuction.Columns.Insert(10, remarks);
            dvAuction.Columns.Insert(11, sales_id);
            dvAuction.Columns.Insert(12, purchase_order_id);
            dvAuction.Columns.Insert(13, listing_slip_id);
            dvAuction.Columns.Insert(14, buy_progress_flg);
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

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult Res;
            Res = MessageBox.Show("オークションの決定を完了してもよろしいですか？", "確認", MessageBoxButtons.OKCancel);
            if (Res == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}

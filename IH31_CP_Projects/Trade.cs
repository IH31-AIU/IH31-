using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;


namespace IH31_CP_Projects
{
    public class PurchaseKanri
    {
        public MySqlDataAdapter purchaseSearch()
        {
            MySqlConnection conn = DBManager.getConection();
            conn.Open();
            String sql = "SELECT rod.auction as name ,count(rod.auction) as number FROM `rce_order_detail` rod " +
                         "join memo on(memo.memo_id = rod.rce_order_id) " +
                         "where memo.trade_flg = 'K' and rod.auction_date >= CURRENT_DATE() and rod.purchase_order_id is null " +
                         "group by rod.auction";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            conn.Close();
            return da;

        }
        public MySqlDataAdapter purchaseOrderInfoGet(string auctionName)
        {
            MySqlConnection conn = DBManager.getConection();
            conn.Open();
            String sql = "SELECT rod.auction ,rod.auction_date,rod.auction_no,rod.car_name,rod.model_year,rod.grade,rod.quote_price,rod.rce_order_id,rod.rce_order_detail_id FROM `rce_order_detail` rod " +
                         "join memo on (memo.memo_id = rod.rce_order_id) " +
                         "where memo.trade_flg = 'K' and rod.auction_date >= CURRENT_DATE() and rod.auction ='" + auctionName + "' and rod.purchase_order_id is null";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            conn.Close();
            return da;
        }

        public void insertPurchase()
        {
            MySqlConnection conn = DBManager.getConection();
            conn.Open();
            String sql = "INSERT INTO purchase values()";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            conn.Close();
            DataTable dt = new DataTable();
            da.Fill(dt);
        }

        public int maxPurchaseIdGet()
        {
            MySqlConnection conn = DBManager.getConection();
            conn.Open();
            String sql = "SELECT max(purchase_order_id) as id from purchase";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            conn.Close();
            DataTable dt = new DataTable();
            da.Fill(dt);
            return Convert.ToInt32(dt.Rows[0]["id"]);
        }

        public void updatePurchaseIdRceOrderDetail(String orderId, int detailId, int purchaseId)
        {
            MySqlConnection conn = DBManager.getConection();
            conn.Open();
            String sql = "update rce_order_detail set purchase_order_id = " + purchaseId + " where rce_order_id = '" + orderId + "' and rce_order_detail_id = " + detailId + "";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            conn.Close();
            DataTable dt = new DataTable();
            da.Fill(dt);
        }

    }


    public class ListingKanri
    {
        public MySqlDataAdapter listingSearch()
        {
            MySqlConnection conn = DBManager.getConection();
            conn.Open();
            String sql = "SELECT rod.auction as name ,count(rod.auction) as number FROM `rce_order_detail` rod " +
                         "join memo on(memo.memo_id = rod.rce_order_id) " +
                         "where memo.trade_flg = 'U' and rod.auction_date >= CURRENT_DATE() and rod.listing_slip_id is null " +
                         "group by rod.auction";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            conn.Close();
            return da;

        }

        public MySqlDataAdapter listingInfoGet(string auctionName)
        {
            MySqlConnection conn = DBManager.getConection();
            conn.Open();
            String sql = "SELECT rod.auction ,rod.auction_date,rod.auction_no,rod.car_name,rod.model_year,rod.model,rod.grade,rod.quote_price,rod.rce_order_id,rod.rce_order_detail_id FROM `rce_order_detail` rod " +
                         "join memo on (memo.memo_id = rod.rce_order_id) " +
                         "where memo.trade_flg = 'U' and rod.auction_date >= CURRENT_DATE() and rod.auction ='" + auctionName + "' and rod.listing_slip_id is null";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            conn.Close();
            return da;
        }

        public void insertListing()
        {
            MySqlConnection conn = DBManager.getConection();
            conn.Open();
            String sql = "INSERT INTO listing values()";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            conn.Close();
            DataTable dt = new DataTable();
            da.Fill(dt);
        }

        public int maxListingIdGet()
        {
            MySqlConnection conn = DBManager.getConection();
            conn.Open();
            String sql = "SELECT max(listing_slip_id) as id from listing";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            conn.Close();
            DataTable dt = new DataTable();
            da.Fill(dt);
            return Convert.ToInt32(dt.Rows[0]["id"]);
        }
        public void updatePurchaseIdRceOrderDetail(String orderId, int detailId, int listingId)
        {
            MySqlConnection conn = DBManager.getConection();
            conn.Open();
            String sql = "update rce_order_detail set listing_slip_id = " + listingId + " where rce_order_id = '" + orderId + "' and rce_order_detail_id = " + detailId + "";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            conn.Close();
            DataTable dt = new DataTable();
            da.Fill(dt);
        }
    }

    public class AuctionKanri
    {
        //オークション計算書Select
        public DataTable auctionSelect(String auction_name, String auction_date)
        {
            MySqlConnection conn = DBManager.getConection();
            conn.Open();
            String sql = "select rce_order_detail.rce_order_id,rce_order_detail.rce_order_detail_id,rce_order_detail.auction_no,rce_order_detail.car_name,rce_order_detail.model_year,rce_order_detail.model,rce_order_detail.grade, case memo.trade_flg when 'U' then '売' when 'K' then '買' end from rce_order_detail join memo on memo.memo_id=rce_order_detail.rce_order_id left join sales on rce_order_detail.sales_id=sales.sales_id where auction='" + auction_name + "' and auction_date='" + auction_date + "' and rce_order_detail.sales_id is null";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;

        }

        //売上Insert
        public void saleInsert(String auctionname,int price,int fee,int charge)
        {
            MySqlConnection conn = DBManager.getConection();
            conn.Open();
            String sql = "insert into sales (supplier_sales_target_info,sales_stocking_price,fee,expenses_charge,sales_stocking_days) values ('"+auctionname+"',"+price+","+fee+","+charge+",CURRENT_DATE())";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();


        }

        //受注明細の売上ID更新
        public void rcedetailSaleIdUpdate(String id,int detailid,String trade)
        {
            MySqlConnection conn = DBManager.getConection();
            conn.Open();
            string sql;
            if (trade == "買")
            {
                sql = "update rce_order_detail set sales_id=(select max(sales_id) from sales),buy_progress_flag = 2 where rce_order_id='" + id + "' and rce_order_detail_id=" + detailid;

            }
            else
            {
                sql = "update rce_order_detail set sales_id=(select max(sales_id) from sales) where rce_order_id='" + id + "' and rce_order_detail_id=" + detailid;

            }
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();


        }


    }

    public class DeliveryKanri
    {
        public MySqlDataAdapter deloveryInfoGet(string CustomerCode)
        {
            MySqlConnection conn = DBManager.getConection();
            conn.Open();
            String sql = "SELECT rod.*,sales.*,customer.* FROM `rce_order_detail` rod "+
                         "join memo on (memo.memo_id = rod.rce_order_id) "+
                         "join sales using (sales_id) "+
                         "join customer on(left(rce_order_id, 3) = customer_id) "+
                         "where memo.trade_flg = 'K' and buy_progress_flag=2 and left(rce_order_id,3) = '" + CustomerCode + "'";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            conn.Close();
            return da;
        }

        public void buyFlagUpdate(string CustomerCode)
        {
            MySqlConnection conn = DBManager.getConection();
            conn.Open();
            String sql = "update rce_order_detail as rod join memo on(memo.memo_id = rod.rce_order_id) " +
                         "set buy_progress_flag = 3 where memo.trade_flg = 'K' and buy_progress_flag = 2 and left(rce_order_id,3) = '" + CustomerCode + "'";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
        }

    }



}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

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

}

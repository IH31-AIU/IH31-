using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace IH31_CP_Projects
{
    class Received
    {
        //見積書を探すやつ
        public MySqlDataAdapter EstimateSearch(string id) {
            MySqlConnection conn = DBManager.getConection();
            conn.Open();
            String sql = "SELECT memo_id,quote_detail_id,abb_name,mail_address,car_name,model,grade,memo_info,quote_price FROM memo"
                        + " inner join quote on quote.quote_id = memo_id"
                        + " inner join customer on customer_id = substr(memo_id, 1, 3)"
                        + " inner join quote_item on memo_id = quote_item.quote_id"
                        + " Left join rce_order on rce_order_id = quote.quote_id"
                        + " WHERE " + id + " = responsible_employee_id and rce_order_id is null";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            conn.Close();
            return da;
        }

        /**
         * List<String[]> String[]={quote_id,quote_detail_id}
         * 
         * 見積もり明細をidを指定して取得するメソッド
         */
        public MySqlDataAdapter QuiteItem(List<String[]> Ids)
        {
            if(1 <= Ids.Count())
            {

                MySqlConnection conn = DBManager.getConection();
                conn.Open();
                String sql = "select * from quote_item";
                for(int i=0; i < Ids.Count(); i++)
                {
                    if(i == 0)
                    {
                        sql += " where (quote_id = '" + Ids[i][0] + "'";
                        sql += " and quote_detail_id = " + Ids[i][1] + ")";
                    }
                    else
                    {
                        sql += " or (quote_id = '" + Ids[i][0] + "'";
                        sql += " and quote_detail_id = " + Ids[i][1] + ")";
                    }

                }
                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                conn.Close();
                return da;
            }
            return null;
        }
        public MySqlDataAdapter limitPrice(string id)
        {
            MySqlConnection conn = DBManager.getConection();
            conn.Open();
            string sql = "SELECT credit_limit_price-sum(`sales_stocking_price`+`expenses_charge`+`fee`+`supplier_sales_target_info`-`clearing_price`) FROM `sales`"
                        + " inner join rce_order_detail on rce_order_detail.sales_id = sales.sales_id"
                        + " inner join customer on customer_id = substr(rce_order_id, 1, 3)"
                        + " where customer_id = '"+id+"'" 
                        + " Group by customer_id;";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            conn.Close();
            return da;
        }
    }
}

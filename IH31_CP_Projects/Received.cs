using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;



namespace IH31_CP_Projects
{
    class Received
    {
        //見積書を探すやつ
        public MySqlDataAdapter EstimateSearch(string id) {
            MySqlConnection conn = DBManager.getConection();
            conn.Open();
            String sql = "SELECT quote.quote_id,abb_name FROM memo"
                        + " inner join quote on quote.quote_id = memo_id"
                        + " inner join customer on customer_id = substr(memo_id, 1, 3)"
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
        public MySqlDataAdapter QuiteItem(String Ids)
        {
            MySqlConnection conn = DBManager.getConection();
            conn.Open();
            String sql = "select `quote_id`, `quote_detail_id`, `model_year`, `car_name`, `model`, `grade`, `remarks`, `quote_price` from quote_item where quote_id ='" + Ids+"'";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            conn.Close();
            return da;
        }
        public MySqlDataAdapter limitPrice(string id)
        {
            MySqlConnection conn = DBManager.getConection();
            conn.Open();
            string sql = "SELECT credit_limit_price-ifnull(sum(`sales_stocking_price`+`expenses_charge`+`fee`+`supplier_sales_target_info`-`clearing_price`),0) FROM customer"
                            +" left join rce_order_detail on customer_id = substr(rce_order_id,1,3)"
                            +" left join sales on customer_id =substr(rce_order_id,1,3)"
                            +" where customer_id='"+id+"'"
                            +" Group by customer_id;";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            Console.WriteLine(sql);
            conn.Close();
            return da;
        }

        public MySqlDataAdapter componyName(string id)
        {
            MySqlConnection conn = DBManager.getConection();
            conn.Open();
            id = id.Substring(0, 3);
            string sql = "select formal_company_name from customer"
                        +" where customer_id ='"+id+"'";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            conn.Close();
            return da;
        }

        public void rceInsert(string id,string pdf,List<string[]> rceDetail)
        {
            MySqlConnection conn = DBManager.getConection();
            conn.Open();
            string sql = "insert into rce_order (rce_order_id,rce_order_date,rce_order_pdf_path)"
                        + " values('" + id + "','" + DateTime.Now.Year+"-"+DateTime.Now.Month+"-"+DateTime.Now.Day + "','" + pdf + "')";
            string datailSql = "INSERT INTO `rce_order_detail`(`rce_order_id`, `rce_order_detail_id`, `model_year`, `car_name`, `model`, `grade`, `remarks`, `quote_price`) value";
            for(int i = 0; i < rceDetail.Count; i++)
            {
                if(i != 0)
                {
                    datailSql += ",";
                }
                datailSql += " ('" + id + "','" + rceDetail[i][0] + "','" + rceDetail[i][1] + "','" + rceDetail[i][2] + "','" + rceDetail[i][3] + "','" + rceDetail[i][4] + "','" + rceDetail[i][5] + "','" + rceDetail[i][6] + "')";
            }
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            da = new MySqlDataAdapter(datailSql, conn);
            da.Fill(dt);

        }

        public MySqlDataAdapter orderDetail(string id)
        {
            MySqlConnection conn = DBManager.getConection();
            conn.Open();
            string sql = "select rce_order_detail.* from rce_order_detail"
                        + " inner join memo on memo_id = rce_order_id"
                        + " where responsible_employee_id ='" + id + "'";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            conn.Close();
            return da;
        }

        public void updateOrder(string no, string date, string name,string id,string detail)
        {
            MySqlConnection conn = DBManager.getConection();
            conn.Open();
            DateTime time = DateTime.Parse(date);
            string sql = "update rce_order_detail set auction='" + name + "' ,auction_date='" + time.Year+"-"+time.Month+"-"+time.Day + "' ,auction_no=" + no
                        +" where rce_order_id ='"+id+"' and"+" rce_order_detail_id='"+detail+"'";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            conn.Close();
            DataTable dt = new DataTable();
            da.Fill(dt);
        }

        public MySqlDataAdapter orderDetailWhere(string id,string flg)
        {
            MySqlConnection conn = DBManager.getConection();
            conn.Open();
            string sql = "select * from rce_order_detail"
                        + " inner join memo on memo_id = rce_order_id"
                        + " where responsible_employee_id ='" + id + "'"
                        + " and trade_flg='"+flg+"'";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            conn.Close();
            return da;
        }

        public MySqlDataAdapter customer(string sql)
        {
            MySqlConnection conn = DBManager.getConection();
            conn.Open();

            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            conn.Close();
            return da;
        }

        public List<string> updateSales(string id, int price)
        {

            MySqlConnection conn = DBManager.getConection();
            conn.Open();
            string select = "SELECT sales.`sales_id`, `supplier_sales_target_info`, `sales_stocking_price`, `fee`, `expenses_charge`, `clearing_price`, `sales_stocking_days` ,`sales_stocking_price`+`fee`+`expenses_charge` as total,`sales_stocking_price`+`fee`+`expenses_charge`-`clearing_price` as nokori"
                            +" FROM `sales`"
                            +" inner join rce_order_detail on rce_order_detail.`sales_id`= sales.`sales_id`"
                            +" WHERE substr(`rce_order_id`, 1, 3)= '"+id+"'  and `sales_stocking_price`+`fee`+`expenses_charge`-`clearing_price`<> 0"
                            + " order by nokori";
            MySqlDataAdapter da = new MySqlDataAdapter(select, conn);
            DataTable selectDt = new DataTable();
            conn.Close();
            da.Fill(selectDt);

            List<string> update = new List<string>();
            string salesId = "";
            int crearing_price = 0;
            if (selectDt.Rows.Count != 0)
            {
                for (int i = 0; i < selectDt.Rows.Count; i++)
                {
                    int nokori = Convert.ToInt32(selectDt.Rows[i]["nokori"]);
                    if (price > nokori)
                    {
                        crearing_price = Convert.ToInt32(selectDt.Rows[i]["total"]);
                        salesId = selectDt.Rows[i]["sales_id"].ToString();
                        update.Add("update sales set clearing_price=" + crearing_price + " where sales_id=" + salesId);
                        price -= crearing_price;
                    }
                    else if (price <= nokori)
                    {
                        crearing_price = Convert.ToInt32(selectDt.Rows[i]["clearing_price"]);
                        salesId = selectDt.Rows[i]["sales_id"].ToString();
                        update.Add("update sales set clearing_price=" + price + crearing_price + " where sales_id=" + salesId);
                        price -= nokori;
                        break;
                    }

                }
                if (0 < price)
                {
                    update.Add("update sales set clearing_price=" + price + crearing_price + " where sales_id=" + salesId);
                }
            }
            return update;

        }
    }
}

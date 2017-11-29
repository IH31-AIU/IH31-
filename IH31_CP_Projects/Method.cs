using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;



namespace IH31_CP_Projects
{
    public class Method
    {


        //顧客探す奴
        public MySqlDataAdapter CustomertSearch(String customername) {
            MySqlConnection conn = DBManager.getConection();
            conn.Open();
            String sql = "select customer_id,customer_verid,mail_address,formal_company_name,abb_name,phone_number,address from customer where abb_name like '%" + customername + "%'";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            conn.Close();
            return da;

        }

        public MySqlDataAdapter purchaseSearch()
        {
            MySqlConnection conn = DBManager.getConection();
            conn.Open();
            String sql = "SELECT rod.auction as name ,count(rod.auction) as number FROM `rce_order_detail` rod " +
                         "join memo on(memo.memo_id = rod.rce_order_id) " +
                         "where memo.trade_flg = 'K' and rod.auction_date >= CURRENT_DATE() " +
                         "group by rod.auction";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            conn.Close();
            return da;

        }



    }

    public class Customer
    {
        private String customercode;
        private String customername;

        //CustomerCodeセット
        public void CustomerCodeSet(String value)
        {
            customercode = value;

        }
        //CustomerCodeゲット
        public String CustomerCodeGet()
        {
            return customercode;
        }

        //CustomerNameセット
        public void CustomerNameSet(String value)
        {
            customername = value;

        }
        //CustomerNameゲット
        public String CustomerNameGet()
        {
            return customername;
        }



    }

    public class Auction{
        private string[] auctionName = {
                                            "オークション会場A",
                                            "オークション会場B",
                                            "オークション会社C"
                                        };
        public string[] auctionNameGet()
        {
            return auctionName;
        }
    }




}

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

        //メモID最大値取得
        public MySqlDataAdapter memoIDMax(String customercode)
        {
            MySqlConnection conn = DBManager.getConection();
            conn.Open();
            String sql = "SELECT max(substr(memo_id,4,7))+1 FROM memo where memo_id like '%"+customercode+"%'";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            conn.Close();
            return da;

        }
        
        //メモInsert
        public void memoInsert(String memoid,String memoinfo,String tradeflg)
        {
            MySqlConnection conn = DBManager.getConection();
            conn.Open();
            String sql = "INSERT INTO memo (memo_id, memo_info, date,trade_flg, responsible_employee_id) VALUES ('"+memoid+"','"+memoinfo+"',CURRENT_TIMESTAMP,'"+tradeflg+"', NULL)";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            

        }

        //ログイン
        public MySqlDataAdapter login(String mailaddress,String pass)
        {
            MySqlConnection conn = DBManager.getConection();
            conn.Open();
            String sql = "select employee_id,name from employee where mail_address='"+mailaddress+"'&& password='"+pass+"'";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            conn.Close();
            return da;
            

        }

        //担当未決定メモ取得
        public MySqlDataAdapter memoSlect()
        {
            MySqlConnection conn = DBManager.getConection();
            conn.Open();
            String sql = "select memo.memo_id,customer.abb_name,memo.date from memo,customer where memo.responsible_employee_id is null && substr(memo_id,1,3)=customer.customer_id";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            conn.Close();
            return da;


        }

        //指定メモ取得
        public MySqlDataAdapter memoSlectOne(String memoid)
        {
            MySqlConnection conn = DBManager.getConection();
            conn.Open();
            String sql = "select memo.memo_id,customer.abb_name,memo.date,memo.trade_flg,memo.memo_info from memo,customer where substr(memo_id,1,3)=customer.customer_id && memo.memo_id='"+memoid+"'";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            conn.Close();
            return da;


        }

        //メモ担当決定
        public void memoChange(String employeeid,String memoid)
        {
            MySqlConnection conn = DBManager.getConection();
            conn.Open();
            String sql = "update memo set responsible_employee_id='"+employeeid+"'where memo_id='"+memoid+"'";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();


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

    public class Loginstr
    {
        private String employeeid;
        private String employeename;

        //employeeidセット
        public void employeeIdSet(String value)
        {
            employeeid = value;

        }
        //employeeidゲット
        public String employeeIdGet()
        {
            return employeeid;
        }

        //employeeNameセット
        public void employeeNameSet(String value)
        {
            employeename = value;

        }
        //employeeNameゲット
        public String employeeNameGet()
        {
            return employeename;
        }

 


    }










}

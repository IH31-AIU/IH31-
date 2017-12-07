using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace IH31_CP_Projects
{
    class Quote
    {
        
        //顧客探す奴
        public MySqlDataAdapter CustomertSearch(String customername)
        {
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
            String sql = "SELECT max(substr(memo_id,4,7))+1 FROM memo where memo_id like '%" + customercode + "%'";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            conn.Close();
            return da;

        }

        //メモInsert
        public void memoInsert(String memoid, String memoinfo, String tradeflg)
        {
            MySqlConnection conn = DBManager.getConection();
            conn.Open();
            String sql = "INSERT INTO memo (memo_id, memo_info, date,trade_flg, responsible_employee_id) VALUES ('" + memoid + "','" + memoinfo + "',CURRENT_TIMESTAMP,'" + tradeflg + "', NULL)";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();


        }

        //ログイン
        public MySqlDataAdapter login(String mailaddress, String pass)
        {
            MySqlConnection conn = DBManager.getConection();
            conn.Open();
            String sql = "select employee_id,name from employee where mail_address='" + mailaddress + "'&& password='" + pass + "'";
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
            String sql = "select memo.memo_id,customer.abb_name,memo.date,memo.trade_flg,memo.memo_info from memo,customer where substr(memo_id,1,3)=customer.customer_id && memo.memo_id='" + memoid + "'";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            conn.Close();
            return da;


        }

        //メモ担当決定
        public void memoChange(String employeeid, String memoid)
        {
            MySqlConnection conn = DBManager.getConection();
            conn.Open();
            String sql = "update memo set responsible_employee_id='" + employeeid + "'where memo_id='" + memoid + "'";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        //見積もりまだのやつメモ取得
        public MySqlDataAdapter memoSelectNoQuote()
        {
            MySqlConnection conn = DBManager.getConection();
            conn.Open();
            String sql = "select  a.memo_id,a.abb_name,a.date,a.name,a.trade_flg from (select memo.memo_id,customer.abb_name,memo.date,memo.trade_flg,memo.memo_info ,employee.name from memo,customer,employee where substr(memo_id,1,3)=customer.customer_id && memo.responsible_employee_id=employee.employee_id) as a left join quote on quote.quote_id=a.memo_id where quote.quote_id is null";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            conn.Close();
            return da;

        }

        //見積明細連番最大値取得
        public MySqlDataAdapter quoteDetailIdMax(String memoid)
        {
            MySqlConnection conn = DBManager.getConection();
            conn.Open();
            String sql = "select max(quote_detail_id) from quote_item where quote_id='" + memoid + "'";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            conn.Close();
            return da;

        }

        //見積明細Insert
        public void quote_ItemInsert(String id, int detail_id, String year,String carname,String model,String grade,String other,int price)
        {
            MySqlConnection conn = DBManager.getConection();
            conn.Open();
            String sql = "insert into quote_item values('"+id+"','"+detail_id+"','"+year+"','"+carname+"','"+model+"','"+grade+"','"+other+"',"+price+")";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();


        }

        //指定見積もり明細取得
        public MySqlDataAdapter quoteDetailSeleceOne(String memoid)
        {
            MySqlConnection conn = DBManager.getConection();
            conn.Open();
            String sql = "select quote_id,quote_detail_id,model_year,car_name,model,grade,quote_price from quote_item where quote_id='" + memoid + "'";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            conn.Close();
            return da;

        }

        //見積Insert
        public void quoteInsert(String id)
        {
            MySqlConnection conn = DBManager.getConection();
            conn.Open();
            String sql = "insert into quote (quote_id) values('" + id + "')";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();


        }

        //正式顧客名取得
        public String customerNameSelect(String abb_name)
        {
            MySqlConnection conn = DBManager.getConection();
            conn.Open();
            String sql = "select formal_company_name from customer where abb_name='" + abb_name + "'";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            String formal_name="";
            try
            {
                formal_name=dt.Rows[0][0].ToString();
            }
            catch
            {
                formal_name = "";
            }

            conn.Close();
            return formal_name;

        }

    }

    public class Memo
    {
        private String memoid;
        private String customername;
        private String employeename;
        private String tradeFlag;
        

        //memoidセット
        public void memoIdSet(String value)
        {
            memoid = value;

        }
        //memoidゲット
        public String memoIdGet()
        {
            return memoid;
        }

        //customernameセット
        public void customerNameSet(String value)
        {
            customername = value;

        }
        //customernameゲット
        public String customerNameGet()
        {
            return customername;
        }

        //employeenameセット
        public void employeeNameSet(String value)
        {
           employeename = value;

        }
        //employeenameゲット
        public String employeeNameGet()
        {
            return employeename;
        }

        public void tradeFlagSet(String value)
        {
            tradeFlag = value;
        }
        public String tradeFlagGet()
        {
            return tradeFlag;
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

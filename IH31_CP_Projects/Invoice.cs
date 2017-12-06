using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using testEW;

namespace IH31_CP_Projects
{
    class Invoice
    {
        //企業ごとの請求額表示
        public MySqlDataAdapter invoiceSelect(String date)
        {
            MySqlConnection conn = DBManager.getConection();
            conn.Open();
            String sql = "select customer_id,formal_company_name,sum(sales_stocking_price + fee + expenses_charge - clearing_price) from sales join rce_order_detail as rod using(sales_id) join customer as c on(left(rce_order_id,3) = customer_id) where sales_stocking_price + fee + expenses_charge - clearing_price <> 0 and sales.sales_stocking_days<= '"+date+"' group by left(rce_order_id,3)";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            conn.Close();
            return da;

        }

        //ひとつの企業請求額
        public MySqlDataAdapter invoiceSelectOne(String date,String customercode)
        {
            MySqlConnection conn = DBManager.getConection();
            conn.Open();
            String sql = "select rce_order_detail.car_name,sales.sales_stocking_price,sales.fee,sales.expenses_charge,sales.sales_stocking_price+fee+expenses_charge-sales.clearing_price,sales.clearing_price from sales join rce_order_detail on rce_order_detail.sales_id=sales.sales_id where sales.sales_stocking_price+sales.fee+sales.expenses_charge-sales.clearing_price <> 0 and sales.sales_stocking_days<='" + date + "' and  substr(rce_order_id,1,3)='" + customercode + "'";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            Console.WriteLine(sql);
            conn.Close();
            return da;

        }


    }
}

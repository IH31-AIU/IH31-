using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;



namespace IH31_CP_Projects
{
    public class Customer
    {
        private String customercode;

        //顧客探す奴
        public MySqlDataAdapter CustomertSearch(String customername) {
            MySqlConnection conn=DBManager.getConection();
            conn.Open();
            String sql = "select customer_id,customer_verid,mail_address,formal_company_name,abbreviation_name,phone_number,address from customer where abbreviation_name like '%"+ customername + "%'";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            conn.Close();
            return da;

        }

        //CustomerCodeセット
        public void CustomerCodeSet(String ccode)
        {
            customercode = ccode;
           
        }
        //CustomerCodeゲット
        public String CustomerCodeGet()
        {
            return customercode;
        }

    }




}

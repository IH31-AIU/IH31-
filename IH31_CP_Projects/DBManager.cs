using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace IH31_CP_Projects
{
    class DBManager
    {
        private static String Constr = "SERVER=bashio777.f5.si;DATABASE=ih;UiD=root; PASSWORD=Yuuya6618;CHARSET=utf8";


        public static MySqlConnection getConection()
        {
           
            MySqlConnection conn = null;

            try
            {
               conn = new MySqlConnection(Constr);

            }
            catch (Exception e)
            {

            }

            return conn;

        }
    }
}

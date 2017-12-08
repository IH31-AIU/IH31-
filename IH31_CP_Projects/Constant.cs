using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;



namespace IH31_CP_Projects
{


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

    public class Path
    {
        public const string araki = "C:\\Users\\yuki\\Desktop\\IH";
        public const string ueda = "";
        public const string ishibashi = "C:\\Users\\yuuya\\Desktop\\IH";
        public const string path = ishibashi; 
    }
}

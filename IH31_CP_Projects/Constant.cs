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

   










}

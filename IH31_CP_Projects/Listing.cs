using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace IH31_CP_Projects
{
    public partial class Listing : Form
    {
        ListingKanri lk = new ListingKanri();
        public Listing()
        {
            InitializeComponent();
            MySqlDataAdapter da = lk.listingSearch();
            DataTable dt = new DataTable();
            da.Fill(dt);
            auctionList.AllowUserToAddRows = false;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                auctionList.Rows.Add();
                auctionList.Rows[i].Cells[0].Value = false;
                auctionList.Rows[i].Cells[1].Value = dt.Rows[i]["name"];
                auctionList.Rows[i].Cells[2].Value = dt.Rows[i]["number"];

            }
        }
    }
}

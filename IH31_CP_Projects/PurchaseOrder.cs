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
    public partial class PurchaseOrder : Form
    {
        Method method = new Method();
        public PurchaseOrder()
        {
            InitializeComponent();
            Method method = new Method();
            MySqlDataAdapter da = method.purchaseSearch();
            DataTable dt = new DataTable();
            da.Fill(dt);
            auctionList.AllowUserToAddRows = false;
            for ( int i= 0; i< dt.Rows.Count; i++)
            {
                auctionList.Rows.Add();
                auctionList.Rows[i].Cells[1].Value = dt.Rows[i]["name"];
                auctionList.Rows[i].Cells[2].Value = dt.Rows[i]["number"];
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}

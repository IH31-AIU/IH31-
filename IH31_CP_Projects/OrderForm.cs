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
using System.Text.RegularExpressions;

namespace IH31_CP_Projects
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void search_Click(object sender, EventArgs e)
        {
            EstimateSharch estimate = new EstimateSharch();
            estimate.ShowDialog();
            List<string[]> ids = estimate.Ids;
            Received receive = new Received();
            MySqlDataAdapter item = receive.QuiteItem(ids);
            if (item != null)
            {
                DataTable dt = new DataTable();
                item.Fill(dt);
                DvItem.DataSource = dt;
            }

            int price = 0;

            for (int i = 0; i < DvItem.RowCount; i++)
            {
                if (DvItem[7, i].Value == null){continue;}
                price += int.Parse(DvItem[7, i].Value.ToString()); 
            }
            LbPrice.Text = "合計"+price +"円";
        }

        private void btCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (DvItem.Rows[0].Cells[0].Value != null)
                {
                    string id = DvItem.Rows[0].Cells[0].Value.ToString();
                    id = id.Substring(0, 3);
                    Received received = new Received();
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = received.limitPrice(id);
                    da.Fill(dt);
                    string lbprice = LbPrice.Text.ToString();
                    Regex re = new Regex(@"[^0-9]");
                    string price = re.Replace(lbprice, "");
                    if (int.Parse(price) < int.Parse(dt.Rows[0][0].ToString()))
                    {

                    }
                    else
                    {
                        MessageBox.Show("売掛金が不足しています。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch(Exception ex)
            {

            }
        }
    }
}

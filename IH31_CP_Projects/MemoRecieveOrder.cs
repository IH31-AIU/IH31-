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
    public partial class MemoRecieveOrder : Form
    {
        Quote quote = new Quote();
       

        public MemoRecieveOrder()
        {
            InitializeComponent();
            DvMemo.AllowUserToAddRows = false;
            MySqlDataAdapter da = quote.memoSlect();
            DataTable dt = new DataTable();
            da.Fill(dt);
            DvMemo.DataSource = dt;
            DvMemo.Columns[0].HeaderText = "メモID";
            DvMemo.Columns[1].HeaderText = "会社名";
            DvMemo.Columns[2].HeaderText = "日付";

        }

        private void cell_click(object sender, DataGridViewCellMouseEventArgs e)
        {
            String memoid = DvMemo.CurrentRow.Cells["memo_id"].Value.ToString();
            MemoDetail memodetail = new MemoDetail(memoid);
           
            memodetail.ShowDialog();
            MySqlDataAdapter da = quote.memoSlect();
            DataTable dt = new DataTable();
            da.Fill(dt);
            DvMemo.DataSource = dt;
        }



    }
}

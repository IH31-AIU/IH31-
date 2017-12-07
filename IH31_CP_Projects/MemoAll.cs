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
    public partial class MemoAll : Form
    {
        Memo memo;
        Quote quote = new Quote();

        public MemoAll(Memo memo)
        {
            InitializeComponent();
            this.memo = memo;
            MySqlDataAdapter da = quote.memoSelectNoQuote();
            DataTable dt = new DataTable();
            da.Fill(dt);
            DvMemo.DataSource = dt;
            DvMemo.AllowUserToAddRows = false;
            DvMemo.Columns[0].HeaderText = "メモID";
            DvMemo.Columns[1].HeaderText = "会社名";
            DvMemo.Columns[2].HeaderText = "日付";
            DvMemo.Columns[3].HeaderText = "担当者";
            DvMemo.Columns[4].HeaderText = "売買";



        }

        private void cell_doubleclick(object sender, DataGridViewCellEventArgs e)
        {
            String memoid = DvMemo.CurrentRow.Cells["memo_id"].Value.ToString();
            String customername = DvMemo.CurrentRow.Cells["abb_name"].Value.ToString();
            String employeename = DvMemo.CurrentRow.Cells["name"].Value.ToString();
            String tradeFlag = DvMemo.CurrentRow.Cells["trade_flg"].Value.ToString();


            memo.memoIdSet(memoid);
            memo.customerNameSet(customername);
            memo.employeeNameSet(employeename);
            memo.tradeFlagSet(tradeFlag);
            this.Close();
        }






    }
}

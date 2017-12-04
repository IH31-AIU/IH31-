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
    public partial class MemoDetail : Form
    {
        Quote quote = new Quote();
        public MemoDetail(String memoid)
        {
            InitializeComponent();
            MySqlDataAdapter da = method.memoSlectOne(memoid);
            DataTable dt = new DataTable();
            da.Fill(dt);
            String memo_id=dt.Rows[0][0].ToString();
            String customername=dt.Rows[0][1].ToString();
            String date=dt.Rows[0][2].ToString();
            String trade_flg=dt.Rows[0][3].ToString();
            if (trade_flg.Equals("U"))
            {
                sflg.Checked = true;
            }
            else
            {
                pflg.Checked = true;
            }
            String memoinfo=dt.Rows[0][4].ToString();

            Tbmemo.Text = memo_id;
            TbCustomerName.Text = customername;
            TbDate.Text = date;
            TbMemoDetail.Text = memoinfo;

        }

        private void BtClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtSubmit_Click(object sender, EventArgs e)
        {
            String employeeid = "1";
            method.memoChange(employeeid, Tbmemo.Text);
            DialogResult Res;
            Res = MessageBox.Show("処理が完了しました", "確認", MessageBoxButtons.OK);
            if (Res == DialogResult.OK)
            {
                this.Close();
            }
        }


    }
}
